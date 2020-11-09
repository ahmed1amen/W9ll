<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InstaVerify
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InstaVerify))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectMethodGroupBox = New DevExpress.XtraEditors.GroupControl()
        Me.SendCodeButton = New DevExpress.XtraEditors.SimpleButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.RadioVerifyWithEmail = New System.Windows.Forms.RadioButton()
        Me.RadioVerifyWithPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.VerifyCodeGroupBox = New DevExpress.XtraEditors.GroupControl()
        Me.ResendButton = New DevExpress.XtraEditors.SimpleButton()
        Me.VerifyButton = New DevExpress.XtraEditors.SimpleButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtVerifyCode = New System.Windows.Forms.TextBox()
        Me.LblForSmsEmail = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtTwoFactorCode = New System.Windows.Forms.TextBox()
        Me.TwoFactorButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TwoFactorGroupBox = New DevExpress.XtraEditors.GroupControl()
        Me.SubmitPhoneChallengeGroup = New DevExpress.XtraEditors.GroupControl()
        Me.label6 = New System.Windows.Forms.Label()
        Me.SubmitPhoneChallengeButton = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSubmitPhoneForChallenge = New System.Windows.Forms.TextBox()
        CType(Me.SelectMethodGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectMethodGroupBox.SuspendLayout()
        CType(Me.VerifyCodeGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VerifyCodeGroupBox.SuspendLayout()
        CType(Me.TwoFactorGroupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TwoFactorGroupBox.SuspendLayout()
        CType(Me.SubmitPhoneChallengeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubmitPhoneChallengeGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SelectMethodGroupBox
        '
        Me.SelectMethodGroupBox.Controls.Add(Me.SendCodeButton)
        Me.SelectMethodGroupBox.Controls.Add(Me.label3)
        Me.SelectMethodGroupBox.Controls.Add(Me.RadioVerifyWithEmail)
        Me.SelectMethodGroupBox.Controls.Add(Me.RadioVerifyWithPhoneNumber)
        resources.ApplyResources(Me.SelectMethodGroupBox, "SelectMethodGroupBox")
        Me.SelectMethodGroupBox.Name = "SelectMethodGroupBox"
        '
        'SendCodeButton
        '
        resources.ApplyResources(Me.SendCodeButton, "SendCodeButton")
        Me.SendCodeButton.Name = "SendCodeButton"
        '
        'label3
        '
        resources.ApplyResources(Me.label3, "label3")
        Me.label3.Name = "label3"
        '
        'RadioVerifyWithEmail
        '
        resources.ApplyResources(Me.RadioVerifyWithEmail, "RadioVerifyWithEmail")
        Me.RadioVerifyWithEmail.Name = "RadioVerifyWithEmail"
        Me.RadioVerifyWithEmail.TabStop = True
        '
        'RadioVerifyWithPhoneNumber
        '
        resources.ApplyResources(Me.RadioVerifyWithPhoneNumber, "RadioVerifyWithPhoneNumber")
        Me.RadioVerifyWithPhoneNumber.Name = "RadioVerifyWithPhoneNumber"
        Me.RadioVerifyWithPhoneNumber.TabStop = True
        '
        'VerifyCodeGroupBox
        '
        Me.VerifyCodeGroupBox.Controls.Add(Me.ResendButton)
        Me.VerifyCodeGroupBox.Controls.Add(Me.VerifyButton)
        Me.VerifyCodeGroupBox.Controls.Add(Me.label4)
        Me.VerifyCodeGroupBox.Controls.Add(Me.txtVerifyCode)
        Me.VerifyCodeGroupBox.Controls.Add(Me.LblForSmsEmail)
        resources.ApplyResources(Me.VerifyCodeGroupBox, "VerifyCodeGroupBox")
        Me.VerifyCodeGroupBox.Name = "VerifyCodeGroupBox"
        '
        'ResendButton
        '
        resources.ApplyResources(Me.ResendButton, "ResendButton")
        Me.ResendButton.Name = "ResendButton"
        '
        'VerifyButton
        '
        resources.ApplyResources(Me.VerifyButton, "VerifyButton")
        Me.VerifyButton.Name = "VerifyButton"
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'txtVerifyCode
        '
        resources.ApplyResources(Me.txtVerifyCode, "txtVerifyCode")
        Me.txtVerifyCode.Name = "txtVerifyCode"
        '
        'LblForSmsEmail
        '
        resources.ApplyResources(Me.LblForSmsEmail, "LblForSmsEmail")
        Me.LblForSmsEmail.Name = "LblForSmsEmail"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'label5
        '
        resources.ApplyResources(Me.label5, "label5")
        Me.label5.Name = "label5"
        '
        'txtTwoFactorCode
        '
        resources.ApplyResources(Me.txtTwoFactorCode, "txtTwoFactorCode")
        Me.txtTwoFactorCode.Name = "txtTwoFactorCode"
        '
        'TwoFactorButton
        '
        resources.ApplyResources(Me.TwoFactorButton, "TwoFactorButton")
        Me.TwoFactorButton.Name = "TwoFactorButton"
        '
        'TwoFactorGroupBox
        '
        Me.TwoFactorGroupBox.Controls.Add(Me.TwoFactorButton)
        Me.TwoFactorGroupBox.Controls.Add(Me.txtTwoFactorCode)
        Me.TwoFactorGroupBox.Controls.Add(Me.label5)
        resources.ApplyResources(Me.TwoFactorGroupBox, "TwoFactorGroupBox")
        Me.TwoFactorGroupBox.Name = "TwoFactorGroupBox"
        '
        'SubmitPhoneChallengeGroup
        '
        Me.SubmitPhoneChallengeGroup.Controls.Add(Me.SubmitPhoneChallengeButton)
        Me.SubmitPhoneChallengeGroup.Controls.Add(Me.txtSubmitPhoneForChallenge)
        Me.SubmitPhoneChallengeGroup.Controls.Add(Me.label6)
        resources.ApplyResources(Me.SubmitPhoneChallengeGroup, "SubmitPhoneChallengeGroup")
        Me.SubmitPhoneChallengeGroup.Name = "SubmitPhoneChallengeGroup"
        '
        'label6
        '
        resources.ApplyResources(Me.label6, "label6")
        Me.label6.Name = "label6"
        '
        'SubmitPhoneChallengeButton
        '
        resources.ApplyResources(Me.SubmitPhoneChallengeButton, "SubmitPhoneChallengeButton")
        Me.SubmitPhoneChallengeButton.Name = "SubmitPhoneChallengeButton"
        '
        'txtSubmitPhoneForChallenge
        '
        resources.ApplyResources(Me.txtSubmitPhoneForChallenge, "txtSubmitPhoneForChallenge")
        Me.txtSubmitPhoneForChallenge.Name = "txtSubmitPhoneForChallenge"
        '
        'Frm_InstaVerify
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.TwoFactorGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubmitPhoneChallengeGroup)
        Me.Controls.Add(Me.SelectMethodGroupBox)
        Me.Controls.Add(Me.VerifyCodeGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_InstaVerify"
        CType(Me.SelectMethodGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectMethodGroupBox.ResumeLayout(False)
        Me.SelectMethodGroupBox.PerformLayout()
        CType(Me.VerifyCodeGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VerifyCodeGroupBox.ResumeLayout(False)
        Me.VerifyCodeGroupBox.PerformLayout()
        CType(Me.TwoFactorGroupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TwoFactorGroupBox.ResumeLayout(False)
        Me.TwoFactorGroupBox.PerformLayout()
        CType(Me.SubmitPhoneChallengeGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubmitPhoneChallengeGroup.ResumeLayout(False)
        Me.SubmitPhoneChallengeGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label1 As Label
    Public WithEvents SelectMethodGroupBox As DevExpress.XtraEditors.GroupControl
    Public WithEvents VerifyCodeGroupBox As DevExpress.XtraEditors.GroupControl
    Public WithEvents SendCodeButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents label3 As Label
    Public WithEvents RadioVerifyWithEmail As RadioButton
    Public WithEvents RadioVerifyWithPhoneNumber As RadioButton
    Public WithEvents ResendButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents VerifyButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents label4 As Label
    Public WithEvents txtVerifyCode As TextBox
    Public WithEvents LblForSmsEmail As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents label5 As Label
    Public WithEvents txtTwoFactorCode As TextBox
    Public WithEvents TwoFactorButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents TwoFactorGroupBox As DevExpress.XtraEditors.GroupControl
    Public WithEvents SubmitPhoneChallengeGroup As DevExpress.XtraEditors.GroupControl
    Public WithEvents SubmitPhoneChallengeButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtSubmitPhoneForChallenge As TextBox
    Public WithEvents label6 As Label
End Class
