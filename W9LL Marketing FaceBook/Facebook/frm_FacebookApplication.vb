Imports System.Text
Imports System.Net
Imports System.IO
Imports Facebook
Imports Newtonsoft.Json.Linq
Imports System.Net.Cache
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Dynamic
Imports Facebook.ClientHTML.Sdk
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports HtmlAgilityPack
Imports System.Web
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.XtraBars
Imports AutoUpdaterDotNET

Public Class frm_FacebookApplication
    Public DT_AccountManager As DataTable = New DataTable

    Public cooooo As String = ""
    Dim authtoken As Regex = New Regex("(async_get_token" & Chr(34) & ":" & Chr(34) & ")" & "(.*?)(" & Chr(34) & "},)")
    '(cursor:"")(.*?)("")
    Dim cursoX As Regex = New Regex("(cursor:" & Chr(34) & ")(.*?)(" & Chr(34) & ")")
    '\d+(,""ra)
    Dim dataid As Regex = New Regex("\d+(," & Chr(34) & "ra)")
    Public Function SearchGroup(keyword As String, ByRef cursor As String, ByRef async_get_token As String, ByRef ismobile As Boolean, page As Integer) As List(Of GroupSearchResult)
        Dim list As List(Of GroupSearchResult) = New List(Of GroupSearchResult)()
        Dim text As String = ""

        If cursor = "" Then
            Dim url As String = String.Format("https://{0}.facebook.com/search/groups/?q=", If(ismobile, "web", "www")) + HttpUtility.UrlEncode(keyword)
            text = HttpRequest.GetRequestText(url, "GET", Nothing, "", cooooo, "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0", Nothing, True, False, "application/x-www-form-urlencoded;")
            Dim flag2 As Boolean = Not text = ""
            If flag2 Then
                Dim htmlDocument As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument()
                htmlDocument.LoadHtml(text)
                async_get_token = authtoken.Match(text).Groups.Item(2).Value
                Dim htmlNodeCollection As HtmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//code")
                text = ""
                Dim flag3 As Boolean = htmlNodeCollection IsNot Nothing
                If flag3 Then
                    For Each htmlNode As HtmlNode In CType(htmlNodeCollection, IEnumerable(Of HtmlNode))
                        Dim flag4 As Boolean = htmlNode.InnerHtml.Contains("BrowseResultsContainer") OrElse htmlNode.InnerHtml.Contains("all_search_results")
                        If flag4 Then
                            text = htmlNode.InnerHtml.TrimEnd("-->".ToCharArray()).TrimStart("<!--".ToCharArray())
                            Dim htmlNode2 As HtmlNode = htmlDocument.DocumentNode.SelectSingleNode("//script[contains(., 'pageletComplete')]")

                            Dim flag5 As Boolean = htmlNode2 IsNot Nothing
                            If flag5 Then


                                '  
                                cursor = cursoX.Match(htmlNode2.InnerText).Groups.Item(0).Value.Replace("cursor:" & Chr(34), "").Replace(Chr(34), "")

                            End If
                            Exit For
                        End If
                    Next
                End If
            End If
        Else
            Dim url As String = String.Format("https://{2}.facebook.com/ajax/pagelet/generic.php/BrowseScrollingSetPagelet?fb_dtsg_ag={4}&dpr=1&data=%7B%22view%22%3A%22list%22%2C%22encoded_query%22%3A%22%7B%5C%22bqf%5C%22%3A%5C%22keywords_groups({0})%5C%22%2C%5C%22browse_sid%5C%22%3Anull%2C%5C%22vertical%5C%22%3A%5C%22content%5C%22%2C%5C%22post_search_vertical%5C%22%3Anull%7D%22%2C%22encoded_title%22%3A%22WyJtYXJrZXRpbmciXQ%22%2C%22ref%22%3A%22unknown%22%2C%22logger_source%22%3A%22www_main%22%2C%22typeahead_sid%22%3A%22%22%2C%22tl_log%22%3Afalse%2C%22impression_id%22%3A%22c8ae3156%22%2C%22filter_ids%22%3A%7B%7D%2C%22experience_type%22%3A%22grammar%22%2C%22exclude_ids%22%3Anull%2C%22browse_location%22%3A%22browse_location%3Abrowse%22%2C%22trending_source%22%3Anull%2C%22reaction_surface%22%3Anull%2C%22reaction_session_id%22%3Anull%2C%22ref_path%22%3A%22%2Fsearch%2Fgroups%2F%22%2C%22is_trending%22%3Afalse%2C%22topic_id%22%3Anull%2C%22place_id%22%3Anull%2C%22story_id%22%3Anull%2C%22callsite%22%3A%22browse_ui%3Ainit_result_set%22%2C%22has_top_pagelet%22%3Atrue%2C%22display_params%22%3A%7B%22crct%22%3A%22none%22%7D%2C%22cursor%22%3A%22{1}%22%2C%22page_number%22%3A{3}%2C%22em%22%3Afalse%2C%22tr%22%3Anull%7D&__a=1&__af=h0&__req=j&__be=1&__pc=EXP1:home_page_pkg", New Object() {keyword, cursor, If(ismobile, "web", "www"), page, async_get_token})
            text = HttpRequest.GetRequestText(url, "GET", Nothing, Nothing, cooooo, "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0", Nothing, True, False, "application/x-www-form-urlencoded;")
            Dim flag6 As Boolean = Not text = ""
            If flag6 Then

                text = text.Replace("for (;;);", "")

                Dim fdate = JObject.Parse(text)("payload")
                text = fdate

            End If
        End If

        Dim flag9 As Boolean = Not text = ""
        If flag9 Then
            Dim flag10 As Boolean = Not ismobile AndAlso text.Contains("web.facebook")
            If flag10 Then
                ismobile = True
            End If
            Dim htmlDocument2 As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument()
            htmlDocument2.LoadHtml(text)
            Dim htmlNodeCollection2 As HtmlNodeCollection = htmlDocument2.DocumentNode.SelectNodes("//div[contains(@data-bt, 'id') and contains(@data-bt, 'rank')]")
            Dim flag11 As Boolean = htmlNodeCollection2 IsNot Nothing
            If flag11 Then


                Dim count As Integer = 0


                For Each htmlNode3 As HtmlNode In CType(htmlNodeCollection2, IEnumerable(Of HtmlNode))
                    Dim text2 As String = Web.HttpUtility.HtmlDecode(htmlNode3.GetAttributeValue("data-bt", ""))
                    text2 = dataid.Match(text2).Groups.Item(0).Value.Replace("," & Chr(34) & "ra", "")
                    Dim flag12 As Boolean = Not text = ""
                    If flag12 Then

                        Dim name As String = ""
                        Dim gMnum As String = ""
                        Dim htmlNodeCollection3 As HtmlNodeCollection = htmlNode3.SelectNodes(".//a[contains(@href, '/groups/')]")
                        Dim htmlNodeCollection4 As HtmlNodeCollection = htmlNode3.SelectNodes("//*[@class='_pac']/text()[1]")
                        Dim flag13 As Boolean = htmlNodeCollection3 IsNot Nothing AndAlso htmlNodeCollection3.Count > 1
                        Dim flag14 As Boolean = htmlNodeCollection4 IsNot Nothing AndAlso htmlNodeCollection4.Count > 1
                        If flag13 Then
                            name = HttpUtility.HtmlDecode(htmlNodeCollection3(1).InnerText)
                        End If
                        If flag14 Then
                            gMnum = htmlNodeCollection4(count).InnerText.ToLower.Replace("members", "")
                            If gMnum.ToLower.Contains("k") Then
                                gMnum = gMnum.ToLower.Replace("k", "")
                                Dim xxx As Integer = gMnum * 1000
                                gMnum = xxx
                            End If
                            count += 1

                        End If

                        list.Add(New GroupSearchResult(text2, name, ""))

                        Dim listView As New ListView()
                        Dim item1 As New ListViewItem("")
                        item1.SubItems.Add(name)
                        item1.SubItems.Add(text2)
                        item1.SubItems.Add(gMnum)
                        Me.Invoke(New Action(Sub()




                                                 ListView_currentLogginUser_searchResult.Items.Add(item1)


                                             End Sub))






                    End If
                Next
            End If
        End If

        Return list
    End Function


    Dim mycontainer2 As New CookieContainer()
    Sub TabControl_enabled(ByVal x As Boolean)
        'TabControl1.TabPages(1).Enabled = x
        'TabControl1.TabPages(2).Enabled = x
        'TabControl1.TabPages(3).Enabled = x

    End Sub

    Sub log(ByVal logText As String, ByVal logColor As Color)

        Txt_Log.Select(Txt_Log.TextLength, 0)
        Txt_Log.SelectionColor = logColor
        Txt_Log.AppendText(logText & vbNewLine)
        Txt_Log.SelectionStart = Txt_Log.Text.Length
        Txt_Log.ScrollToCaret()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoUpdater.Mandatory = True
        AutoUpdater.UpdateMode = Mode.Forced
        AutoUpdater.Start("https://w9ll.co/Update/TW.xml")

        TabControl_enabled(False)


        'DT Account Mananger
        DT_AccountManager.Columns.Add("Username")
        DT_AccountManager.Columns.Add("Password")
        DT_AccountManager.Columns.Add("AccessToken")
        DT_AccountManager.Columns.Add("Cookies")

        Grid_Control_Accounts.DataSource = DT_AccountManager
    End Sub

    Enum FileToDelete
        History = 1
        Cookies = 2
        TemporaryInternetFiles = 8
        FormData = 16
        Passwords = 32
        DeleteAll = 255
        DeleteAllExt = 4351

    End Enum

    Sub DeleteSystemFile(ByVal action As FileToDelete)
        Dim args As String = ""
        args = "InetCpl.cpl,ClearMyTracksByProcess " & action
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System).ToString & "\Rundll32.exe" '"regedit.exe"
        If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
            processStartInfo.Verb = "runas"
        End If
        processStartInfo.Arguments = args
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        processStartInfo.UseShellExecute = True
        Try
            process = System.Diagnostics.Process.Start(processStartInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not (process Is Nothing) Then
                process.Dispose()
            End If

        End Try
    End Sub

    Dim cts As Boolean

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Button1.Enabled = True
    End Sub






    'Public Shared Function UploadPictureToWall(ByVal id As String, ByVal accessToken As String, ByVal filePath As String) As String
    '    Dim mediaObject = New FacebookMediaObject With {.FileName = System.IO.Path.GetFileName(filePath), .ContentType = "image/jpeg"}
    '    mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath))
    '    Try
    '        Dim fb = New FacebookClient(accessToken)
    '        Dim result = DirectCast(fb.Post(id & "/photos", New Dictionary(Of String, Object) From {
    '            {"source", mediaObject},
    '            {"message", "photo"}
    '        }), IDictionary(Of String, Object))
    '        Dim postId = CStr(result("id"))
    '        Return postId
    '    Catch ex As FacebookApiException
    '        Throw
    '    End Try
    'End Function


#Region "Login & Get ACC_Tc"

    Public facebookUser As New FacebookUser

    Public Function login(ByVal email As String, ByVal password As String) As Boolean
        Try
            Dim dictionary As New Dictionary(Of String, String)()
            dictionary.Add("api_key", "882a8490361da98702bf97a021ddc14d")
            dictionary.Add("credentials_type", "password")
            dictionary.Add("email", email)
            dictionary.Add("format", "JSON")
            dictionary.Add("generate_machine_id", "1")
            dictionary.Add("generate_session_cookies", "1")
            dictionary.Add("method", "auth.login")
            dictionary.Add("password", password)
            dictionary.Add("return_ssl_resources", "0")
            dictionary.Add("v", "1.0")
            Dim str As String = ""
            For Each pair As KeyValuePair(Of String, String) In dictionary
                str = str & pair.Key & "=" & pair.Value
            Next pair
            str = Me.CreateMD5(str & "62f8ce9f74b12f84c123cc23437a4a32")

            dictionary.Add("sig", str)
            Dim str6 As String = ""
            Dim str2 As String = "Mozilla/5.0 (Linux; Android 5.0.2; Andromax C46B2G Build/LRX22G) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/37.0.0.0 Mobile Safari/537.36 [FB_IAB/FB4A;FBAV/60.0.0.16.76;]" 'Helper2.GetAndroidUserAgentsList()((New Random()).Next(0, Helper2.GetAndroidUserAgentsList().Count))
            Dim request As HttpWebRequest = CType(WebRequest.Create("https://api.facebook.com/restserver.php"), HttpWebRequest)
            request.Method = "POST"
            request.CachePolicy = New RequestCachePolicy(RequestCacheLevel.NoCacheNoStore)
            request.KeepAlive = True
            request.UserAgent = str2
            request.Host = "api.facebook.com"
            Dim s As String = ""
            For Each pair2 As KeyValuePair(Of String, String) In dictionary
                Dim textArray1() As String = {s, pair2.Key, "=", pair2.Value, "&"}
                s = String.Concat(textArray1)
            Next pair2
            s = s.Remove(s.Length - 1)
            s.Replace("+", "%2B")
            Dim bytes() As Byte = Encoding.UTF8.GetBytes(s)
            request.ContentType = "application/x-www-form-urlencoded;"
            request.ContentLength = bytes.Length
            Dim requestStream As Stream = request.GetRequestStream()
            requestStream.Write(bytes, 0, bytes.Length)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.InternalServerError Then
                response.Close()
                requestStream.Close()
                MessageBox.Show("Internal Server Error Please Try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                requestStream = response.GetResponseStream()
                Dim reader1 As New StreamReader(requestStream)
                Dim json As String = reader1.ReadToEnd()
                reader1.Close()
                response.Close()
                requestStream.Close()
                If json.Contains("access_token") Then
                    Dim obj1 As JObject = JObject.Parse(json)
                    Dim str5 As String = obj1.GetValue("access_token").ToString()

                    Dim array As JArray = JArray.Parse(obj1.GetValue("session_cookies").ToString())

                    For i As Integer = 0 To array.Count - 1
                        Dim textArray2() As String = {str6, array(i)("name").Value(Of String)(), "=", array(i)("value").Value(Of String)(), ";"}
                        str6 = String.Concat(textArray2)
                    Next i

                    Me.facebookUser.GraphAccessToken = str5
                    facebookUser.UserName = email
                    facebookUser.Password = password

                    Me.facebookUser.AccessToken = Me.facebookUser.GraphAccessToken

                    Me.facebookUser.GraphAccessTokenExpireDate = Date.Now.AddHours(1.0).ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture)
                    Me.facebookUser.Cookies = str6
                    cooooo = str6
                    Me.facebookUser.CookiesExpireDate = Date.Now.AddYears(1).ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture)
                    Dim manuallyID As String = Me.GetManuallyID(Me.facebookUser.Cookies)
                    If String.IsNullOrEmpty(manuallyID) Then
                        Me.facebookUser.ManuallyID = Me.facebookUser.ID
                    Else
                        Me.facebookUser.ManuallyID = manuallyID
                        Me.facebookUser.ID = Me.facebookUser.ManuallyID
                    End If

                    Me.facebookUser.UserAgent = "Mozilla/5.0(Linux; Android 7.1.1; Build/LMY47O.H18; wv) AppleWebKit/537.36(KHTML, like Gecko) Version/4.0 Chrome/58.0.3029.83 Mobile Safari/537.36 [FB_IAB/FB4A;FBAV/127.0.0.22.69;]"
                    Me.facebookUser.HtcAccessToken = str5
                    Me.facebookUser.HtcAccessTokenExpireDate = Date.Now.AddYears(1).ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture)
                    Me.facebookUser.AccessToken = Me.facebookUser.HtcAccessToken
                    Return True

                Else
                    If json.Contains("error_code") Then
                        Try
                            Dim obj2 As JObject = JObject.Parse(JObject.Parse(json).GetValue("error_data").ToString())
                            Dim caption As String = obj2.GetValue("error_title").ToString()
                            MessageBox.Show(obj2.GetValue("error_message").ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        Catch
                            MessageBox.Show("Please login to this facebook account from your web browser then login from application " & vbLf & vbCr & " " & json, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End Try
                    End If
                    MessageBox.Show("Please check your Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return False
                End If
            End If
        Catch exception1 As Exception
            MessageBox.Show(exception1.Message, "General Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End Try
    End Function
    Private Function GetManuallyID(ByVal cookies As String) As String
        Dim separator() As String = {";"}
        Dim strArray() As String = cookies.Split(separator, StringSplitOptions.None)
        For i As Integer = 0 To strArray.Length - 1
            If strArray(i).Contains("user") Then
                Dim textArray2() As String = {"="}
                Return strArray(i).Split(textArray2, StringSplitOptions.None)(1).Trim()
            End If
        Next i
        Return ""
    End Function
    Private Function CreateMD5(ByVal input As String) As String
        Using md As MD5 = MD5.Create()
            Dim bytes() As Byte = Encoding.ASCII.GetBytes(input)
            Dim buffer2() As Byte = md.ComputeHash(bytes)
            Dim builder As New StringBuilder()
            For i As Integer = 0 To buffer2.Length - 1
                builder.Append(buffer2(i).ToString("X2"))
            Next i
            Return builder.ToString().ToLower()
        End Using
    End Function
#End Region







    Dim searchHandller As Boolean



    Private Sub Button13_Click(sender As Object, e As EventArgs)
        log("Search Done! ", Color.DarkGreen)
        btn_groupStartjoin.Enabled = True

    End Sub
    '321090721625587/members?limit=100000

    Sub counter()

    End Sub
    Private Sub IDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem.Click
        Dim selectedItems As ListView.SelectedListViewItemCollection = ListView_currentLogginUser_searchResult.SelectedItems

        For Each item As ListViewItem In selectedItems
            My.Computer.Clipboard.SetText(item.SubItems(2).Text)
        Next


    End Sub
    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click
        Dim selectedItems As ListView.SelectedListViewItemCollection = ListView_currentLogginUser_searchResult.SelectedItems
        For Each item As ListViewItem In selectedItems
            My.Computer.Clipboard.SetText(item.SubItems(1).Text)
        Next
    End Sub
    Private Async Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            log("Logging...... " & txt_username.Text, Color.Green)
            Button1.Enabled = False
            If login(txt_username.Text, txt_password.Text) = True Then
                Dim x = New FacebookClient(facebookUser.AccessToken)

                Dim result As Object = Await x.GetTaskAsync("me")
                lbl_Currentusername.Text = "Current User :   " & facebookUser.UserName
                Label4.Text = "Name : " & result.name
                log("Hi " & result.name & vbNewLine & Now, Color.Blue)
                facebookUser.ID = result.id.ToString
                PictureBox2.Load("https://graph.facebook.com/" & result.id & "/picture?type=large&width=720&height=720")
ennn:           Button1.Enabled = True
                TabControl_enabled(True)
                log(facebookUser.AccessToken, Color.Green)
                Dim items As String() = New String() {facebookUser.UserName, facebookUser.Password, facebookUser.AccessToken, facebookUser.Cookies}
                DT_AccountManager.Rows.Add(items)
            End If
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            GoTo ennn
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cts = True
        Button8.Hide()
        Button2.Enabled = True
    End Sub

    Private Async Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cts = False
        Button8.Show()

        Dim fb = New FacebookClient(facebookUser.AccessToken)
        If Ck_posttomywall.Checked = True Then
            Try
                Button2.Enabled = False
                Dim parameters As Object = New ExpandoObject()
                parameters.message = txt_post.Text
                If RD_link.Checked = True Then parameters.link = TextBox1.Text
                Dim result = Await fb.PostTaskAsync("me/feed", parameters)
                log("Posted Compelete", Color.SteelBlue)
                Button2.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

        If Ck_posttopages.Checked = True Then

            Button2.Enabled = False
            For Each x As ListViewItem In ListView_currentLogginUser_Pages.Items
                If cts = True Then
                    Exit For
                    Exit Sub

                End If
                If x.Checked = True Then
                    Try
                        Dim parameters As Object = New ExpandoObject()
                        parameters.message = txt_post.Text

                        If RD_link.Checked = True Then parameters.link = TextBox1.Text

                        Dim result = Await fb.PostTaskAsync(x.SubItems(2).Text & "/feed", parameters)
                        log("Posted To " & x.SubItems(1).Text & "OK!", Color.Purple)
                    Catch ex As Exception
                        log("Failed Posting to " & x.SubItems(1).Text, Color.Red)
                        Continue For
                    End Try

                End If
            Next
        End If

        If Ck_posttogroup.Checked = True Then
            Button2.Enabled = False
            For Each x As ListViewItem In ListView_currentLogginUser_Groups.Items
                If cts = True Then
                    Exit For
                    Exit Sub


                End If
                If x.Checked = True Then
                    Try
                        Dim parameters As Object = New ExpandoObject()
                        parameters.message = txt_post.Text
                        If RD_link.Checked = True Then parameters.link = TextBox1.Text
                        Dim result = Await fb.PostTaskAsync(x.SubItems(2).Text & "/feed", parameters)
                        log("Posted To " & x.SubItems(1).Text & "OK!", Color.MidnightBlue)
                    Catch ex As Exception
                        log("Failed Posting to " & x.SubItems(1).Text, Color.Red)
                        Continue For
                    End Try

                End If
            Next
        End If



        If Ck_posttofriends.Checked = True Then
            Button2.Enabled = False
            For Each x As ListViewItem In ListView_currentLogginUser_friends.Items
                If cts = True Then
                    Exit For
                    Exit Sub

                End If
                If x.Checked = True Then
                    Try
                        Dim parameters As Object = New ExpandoObject()
                        parameters.message = txt_post.Text
                        If RD_link.Checked = True Then parameters.link = TextBox1.Text
                        Dim result = Await fb.PostTaskAsync(x.SubItems(2).Text & "/feed", parameters)
                        log("Posted To " & x.SubItems(1).Text & "OK!", Color.MediumVioletRed)
                    Catch ex As Exception
                        log("Failed Posting to " & x.SubItems(1).Text, Color.Red)
                        Continue For
                    End Try

                End If
            Next
        End If


        Exit Sub


    End Sub
    Private Async Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ListView_currentLogginUser_Groups.Items.Clear()
        ListView_currentLogginUser_friends.Items.Clear()
        ListView_currentLogginUser_Pages.Items.Clear()
        log("Getting Information...... ", Color.Red)
        Dim user = New FacebookClient(facebookUser.AccessToken)
        Dim result As Object = Await user.GetTaskAsync("/me")
        Dim Friendlist As Object = Await user.GetTaskAsync("/me/friends")
        For Each Friend_c In Friendlist.data
            Dim listView As New ListView()
            Dim item1 As New ListViewItem("")
            item1.SubItems.Add(Friend_c.name.ToString)
            item1.SubItems.Add(Friend_c.id.ToString)
            ListView_currentLogginUser_friends.Items.Add(item1)
        Next
        Dim Grouplist As Object = Await user.GetTaskAsync("/me/groups")

        For Each Group_t In Grouplist.data
            Dim listView As New ListView()
            Dim item1 As New ListViewItem("")
            item1.SubItems.Add(Group_t.name.ToString)
            item1.SubItems.Add(Group_t.id.ToString)
            ListView_currentLogginUser_Groups.Items.Add(item1)
        Next
        Dim PagesList As Object = Await user.GetTaskAsync("/me/likes")
        For Each PagesList_t In PagesList.data
            Dim listView As New ListView()
            Dim item1 As New ListViewItem("")
            item1.SubItems.Add(PagesList_t.name.ToString)
            item1.SubItems.Add(PagesList_t.id.ToString)
            ListView_currentLogginUser_Pages.Items.Add(item1)
        Next
        log("loaded Complete" & vbNewLine & "Friend :   " & ListView_currentLogginUser_friends.Items.Count &
            "   Groups :   " & ListView_currentLogginUser_Groups.Items.Count & "   Pages :   " & ListView_currentLogginUser_Pages.Items.Count, Color.SteelBlue)
    End Sub
    Private Async Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles btn_groupStartSearch.Click
        Try
            searchHandller = True
            btn_groupStopSearch.Show()
            btn_groupStartjoin.Enabled = False
            log("Query Information.....", Color.Black)
            ListView_currentLogginUser_searchResult.Items.Clear()
            Dim curr As String = ""
            Dim authtoken As String = ""


            Try
                While (ListView_currentLogginUser_searchResult.Items.Count < Goup_maxResults.Value)

                    If searchHandller = False Then
                        Exit While
                    End If

                    Dim t As New Task(Sub()


                                          SearchGroup(txt_keyword.Text, curr, authtoken, False, 0)

                                      End Sub)
                    t.Start()
                    Await t
                End While
            Catch ex As Exception

                XtraMessageBox.Show(ex.Message, "Error_Login_Thread", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End Try





            SearchGroup(txt_keyword.Text, curr, authtoken, False, 0)
            'Dim user = New FacebookClient(facebookUser.AccessToken)
            'Dim searchlist As Object = Await user.GetTaskAsync("search?q=" & txt_keyword.Text & "&type=group&limit=" & NumericUpDown1.Value & "&fields=id,name,members.limit(0).summary(true)")
            'For Each Friend_c In searchlist.data

            '    If searchHandller = False Then Exit For : Exit Sub : Button11.Hide() : Button10.Enabled = True
            '    Dim listView As New ListView()
            '    Dim item1 As New ListViewItem("")
            '    item1.SubItems.Add(Friend_c.name.ToString)
            '    item1.SubItems.Add(Friend_c.id.ToString)
            '    item1.SubItems.Add(Friend_c.members.summary.total_count.ToString)
            '    ListView_currentLogginUser_searchResult.Items.Add(item1)
            'Next




            log("Search Done! ", Color.DarkGreen)
            btn_groupStartjoin.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles btn_groupStopSearch.Click
        searchHandller = False
    End Sub
    Private Async Sub SimpleButton7_ClickAsync(sender As Object, e As EventArgs) Handles btn_groupStartScrap.Click
        Try
            Dim groupname As String = ListView_currentLogginUser_searchResult.Items(ListView_currentLogginUser_searchResult.FocusedItem.Index).SubItems(1).Text()
            Dim groupid As String = ListView_currentLogginUser_searchResult.Items(ListView_currentLogginUser_searchResult.FocusedItem.Index).SubItems(2).Text()
            Dim user = New FacebookClient(facebookUser.AccessToken)
            Dim result As Object = Await user.GetTaskAsync(groupid & "?fields=member_count")
            Dim groupmembercount As String = result.member_count
            Dim x As String = InputBox("اكتب عدد الاعضاء المراد الارسال لهم", "حدد عدد الاعضاء", "")
            If x = "" Then
                Exit Sub
            End If
            If Val(x) < groupmembercount Or Val(x) = groupmembercount Then
                Dim x_form As New frm_Friends_Adder
                x_form.limit = Val(x)
                x_form.faceObject = user
                x_form.gid = groupid
                x_form.Label4.Text = groupname
                x_form.username = facebookUser.UserName
                x_form.password = facebookUser.Password
                x_form.Text = "Users Count : " & Val(x) & "  Current Account : " & facebookUser.UserName
                x_form.Show()

            Else
                MsgBox("العدد المدخل اكبر من عدد الاعضاء" & Val(x), MsgBoxStyle.Exclamation, "خطأ")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Async Sub SimpleButton8_ClickAsync(sender As Object, e As EventArgs) Handles btn_groupStartjoin.Click


        If ListView_currentLogginUser_searchResult.Items.Count = 0 Then
            Exit Sub
        Else
            searchHandller = True
            btn_groupStopSearch.Show()
            btn_groupStartjoin.Enabled = False
            Dim faceObject As New FacebookClientHTML(facebookUser.UserName, facebookUser.Password)
            Dim rand As New Random

            For Each x As ListViewItem In ListView_currentLogginUser_searchResult.Items

                If searchHandller = False Then Exit For : Exit Sub

                Dim delay As Integer = rand.Next(1, 3)
                If x.Checked = True Then
                    Try

                        Dim t = Task.Factory.StartNew(Sub()
                                                          faceObject.JoinGroup(x.SubItems(2).Text)
                                                      End Sub)
                        Await t

                        Await Task.Delay(delay)
                        t.Dispose()
                        log("Requeset Sent : " & x.SubItems(1).Text & " OK", Color.DarkGreen)
                    Catch ex As Exception
                        log("Failed To Join " & x.SubItems(1).Text & " Error : " & ex.Message, Color.Red)
                        Continue For
                    End Try
                End If
            Next
        End If
    End Sub

    Private Async Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txt_target.Text = "" Then

        Else
            Try
                Dim LISTOFSTR As New List(Of String)
                Dim user = New FacebookClient(facebookUser.AccessToken)
                '  result = Await user.GetTaskAsync(txt_target.Text)
                Dim result As Object
                Dim LINES As String = ""
                For Each urlf As String In File.ReadAllLines("D:\kali\me\s\SCampagne\AllAhFrinds.txt")
                    Try
                        result = Await user.GetTaskAsync(urlf.Substring(17).Replace("profile.php?id=", ""))
                        LINES = result.name + "*_*" + result.id + "*_*" + "https://graph.facebook.com/" & result.id & "/picture?type=large&width=720&height=720"
                        My.Computer.FileSystem.WriteAllText("D:\kali\me\s\SCampagne\SavedList.txt", LINES + vbNewLine, True)
                    Catch ex As Exception
                        My.Computer.FileSystem.WriteAllText("D:\kali\me\s\SCampagne\SavedList.txt", "#####" + urlf.Substring(17) + "#####" + vbNewLine, True)
                    End Try

                Next

                MsgBox("Finished")

                'lblname.Text = result.name
                'PictureBox3.Load("https://graph.facebook.com/" & result.id & "/picture?type=large&width=720&height=720")

                'ListView6.Items.Clear()
                'ListView7.Items.Clear()
                'ListView8.Items.Clear()
                'log("Getting Information...... ", Color.Red)
                'Dim Friendlist As Object = Await user.GetTaskAsync("/" & txt_target.Text & "/friends")
                'For Each Friend_c In Friendlist.data
                '    Dim listView As New ListView()
                '    Dim item1 As New ListViewItem("")
                '    item1.SubItems.Add(Friend_c.name.ToString)
                '    item1.SubItems.Add(Friend_c.id.ToString)
                '    ListView7.Items.Add(item1)
                'Next
                'Dim Grouplist As Object = Await user.GetTaskAsync("/" & txt_target.Text & "/groups")

                'For Each Group_t In Grouplist.data
                '    Dim listView As New ListView()
                '    Dim item1 As New ListViewItem("")
                '    item1.SubItems.Add(Group_t.name.ToString)
                '    item1.SubItems.Add(Group_t.id.ToString)
                '    ListView6.Items.Add(item1)
                'Next
                'Dim PagesList As Object = Await user.GetTaskAsync("/" & txt_target.Text & "/likes")
                'For Each PagesList_t In PagesList.data
                '    Dim listView As New ListView()
                '    Dim item1 As New ListViewItem("")
                '    item1.SubItems.Add(PagesList_t.name.ToString)
                '    item1.SubItems.Add(PagesList_t.id.ToString)
                '    ListView8.Items.Add(item1)
                'Next
                'log("loaded Complete" & vbNewLine & "Friend :   " & ListView_currentLogginUser_friends.Items.Count &
                '"   Groups :   " & ListView_currentLogginUser_Groups.Items.Count & "   Pages :   " & ListView_currentLogginUser_Pages.Items.Count, Color.SteelBlue)

            Catch ex As Exception
                MsgBox("This Mail is Not Exist")
            End Try

            'log("Getting Information...... ", Color.Red)
            'Dim user = New FacebookClient(facebookUser.AccessToken)
            'Dim Friendlist As Object = Await user.GetTaskAsync("/" & txt_target.Text & "/groups")
            'For Each Friend_c In Friendlist.data
            '    Dim listView As New ListView()
            '    Dim item1 As New ListViewItem("")
            '    item1.SubItems.Add(Friend_c.name.ToString)
            '    item1.SubItems.Add(Friend_c.id.ToString)
            '    ListView3.Items.Add(item1)
            'Next

        End If
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim selectedItems As ListView.SelectedListViewItemCollection = ListView6.SelectedItems


        For Each item As ListViewItem In selectedItems
            My.Computer.Clipboard.SetText(item.SubItems(2).Text)
        Next
    End Sub
    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Txt_Log.Clear()

        '\d+(,""ra)

        'async_get_token":".*?"
        '  Txt_Log.Text = "(cursor:" & """" & """" & "(.*?)(" & """" & """" & ")"
        '(async_get_token":")(.*?)("},)


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If TabControl2.SelectedIndex = 0 Then
                For i = 0 To ListView_currentLogginUser_Groups.Items.Count - 1
                    ListView_currentLogginUser_Groups.Items(i).Checked = True
                Next
            ElseIf TabControl2.SelectedIndex = 1 Then
                For i = 0 To ListView_currentLogginUser_friends.Items.Count - 1
                    ListView_currentLogginUser_friends.Items(i).Checked = True
                Next
            ElseIf TabControl2.SelectedIndex = 2 Then
                For i = 0 To ListView_currentLogginUser_Pages.Items.Count - 1
                    ListView_currentLogginUser_Pages.Items(i).Checked = True
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frm_FacebookApplication_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim svd As New SaveFileDialog
        svd.Filter = "dbxf files (*.dbxf)|*.dbxf"
        svd.CheckFileExists = False
        svd.CheckPathExists = False
        If svd.ShowDialog = DialogResult.OK Then
            Dim File As System.IO.StreamWriter = New StreamWriter(svd.FileName, False, Encoding.Unicode)
            For Each x As ListViewItem In ListView7.Items
                File.WriteLine(x.SubItems(1).Text & "*_*" & x.SubItems(2).Text)
            Next
            File.Close()
        End If
    End Sub
    Private Sub Grid_Control_Accounts_MouseUp(sender As Object, e As MouseEventArgs) Handles Grid_Control_Accounts.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu2.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub Btn_Import_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Import.ItemClick
        Dim temprorayDT As DataTable = New DataTable
        temprorayDT = AppHelper.UserDataTable_Control
        If temprorayDT.Rows.Count <> 0 Then
            DT_AccountManager = temprorayDT
            Grid_Control_Accounts.DataSource = DT_AccountManager
        End If


    End Sub

    Private Sub Btn_Export_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Export.ItemClick
        AppHelper.UserDataTable_Control = DT_AccountManager
    End Sub
    Private Sub Btn_Remove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Remove.ItemClick
        If (Grid_View_Accounts.SelectedRowsCount = 0) Then
            XtraMessageBox.Show("Please Select ACCOUNT/S ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If XtraMessageBox.Show("Do You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim intx As Integer() = Grid_View_Accounts.GetSelectedRows.ToArray
                Dim temp As DataTable
                temp = Grid_Control_Accounts.DataSource
                Dim conter As Integer = 0

                For Each index1 As Integer In intx
                    temp.Rows.RemoveAt(index1 - conter)
                    conter += 1
                Next
                DT_AccountManager = temp
            End If
        End If
    End Sub
    Private Async Sub Grid_Control_Accounts_DoubleClickAsync(sender As Object, e As EventArgs) Handles Grid_Control_Accounts.DoubleClick
        If (Grid_View_Accounts.SelectedRowsCount = 0) Then

        Else
            If XtraMessageBox.Show("Do You Want Load This Account", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                facebookUser.UserName = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                facebookUser.Password = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Password").ToString()
                facebookUser.AccessToken = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "AccessToken").ToString()
                facebookUser.Cookies = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Cookies").ToString()

                Try
                    PictureBox2.Image = Nothing
                    lbl_Currentusername.Text = ""
                    Label4.Text = ""
                    Dim x = New FacebookClient(facebookUser.AccessToken)
                    Dim result As Object = Await x.GetTaskAsync("me")
                    lbl_Currentusername.Text = "Current User :   " & facebookUser.UserName
                    Label4.Text = "Name : " & result.name
                    log("Hi " & result.name & vbNewLine & Now, Color.Blue)
                    facebookUser.ID = result.id.ToString
                    PictureBox2.Load("https://graph.facebook.com/" & result.id & "/picture?type=large&width=720&height=720")
ennn:               Button1.Enabled = True
                    TabControl_enabled(True)
                    log(facebookUser.AccessToken, Color.Green)

                Catch ex As FacebookOAuthException
                    log(String.Format("User : {0} Authentication Error {1}", facebookUser.UserName, ex.Message), Color.Red)
                Catch ex As Exception
                    log(String.Format("User : {0} General Error {1}", facebookUser.UserName, ex.Message), Color.Red)

                End Try



            End If
        End If
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Dim frm_mes As New frm_Message_AutoSender
        frm_mes.username = facebookUser.UserName
        frm_mes.password = facebookUser.Password
        frm_mes.Text = "Current Account : " + facebookUser.UserName
        frm_mes.Show()

    End Sub
    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dim svd As New SaveFileDialog
        svd.Filter = "dbxf files (*.dbxf)|*.dbxf"
        svd.CheckFileExists = False
        svd.CheckPathExists = False
        If svd.ShowDialog = DialogResult.OK Then
            Dim File As System.IO.StreamWriter = New StreamWriter(svd.FileName, False, Encoding.UTF8)
            For Each x As ListViewItem In ListView6.Items
                File.WriteLine(x.SubItems(1).Text & "   " & x.SubItems(2).Text)
            Next
            File.Close()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class