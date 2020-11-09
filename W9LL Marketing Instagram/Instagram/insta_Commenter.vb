Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Imports DevExpress.XtraEditors
Public Class insta_Commenter
    Dim MentionList As New List(Of String)
    Dim stopThread As Boolean
    Dim TaskList As New List(Of Task)
    Public Property DelaySeconds As Integer
    Public Property DelaySeconds2 As Integer
    Public Shared Property Soruceencodeing As Encoding
    Sub loadUser(Optional LoadSplit As Boolean = False)
        Dim Counter, sensorOfDef As Integer
        If LoadSplit = True Then
            MentionList.Clear()
            For Each aXa As String In IO.File.ReadAllLines(OpenFileDialog2.FileName)
                MentionList.Add(aXa)

            Next


            Counter = 0


            Dim sec As Decimal = (MentionList.Count * 60) / 60
            lbl_Comments_Count.Invoke(New Action(Sub() lbl_Comments_Count.Text = "عدد التعليقات : " & MentionList.Count & vbNewLine & "الزمن الكلي : " & sec & " دقيقة"))

            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                DataGridView2.Rows(i).Cells(2).Value = 0
            Next
            Dim source As Integer = MentionList.Count

            Do Until source = 0
                For Each ROSNum As DataGridViewRow In DataGridView2.Rows
                    If source > 0 Then
                        source -= 1
                        DataGridView2.Invoke(New Action(Sub() ROSNum.Cells(2).Value += 1))
                    ElseIf source <= 0 Then
                        Exit For
                        Exit Do
                    End If
                Next
            Loop



            GroupBox1.Invoke(New Action(Sub() GroupBox1.Enabled = True))

        Else
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
            lbl_Comments_Count.Invoke(New Action(Sub() lbl_Comments_Count.Text = "عدد التعليقات : " & MentionList.Count & vbNewLine & "الزمن الكلي : " & sec & " دقيقة"))

            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                DataGridView2.Rows(i).Cells(2).Value = 0
            Next



            Dim source As Integer = MentionList.Count

            Do Until source = 0
                For Each ROSNum As DataGridViewRow In DataGridView2.Rows
                    If source > 0 Then
                        source -= 1
                        DataGridView2.Invoke(New Action(Sub() ROSNum.Cells(2).Value += 1))
                    ElseIf source <= 0 Then
                        Exit For
                        Exit Do
                    End If
                Next
            Loop

            GroupBox1.Invoke(New Action(Sub() GroupBox1.Enabled = True))
        End If

    End Sub

    Public Media_ID, Media_Link As String
    Private RandText As String()
    Dim commentsC As New instgram_Func


    Sub makethefile()
        Dim numerator As Integer = MentionList.Count
        Dim denominator As Integer = 7 * (DataGridView2.Rows.Count)
        Dim FinalIndexEachFile As Integer
