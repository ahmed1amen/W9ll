<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGetFolder = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtDownloadTo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.DownloadProgress = New System.Windows.Forms.ProgressBar()
        Me.BtnDownload = New DevExpress.XtraEditors.SimpleButton()
        Me.FolderBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.TimerDownloadSpeed = New System.Windows.Forms.Timer()
        Me.TimerSpeed = New System.Windows.Forms.Timer()
        Me.TxtUrl = New DevExpress.XtraEditors.TextEdit()
        Me.LabelTime = New System.Windows.Forms.Label()
        CType(Me.TxtDownloadTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Location = New System.Drawing.Point(416, 123)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(72, 24)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        '
        'BtnGetFolder
        '
        Me.BtnGetFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGetFolder.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetFolder.Appearance.Options.UseFont = True
        Me.BtnGetFolder.Location = New System.Drawing.Point(456, 36)
        Me.BtnGetFolder.Name = "BtnGetFolder"
        Me.BtnGetFolder.Size = New System.Drawing.Size(32, 20)
        Me.BtnGetFolder.TabIndex = 21
        Me.BtnGetFolder.Text = "..."
        '
        'TxtDownloadTo
        '
        Me.TxtDownloadTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDownloadTo.Location = New System.Drawing.Point(8, 36)
        Me.TxtDownloadTo.Name = "TxtDownloadTo"
        Me.TxtDownloadTo.Size = New System.Drawing.Size(448, 20)
        Me.TxtDownloadTo.TabIndex = 19
        '
        'LabelProgress
        '
        Me.LabelProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelProgress.Location = New System.Drawing.Point(8, 99)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(272, 16)
        Me.LabelProgress.TabIndex = 24
        Me.LabelProgress.Text = "#Progress"
        '
        'DownloadProgress
        '
        Me.DownloadProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DownloadProgress.Location = New System.Drawing.Point(8, 68)
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.Size = New System.Drawing.Size(480, 16)
        Me.DownloadProgress.TabIndex = 20
        '
        'BtnDownload
        '
        Me.BtnDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDownload.Location = New System.Drawing.Point(416, 95)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(72, 24)
        Me.BtnDownload.TabIndex = 22
        Me.BtnDownload.Text = "Download"
        '
        'LabelSpeed
        '
        Me.LabelSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelSpeed.Location = New System.Drawing.Point(8, 115)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(272, 16)
        Me.LabelSpeed.TabIndex = 25
        Me.LabelSpeed.Text = "#Speed"
        '
        'TimerDownloadSpeed
        '
        Me.TimerDownloadSpeed.Interval = 1000
        '
        'TimerSpeed
        '
        Me.TimerSpeed.Enabled = True
        Me.TimerSpeed.Interval = 1
        '
        'TxtUrl
        '
        Me.TxtUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtUrl.Location = New System.Drawing.Point(8, 10)
        Me.TxtUrl.Name = "TxtUrl"
        Me.TxtUrl.Size = New System.Drawing.Size(480, 20)
        Me.TxtUrl.TabIndex = 27
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.Location = New System.Drawing.Point(8, 131)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(272, 16)
        Me.LabelTime.TabIndex = 26
        Me.LabelTime.Text = "#Time"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(507, 158)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnGetFolder)
        Me.Controls.Add(Me.TxtDownloadTo)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.DownloadProgress)
        Me.Controls.Add(Me.BtnDownload)
        Me.Controls.Add(Me.LabelSpeed)
        Me.Controls.Add(Me.TxtUrl)
        Me.Controls.Add(Me.LabelTime)
        Me.Name = "Form1"
        Me.Text = "Updater"
        CType(Me.TxtDownloadTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGetFolder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtDownloadTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelProgress As Label
    Friend WithEvents DownloadProgress As ProgressBar
    Friend WithEvents BtnDownload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowse As FolderBrowserDialog
    Friend WithEvents LabelSpeed As Label
    Friend WithEvents TimerDownloadSpeed As Timer
    Friend WithEvents TimerSpeed As Timer
    Friend WithEvents TxtUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelTime As Label
End Class
