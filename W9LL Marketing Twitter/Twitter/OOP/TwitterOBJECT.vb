Imports HtmlAgilityPack
Imports Newtonsoft.Json.Linq
Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Windows.Forms
Imports HtmlDocument = HtmlAgilityPack.HtmlDocument
Public Class TwitterOBJECT
    Public isUserAuthnticted As Boolean = False
    Private IndexOfUser As Integer
    Private authenticity_token As String = String.Empty
    Private Xcsrf_token = String.Empty
    Public Property ProxyString As String = ""
    Private Property Proxy As New WebProxy
    Public taskID As String = "0"
    Public MaxSearchResult As Long
    Public Delay_Min = 0, Delay_Max As Integer = 0
    Private Shared _UserAgent As String = "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:29.0) Gecko/20100101 /29.0"
    Public loginErrorMsg As String = String.Empty
    Public CurrentAccount As String
    Public QureyType As String
    Public cookieContainer As CookieContainer = New CookieContainer()
    Dim auth_token As String = String.Empty
    Private Sub InitalizeProxy(proxyString As String)
        Dim proxyAdd As String = proxyString


        If proxyAdd = "" Or (proxyAdd.ToLower = "localproxy") Then

        Else
            Dim str1 As String() = proxyString.Split(":")
            Dim ipandportNumber, ProxyUserName, ProxyPassword As String
            ipandportNumber = str1(0) & ":" & str1(1)
            Proxy = New WebProxy(ipandportNumber, True)
            If str1.Length > 2 Then
                ProxyUserName = str1(2)
                ProxyPassword = str1(3)
                Proxy.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
            End If

        End If

    End Sub

    Public Shared Property UserAgent As String
        Get
            Return _UserAgent
        End Get
        Set(value As String)
            _UserAgent = value
        End Set
    End Property
    Function PrepareHeader(ByVal TwitterAPI As Boolean) As WebHeaderCollection
        Dim Head As New WebHeaderCollection
        If TwitterAPI = True Then
            Head.Add("Origin", "https://twitter.com")
            Head.Add("Authorization", My.Settings.BareerTok)
            Head.Add("x-twitter-auth-type", " OAuth2Session")
            Head.Add("x-csrf-token", Me.Xcsrf_token)
            Head.Add("-Twitter-Active-User", "yes")
            Return Head
        Else
            Return Head
        End If
    End Function
    Public Function Prevent() As Boolean
        If CurrentWorkingTask.PIDS.Contains(taskID) = True Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Creat_GET_Req(ByVal url As String, ByVal Referer As String, ByVal head As WebHeaderCollection, Optional host As String = "twitter.com", Optional Cookies As String = "") As WebResponse
        Dim httpRequest As HttpWebRequest = Nothing
        Dim httpPostStream As Stream = Nothing
        Dim httpResponseStream As BinaryReader = Nothing
        '  Try
        httpRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpRequest.Method = "GET"
        httpRequest.Headers = head
        httpRequest.ContentType = "application/x-www-form-urlencoded"
        httpRequest.Accept = "gzip"
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:29.0) Gecko/20100101 /29.0"
        httpRequest.Referer = Referer
        httpRequest.Host = host
        httpRequest.AutomaticDecompression = DecompressionMethods.GZip
        httpRequest.Timeout = 10000
        httpRequest.ReadWriteTimeout = 10000
        If ProxyString = "" Or (ProxyString.ToLower = "localproxy") Then
        Else
            httpRequest.Proxy = Proxy
        End If
        ServicePointManager.DefaultConnectionLimit = 200
        '        httpRequest.ProtocolVersion = HttpVersion.Version1
        httpRequest.CookieContainer = cookieContainer
        If Not Cookies = String.Empty Then
            ' httpRequest.Headers("Cookie") = Cookies
        End If
        '    Dim headerdata As Task(Of HttpWebResponse) = Response.
        Return httpRequest.GetResponse
        'Catch ex As WebException
        '    Dim Response As HttpWebResponse = ex.Response
        '    Dim Postreqreader As New StreamReader(Response.GetResponseStream())
        '    Dim headerdata As HttpWebResponse = Response
        '    Return httpRequest.GetResponseAsync
        'End Try
    End Function
    Function Creat_POST_ReqAsync(ByVal url As String, ByVal Referer As String, ByVal postdatax As String, ByVal head As WebHeaderCollection, Optional host As String = "twitter.com", Optional wantReturn As Boolean = False) As WebResponse
        If Prevent() = True Then
            Exit Function
        End If
        Dim httpRequest As HttpWebRequest = Nothing
        Dim httpPostStream As Stream = Nothing
        Dim httpResponseStream As BinaryReader = Nothing
        httpRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpRequest.Headers = head
        httpRequest.Method = "POST"
        httpRequest.Host = host
        httpRequest.Accept = "gzip"
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0"
        httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
        httpRequest.Referer = Referer
        httpRequest.ContentType = "application/x-www-form-urlencoded"
        httpRequest.KeepAlive = True
        httpRequest.CookieContainer = cookieContainer
        httpRequest.AutomaticDecompression = DecompressionMethods.GZip
        httpRequest.Timeout = 10000
        httpRequest.ReadWriteTimeout = 10000
        If ProxyString = "" Or (ProxyString.ToLower = "localproxy") Then
        Else
            httpRequest.Proxy = Proxy
        End If
        '   httpRequest.ContentType = "application/x-www-form-urlencoded"
        '   httpRequest.Headers("Accept-Language") = "en-US,en;q=0.9,ar;q=0.8"
        '   httpRequest.Headers("Upgrade-Insecure-Requests") = "1"
        '   httpRequest.Headers("Origin") = "https://twitter.com"
        '   httpRequest.Accept = "*/*"
        '   httpRequest.KeepAlive = True
        ServicePointManager.DefaultConnectionLimit = 200
        Dim xaaxax() As Byte = Encoding.ASCII.GetBytes(postdatax)
        httpRequest.ContentLength = xaaxax.Length
        'httpRequest.GetRequestStream.Write(xaaxax, 0, postdatax.Length)
        Dim dataStream As Stream = httpRequest.GetRequestStream()
        dataStream.Write(xaaxax, 0, postdatax.Length)
        dataStream.Close()
        If wantReturn = True Then   'Ask If You Want Function Return Http Post Response
            Return httpRequest.GetResponse
        Else
        End If
    End Function
    Public Property Cookies_Control(ByVal path As String) As CookieContainer
        Set(value As CookieContainer)
            If My.Computer.FileSystem.DirectoryExists("Sessions") = False Then
                My.Computer.FileSystem.CreateDirectory("Sessions")
            End If


            Using stream As New FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite)
                Try
                    Dim formatter As New BinaryFormatter()
                    formatter.Serialize(stream, value)
                Catch e As Exception
                    MsgBox("Problem writing cookies to disk: " & vbNewLine & e.Message)
                End Try
            End Using


        End Set

        Get
            Try
                Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                    Dim formatter As New BinaryFormatter()
                    Return CType(formatter.Deserialize(stream), CookieContainer)
                End Using
            Catch e As Exception
                Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> Reading Cookies Task : " & "حاول تحديث دخول الحساب      ")
                Return New CookieContainer

            End Try

        End Get
    End Property
    Public ReadOnly Property GetCookiesString As String
        Get
            If isUserAuthnticted = True Then


                Dim fullCookies As String = String.Empty
                Dim cookieCont = cookieContainer
                Dim uri = New Uri("https://www.twitter.com")
                For Each cookie In cookieCont.GetCookies(uri)
                    fullCookies += cookie.ToString() & ";"
                Next cookie


                Return fullCookies
            Else
                Throw New System.Exception("user is not authenticated Can't Get Cookies")

            End If
        End Get
    End Property
    Public Sub New()
        isUserAuthnticted = True
    End Sub
    Public Sub New(Optional usernme As String = "", Optional passowrd As String = "", Optional loadSesstion As Boolean = False, Optional IndexO As Integer = 9999, Optional proxy As String = "", Optional forcerun As Boolean = False)
        If usernme <> String.Empty Then
            CurrentAccount = usernme
            IndexOfUser = IndexO
            ProxyString = proxy
            InitalizeProxy(ProxyString)

            If forcerun = True Then
                CurrentWorkingTask.PIDS += taskID & " " ''''''''dannnger
            End If


            Try


                If loadSesstion = True Then
                    cookieContainer = Cookies_Control("Sessions\_" & usernme & ".dat")  'Load Cookies If You Have
                    Dim head As New WebHeaderCollection
                    Dim resPonseX As WebResponse
                    Dim postreqreader As StreamReader

                    resPonseX = Creat_GET_Req("https://twitter.com/", "https://twitter.com/", head)
                    postreqreader = New StreamReader(resPonseX.GetResponseStream())




                    'Dim document2 As New HtmlDocument
                    'document2.LoadHtml(postreqreader.ReadToEnd())
                    'Dim node As HtmlNode = document2.DocumentNode.SelectSingleNode("//input[@name='authenticity_token']")

                    'token = node.GetAttributeValue("value", "")


                    If Is_Valid_Login(postreqreader.ReadToEnd) = True Then
                        isUserAuthnticted = True
                    Else
                        isUserAuthnticted = False
                        Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> Check Login Of This Use : " & CurrentAccount)
                        Exit Sub
                    End If
                Else
                    Dim LoginTask As Task(Of Boolean) = Login(usernme, passowrd)  ''Call Twtitter Http Authentication 
                    LoginTask.Wait()
                    If LoginTask.Result = True Then         'If Authentication Okay
                        isUserAuthnticted = True
                    Else
                        isUserAuthnticted = False
                        Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> Check Login Of This Use : " & CurrentAccount)
                        Exit Sub
                    End If
                End If
                Try
                    Dim uri = New Uri("https://www.twitter.com")
                    For Each cookie As System.Net.Cookie In cookieContainer.GetCookies(uri)
                        If cookie.Name.ToLower = "auth_token" Then
                            authenticity_token = cookie.Value
                        End If
                        If cookie.Name = "ct0" Then
                            Xcsrf_token = cookie.Value
                        End If
                    Next cookie
                Catch ex As Exception
                    Throw New System.Exception("Error When Retrieving auth_token")
                End Try
            Catch ex As WebException
                Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + ex.Message)
                isUserAuthnticted = False
            End Try
        End If
    End Sub
    Public Function CheckLoginByHomePage(ByVal username As String, ByVal password As String)
        Dim document2 As New HtmlDocument
        Dim head As New WebHeaderCollection
        Dim resPonseX As WebResponse = Creat_GET_Req("https://twitter.com/", "https://twitter.com/home", head)
        Dim postreqreader As New StreamReader(resPonseX.GetResponseStream())
        document2.LoadHtml(postreqreader.ReadToEnd())
    End Function
    Public Async Function Login(ByVal username As String, ByVal password As String) As Task(Of Boolean)
        Dim head As New WebHeaderCollection
        Dim resPonseX As WebResponse = Creat_GET_Req("https://twitter.com/", String.Empty, head)
        Dim postreqreader As New StreamReader(resPonseX.GetResponseStream())
        Dim document2 As New HtmlDocument
        document2.LoadHtml(postreqreader.ReadToEnd())
        Dim node As HtmlNode = document2.DocumentNode.SelectSingleNode("//input[@name='authenticity_token']")
        Dim token As String = node.GetAttributeValue("value", String.Empty)
        Dim sess_username As String = "session[username_or_email]=" & username
        Dim sess_password As String = "&session[password]=" & password
        Dim authenticity_token As String = "&authenticity_token=" & token
        auth_token = token
        Dim addtiondata As String = "&return_to_ssl=true&scribe_log=" & My.Settings.key & "&redirect_after_login="
        Dim content As String = sess_username & sess_password & addtiondata & authenticity_token


        'Dim cookkv As String = twitter_sess & personalization_id & guest_id & ct0

        resPonseX = Creat_POST_ReqAsync("https://twitter.com/sessions", "https://twitter.com/", content, head, "twitter.com", True)

        postreqreader = New StreamReader(resPonseX.GetResponseStream())
        Dim Login_Content As String = postreqreader.ReadToEnd()


        If Is_Valid_Login(Login_Content) = True Then

            Dim uri = New Uri("https://www.twitter.com")
            For Each cookie As System.Net.Cookie In cookieContainer.GetCookies(uri)

            Next

            Cookies_Control("Sessions\_" & username & ".dat") = cookieContainer 'Save Cookies
            isUserAuthnticted = True
            Return True
        Else
            Return False

        End If







    End Function



    Function Is_Valid_Login(ByVal Login_Content As String) As Boolean

        Dim document2 As New HtmlDocument
        document2.LoadHtml(Login_Content)



        If Login_Content.ToLower.Contains("your identity by entering the email address") Or Login_Content.ToLower.Contains("your identity by entering the phone number") Then
            Dim str3 As String = String.Empty
            Dim node1 As HtmlNode = document2.DocumentNode.SelectSingleNode("//input[@name='challenge_type']")
            If CType(node1, Object) Is Nothing Then
            Else
                str3 = node1.Attributes.Item("value").Value
            End If
            If str3.Contains("RetypePhoneNumber") Then
                loginErrorMsg = "Account need confirm phone number to continute login"

                Return False
            End If
            loginErrorMsg = "Account need confirm email to continute login"
            Return False
        End If
        If CType(document2.DocumentNode.SelectSingleNode("//form[contains(@action,'account/access')]"), Object) Is Nothing Then
        Else
            loginErrorMsg = "Account need verify to continute login"
            Return False
        End If
        If CType(document2.DocumentNode.SelectSingleNode("//div[@class='form_row captcha']"), Object) Is Nothing Then
        Else
            Exit Function
        End If
        If CType(document2.DocumentNode.SelectSingleNode("//input[@name='session[username_or_email]']"), Object) Is Nothing Then
        Else
            loginErrorMsg = "Wrong username or password!"
            Return False
        End If
        If Login_Content.ToLower.Contains("login limit exceeded") Then
            loginErrorMsg = "Login limit exceeded.Please wait one hour before trying to log in again"
            Return False
        End If

        Return True

    End Function

