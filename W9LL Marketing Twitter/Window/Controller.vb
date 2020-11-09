Imports System.ComponentModel
Imports System.Net
Imports AutoUpdaterDotNET
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports W9LL_Marketing_Twitter.Activation
Public Class Controller
    Public BatchSize As Integer = 50
    Public MaxRecordCount As Integer = 100000
    Public TaskList As New List(Of BackgroundWorker)
    Public DT_AccountManager As DataTable = New DataTable
    Public DT_ListOfTasks As DataTable = New DataTable
    Public DT_Tweeting_Report_Users As DataTable = New DataTable
    Public DT_Scrapper_Report_Users As DataTable = New DataTable
    Public DT_Tweets As DataTable = New DataTable
    Public DT_TweetLimit As DataTable = New DataTable
    Public DT_Following_Report As DataTable = New DataTable
    Public Sub New()
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
        If _instance Is Nothing Then _instance = Me
        'DT Account Mananger
        DT_AccountManager.Columns.Add("Username")
        DT_AccountManager.Columns.Add("Password")
        DT_AccountManager.Columns.Add("Status")
        DT_AccountManager.Columns.Add("Proxy")
        DT_AccountManager.Columns.Add("Cookies")
        DT_AccountManager.Columns.Add("GroupName")

        'DT ListOfTasks 
        DT_ListOfTasks.Columns.Add("ID")
        DT_ListOfTasks.Columns.Add("INFO")
        DT_ListOfTasks.Columns.Add("Status")
        DT_ListOfTasks.Columns.Add("accountname")
        'DT Scrapper Report Users


        DT_Scrapper_Report_Users.Columns.Add("ID")
        DT_Scrapper_Report_Users.Columns.Add("Username")
        DT_Scrapper_Report_Users.Columns.Add("QueryType")
        DT_Scrapper_Report_Users.Columns.Add("Used Account")



        'DT Tweets


        DT_Tweets.Columns.Add("ID")
        DT_Tweets.Columns.Add("TweetText")
        DT_Tweets.Columns.Add("Favourites_Count")
        DT_Tweets.Columns.Add("Retweet_Count")
        DT_Tweets.Columns.Add("Created_At")
        DT_Tweets.Columns.Add("UserName")


        'DT Twetting Report Users



        DT_Tweeting_Report_Users.Columns.Add("ID")
        DT_Tweeting_Report_Users.Columns.Add("Query Type")
        DT_Tweeting_Report_Users.Columns.Add("UsedAccount")




        'DT Following Report Users
        DT_Following_Report.Columns.Add("Query Type")
        DT_Following_Report.Columns.Add("UsedAccount")


        'DT TweetLimit
        DT_TweetLimit.Columns.Add("Username").DataType = System.Type.GetType("System.String")
        DT_TweetLimit.Columns.Add("Date").DataType = System.Type.GetType("System.DateTime")






        If System.IO.File.Exists("UserDataTable.dll") = True Then
            DT_AccountManager = UserDataTable_Control

        End If
        If System.IO.File.Exists("TweetsDataTable.dll") = True Then
            DT_Tweets = TweetsDataTable_Control
        End If

        If System.IO.File.Exists("TweetLimitDataTable.dll") = True Then
            DT_TweetLimit = TweetLimitDataTable_Control
        End If


        GridControl1.DataSource = DT_AccountManager
        Grid_Running_Tasks.DataSource = DT_ListOfTasks
        Grid_Control_Twetting.DataSource = DT_Tweets



        Grid_Control_Following_Report.DataSource = DT_Following_Report
        ' DataGridView1.DataSource = DT_Scrapper_Report_Users
        Grid_Scrapper_Report_Users.DataSource = DT_Scrapper_Report_Users

        Grid_Control_Tweeting_Report_Users.DataSource = DT_Tweeting_Report_Users


        'AddHandler VirtualServerModeSource1.AcquireInnerList, AddressOf VirtualServerModeSource1_AcquireInnerList
        'AddHandler VirtualServerModeSource1.MoreRows, AddressOf VirtualServerModeSource1_MoreRows
        'Grid_Scrapper_Report_Users.DataSource = VirtualServerModeSource1

    End Sub
    'Private Sub VirtualServerModeSource1_MoreRows(ByVal sender As Object, ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs)
    '    e.RowsTask = Task.Factory.StartNew(
    '            Function()
    '                MaxRecordCount = 30
    '                BatchSize = 30
    '                GridControl1.RefreshDataSource()

    '                Dim nextBatch = DT_Scrapper_Report_Users.Clone()
    '                Dim moreRows As Boolean = True
    '                Dim rowCount As Integer = e.CurrentRowCount
    '                Dim rnd As New Random(Guid.NewGuid().GetHashCode())

    '                moreRows = rowCount < MaxRecordCount
    '                Return New VirtualServerModeRowsTaskResult(nextBatch.DefaultView, moreRows, Nothing)
    '            End Function, e.CancellationToken)

    'End Sub

    'Private Sub VirtualServerModeSource1_AcquireInnerList(ByVal sender As Object, ByVal e As DevExpress.Data.VirtualServerModeAcquireInnerListEventArgs)
    '    e.InnerList = DT_Scrapper_Report_Users.DefaultView
    '    e.AddMoreRowsFunc = AddressOf MoreRows
    '    e.ClearAndAddRowsFunc = AddressOf ClearAndAddMoreRows
    '    e.ReleaseAction = AddressOf ReleaseList
    'End Sub

    'Public Sub ReleaseList(ByVal list As IList)
    '    TryCast(list, DataView).Table.Rows.Clear()
    'End Sub
    'Public Function MoreRows(ByVal list As IList, ByVal en As IEnumerable) As IList
    '    Dim data = TryCast(en, DataView)
    '    For Each dr As DataRow In data.Table.Rows
    '        TryCast(list, DataView).Table.Rows.Add(dr.ItemArray)
    '    Next dr
    '    Return list
    'End Function
    'Public Function ClearAndAddMoreRows(ByVal list As IList, ByVal en As IEnumerable) As IList
    '    Dim data = TryCast(en, DataView)
    '    TryCast(list, DataView).Table.Rows.Clear()
    '    For Each dr As DataRow In data.Table.Rows
    '        TryCast(list, DataView).Table.Rows.Add(dr.ItemArray)
    '    Next dr
    '    Return list
    'End Function
    Private Shared _instance As Controller = Nothing
    Sub AddRowsToThread(ByVal DataArray As String())
        Dim DT As DataTable = DT_Scrapper_Report_Users
        Dim dr As DataRow = DT.NewRow()

        For i As Integer = 0 To DataArray.Length - 1

            dr(i) = DataArray(i).ToString
        Next

        'dr(0) = txt_Username.Text
        'dr(1) = txt_password.Text
        'dr(2) = "Not Checked"
        DT.Rows.Add(dr)
    End Sub
    Sub AddRowsToDT(ByRef DT As DataTable, ByVal DataArray As String())
        Dim dr As DataRow = DT.NewRow()
        For i As Integer = 0 To DataArray.Length - 1
            dr(i) = DataArray(i).ToString
        Next
        'dr(0) = txt_Username.Text
        'dr(1) = txt_password.Text
        'dr(2) = "Not Checked"
        DT.Rows.Add(dr)
    End Sub
    Public Shared ReadOnly Property MainInstance As Controller
        Get
            Return _instance
        End Get
    End Property
    Private Sub Controller_Load(sender As Object, e As EventArgs) Handles Me.Load

        AutoUpdater.Mandatory = True
        AutoUpdater.UpdateMode = Mode.Forced
        AutoUpdater.Start("https://w9ll.co/Update/TW.xml")
        If ProgramVersion.current = ProgramVersion.Standard Then
            RG_Scrapper_Options.Properties.Items.RemoveAt(1)
            RG_Scrapper_Options.Properties.Items.RemoveAt(1)
        End If
        Me.Text = Me.Text + " - " + ProgramVersion.current

        WindowsFormsSettings.AnimationMode = AnimationMode.EnableAll
        CheckForIllegalCrossThreadCalls = False
        AddHandler Scrapper_GridView.MouseUp, AddressOf gridView1_MouseUp
        AddHandler Scrapper_GridView.MouseMove, AddressOf gridView1_MouseMove
        AddHandler Scrapper_GridView.MouseDown, AddressOf gridView1_MouseDown






        AddHandler Comb_Following.Enter, AddressOf ComboBoxEdit_Enter
        AddHandler comb_scrapper.Enter, AddressOf ComboBoxEdit_Enter
        AddHandler Comb_Tweeting.Enter, AddressOf ComboBoxEdit_Enter




    End Sub
    Private Sub Btn_AddSingleAccount_Click(sender As Object, e As EventArgs) Handles Btn_AddSingleAccount.Click
        Frm_Add_Account.ShowDialog(Me)
    End Sub

    Private Sub Btn_AddMulitpleAccount_Click(sender As Object, e As EventArgs) Handles Btn_AddMulitpleAccount.Click
        Try
            If OFD_LoadAccount.ShowDialog = DialogResult.OK Then


                For Each x As String In System.IO.File.ReadAllLines(OFD_LoadAccount.FileName, System.Text.Encoding.UTF8)
                    Dim Text_File() As String = x.Split(":")
                    Try
                        Dim dr As DataRow = DT_AccountManager.NewRow()
                        dr(0) = Text_File(0)
                        dr(1) = Text_File(1)
                        dr(2) = "Not Checked"
                        dr(3) = "LocalProxy"
                        dr(4) = "-"
                        dr(5) = "Ungrouped"





                        DT_AccountManager.Rows.Add(dr)
                    Catch ex As Exception

                    End Try


                Next




            End If


            UserDataTable_Control = DT_AccountManager

        Catch ex As Exception
            XtraMessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try









    End Sub
    Public Sub ComboBoxEdit_Enter(sender As Object, e As EventArgs)

        'Dim items = dt.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        'Dim itemsZ = (From p In dt.AsEnumerable()
        '              Select New With {.Username = p.Field(Of String)("Username"),
        '                        .Status = p.Field(Of String)("Status")}).ToList()

        'Dim filtered = itemsZ.Where(Function(x) x.Status.Contains("Not Checked")).ToArray


        'MsgBox(filtered(0).ToString)

        Dim result() As DataRow = DT_AccountManager.Select("Status = '" & AccountAuthenticationStatus.authenticated & "'")

        Dim cmb As ComboBoxEdit = CType(sender, ComboBoxEdit)
        cmb.Properties.Items.Clear()
        For Each row As DataRow In result
            cmb.Properties.Items.Add(row(0))
            Try
                cmb.SelectedIndex = 0
            Catch ex As Exception

            End Try
        Next

        Try
            comb_scrapper.SelectedIndex = 0

            Comb_Following.SelectedIndex = 0

            Comb_Tweeting.SelectedIndex = 0

        Catch ex As Exception

        End Try


    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        If (GridView1.SelectedRowsCount = 0) Then

            XtraMessageBox.Show("Please Select ACCOUNT/S ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            If XtraMessageBox.Show("Do You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim intx As Integer() = GridView1.GetSelectedRows.ToArray
                Dim temp As DataTable
                temp = GridControl1.DataSource
                Dim conter As Integer = 0

                For Each index1 As Integer In intx

                    temp.Rows.RemoveAt(index1 - conter)
                    conter += 1
                Next

                DT_AccountManager = temp

                Notify_DataTable_Update()


            End If



        End If

    End Sub
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        DT_AccountManager = GridControl1.DataSource
        UserDataTable_Control = DT_AccountManager
        Notify_DataTable_Update()
        XtraMessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Async Sub SimpleButton6_ClickAsync(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Try
            SimpleButton6.Enabled = False

            comb_scrapper.Properties.Items.Clear()
            Comb_Following.Properties.Items.Clear()
            Comb_Tweeting.Properties.Items.Clear()




            Dim taskOFlogin As New List(Of Task)
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows


                If rowHandle >= 0 Then
                    Dim Username As String = GridView1.GetRowCellValue(rowHandle, "Username").ToString
                    Dim Passwrod As String = GridView1.GetRowCellValue(rowHandle, "Password").ToString
                    Dim Proxy As String = GridView1.GetRowCellValue(rowHandle, "Proxy").ToString
                    Dim Status As String = GridView1.GetRowCellValue(rowHandle, "Status").ToString



                    Dim AccountInActive = DT_ListOfTasks.AsEnumerable().Where(Function(dr) dr.Field(Of String)("accountname").Contains(Username) And dr.Field(Of String)("Status").Contains(TaskStatus.Running))
                    If AccountInActive.Count > 0 Then
                        ListBoxControl1.Items.Add("---info--- >>> " & Username & " >>> " & " had Skipped Checking , because exist in running task")
                        GoTo SkipChecking
                    End If
                    If Proxy = "LocalProxy" Or Proxy = String.Empty Then Proxy = String.Empty
                    ListBoxControl1.Items.Add("--- Trying To Login --- >>>" & Username)


                    Dim LoginTask = Task.Factory.StartNew(
                        Function()
                            If Status = AccountAuthenticationStatus.authenticated Then


                                Dim twtob1 As New TwitterOBJECT(Username, Passwrod, True, rowHandle, Proxy, True)

                                If twtob1.isUserAuthnticted = True Then
                                    GridControl1.Invoke(New Action(Sub() GridView1.SetRowCellValue(rowHandle, "Status", AccountAuthenticationStatus.authenticated)))
                                    ListBoxControl1.Items.Add("--- Login OK ! --- >>>" & Username)
                                Else
                                    ListBoxControl1.Items.Add("---Error--- >>>" & Username & " >>> " & twtob1.loginErrorMsg)
                                    GridControl1.Invoke(New Action(Sub() GridView1.SetRowCellValue(rowHandle, "Status", AccountAuthenticationStatus.Failed)))

                                End If


                            Else


                                Dim twtob As New TwitterOBJECT(Username, Passwrod, False, rowHandle, Proxy, True)

                                If twtob.isUserAuthnticted = True Then
                                    GridControl1.Invoke(New Action(Sub() GridView1.SetRowCellValue(rowHandle, "Status", AccountAuthenticationStatus.authenticated)))
                                    ListBoxControl1.Items.Add("--- Login OK ! --- >>>" & Username)
                                Else

                                    ListBoxControl1.Items.Add("---Error--- >>>" & Username & " >>> " & twtob.loginErrorMsg)
                                    GridControl1.Invoke(New Action(Sub() GridView1.SetRowCellValue(rowHandle, "Status", AccountAuthenticationStatus.Failed)))

                                End If
                            End If

                            Return 0

                        End Function)

                    Dim result = Await LoginTask


                End If

SkipChecking:
            Next rowHandle

        Catch ex As Exception

            ListBoxControl1.Items.Add("---Error--- " & ex.InnerException.Message)
            SimpleButton6.Enabled = True
        End Try
        SimpleButton6.Enabled = True
        DT_AccountManager = GridControl1.DataSource
        UserDataTable_Control = DT_AccountManager
        Notify_DataTable_Update()

    End Sub
    Private Sub checkedListBoxControl1_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles ListBoxControl1.DrawItem
        If e.Item.ToString.ToLower.Contains("error") Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = Color.Green
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If comb_scrapper.SelectedItem = Nothing Then
            XtraMessageBox.Show("قم بتحديد الحساب المستخدم اولاً ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If txt_scrapper_Command.Text = String.Empty Then
            XtraMessageBox.Show("يرجي ادخال اسم الحساب المستهدف / كلمه مفتاحيه / هاشتاق", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If txt_scrapper_Command.Text.StartsWith("#") Then
            If RG_Scrapper_Options.SelectedIndex <> 2 Then
                XtraMessageBox.Show("قم بتحديد خيار الهاشتاق", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim target As String = txt_scrapper_Command.Text
        Dim CurrentAccount As String = comb_scrapper.SelectedItem.ToString
        Dim maxSearchResults As String = Scrapper_Num_MaxSearchResult.Value

        Dim t As New BackgroundWorker
        t.WorkerSupportsCancellation = True

        If RG_Scrapper_Options.SelectedIndex = 0 Then





            If RadG_Follow.SelectedIndex = 0 Then

                AddHandler t.DoWork, Sub()



                                         Dim twOBJ As New TwitterOBJECT(CurrentAccount, String.Empty, True)
                                         twOBJ.CurrentAccount = CurrentAccount
                                         twOBJ.QureyType = "Scrap Follwers >" & target
                                         twOBJ.taskID = t.GetHashCode()
                                         twOBJ.MaxSearchResult = maxSearchResults
                                         twOBJ.ScrapFollowers(target)


                                     End Sub

                TaskList.Add(t)

                AddRowsToDT(DT_ListOfTasks, {t.GetHashCode, "User : " & CurrentAccount & " Scrapping Followers From > " & txt_scrapper_Command.Text, TaskStatus.Ready, CurrentAccount})
            Else


                AddHandler t.DoWork, Sub()
                                         Dim twOBJ As New TwitterOBJECT
                                         twOBJ.CurrentAccount = CurrentAccount
                                         twOBJ.QureyType = "Scrap Following >" & target
                                         twOBJ.taskID = t.GetHashCode()
                                         twOBJ.MaxSearchResult = maxSearchResults
                                         twOBJ.ScrapFollowers(txt_scrapper_Command.Text, "following")
                                     End Sub
                TaskList.Add(t)

                AddRowsToDT(DT_ListOfTasks, {t.GetHashCode, "User : " & CurrentAccount & " Scrapping Followeing From > " & txt_scrapper_Command.Text, TaskStatus.Ready, CurrentAccount})
            End If

        Else

            If RG_Scrapper_Options.SelectedIndex = 2 Then
                If txt_scrapper_Command.Text.StartsWith("#") Then
                Else
                    txt_scrapper_Command.Text = "#" & txt_scrapper_Command.Text
                End If
            End If









            AddHandler t.DoWork, Sub()


                                     Dim twOBJ As New TwitterOBJECT(CurrentAccount, String.Empty, True)

                                     twOBJ.CurrentAccount = CurrentAccount
                                     twOBJ.QureyType = "Scrap Following >" & target
                                     twOBJ.taskID = t.GetHashCode()
                                     twOBJ.MaxSearchResult = maxSearchResults
                                     twOBJ.ScrapByKeyword(target)

                                 End Sub
            TaskList.Add(t)

            AddRowsToDT(DT_ListOfTasks, {t.GetHashCode, "User : " & CurrentAccount & " Scrapping KeyWord " & target, TaskStatus.Ready, CurrentAccount})





        End If


        XtraMessageBox.Show("تم اضافة العمليه الي القائمه بنجاح", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txt_scrapper_Command.Text = String.Empty
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles Btn_StartThread.Click
        Dim selectedRows() As Integer = GridView_RunningTasks.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                Dim ID As String = GridView_RunningTasks.GetRowCellValue(rowHandle, "ID").ToString
                Dim status As String = GridView_RunningTasks.GetRowCellValue(rowHandle, "Status").ToString
                If status = TaskStatus.Running Then
                    XtraMessageBox.Show("لا يمكنك بدأ تشغيل نفس العمليه اكثر من مرة", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If status = TaskStatus.Failed Then
                    XtraMessageBox.Show("تم الانتهاء بالفعل من هذه العمليه", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                For Each t As BackgroundWorker In TaskList
                    If t.GetHashCode = ID Then
                        CurrentWorkingTask.PIDS += t.GetHashCode & " "
                        t.RunWorkerAsync()
                        GridView_RunningTasks.SetRowCellValue(rowHandle, "Status", TaskStatus.Running)
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub RG_Scrapper_Options_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RG_Scrapper_Options.SelectedIndexChanged
        If RG_Scrapper_Options.SelectedIndex = 0 Then
            RadG_Follow.Visible = True
        Else
            RadG_Follow.Visible = False
        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btn_StopThread.Click
        Dim selectedRows() As Integer = GridView_RunningTasks.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                Dim ID As String = GridView_RunningTasks.GetRowCellValue(rowHandle, "ID").ToString
                Dim status As String = GridView_RunningTasks.GetRowCellValue(rowHandle, "Status").ToString
                If status = TaskStatus.Running Then
                    For Each t As BackgroundWorker In TaskList
                        If t.GetHashCode = ID Then
                            CurrentWorkingTask.PIDS = CurrentWorkingTask.PIDS.Replace(ID & " ", "")
                            t.CancelAsync()
                            GridView_RunningTasks.SetRowCellValue(rowHandle, "Status", TaskStatus.Stopped)
                            DT_ListOfTasks.Rows.RemoveAt(rowHandle)
                            'For Each row As DataRow In DT_ListOfTasks.Rows

                            '    If row("ID").ToString() = ID Then

                            '        row.Delete()

                            '    End If


                            'Next

                        End If
                    Next


                    XtraMessageBox.Show("تم ايقاف العمليه بنجاح", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            End If
        Next

    End Sub
    Private Async Sub SimpleButton2_Click_1Async(sender As Object, e As EventArgs) Handles Btn_Tweet.Click
        If Comb_Tweeting.SelectedItem = Nothing Then
            XtraMessageBox.Show("قم بتحديد الحساب المستخدم اولاً ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ProgramVersion.current = ProgramVersion.Standard Then
            Dim result() As DataRow = DT_TweetLimit.Select("Username = '" & Comb_Tweeting.SelectedItem & "' AND Date=#" & Now.Date & "#")
            If result.Count > 3 Then
                XtraMessageBox.Show("تم الوصول للحد الاقصي من التغريدات لهذا الحساب", "نظام التغريد", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Try
            Dim twOBJ As New TwitterOBJECT(Comb_Tweeting.SelectedItem.ToString, String.Empty, True,,, True)
            twOBJ.taskID = twOBJ.GetHashCode
            If twOBJ.cookieContainer Is Nothing Then
                Exit Sub
            End If
            Btn_Tweet.Enabled = False
            Dim tweet As New Embedded_Browser
            tweet.Text = "New Tweet : " & Comb_Tweeting.SelectedItem.ToString
            tweet.CookiesCont = twOBJ.cookieContainer
            tweet.Remove_BrowserCook()

            If tweet.ShowDialog = DialogResult.Cancel Then
                XtraMessageBox.Show("تم الالغاء بنجاح", "نظام التغريد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Btn_Tweet.Enabled = True
            Else
                ListBoxControl1.Items.Add("الحصول علي تغريديك ... برجاء الانتظار")




                twOBJ.CurrentAccount = Comb_Tweeting.SelectedItem.ToString
                twOBJ.QureyType = "Getting Your Tweet "
                twOBJ.taskID = twOBJ.GetHashCode
                Dim r = Await twOBJ.GetLastTweetAsync()



                If r = True Then
                    Btn_Tweet.Enabled = True
                    ListBoxControl1.Items.Add("تم الحصول علي التغريده بنجاح")
                    If ProgramVersion.current = ProgramVersion.Standard Then


                        DT_TweetLimit.Rows.Add(Comb_Tweeting.SelectedItem, Now.Date)
                        TweetLimitDataTable_Control = DT_TweetLimit
                    End If
                Else
                    Btn_Tweet.Enabled = True
                End If
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "نظام التغريد", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Btn_Tweet.Enabled = True
            Exit Sub
        End Try









        'client.UploadData("https://  upload.twitter.com/i/media/upload.json?command=APPEND&media_id=1123630809842425856 & segment_index=0", bytesx)


        'If opf.ShowDialog = DialogResult.OK Then

        'End If
    End Sub

    Private Sub btn_Tweeting_Support_Click(sender As Object, e As EventArgs) Handles btn_Tweeting_Support.Click
        If Comb_Tweeting_Support_Fuction.SelectedItem = Nothing Then
            XtraMessageBox.Show("قم بتحديد نوع الدعم ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If (Grid_View_Twetting.SelectedRowsCount = 0) Then
            XtraMessageBox.Show("قم بتحديد بعض التغريدات ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim accSlele As New AccountSelector

        Select Case (Comb_Tweeting_Support_Fuction.SelectedIndex)
            Case 0
                accSlele.QureyShortName = QureyTypes.Q_Like
                accSlele.ShowDialog()

            Case 1
                accSlele.QureyShortName = QureyTypes.Q_Retweet
                accSlele.ShowDialog()

            Case 2
                If Grid_View_Twetting.SelectedRowsCount > 1 Then
                    XtraMessageBox.Show("قم بتحديد تغريده واحده فقط في عمليه المنشن", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End If
                XtraMessageBox.Show("قم بتحديد ملف المستخدمين", "تحديد الملف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim MentionWindow As New Frm_Mentions
                MentionWindow.QureyShortName = QureyTypes.Q_Comment
                MentionWindow.TweetID = Grid_View_Twetting.GetRowCellValue(Grid_View_Twetting.GetSelectedRows().First, "ID").ToString()
                MentionWindow.Text = "Mention ON >>" & MentionWindow.TweetID
                MentionWindow.Show()
        End Select


    End Sub

    Private Sub Btn_Tweeting_RetriveTweetInfo_ClickAsync(sender As Object, e As EventArgs) Handles Btn_Tweeting_RetriveTweetInfo.Click
        If (Grid_View_Twetting.SelectedRowsCount = 0) Then
            XtraMessageBox.Show("قم بتحديد بعض التغريcدات ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Comb_Tweeting.SelectedItem = Nothing Then
            XtraMessageBox.Show("قم بتحديد الحساب المستخدم اولاً ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        Dim twOBJ As New TwitterOBJECT(Comb_Tweeting.SelectedItem, String.Empty, True,,, True)

        Dim selectedRows() As Integer = Grid_View_Twetting.GetSelectedRows()

        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                Try

                    Dim TweetID As String = Grid_View_Twetting.GetRowCellValue(rowHandle, "ID").ToString
                    twOBJ.GetTweetInfo(TweetID)



                Catch ex As Exception
                    ListBoxControl1.Items.Add(ex.InnerException)
                    Exit Sub
                End Try


            End If
        Next

    End Sub

    Private Async Sub ComboBoxEdit1_SelectedIndexChangedAsync(sender As Object, e As EventArgs) Handles TrendComboBox.SelectedIndexChanged
        Try

            ProgressPanel1.Visible = True
            TrendComboBox.Enabled = False
            Dim parameter As String = String.Empty
            'Select Case TrendComboBox.SelectedIndex
            '    Case 0
            '        parameter = "SA"
            '    Case 1
            '        parameter = "KW"
            '    Case 2
            '        parameter = "BH"
            '    Case 3
            '        parameter = "AE"
            '    Case 4
            '        parameter = "OM"
            'End Select



            Select Case TrendComboBox.SelectedIndex
                Case 0
                    parameter = "saudi-arabia"
                Case 1
                    parameter = "kuwait"
                Case 2
                    parameter = "bahrain"
                Case 3
                    parameter = "united-arab-emirates"
                Case 4
                    parameter = "oman"
                Case 4
                    parameter = "qatar"
            End Select

            Try
                Dim trend As New TwitterOBJECT(,,,,, True)

                Await trend.Get_Trending_HashTagAsync(parameter)

            Finally

                TrendComboBox.Enabled = True

                ProgressPanel1.Visible = False
            End Try


        Catch ex As WebException
            Controller.MainInstance.ListBoxControl1.Items.Add("---Error--- >>> " + ex.Message)

        End Try


    End Sub



    Private Sub SelectRows(ByVal view As GridView, ByVal startRow As Integer, ByVal endRow As Integer)

        If startRow > -1 AndAlso endRow > -1 Then

            view.BeginSelection()

            view.ClearSelection()

            view.SelectRange(startRow, endRow)

            view.EndSelection()

        End If

    End Sub

    Private Function GetRowAt(ByVal view As GridView, ByVal x As Integer, ByVal y As Integer) As Integer
        Return view.CalcHitInfo(New Point(x, y)).RowHandle
    End Function
    Private StartRowHandle As Integer = -1
    Private CurrentRowHandle As Integer = -1
    Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
    End Sub
    Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim newRowHandle As Integer = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
        If CurrentRowHandle <> newRowHandle Then
            CurrentRowHandle = newRowHandle
            SelectRows(TryCast(sender, GridView), StartRowHandle, CurrentRowHandle)
        End If
    End Sub
    Private Sub gridView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = -1
        CurrentRowHandle = -1
    End Sub

    Private Sub تصديرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصديرToolStripMenuItem.Click
        Try
            ScrapperDataTable_Control = DT_Scrapper_Report_Users

        Catch ex As Exception

        End Try

    End Sub

    Private Sub استيرادToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استيرادToolStripMenuItem.Click
        Try
            DT_Scrapper_Report_Users = ScrapperDataTable_Control

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBoxControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBoxControl1.KeyDown
        If e.KeyCode = Keys.F12 Then
            ListBoxControl1.Items.Clear()
        End If
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs, Optional op As String = "follow") Handles SimpleButton2.Click
        If Comb_Following.SelectedItem = Nothing Then
            XtraMessageBox.Show("قم بتحديد الحساب المستخدم اولاً ", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If num2.Value < num1.Value Then
            XtraMessageBox.Show("الفاصل الزمني يجب ان يكون الرقم الاول اقل من الثاني", "خطأ في تكوين العملية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim DT_ScrappedUsers As DataTable = New DataTable
        Dim LoadedUsers() As String
        DT_ScrappedUsers = ScrapperDataTable_Control

        If DT_ScrappedUsers.Rows.Count = 0 Then

            XtraMessageBox.Show("تم ايقاف العمليه بنجاح", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        LoadedUsers = DT_ScrappedUsers.Rows.OfType(Of DataRow).Select(Function(k) k(0).ToString()).ToArray()
        Dim CurrentAccount As String = Comb_Following.SelectedItem.ToString
        Dim qtype As String = "User : " & CurrentAccount & " Following " & LoadedUsers.Count & " Users"
        Dim nummin = num1.Value, nummax As Integer = num2.Value

        If op = "unfollow" Then

            qtype = "User : " & CurrentAccount & "unFollowing" & LoadedUsers.Count & "Users"


        End If

        Dim t As New BackgroundWorker
        t.WorkerSupportsCancellation = True

        AddHandler t.DoWork, Sub()



                                 Dim twOBJ As New TwitterOBJECT(CurrentAccount, String.Empty, True)



                                 twOBJ.CurrentAccount = CurrentAccount
                                 twOBJ.QureyType = qtype
                                 twOBJ.taskID = t.GetHashCode()
                                 twOBJ.Delay_Min = nummin
                                 twOBJ.Delay_Max = nummax
                                 twOBJ.Follow_UnFollowAsync(LoadedUsers, op)


                             End Sub
        TaskList.Add(t)

        AddRowsToDT(DT_ListOfTasks, {t.GetHashCode, qtype, TaskStatus.Ready, CurrentAccount})
        XtraMessageBox.Show("تم اضافة العمليه الي القائمه بنجاح", "قائمه العمليات", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        SimpleButton2_Click_1(Nothing, Nothing, "unfollow")
    End Sub
    Private Sub Controller_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Comb_Tweeting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb_Tweeting.SelectedIndexChanged

    End Sub
End Class