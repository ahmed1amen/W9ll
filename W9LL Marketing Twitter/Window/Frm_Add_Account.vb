Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms

Partial Public Class Frm_Add_Account
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        If (txt_Username.Text = "Type Your Username" Or txt_password.Text = "Type Your Passwrod") Or txt_Username.Text.Contains("@") Then

            XtraMessageBox.Show("Error Fill All Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)




        Else




            Dim dr As DataRow = Controller.DT_AccountManager.NewRow()
            dr(0) = txt_Username.Text
            dr(1) = txt_password.Text
            dr(2) = "Not Checked"

            If (txt_port.Text = "Port" Or Txt_Proxy.Text = "ProxyIP" Or txt_port.Text = String.Empty Or Txt_Proxy.Text = String.Empty) Then
                dr(3) = "LocalProxy"

            Else

                dr(3) = Txt_Proxy.Text & ":" & txt_port.Text

            End If



            dr(4) = "-"
            If txt_group.Text = "Type Group Name" Or txt_group.Text = String.Empty Then
                dr(5) = "Ungrouped"

            Else
                dr(5) = txt_group.Text
            End If

            Controller.DT_AccountManager.Rows.Add(dr)
            UserDataTable_Control = Controller.DT_AccountManager

            Me.Dispose()



        End If





    End Sub
    Private Sub Frm_Add_Account_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class
