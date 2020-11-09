Public Class frm_Activation
    Dim ClsAc As New Activator
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://w9ll.co/")
    End Sub
    Private Async Sub btn_validate_ClickAsync(sender As Object, e As EventArgs) Handles btn_validate.Click

        Dim x As Boolean = Await ClsAc.DoShow()
        If x = True Then
            Controller.Show()
        End If
    End Sub
    Private Sub frm_Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit2.Text = My.Settings.serial
        Activation.ProgramVersion.Program_Name = "twitter"
        My.Settings.Save()
    End Sub
    Private Sub TextEdit2_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        Activator.spaccing_Remover()
    End Sub
End Class