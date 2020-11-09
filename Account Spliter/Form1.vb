Imports System.IO
Imports System.Threading

Public Class Form1


    Dim MentionList As New List(Of String)

    Sub loadUser()
        Dim Counter, sensorOfDef As Integer



        MentionList.Clear()

        Dim lineCount = IO.File.ReadAllLines(OpenFileDialog1.FileName).Length
        Dim file As String() = IO.File.ReadAllLines(OpenFileDialog1.FileName, System.Text.Encoding.UTF8)
        Dim str10_10 As String = ""
        For Each x As String In IO.File.ReadAllLines(OpenFileDialog1.FileName, System.Text.Encoding.UTF8)
            Dim ss() As String = x.Split("*_*")
            '     txt_MediaComment.Invoke(New Action(Sub() txt_MediaComment.AppendText()))
            If x.Contains("*_*") = True Then
                str10_10 += "@" & ss(4) & " "
                Counter += 1
                If lineCount <= 10 Then
                    'apply normal mention
                    If Counter = 10 Then
                        MentionList.Add(str10_10)
                        str10_10 = ""
                        Counter = 0
                    End If
                Else 'IF MORE THAN 10
                    If (lineCount Mod 10) = 0 Then
                        If Counter = 10 Then
                            MentionList.Add(str10_10)
                            str10_10 = ""
                            Counter = 0
                        End If
                    Else
                        sensorOfDef = lineCount - (lineCount Mod 10)
                        If Counter = 10 Then
                            MentionList.Add(str10_10)
                            str10_10 = ""
                            Counter = 0
                        End If
                    End If
                End If


            End If
        Next
        str10_10 = ""
        If sensorOfDef <> 0 Then
            For i As Integer = sensorOfDef To lineCount - 1
                '     txt_MediaComment.Invoke(New Action(Sub() txt_MediaComment.AppendText()))
                If file(i).Contains("*_*") = True Then
                    Dim ss() As String = file(i).Split("*_*")
                    str10_10 += "@" & ss(4) & " "
                End If
            Next
            MentionList.Add(str10_10)
            str10_10 = ""
        End If


        Counter = 0


        Dim sec As Decimal = (MentionList.Count * 60) / 60
        lbl_Comments_Count.Invoke(New Action(Sub() lbl_Comments_Count.Text = "عدد حسابات الملف : " & MentionList.Count & vbNewLine & "الزمن الكلي : " & sec & " دقيقة"))



        Dim Splittttter As Integer = MentionList.Count / (NumericUpDown1.Value * 7)



        Dim source As Integer = MentionList.Count

        GroupBox1.Invoke(New Action(Sub() GroupBox1.Enabled = True))

    End Sub
    Private Sub EffectualButtonOrange1_Click(sender As Object, e As EventArgs) Handles EffectualButtonOrange1.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("يرجي اضافه عدد الحسابات اولا", MsgBoxStyle.Critical, "الحسابات")
            Exit Sub
        End If

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            lbl_Comments_Count.Text = OpenFileDialog1.FileName
            loadUser()

            MsgBox(" اختر مكان حفظ الملفات وتأكد من الصيغه", MsgBoxStyle.Information, "حدد مكان الحفظ")
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

                Try
                    Dim Splittttter As Integer = MentionList.Count / (NumericUpDown1.Value * 7)

                    If Splittttter = 0 Then
                        MsgBox("الملف لا يحتاج تقسيم ... عدد الحسابات كافيه لعمل المنشن", MsgBoxStyle.Information, "تصدير الملفات")
                    Else




                        Dim muliplyer As Integer
                        muliplyer = (NumericUpDown1.Value * 7)
                        Dim xa As IEnumerable(Of String)


                        Dim oldI As Integer = 0
                        For it As Integer = 1 To Splittttter

                            xa = MentionList.Skip(oldI).Take((muliplyer))
                            oldI = muliplyer * it
                            File.WriteAllLines(FolderBrowserDialog1.SelectedPath & "\" & it & ".dbxiSpl", xa.ToArray(), System.Text.Encoding.UTF8)
                        Next
                        MsgBox("تم بنجاح", MsgBoxStyle.Information, "تصدير الملفات")
                    End If
                Catch ex As Exception
                    MsgBox("حدث خطأ اثناء التصدير" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "تصدير الملفات")
                End Try



            End If

        End If

        'If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
        '    IO.File.ReadAllBytes("")

        'End If
    End Sub

    Private Sub EffectualButtonBlue1_Click(sender As Object, e As EventArgs) Handles EffectualButtonBlue1.Click
        DataGridView1.Rows.Clear()
        For i As Integer = 1 To NumericUpDown1.Value
            DataGridView1.Rows.Add(i, " حساب " & i, "")
        Next
    End Sub

End Class
