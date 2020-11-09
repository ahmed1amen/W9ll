<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_FacebookApplication
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FacebookApplication))
        Me.RD_text = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RD_link = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Currentusername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Grid_Control_Accounts = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Accounts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Username = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Password = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccessToken = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cookies = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_password = New DevExpress.XtraEditors.TextEdit()
        Me.txt_username = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pnl_link = New System.Windows.Forms.Panel()
        Me.TextBox1 = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Btn_Import = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Export = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_post = New DevExpress.XtraEditors.MemoEdit()
        Me.Ck_posttogroup = New DevExpress.XtraEditors.CheckEdit()
        Me.Ck_posttomywall = New DevExpress.XtraEditors.CheckEdit()
        Me.Ck_posttopages = New DevExpress.XtraEditors.CheckEdit()
        Me.Ck_posttofriends = New DevExpress.XtraEditors.CheckEdit()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ListView_currentLogginUser_Groups = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ListView_currentLogginUser_friends = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ListView_currentLogginUser_Pages = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Goup_maxResults = New System.Windows.Forms.NumericUpDown()
        Me.ListView_currentLogginUser_searchResult = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_groupStartjoin = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_groupStartScrap = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_groupStopSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_groupStartSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_keyword = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.ListView7 = New System.Windows.Forms.ListView()
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.ListView8 = New System.Windows.Forms.ListView()
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_target = New DevExpress.XtraEditors.TextEdit()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button13 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Txt_Log = New System.Windows.Forms.RichTextBox()
        Me.SFD_Accounts = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        Me.OFD_Accounts = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid_Control_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.pnl_link.SuspendLayout()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_post.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_posttogroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_posttomywall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_posttopages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_posttofriends.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Goup_maxResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_keyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        CType(Me.txt_target.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RD_text
        '
        Me.RD_text.AutoSize = True
        Me.RD_text.Checked = True
        Me.RD_text.Location = New System.Drawing.Point(16, 27)
        Me.RD_text.Name = "RD_text"
        Me.RD_text.Size = New System.Drawing.Size(47, 17)
        Me.RD_text.TabIndex = 34
        Me.RD_text.TabStop = True
        Me.RD_text.Text = "Text"
        Me.RD_text.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem, Me.ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 48)
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.IDToolStripMenuItem.Text = "ID نسخ"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem.Text = "نسخ الاسم"
        '
        'RD_link
        '
        Me.RD_link.AutoSize = True
        Me.RD_link.Location = New System.Drawing.Point(97, 27)
        Me.RD_link.Name = "RD_link"
        Me.RD_link.Size = New System.Drawing.Size(43, 17)
        Me.RD_link.TabIndex = 36
        Me.RD_link.Text = "Link"
        Me.RD_link.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 2
        '
        'lbl_Currentusername
        '
        Me.lbl_Currentusername.AutoSize = True
        Me.lbl_Currentusername.Location = New System.Drawing.Point(61, 7)
        Me.lbl_Currentusername.Name = "lbl_Currentusername"
        Me.lbl_Currentusername.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Currentusername.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lbl_Currentusername)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1271, 53)
        Me.Panel3.TabIndex = 13
        '
        'BackgroundWorker1
        '
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.CustomHeaderButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() {New DevExpress.XtraTab.Buttons.CustomHeaderButton()})
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 107)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1271, 467)
        Me.XtraTabControl1.TabIndex = 23
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.Grid_Control_Accounts)
        Me.XtraTabPage1.Controls.Add(Me.Button1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.txt_password)
        Me.XtraTabPage1.Controls.Add(Me.txt_username)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1269, 442)
        Me.XtraTabPage1.Text = "Accounts"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(315, 25)
        Me.LabelControl3.TabIndex = 62
        Me.LabelControl3.Text = "اضغط مرتين لبدأ الحساب المسجل مسبقاً"
        '
        'Grid_Control_Accounts
        '
        Me.Grid_Control_Accounts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid_Control_Accounts.Location = New System.Drawing.Point(0, 87)
        Me.Grid_Control_Accounts.MainView = Me.Grid_View_Accounts
        Me.Grid_Control_Accounts.Name = "Grid_Control_Accounts"
        Me.Grid_Control_Accounts.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Grid_Control_Accounts.Size = New System.Drawing.Size(1269, 355)
        Me.Grid_Control_Accounts.TabIndex = 61
        Me.Grid_Control_Accounts.UseEmbeddedNavigator = True
        Me.Grid_Control_Accounts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_View_Accounts, Me.TileView1})
        '
        'Grid_View_Accounts
        '
        Me.Grid_View_Accounts.ActiveFilterEnabled = False
        Me.Grid_View_Accounts.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Grid_View_Accounts.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Accounts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Username, Me.Password, Me.AccessToken, Me.Cookies})
        Me.Grid_View_Accounts.GridControl = Me.Grid_Control_Accounts
        Me.Grid_View_Accounts.Name = "Grid_View_Accounts"
        Me.Grid_View_Accounts.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Accounts.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsBehavior.KeepFocusedRowOnUpdate = False
        Me.Grid_View_Accounts.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.Grid_View_Accounts.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        Me.Grid_View_Accounts.OptionsCustomization.AllowGroup = False
        Me.Grid_View_Accounts.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Accounts.OptionsFilter.AllowColumnMRUFilterList = False
        Me.Grid_View_Accounts.OptionsFilter.AllowFilterEditor = False
        Me.Grid_View_Accounts.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.Grid_View_Accounts.OptionsFilter.AllowMRUFilterList = False
        Me.Grid_View_Accounts.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.Grid_View_Accounts.OptionsMenu.EnableGroupPanelMenu = False
        Me.Grid_View_Accounts.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.Grid_View_Accounts.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.Grid_View_Accounts.OptionsView.AllowHtmlDrawGroups = False
        Me.Grid_View_Accounts.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office
        Me.Grid_View_Accounts.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.Grid_View_Accounts.OptionsView.ShowGroupPanel = False
        '
        'Username
        '
        Me.Username.AppearanceCell.Options.UseTextOptions = True
        Me.Username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Username.AppearanceHeader.Options.UseTextOptions = True
        Me.Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Username.Caption = "اسم المستخدم"
        Me.Username.FieldName = "Username"
        Me.Username.Name = "Username"
        Me.Username.OptionsColumn.AllowEdit = False
        Me.Username.OptionsColumn.ReadOnly = True
        Me.Username.Visible = True
        Me.Username.VisibleIndex = 0
        '
        'Password
        '
        Me.Password.AppearanceCell.Options.UseTextOptions = True
        Me.Password.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Password.AppearanceHeader.Options.UseTextOptions = True
        Me.Password.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Password.Caption = "كلمه السر"
        Me.Password.FieldName = "Password"
        Me.Password.Name = "Password"
        Me.Password.OptionsColumn.AllowEdit = False
        Me.Password.OptionsColumn.ReadOnly = True
        Me.Password.Visible = True
        Me.Password.VisibleIndex = 1
        '
        'AccessToken
        '
        Me.AccessToken.AppearanceCell.Options.UseTextOptions = True
        Me.AccessToken.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccessToken.AppearanceHeader.Options.UseTextOptions = True
        Me.AccessToken.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccessToken.Caption = "Access Token"
        Me.AccessToken.FieldName = "AccessToken"
        Me.AccessToken.Name = "AccessToken"
        Me.AccessToken.OptionsColumn.AllowEdit = False
        Me.AccessToken.OptionsColumn.ReadOnly = True
        Me.AccessToken.Visible = True
        Me.AccessToken.VisibleIndex = 2
        '
        'Cookies
        '
        Me.Cookies.AppearanceCell.Options.UseTextOptions = True
        Me.Cookies.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cookies.AppearanceHeader.Options.UseTextOptions = True
        Me.Cookies.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cookies.Caption = "Cookies"
        Me.Cookies.FieldName = "Cookies"
        Me.Cookies.Name = "Cookies"
        Me.Cookies.OptionsColumn.AllowEdit = False
        Me.Cookies.OptionsColumn.ReadOnly = True
        Me.Cookies.Visible = True
        Me.Cookies.VisibleIndex = 3
        '
        'TileView1
        '
        Me.TileView1.GridControl = Me.Grid_Control_Accounts
        Me.TileView1.Name = "TileView1"
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Location = New System.Drawing.Point(733, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(388, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 25)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Password :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(382, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 25)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Username : "
        '
        'txt_password
        '
        Me.txt_password.EditValue = ""
        Me.txt_password.Location = New System.Drawing.Point(484, 46)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Size = New System.Drawing.Size(243, 32)
        Me.txt_password.TabIndex = 3
        '
        'txt_username
        '
        Me.txt_username.EditValue = ""
        Me.txt_username.Location = New System.Drawing.Point(484, 10)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.txt_username.Properties.Appearance.Options.UseFont = True
        Me.txt_username.Size = New System.Drawing.Size(243, 32)
        Me.txt_username.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton3)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1269, 442)
        Me.XtraTabPage2.Text = "Posting"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pnl_link)
        Me.GroupControl1.Controls.Add(Me.txt_post)
        Me.GroupControl1.Controls.Add(Me.RD_text)
        Me.GroupControl1.Controls.Add(Me.Ck_posttogroup)
        Me.GroupControl1.Controls.Add(Me.RD_link)
        Me.GroupControl1.Controls.Add(Me.Ck_posttomywall)
        Me.GroupControl1.Controls.Add(Me.Ck_posttopages)
        Me.GroupControl1.Controls.Add(Me.Ck_posttofriends)
        Me.GroupControl1.Controls.Add(Me.Button8)
        Me.GroupControl1.Controls.Add(Me.Button2)
        Me.GroupControl1.Location = New System.Drawing.Point(19, 10)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(369, 422)
        Me.GroupControl1.TabIndex = 44
        Me.GroupControl1.Text = "Posting"
        '
        'pnl_link
        '
        Me.pnl_link.Controls.Add(Me.TextBox1)
        Me.pnl_link.Controls.Add(Me.Label1)
        Me.pnl_link.Location = New System.Drawing.Point(10, 273)
        Me.pnl_link.Name = "pnl_link"
        Me.pnl_link.Size = New System.Drawing.Size(333, 34)
        Me.pnl_link.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 7)
        Me.TextBox1.MenuManager = Me.RibbonControl1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 20)
        Me.TextBox1.TabIndex = 31
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.Btn_Import, Me.Btn_Export, Me.BarButtonItem1, Me.Btn_Remove})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1271, 54)
        '
        'Btn_Import
        '
        Me.Btn_Import.Caption = "استيراد الحسابات"
        Me.Btn_Import.Id = 2
        Me.Btn_Import.ImageOptions.Image = CType(resources.GetObject("Btn_Import.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Import.Name = "Btn_Import"
        '
        'Btn_Export
        '
        Me.Btn_Export.Caption = "تصدير الحسابات"
        Me.Btn_Export.Id = 3
        Me.Btn_Export.ImageOptions.Image = CType(resources.GetObject("Btn_Export.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Caption = "حذف"
        Me.Btn_Remove.Id = 5
        Me.Btn_Remove.ImageOptions.Image = CType(resources.GetObject("Btn_Remove.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Remove.Name = "Btn_Remove"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "الرابط"
        '
        'txt_post
        '
        Me.txt_post.Location = New System.Drawing.Point(7, 56)
        Me.txt_post.MenuManager = Me.RibbonControl1
        Me.txt_post.Name = "txt_post"
        Me.txt_post.Size = New System.Drawing.Size(331, 207)
        Me.txt_post.TabIndex = 30
        '
        'Ck_posttogroup
        '
        Me.Ck_posttogroup.Location = New System.Drawing.Point(194, 390)
        Me.Ck_posttogroup.MenuManager = Me.RibbonControl1
        Me.Ck_posttogroup.Name = "Ck_posttogroup"
        Me.Ck_posttogroup.Properties.Caption = "نشر في القروبات المحدده"
        Me.Ck_posttogroup.Size = New System.Drawing.Size(155, 19)
        Me.Ck_posttogroup.TabIndex = 42
        '
        'Ck_posttomywall
        '
        Me.Ck_posttomywall.Location = New System.Drawing.Point(214, 363)
        Me.Ck_posttomywall.MenuManager = Me.RibbonControl1
        Me.Ck_posttomywall.Name = "Ck_posttomywall"
        Me.Ck_posttomywall.Properties.Caption = "نشر علي حائطي"
        Me.Ck_posttomywall.Size = New System.Drawing.Size(103, 19)
        Me.Ck_posttomywall.TabIndex = 41
        '
        'Ck_posttopages
        '
        Me.Ck_posttopages.Location = New System.Drawing.Point(7, 390)
        Me.Ck_posttopages.MenuManager = Me.RibbonControl1
        Me.Ck_posttopages.Name = "Ck_posttopages"
        Me.Ck_posttopages.Properties.Caption = " نشر علي الصفحات المحدده"
        Me.Ck_posttopages.Size = New System.Drawing.Size(153, 19)
        Me.Ck_posttopages.TabIndex = 40
        '
        'Ck_posttofriends
        '
        Me.Ck_posttofriends.Location = New System.Drawing.Point(7, 365)
        Me.Ck_posttofriends.MenuManager = Me.RibbonControl1
        Me.Ck_posttofriends.Name = "Ck_posttofriends"
        Me.Ck_posttofriends.Properties.Caption = "نشر علي حوائط الاصدقاء المحددين"
        Me.Ck_posttofriends.Size = New System.Drawing.Size(187, 19)
        Me.Ck_posttofriends.TabIndex = 39
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(243, 328)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Stop"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Post"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(763, 35)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(129, 58)
        Me.SimpleButton3.TabIndex = 43
        Me.SimpleButton3.Text = "Load Information"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TabControl2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(927, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 442)
        Me.Panel2.TabIndex = 29
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(23, 412)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(129, 23)
        Me.SimpleButton2.TabIndex = 50
        Me.SimpleButton2.Text = "تحديد الكل"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(258, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 30
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(332, 401)
        Me.TabControl2.TabIndex = 27
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ListView_currentLogginUser_Groups)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(324, 375)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "القروبات"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ListView_currentLogginUser_Groups
        '
        Me.ListView_currentLogginUser_Groups.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_currentLogginUser_Groups.CheckBoxes = True
        Me.ListView_currentLogginUser_Groups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView_currentLogginUser_Groups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_currentLogginUser_Groups.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_currentLogginUser_Groups.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView_currentLogginUser_Groups.FullRowSelect = True
        Me.ListView_currentLogginUser_Groups.GridLines = True
        Me.ListView_currentLogginUser_Groups.HideSelection = False
        Me.ListView_currentLogginUser_Groups.Location = New System.Drawing.Point(3, 3)
        Me.ListView_currentLogginUser_Groups.Name = "ListView_currentLogginUser_Groups"
        Me.ListView_currentLogginUser_Groups.Size = New System.Drawing.Size(318, 369)
        Me.ListView_currentLogginUser_Groups.TabIndex = 25
        Me.ListView_currentLogginUser_Groups.UseCompatibleStateImageBehavior = False
        Me.ListView_currentLogginUser_Groups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Select"
        Me.ColumnHeader1.Width = 52
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 229
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 172
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ListView_currentLogginUser_friends)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(324, 375)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "الاصدقاء"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ListView_currentLogginUser_friends
        '
        Me.ListView_currentLogginUser_friends.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_currentLogginUser_friends.CheckBoxes = True
        Me.ListView_currentLogginUser_friends.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView_currentLogginUser_friends.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_currentLogginUser_friends.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_currentLogginUser_friends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView_currentLogginUser_friends.FullRowSelect = True
        Me.ListView_currentLogginUser_friends.GridLines = True
        Me.ListView_currentLogginUser_friends.HideSelection = False
        Me.ListView_currentLogginUser_friends.Location = New System.Drawing.Point(3, 3)
        Me.ListView_currentLogginUser_friends.Name = "ListView_currentLogginUser_friends"
        Me.ListView_currentLogginUser_friends.Size = New System.Drawing.Size(318, 369)
        Me.ListView_currentLogginUser_friends.TabIndex = 28
        Me.ListView_currentLogginUser_friends.UseCompatibleStateImageBehavior = False
        Me.ListView_currentLogginUser_friends.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Select"
        Me.ColumnHeader10.Width = 52
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 229
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ID"
        Me.ColumnHeader12.Width = 172
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ListView_currentLogginUser_Pages)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(324, 375)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "الصفحات"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ListView_currentLogginUser_Pages
        '
        Me.ListView_currentLogginUser_Pages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_currentLogginUser_Pages.CheckBoxes = True
        Me.ListView_currentLogginUser_Pages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.ListView_currentLogginUser_Pages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_currentLogginUser_Pages.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_currentLogginUser_Pages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView_currentLogginUser_Pages.FullRowSelect = True
        Me.ListView_currentLogginUser_Pages.GridLines = True
        Me.ListView_currentLogginUser_Pages.HideSelection = False
        Me.ListView_currentLogginUser_Pages.Location = New System.Drawing.Point(0, 0)
        Me.ListView_currentLogginUser_Pages.Name = "ListView_currentLogginUser_Pages"
        Me.ListView_currentLogginUser_Pages.Size = New System.Drawing.Size(324, 375)
        Me.ListView_currentLogginUser_Pages.TabIndex = 29
        Me.ListView_currentLogginUser_Pages.UseCompatibleStateImageBehavior = False
        Me.ListView_currentLogginUser_Pages.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Select"
        Me.ColumnHeader13.Width = 52
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Name"
        Me.ColumnHeader14.Width = 229
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ID"
        Me.ColumnHeader15.Width = 172
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Goup_maxResults)
        Me.XtraTabPage3.Controls.Add(Me.ListView_currentLogginUser_searchResult)
        Me.XtraTabPage3.Controls.Add(Me.btn_groupStartjoin)
        Me.XtraTabPage3.Controls.Add(Me.btn_groupStartScrap)
        Me.XtraTabPage3.Controls.Add(Me.btn_groupStopSearch)
        Me.XtraTabPage3.Controls.Add(Me.btn_groupStartSearch)
        Me.XtraTabPage3.Controls.Add(Me.Label9)
        Me.XtraTabPage3.Controls.Add(Me.Label2)
        Me.XtraTabPage3.Controls.Add(Me.txt_keyword)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1269, 442)
        Me.XtraTabPage3.Text = "Groups"
        '
        'Goup_maxResults
        '
        Me.Goup_maxResults.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Goup_maxResults.Location = New System.Drawing.Point(307, 16)
        Me.Goup_maxResults.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.Goup_maxResults.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Goup_maxResults.Name = "Goup_maxResults"
        Me.Goup_maxResults.Size = New System.Drawing.Size(53, 20)
        Me.Goup_maxResults.TabIndex = 43
        Me.Goup_maxResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Goup_maxResults.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ListView_currentLogginUser_searchResult
        '
        Me.ListView_currentLogginUser_searchResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_currentLogginUser_searchResult.CheckBoxes = True
        Me.ListView_currentLogginUser_searchResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView_currentLogginUser_searchResult.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView_currentLogginUser_searchResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView_currentLogginUser_searchResult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_currentLogginUser_searchResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView_currentLogginUser_searchResult.FullRowSelect = True
        Me.ListView_currentLogginUser_searchResult.GridLines = True
        Me.ListView_currentLogginUser_searchResult.HideSelection = False
        Me.ListView_currentLogginUser_searchResult.Location = New System.Drawing.Point(0, 42)
        Me.ListView_currentLogginUser_searchResult.Name = "ListView_currentLogginUser_searchResult"
        Me.ListView_currentLogginUser_searchResult.Size = New System.Drawing.Size(1269, 400)
        Me.ListView_currentLogginUser_searchResult.TabIndex = 42
        Me.ListView_currentLogginUser_searchResult.UseCompatibleStateImageBehavior = False
        Me.ListView_currentLogginUser_searchResult.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Select"
        Me.ColumnHeader6.Width = 52
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "الاسم"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 424
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "ID"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 271
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "عدد الاعضاء"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 90
        '
        'btn_groupStartjoin
        '
        Me.btn_groupStartjoin.Location = New System.Drawing.Point(713, 11)
        Me.btn_groupStartjoin.Name = "btn_groupStartjoin"
        Me.btn_groupStartjoin.Size = New System.Drawing.Size(219, 23)
        Me.btn_groupStartjoin.TabIndex = 41
        Me.btn_groupStartjoin.Text = "ارسال الانضمام الي المجموعات المحدده"
        '
        'btn_groupStartScrap
        '
        Me.btn_groupStartScrap.Location = New System.Drawing.Point(633, 11)
        Me.btn_groupStartScrap.Name = "btn_groupStartScrap"
        Me.btn_groupStartScrap.Size = New System.Drawing.Size(75, 23)
        Me.btn_groupStartScrap.TabIndex = 40
        Me.btn_groupStartScrap.Text = "سحب"
        '
        'btn_groupStopSearch
        '
        Me.btn_groupStopSearch.Location = New System.Drawing.Point(554, 11)
        Me.btn_groupStopSearch.Name = "btn_groupStopSearch"
        Me.btn_groupStopSearch.Size = New System.Drawing.Size(75, 23)
        Me.btn_groupStopSearch.TabIndex = 39
        Me.btn_groupStopSearch.Text = "ايقاف"
        '
        'btn_groupStartSearch
        '
        Me.btn_groupStartSearch.Location = New System.Drawing.Point(474, 11)
        Me.btn_groupStartSearch.Name = "btn_groupStartSearch"
        Me.btn_groupStartSearch.Size = New System.Drawing.Size(75, 23)
        Me.btn_groupStartSearch.TabIndex = 38
        Me.btn_groupStartSearch.Text = "بحث"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(384, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "حدود النتائج"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "كلمه دلاليه : "
        '
        'txt_keyword
        '
        Me.txt_keyword.Location = New System.Drawing.Point(9, 16)
        Me.txt_keyword.MenuManager = Me.RibbonControl1
        Me.txt_keyword.Name = "txt_keyword"
        Me.txt_keyword.Size = New System.Drawing.Size(213, 20)
        Me.txt_keyword.TabIndex = 28
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.TabControl4)
        Me.XtraTabPage4.Controls.Add(Me.Label11)
        Me.XtraTabPage4.Controls.Add(Me.txt_target)
        Me.XtraTabPage4.Controls.Add(Me.Button5)
        Me.XtraTabPage4.Controls.Add(Me.Button13)
        Me.XtraTabPage4.Controls.Add(Me.Panel4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1269, 442)
        Me.XtraTabPage4.Text = "Target"
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage1)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Location = New System.Drawing.Point(830, 18)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(419, 416)
        Me.TabControl4.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SimpleButton5)
        Me.TabPage1.Controls.Add(Me.ListView6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(411, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "القروبات"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton5.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(405, 31)
        Me.SimpleButton5.TabIndex = 26
        Me.SimpleButton5.Text = "تصدير الي ملف"
        '
        'ListView6
        '
        Me.ListView6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView6.CheckBoxes = True
        Me.ListView6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31})
        Me.ListView6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView6.FullRowSelect = True
        Me.ListView6.GridLines = True
        Me.ListView6.HideSelection = False
        Me.ListView6.Location = New System.Drawing.Point(3, 34)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(405, 353)
        Me.ListView6.TabIndex = 25
        Me.ListView6.UseCompatibleStateImageBehavior = False
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Select"
        Me.ColumnHeader29.Width = 52
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Name"
        Me.ColumnHeader30.Width = 229
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "ID"
        Me.ColumnHeader31.Width = 172
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.ListView7)
        Me.TabPage11.Controls.Add(Me.SimpleButton4)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(411, 390)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "الاصدقاء"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'ListView7
        '
        Me.ListView7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView7.CheckBoxes = True
        Me.ListView7.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader34})
        Me.ListView7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView7.FullRowSelect = True
        Me.ListView7.GridLines = True
        Me.ListView7.HideSelection = False
        Me.ListView7.Location = New System.Drawing.Point(3, 34)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(405, 353)
        Me.ListView7.TabIndex = 28
        Me.ListView7.UseCompatibleStateImageBehavior = False
        Me.ListView7.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "Select"
        Me.ColumnHeader32.Width = 52
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Name"
        Me.ColumnHeader33.Width = 229
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "ID"
        Me.ColumnHeader34.Width = 172
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton4.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(405, 31)
        Me.SimpleButton4.TabIndex = 0
        Me.SimpleButton4.Text = "تصدير الي ملف"
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.ListView8)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(411, 390)
        Me.TabPage12.TabIndex = 2
        Me.TabPage12.Text = "الصفحات"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'ListView8
        '
        Me.ListView8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView8.CheckBoxes = True
        Me.ListView8.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37})
        Me.ListView8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView8.FullRowSelect = True
        Me.ListView8.GridLines = True
        Me.ListView8.HideSelection = False
        Me.ListView8.Location = New System.Drawing.Point(0, 0)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(411, 390)
        Me.ListView8.TabIndex = 29
        Me.ListView8.UseCompatibleStateImageBehavior = False
        Me.ListView8.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Select"
        Me.ColumnHeader35.Width = 52
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "Name"
        Me.ColumnHeader36.Width = 229
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "ID"
        Me.ColumnHeader37.Width = 172
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "ID Or Username"
        '
        'txt_target
        '
        Me.txt_target.Location = New System.Drawing.Point(118, 32)
        Me.txt_target.MenuManager = Me.RibbonControl1
        Me.txt_target.Name = "txt_target"
        Me.txt_target.Size = New System.Drawing.Size(264, 20)
        Me.txt_target.TabIndex = 41
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(212, 69)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "بحث"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(387, 29)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 39
        Me.Button13.Text = "نسخ الاي دي"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblname)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Location = New System.Drawing.Point(17, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 165)
        Me.Panel4.TabIndex = 26
        '
        'lblname
        '
        Me.lblname.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblname.Location = New System.Drawing.Point(0, 146)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(296, 19)
        Me.lblname.TabIndex = 1
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(129, 120)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.SimpleButton7)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1269, 442)
        Me.XtraTabPage5.Text = "Messages"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton7.Location = New System.Drawing.Point(300, 117)
        Me.SimpleButton7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(561, 206)
        Me.SimpleButton7.TabIndex = 63
        Me.SimpleButton7.Text = "FB Message Sender"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1134, 580)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(129, 23)
        Me.SimpleButton1.TabIndex = 44
        Me.SimpleButton1.Text = "مسح مربع الاحداث"
        '
        'Txt_Log
        '
        Me.Txt_Log.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Txt_Log.ForeColor = System.Drawing.Color.Lime
        Me.Txt_Log.Location = New System.Drawing.Point(0, 612)
        Me.Txt_Log.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Log.Name = "Txt_Log"
        Me.Txt_Log.Size = New System.Drawing.Size(1271, 100)
        Me.Txt_Log.TabIndex = 22
        Me.Txt_Log.Text = ""
        '
        'SFD_Accounts
        '
        Me.SFD_Accounts.FileName = Nothing
        Me.SFD_Accounts.Filter = "FDat Files|*.Fdat"
        Me.SFD_Accounts.RestoreDirectory = True
        Me.SFD_Accounts.Title = "Choose The Location Of IDAT File"
        '
        'OFD_Accounts
        '
        Me.OFD_Accounts.FileName = Nothing
        Me.OFD_Accounts.Filter = "FDat Files|*.Fdat"
        Me.OFD_Accounts.RestoreDirectory = True
        Me.OFD_Accounts.Title = "Choose The Location Of IDAT File"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.ItemLinks.Add(Me.Btn_Export)
        Me.PopupMenu2.ItemLinks.Add(Me.Btn_Import)
        Me.PopupMenu2.ItemLinks.Add(Me.Btn_Remove)
        Me.PopupMenu2.Name = "PopupMenu2"
        Me.PopupMenu2.Ribbon = Me.RibbonControl1
        '
        'frm_FacebookApplication
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1271, 712)
        Me.Controls.Add(Me.Txt_Log)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_FacebookApplication"
        Me.Ribbon = Me.RibbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facebook Manager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.Grid_Control_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.pnl_link.ResumeLayout(False)
        Me.pnl_link.PerformLayout()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_post.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_posttogroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_posttomywall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_posttopages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_posttofriends.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.Goup_maxResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_keyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        CType(Me.txt_target.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RD_text As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents IDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RD_link As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Currentusername As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ListView_currentLogginUser_Groups As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ListView_currentLogginUser_friends As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents ListView_currentLogginUser_Pages As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_post As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Ck_posttogroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ck_posttomywall As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ck_posttopages As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ck_posttofriends As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_keyword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_groupStartSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_groupStartScrap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_groupStopSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_groupStartjoin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents ListView7 As ListView
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents ColumnHeader33 As ColumnHeader
    Friend WithEvents ColumnHeader34 As ColumnHeader
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents ListView8 As ListView
    Friend WithEvents ColumnHeader35 As ColumnHeader
    Friend WithEvents ColumnHeader36 As ColumnHeader
    Friend WithEvents ColumnHeader37 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_target As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Txt_Log As RichTextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListView_currentLogginUser_searchResult As ListView
    Friend WithEvents Goup_maxResults As NumericUpDown
    Friend WithEvents pnl_link As Panel
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_Control_Accounts As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Accounts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Username As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Password As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessToken As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents SFD_Accounts As DevExpress.XtraEditors.XtraSaveFileDialog
    Friend WithEvents OFD_Accounts As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents Btn_Import As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Export As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Cookies As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
