Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Public Class Insta_Mulit_Commnet
    Dim dt_Comments As New DataTable
    Dim anotherInstance
    Public mediaid As String
    Public Sub New()
        InitializeComponent()
        Me.dt_Comments.Columns.Add("Comment")
        Me.dt_Comments.Columns.Add("acc_UserName")
        Me.dt_Comments.Columns.Add("Status")
        Grid_Control_Comments.DataSource = dt_Comments
    End Sub
    Private Sub Btn_OpenCommentFile_Click(sender As Object, e As EventArgs) Handles Btn_OpenCommentFile.Click
        If Opn_filedialog.ShowDialog = DialogResult.OK Then
            For Each Commnet_txt As String In IO.File.ReadAllLines(Opn_filedialog.FileName, System.Text.Encoding.UTF8)
                dt_Comments.Rows.Add({Commnet_txt})
            Next
        End If
    End Sub
    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        Process.Start(HyperlinkLabelControl1.Text)
    End Sub
    Private Sub Grid_Control_Comments_MouseUp(sender As Object, e As MouseEventArgs) Handles Grid_Control_Comments.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub Combo_Accounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Accounts.SelectedIndexChanged
        Dim editor As ComboBoxEdit = sender
        Dim selectedRows() As Integer = Grid_View_Comments.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                Grid_View_Comments.SetRowCellValue(rowHandle, "acc_UserName", editor.SelectedItem)
            End If
        Next
        PopupMenu1.HidePopup()
        btn_startCommenting.Enabled = True
    End Sub
    Private Sub Btn_randall_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_randall.ItemClick
        Dim rand As New Random
        Dim ind As Integer
        For Each row As DataRow In dt_Comments.Rows
            ind = rand.Next(0, Combo_Accounts.Items.Count)
            row("acc_UserName") = Combo_Accounts.Items.Item(ind)
        Next
        PopupMenu1.HidePopup()
        btn_startCommenting.Enabled = True
    End Sub
    Async Function LoginByThisAccountAsync(ByVal accountname As String, ByVal min_delay As Integer, ByVal max_Delay As Integer) As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & accountname & ".dat", System.Text.Encoding.UTF8)
            anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).SetRequestDelay(RequestDelay.FromSeconds(min_delay, max_Delay)).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Async Sub btn_startCommenting_ClickAsync(sender As Object, e As EventArgs) Handles btn_startCommenting.Click
        If num2.Value > num1.Value Then
            btn_startCommenting.Enabled = False
            mediaid = mediaid.Replace("?id=", "")
            Dim comment As String
            Dim AccountName As String
            Dim commentAction
            For Each row As DataRow In dt_Comments.Rows
                AccountName = row("acc_UserName").ToString
                comment = row("Comment").ToString
                If Await LoginByThisAccountAsync(AccountName, num1.Value, num2.Value) = True Then
                    commentAction = Await anotherInstance.CommentProcessor.CommentMediaAsync(mediaid, comment)
                    If commentAction.Succeeded Then
                        row("Status") = ".OK."
                    Else
                        row("Status") = "Error : " & commentAction.Info?.Message
                    End If
                Else
                    row("Status") = "Error Login "
                End If
            Next
            btn_startCommenting.Enabled = True
        Else
            XtraMessageBox.Show("يجب ان تكون عدد الثواني الثانيه اكبر من الاولي في الفاصل الزمني", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class