#Region "Method & Functions"




    Public Sub MediaTest()

        'Dim client As New WebClient
        'Dim opf As New OpenFileDialog
        'Dim head As New WebHeaderCollection
        'Dim byestx2 As Byte()
        'byestx2 = IO.File.ReadAllBytes("Sessions\test.png")

        'CurrentWorkingTask.PIDS += taskID & " "


        'Dim resPonseX As Task(Of HttpWebResponse)
        'Dim urlAs As String = "https://upload.twitter.com/i/media/upload.json?command=INIT&total_bytes=" & byestx2.Length & "&media_type=image%2Fpng&media_category=tweet_image"
        'resPonseX = Creat_POST_ReqAsync(urlAs, "https://twitter.com/" & CurrentAccount, "", head, "upload.twitter.com", "", True)
        'Dim postreqreader As StreamReader
        'postreqreader = New StreamReader(resPonseX.Result.GetResponseStream())



        'Dim o As JObject = JObject.Parse(postreqreader.ReadToEnd)
        'Dim results As List(Of JToken) = o.Children().ToList


        ''<= 5 MB


        '' head.Add("Connection", "keep-alive")
        '' head.Add("Content-Length", byestx2.ToString)

        'Dim boundary As String = "----------------------------" & Date.Now.Ticks.ToString("x", NumberFormatInfo.InvariantInfo)
        'head.Add("Origin", "https://twitter.com")
        'head.Add("User-Agent", UserAgent)
        'head.Add("Accept", "*/*")
        'head.Add("Referer", "https://twitter.com/compose/tweet")
        'head.Add("Referer", "https://twitter.com/AhmedAmen_T")
        'head.Add("Accept-Encoding", "gzip")
        'head.Add("Accept-Language", "en-US, en;q=0.9, ar;q=0.8")
        ''head.Add("Content-Type", "multipart/form-data; boundary=" & boundary)
        'head.Add("Cookie", GetCookiesString)
        'client.Headers = head


        '       Dim dest(170936) As Byte
        '        Array.Copy(byestx2, 0, dest, 0, 170936)

        '   client.UploadData("https://upload.twitter.com/i/media/upload.json?command=APPEND&media_id=" & o.Item("media_id_string").ToString & "&segment_index=0", dest)






    End Sub

    Public Async Function LikeTweetAsync(ByVal TweetID As String, ByVal TeewetOwnerAccount As String) As Task
        Try
            Dim resPonseX As HttpWebResponse
            Dim Parameter As String = "include_entities=false"
            resPonseX = Creat_POST_ReqAsync("https://api.twitter.com/1.1/favorites/create.json?id=" & TweetID, String.Empty, Parameter, PrepareHeader(True), "api.twitter.com", True)

            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(resPonseX.GetResponseStream())
            Dim Message As String = postreqreader.ReadToEnd


            Controller.MainInstance.Grid_Control_Tweeting_Report_Users.BeginInvoke(New Action(Sub() Controller.MainInstance.DT_Tweeting_Report_Users.Rows.Add({TweetID, QureyType & " OK ", CurrentAccount})))


            Dim randomx As New Random
            Dim Sleepi As Integer = (randomx.Next(Delay_Min, Delay_Max)) * 1000
            System.Threading.Thread.Sleep(Sleepi)

        Catch ex As WebException


            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(ex.Response.GetResponseStream)
            Dim rawJson As String = postreqreader.ReadToEnd

            Dim o As JObject = JObject.Parse(rawJson)

            If rawJson.Contains("errors") Then
                Dim errormsg As String = CStr(o("errors")(0)("message"))
                Controller.MainInstance.Grid_Control_Tweeting_Report_Users.BeginInvoke(New Action(Sub() Controller.MainInstance.DT_Tweeting_Report_Users.Rows.Add({TweetID, QureyType & " Error " + errormsg, CurrentAccount})))

            End If
        End Try

    End Function
    Public Async Function RetweetAsync(ByVal TweetID As String) As Task
        Try
            Dim resPonseX As HttpWebResponse
            Dim Parameter As String = "tweet_mode=extended"
            resPonseX = Creat_POST_ReqAsync("https://api.twitter.com/1.1/statuses/retweet/" & TweetID & ".json", String.Empty, Parameter, PrepareHeader(True), "api.twitter.com", True)


            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(resPonseX.GetResponseStream())
            Dim Message As String = postreqreader.ReadToEnd

            Controller.MainInstance.Grid_Control_Tweeting_Report_Users.BeginInvoke(New Action(Sub() Controller.MainInstance.DT_Tweeting_Report_Users.Rows.Add({TweetID, QureyType & " OK ", CurrentAccount})))

            Dim randomx As New Random

            Dim Sleepi As Integer = (randomx.Next(Delay_Min, Delay_Max)) * 1000
            System.Threading.Thread.Sleep(Sleepi)


        Catch ex As WebException


            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(ex.Response.GetResponseStream)
            Dim rawJson As String = postreqreader.ReadToEnd

            Dim o As JObject = JObject.Parse(rawJson)

            If rawJson.Contains("errors") Then
                Dim errormsg As String = CStr(o("errors")(0)("message"))
                Controller.MainInstance.Grid_Control_Tweeting_Report_Users.BeginInvoke(New Action(Sub() Controller.MainInstance.DT_Tweeting_Report_Users.Rows.Add({TweetID, QureyType & " Error " + errormsg, CurrentAccount})))

            End If
        End Try
    End Function
    Public Async Sub ScrapFollowers(ByVal username As String, Optional target As String = "followers")
        Dim counter As Long = 0
        Try
            Dim dictionary As New Dictionary(Of String, String)

            Dim head As New WebHeaderCollection
            Dim document2 As New HtmlDocument
            Dim refeee As String = "https://twitter.com/" & username & "/" & target
            Dim resPonseX As WebResponse
            resPonseX = Creat_GET_Req("https://twitter.com/" & username & "/" & target, refeee, head,)
            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(resPonseX.GetResponseStream())
            document2.LoadHtml(postreqreader.ReadToEnd())
            Dim nodes As HtmlAgilityPack.HtmlNodeCollection = document2.DocumentNode.SelectNodes("//div[contains(@class,'ProfileCard js-actionable-user')]")
            Dim node As HtmlNode = document2.DocumentNode.SelectSingleNode("//div[contains(@class,'GridTimeline-items') or contains(@class,'stream-container')]")
            Dim data_pos As String = node.Attributes.Item("data-min-position").Value.ToString()



            For Each item As HtmlNode In nodes
                dictionary.Add(item.Attributes.Item("data-screen-name").Value.ToString(), item.Attributes.Item("data-user-id").Value.ToString())

            Next



