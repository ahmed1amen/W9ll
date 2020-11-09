<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Activation
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
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.btn_validate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgWait = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "emptySpaceItem1"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 71)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(802, 321)
        Me.EmptySpaceItem2.Text = "emptySpaceItem1"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "2UBATN36LCTVDCWM3UXV7O7S04Q5T3"
        Me.TextEdit2.Location = New System.Drawing.Point(12, 35)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextEdit2.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit2.Size = New System.Drawing.Size(567, 38)
        Me.TextEdit2.TabIndex = 6
        '
        'btn_validate
        '
        Me.btn_validate.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.btn_validate.Appearance.Options.UseFont = True
        Me.btn_validate.Location = New System.Drawing.Point(426, 78)
        Me.btn_validate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_validate.Name = "btn_validate"
        Me.btn_validate.Size = New System.Drawing.Size(152, 45)
        Me.btn_validate.TabIndex = 5
        Me.btn_validate.Text = "Validate "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 21)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Product Key "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 100)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 19)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.w9ll.co"
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
        Me.ProgWait.Location = New System.Drawing.Point(0, 127)
        Me.ProgWait.Name = "ProgWait"
        Me.ProgWait.RingAnimationDiameter = 10
        Me.ProgWait.ShowCaption = False
        Me.ProgWait.ShowDescription = False
        Me.ProgWait.Size = New System.Drawing.Size(587, 12)
        Me.ProgWait.TabIndex = 60
        Me.ProgWait.Visible = False
        Me.ProgWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'frm_Activation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(587, 139)
        Me.Controls.Add(Me.ProgWait)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.btn_validate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_Activation"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licence Manager"
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_validate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LinkLabel1 As Windows.Forms.LinkLabel
    Friend WithEvents ProgWait As DevExpress.XtraWaitForm.ProgressPanel
End Class
