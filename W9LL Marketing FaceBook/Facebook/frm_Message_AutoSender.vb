Imports Facebook.ClientHTML.Sdk
Public Class frm_Message_AutoSender
    Public username As String
    Public password As String
    Dim x_lbl As Integer
    Dim LOG_lIST_err As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim cc As Integer
        For Each x As DataGridViewRow In DataGridView1.Rows
            If x.Cells(0).Value = True Then
                cc += 1
            End If
        Next
        x_lbl = cc
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.Rows.Count = 0 Then
        Else
            For Each x As DataGridViewRow In DataGridView1.Rows
                If x.Cells(0).Value = True Then
                    x.Cells(0).Value = False
                    x.Selected = False
                ElseIf x.Cells(0).Value = False Then
                    x.Cells(0).Value = True
                    x.Selected = True
                End If
            Next
            DataGridView1.Focus()
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        LOG_lIST_err.Clear()
        Dim faceObject As New FacebookClientHTML(username, password)
        For Each x As DataGridViewRow In DataGridView1.Rows
            If x.Cells(0).Value = True Then
                Try
                    Try
                        faceObject.SendmessagetoFriend_ByMe(x.Cells(2).Value.ToString, TextBox1.Text)
                        x_lbl -= 1
                        Label3.Text = x_lbl
                        If Label3.Text = 0 Then
                            Timer1.Stop()
                            Button1.Enabled = True
                        End If
                    Catch ex As Exception
                        frm_FacebookApplication.log(" Ex : " & ex.Message, Color.Red)
                    End Try
                    System.Threading.Thread.Sleep(NumericUpDown1.Value * 1000)
                    Application.DoEvents()
                Catch ex As Exception
                    LOG_lIST_err.Add("فشل الارسال " & x.Cells(1).Value.ToString & " Ex : " & ex.Message)
                    Continue For
                End Try
            End If
        Next
    End Sub
    Private Sub frm_Message_AutoSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim svd As New OpenFileDialog
        svd.Filter = "dbxf files (*.dbxf)|*.dbxf"
        svd.CheckFileExists = False
        svd.CheckPathExists = False
        If svd.ShowDialog = DialogResult.OK Then
            Dim Stringarr As String()
            For Each x As String In IO.File.ReadAllLines(svd.FileName, System.Text.Encoding.UTF8)
                Stringarr = x.Split("*_*")
                DataGridView1.Rows.Add(False, Stringarr(0), Stringarr(2))
            Next
        End If
    End Sub
End Class