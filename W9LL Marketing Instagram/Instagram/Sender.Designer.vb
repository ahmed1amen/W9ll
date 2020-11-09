<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Sender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Sender))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Btn_Rundom = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Grid_Control_Following_Report = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Following_Report = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acc_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acc_UserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acc_messagestate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileView7 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn31 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn32 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn33 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn34 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn35 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn36 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.Txt_Messsge = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_Send = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgWait = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btn_loadaccounts = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.num2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.num1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.num_row2 = New DevExpress.XtraEditors.SpinEdit()
        Me.num_row1 = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Control_Following_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Following_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Messsge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_row2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_row1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.Btn_Rundom})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(975, 54)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'Btn_Rundom
        '
        Me.Btn_Rundom.Caption = "Random All"
        Me.Btn_Rundom.Id = 1
        Me.Btn_Rundom.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Rundom.Name = "Btn_Rundom"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Grid_Control_Following_Report
        '
        Me.Grid_Control_Following_Report.Dock = System.Windows.Forms.DockStyle.Left
        Me.Grid_Control_Following_Report.Location = New System.Drawing.Point(0, 54)
        Me.Grid_Control_Following_Report.MainView = Me.Grid_View_Following_Report
        Me.Grid_Control_Following_Report.Name = "Grid_Control_Following_Report"
        Me.Grid_Control_Following_Report.Size = New System.Drawing.Size(611, 554)
        Me.Grid_Control_Following_Report.TabIndex = 58
        Me.Grid_Control_Following_Report.UseEmbeddedNavigator = True
        Me.Grid_Control_Following_Report.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_View_Following_Report, Me.TileView7})
        '
        'Grid_View_Following_Report
        '
        Me.Grid_View_Following_Report.ActiveFilterEnabled = False
        Me.Grid_View_Following_Report.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.Grid_View_Following_Report.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Following_Report.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_View_Following_Report.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Following_Report.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Grid_View_Following_Report.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Following_Report.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.acc_name, Me.acc_ID, Me.acc_UserName, Me.acc_messagestate, Me.AccountUsed})
        Me.Grid_View_Following_Report.GridControl = Me.Grid_Control_Following_Report
        Me.Grid_View_Following_Report.Name = "Grid_View_Following_Report"
        Me.Grid_View_Following_Report.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.Grid_View_Following_Report.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Following_Report.OptionsBehavior.AutoExpandAllGroups = True
        Me.Grid_View_Following_Report.OptionsBehavior.KeepFocusedRowOnUpdate = False
        Me.Grid_View_Following_Report.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.Grid_View_Following_Report.OptionsBehavior.SmartVertScrollBar = False
        Me.Grid_View_Following_Report.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        Me.Grid_View_Following_Report.OptionsCustomization.AllowColumnMoving = False
        Me.Grid_View_Following_Report.OptionsCustomization.AllowFilter = False
        Me.Grid_View_Following_Report.OptionsCustomization.AllowQuickHideColumns = False
        Me.Grid_View_Following_Report.OptionsCustomization.AllowSort = False
        Me.Grid_View_Following_Report.OptionsDetail.EnableMasterViewMode = False
        Me.Grid_View_Following_Report.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsFilter.AllowColumnMRUFilterList = False
        Me.Grid_View_Following_Report.OptionsFilter.AllowFilterEditor = False
        Me.Grid_View_Following_Report.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.Grid_View_Following_Report.OptionsFilter.AllowMRUFilterList = False
        Me.Grid_View_Following_Report.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.Grid_View_Following_Report.OptionsMenu.EnableGroupPanelMenu = False
        Me.Grid_View_Following_Report.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.Grid_View_Following_Report.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.Grid_View_Following_Report.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.Grid_View_Following_Report.OptionsPrint.ExpandAllGroups = False
        Me.Grid_View_Following_Report.OptionsPrint.PrintGroupFooter = False
        Me.Grid_View_Following_Report.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Grid_View_Following_Report.OptionsSelection.MultiSelect = True
        Me.Grid_View_Following_Report.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.Grid_View_Following_Report.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Following_Report.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Following_Report.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.Grid_View_Following_Report.OptionsView.ShowGroupPanel = False
        Me.Grid_View_Following_Report.OptionsView.ShowIndicator = False
        Me.Grid_View_Following_Report.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        Me.Grid_View_Following_Report.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'acc_name
        '
        Me.acc_name.AppearanceCell.Options.UseTextOptions = True
        Me.acc_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_name.AppearanceHeader.Options.UseTextOptions = True
        Me.acc_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_name.Caption = "Name"
        Me.acc_name.FieldName = "acc_name"
        Me.acc_name.Name = "acc_name"
        Me.acc_name.OptionsColumn.AllowEdit = False
        Me.acc_name.OptionsColumn.ReadOnly = True
        Me.acc_name.Visible = True
        Me.acc_name.VisibleIndex = 0
        '
        'acc_ID
        '
        Me.acc_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.acc_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_ID.Caption = "ID"
        Me.acc_ID.FieldName = "acc_ID"
        Me.acc_ID.Name = "acc_ID"
        Me.acc_ID.OptionsColumn.AllowEdit = False
        Me.acc_ID.OptionsColumn.ReadOnly = True
        Me.acc_ID.Visible = True
        Me.acc_ID.VisibleIndex = 1
        '
        'acc_UserName
        '
        Me.acc_UserName.AppearanceHeader.Options.UseTextOptions = True
        Me.acc_UserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_UserName.Caption = "UserName"
        Me.acc_UserName.FieldName = "acc_UserName"
        Me.acc_UserName.Name = "acc_UserName"
        Me.acc_UserName.OptionsColumn.AllowEdit = False
        Me.acc_UserName.OptionsColumn.ReadOnly = True
        Me.acc_UserName.Visible = True
        Me.acc_UserName.VisibleIndex = 2
        '
        'acc_messagestate
        '
        Me.acc_messagestate.AppearanceCell.Options.UseTextOptions = True
        Me.acc_messagestate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_messagestate.AppearanceHeader.Options.UseTextOptions = True
        Me.acc_messagestate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acc_messagestate.Caption = "State"
        Me.acc_messagestate.FieldName = "acc_messagestate"
        Me.acc_messagestate.Name = "acc_messagestate"
        Me.acc_messagestate.OptionsColumn.AllowEdit = False
        Me.acc_messagestate.OptionsColumn.ReadOnly = True
        Me.acc_messagestate.Visible = True
        Me.acc_messagestate.VisibleIndex = 3
        '
        'AccountUsed
        '
        Me.AccountUsed.AppearanceCell.Options.UseTextOptions = True
        Me.AccountUsed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccountUsed.AppearanceHeader.Options.UseTextOptions = True
        Me.AccountUsed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccountUsed.Caption = "Account Used"
        Me.AccountUsed.FieldName = "AccountUsed"
        Me.AccountUsed.Name = "AccountUsed"
        Me.AccountUsed.Visible = True
        Me.AccountUsed.VisibleIndex = 4
        '
        'TileView7
        '
        Me.TileView7.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.TileView7.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumn31, Me.TileViewColumn32, Me.TileViewColumn33, Me.TileViewColumn34, Me.TileViewColumn35, Me.TileViewColumn36})
        Me.TileView7.GridControl = Me.Grid_Control_Following_Report
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
        'Txt_Messsge
        '
        Me.Txt_Messsge.EditValue = "Hello From W9ll Markting - Instagram"
        Me.Txt_Messsge.Location = New System.Drawing.Point(617, 70)
        Me.Txt_Messsge.MenuManager = Me.RibbonControl1
        Me.Txt_Messsge.Name = "Txt_Messsge"
        Me.Txt_Messsge.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Messsge.Properties.Appearance.Options.UseFont = True
        Me.Txt_Messsge.Properties.Appearance.Options.UseTextOptions = True
        Me.Txt_Messsge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Txt_Messsge.Size = New System.Drawing.Size(357, 176)
        Me.Txt_Messsge.TabIndex = 59
        '
        'btn_Send
        '
        Me.btn_Send.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Send.Appearance.Options.UseFont = True
        Me.btn_Send.Enabled = False
        Me.btn_Send.ImageOptions.Image = CType(resources.GetObject("btn_Send.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Send.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btn_Send.Location = New System.Drawing.Point(664, 327)
        Me.btn_Send.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(246, 73)
        Me.btn_Send.TabIndex = 63
        Me.btn_Send.Text = "Start Sending"
        '
        'ProgWait
        '
        Me.ProgWait.AnimationAcceleration = 15.0!
        Me.ProgWait.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgWait.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgWait.Appearance.Options.UseBackColor = True
        Me.ProgWait.Appearance.Options.UseForeColor = True
        Me.ProgWait.BarAnimationElementThickness = 2
        Me.ProgWait.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgWait.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgWait.FrameCount = 5000
        Me.ProgWait.FrameInterval = 4000
        Me.ProgWait.Location = New System.Drawing.Point(611, 596)
        Me.ProgWait.Name = "ProgWait"
        Me.ProgWait.RingAnimationDiameter = 10
        Me.ProgWait.ShowCaption = False
        Me.ProgWait.ShowDescription = False
        Me.ProgWait.Size = New System.Drawing.Size(364, 12)
        Me.ProgWait.TabIndex = 65
        Me.ProgWait.Visible = False
        Me.ProgWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'btn_loadaccounts
        '
        Me.btn_loadaccounts.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_loadaccounts.Appearance.Options.UseFont = True
        Me.btn_loadaccounts.ImageOptions.Image = CType(resources.GetObject("btn_loadaccounts.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_loadaccounts.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btn_loadaccounts.Location = New System.Drawing.Point(664, 250)
        Me.btn_loadaccounts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_loadaccounts.Name = "btn_loadaccounts"
        Me.btn_loadaccounts.Size = New System.Drawing.Size(246, 73)
        Me.btn_loadaccounts.TabIndex = 67
        Me.btn_loadaccounts.Text = "Load Accounts"
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = Nothing
        Me.XtraOpenFileDialog1.Filter = "dbxi files (*.dbxi)|*.dbxi"
        Me.XtraOpenFileDialog1.RestoreDirectory = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(641, 419)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 25)
        Me.LabelControl3.TabIndex = 73
        Me.LabelControl3.Text = "ثانيه"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(741, 419)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 25)
        Me.LabelControl2.TabIndex = 72
        Me.LabelControl2.Text = "الي"
        '
        'num2
        '
        Me.num2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num2.Location = New System.Drawing.Point(680, 417)
        Me.num2.Name = "num2"
        Me.num2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.num2.Properties.Appearance.Options.UseFont = True
        Me.num2.Properties.Appearance.Options.UseTextOptions = True
        Me.num2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.num2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.num2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num2.Properties.IsFloatValue = False
        Me.num2.Properties.Mask.EditMask = "N00"
        Me.num2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.num2.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.num2.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num2.Size = New System.Drawing.Size(55, 32)
        Me.num2.TabIndex = 71
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(834, 419)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 25)
        Me.LabelControl1.TabIndex = 70
        Me.LabelControl1.Text = "فاصل زمني من"
        '
        'num1
        '
        Me.num1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num1.Location = New System.Drawing.Point(774, 417)
        Me.num1.Name = "num1"
        Me.num1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.num1.Properties.Appearance.Options.UseFont = True
        Me.num1.Properties.Appearance.Options.UseTextOptions = True
        Me.num1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.num1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.num1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num1.Properties.IsFloatValue = False
        Me.num1.Properties.Mask.EditMask = "N00"
        Me.num1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.num1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.num1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num1.Size = New System.Drawing.Size(55, 32)
        Me.num1.TabIndex = 69
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(152, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(27, 25)
        Me.LabelControl5.TabIndex = 78
        Me.LabelControl5.Text = "الي"
        '
        'num_row2
        '
        Me.num_row2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num_row2.Location = New System.Drawing.Point(88, 33)
        Me.num_row2.Name = "num_row2"
        Me.num_row2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.num_row2.Properties.Appearance.Options.UseFont = True
        Me.num_row2.Properties.Appearance.Options.UseTextOptions = True
        Me.num_row2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.num_row2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.num_row2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num_row2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num_row2.Properties.IsFloatValue = False
        Me.num_row2.Properties.Mask.EditMask = "N00"
        Me.num_row2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.num_row2.Properties.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.num_row2.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num_row2.Size = New System.Drawing.Size(55, 32)
        Me.num_row2.TabIndex = 77
        '
        'num_row1
        '
        Me.num_row1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.num_row1.Location = New System.Drawing.Point(188, 33)
        Me.num_row1.Name = "num_row1"
        Me.num_row1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.num_row1.Properties.Appearance.Options.UseFont = True
        Me.num_row1.Properties.Appearance.Options.UseTextOptions = True
        Me.num_row1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.num_row1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.num_row1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num_row1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.num_row1.Properties.IsFloatValue = False
        Me.num_row1.Properties.Mask.EditMask = "N00"
        Me.num_row1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.num_row1.Properties.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num_row1.Size = New System.Drawing.Size(55, 32)
        Me.num_row1.TabIndex = 75
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.num_row2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.num_row1)
        Me.GroupControl1.Location = New System.Drawing.Point(617, 471)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(337, 95)
        Me.GroupControl1.TabIndex = 80
        Me.GroupControl1.Text = "بدأ الارسال من"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.Btn_Rundom)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl1
        '
        'frm_Sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(975, 608)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.btn_loadaccounts)
        Me.Controls.Add(Me.ProgWait)
        Me.Controls.Add(Me.btn_Send)
        Me.Controls.Add(Me.Txt_Messsge)
        Me.Controls.Add(Me.Grid_Control_Following_Report)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Sender"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DM Sender"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Control_Following_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Following_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Messsge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_row2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_row1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Grid_Control_Following_Report As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Following_Report As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TileView7 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumn31 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn32 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn33 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn34 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn35 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn36 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents Txt_Messsge As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_Send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acc_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acc_UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acc_messagestate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgWait As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btn_loadaccounts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num_row2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents num_row1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents AccountUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Btn_Rundom As DevExpress.XtraBars.BarButtonItem
End Class
