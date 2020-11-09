<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Frm_Add_Account
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Account))
        Me.txt_Username = New DevExpress.XtraEditors.TextEdit()
        Me.Btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_password = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_group = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Txt_Proxy = New DevExpress.XtraEditors.TextEdit()
        Me.txt_port = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Proxy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_port.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(135, 51)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Properties.Appearance.Options.UseFont = True
        Me.txt_Username.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_Username.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_Username.Properties.NullText = "Type Your Username"
        Me.txt_Username.Size = New System.Drawing.Size(194, 22)
        Me.txt_Username.TabIndex = 0
        '
        'Btn_Add
        '
        Me.Btn_Add.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Appearance.Options.UseFont = True
        Me.Btn_Add.ImageOptions.Image = CType(resources.GetObject("Btn_Add.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Add.Location = New System.Drawing.Point(179, 163)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(92, 34)
        Me.Btn_Add.TabIndex = 5
        Me.Btn_Add.Text = "ADD"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(135, 79)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_password.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_password.Properties.NullText = "Type Your Passwrod"
        Me.txt_password.Size = New System.Drawing.Size(194, 22)
        Me.txt_password.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 82)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Passwrod"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(11, 110)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Proxy"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 54)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Username"
        '
        'txt_group
        '
        Me.txt_group.Location = New System.Drawing.Point(135, 135)
        Me.txt_group.Name = "txt_group"
        Me.txt_group.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_group.Properties.Appearance.Options.UseFont = True
        Me.txt_group.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_group.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_group.Properties.NullText = "Type Group Name"
        Me.txt_group.Size = New System.Drawing.Size(194, 22)
        Me.txt_group.TabIndex = 4
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(2, -1)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(58, 55)
        Me.PictureEdit1.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(119, 13)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 23)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Add Panel"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(11, 138)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Group Name"
        '
        'Txt_Proxy
        '
        Me.Txt_Proxy.EditValue = "ProxyIP"
        Me.Txt_Proxy.Location = New System.Drawing.Point(135, 107)
        Me.Txt_Proxy.Name = "Txt_Proxy"
        Me.Txt_Proxy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proxy.Properties.Appearance.Options.UseFont = True
        Me.Txt_Proxy.Properties.Appearance.Options.UseTextOptions = True
        Me.Txt_Proxy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Txt_Proxy.Properties.Mask.EditMask = "([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9" &
    "]|2[0-4][0-9]|25[0-5])){3}"
        Me.Txt_Proxy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.Txt_Proxy.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(46)
        Me.Txt_Proxy.Properties.NullText = "ProxyIP"
        Me.Txt_Proxy.Size = New System.Drawing.Size(136, 22)
        Me.Txt_Proxy.TabIndex = 2
        '
        'txt_port
        '
        Me.txt_port.Location = New System.Drawing.Point(277, 107)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_port.Properties.Appearance.Options.UseFont = True
        Me.txt_port.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_port.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_port.Properties.Mask.EditMask = "([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])"
        Me.txt_port.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txt_port.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txt_port.Properties.NullText = "Port"
        Me.txt_port.Size = New System.Drawing.Size(60, 22)
        Me.txt_port.TabIndex = 3
        '
        'Frm_Add_Account
        '
        Me.AcceptButton = Me.Btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(341, 210)
        Me.Controls.Add(Me.txt_port)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.Txt_Proxy)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_group)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HtmlText = "Add Single Account"
        Me.Name = "Frm_Add_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Proxy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_port.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_group As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Txt_Proxy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_port As DevExpress.XtraEditors.TextEdit

#End Region
End Class
