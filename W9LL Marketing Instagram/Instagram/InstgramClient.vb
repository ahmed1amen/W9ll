Imports System.Net
Imports System.Text.RegularExpressions
Imports W9LL_Marketing_Instagram.Activation
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports AutoUpdaterDotNET

Public Class InstgramClient
    Sub showIf()
        If DT_AccountManager.Rows.Count <> 0 Then
            XtraTabPage2.PageVisible = True
        Else
            XtraTabPage2.PageVisible = False
        End If
    End Sub
    Private Sub LogReport(ByVal IsError As Boolean, ByVal usernameF As String, ByVal messageOf As String)
        If IsError = True Then
            ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] error : {2} ", Now, usernameF, messageOf))
        Else
            ListBoxControl1.Items.Add(String.Format("[{0}] >> [{1}] : {2} ", Now, usernameF, messageOf))
        End If
    End Sub
    Private Shared _instance As InstgramClient = Nothing
    Public Shared ReadOnly Property MainInstance As InstgramClient
        Get
            Return _instance
        End Get
    End Property

    Public DT_AccountManager As DataTable = New DataTable
    Dim mainCookieContainer As CookieContainer
    'Sub reqCheckLog(ByVal URLpOINT As String, Optional usex As String = "", Optional passx As String = "")
    '    Dim classQx As New instgram_Func
    '    Dim head As New WebHeaderCollection
    '    Dim url = "", method = "", Referer = "", postdatax = "", Cookies As String = ""
    '    url = "https://www.instagram.com" & URLpOINT
    '    method = "GET"
    '    Dim req As String = classQx.CreatReq(url, method, Referer, postdatax, Cookies, head, "xxa", txt_Proxy.Text)



    '    Dim classQx2 As New instgram_Func
    '    Dim head2 As New WebHeaderCollection
    '    Dim url2, method2, Referer2, postdatax2, Cookies2 As String
    '    url2 = "https://www.instagram.com" & URLpOINT
    '    method2 = "POST"
    '    postdatax2 = "choice=1"
    '    Referer2 = "https://www.instagram.com" & URLpOINT
    '    head2.Add("X-Instagram-AJAX", "acdd44575d91")
    '    head2.Add("X-CSRFToken", classQx.csrftoken_code_adv)
    '    Cookies2 = classQx.Cookies_str
    '    Dim req2 As String = classQx2.CreatReq(url2, method2, Referer2, postdatax2, Cookies2, head2, "", txt_Proxy.Text)
    '    Thread.Sleep(2000)
    '    Dim req2x As String = classQx2.CreatReq(url2, method2, Referer2, postdatax2, Cookies2, head2, "", txt_Proxy.Text)
    '    'security_code=761823
    '    Dim CODE As String = InputBox("ادخل كود التفعيل", "ادخل كود التفعيل")
    '    If CODE IsNot Nothing Then
    '        Referer2 = "https://www.instagram.com"
    '        postdatax2 = "security_code=" & CODE
    '        Dim lastrow As Integer = Grid_View_Accounts.RowCount
    '        Dim req3 As String = classQx2.CreatReq(url2, method2, Referer2, postdatax2, Cookies2, head2, "log", txt_Proxy.Text)
    '        Dim profile_page_txt As String = classQx2.GetPageText("https://www.instagram.com/" & txtname.Text, txt_Proxy.Text)
    '        Dim Followers As String = Regex.Match(profile_page_txt, "content=" + Chr(34) + "(.*?) Followers,").Groups.Item(1).Value
    '        Dim Following As String = Regex.Match(profile_page_txt, ", (.*?)Following,").Groups.Item(1).Value
    '        Dim Posts As String = Regex.Match(profile_page_txt, "Following, (.*?) Posts").Groups.Item(1).Value
    '        Dim proxyAdd As String = txt_Proxy.Text


    '        Dim items As String() = New String() {txtname.Text, txtpass.Text, Followers, Following, Posts, "Good", proxyAdd, classQx2.Cookies_str, classQx2.csrftoken_code_adv}

    '        If usex = "" Then
    '            items = New String() {txtname.Text, txtpass.Text, Followers, Following, Posts, "Good", proxyAdd, classQx2.Cookies_str, classQx2.csrftoken_code_adv}
    '        Else
    '            items = New String() {usex, passx, Followers, Following, Posts, "Good", proxyAdd, classQx2.Cookies_str, classQx2.csrftoken_code_adv}
    '        End If
    '        DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows.Add(items)))
    '        DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows(lastrow).Cells(5).Style.BackColor = Color.DarkGreen))
    '        GroupBox1.Invoke(New Action(Sub() GroupBox1.Enabled = True))
    '        GroupBox2.Invoke(New Action(Sub() GroupBox2.Enabled = True))
    '    End If
    'End Sub
    'Sub Login(Optional usex As String = "", Optional passx As String = "")

    '    Dim classQ As New instgram_Func
    '    Dim profile_page_txt As String
    '    Dim url, method, Referer, postdatax, Cookies As String
    '    If usex = "" Then

    '        profile_page_txt = classQ.GetPageText("https://www.instagram.com/" & txtname.Text, txt_Proxy.Text)
    '        postdatax = String.Format("username={0}&password={1}", txtname.Text, txtpass.Text)
    '    Else

    '        profile_page_txt = classQ.GetPageText("https://www.instagram.com/" & usex, txt_Proxy.Text)
    '        postdatax = String.Format("username={0}&password={1}", usex, passx)
    '    End If

    '    If profile_page_txt = Nothing Then Exit Sub
    '    Dim csrftoken As String = Regex.Match(profile_page_txt, "csrf_token" + Chr(34) + ":" + Chr(34) + "(.*?)" + Chr(34)).Groups.Item(1).Value
    '    Dim head As New WebHeaderCollection

    '    url = "https://www.instagram.com/accounts/login/ajax/"
    '    method = "POST"
    '    Referer = "https://www.instagram.com/"

    '    Cookies = csrftoken
    '    head.Add("X-Instagram-AJAX", "acdd44575d91")
    '    head.Add("X-CSRFToken", csrftoken)
    '    Dim req As String = classQ.CreatReq(url, method, Referer, postdatax, Cookies, head, "log", txt_Proxy.Text)
    '    Dim lastrow As Integer = DataGridView1.Rows.Count

    '    If req <> Nothing And req.Contains("authenticated" & Chr(34) & ": true") = True Then
    '        If req.Contains(Chr(34) + "status" + Chr(34) + ": " + Chr(34) + "ok" + Chr(34)) Then
    '            Dim Followers As String = Regex.Match(profile_page_txt, "content=" + Chr(34) + "(.*?) Followers,").Groups.Item(1).Value
    '            Dim Following As String = Regex.Match(profile_page_txt, ", (.*?)Following,").Groups.Item(1).Value
    '            Dim Posts As String = Regex.Match(profile_page_txt, "Following, (.*?) Posts").Groups.Item(1).Value
    '            Dim proxyAdd As String = txt_Proxy.Text

    '            Dim items As String()
    '            If usex = "" Then
    '                items = New String() {txtname.Text, txtpass.Text, Followers, Following, Posts, "Good", proxyAdd, classQ.Cookies_str, classQ.csrftoken_code_adv}
    '            Else

    '                items = New String() {usex, passx, Followers, Following, Posts, "Good", proxyAdd, classQ.Cookies_str, classQ.csrftoken_code_adv}

    '            End If


    '            DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows.Add(items)))
    '            DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows(lastrow).Cells(5).Style.BackColor = Color.DarkGreen))
    '            GroupBox1.Invoke(New Action(Sub() GroupBox1.Enabled = True))
    '            GroupBox2.Invoke(New Action(Sub() GroupBox2.Enabled = True))
    '        End If
    '    ElseIf req <> Nothing And req.Contains("checkpoint_required") = True Then

    '        If MessageBox.Show("الحساب يحتاج الي تفعيل" & vbNewLine & "هل تريد من البرنامج ارسال كود التفعيل الي الحساب ؟!", "checkpoint_required", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
    '            Dim URXXXX As String = req.Replace(LBL_REPLACE1.Text, "").Replace(LBL_REPLACE2.Text, "")
    '            If usex = "" Then
    '                reqCheckLog(URXXXX)
    '            Else
    '                reqCheckLog(URXXXX, usex, passx)

    '            End If

    '        End If
    '    Else
    '        XtraMessageBox.Show("خطأ في تسجيل الدخول .. تحقق من البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End If
    '    btn_login.Invoke(New Action(Sub() btn_login.Enabled = True))

    'End Sub
    Private Sub Instgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        AutoUpdater.Mandatory = True
        AutoUpdater.UpdateMode = Mode.Forced
        AutoUpdater.Start("https://w9ll.co/Update/IG.xml")
        WindowsFormsSettings.AnimationMode = AnimationMode.EnableAll

        CheckForIllegalCrossThreadCalls = False
        If _instance Is Nothing Then _instance = Me
        'DT Account Mananger
        DT_AccountManager.Columns.Add("Username")
        DT_AccountManager.Columns.Add("Pasword")
        DT_AccountManager.Columns.Add("Followers")
        DT_AccountManager.Columns.Add("Following")
        DT_AccountManager.Columns.Add("Status")
        DT_AccountManager.Columns.Add("Proxy")
        DT_AccountManager.Columns.Add("Cookise_String")
        DT_AccountManager.Columns.Add("csr_Token")


        If System.IO.File.Exists("IUserDataTable.dll") = True Then
            DT_AccountManager = AppHelper.UserDataTable_Control

        End If
        Grid_Control_Accounts.DataSource = DT_AccountManager

        showIf()

        ';InitializeComponent()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(SkinRibbonGalleryBarItem2, True, False)
        If ProgramVersion.current = ProgramVersion.Standard Then

        End If

        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\log.txt")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try



            lbl_Current_Account_Comment.Text = "Current Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username")

        Catch ex As Exception
        End Try
    End Sub
    'Public InstaApi As IInstaApi
    'Dim AppName As String = "VB.NET Example"
    'Dim StateFile As String = "state.bin"
    'Private Sub LoadSession()
    '    InstaApi.SessionHandler.Load()
    '    '' Old load session
    '    'Try
    '    '    If File.Exists(StateFile) Then
    '    '        Debug.WriteLine("Loading state from file")
    '    '        Dim fs = File.OpenRead(StateFile)
    '    '        InstaApi.LoadStateDataFromStream(fs)
    '    '    End If

    '    'Catch ex As Exception
    '    '    Debug.WriteLine(ex)
    '    'End Try
    'End Sub
    'Private Sub SaveSession()
    '    If (InstaApi Is Nothing) Then
    '        Return
    '    End If

    '    If Not InstaApi.IsUserAuthenticated Then
    '        Return
    '    End If
    '    InstaApi.SessionHandler.Save()
    '    '' Old save session
    '    'Dim state = InstaApi.GetStateDataAsStream
    '    'Dim fileStream = File.Create(StateFile)
    '    'state.Seek(0, SeekOrigin.Begin)
    '    'state.CopyTo(fileStream)
    'End Sub
    Private Async Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            btn_login.Enabled = False
            ProgWait.Visible = True
            Dim account As New InstagramObject(txtname.Text, txtpass.Text, txt_Proxy.Text)

            Await account.LoginMethodAsync()

            btn_login.Enabled = True

            showIf()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error Login Thread #1", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_login.Enabled = True
        End Try

        ProgWait.Visible = False

    End Sub
    Private Async Sub SimpleButton1_Click_1Async(sender As Object, e As EventArgs) Handles Btn_Mention.Click
        Try
            If num1.Value > num2.Value Then
                XtraMessageBox.Show("خطأ في تكوين العمليه الفاصل الزمني الرقم الاول اكبر من الثاني", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txt_mediaLink.Text <> "" Then
                Btn_Mention.Enabled = False
                Btn_MulitComment.Enabled = False
                Dim classZx As New instgram_Func
                Dim x As New insta_Commenter
                x.DelaySeconds = num1.Value
                x.DelaySeconds2 = num2.Value
                Dim media_page_txt As String = Await classZx.GetPageText(txt_mediaLink.Text)

                Dim Media_IDx As String = (Regex.Match(media_page_txt, "instagram://media\?id=(.*?)""").Groups.Item(1).Value) '+ "_" + (Regex.Match(media_page_txt, "owner_user_id" + Chr(34) + " content=" + Chr(34) + "(.*?)" + Chr(34)).Groups.Item(1).Value)
                'owner_user_id" content="(.*?)"


                Dim counter As Integer
                For Each rowA As DataRow In DT_AccountManager.Rows
                    x.DataGridView2.Rows.Add(counter, rowA.Item(0), "0", "Ready...", rowA.Item(6), rowA.Item(7), "0", "0", rowA.Item(5))
                    counter += 1
                Next
                If Media_IDx = "" Then XtraMessageBox.Show("فشل العثور علي Media ID", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Try
                x.Media_ID = Media_IDx
                x.Media_Link = txt_mediaLink.Text
                x.Text = "Comment On : " & txt_mediaLink.Text
                x.Show()
            End If
        Catch ex As Exception
        End Try
        Btn_Mention.Enabled = True
        Btn_MulitComment.Enabled = True
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If Grid_View_Accounts.GetSelectedRows().Count = 1 Then
                If ProgramVersion.current = ProgramVersion.Standard Then

                    Dim x As New insta_Scrapper
                    x.T_Username = TextBox1.Text
                    x.Cookies_2 = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                    x.csrftoken_code = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                    x.proxy = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
                    x.NumOfScrap = NumericUpDown1.Value
                    Dim useridname As New instgram_Func
                    x.useridx = useridname.GetUserId(TextBox1.Text)
                    x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.lbl_Target_Account.Text = "Target Account : " & TextBox1.Text
                    x.lbl_Target_Count.Text = "Target Count : " & NumericUpDown1.Value
                    x.urlidX = "17851374694183129"
                    x.nodename = "edge_followed_by"
                    x.Text = "Scraper Followers"
                    x.UsedToScrap = True
                    x.TabControlZ.TabPages.Remove(x.TabPage2)
                    x.Panel_Fol_UnFol.Visible = False
                    x.Show()
                Else
                    Dim x As New insta_scrapperfast
                    x.proxyAdd = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
                    x.Loggeduser = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.Tatgetuser = TextBox1.Text
                    x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.lbl_Target_Account.Text = "Target Account : " & TextBox1.Text
                    x.maxload = NumericUpDown1.Value
                    x.Show()
                End If
            Else

                XtraMessageBox.Show("حدد حساب واحد فقط", "حدد حساب واحد فقط", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Err1196", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
        End Try
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            If Grid_View_Accounts.GetSelectedRows().Count = 1 Then
                If ProgramVersion.current = ProgramVersion.Standard Then
                    Dim x As New insta_Scrapper
                    x.T_Username = TextBox1.Text \
                    x.Cookies_2 = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                    x.proxy = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
                    x.csrftoken_code = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                    x.NumOfScrap = NumericUpDown1.Value
                    x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.lbl_Target_Account.Text = "Target Account : " & TextBox1.Text
                    x.lbl_Target_Count.Text = "Target Count : " & NumericUpDown1.Value
                    Dim Username As New instgram_Func
                    x.useridx = Username.GetUserId(TextBox1.Text)
                    x.urlidX = "17874545323001329"
                    x.nodename = "edge_follow"
                    x.Text = "Scraper Following"
                    x.UsedToScrap = True
                    x.TabControlZ.TabPages.Remove(x.TabPage2)
                    x.Panel_Fol_UnFol.Visible = False
                    x.Show()
                Else
                    Dim x As New insta_scrapperfast
                    x.proxyAdd = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
                    x.Loggeduser = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.Tatgetuser = TextBox1.Text
                    x.maxload = NumericUpDown1.Value
                    x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                    x.lbl_Target_Account.Text = "Target Account : " & TextBox1.Text
                    x.scrapFollowers = False
                    x.Show()

                End If
            Else

                XtraMessageBox.Show("حدد حساب واحد فقط", "حدد حساب واحد فقط", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Err1196", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
        End Try
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try
            If Grid_View_Accounts.GetSelectedRows().Count = 1 Then
                Dim x As New insta_Scrapper
                x.Cookies_2 = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                x.csrftoken_code = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "csr_Token").ToString()
                x.ProxyString = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
                x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                x.NatrulUserName = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                x.lbl_Target_Account.Text = "Target Account : -"
                x.lbl_Target_Count.Text = "Target Count : -"
                x.urlidX = "17874545323001329"
                x.nodename = "edge_follow"
                x.Text = "Follow_UnFollow"
                x.TabControlZ.TabPages.Remove(x.TabPage1)
                x.Panel_Fol_UnFol.Visible = True
                x.Panel2.Visible = False
                x.ToolStripProgressBar1.Visible = False
                x.ToolStripStatusLabel1.Text = ""
                x.Button1.Visible = False
                x.Show()
            Else
                XtraMessageBox.Show("حدد حساب واحد فقط", "حدد حساب واحد فقط", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Err1195", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
        End Try
    End Sub


    Private Async Sub SimpleButton5_ClickAsync(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            If Grid_View_Accounts.GetSelectedRows().Count = 1 Then

                SimpleButton5.Enabled = False
                Dim commentsC As New instgram_Func
                Dim classZx As New instgram_Func
                Dim x As New insta_Commenter
                Dim media_page_txt As String = Await classZx.GetPageText(txt_mediaLink.Text)
                Dim Media_IDx As String = Regex.Match(media_page_txt, "instagram://media\?id=(.*?)""").Groups.Item(1).Value
                Dim counter As Integer = 0




                If Media_IDx = "" Then XtraMessageBox.Show("فشل العثور علي Media ID", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                Dim newuser As New SaveLoadState()
                newuser.Username = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
                newuser.MediaID = Media_IDx.Replace("?id=", "")
                newuser.CommentText = txt_Comment.Text
                Dim reqx As Boolean = Await newuser.doshowAsync_Comment(Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString())
                If reqx = True Then
                    XtraMessageBox.Show("Single Comment Done", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SimpleButton5.Enabled = True
                Else
                    XtraMessageBox.Show("Single Comment Error", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SimpleButton5.Enabled = True
                End If

            Else
                XtraMessageBox.Show("حدد حساب واحد فقط", "حدد حساب واحد فقط", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub


            End If
        Catch ex As Exception
            SimpleButton5.Enabled = True
            XtraMessageBox.Show(ex.Message, "Error_Single Comment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click


        Dim x As New frm_Sender


            x.Show()


    End Sub
    Private Sub InstgramClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Async Sub SimpleButton6_ClickAsync(sender As Object, e As EventArgs) Handles Btn_MulitComment.Click

        Try
            Btn_Mention.Enabled = False
            Btn_MulitComment.Enabled = False
            Dim commentsC As New instgram_Func

            Dim classZx As New instgram_Func
            Dim CommentWindow As New Insta_Mulit_Commnet

            Dim media_page_txt As String = Await classZx.GetPageText(txt_mediaLink.Text)
            Dim Media_IDx As String = (Regex.Match(media_page_txt, "instagram://media\?id=(.*?)""").Groups.Item(1).Value) + "_" + (Regex.Match(media_page_txt, "owner_user_id" + Chr(34) + " content=" + Chr(34) + "(.*?)" + Chr(34)).Groups.Item(1).Value)

            If Media_IDx = "" Then XtraMessageBox.Show("فشل العثور علي Media ID", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Try
            CommentWindow.mediaid = Media_IDx
            CommentWindow.Text = "Comment On Media : " & Media_IDx
            CommentWindow.HyperlinkLabelControl1.Text = txt_mediaLink.Text
            For Each rowx As DataRow In DT_AccountManager.Rows
                CommentWindow.Combo_Accounts.Items.Add(rowx.Item(0))
            Next

            CommentWindow.Show()

        Catch ex As Exception
            Btn_MulitComment.Enabled = True
            XtraMessageBox.Show(ex.Message, "Error_Mulit Comment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Btn_Mention.Enabled = True
        Btn_MulitComment.Enabled = True
    End Sub
    Private Sub ListBoxControl1_DrawItem(sender As Object, e As ListBoxDrawItemEventArgs) Handles ListBoxControl1.DrawItem
        If e.Item.ToString.ToLower.Contains("error") Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = Color.Green
        End If
    End Sub
    Private Sub Grid_Control_Accounts_MouseUp(sender As Object, e As MouseEventArgs) Handles Grid_Control_Accounts.MouseUp
        If e.Button = MouseButtons.Right Then
            PopupMenu2.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub pop_btn_DeletetSelected_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pop_btn_DeletetSelected.ItemClick

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
                Grid_Control_Accounts.DataSource = DT_AccountManager

            End If

        End If
        showIf()
    End Sub
    Private Sub pop_btn_ExportAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pop_btn_ExportAccounts.ItemClick
        AppHelper.UserDataTable_Control = DT_AccountManager
    End Sub
    Private Sub pop_btn_ImportAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pop_btn_ImportAccounts.ItemClick
        Try
            Dim temprorayDT As DataTable = New DataTable
            temprorayDT = AppHelper.UserDataTable_Control
            If temprorayDT.Rows.Count <> 0 Then
                For Each row As DataRow In temprorayDT.Rows

                    DT_AccountManager.Rows.Add(row.ItemArray)
                Next
                Grid_Control_Accounts.DataSource = DT_AccountManager
            End If
            showIf()
        Catch ex As Exception
            LogReport(True, "Import Accounts ", ex.Message)
        End Try

    End Sub
    Private Async Sub pop_btn_MulitLogin_ItemClickAsync(sender As Object, e As ItemClickEventArgs) Handles pop_btn_MulitLogin.ItemClick
        e.Item.Enabled = False
        ProgWait.Visible = True
        If OFD_Mulit.ShowDialog = DialogResult.OK Then
            Dim IsGoodFlag As Boolean = True
            For Each line As String In IO.File.ReadAllLines(OFD_Mulit.FileName)
                Dim sour As String() = line.Split(":")
                Dim account As InstagramObject
                If sour.Count = 2 Then
                    account = New InstagramObject(sour(0), sour(1), "")
                ElseIf sour.Count = 4 Then
                    account = New InstagramObject(sour(0), sour(1), sour(2) + ":" + sour(3))
                ElseIf sour.Count = 6 Then
                    account = New InstagramObject(sour(0), sour(1), sour(2) + ":" + sour(3) + ":" + sour(4) + ":" + sour(5))
                Else
                    LogReport(True, "Format Error", line)
                    IsGoodFlag = False
                End If
                Try
                    If IsGoodFlag = True Then
                        Await account.LoginMethodAsync()
                    End If
                Catch ex As Exception
                    LogReport(True, sour(0), ex.Message)
                End Try

            Next
            e.Item.Enabled = True
            showIf()
        End If
        ProgWait.Visible = False
    End Sub
    Dim TerminateFlag As Boolean = False
    Private Async Sub pop_btn_Stop_ItemClickAsync(sender As Object, e As ItemClickEventArgs) Handles pop_btn_Stop.ItemClick
        pop_btn_Stop.Visibility = BarItemVisibility.Never
        TerminateFlag = True
        pop_btn_RefreshLogin.Visibility = BarItemVisibility.Always
    End Sub

    Private Async Sub pop_btn_RefreshLogin_ItemClickAsync(sender As Object, e As ItemClickEventArgs) Handles pop_btn_RefreshLogin.ItemClick
        pop_btn_RefreshLogin.Visibility = BarItemVisibility.Never
        btn_login.Enabled = False
        ProgWait.Visible = True
        TerminateFlag = False
        pop_btn_Stop.Visibility = BarItemVisibility.Always

        Dim selectedRows() As Integer = Grid_View_Accounts.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                If TerminateFlag = True Then Exit For
                Dim Username As String = Grid_View_Accounts.GetRowCellValue(rowHandle, "Username").ToString
                Dim Passwrod As String = Grid_View_Accounts.GetRowCellValue(rowHandle, "Pasword").ToString
                Dim Proxy As String = Grid_View_Accounts.GetRowCellValue(rowHandle, "Proxy").ToString


                Grid_View_Accounts.SetRowCellValue(rowHandle, "Status", "Cheking ..")



                Dim account As InstagramObject = New InstagramObject(Username, Passwrod, Proxy)
                Dim RESULT = Await account.CheckAccount(rowHandle)
                If RESULT = False Then
                    'Grid_View_Accounts.SetRowCellValue(rowHandle, "Status", "Error")
                End If
            End If
        Next


        pop_btn_Stop.Visibility = BarItemVisibility.Never
        pop_btn_RefreshLogin.Visibility = BarItemVisibility.Always
        ProgWait.Visible = False
        btn_login.Enabled = True

    End Sub
    Private Sub ToggleSwitch1_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch1.Toggled
        If ProgramVersion.current = ProgramVersion.Standard Then
            Application.Exit()
        End If
        If ToggleSwitch1.IsOn = True Then
            Try
                ' Form1.Show()
            Catch ex As Exception

            End Try
        Else
            Try
                '   Form1.exitThread = True
                '   Form1.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim newuser As New SaveLoadState()
        newuser.Username = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
        newuser.TempFunction()
    End Sub

    Private Async Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        'Dim newuser As New SaveLoadState()
        'newuser.Username = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
        'newuser.Location()
        ' Maps.Show()
        If Grid_View_Accounts.GetSelectedRows().Count = 1 Then


            Dim x As New Maps
        x.proxyAdd = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Proxy").ToString()
        x.Loggeduser = Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
            'x.Tatgetuser = TextBox1.Text
            'x.maxload = NumericUpDown1.Value
            'x.lbl_Login_Account.Text = "Login Account : " & Grid_View_Accounts.GetRowCellValue(Grid_View_Accounts.GetSelectedRows().First, "Username").ToString()
            'x.lbl_Target_Account.Text = "Target Account : " & TextBox1.Text
            x.ShowDialog()


        Else
            XtraMessageBox.Show("حدد حساب واحد فقط", "حدد حساب واحد فقط", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub



        End If

    End Sub
    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Dim frmfil As New insta_MapsFiltration
        frmfil.Show()

    End Sub
End Class