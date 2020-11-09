<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maps
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maps))
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Grid_Control_Location = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Location = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Namea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Longttt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Lattt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExternalID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileView7 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn31 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn32 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn33 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn34 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn35 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn36 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Grid_Control_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GMapControl1
        '
        Me.GMapControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = True
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.GrayScaleMode = False
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(433, -4)
        Me.GMapControl1.MarkersEnabled = True
        Me.GMapControl1.MaxZoom = 2
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomEnabled = True
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = False
        Me.GMapControl1.PolygonsEnabled = True
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = True
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapControl1.ShowTileGridLines = False
        Me.GMapControl1.Size = New System.Drawing.Size(619, 676)
        Me.GMapControl1.TabIndex = 0
        Me.GMapControl1.Zoom = 0R
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(150, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(102, 41)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&OK"
        '
        'Grid_Control_Location
        '
        Me.Grid_Control_Location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid_Control_Location.Location = New System.Drawing.Point(6, 0)
        Me.Grid_Control_Location.MainView = Me.Grid_View_Location
        Me.Grid_Control_Location.Name = "Grid_Control_Location"
        Me.Grid_Control_Location.Size = New System.Drawing.Size(421, 525)
        Me.Grid_Control_Location.TabIndex = 60
        Me.Grid_Control_Location.UseEmbeddedNavigator = True
        Me.Grid_Control_Location.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_View_Location, Me.TileView7})
        '
        'Grid_View_Location
        '
        Me.Grid_View_Location.ActiveFilterEnabled = False
        Me.Grid_View_Location.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.Grid_View_Location.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Location.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Grid_View_Location.Appearance.HeaderPanel.Options.UseFont = True
        Me.Grid_View_Location.Appearance.Row.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_View_Location.Appearance.Row.Options.UseFont = True
        Me.Grid_View_Location.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_View_Location.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Location.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Grid_View_Location.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Location.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Address, Me.Namea, Me.Longttt, Me.Lattt, Me.ExternalID})
        Me.Grid_View_Location.GridControl = Me.Grid_Control_Location
        Me.Grid_View_Location.Name = "Grid_View_Location"
        Me.Grid_View_Location.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Location.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.Grid_View_Location.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Location.OptionsBehavior.AutoExpandAllGroups = True
        Me.Grid_View_Location.OptionsBehavior.KeepFocusedRowOnUpdate = False
        Me.Grid_View_Location.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.Grid_View_Location.OptionsBehavior.SmartVertScrollBar = False
        Me.Grid_View_Location.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        Me.Grid_View_Location.OptionsCustomization.AllowColumnMoving = False
        Me.Grid_View_Location.OptionsCustomization.AllowFilter = False
        Me.Grid_View_Location.OptionsCustomization.AllowQuickHideColumns = False
        Me.Grid_View_Location.OptionsCustomization.AllowSort = False
        Me.Grid_View_Location.OptionsDetail.EnableMasterViewMode = False
        Me.Grid_View_Location.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Location.OptionsFilter.AllowColumnMRUFilterList = False
        Me.Grid_View_Location.OptionsFilter.AllowFilterEditor = False
        Me.Grid_View_Location.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.Grid_View_Location.OptionsFilter.AllowMRUFilterList = False
        Me.Grid_View_Location.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.Grid_View_Location.OptionsMenu.EnableGroupPanelMenu = False
        Me.Grid_View_Location.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.Grid_View_Location.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.Grid_View_Location.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.Grid_View_Location.OptionsPrint.ExpandAllGroups = False
        Me.Grid_View_Location.OptionsPrint.PrintGroupFooter = False
        Me.Grid_View_Location.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.Grid_View_Location.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.Grid_View_Location.OptionsView.ShowGroupPanel = False
        Me.Grid_View_Location.OptionsView.ShowIndicator = False
        Me.Grid_View_Location.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        Me.Grid_View_Location.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Address
        '
        Me.Address.AppearanceCell.Options.UseTextOptions = True
        Me.Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Address.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Address.AppearanceHeader.Options.UseTextOptions = True
        Me.Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Address.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Address.Caption = "Address"
        Me.Address.FieldName = "Address"
        Me.Address.Name = "Address"
        Me.Address.OptionsColumn.AllowEdit = False
        Me.Address.Visible = True
        Me.Address.VisibleIndex = 0
        '
        'Namea
        '
        Me.Namea.AppearanceCell.Options.UseTextOptions = True
        Me.Namea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Namea.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Namea.AppearanceHeader.Options.UseTextOptions = True
        Me.Namea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Namea.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Namea.Caption = "Name"
        Me.Namea.FieldName = "Name"
        Me.Namea.Name = "Namea"
        Me.Namea.OptionsColumn.AllowEdit = False
        Me.Namea.Visible = True
        Me.Namea.VisibleIndex = 1
        '
        'Longttt
        '
        Me.Longttt.AppearanceCell.Options.UseTextOptions = True
        Me.Longttt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Longttt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Longttt.AppearanceHeader.Options.UseTextOptions = True
        Me.Longttt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Longttt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Longttt.Caption = "Longttt"
        Me.Longttt.FieldName = "Longttt"
        Me.Longttt.Name = "Longttt"
        Me.Longttt.OptionsColumn.AllowEdit = False
        Me.Longttt.Visible = True
        Me.Longttt.VisibleIndex = 2
        '
        'Lattt
        '
        Me.Lattt.AppearanceCell.Options.UseTextOptions = True
        Me.Lattt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Lattt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Lattt.AppearanceHeader.Options.UseTextOptions = True
        Me.Lattt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Lattt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Lattt.Caption = "Lattt"
        Me.Lattt.FieldName = "Lattt"
        Me.Lattt.Name = "Lattt"
        Me.Lattt.OptionsColumn.AllowEdit = False
        Me.Lattt.Visible = True
        Me.Lattt.VisibleIndex = 3
        '
        'ExternalID
        '
        Me.ExternalID.Caption = "ExternalID"
        Me.ExternalID.FieldName = "ExternalID"
        Me.ExternalID.Name = "ExternalID"
        '
        'TileView7
        '
        Me.TileView7.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.TileView7.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn31, Me.TileViewColumn32, Me.TileViewColumn33, Me.TileViewColumn34, Me.TileViewColumn35, Me.TileViewColumn36})
        Me.TileView7.GridControl = Me.Grid_Control_Location
        Me.TileView7.Name = "TileView7"
        Me.TileView7.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        '
        'TileViewColumn31
        '
        Me.TileViewColumn31.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn31.Caption = "Username"
        Me.TileViewColumn31.FieldName = "Username"
        Me.TileViewColumn31.Name = "TileViewColumn31"
        Me.TileViewColumn31.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn31.Visible = True
        Me.TileViewColumn31.VisibleIndex = 0
        '
        'TileViewColumn32
        '
        Me.TileViewColumn32.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn32.Caption = "Password"
        Me.TileViewColumn32.FieldName = "Password"
        Me.TileViewColumn32.Name = "TileViewColumn32"
        Me.TileViewColumn32.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn32.Visible = True
        Me.TileViewColumn32.VisibleIndex = 1
        '
        'TileViewColumn33
        '
        Me.TileViewColumn33.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn33.Caption = "Status"
        Me.TileViewColumn33.FieldName = "Status"
        Me.TileViewColumn33.Name = "TileViewColumn33"
        Me.TileViewColumn33.OptionsColumn.AllowEdit = False
        Me.TileViewColumn33.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn33.Visible = True
        Me.TileViewColumn33.VisibleIndex = 2
        '
        'TileViewColumn34
        '
        Me.TileViewColumn34.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn34.Caption = "Proxy"
        Me.TileViewColumn34.FieldName = "Proxy"
        Me.TileViewColumn34.Name = "TileViewColumn34"
        Me.TileViewColumn34.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn34.Visible = True
        Me.TileViewColumn34.VisibleIndex = 3
        '
        'TileViewColumn35
        '
        Me.TileViewColumn35.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn35.Caption = "Cookies"
        Me.TileViewColumn35.FieldName = "Cookies"
        Me.TileViewColumn35.Name = "TileViewColumn35"
        Me.TileViewColumn35.OptionsColumn.AllowEdit = False
        Me.TileViewColumn35.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn35.Visible = True
        Me.TileViewColumn35.VisibleIndex = 4
        '
        'TileViewColumn36
        '
        Me.TileViewColumn36.AppearanceHeader.Options.UseTextOptions = True
        Me.TileViewColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileViewColumn36.Caption = "GroupName"
        Me.TileViewColumn36.FieldName = "GroupName"
        Me.TileViewColumn36.Name = "TileViewColumn36"
        Me.TileViewColumn36.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.TileViewColumn36.Visible = True
        Me.TileViewColumn36.VisibleIndex = 5
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(6, 32)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(102, 41)
        Me.SimpleButton2.TabIndex = 61
        Me.SimpleButton2.Text = "&Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(353, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 25)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "عدد"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown1.Location = New System.Drawing.Point(274, 39)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(73, 32)
        Me.NumericUpDown1.TabIndex = 66
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.NumericUpDown1)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 590)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(409, 81)
        Me.GroupControl1.TabIndex = 68
        Me.GroupControl1.Text = "Control"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.LinkLabel1)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Location = New System.Drawing.Point(6, 529)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(409, 66)
        Me.GroupControl2.TabIndex = 69
        Me.GroupControl2.Text = "معلومات"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(175, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(175, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(33, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "لم يتم السحب من هذا المكان"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(296, 34)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 17)
        Me.LinkLabel1.TabIndex = 68
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "حذف سجل البحث"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "تم السحب من هذا المكان مسبقا"
        '
        'Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 676)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Grid_Control_Location)
        Me.Controls.Add(Me.GMapControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maps & Loaction"
        CType(Me.Grid_Control_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_Control_Location As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Location As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TileView7 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn31 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn32 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn33 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn34 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn35 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn36 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Namea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lattt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Longttt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ExternalID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