repate:
            resPonseX = Creat_GET_Req("https://twitter.com/" & username & "/followers/users?include_available_features=1&include_entities=1&max_position=" & data_pos & "&reset_error_state=false" & username & "/followers", "https://twitter.com/" & username & "/followers", head)

            postreqreader = New StreamReader(resPonseX.GetResponseStream())

            Dim o As JObject = JObject.Parse(postreqreader.ReadToEnd)
            Dim results As List(Of JToken) = o.Children().ToList

            If Prevent() = True Then Exit Sub



            If o.Item("has_more_items").ToString.ToLower = "true" Then


                document2.LoadHtml(o.Item("items_html").ToString())
                data_pos = o.Item("min_position").ToString()
                nodes = document2.DocumentNode.SelectNodes("//div[contains(@class,'ProfileCard js-actionable-user')]")

                For Each item As HtmlNode In nodes
                    dictionary.Add(item.Attributes.Item("data-screen-name").Value.ToString(), item.Attributes.Item("data-user-id").Value.ToString())

                Next

                'Controller.MainInstance.TextBox1.Text = dictionary.Keys.Count

                For Each pair In dictionary


                    ''     Dim dr As DataRow = Controller.MainInstance.DT_Scrapper_Report_Users.NewRow()
                    '     dr(0) = pair.Key
                    '      dr(1) = pair.Value
                    '   'Controller.MainInstance.DT_Scrapper_Report_Users.Rows.Add(dr)
                    Controller.MainInstance.Grid_Scrapper_Report_Users.BeginInvoke(New Action(Sub()


                                                                                                  Controller.MainInstance.DT_Scrapper_Report_Users.Rows.Add({pair.Value, pair.Key, QureyType, CurrentAccount})

                                                                                              End Sub))
                    '       UpdateGridDataSource({pair.Key, pair.Value})

                    counter += 1
                Next

                If counter >= MaxSearchResult Then
                    NotifyTaskFinished(taskID, True)
                    Exit Sub
                End If

                Dim randomx As New Random()

                Await Task.Delay((randomx.Next(1, 3)) * 1000)

                GoTo repate



            End If

            NotifyTaskFinished(taskID, True)

        Catch ex As Exception
            NotifyTaskFinished(taskID, False)
            Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> ScrapFollowers Task : " & ex.Message)
            Exit Sub
        End Try


    End Sub


    Private Sub NotifyTaskFinished(ByVal taskID As String, ByVal DoneWell As Boolean)


        For Each row As DataRow In Controller.MainInstance.DT_ListOfTasks.Rows

            If row("ID").ToString() = taskID Then
                Controller.MainInstance.Grid_Running_Tasks.BeginInvoke(New Action(Sub()
                                                                                      If DoneWell = True Then
                                                                                          row("Status") = TaskStatus.Finished
                                                                                      Else
                                                                                          row("Status") = TaskStatus.Failed
                                                                                      End If
                                                                                      row.Delete()
                                                                                  End Sub))
            End If




        Next

    End Sub


    Public Async Sub GetTweetInfo(ByVal TweetID_P As String)
        Try
            Dim resPonseX As HttpWebResponse


            resPonseX = Creat_GET_Req("https://api.twitter.com/1.1/statuses/show.json?id=" & TweetID_P & "&include_card_uri=false&include_my_retweet=false&trim_user=false", String.Empty, PrepareHeader(True), "api.twitter.com")

            Dim postreqreader As StreamReader

            postreqreader = New StreamReader(resPonseX.GetResponseStream())

            Dim rawJson As String = postreqreader.ReadToEnd
            Dim o As JObject = JObject.Parse(rawJson)
            Dim results As List(Of JToken) = o.Children().ToList






            Dim TweetID As String = o.Item("id_str").ToString
            Dim TweetText As String = o.Item("text").ToString
            Dim Favourites_Count As String = o.Item("favorite_count").ToString
            Dim Retweet_Count As String = o.Item("retweet_count").ToString
            Dim Created_At As String = o.Item("created_at").ToString


            Controller.MainInstance.Grid_Scrapper_Report_Users.BeginInvoke(
                New Action(Sub()

                               For Each row As DataRow In Controller.MainInstance.DT_Tweets.Rows
                                   If row("ID").ToString() = TweetID_P Then
                                       row("TweetText") = TweetText
                                       row("Favourites_Count") = Favourites_Count
                                       row("Retweet_Count") = Retweet_Count
                                       row("Created_At") = Created_At
                                   End If
                               Next
                           End Sub))
            TweetsDataTable_Control = Controller.MainInstance.DT_Tweets
        Catch ex As Exception
            Controller.MainInstance.ListBoxControl1.Items.Add("--Error--- >>> Get Tweet Info : Unable Get This Tweet")
        End Try






    End Sub


    Public Async Function GetLastTweetAsync() As Task(Of Boolean)

        Try








            Dim resPonseX = Creat_GET_Req("https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name=" & CurrentAccount & "&count=1&trim_user=true", String.Empty, PrepareHeader(True), "api.twitter.com")



            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(resPonseX.GetResponseStream())

            Dim rawJson As String = postreqreader.ReadToEnd

            rawJson = rawJson.Substring(1, rawJson.Length - 2)

            Dim o As JObject = JObject.Parse(rawJson)
            Dim results As List(Of JToken) = o.Children().ToList


            Try
                Dim TweetID As String = o.Item("id_str").ToString
                Dim TweetText As String = o.Item("text").ToString
                Dim Favourites_Count As String = o.Item("favorite_count").ToString
                Dim Retweet_Count As String = o.Item("retweet_count").ToString
                Dim Created_At As String = o.Item("created_at").ToString

                Controller.MainInstance.Grid_Scrapper_Report_Users.BeginInvoke(
                    New Action(Sub()

                                   Controller.MainInstance.DT_Tweets.Rows.Add({TweetID, TweetText, Favourites_Count, Retweet_Count, Created_At, CurrentAccount})
                                   TweetsDataTable_Control = Controller.MainInstance.DT_Tweets
                               End Sub))


            Catch ex As Exception

            End Try
            Return True



        Catch ex As WebException



            Dim postreqreader As StreamReader
            postreqreader = New StreamReader(ex.Response.GetResponseStream)
            Dim rawJson As String = postreqreader.ReadToEnd

            Dim o As JObject = JObject.Parse(rawJson)

            If rawJson.Contains("errors") Then
                Dim errormsg As String = CStr(o("errors")(0)("message"))

                Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + errormsg)
            End If



            Return False




        End Try



    End Function
    Public Sub ScrapByKeyword(ByVal keyword As String)
        '  Try
        Dim counter As Long = 0

        Dim dictionary As New Dictionary(Of String, String)

        Dim head As New WebHeaderCollection
        Dim document2 As New HtmlDocument


        If keyword.Contains("#") Then
            keyword = keyword.Replace("#", "%23")
        End If


        Dim resPonseX As WebResponse
        resPonseX = Creat_GET_Req("https://twitter.com/search?f=tweets&vertical=default&src=typd&q=" & keyword & "&src=unkn", "https://twitter.com/sw.js", head)
        Dim postreqreader As StreamReader
        postreqreader = New StreamReader(resPonseX.GetResponseStream())



        document2.LoadHtml(postreqreader.ReadToEnd())



        Dim nodes As HtmlAgilityPack.HtmlNodeCollection = document2.DocumentNode.SelectNodes("//div[@data-screen-name]")

        Dim node As HtmlNode = document2.DocumentNode.SelectSingleNode("//div[@data-min-position]")
        Dim data_pos As String = node.Attributes.Item("data-min-position").Value.ToString()



        For Each item As HtmlNode In nodes
            Try
                dictionary.Add(item.Attributes.Item("data-screen-name").Value.ToString(), item.Attributes.Item("data-user-id").Value.ToString())
            Catch ex As Exception

            End Try

        Next



