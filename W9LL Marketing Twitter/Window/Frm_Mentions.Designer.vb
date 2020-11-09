<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mentions
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mentions))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Grid_Control_Mentions = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Mentions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Username = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.num2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.num1 = New DevExpress.XtraEditors.SpinEdit()
        Me.Proxy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cookies = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Control_Mentions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Mentions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
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
        Me.RibbonControl1.Size = New System.Drawing.Size(697, 54)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(545, 112)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(128, 45)
        Me.SimpleButton5.TabIndex = 57
        Me.SimpleButton5.Text = "بدأ المنشن"
        '
        'Grid_Control_Mentions
        '
        Me.Grid_Control_Mentions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid_Control_Mentions.Location = New System.Drawing.Point(0, 163)
        Me.Grid_Control_Mentions.MainView = Me.Grid_View_Mentions
        Me.Grid_Control_Mentions.Name = "Grid_Control_Mentions"
        Me.Grid_Control_Mentions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Grid_Control_Mentions.Size = New System.Drawing.Size(697, 481)
        Me.Grid_Control_Mentions.TabIndex = 64
        Me.Grid_Control_Mentions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_View_Mentions, Me.TileView1})
        '
        'Grid_View_Mentions
        '
        Me.Grid_View_Mentions.ActiveFilterEnabled = False
        Me.Grid_View_Mentions.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.Grid_View_Mentions.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Mentions.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_View_Mentions.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Mentions.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Grid_View_Mentions.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Mentions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Username, Me.Status, Me.Proxy, Me.Cookies})
        Me.Grid_View_Mentions.GridControl = Me.Grid_Control_Mentions
        Me.Grid_View_Mentions.Name = "Grid_View_Mentions"
        Me.Grid_View_Mentions.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Mentions.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsBehavior.AutoExpandAllGroups = True
        Me.Grid_View_Mentions.OptionsBehavior.AutoSelectAllInEditor = False
        Me.Grid_View_Mentions.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.Grid_View_Mentions.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        Me.Grid_View_Mentions.OptionsCustomization.AllowColumnMoving = False
        Me.Grid_View_Mentions.OptionsCustomization.AllowColumnResizing = False
        Me.Grid_View_Mentions.OptionsCustomization.AllowFilter = False
        Me.Grid_View_Mentions.OptionsCustomization.AllowQuickHideColumns = False
        Me.Grid_View_Mentions.OptionsCustomization.AllowSort = False
        Me.Grid_View_Mentions.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsFilter.AllowColumnMRUFilterList = False
        Me.Grid_View_Mentions.OptionsFilter.AllowFilterEditor = False
        Me.Grid_View_Mentions.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.Grid_View_Mentions.OptionsFilter.AllowMRUFilterList = False
        Me.Grid_View_Mentions.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
        Me.Grid_View_Mentions.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.Grid_View_Mentions.OptionsMenu.EnableGroupPanelMenu = False
        Me.Grid_View_Mentions.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.Grid_View_Mentions.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.Grid_View_Mentions.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.Grid_View_Mentions.OptionsPrint.ExpandAllGroups = False
        Me.Grid_View_Mentions.OptionsPrint.PrintGroupFooter = False
        Me.Grid_View_Mentions.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Grid_View_Mentions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.Grid_View_Mentions.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Mentions.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Mentions.OptionsView.ShowGroupPanel = False
        Me.Grid_View_Mentions.OptionsView.ShowIndicator = False
        '
        'Username
        '
        Me.Username.AppearanceHeader.Options.UseTextOptions = True
        Me.Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Username.Caption = "الحساب"
        Me.Username.FieldName = "Username"
        Me.Username.Name = "Username"
        Me.Username.OptionsColumn.AllowEdit = False
        Me.Username.OptionsColumn.ReadOnly = True
        Me.Username.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Username.Visible = True
        Me.Username.VisibleIndex = 0
        Me.Username.Width = 503
        '
        'Status
        '
        Me.Status.AppearanceCell.Options.UseTextOptions = True
        Me.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.Options.UseTextOptions = True
        Me.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.Caption = "الحاله"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.AllowEdit = False
        Me.Status.OptionsEditForm.Caption = "الحالة"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 1
        Me.Status.Width = 192
        '
        'TileView1
        '
        Me.TileView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.TileView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.TileView1.GridControl = Me.Grid_Control_Mentions
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Username"
        Me.GridColumn1.FieldName = "Username"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Password"
        Me.GridColumn2.FieldName = "Password"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Status"
        Me.GridColumn3.FieldName = "Status"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Proxy"
        Me.GridColumn4.FieldName = "Proxy"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Cookies"
        Me.GridColumn5.FieldName = "Cookies"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "GroupName"
        Me.GridColumn6.FieldName = "GroupName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(148, 121)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 25)
        Me.LabelControl3.TabIndex = 78
        Me.LabelControl3.Text = "ثانيه"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(248, 121)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 25)
        Me.LabelControl2.TabIndex = 77
        Me.LabelControl2.Text = "الي"
        '
        'num2
        '
        Me.num2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num2.Location = New System.Drawing.Point(187, 119)
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
        Me.num2.TabIndex = 76
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(341, 121)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 25)
        Me.LabelControl1.TabIndex = 75
        Me.LabelControl1.Text = "فاصل زمني من"
        '
        'num1
        '
        Me.num1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num1.Location = New System.Drawing.Point(281, 119)
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
        Me.num1.TabIndex = 74
        '
        'Proxy
        '
        Me.Proxy.Caption = "Proxy"
        Me.Proxy.FieldName = "Proxy"
        Me.Proxy.Name = "Proxy"
        '
        'Cookies
        '
        Me.Cookies.Caption = "Cookies"
        Me.Cookies.FieldName = "Cookies"
        Me.Cookies.Name = "Cookies"
        '
        'Frm_Mentions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 644)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Grid_Control_Mentions)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.RibbonControl1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Mentions"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Mentions"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Control_Mentions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Mentions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_Control_Mentions As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Mentions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Username As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Proxy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cookies As DevExpress.XtraGrid.Columns.GridColumn
End Class
