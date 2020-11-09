Imports DevExpress.XtraEditors
Imports System.ComponentModel
Public Class AccountSelector
    Public DT_AccountManager As DataTable = New DataTable
    Public QureyShortName As String

    Private Sub AccountSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        DT_AccountManager.Clear()
        Try
            'DT Account Mananger
            DT_AccountManager.Columns.Add("Username")
            DT_AccountManager.Columns.Add("Password")
            DT_AccountManager.Columns.Add("Status")
            DT_AccountManager.Columns.Add("Proxy")
            DT_AccountManager.Columns.Add("Cookies")
            DT_AccountManager.Columns.Add("GroupName")
        Catch ex As Exception
        End Try

        'Dim rowsToDelete As String() = Controller.DT_Tweets.Rows.OfType(Of DataRow).Select(Function(k) k(5).ToString()).ToArray
        GridControl1.DataSource = DT_AccountManager





        Dim result() As DataRow = Controller.DT_AccountManager.Select("Status = '" & AccountAuthenticationStatus.authenticated & "'")


        For Each row As DataRow In result
            '  If rowsToDelete.Contains(row(0)) = False Then

            DT_AccountManager.Rows.Add({row(0), row(1), row(2), row(3), row(4), row(5)})
            ' End If

        Next
        If DT_AccountManager.Rows.Count = 0 Then
            XtraMessageBox.Show("لا يوجد حسابات للدعم , تنويه : الحسابات التي تم التغريد بها لايمكنك الدعم منها", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            If XtraMessageBox.Show("هل تود حفظ هذا الاعداد", "محدد الحسابات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim ListOfuser As New List(Of String)
                Dim ListOfTweets As New Dictionary(Of String, String)
                Dim QureyShortNameINNER As String

                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                Dim selectedTweets() As Integer = Controller.Grid_View_Twetting.GetSelectedRows()

                For Each rowHandle As Integer In selectedTweets
                    If rowHandle >= 0 Then
                        Dim TweetID As String = Controller.Grid_View_Twetting.GetRowCellValue(rowHandle, "ID").ToString
                        Dim TweetOwner As String = Controller.Grid_View_Twetting.GetRowCellValue(rowHandle, "UserName").ToString
                        ListOfTweets.Add(TweetID, TweetOwner)
                    End If
                Next


                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        Dim Username As String = GridView1.GetRowCellValue(rowHandle, "Username").ToString

                        ListOfuser.Add(Username)
                    End If
                Next
                QureyShortNameINNER = QureyShortName
                Dim n1, n2 As Integer
                n1 = num1.Value
                n2 = num2.Value

                Dim t As New BackgroundWorker

                t.WorkerSupportsCancellation = True
                AddHandler t.DoWork, Async Sub()
                                         Try


                                             Dim rand1, rand2 As Integer
                                             rand1 = n1
                                             rand2 = n2


                                             Dim accList As New List(Of String)
                                             Dim Tweetids As New Dictionary(Of String, String)

                                             Dim QNAME As String
                                             accList = ListOfuser
                                             Tweetids = ListOfTweets
                                             QNAME = QureyShortNameINNER
                                             QureyShortNameINNER = QureyShortName
                                             Dim TempObj As String
                                             Dim skkiip As Integer = 0
                                             Dim CountOfAccounts As Integer = ListOfuser.Count
                                             For Each CurrentAccount As String In ListOfuser
                                                 For Each TweetID In Tweetids
                                                     Dim twOBJ As New TwitterOBJECT(CurrentAccount, String.Empty, True)
                                                     twOBJ.taskID = t.GetHashCode()
                                                     TempObj = t.GetHashCode()
                                                     twOBJ.Delay_Min = rand1
                                                     twOBJ.Delay_Max = rand2
                                                     If twOBJ.isUserAuthnticted = True Then


                                                         twOBJ.CurrentAccount = CurrentAccount
                                                         twOBJ.QureyType = QureyShortName & " > " & TweetID.Key
                                                         twOBJ.taskID = t.GetHashCode()
                                                         If QureyShortNameINNER = QureyTypes.Q_Like Then
                                                             Await twOBJ.LikeTweetAsync(TweetID.Key, TweetID.Value)
                                                         ElseIf QureyShortNameINNER = QureyTypes.Q_Retweet Then
                                                             Await twOBJ.RetweetAsync(TweetID.Key)






                                                         End If



                                                     Else

                                                         Controller.MainInstance.DT_Tweeting_Report_Users.Rows.Add({TweetID, QureyShortName & " > " & TweetID.Key & " Error ", CurrentAccount})
                                                         Controller.MainInstance.ListBoxControl1.Items.Add("---Error--- >>>" & CurrentAccount & " >>>  Login Error")

                                                     End If



                                                     If CurrentWorkingTask.PIDS.Contains(TempObj) = False Then

                                                         For Each row As DataRow In Controller.MainInstance.DT_ListOfTasks.Rows
                                                             If row("ID").ToString() = TempObj Then
                                                                 Controller.MainInstance.Grid_Running_Tasks.BeginInvoke(New Action(Sub() row.Delete()))
                                                             End If
                                                         Next

                                                         Exit Sub


                                                     End If
                                                 Next


                                                 'If LoadedUsers.Count < 10 Then
                                                 '    Exit For
                                                 'End If


                                             Next
                                             For Each row As DataRow In Controller.MainInstance.DT_ListOfTasks.Rows
                                                 If row("ID").ToString() = t.GetHashCode Then
                                                     Controller.MainInstance.Grid_Running_Tasks.BeginInvoke(New Action(Sub() row.Delete()))
                                                 End If
                                             Next
                                         Catch ex As Exception
                                             Controller.MainInstance.ListBoxControl1.Items.Add("---Error--- >>>Loop : " & ex.Message)
                                         End Try
                                     End Sub

                Controller.TaskList.Add(t)
                Dim accounts As String = ""
                For Each accn As String In ListOfuser
                    accounts = accounts & accn & " "
                Next

                Controller.AddRowsToDT(Controller.DT_ListOfTasks, {t.GetHashCode, QureyShortNameINNER & " Tweets Task : " & ListOfuser.Count, TaskStatus.Ready, "accounts"})
                XtraMessageBox.Show("تم اضافة العمليه الي القائمه بنجاح", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If


        Catch ex As Exception
            Controller.MainInstance.ListBoxControl1.Items.Add("---Error--- >>>1 : " & ex.Message)
        End Try
    End Sub

    Private Sub SpinEdit1_Click(sender As Object, e As EventArgs) Handles SpinEdit1.Click
        Try

            If SpinEdit1.Value >= GridView1.RowCount Then
                GridView1.SelectAll()
            Else

                GridView1.SelectRange(0, SpinEdit1.Value)
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class