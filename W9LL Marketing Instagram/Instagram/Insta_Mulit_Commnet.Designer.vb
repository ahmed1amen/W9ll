<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Insta_Mulit_Commnet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insta_Mulit_Commnet))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.Combo_Accounts = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Btn_randall = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Grid_Control_Comments = New DevExpress.XtraGrid.GridControl()
        Me.Grid_View_Comments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Comment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.accUserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Opn_filedialog = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Btn_OpenCommentFile = New DevExpress.XtraEditors.SimpleButton()
        Me.SidePanel1 = New DevExpress.XtraEditors.SidePanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_startCommenting = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.num2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.num1 = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Control_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_View_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel1.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarEditItem1, Me.Btn_randall})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Combo_Accounts})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(844, 54)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'BarEditItem1
        '
        Me.BarEditItem1.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarEditItem1.Caption = "Account"
        Me.BarEditItem1.Edit = Me.Combo_Accounts
        Me.BarEditItem1.EditWidth = 170
        Me.BarEditItem1.Id = 6
        Me.BarEditItem1.ImageOptions.Image = CType(resources.GetObject("BarEditItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'Combo_Accounts
        '
        Me.Combo_Accounts.AutoHeight = False
        Me.Combo_Accounts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Combo_Accounts.Name = "Combo_Accounts"
        Me.Combo_Accounts.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Btn_randall
        '
        Me.Btn_randall.Caption = "                            Random All"
        Me.Btn_randall.Id = 1
        Me.Btn_randall.ImageOptions.Image = CType(resources.GetObject("Btn_randall.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_randall.ItemAppearance.Disabled.Options.UseTextOptions = True
        Me.Btn_randall.ItemAppearance.Disabled.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.Btn_randall.Name = "Btn_randall"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Grid_Control_Comments
        '
        Me.Grid_Control_Comments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Control_Comments.Location = New System.Drawing.Point(0, 1)
        Me.Grid_Control_Comments.MainView = Me.Grid_View_Comments
        Me.Grid_Control_Comments.Name = "Grid_Control_Comments"
        Me.Grid_Control_Comments.Size = New System.Drawing.Size(844, 583)
        Me.Grid_Control_Comments.TabIndex = 60
        Me.Grid_Control_Comments.UseEmbeddedNavigator = True
        Me.Grid_Control_Comments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_View_Comments})
        '
        'Grid_View_Comments
        '
        Me.Grid_View_Comments.ActiveFilterEnabled = False
        Me.Grid_View_Comments.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.Grid_View_Comments.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Comments.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_View_Comments.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Comments.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Grid_View_Comments.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_View_Comments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Comment, Me.accUserName, Me.Status})
        Me.Grid_View_Comments.GridControl = Me.Grid_Control_Comments
        Me.Grid_View_Comments.Name = "Grid_View_Comments"
        Me.Grid_View_Comments.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Comments.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.Grid_View_Comments.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_View_Comments.OptionsBehavior.AutoExpandAllGroups = True
        Me.Grid_View_Comments.OptionsBehavior.KeepFocusedRowOnUpdate = False
        Me.Grid_View_Comments.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.Grid_View_Comments.OptionsBehavior.SmartVertScrollBar = False
        Me.Grid_View_Comments.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard
        Me.Grid_View_Comments.OptionsCustomization.AllowColumnMoving = False
        Me.Grid_View_Comments.OptionsCustomization.AllowColumnResizing = False
        Me.Grid_View_Comments.OptionsCustomization.AllowFilter = False
        Me.Grid_View_Comments.OptionsCustomization.AllowQuickHideColumns = False
        Me.Grid_View_Comments.OptionsCustomization.AllowSort = False
        Me.Grid_View_Comments.OptionsDetail.EnableMasterViewMode = False
        Me.Grid_View_Comments.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.Grid_View_Comments.OptionsFilter.AllowColumnMRUFilterList = False
        Me.Grid_View_Comments.OptionsFilter.AllowFilterEditor = False
        Me.Grid_View_Comments.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.Grid_View_Comments.OptionsFilter.AllowMRUFilterList = False
        Me.Grid_View_Comments.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.Grid_View_Comments.OptionsMenu.EnableGroupPanelMenu = False
        Me.Grid_View_Comments.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.Grid_View_Comments.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.Grid_View_Comments.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.Grid_View_Comments.OptionsPrint.ExpandAllGroups = False
        Me.Grid_View_Comments.OptionsPrint.PrintGroupFooter = False
        Me.Grid_View_Comments.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Grid_View_Comments.OptionsSelection.MultiSelect = True
        Me.Grid_View_Comments.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.Grid_View_Comments.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.Grid_View_Comments.OptionsView.ShowGroupPanel = False
        Me.Grid_View_Comments.OptionsView.ShowIndicator = False
        Me.Grid_View_Comments.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        Me.Grid_View_Comments.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Comment
        '
        Me.Comment.AppearanceCell.Options.UseTextOptions = True
        Me.Comment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Comment.AppearanceHeader.Options.UseTextOptions = True
        Me.Comment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Comment.Caption = "Comment"
        Me.Comment.FieldName = "Comment"
        Me.Comment.Name = "Comment"
        Me.Comment.Visible = True
        Me.Comment.VisibleIndex = 0
        Me.Comment.Width = 371
        '
        'accUserName
        '
        Me.accUserName.AppearanceHeader.Options.UseTextOptions = True
        Me.accUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.accUserName.Caption = "UserName"
        Me.accUserName.FieldName = "acc_UserName"
        Me.accUserName.Name = "accUserName"
        Me.accUserName.OptionsColumn.AllowEdit = False
        Me.accUserName.OptionsColumn.FixedWidth = True
        Me.accUserName.OptionsColumn.ReadOnly = True
        Me.accUserName.Visible = True
        Me.accUserName.VisibleIndex = 1
        Me.accUserName.Width = 121
        '
        'Status
        '
        Me.Status.AppearanceCell.Options.UseTextOptions = True
        Me.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.Options.UseTextOptions = True
        Me.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.AllowEdit = False
        Me.Status.OptionsColumn.AllowMove = False
        Me.Status.OptionsColumn.FixedWidth = True
        Me.Status.OptionsColumn.ReadOnly = True
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 2
        '
        'Opn_filedialog
        '
        Me.Opn_filedialog.FileName = Nothing
        Me.Opn_filedialog.Filter = "txt Files (*.txt)|*.txt"
        '
        'Btn_OpenCommentFile
        '
        Me.Btn_OpenCommentFile.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Btn_OpenCommentFile.Appearance.Options.UseFont = True
        Me.Btn_OpenCommentFile.ImageOptions.Image = CType(resources.GetObject("Btn_OpenCommentFile.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_OpenCommentFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_OpenCommentFile.Location = New System.Drawing.Point(243, 161)
        Me.Btn_OpenCommentFile.Name = "Btn_OpenCommentFile"
        Me.Btn_OpenCommentFile.Size = New System.Drawing.Size(218, 39)
        Me.Btn_OpenCommentFile.TabIndex = 62
        Me.Btn_OpenCommentFile.Text = "Load Comment File"
        '
        'SidePanel1
        '
        Me.SidePanel1.AllowResize = False
        Me.SidePanel1.AllowSnap = False
        Me.SidePanel1.Controls.Add(Me.Grid_Control_Comments)
        Me.SidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SidePanel1.Location = New System.Drawing.Point(0, 206)
        Me.SidePanel1.Name = "SidePanel1"
        Me.SidePanel1.Size = New System.Drawing.Size(844, 584)
        Me.SidePanel1.TabIndex = 64
        Me.SidePanel1.Text = "SidePanel1"
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(117, 76)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(385, 23)
        Me.HyperlinkLabelControl1.TabIndex = 67
        Me.HyperlinkLabelControl1.Text = "https://www.instagram.com/p/BxnZDeEpCQ-/"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl1.TabIndex = 68
        Me.LabelControl1.Text = "Current Post :"
        '
        'btn_startCommenting
        '
        Me.btn_startCommenting.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_startCommenting.Appearance.Options.UseFont = True
        Me.btn_startCommenting.Enabled = False
        Me.btn_startCommenting.ImageOptions.Image = CType(resources.GetObject("btn_startCommenting.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_startCommenting.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btn_startCommenting.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_startCommenting.Location = New System.Drawing.Point(752, 140)
        Me.btn_startCommenting.Name = "btn_startCommenting"
        Me.btn_startCommenting.Size = New System.Drawing.Size(80, 60)
        Me.btn_startCommenting.TabIndex = 70
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.BarEditItem1, True)
        Me.PopupMenu1.ItemLinks.Add(Me.Btn_randall)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 76
        Me.LabelControl3.Text = "ثانيه"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(95, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl2.TabIndex = 75
        Me.LabelControl2.Text = "الي"
        '
        'num2
        '
        Me.num2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num2.Location = New System.Drawing.Point(35, 24)
        Me.num2.Name = "num2"
        Me.num2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
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
        Me.num2.Size = New System.Drawing.Size(55, 26)
        Me.num2.TabIndex = 74
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(177, 31)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl4.TabIndex = 73
        Me.LabelControl4.Text = "فاصل زمني من"
        '
        'num1
        '
        Me.num1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num1.Location = New System.Drawing.Point(117, 24)
        Me.num1.Name = "num1"
        Me.num1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
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
        Me.num1.Size = New System.Drawing.Size(55, 26)
        Me.num1.TabIndex = 72
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.num1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.num2)
        Me.GroupControl1.Location = New System.Drawing.Point(484, 142)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(262, 59)
        Me.GroupControl1.TabIndex = 77
        Me.GroupControl1.Text = "Delay"
        '
        'Insta_Mulit_Commnet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 790)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btn_startCommenting)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.SidePanel1)
        Me.Controls.Add(Me.Btn_OpenCommentFile)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Insta_Mulit_Commnet"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "Insta_Mulit_Commnet"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Control_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_View_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel1.ResumeLayout(False)
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Grid_Control_Comments As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_View_Comments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents accUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Opn_filedialog As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents Btn_OpenCommentFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SidePanel1 As DevExpress.XtraEditors.SidePanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_startCommenting As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents Combo_Accounts As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Btn_randall As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
