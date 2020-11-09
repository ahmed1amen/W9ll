Imports DevExpress.XtraEditors
Imports Gecko
Imports Gecko.Events
Imports System.ComponentModel
Imports System.Net
Imports System.Windows.Forms

Public Class Embedded_Browser

    Public CookiesCont As New CookieContainer
    Function Xpath_Method(ByVal Xpath As String, ByVal mth As String, Optional valx As String = "") As String
        Dim element = Web_Control.DomDocument.EvaluateXPath(Xpath)
        Dim nodes = element.GetNodes()

        Dim paginElement = nodes.Select(Function(x) TryCast(x, GeckoElement)).FirstOrDefault()
        If paginElement Is Nothing Then
            Return "element Not found"
        Else
            Dim elementHTML = TryCast(paginElement, GeckoHtmlElement)
            If elementHTML IsNot Nothing Then

                If mth = "click" Then
                    elementHTML.Click()
                    Return "OKaaay"
                ElseIf mth = "set" Then
                    elementHTML.SetAttribute("value", valx)
                ElseIf mth = "get" Then
                    Return elementHTML.GetAttribute("value")
                ElseIf mth = "get_inner_text" Then
                    Return elementHTML.TextContent

                ElseIf mth = "get_inner_html" Then
                    Return elementHTML.InnerHtml

                ElseIf mth = "set_bysendkeys" Then
                    elementHTML.Focus()

                    Web_Control.Window.WindowUtils.SendKeyEvent("keypress", 0, Keys.A, 2, False)
                    For Each chhrr As Char In valx
                        Web_Control.Window.WindowUtils.SendKeyEvent("keypress", 0, Asc(chhrr), 0, False)
                    Next

                    '   Dim span = Web_Control.Document.GetHtmlElementById("theElementIWantToClickOn")


                    'Web_Control.Window.WindowUtils.SendMouseEvent("contextmenu", elementHTML.OffsetLeft, elementHTML.OffsetTop, 2, 1, 0, True, 0, 0)
                End If
            Else
                Return "0"
            End If
        End If
        Return "0"
    End Function


    Public Sub Remove_BrowserCook()
        Try
            Dim CookieMan As nsICookieManager
            CookieMan = Xpcom.GetService(Of nsICookieManager)("@mozilla.org/cookiemanager;1")
            CookieMan = Xpcom.QueryInterface(Of nsICookieManager)(CookieMan)
            CookieMan.RemoveAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        'Cookie requests should now be sent to TestCookieService, process them as your want.
    End Sub
    Sub InjectCookies_And_NavigateToUpload()
        Dim cookieConX = CookiesCont
        Dim uri = New Uri("https://www.twitter.com")
        For Each cookie As System.Net.Cookie In cookieConX.GetCookies(uri)
            Dim host As String = ".twitter.com"
            Dim path As String = cookie.Path
            Dim Name As String = cookie.Name
            Dim value As String = cookie.Value
            Dim isSecure As Boolean = cookie.Secure
            Dim isHttpOnly As Boolean = cookie.HttpOnly
            Dim isSession As Boolean = cookie.HttpOnly
            Dim num As Long = CInt(DateTime.UtcNow.AddYears(1).Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
            CookieManager.Add(host, path, Name, value, isSecure, isHttpOnly, isSecure, num)
        Next cookie
        Web_Control.Navigate("https://mobile.twitter.com/compose/tweet")
    End Sub
    Private Async Sub Form1_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        GeckoPreferences.User("browser.xul.error_pages.enabled") = True
        GeckoPreferences.User("browser.cache.disk.enable") = False
        GeckoPreferences.User("browser.cache.offline.enable") = False
        GeckoPreferences.User("places.history.enabled") = False
        GeckoPreferences.User("network.proxy.type") = 0
        GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:68.0) Gecko/20100101 Firefox/68.0"
        GeckoPreferences.User("browser.xul.error_pages.enabled") = False
        GeckoPreferences.User("browser.download.manager.showAlertOnComplete") = False
        GeckoPreferences.User("security.warn_viewing_mixed") = False
        GeckoPreferences.User("privacy.popups.showBrowserMessage") = False


        Remove_BrowserCook()
        Web_Control.Dock = DockStyle.Fill
        InjectCookies_And_NavigateToUpload()

        Web_Control.Enabled = False
        Web_Control.Dock = DockStyle.Fill
        Await Task.Delay(3000)
        Timer1.Start()
        Panel1.Controls.Add(Web_Control)
        Panel1.Dock = DockStyle.Fill
        Web_Control.NoDefaultContextMenu = True
        Web_Control.ContextMenu = ContextMenuStrip1.ContextMenu


    End Sub
    Dim notClosedByUser As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim someElement As GeckoHtmlElement = Web_Control.Document.EvaluateXPath("//*[@aria-label='Back' and @role='button']").GetNodes(0)

            someElement.SetAttribute("style", "display: none;")

            Web_Control.Enabled = True
            Button1.Visible = False
        Catch ex As Exception

        End Try
        Try



            If Web_Control.Document.Uri = "https://mobile.twitter.com/compose/tweet" Or Web_Control.Document.Uri = "https://mobile.twitter.com/compose/tweet/media" Then

            Else

                notClosedByUser = True
                Me.Close()

            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If notClosedByUser = True Then
            Me.DialogResult = 3
        Else
            Me.DialogResult = 2
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If notClosedByUser = True Then
            Me.DialogResult = 2
        Else
            Me.DialogResult = 3
        End If

    End Sub

    Private Sub Web_Control_NSSError(sender As Object, e As GeckoNSSErrorEventArgs) Handles Web_Control.NSSError
        Web_Control.Stop()
        Web_Control.Dispose()


        XtraMessageBox.Show("Error Fiddler Or Reverse Proxy Detected ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Me.DialogResult = 2
        Me.Close()

    End Sub
End Class












'Sub W(ByVal Txt As String)
'    '                                                                           TextTweet






'    ' IF Image 
'    ' Dim ImageDetection As String = "//*[@id='react-root']/div/div/div[1]/div/div/div/div/div[2]/div[2]/div/div[3]/div/div/div[1]/div/div/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div/div[1]/div/div[2]/div/div/div[1]/div/div/img"
'    ' Dim VideoDetection As String = "//*[@id='react-root']/div/div/div[1]/div/div/div/div/div[2]/div[2]/div/div[3]/div/div/div[1]/div/div/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div/div/div/div[2]/div/div/video/source"

'End Sub

'Public Async Function StartTweetingWithMedia(ByVal txt) As Task(Of Boolean)

'    ''Xpath_Method("//*[@data-testid='tweetTextarea_0']", "set_bysendkeys", txt)
'    ''My.Computer.Clipboard.SetText(Web_Control.Document.Body.OuterHtml)
'    ''If Web_Control.Document.Body.OuterHtml.Contains("blob:https://twitter.com") = False Then
'    ''    Return False
'    ''End If
'    ''Xpath_Method("//*[@id='react-root']/div/div/div[1]/div/div/div/div/div[2]/div[2]/div/div[2]/div/div[1]/div/div[3]/div ", "click")
'    While Web_Control.Document.Uri = "https://mobile.twitter.com/compose/tweet"                                                                'Upload Finish
'        Await Task.Delay(3000)
'    End While
'    Return True
'End Function
