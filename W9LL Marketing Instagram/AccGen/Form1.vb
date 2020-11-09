Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports W9LL_Marketing_Instagram.Activation

Public Class Form1
    Dim coka As New CookieContainer
    Dim CSRFToken, Instagram_ajax, cookstring As String
    Function Creat_POST_ReqAsync(ByVal postdatax As String, ByVal usernamex As String, ByVal passwordx As String) As Boolean

        Try
            Dim httpRequest As HttpWebRequest = Nothing
            Dim httpPostStream As Stream = Nothing
            Dim httpResponseStream As BinaryReader = Nothing

            httpRequest = CType(WebRequest.Create("https://www.instagram.com/accounts/web_create_ajax/"), HttpWebRequest)



            httpRequest.Method = "POST"
            httpRequest.Host = "www.instagram.com"
            httpRequest.Accept = "gzip"
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.67 Safari/537.36"
            httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
            httpRequest.Referer = "https://www.instagram.com/"
            httpRequest.ContentType = "application/x-www-form-urlencoded"
            httpRequest.KeepAlive = True
            httpRequest.Headers.Add("X-Requested-With", "XMLHttpRequest")
            httpRequest.Headers.Add("X-CSRFToken", CSRFToken)
            httpRequest.Headers.Add("X-Instagram-AJAX", Instagram_ajax)
            httpRequest.Headers.Add("Cookie", cookstring)

            httpRequest.AutomaticDecompression = DecompressionMethods.GZip
            If TextBox1.Text <> "" Then
                Dim str1 As String() = TextBox1.Text.Split(":")
                Dim ipandportNumber, ProxyUserName, ProxyPassword As String

                ipandportNumber = str1(0) & ":" & str1(1)


                Dim p As WebProxy = New WebProxy(ipandportNumber, True)
                If str1.Length > 2 Then
                    ProxyUserName = str1(2)
                    ProxyPassword = str1(3)

                    p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
                End If


                '    WebRequest.DefaultWebProxy = p
                '   httpRequest.Proxy = p
            End If



            Dim xaaxax() As Byte = Encoding.ASCII.GetBytes(postdatax)
            httpRequest.ContentLength = xaaxax.Length
            'httpRequest.GetRequestStream.Write(xaaxax, 0, postdatax.Length)

            Dim dataStream As Stream = httpRequest.GetRequestStream()

            dataStream.Write(xaaxax, 0, postdatax.Length)



            dataStream.Close()




            Dim Response As HttpWebResponse = httpRequest.GetResponse
            Dim Postreqreader As New StreamReader(Response.GetResponseStream())
            Dim content As String = Postreqreader.ReadToEnd

            txtLog3.Invoke(New Action(Sub() txtLog3.AppendText(Now & " : " & content & vbNewLine)))
            If content.Contains("The IP address you are using has been flagged as an open proxy") Then
                lblf.Invoke(New Action(Sub() lblf.Text += 1))
                Return True

            Else
                lbls.Invoke(New Action(Sub() lbls.Text += 1))
                ListBox1.Invoke(New Action(Sub() ListBox1.Items.Add("w9ll_" + usernamex & ":" & passwordx)))
                Return False
            End If
        Catch ex As Exception
            TextBox2.Invoke(New Action(Sub() TextBox2.AppendText(Now & " : " & ex.Message & vbNewLine)))
            Return False
        End Try





    End Function

    Function Creat_get_ReqAsync() As String




        Dim httpRequest As HttpWebRequest = Nothing
        Dim httpPostStream As Stream = Nothing
        Dim httpResponseStream As BinaryReader = Nothing




        httpRequest = CType(WebRequest.Create("https://www.instagram.com/"), HttpWebRequest)
        httpRequest.Method = "GET"
        httpRequest.ContentType = "application/x-www-form-urlencoded"
        httpRequest.Accept = "gzip"
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:29.0) Gecko/20100101 /29.0"
        httpRequest.Host = "www.instagram.com"
        httpRequest.AutomaticDecompression = DecompressionMethods.GZip


        If TextBox1.Text <> "" Then
            Dim str1 As String() = TextBox1.Text.Split(":")
            Dim ipandportNumber, ProxyUserName, ProxyPassword As String

            ipandportNumber = str1(0) & ":" & str1(1)


            Dim p As WebProxy = New WebProxy(ipandportNumber, True)
            If str1.Length > 2 Then
                ProxyUserName = str1(2)
                ProxyPassword = str1(3)

                p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
            End If


            ' WebRequest.DefaultWebProxy = p
            'httpRequest.Proxy = p
        End If


        '        httpRequest.ProtocolVersion = HttpVersion.Version1

        httpRequest.CookieContainer = coka

        Dim Response As HttpWebResponse = httpRequest.GetResponse()
        Dim Postreqreader As New StreamReader(Response.GetResponseStream())

        Dim pageas As String = Postreqreader.ReadToEnd
        Dim ajaxinsta As String = Regex.Match(pageas, "ollout_hash" + Chr(34) + ":" + Chr(34) + "(.*?)" + Chr(34) + ",").Groups.Item(1).Value

        Dim uri = New Uri("https://www.instagram.com")

        Dim csrf = "", midt As String = ""

        For Each cookie As System.Net.Cookie In coka.GetCookies(uri)
            If cookie.Name = "csrftoken" Then
                CSRFToken = cookie.Value
                csrf = cookie.Value
            End If

            If cookie.Name = "mid" Then

                midt = cookie.Value
            End If
        Next
        cookstring = "csrftoken=" + csrf + "; rur=VLL; mid=" + midt
        Instagram_ajax = ajaxinsta

        Return ajaxinsta

    End Function
    Function RandomString(r As Random, ByVal max As Integer)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        '     Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To max
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function


    Public exitThread As Boolean = False

    Async Sub startCreationAsync()
        Try
            Creat_get_ReqAsync()
            Dim progval As Integer = 0
            For i As Integer = 1 To NumericUpDown1.Value
                Dim r As New Random
                progval = i
                Dim username As String
                username = RandomString(r, 5)
                Dim emailX As String = "fx9l_" & username
                Dim passwordx As String = RandomString(r, 25)

                Creat_POST_ReqAsync("email=" & emailX & "@gmail.com&password=" & passwordx & "&username=fx9l_" & username & "&first_name=" & RandomString(r, 5) & "&seamless_login_enabled=1&tos_version=row&opt_into_one_tap=false", username, passwordx)
                StatusStrip1.Invoke(New Action(Sub() ProgressBar1.Value = progval))




                If exitThread = True Then
                    BtnStart.Invoke(New Action(Sub() BtnStart.Enabled = True))
                    NumericUpDown1.Invoke(New Action(Sub() NumericUpDown1.Enabled = True))
                    StatusStrip1.Invoke(New Action(Sub() ProgressBar1.Value = 0))
                    Exit Sub

                End If
                Await Task.Delay(200)

            Next
            exitThread = False

            BtnStart.Invoke(New Action(Sub() BtnStart.Enabled = True))
            NumericUpDown1.Invoke(New Action(Sub() NumericUpDown1.Enabled = True))
            BtnStop.Invoke(New Action(Sub() BtnStop.Enabled = False))
            StatusStrip1.Invoke(New Action(Sub() ProgressBar1.Value = 0))
        Catch ex As Exception
            exitThread = False
            NumericUpDown1.Invoke(New Action(Sub() NumericUpDown1.Enabled = True))
            BtnStart.Invoke(New Action(Sub() BtnStart.Enabled = True))
            BtnStop.Invoke(New Action(Sub() BtnStop.Enabled = False))
            StatusStrip1.Invoke(New Action(Sub() ProgressBar1.Value = 0))

            TextBox2.Invoke(New Action(Sub() TextBox2.AppendText(Now & " : " & ex.Message & vbNewLine)))
        End Try


    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("هل تود تصدير قائمه الحسابات , بالضغط علي موافق سيتم تصدير الملف بجانب البرنامج", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then




            Dim items() As String = ListBox1.Items.Cast(Of Object).Select(Function(o) ListBox1.GetItemText(o)).ToArray
            Dim FileName As String = String.Format("{0}_{1}{2}", "Account", Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "_" & Now.Minute & "_" & Now.Second, ".txt")
            IO.File.WriteAllLines(FileName, items)

            ' From item As Object In ListBox.ObjectCollection Select item.ToString().ToArray()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ProgramVersion.current = ProgramVersion.Standard Then
            Application.Exit()
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox2.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        txtLog3.Clear()
    End Sub

    'Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    '    Dim httpRequest As HttpWebRequest = Nothing
    '    Dim httpPostStream As Stream = Nothing
    '    Dim httpResponseStream As BinaryReader = Nothing




    '    httpRequest = CType(WebRequest.Create("https://abs.twimg.com/responsive-web/web/main.846e5906cb4b35932.js"), HttpWebRequest)
    '    httpRequest.Method = "GET"
    '    httpRequest.ContentType = "application/x-www-form-urlencoded"
    '    httpRequest.Accept = "gzip"
    '    httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36"
    '    httpRequest.Host = "abs.twimg.com"
    '    httpRequest.AutomaticDecompression = DecompressionMethods.GZip
    '    httpRequest.CookieContainer = coka

    '    Using stream As HttpWebResponse = httpRequest.GetResponse()

    '        ' stream.
    '    End Using


    '    'Dim Postreqreader As New StreamReader(Response.GetResponseStream())



    '    'Dim pageas As String = Postreqreader.ReadToEnd





    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Dim x As Integer = Val(TextBox1.Text) Mod Val(TextBox2.Text)
    '    ListBox1.Items.Add(x)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        BtnStop.Enabled = False
        BtnStart.Enabled = False
        NumericUpDown1.Enabled = False
        exitThread = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        coka = New CookieContainer
        lblf.Text = 0
        lbls.Text = 0
        ProgressBar1.Maximum = NumericUpDown1.Value
        If ProgramVersion.current = ProgramVersion.Standard Then
            Application.Exit()
        End If
        Dim t As New Task(Sub() startCreationAsync())
        t.Start()
        exitThread = False
        BtnStart.Enabled = False
        BtnStop.Enabled = True
        NumericUpDown1.Enabled = False
    End Sub

End Class
