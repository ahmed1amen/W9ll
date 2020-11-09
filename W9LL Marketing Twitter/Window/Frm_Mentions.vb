Imports System.ComponentModel
Imports System.Threading
Imports DevExpress.XtraEditors

Public Class Frm_Mentions
    Public DT_Mentinos As DataTable
    Public DT_ScrappedUsers As DataTable
    Public Property QureyShortName As String
    Public Property TweetID As String
    Dim LoadedUsers() As String
    Private TaskID As String


    Public Sub InvokeData(ByVal rowhandle As Integer, ByVal Succced As String, ByVal Fult As String, ByVal total As String)
        '   Grid_View_Mentions.SetRowCellValue(rowhandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))
        Grid_Control_Mentions.Invoke(Sub()
                                         Grid_View_Mentions.SetRowCellValue(rowhandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))
                                         DT_Mentinos.Rows(1)("Status") = String.Format("{0}/{1} : {2}", Succced, Fult, total)
                                     End Sub)


    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization ~after~ the InitializeComponent() call.



        DT_Mentinos = New DataTable
        DT_ScrappedUsers = New DataTable

        DT_Mentinos.Columns.Add("Username")
        DT_Mentinos.Columns.Add("Status")

        DT_Mentinos.Columns.Add("Proxy")
        DT_Mentinos.Columns.Add("Cookies")


    End Sub
    Private Sub Frm_Mentions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DoubleBuffered = False
        TaskID = Me.GetHashCode()
        DT_ScrappedUsers = ScrapperDataTable_Control
        If DT_ScrappedUsers.Rows.Count = 0 Then
            Me.Close()
        End If

        LoadedUsers = DT_ScrappedUsers.Rows.OfType(Of DataRow).Select(Function(k) k(1).ToString()).ToArray()

        'DT_Mentinos.Rows.Add({"ahmedamen_t", "-"})
        'DT_Mentinos.Rows.Add({"engam2018", "-"})
        'DT_Mentinos.Rows.Add({"rakan48534479", "-"})
        'DT_Mentinos.Rows.Add({"w9ll21", "-"})
        Grid_Control_Mentions.DataSource = DT_Mentinos




        Dim result() As DataRow = Controller.DT_AccountManager.Select("Status = '" & AccountAuthenticationStatus.authenticated & "'")

        For Each row As DataRow In result

            DT_Mentinos.Rows.Add({row(0), "-", row(3), row(4)})

        Next
        Grid_Control_Mentions.DataSource = DT_Mentinos

        If DT_Mentinos.Rows.Count = 0 Then
            XtraMessageBox.Show("لا يوجد حسابات للدعم , تنويه : الحسابات التي تم التغريد بها لايمكنك الدعم منها", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Sub AXCASD(ByVal CurrentAccount As String, ByVal Part_OfUSERS As String(), ByVal RowHandle As Integer)

        Dim twOBJ As New TwitterOBJECT(CurrentAccount, "", True)
        twOBJ.taskID = TaskID
        Dim Fult As Integer = 0
        Dim Succced As Integer = 0
        twOBJ.Delay_Min = num1.Value
        twOBJ.Delay_Max = num2.Value

        Dim total As Integer = Part_OfUSERS.Count
        Dim tempraay As String() = Part_OfUSERS

        If twOBJ.isUserAuthnticted = True Then

            twOBJ.CurrentAccount = CurrentAccount
            twOBJ.QureyType = QureyShortName & " > " & TweetID
            twOBJ.taskID = TaskID

            While (Part_OfUSERS.Length <> 0)

                Dim CurrentUsers As String = String.Empty

                If Part_OfUSERS.Length >= 10 Then
                    tempraay = Part_OfUSERS.Take(10).ToArray
                    Part_OfUSERS = Part_OfUSERS.Skip(10).ToArray
                Else
                    tempraay = Part_OfUSERS
                    ReDim Part_OfUSERS(-1)
                End If
                For Each usrName As String In tempraay

                    CurrentUsers += "@" + usrName & " "

                Next
                If twOBJ.Comment_tweet(TweetID, CurrentUsers, RowHandle) = True Then
                    Succced += tempraay.Count
                Else
                    Fult += CurrentUsers.Count
                End If

                '  InvokeData(RowHandle, Succced, Fult, total)
                Grid_Control_Mentions.Invoke(New Action(Sub()
                                                            Grid_View_Mentions.SetRowCellValue(RowHandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))
                                                        End Sub))
                'DT_Mentinos.Rows(RowHandle)("Status") = String.Format("{0}/{1} : {2}", Succced, Fult, total)
                'ListBox1.Items.Add(String.Format("{0}/{1} : {2}", Succced, Fult, total) & "  " & CurrentAccount & "  " & RowHandle)
                tempraay = Part_OfUSERS
            End While











        End If

    End Sub
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        CurrentWorkingTask.PIDS += TaskID & " "
        Dim CountOfAccounts As Integer = Grid_View_Mentions.RowCount
        Dim skkiip As Integer = 0
        For rowHandle As Integer = 0 To Grid_View_Mentions.RowCount - 1
            Dim CurrentAccount As String = Grid_View_Mentions.GetRowCellValue(rowHandle, "Username").ToString
            Dim Han As Integer = rowHandle
            Dim status As String = Grid_View_Mentions.GetRowCellValue(rowHandle, "Status").ToString
            Dim rowhand As Integer = rowHandle
            Dim TragetdUser() = LoadedUsers

            Dim Part_OfUSERS As String()

            If LoadedUsers.Count <= 10 Then
                Part_OfUSERS = LoadedUsers
                '      twOBJ.Comment_tweet(TweetID, Part_OfUSERS, Me, xaswrrr)
                Dim CmThread2 As New Task(Sub()
                                              Dim Rowhan As Integer = Han
                                              AXCASD(CurrentAccount, Part_OfUSERS, Rowhan)
                                          End Sub)
                CmThread2.Start()
            Else

                Dim DvidedMod As Integer = LoadedUsers.Count Mod CountOfAccounts     'Check If Account And Mentions Have MOD               

                If DvidedMod = 0 Then 'IF MOD Zero ... Take From array means Equality 
                    skkiip = (LoadedUsers.Count / CountOfAccounts)
                Else         'IF MOD  NOT = Zero ... Take From array  + MOD  >> TO Make >> Equality 
                    skkiip = (LoadedUsers.Count / CountOfAccounts) + DvidedMod   '33
                End If

                Part_OfUSERS = LoadedUsers.Take(skkiip).ToArray
                LoadedUsers = LoadedUsers.Skip(skkiip).Take(LoadedUsers.Length - (skkiip)).ToArray
                CountOfAccounts -= 1

            End If

            Dim CmThread As New Task(Sub()
                                         Dim Rowhan As Integer = Han
                                         AXCASD(CurrentAccount, Part_OfUSERS, Rowhan)
                                     End Sub)

            '    Debug.WriteLine(String.Format("{0}  = {1}", String.Join("; ", Part_OfUSERS), Part_OfUSERS.Count))
            CmThread.Start()

        Next



    End Sub
End Class