Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json
Imports Activator.ActivatorSpcace
Public Class frm_Activation
    Dim ClsAc As New Activator
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://w9ll.co/")

    End Sub
    Private Async Sub btn_validate_ClickAsync(sender As Object, e As EventArgs) Handles btn_validate.Click

        Await ClsAc.DoShow()

    End Sub
    Public Sub startval()
        Dim pwn As String = reqestpgpcert()
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        Dim PWWN() As Byte = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(pwn))
        Dim senderjson As String = JsonConvert.SerializeObject(ClsAc.JsonSenderOBJ)
        Dim resposebody As String = "4w3AoLU8f+/yQ6sLkZGJ1Nn296ESXsq4R1Y26hNQpRs+2l0+VkruH6owFYiy5LXfAcnZvupyL7FYrTIMKQj4x2Vk9EDPk/LkDIpsUZCrkhaR1KiwceR125U/x+4j5HB+2e6rfQCqTSBmAhBmUuszXkuVQnywbDnmYL32w6j17tA="
        ClsAc.plainText = Activator.DecryptString(resposebody, PWWN)
    End Sub
    Function reqestpgpcert() As String
        Dim cert As String = Activator.RequestFromServer("https://w9ll.co/socialmark/PublicPGBKey.txt", "", "w9ll.co")
        Try
            Return cert.Substring(50, 20)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Sub frm_Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startval()
        MsgBox(ClsAc.plainText)

        TextEdit2.Text = My.Settings.serial
        My.Settings.Save()
    End Sub
    Private Sub TextEdit2_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        Activator.spaccing_Remover()
    End Sub
End Class