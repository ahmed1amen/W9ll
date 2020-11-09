Imports DevExpress.XtraEditors
Imports InstagramApiSharp
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Imports InstagramApiSharp.Classes.Models
Imports InstagramApiSharp.Logger
Imports System.IO
Imports System.Net
Class SaveLoadState
    Public Username As String
    Public MediaID As String
    Public CommentText As String
    Public Shared Sub LogReport(ByVal IsError As Boolean, ByVal usernameF As String, ByVal messageOf As String)
        If IsError = True Then
            InstgramClient.MainInstance.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, usernameF, messageOf))
        Else
            InstgramClient.MainInstance.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] : {2} ", Now, usernameF, messageOf))
        End If
    End Sub
    Public Async Function GetMediaID(ByVal URL As String) As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)


            ' Now create a client handler which uses that proxy

            Dim Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")
            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).UseLogger(Logger).SetRequestDelay(RequestDelay.FromSeconds(1, 3)).Build() '.UseHttpClientHandler(httpClientHandler).Build() '
            anotherInstance.LoadStateDataFromString(datastring)

            '  Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()
            '  If Not anotherResult.Succeeded Then
            'InstgramClient.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, Username, anotherResult.Info?.Message))
            'Return False
            '  Else
            Dim X = Await anotherInstance.CommentProcessor.CommentMediaAsync(MediaID, CommentText)
            ' Dim X = Await anotherInstance.CommentProcessor.ReplyCommentMediaAsync(MediaID, "17858621008531954", CommentText)
            If X.Succeeded Then

                Return True
            Else
                InstgramClient.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, Username, X.Info?.Message))
                Return False
            End If
            '    End If
        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try

    End Function

    Public Async Function doshowAsync_Comment(ByVal proxyAdd As String) As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)
            Dim ProxyString As String = proxyAdd
            Dim proxy = New WebProxy()
            If proxyAdd <> Nothing Then
                Dim str1 As String() = ProxyString.Split(":")
                Dim ipandportNumber, ProxyUserName, ProxyPassword As String
                ipandportNumber = str1(0) & ":" & str1(1)
                Dim p As WebProxy = New WebProxy(ipandportNumber, True)
                If str1.Length > 2 Then
                    ProxyUserName = str1(2)
                    ProxyPassword = str1(3)
                    p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
                End If
                WebRequest.DefaultWebProxy = p
            Else
                WebRequest.DefaultWebProxy = New WebProxy()
            End If

            ' Now create a client handler which uses that proxy
            Dim httpClientHandler = New Http.HttpClientHandler() With {.Proxy = proxy}

            httpClientHandler.Proxy = proxy
            Dim Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")
            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).UseLogger(Logger).SetRequestDelay(RequestDelay.FromSeconds(1, 3)).UseHttpClientHandler(httpClientHandler).Build() '
            anotherInstance.LoadStateDataFromString(datastring)

            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()

            If Not anotherResult.Succeeded Then
                'InstgramClient.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, Username, anotherResult.Info?.Message))
                Return False
            Else
                Dim X = Await anotherInstance.CommentProcessor.CommentMediaAsync(MediaID, CommentText)
                '  Dim X = Await anotherInstance.CommentProcessor.ReplyCommentMediaAsync(MediaID, "17858621008531954", CommentText)
                If X.Succeeded Then

                    Return True
                Else
                    InstgramClient.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, Username, X.Info?.Message))
                    Return False
                End If
            End If
        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try

    End Function
    Public Async Function doshowAsyncFollow(ByVal userid As Long, ByVal command As String, ByVal proxyAdd As String) As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)
            Dim proxy = New WebProxy()
            If proxyAdd <> Nothing Then
                Dim str1 As String() = proxyAdd.Split(":")
                Dim ipandportNumber, ProxyUserName, ProxyPassword As String
                ipandportNumber = str1(0) & ":" & str1(1)
                Dim p As WebProxy = New WebProxy(ipandportNumber, True)
                If str1.Length > 2 Then
                    ProxyUserName = str1(2)
                    ProxyPassword = str1(3)
                    p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
                End If
                WebRequest.DefaultWebProxy = p
            Else
                WebRequest.DefaultWebProxy = New WebProxy()
            End If
            ' Now create a client handler which uses that proxy
            Dim httpClientHandler = New Http.HttpClientHandler() With {.Proxy = proxy}




            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).SetRequestDelay(RequestDelay.FromSeconds(2, 2)).UseHttpClientHandler(httpClientHandler).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()
            If Not anotherResult.Succeeded Then
                Return False
            Else
                Dim Xdadad As Object = Nothing
                If command = "follow" Then
                    Await anotherInstance.UserProcessor.FollowUserAsync(userid)
                Else
                    Await anotherInstance.UserProcessor.UnFollowUserAsync(userid)

                End If
                Return True

            End If
        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try

    End Function


    Public Async Function Location() As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)
            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).SetRequestDelay(RequestDelay.FromSeconds(2, 2)).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()



            Dim Result = Await anotherInstance.LocationProcessor.SearchLocationAsync(55.753923, 37.62094, "square")

            Dim firstLocation = Result.Value?.FirstOrDefault()
            Dim locationStories = Await anotherInstance.LocationProcessor.GetRecentLocationFeedsAsync(Long.Parse(firstLocation.ExternalId), PaginationParameters.MaxPagesToLoad(10))

            For Each media As InstaMedia In locationStories.Value.Medias


            Next


            MsgBox("done")


        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try

    End Function


    Public Async Function TempFunction() As Task(Of Boolean)
        Try
            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)
            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).SetRequestDelay(RequestDelay.FromSeconds(2, 2)).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()

            'Esraa Mousa*_*15260506069*_*esraa.mahmoud.1999
            Dim xxx
            'xxx.ProfilePicUrl
            Dim urxx As String()
            For Each urlf As String In File.ReadAllLines("D:\kali\me\s\SCampagne\Esraa Following - Copy.txt")
                Try
                    urxx = urlf.Split("*_*")
                    xxx = Await anotherInstance.UserProcessor.GetUserInfoByIdAsync(urxx(2))
                    My.Computer.FileSystem.WriteAllText("D:\kali\me\s\SCampagne\SavedListInstagram.txt", urxx(0) + "*_*" + urxx(2) + "*_*" + urxx(4) + "*_*" + xxx.Value.ProfilePicUrl + vbNewLine, True)
                Catch ex As Exception
                    My.Computer.FileSystem.WriteAllText("D:\kali\me\s\SCampagne\SavedListInstagram.txt", "#####" + urlf + "#####" + vbNewLine, True)
                End Try
            Next





        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try

        MsgBox("done")
    End Function
End Class