33:     If (numerator Mod denominator) = 0 Then
            FinalIndexEachFile = numerator / denominator
        Else
            numerator -= 1
            GoTo 33
        End If

        Dim tmparr As New List(Of String)
        For i As Integer = 0 To numerator - 1 Step denominator
            For d As Integer = i To (i + denominator) - 1

                tmparr.Add(MentionList(d))

                If d = (i + denominator) - 1 Then
                    IO.File.WriteAllLines(My.Computer.FileSystem.SpecialDirectories.Desktop & "\tmp\" & i & ".txt", tmparr, System.Text.Encoding.UTF8)
                    tmparr.Clear()
                End If


            Next
        Next
    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            GroupBox1.Enabled = False
            Dim x As New Thread(Sub() loadUser())
            x.IsBackground = True
            x.Start()
        End If
    End Sub
    Async Function Comments_Mention_API(ByVal Media_Link As String, cookiesZ As String, csrftockenZ As String, rowIndex As Integer, ByVal startInd As Integer, endind As Integer, ByVal proxy As String) As Task(Of Boolean)

        Try

            For i As Integer = startInd To endind
                Dim head As New WebHeaderCollection
                Dim postdatax As String

                If stopThread = True Then
                    Return False
                End If
                If i = MentionList.Count Then
                    postdatax = MentionList(i - 1).ToString
                Else
                    postdatax = MentionList(i).ToString
                End If

                Dim newuser As New SaveLoadState()
                newuser.Username = DataGridView2.Rows(rowIndex).Cells(1).Value
                newuser.MediaID = Media_ID.Replace("?id=", "")
                Dim RandSequnce As Random = New Random()
                Dim RandLineNum As Integer = RandSequnce.Next(0, Me.RandText.Count() - 1)
                newuser.CommentText = postdatax + " " + Me.RandText(RandLineNum)
                Dim reqx As Boolean = Await newuser.doshowAsync_Comment(proxy)

                If stopThread = True Then
                    Return False
                End If
                'commentsC.CreatReq(url, method, Referer, "", Cookies, head)
                If reqx = True Then
                    DataGridView2.Invoke(New Action(Sub() DataGridView2.Rows(rowIndex).Cells(6).Value += 1))
                Else
                    DataGridView2.Invoke(New Action(Sub() DataGridView2.Rows(rowIndex).Cells(7).Value += 1))
                End If

                Dim randx As New Random
                Dim delay As Integer = randx.Next(DelaySeconds, DelaySeconds2) * 1000
                Await Task.Delay(delay)
            Next

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error_ComSub")
            Return False
        End Try
        Return True
    End Function

    Public Async Sub Comments_Mention(Media_Link As String, cookiesZ As String, csrftockenZ As String, rowIndex As Integer, startInd As Integer, endind As Integer, proxys As String)
        Try

            For i As Integer = startInd To endind
                Dim tries As Integer = 1
                Dim head As WebHeaderCollection = New WebHeaderCollection()
                Dim url As String = "https://www.instagram.com/web/comments/" + Me.Media_ID.Replace("?id=", "") + "/add/"
                Dim method As String = "POST"


                If stopThread = True Then
                    Exit Sub
                End If

                Dim RandSequnce As Random = New Random()
                Dim RandLineNum As Integer = RandSequnce.Next(0, Me.RandText.Count() - 1)
                Dim flag2 As Boolean = Me.MentionList.Count = i
                Dim postdatax As String


                If i = MentionList.Count Then
                    postdatax = "comment_text=" + Me.MentionList(i - 1).ToString() + " " + Me.RandText(RandLineNum)

                Else
                    postdatax = "comment_text=" + Me.MentionList(i).ToString() + " " + Me.RandText(RandLineNum)
                End If

                head.Add("sec-fetch-mode", "cors")
                head.Add("x-ig-www-claim", "hmac.AR3tqhRw8LRMd70e4-yzPE2LIrtsEYo2_CLjtC9xjEhAuoxZ")
                head.Add("X-Instagram-AJAX", "2557ab85cbe0")
                head.Add("x-ig-app-id", "936619743392459")
                head.Add("X-CSRFToken", csrftockenZ)


Block_5:        Dim reqx As String = Me.commentsC.CreatReq(url, method, Media_Link, postdatax, cookiesZ, head, "", proxys)
                If reqx.ToLower().Contains("""ok""}") Then
                    GoTo goodcomment
                End If
                tries += 1
                If tries >= 3 Then
                    GoTo goodcomment
                Else

                    GoTo Block_5
                End If


                If stopThread = True Then
                    Exit Sub
                End If

goodcomment:
                If reqx.ToLower().Contains("""ok""}") Then
                    DataGridView2.Invoke(New Action(Sub() DataGridView2.Rows(rowIndex).Cells(6).Value += 1))
                Else
                    DataGridView2.Invoke(New Action(Sub() DataGridView2.Rows(rowIndex).Cells(7).Value += 1))
                End If

                Dim randx As New Random
                Dim delay As Integer = randx.Next(DelaySeconds, DelaySeconds2) * 1000
                Await Task.Delay(delay)
            Next

        Catch ex As Exception
            '       MsgBox(ex.Message, MsgBoxStyle.Critical, "Error_ComSub")
            Exit Sub
        End Try

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            GroupBox1.Enabled = False
            Dim x As New Thread(Sub() loadUser(True))
            x.IsBackground = True
            x.Start()
        End If
    End Sub

    Dim ts As New CancellationTokenSource
    Dim ct As CancellationToken = ts.Token

    Private Async Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btn_Comment.Click
        ToolStripProgressBar1.Visible = True
        GroupBox1.Enabled = False
        Dim first As Boolean = False
        Dim endEndx As Integer
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            Dim a As String = DataGridView2.Rows(i).Cells(0).Value
            Dim Cookiseaa As String = DataGridView2.Rows(i).Cells(4).Value
            Dim csrxxxx As String = DataGridView2.Rows(i).Cells(5).Value
            Dim proxy As String = DataGridView2.Rows(i).Cells(8).Value
            endEndx = DataGridView2.Rows(i).Cells(2).Value
            Dim lastsum As Integer
            If first = False Then
                Dim randx As New Random
                Dim delay As Integer = randx.Next(num1.Value, num2.Value) * 1000
                Await Task.Delay(delay)

                Dim CmThread As New Task(Sub() Comments_Mention(Media_Link, Cookiseaa, csrxxxx, a, 0, endEndx - 1, proxy), ts)
                CmThread.Start()
                first = True
                lastsum = DataGridView2.Rows(i).Cells(2).Value
            ElseIf first = True Then
                Dim randx As New Random
                Dim delay As Integer = randx.Next(num1.Value, num2.Value) * 1000
                Await Task.Delay(delay)

                Dim startX As Integer = lastsum
                Dim endX As Integer = DataGridView2.Rows(i).Cells(2).Value + lastsum
                Dim CmThread2 As New Task(Sub() Comments_Mention(Media_Link, Cookiseaa, csrxxxx, a, startX + 1, endX, proxy), ts)
                CmThread2.Start()

                Dim eexap As Integer = DataGridView2.Rows(i).Cells(2).Value + lastsum
                lastsum = eexap
            End If
        Next

        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim totaltaget As Integer = MentionList.Count
        Dim curret As Integer = 0

        For Each rowx As DataGridViewRow In DataGridView2.Rows
            curret += rowx.Cells(6).Value.ToString()
            curret += rowx.Cells(7).Value.ToString()
        Next

        If curret >= totaltaget Then
            Timer1.Stop()
            ToolStripProgressBar1.Visible = False
            GroupBox1.Enabled = True
        End If

    End Sub

    Private Sub insta_Commenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Shared Function GetEncoding(ByVal filename As String) As Encoding
        ' Read the BOM
        Dim bom = New Byte(3) {}
        Using file = New FileStream(filename, FileMode.Open, FileAccess.Read)
            file.Read(bom, 0, 4)
        End Using

        ' Analyze the BOM
        If bom(0) = &H2B AndAlso bom(1) = &H2F AndAlso bom(2) = &H76 Then
            Return Encoding.UTF7
        End If
        If bom(0) = &HEF AndAlso bom(1) = &HBB AndAlso bom(2) = &HBF Then
            Return Encoding.UTF8
        End If
        If bom(0) = &HFF AndAlso bom(1) = &HFE Then
            Return Encoding.Unicode 'UTF-16LE
        End If
        If bom(0) = &HFE AndAlso bom(1) = &HFF Then
            Return Encoding.BigEndianUnicode 'UTF-16BE
        End If
        If bom(0) = 0 AndAlso bom(1) = 0 AndAlso bom(2) = &HFE AndAlso bom(3) = &HFF Then
            Return Encoding.UTF32
        End If
        Return Encoding.ASCII
    End Function

    Private Sub Btn_randText_Click(sender As Object, e As EventArgs) Handles btn_randText.Click
        Dim text As String = vbCrLf & "يمكنك هذا الخيار من تفادي الحظر من انستقرام بحيث انه يقوم بوضع نص عشوائي معين من ملف من اختيارك بعد كل عمليه منشن كمثال" & vbCrLf & "@mention1 @mention2 @mention3 @mention4 {شركه --- للتسويق العقاري}" & vbCrLf & "@mention1 @mention2 @mention3 @mention4 {اكبر مكتب عقارات في دول الخليج شاهد اجدد العروض}" & vbCrLf & "سيطلب البرنامج منك الان اختيار الملف النصي الذي يحتوي علي الجمل او الكلمات التي تريد وضعها بعد كل عمليه منشن"
        XtraMessageBox.Show(text, "معلومه! ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If Me.OFD_Accounts.ShowDialog() = DialogResult.OK Then


            Soruceencodeing = GetEncoding(Me.OFD_Accounts.FileName)
            Me.RandText = File.ReadAllLines(Me.OFD_Accounts.FileName, Encoding.Default)



            Dim fileInfo As FileInfo = New FileInfo(Me.OFD_Accounts.FileName)
            Me.lbl_Comments_Count.Text = Me.lbl_Comments_Count.Text + vbCrLf + fileInfo.Name
            Me.btn_randText.Enabled = False
            Me.btn_Comment.Enabled = True

        End If
    End Sub

    Private Sub insta_Commenter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        stopThread = True
        commentsC.preventHttp = True
        For Each tttttx As Task In TaskList
            Try

                ts.Cancel()

            Catch ex As Exception

            End Try
        Next
    End Sub
End Class