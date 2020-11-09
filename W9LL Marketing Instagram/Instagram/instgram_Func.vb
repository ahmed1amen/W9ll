Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading
Public Class instgram_Func
    Public postdata, csrftoken_code_adv, mid_code_adv, rur_code_adv, sessionid_adv, shbid_adv, Set_CookieHeader As String
    Public Cookies_str As String
    Public preventHttp As Boolean
    Private Property Proxy As WebProxy
    Function GetUserId(ByVal username As String) As String
22:     Dim profile_ID As Regex = New Regex("profilePage_(.*?)""")
        Dim str17 As String
        Try
            Dim hWeb As HtmlAgilityPack.HtmlWeb = New HtmlAgilityPack.HtmlWeb()
            Dim doc As HtmlAgilityPack.HtmlDocument = hWeb.Load("https://www.instagram.com/" & username, "GET")
            Dim Nodes As HtmlAgilityPack.HtmlNodeCollection = doc.DocumentNode.SelectNodes("/html/body/script[1]")
            Dim Fx_Str As String = Nodes(0).InnerText.Replace("window._sharedData = ", "").Replace("};", "}")
            str17 = profile_ID.Match(Fx_Str).Groups.Item(1).Value
            If Fx_Str.Contains("followed_by") Then
                Return str17
            Else
                MsgBox("Page Not Found", MsgBoxStyle.Critical, "Error")
                Return ""
                Exit Function
            End If
        Catch ex As Exception
            If MessageBox.Show(ex.Message, "Error _ Get User Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) = DialogResult.Retry Then
                GoTo 22
            Else
            End If
        End Try
        Return ""
    End Function
    Private Sub InitalizeProxy(proxyString As String)

    End Sub
    Function CreatReq(ByVal url As String, ByVal method As String, ByVal Referer As String, ByVal postdatax As String, ByVal Cookies As String, ByVal head As WebHeaderCollection, Optional Loginx As String = "", Optional proxyString As String = "") As String
        Dim httpRequest As HttpWebRequest = Nothing
        Dim httpPostStream As Stream = Nothing
        Dim httpResponseStream As BinaryReader = Nothing
        httpRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpRequest.Method = method
        httpRequest.Headers = head
        httpRequest.Headers("Origin") = "https://www.instagram.com"
        httpRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8"
        httpRequest.Accept = "*/*"
        httpRequest.Headers("X-Requested-With") = "XMLHttpRequest"
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36"
        httpRequest.Referer = Referer
        'httpRequest.Headers("Accept-Encoding") = "gzip, deflate, br"
        httpRequest.Headers("Accept-Language") = "en-US,en;q=0.9"
        httpRequest.Host = "www.instagram.com"
        httpRequest.Headers("Cookie") = Cookies

        If preventHttp = True Then
            httpRequest.Abort()
            preventHttp = False
            Exit Function
        End If
        If proxyString <> Nothing Then
            Try

                '    Dim proxyAdd As String = proxyString
                '    If proxyAdd <> Nothing Then
                '        Dim str1 As String() = proxyString.Split(":")
                '        Dim ipandportNumber, ProxyUserName, ProxyPassword As String
                '        ipandportNumber = str1(0) & ":" & str1(1)
                '        Proxy = New WebProxy(ipandportNumber, True)
                '        If str1.Length > 2 Then
                '            ProxyUserName = str1(2)
                '            ProxyPassword = str1(3)
                '            Proxy.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
                '        End If
                '    Else
                '        WebRequest.DefaultWebProxy = New WebProxy()
                '    End If


            Catch ex As Exception
                MsgBox("خطأ في البروكسي", MsgBoxStyle.Critical, "Gen_Error")
                Exit Function
            End Try
        End If
        If postdatax = "" Then
            Try
                If Loginx = "xxa" Then
                    Dim response2 As HttpWebResponse = httpRequest.GetResponse()
                    Dim postreqreader2 As New StreamReader(response2.GetResponseStream())
                    Dim headerdata As String = response2.Headers("Set-Cookie")

                    Set_CookieHeader = headerdata
                    csrftoken_code_adv = Regex.Match(headerdata, "csrftoken=(.*?);").Groups.Item(1).Value
                    mid_code_adv = Regex.Match(headerdata, "mid=(.*?);").Groups.Item(1).Value
                    rur_code_adv = Regex.Match(headerdata, "rur=(.*?);").Groups.Item(1).Value
                    sessionid_adv = Regex.Match(headerdata, "sessionid=(.*?);").Groups.Item(1).Value
                    shbid_adv = Regex.Match(headerdata, "shbid=(.*?);").Groups.Item(1).Value
                    Cookies_str = "shbid=" & shbid_adv & ";rur=ATN;" & "mid=" & mid_code_adv & ";csrftoken=" & csrftoken_code_adv & ";sessionid=" & sessionid_adv
                    Return postreqreader2.ReadToEnd
                    Exit Function
                End If

                Dim response As HttpWebResponse = httpRequest.GetResponse()
                Dim postreqreader As New StreamReader(response.GetResponseStream())
                Return postreqreader.ReadToEnd
            Catch ex As System.Net.WebException
                If ex.Response IsNot Nothing Then
                    Dim postreqreader As New StreamReader(ex.Response.GetResponseStream())
                    Return postreqreader.ReadToEnd()

                End If
            Catch exx As Exception
                MsgBox(exx)
            End Try
        Else
            Try


                Dim xaaxax() As Byte = Encoding.UTF8.GetBytes(postdatax)

                httpRequest.ContentLength = xaaxax.Length


                Dim dataStream As Stream


                dataStream = httpRequest.GetRequestStream()
                Using dataStream
                    dataStream.Write(xaaxax, 0, xaaxax.Length)
                End Using



                Dim response As HttpWebResponse = httpRequest.GetResponse()



                Dim postreqreader As New StreamReader(response.GetResponseStream())




                If Loginx = "log" Then
                    Dim QQ1 As String = Chr(34) & Chr(34)
                    Dim headerdata As String = response.Headers("Set-Cookie")
                    Dim xrep As String = headerdata.Replace("csrftoken=" & QQ1, "").Replace("mid=" & QQ1, "").Replace("rur=" & QQ1, "").Replace("sessionid=" & QQ1, "").Replace("shbid=" & QQ1, "")
                    headerdata = xrep

                    csrftoken_code_adv = Regex.Match(headerdata, "csrftoken=(.*?);").Groups.Item(1).Value
                    mid_code_adv = Regex.Match(headerdata, "mid=(.*?);").Groups.Item(1).Value
                    rur_code_adv = Regex.Match(headerdata, "rur=(.*?);").Groups.Item(1).Value
                    sessionid_adv = Regex.Match(headerdata, "sessionid=(.*?);").Groups.Item(1).Value
                    shbid_adv = Regex.Match(headerdata, "shbid=(.*?);").Groups.Item(1).Value
                    Cookies_str = "shbid=" & shbid_adv & ";rur=ATN;" & "mid=" & mid_code_adv & ";csrftoken=" & csrftoken_code_adv & ";sessionid=" & sessionid_adv
                End If
                Return postreqreader.ReadToEnd
            Catch ex As System.Net.WebException
                If ex.Response IsNot Nothing Then
                    Dim postreqreader As New StreamReader(ex.Response.GetResponseStream())
                    Return postreqreader.ReadToEnd()
                End If
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Creat Rq")
                Return ""
            Catch exa As Exception
                MsgBox(exa.Message, MsgBoxStyle.Critical, "Creat Rq2")
                Return ""

            End Try
        End If
        Return ""


    End Function
    Async Function GetPageText(ByVal url As String, Optional proxy As String = "") As Task(Of String)
        Dim client As WebClient = New WebClient
        Try
            'If proxy <> Nothing Then
            '    Try

            '        Dim str1 As String() = proxy.Split(":")
            '        Dim ipandportNumber, ProxyUserName, ProxyPassword As String
            '        ipandportNumber = str1(0) & ":" & str1(1)
            '        ProxyUserName = str1(2)
            '        ProxyPassword = str1(3)
            '        Dim x As String = proxy
            '        Dim p As WebProxy = New WebProxy(ipandportNumber, True)
            '        p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)

            '        client.Headers.Item(HttpRequestHeader.KeepAlive) = "True"
            '        client.Proxy = p
            '        Return client.DownloadString(url)5
            '    Catch ex As Exception
            '        MsgBox("خطأ في البروكسي" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Gen_Error")
            '        Exit Function
            '    End Try
            'Else

            Dim pag As String = Await client.DownloadStringTaskAsync(New Uri(url))

            Return pag
            ' End If
        Catch ex As System.Net.WebException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Bad Req")
        Catch exx As Exception
            MsgBox("من فضلك تأكد من الرابط", MsgBoxStyle.Critical, "فشل العثور علي النص.")
            Return ""
        End Try
    End Function

End Class