repate:
        resPonseX = Creat_GET_Req("https://twitter.com/i/search/timeline?f=tweets&vertical=news&q=" & keyword & "&src=typd&include_available_features=1&include_entities=1&max_position=" & data_pos & "&reset_error_state=false", "https://twitter.com/search?f=tweets&vertical=news&q=" & keyword & "&src=typd", head)

        postreqreader = New StreamReader(resPonseX.GetResponseStream())

        Dim o As JObject = JObject.Parse(postreqreader.ReadToEnd)
        Dim results As List(Of JToken) = o.Children().ToList

        If Prevent() = True Then Exit Sub



        If Not (o.Item("items_html").ToString = String.Empty) Then


            document2.LoadHtml(o.Item("items_html").ToString())
            data_pos = o.Item("min_position").ToString()
            nodes = document2.DocumentNode.SelectNodes("//div[@data-screen-name]")

            For Each item As HtmlNode In nodes
                Try
                    dictionary.Add(item.Attributes.Item("data-screen-name").Value.ToString(), item.Attributes.Item("data-user-id").Value.ToString())
                Catch ex As Exception

                End Try

            Next

            'Controller.MainInstance.TextBox1.Text = dictionary.Keys.Count

            For Each pair In dictionary

                ''     Dim dr As DataRow = Controller.MainInstance.DT_Scrapper_Report_Users.NewRow()
                '     dr(0) = pair.Key
                '      dr(1) = pair.Value
                '   'Controller.MainInstance.DT_Scrapper_Report_Users.Rows.Add(dr)
                Controller.MainInstance.Grid_Scrapper_Report_Users.BeginInvoke(New Action(Sub()


                                                                                              Controller.MainInstance.DT_Scrapper_Report_Users.Rows.Add({pair.Value, pair.Key, QureyType, CurrentAccount})

                                                                                          End Sub))
                '       UpdateGridDataSource({pair.Key, pair.Value})
                counter += 1
            Next

            If counter >= MaxSearchResult Then
                NotifyTaskFinished(taskID, True)
                Exit Sub
            End If


            GoTo repate



        End If




        NotifyTaskFinished(taskID, True)
        '  Catch ex As Exception
        '  NotifyTaskFinished(taskid, False)
        '  Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> Scrap By KeyWord Task : " & ex.Message)
        '  End Try
    End Sub
    Public Async Function Get_Trending_HashTagAsync(ByVal Country As String) As Task
        Dim httpRequest As HttpWebRequest = Nothing
        Dim httpPostStream As Stream = Nothing
        Dim httpResponseStream As BinaryReader = Nothing
        '   httpRequest = CType(WebRequest.Create("http://tweeplers.com/hashtags/?cc=" & Country), HttpWebRequest)
        httpRequest = CType(WebRequest.Create("https://getdaytrends.com/" & Country), HttpWebRequest)
        httpRequest.Method = "GET"
        httpRequest.ContentType = "application/x-www-form-urlencoded"
        httpRequest.Accept = "*/*"
        httpRequest.Headers("Upgrade-Insecure-Requests") = "1"
        httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:46.0) Gecko/20100101 Firefox/46.0"
        httpRequest.Headers("Accept-Language") = "en-US,en;q=0.9,ar;q=0.8"
        httpRequest.Host = "getdaytrends.com"

        Dim Response As HttpWebResponse = Await httpRequest.GetResponseAsync()
        Dim Postreqreader As New StreamReader(Response.GetResponseStream())
        Dim headerdata As HttpWebResponse = Response



        Dim doc As New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(Postreqreader.ReadToEnd)
        Dim hashCollection As HtmlNodeCollection
        hashCollection = doc.DocumentNode.SelectNodes("//*[@id='table-body']/tr")

        Dim dt As DataTable = New DataTable("trend")



        dt.Columns.Add("rank", Type.GetType("System.Int32"))
        dt.Columns.Add("trend", Type.GetType("System.String"))
        dt.Columns.Add("tweetcount", Type.GetType("System.String"))


        For Each node As HtmlNode In hashCollection
            If node.OuterHtml.ToLower.Contains("colspan") = False Then
                dt.Rows.Add({CInt(node.ChildNodes(1).InnerText), node.ChildNodes(3).ChildNodes(0).InnerText, WebUtility.HtmlDecode(node.ChildNodes(3).ChildNodes(2).InnerText).ToLower.Replace("tweet count:", "")})
                '        MsgBox(node.ChildNodes(1).InnerText & " " & node.ChildNodes(3).ChildNodes(0).InnerText & " " & WebUtility.HtmlDecode(node.ChildNodes(3).ChildNodes(2).InnerText))
            End If
        Next
        Controller.Grid_Control_Trend.DataSource = dt
        '  //*[@id="table-body"]/tr/td[2]/span
        'Dim Rank, name, Twcount As String

        'For countEle As Integer = 1 To 20  
        '    Rank = countEle
        '    name = doc.DocumentNode.SelectSingleNode("//*[@id='item_u_" & countEle & "']").Attributes("name").Value
        '    Twcount = doc.DocumentNode.SelectSingleNode("//*[@id='item_c_" & countEle & "']").InnerText

        '    Dim lvi As New ListViewItem(countEle)
        '    lvi.SubItems.AddRange(New String() {"#" & name, Twcount})
        '    Controller.ListView6.Items.Add(lvi)


        'Next





    End Function
    Public Sub Follow_UnFollowAsync(ByVal ListIDS As String(), Optional Operation As String = "follow")
        For Each userid As String In ListIDS

            If Prevent() = True Then
                Exit Sub
            End If


            Dim Parameter As String = "include_entities=false&user_id=" & userid
            Dim urlOperation As String = "https://api.twitter.com/1.1/friendships/create.json"
            If Operation = "unfollow" Then
                urlOperation = "https://api.twitter.com/1.1/friendships/destroy.json"
            End If
            Try
                Dim resPonseX As WebResponse
                resPonseX = Creat_POST_ReqAsync("https://api.twitter.com/1.1/friendships/create.json", "", Parameter, PrepareHeader(True), "api.twitter.com", True)

                Controller.MainInstance.Grid_Control_Following_Report.BeginInvoke(New Action(Sub() Controller.MainInstance.DT_Following_Report.Rows.Add({Operation & " " & userid & " OK ", CurrentAccount})))

            Catch ex As WebException
                Try
                    Dim postreqreader As StreamReader
                    postreqreader = New StreamReader(ex.Response.GetResponseStream)

                    Dim rawJson As String = postreqreader.ReadToEnd

                    Dim o As JObject = JObject.Parse(rawJson)
                    If rawJson.Contains("errors") Then
                        Dim errormsg As String = CStr(o("errors")(0)("message"))
                        Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + errormsg)

                    End If
                Catch Message As Exception
                    Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + ex.Message)

                End Try

            End Try

            Dim randomx As New Random
            Dim Sleepi As Integer = (randomx.Next(Delay_Min, Delay_Max)) * 1000
            System.Threading.Thread.Sleep(Sleepi)

        Next
    End Sub

    Public Function Comment_tweet(ByVal TweetID As String, ByVal CurrentUsers As String, ByVal rowhandle As Integer) As Boolean
        Try
            'Dim Fult As Integer = 0
            'Dim Succced As Integer = 0
            'Dim total As Integer = comment.Count
            'Dim tempraay As String() = comment

            'While (comment.Length <> 0)
            '    Dim CurrentUsers As String = String.Empty

            '    If comment.Length >= 10 Then
            '        tempraay = comment.Take(10).ToArray
            '        comment = comment.Skip(10).ToArray
            '    Else
            '        tempraay = comment
            '        ReDim comment(-1)
            '    End If



            '    For Each usrName As String In tempraay

            '        CurrentUsers += "@" + usrName & " "

            '    Next



            Dim Content_data As String
            Content_data = "include_profile_interstitial_type=1&include_blocking=1&include_blocked_by=1&include_followed_by=1&include_want_retweets=1&include_mute_edge=1&include_can_dm=1&include_can_media_tag=1&skip_status=1&cards_platform=Web-12&include_cards=1&include_composer_source=true&include_ext_alt_text=true&include_reply_count=1&tweet_mode=extended&trim_user=false&include_ext_media_color=true&include_ext_media_availability=true&auto_populate_reply_metadata=true&batch_mode=off&in_reply_to_status_id=" + TweetID + "&status=" + CurrentUsers

            Try

                Dim resPonseX As WebResponse
                resPonseX = Creat_POST_ReqAsync("https://api.twitter.com/1.1/statuses/update.json", "https://twitter.com/compose/tweet", Content_data, PrepareHeader(True), "api.twitter.com", True)
                '     Succced += tempraay.Count

                '     frm.InvokeData(rowhandle, Succced, Fult, total)


                '   frm.Grid_View_Mentions.SetRowCellValue(rowhandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))

                'Frm.Grid_Control_Mentions.Invoke(New Action(Sub() 

            Catch ex As WebException


                '    Fult += CurrentUsers.Count
                'Frm_Mentions.Grid_View_Mentions.SetRowCellValue(rowhandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))
                Dim postreqreader As StreamReader
                postreqreader = New StreamReader(ex.Response.GetResponseStream)
                Dim rawJson As String = postreqreader.ReadToEnd
                Try

                    Dim o As JObject = JObject.Parse(rawJson)


                    If rawJson.Contains("errors") Then
                        Dim errormsg As String = CStr(o("errors")(0)("message"))

                        Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + errormsg)
                    End If
                    Return False
                Catch Messagex As Exception

                    Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + ex.Message)
                    Return False
                End Try
                Return False
            Catch exa As Exception
                '   Fult += CurrentUsers.Count
                'Frm_Mentions.Grid_View_Mentions.SetRowCellValue(rowhandle, "Status", String.Format("{0}/{1} : {2}", Succced, Fult, total))
                Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> " + CurrentAccount + "   " + exa.Message)
                Return False
            End Try



            Dim randomx As New Random
            Dim Sleepi As Integer = (randomx.Next(Delay_Min, Delay_Max)) * 1000
            System.Threading.Thread.Sleep(Sleepi)

            Return True
            '  End While
            'Controller.MainInstance.TextBox1.Text = ciu

        Catch ex As Exception
            Controller.MainInstance.ListBoxControl1.Items.Add(taskID & ": ---Error--- >>> Comment Task : " + CurrentAccount + " : " & ex.Message)
            Return False
        End Try

    End Function

