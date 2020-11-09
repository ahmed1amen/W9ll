Imports System.Threading
Imports Facebook
Imports Facebook.ClientHTML.Sdk
Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class frm_Friends_Adder
    Public limit As String
    Public gid As String
    Public username As String
    Public password As String
    Public tocken As String
    Public faceObject As FacebookClient
    Async Sub mainX()
        Try
            Dim name = "", id = "", location = "", hometown As String = ""
            Button1.Enabled = False


            Dim attrib As String = gid & "/members?limit=" & limit

            Dim afterval As String
1:          Dim searchlist As Object = Await faceObject.GetTaskAsync(attrib)

            Await Tasks.Task.Delay(6000)
            For Each Friend_c In searchlist.data
                Dim listView As New ListView()
                Dim item1 As New ListViewItem("")
                name = Friend_c.name.ToString
                id = Friend_c.id.ToString
                Dim Query_Location As Object = Await faceObject.GetTaskAsync(Friend_c.id.ToString & "?fields=location,hometown,address")
                If Query_Location.ToString.Contains("location") Then
                    location = Query_Location.location.name.ToString
                End If
                If Query_Location.ToString.Contains("hometown") Then
                    hometown = Query_Location.hometown.name.ToString
                End If
                If Query_Location.ToString.Contains("hometown") = False And Query_Location.ToString.Contains("location") = False Then
                    location = "..."
                    hometown = "..."
                End If
                If Query_Location.ToString.Contains("location") = False Then
                    location = "..."
                End If
                If Query_Location.ToString.Contains("hometown") = False Then
                    hometown = "..."
                End If
                DataGridView1.Rows.Add(False, name, id, location, hometown)
            Next
            If DataGridView1.RowCount >= limit Then
                MsgBox("Finished Loading...")
            Else

                For Each Friend_cx In searchlist.paging
                    If Friend_cx.ToString.Contains("next") Then
                        Dim aftervalue = searchlist.paging.cursors.after
                        afterval = aftervalue.ToString
                        attrib = gid & "/members?limit=" & limit & "&after=" & afterval
                        GoTo 1
                    End If
                Next

            End If
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Err87")
            Me.Close()
        End Try
    End Sub
    Private Sub Friends_Adder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        mainX()
    End Sub
    Dim x_lbl As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim cc As Integer
        For Each x As DataGridViewRow In DataGridView1.Rows

            If x.Cells(0).Value = True Then
                cc += 1
            End If
        Next
        x_lbl = cc

        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Dim LOG_lIST_Ok As New List(Of String)
    Dim LOG_lIST_err As New List(Of String)
    Private Sub BackgroundWorker1_DoWorkAsync(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        LOG_lIST_Ok.Clear()
        LOG_lIST_err.Clear()
        Dim faceObject As New FacebookClientHTML(username, password)
        For Each x As DataGridViewRow In DataGridView1.Rows


            If x.Cells(0).Value = True Then
                Try

                    Try

                        faceObject.friendrequest_ByMe(x.Cells(2).Value.ToString, "no")
                        x_lbl -= 1
                        Label3.Invoke(New Action(Sub() Label3.Text = x_lbl))

                        If Label3.Text = 0 Then

                            Button1.Invoke(New Action(Sub() Button1.Enabled = True))
                        End If
                    Catch ex As Exception
                        frm_FacebookApplication.Invoke(New Action(Sub() frm_FacebookApplication.log(" Ex : " & ex.Message, Color.Red)))
                    End Try




                    Try

                        faceObject.friendrequest_ByMe(x.Cells(2).ToString, "no")
                        x_lbl -= 1
                        LOG_lIST_Ok.Add("   تم الارسال      " & x.Cells(1).Value.ToString)
                        Label3.Text = x_lbl
                        If Label3.Text = 0 Then
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try



            Dim svd As New SaveFileDialog
            svd.Filter = "dbxf files (*.dbxf)|*.dbxf"
            svd.CheckFileExists = False
            svd.CheckPathExists = False
            If svd.ShowDialog = DialogResult.OK Then
                Dim File As System.IO.StreamWriter = New StreamWriter(svd.FileName, False, Encoding.Unicode)
                For Each x As DataGridViewRow In DataGridView1.Rows
                    File.WriteLine(x.Cells(1).Value.ToString & "*_*" & x.Cells(2).Value.ToString)
                Next
                File.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Err")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Clear()
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

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Enabled = True
        For Each x As String In LOG_lIST_Ok
            frm_FacebookApplication.log(x, Color.Blue)
        Next
        For Each xxc As String In LOG_lIST_err
            frm_FacebookApplication.log(xxc, Color.Red)
        Next
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.Rows.Count = 0 Then
        Else

            For Each x As DataGridViewRow In DataGridView1.Rows

                If x.Cells(0).Value = True Then
                    x.Cells(0).Value = False
                    x.Selected = False
                ElseIf x.Cells(0).Value = False
                    x.Cells(0).Value = True
                    x.Selected = True
                End If

            Next
            DataGridView1.Focus()
        End If
    End Sub


End Class