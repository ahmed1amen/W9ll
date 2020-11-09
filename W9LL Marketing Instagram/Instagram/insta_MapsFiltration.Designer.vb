<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insta_MapsFiltration
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm



    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insta_MapsFiltration))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Grid_Control_Following_Report = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Following_Report = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acc_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acc_UserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileView7 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumn31 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn32 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn33 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn34 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn35 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumn36 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.btn_Import = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgWait = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btn_Export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_RemoveDup = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.XtraSaveFileDialog1 = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Control_Following_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Following_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(682, 54)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Grid_Control_Following_Report
        '
        Me.Grid_Control_Following_Report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid_Control_Following_Report.Location = New System.Drawing.Point(2, 132)
        Me.Grid_Control_Following_Report.MainView = Me.Grid_View_Following_Report
        Me.Grid_Control_Following_Report.Name = "Grid_Control_Following_Report"
        Me.Grid_Control_Following_Report.Size = New System.Drawing.Size(676, 594)
        Me.Grid_Control_Following_Report.TabIndex = 59
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
        Me.Grid_View_Following_Report.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.acc_name, Me.acc_ID, Me.acc_UserName})
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
        Me.Grid_View_Following_Report.OptionsCustomization.AllowColumnResizing = False
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
        'btn_Import
        '
        Me.btn_Import.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Import.Appearance.Options.UseFont = True
        Me.btn_Import.ImageOptions.Image = CType(resources.GetObject("btn_Import.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Import.Location = New System.Drawing.Point(528, 21)
        Me.btn_Import.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Import.Name = "btn_Import"
        Me.btn_Import.Size = New System.Drawing.Size(139, 43)
        Me.btn_Import.TabIndex = 63
        Me.btn_Import.Text = "اضافه ملف"
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = Nothing
        Me.XtraOpenFileDialog1.Filter = "dbxi files (*.dbxi)|*.dbxi"
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.RestoreDirectory = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 64
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
        Me.ProgWait.Location = New System.Drawing.Point(0, 732)
        Me.ProgWait.Name = "ProgWait"
        Me.ProgWait.RingAnimationDiameter = 10
        Me.ProgWait.ShowCaption = False
        Me.ProgWait.ShowDescription = False
        Me.ProgWait.Size = New System.Drawing.Size(682, 12)
        Me.ProgWait.TabIndex = 69
        Me.ProgWait.Visible = False
        Me.ProgWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'btn_Export
        '
        Me.btn_Export.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Export.Appearance.Options.UseFont = True
        Me.btn_Export.ImageOptions.Image = CType(resources.GetObject("btn_Export.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Export.Location = New System.Drawing.Point(9, 21)
        Me.btn_Export.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(139, 43)
        Me.btn_Export.TabIndex = 71
        Me.btn_Export.Text = "تصدير"
        '
        'btn_RemoveDup
        '
        Me.btn_RemoveDup.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_RemoveDup.Appearance.Options.UseFont = True
        Me.btn_RemoveDup.ImageOptions.SvgImage = CType(resources.GetObject("btn_RemoveDup.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_RemoveDup.Location = New System.Drawing.Point(257, 21)
        Me.btn_RemoveDup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_RemoveDup.Name = "btn_RemoveDup"
        Me.btn_RemoveDup.Size = New System.Drawing.Size(139, 43)
        Me.btn_RemoveDup.TabIndex = 73
        Me.btn_RemoveDup.Text = "حذف المكرر"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btn_RemoveDup)
        Me.GroupControl1.Controls.Add(Me.btn_Export)
        Me.GroupControl1.Controls.Add(Me.btn_Import)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 54)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(674, 72)
        Me.GroupControl1.TabIndex = 75
        Me.GroupControl1.Text = "التحكم"
        '
        'XtraSaveFileDialog1
        '
        Me.XtraSaveFileDialog1.FileName = Nothing
        Me.XtraSaveFileDialog1.Filter = "dbxi files (*.dbxi)|*.dbxi"
        Me.XtraSaveFileDialog1.RestoreDirectory = True
        '
        'insta_MapsFiltration
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(682, 744)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ProgWait)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid_Control_Following_Report)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "insta_MapsFiltration"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maps Filtration"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Control_Following_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Following_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgWait As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents btn_Import As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TileViewColumn36 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn35 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn34 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn33 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn32 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumn31 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileView7 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents Grid_Control_Following_Report As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Following_Report As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acc_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acc_UserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btn_Export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_RemoveDup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraSaveFileDialog1 As DevExpress.XtraEditors.XtraSaveFileDialog
End Class
