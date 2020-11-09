Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports InstagramApiSharp.API
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Imports InstagramApiSharp.Logger
Imports W9LL_Marketing_Instagram.Activation
Public Class InstagramObject
    Public Property Username As String
    Public Property Password As String
    Public Property ProxyString As String
    Public Property InstaApi As IInstaApi
    Public Property StateFile As String = "State.bin"
    Public Property WebCookiesContianer As CookieContainer
    Public Property mainCookieContainer As CookieContainer
    Private Frm_InstaVerifyInstance As New Frm_InstaVerify
    Private ChallengeSize As Size = New Size(432, 604)
    Public Property fullCookies As String
    Private Property Proxy As WebProxy
    Private IsGoodProxy As Boolean = False
    Private Sub InitalizeProxy(proxyString As String)
        'Try
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
        '        webRequest.DefaultWebProxy = New WebProxy()
        '    End If

        'Catch ex As Exception
        '    LogReport(True, Username, "InitalizeProxy " + ex.Message)
        '    webRequest.DefaultWebProxy = New WebProxy()
        'End Try


    End Sub
    Private Sub TestProxy()
        Try
            Dim r As HttpWebRequest = webRequest.Create("http://www.google.com/")
            r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
            r.Timeout = 10000
            r.Proxy = Proxy
            Dim re As WebResponse = r.GetResponse
            IsGoodProxy = True
        Catch ex As Exception

            IsGoodProxy = False
        End Try

    End Sub

    Public Sub New(username As String, password As String, proxyString As String)
        Me.Username = username
        Me.Password = password
        Me.ProxyString = proxyString
        '  InitalizeProxy(proxyString)
        If IO.Directory.Exists("instAcc\") = False Then
            IO.Directory.CreateDirectory("instAcc")

        End If
    End Sub
    Public Shared Sub LogReport(ByVal IsError As Boolean, ByVal usernameF As String, ByVal messageOf As String)
        If IsError = True Then
            InstgramClient.MainInstance.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, usernameF, messageOf))
        Else
            InstgramClient.MainInstance.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] : {2} ", Now, usernameF, messageOf))
        End If
    End Sub
    Async Function CheckAccount(RowHandle As Integer) As Task(Of Boolean)

        'If ProxyString <> Nothing Then


        '    Dim t = Task.Factory.StartNew(Sub() TestProxy())
        '    Await t


        '    If IsGoodProxy = False Then
        '        LogReport(True, Username, "PROXY Error")
        '        InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Status", "PROXY Error")))
        '        Return False

        '    End If
        'End If


        Try
            Dim Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")

            Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Username & ".dat", System.Text.Encoding.UTF8)
            'Now create a client handler which uses that proxy
            Dim httpClientHandler = New Http.HttpClientHandler() With {.Proxy = Proxy}


            Dim anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).UseLogger(Logger).UseHttpClientHandler(httpClientHandler).SetRequestDelay(RequestDelay.FromSeconds(1, 5)).Build()
            anotherInstance.LoadStateDataFromString(datastring)
            Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()

            If Not anotherResult.Succeeded Then
                InstgramClient.ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, Username, anotherResult.Info?.Message))

                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Status", "ERR " + anotherResult.Info?.Message)))
                Return False

            Else
                Dim items As String()
                mainCookieContainer = anotherInstance.HttpRequestProcessor.HttpHandler.CookieContainer
                Dim CookieContainer = mainCookieContainer
                Dim uri = New Uri("https://www.instagram.com")
                For Each cookie In CookieContainer.GetCookies(uri)
                    fullCookies += cookie.ToString() & ";"
                Next cookie

                Dim infoCurrentUser = Await anotherInstance.UserProcessor.GetUserInfoByUsernameAsync(Username)
                items = New String() {"#", "#", "#", "#", "#", "", "#", "#"}
                items(0) = Username
                items(1) = Password
                Try
                    items(2) = infoCurrentUser.Value.FollowerCount
                    items(3) = infoCurrentUser.Value.FollowingCount
                Catch ex As Exception
                End Try
                items(4) = "Good"
                items(5) = ProxyString
                items(6) = fullCookies
                items(7) = Regex.Match(fullCookies, "csrftoken=(.*?);").Groups.Item(1).Value



                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Username", items(0))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Pasword", items(1))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Followers", items(2))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Following", items(3))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Status", items(4))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Proxy", items(5))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "Cookise_String", items(6))))
                InstgramClient.Grid_Control_Accounts.Invoke(New Action(Sub() InstgramClient.Grid_View_Accounts.SetRowCellValue(RowHandle, "csr_Token", items(7))))
                My.Computer.FileSystem.WriteAllText("instAcc\" & Username & ".dat", anotherInstance.GetStateDataAsString(), False)
                Return True

            End If
        Catch ex As Exception
            LogReport(True, Username, ex.Message)
            Return False
        End Try
    End Function
    Async Function LoginMethodAsync() As Task(Of Boolean)
        If ProxyString <> Nothing Then


            Dim t = Task.Factory.StartNew(Sub() TestProxy())
            Await t
            If IsGoodProxy = False Then
                LogReport(True, Username, "Proxy Error")
                Return False

            End If
        End If

        Try

            'Now create a client handler which uses that proxy
Logagain:   Dim httpClientHandler = New Http.HttpClientHandler() With {.Proxy = Proxy}
            Dim Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")
            If ProgramVersion.current = ProgramVersion.Standard Then
                If InstgramClient.Grid_View_Accounts.RowCount >= ProgramVersion.maxSupport Then
                    XtraMessageBox.Show("هذه النسخه تدعم 500 حساب فقط", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
            End If

            Dim items As String()
            Dim userSession As UserSessionData = New UserSessionData With {
                .UserName = Username,
                .Password = Password
            }
            'Session handler, set a file path to save/load your state/session data
            Dim sessionHandler = New SessionHandlers.FileSessionHandler With {.FilePath = StateFile}
            InstaApi = InstaApiBuilder.CreateBuilder.SetUser(userSession).UseLogger(Logger).SetRequestDelay(RequestDelay.FromSeconds(1, 5)).SetSessionHandler(sessionHandler).UseHttpClientHandler(httpClientHandler).Build
            'Text = $"{AppName} Connecting"
            'LoadSession()
            If Not InstaApi.IsUserAuthenticated Then
                Dim logInResult = Await InstaApi.LoginAsync()
                Debug.WriteLine(logInResult.Value)
                If logInResult.Succeeded Then
                    mainCookieContainer = InstaApi.HttpRequestProcessor.HttpHandler.CookieContainer
                    Dim CookieContainer = mainCookieContainer
                    Dim uri = New Uri("https://www.instagram.com")
                    For Each cookie In CookieContainer.GetCookies(uri)
                        fullCookies += cookie.ToString() & ";"


                    Next cookie
                    Dim infoCurrentUser = Await InstaApi.UserProcessor.GetUserInfoByUsernameAsync(Username)
                    items = New String() {"#", "#", "#", "#", "#", "", "#", "#"}
                    items(0) = Username
                    items(1) = Password
                    Try
                        items(2) = infoCurrentUser.Value.FollowerCount
                        items(3) = infoCurrentUser.Value.FollowingCount
                    Catch ex As Exception
                    End Try
                    items(4) = "Good"
                    items(5) = ProxyString
                    items(6) = fullCookies
                    items(7) = Regex.Match(fullCookies, "csrftoken=(.*?);").Groups.Item(1).Value

                    InstgramClient.BeginInvoke(New Action(Sub()
                                                              InstgramClient.DT_AccountManager.Rows.Add(items)
                                                              InstgramClient.XtraTabPage2.PageVisible = True
                                                          End Sub))

                    My.Computer.FileSystem.WriteAllText("instAcc\" & Username & ".dat", InstaApi.GetStateDataAsString(), False)
                ElseIf (logInResult.Value = InstaLoginResult.ChallengeRequired) Then
                    Dim challenge = Await InstaApi.GetChallengeRequireVerifyMethodAsync()
                    If challenge.Succeeded Then
                        If challenge.Value.SubmitPhoneRequired Then
                            Frm_InstaVerifyInstance.SubmitPhoneChallengeGroup.Visible = True

                        ElseIf (Not (challenge.Value.StepData) Is Nothing) Then
                            If Not String.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber) Then
                                Frm_InstaVerifyInstance.RadioVerifyWithPhoneNumber.Checked = False
                                Frm_InstaVerifyInstance.RadioVerifyWithPhoneNumber.Visible = True
                                Frm_InstaVerifyInstance.RadioVerifyWithPhoneNumber.Text = challenge.Value.StepData.PhoneNumber
                            End If
                            If Not String.IsNullOrEmpty(challenge.Value.StepData.Email) Then
                                Frm_InstaVerifyInstance.RadioVerifyWithEmail.Checked = False
                                Frm_InstaVerifyInstance.RadioVerifyWithEmail.Visible = True
                                Frm_InstaVerifyInstance.RadioVerifyWithEmail.Text = challenge.Value.StepData.Email
                            End If
                            Frm_InstaVerifyInstance.SelectMethodGroupBox.Visible = True
                            Frm_InstaVerifyInstance.Size = ChallengeSize


                        End If

                        Frm_InstaVerifyInstance.Size = ChallengeSize
                        Frm_InstaVerifyInstance.InstaApi = InstaApi
                        If InstgramClient.ShowChallenge.Checked = True Then

                            If Frm_InstaVerifyInstance.ShowDialog(InstgramClient) = DialogResult.Cancel Then
                                GoTo ReportLogging
                            End If
                            GoTo Logagain
                        End If
ReportLogging:
                        items = New String() {"#", "#", "#", "#", "#", "", "#", "#"}
                        items(0) = Username
                        items(1) = Password
                        items(4) = "Challenge Required"
                        InstgramClient.BeginInvoke(New Action(Sub()
                                                                  InstgramClient.DT_AccountManager.Rows.Add(items)
                                                                  InstgramClient.XtraTabPage2.PageVisible = True
                                                              End Sub))
                        My.Computer.FileSystem.WriteAllText("instAcc\" & Username & ".dat", InstaApi.GetStateDataAsString(), False)

                    Else
                        LogReport(True, Username, challenge.Info.Message)
                    End If
                ElseIf (logInResult.Value = InstaLoginResult.TwoFactorRequired) Then
                    Frm_InstaVerifyInstance.TwoFactorGroupBox.Visible = True
                    Frm_InstaVerifyInstance.Size = ChallengeSize
                Else
                    LogReport(True, Username, $"{logInResult.Info?.Message}")
                End If
            Else
                mainCookieContainer = InstaApi.HttpRequestProcessor.HttpHandler.CookieContainer
                Dim cookieContainer = mainCookieContainer
                Dim uri = New Uri("https://www.instagram.com")
                For Each cookie In cookieContainer.GetCookies(uri)
                    fullCookies += cookie.ToString() & ";"
                Next cookie
                Dim infoCurrentUser = Await InstaApi.UserProcessor.GetUserInfoByUsernameAsync(Username)
                items = New String() {"#", "#", "#", "#", "#", "", "#", "#"}
                items(0) = Username
                items(1) = Password
                Try
                    items(2) = infoCurrentUser.Value.FollowerCount
                    items(3) = infoCurrentUser.Value.FollowingCount
                Catch ex As Exception

                End Try

                items(4) = "Good"


                items(5) = ProxyString
                items(6) = fullCookies
                items(7) = Regex.Match(fullCookies, "csrftoken=(.*?);").Groups.Item(1).Value


                InstgramClient.BeginInvoke(New Action(Sub()
                                                          InstgramClient.DT_AccountManager.Rows.Add(items)
                                                          InstgramClient.XtraTabPage2.PageVisible = True
                                                      End Sub))


                My.Computer.FileSystem.WriteAllText("instAcc\" & Username & ".dat", InstaApi.GetStateDataAsString(), False)
            End If
        Catch ex As Exception
            LogReport(True, Username, ex.Message)
        End Try
    End Function

    Private webRequest As HttpWebRequest
    Private webRequest2 As HttpWebRequest

    Public Async Function WebLoginAsync() As Task(Of Boolean)

        'GET URL 
        'Dim Page As String = Await GetAsync("https://www.instagram.com/accounts/login/?source=auth_switcher")

        'Dim LoginData As String = "username=ahmed1amen.i&password=esraamysoul5111999&enc_password=&queryParams=%7B%22source%22%3A%22auth_switcher%22%7D&optIntoOneTap=false"

        'Dim Page2 As String = Await POSTAsync("https://www.instagram.com/accounts/login/ajax/", LoginData)



        'https://www.instagram.com/accounts/login/ajax/

        'POST
        Return True

    End Function



End Class
