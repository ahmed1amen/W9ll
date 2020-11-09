Imports W9LL_Marketing_FaceBook.Activation

Public Class frm_Activation
    Dim ClsAc As New Activator
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://w9ll.co/")
    End Sub
    Private Async Sub btn_validate_ClickAsync(sender As Object, e As EventArgs) Handles btn_validate.Click
        Dim x As Boolean = Await ClsAc.DoShow()
        If x = True Then
            If ProgramVersion.current = ProgramVersion.Standard Then
                frm_FacebookApplication.XtraTabPage4.Visible = False
                frm_FacebookApplication.Goup_maxResults.Value = 50
                frm_FacebookApplication.Goup_maxResults.Visible = False
                frm_FacebookApplication.Ck_posttofriends.Visible = False
                frm_FacebookApplication.Ck_posttomywall.Visible = False
                frm_FacebookApplication.Ck_posttopages.Visible = False
                frm_FacebookApplication.pnl_link.Visible = False
                frm_FacebookApplication.RD_link.Visible = False
            End If
            frm_FacebookApplication.Text = frm_FacebookApplication.Text & " - " & ProgramVersion.current
            frm_FacebookApplication.Show()
        End If
    End Sub
    Private Sub frm_Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit2.Text = My.Settings.serial
        ProgramVersion.Program_Name = "facebook"
        My.Settings.Save()
    End Sub
    Private Sub TextEdit2_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        Try
            Activator.spaccing_Remover()
        Catch ex As Exception

        End Try
    End Sub
End Class