#End Region
End Class
'Public Function Tweet(Optional Tweet_TXT As String = "", Optional Cookies As String = "", Optional proxy As String = "") As Task(Of Boolean)
'    Return Threading.Tasks.Task.Factory.StartNew(Of Boolean)(
'    Function() As Boolean
'        'Javascript-enabled: true
'        'XRequestedWith: XMLHttpRequest
'        Dim head As New WebHeaderCollection
'        head.Add("Javascript-enabled", "True")
'        head.Add("XRequestedWith", "True")
'        Try
'            Creat_POST_ReqAsync("https://twitter.com/i/tweet/create", "https://twitter.com/", "authenticity_token=" & auth_token & "&place_id=&status=" & Tweet_TXT, head, "twitter.com", proxy)
'        Catch ex As WebException
'            MsgBox(ex.Message, "Error")
'            Return False
'            Exit Function
'        End Try
'        Return True
'    End Function)
'End Function
''Async Sub Getauthenticity_token(ByVal coox As String)
''    Dim head As New WebHeaderCollection
''    Dim resPonseX As HttpWebResponse = Await Creat_GET_Req("https://twitter.com/", "", head, coox)
''    Dim postreqreader As New StreamReader(resPonseX.GetResponseStream())
''    authenticity_token = (Regex.Match(postreqreader.ReadToEnd(), "ue=" & Chr(34) & "(.*?)" & Chr(34) & " ").Groups.Item(1).Value)
''End Sub