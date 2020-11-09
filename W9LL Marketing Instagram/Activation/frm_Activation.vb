Imports W9LL_Marketing_Instagram.Activation

Public Class frm_Activation
    Dim ClsAc As New Activator
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://w9ll.co/")
    End Sub

    Private Async Sub btn_validate_ClickAsync(sender As Object, e As EventArgs) Handles btn_validate.Click
        Dim x As Boolean = Await ClsAc.DoShow()

        If x = True Then
            If ProgramVersion.current = ProgramVersion.Standard Then
                ProgramVersion.maxSupport = 500
                InstgramClient.Grop_DmSender.Visible = False
                InstgramClient.Grop_Follow_unfollow.Visible = False
            Else

                InstgramClient.XtraTabPage4.PageVisible = True

            End If
            InstgramClient.Text = InstgramClient.Text & " - " & ProgramVersion.current

            InstgramClient.Show()
        End If



    End Sub
    Private Sub frm_Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit2.Text = My.Settings.serial
        ProgramVersion.Program_Name = "instagram"
        My.Settings.Save()

    End Sub
    Private Sub TextEdit2_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        Try
            Activator.spaccing_Remover()
        Catch ex As Exception

        End Try
    End Sub
End Class
