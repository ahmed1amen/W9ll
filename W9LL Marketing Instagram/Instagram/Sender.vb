Imports System.Threading.Tasks
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports InstagramApiSharp.API
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Imports InstagramApiSharp.Logger

Public Class frm_Sender
    Dim anotherInstance As IInstaApi
    Public DT_users As DataTable = New DataTable
    Public Property ListOfAccounts As New List(Of String)

    Private Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")

    Private Sub SelectRows(ByVal view As GridView, ByVal startRow As Integer, ByVal endRow As Integer)

        If startRow > -1 AndAlso endRow > -1 Then

            view.BeginSelection()

            view.ClearSelection()

            view.SelectRange(startRow, endRow)

            view.EndSelection()

        End If

    End Sub
    Async Function LoginByThisAccountAsync(ByVal accountname As String, ByVal min_delay As Integer, ByVal max_Delay As Integer) As Task(Of Boolean)
        Try


            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & accountname & ".dat", System.Text.Encoding.UTF8)
            anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).UseLogger(Logger).SetRequestDelay(RequestDelay.FromSeconds(min_delay, max_Delay)).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function GetRowAt(ByVal view As GridView, ByVal x As Integer, ByVal y As Integer) As Integer
        Return view.CalcHitInfo(New Point(x, y)).RowHandle
    End Function
    Private StartRowHandle As Integer = -1
    Private CurrentRowHandle As Integer = -1
    Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
    End Sub
    Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim newRowHandle As Integer = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
        If CurrentRowHandle <> newRowHandle Then
            CurrentRowHandle = newRowHandle
            SelectRows(TryCast(sender, GridView), StartRowHandle, CurrentRowHandle)
        End If
    End Sub
    Private Sub gridView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = -1
        CurrentRowHandle = -1
    End Sub
    Private Sub frm_Sender_Load(sender As Object, e As EventArgs) Handles Me.Load
        DT_users.Columns.Add("acc_name")
        DT_users.Columns.Add("acc_ID")
        DT_users.Columns.Add("acc_UserName")
        DT_users.Columns.Add("acc_messagestate")
        DT_users.Columns.Add("AccountUsed")
        Grid_Control_Following_Report.DataSource = DT_users

        AddHandler Grid_View_Following_Report.MouseUp, AddressOf gridView1_MouseUp
        AddHandler Grid_View_Following_Report.MouseMove, AddressOf gridView1_MouseMove
        AddHandler Grid_View_Following_Report.MouseDown, AddressOf gridView1_MouseDown




    End Sub
    Private Async Sub SimpleButton7_ClickAsync(sender As Object, e As EventArgs) Handles btn_Send.Click
        Try
            If num1.Value > num2.Value Then
                XtraMessageBox.Show("خطأ في تكوين العمليه الفاصل الزمني الرقم الاول اكبر من الثاني", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If num_row1.Value > num_row2.Value Then
                XtraMessageBox.Show("خطأ في تكوين العمليه ارقام الارسال", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            btn_Send.Enabled = False
            ProgWait.Visible = True
            Dim AccountName As String

            For RowHandle As Integer = num_row1.Value To num_row2.Value
                Dim usderid As String = Grid_View_Following_Report.GetRowCellValue(RowHandle, "acc_ID")
                Try

                    AccountName = Grid_View_Following_Report.GetRowCellValue(RowHandle, "AccountUsed")

                    If Await LoginByThisAccountAsync(AccountName, num1.Value, num2.Value) = True Then


                        Dim aaa = Await anotherInstance.MessagingProcessor.SendDirectTextAsync(usderid, Nothing, Txt_Messsge.Text)
                        If aaa.Succeeded Then
                            Grid_View_Following_Report.SetRowCellValue(RowHandle, "acc_messagestate", ".OK.")
                        Else
                            If aaa.Info.ResponseType = aaa.Info.ResponseType.Spam Then
                                Grid_View_Following_Report.SetRowCellValue(RowHandle, "acc_messagestate", "Error : " & aaa.Info.Message & " - Spam")
                            Else
                                Grid_View_Following_Report.SetRowCellValue(RowHandle, "acc_messagestate", "Error : " & aaa.Info.Message)
                            End If
                        End If
                        Dim randx As New Random
                        Dim delay As Integer = randx.Next(num1.Value, num2.Value) * 1000
                        Await Task.Delay(delay)
                    Else
                        Grid_View_Following_Report.SetRowCellValue(RowHandle, "acc_messagestate", "Error : Login")
                    End If
                Catch ex As Exception
                    Grid_View_Following_Report.SetRowCellValue(RowHandle, "acc_messagestate", "Error : " & ex.Message)
                End Try
            Next
            btn_loadaccounts.Enabled = True
            ProgWait.Visible = False
        Catch ex As Exception
            XtraMessageBox.Show("خطأ في تكوين العمليه" & vbNewLine & ex.Message, "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub loadDataGrid()
        For Each x As String In IO.File.ReadAllLines(XtraOpenFileDialog1.FileName, System.Text.Encoding.UTF8)
            Dim ss() As String = x.Split("*_*")
            If x.Contains("*_*") Then
                If x.Length > 10 Then
                    If ss(0) = "" Then
                    Else
                        DT_users.Rows.Add({ss(0), ss(2), ss(4)})
                    End If

                End If
            End If
        Next

        num_row1.Properties.MaxValue = DT_users.Rows.Count
        num_row2.Properties.MaxValue = DT_users.Rows.Count
        num_row2.Value = DT_users.Rows.Count


    End Sub
    Private Sub Grid_Control_Following_Report_MouseUp(sender As Object, e As MouseEventArgs) Handles Grid_Control_Following_Report.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_loadaccounts.Click
        If XtraOpenFileDialog1.ShowDialog = DialogResult.OK Then
            DT_users.Clear()
            loadDataGrid()
            btn_loadaccounts.Enabled = False
            btn_Send.Enabled = True
        End If
    End Sub
    Private Sub Btn_Rundom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Rundom.ItemClick
        ListOfAccounts.Clear()
        For Each rowx As DataRow In InstgramClient.DT_AccountManager.Rows
            ListOfAccounts.Add(rowx.Item(0))
        Next

        Dim rand As New Random
        Dim ind As Integer
        For Each row As DataRow In DT_users.Rows
            ind = rand.Next(0, ListOfAccounts.Count)
            row("AccountUsed") = ListOfAccounts(ind)
        Next
        PopupMenu1.HidePopup()



    End Sub
End Class