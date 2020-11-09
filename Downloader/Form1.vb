Public Class Form1
    Private Const DIR_MESSAGE As String = "Directory to download"
    Private WithEvents _Downloader As WebFileDownloader
    Dim Speed1 As Integer = 0
    Dim Speed2 As Integer = 0
    Dim Hrs As Integer
    Dim Min As Integer
    Dim Sec As Integer
    Dim TimeLeft As Integer = 0

    Private Sub TxtDownloadTo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDownloadTo.GotFocus
        If TxtDownloadTo.Text = DIR_MESSAGE Then TxtDownloadTo.Text = String.Empty
    End Sub
    Private Sub TxtDownloadTo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDownloadTo.LostFocus
        If TxtDownloadTo.Text = String.Empty Then TxtDownloadTo.Text = DIR_MESSAGE
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

        For Each param As String In My.Application.CommandLineArgs
            Console.WriteLine(param)
        Next param

    End Sub

    Private Sub BtnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownload.Click
        If Not IO.Directory.Exists(TxtDownloadTo.Text) Then
            MsgBox("'" & TxtDownloadTo.Text & "' Directory not found", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, Title:="Error")
            Return
        End If
        Try
            _Downloader = New WebFileDownloader
            _Downloader.DownloadFileWithProgress(TxtUrl.Text, TxtDownloadTo.Text.TrimEnd("\"c) & GetFileNameFromURL(TxtUrl.Text))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function GetFileNameFromURL(ByVal URL As String) As String
        If URL.IndexOf("/"c) = -1 Then Return String.Empty
        Return "\" & URL.Substring(URL.LastIndexOf("/"c) + 1)
    End Function

    Private Sub BtnGetFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetFolder.Click
        If FolderBrowse.ShowDialog(Me) <> DialogResult.Cancel Then
            TxtDownloadTo.Text = FolderBrowse.SelectedPath
        End If
    End Sub

    Private Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles _Downloader.FileDownloadSizeObtained
        DownloadProgress.Value = 0
        DownloadProgress.Maximum = Convert.ToInt32(iFileSize)
    End Sub

    Private Sub _Downloader_FileDownloadComplete() Handles _Downloader.FileDownloadComplete
        DownloadProgress.Value = DownloadProgress.Maximum
        MessageBox.Show("Downloaded Complete")
    End Sub

    Private Sub _Downloader_FileDownloadFailed(ByVal ex As System.Exception) Handles _Downloader.FileDownloadFailed
        MessageBox.Show("An error has occured during download: " & ex.Message)
    End Sub

    Private Sub _Downloader_AmountDownloadedChanged(ByVal iNewProgress As Long) Handles _Downloader.AmountDownloadedChanged
        DownloadProgress.Value = Convert.ToInt32(iNewProgress)
        LabelProgress.Text = WebFileDownloader.FormatFileSize(iNewProgress) & " of " & WebFileDownloader.FormatFileSize(DownloadProgress.Maximum) & " downloaded"
        Application.DoEvents()
    End Sub

    Private Sub FrmDownload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelProgress.Text = String.Empty
        TxtDownloadTo.Text = DIR_MESSAGE
        Show()
        BtnGetFolder.Focus()
    End Sub

    Private Sub TimerDownloadSpeed_Tick(sender As Object, e As EventArgs) Handles TimerDownloadSpeed.Tick
        If Math.Round((Speed1), 2) - Math.Round((Speed2), 2) <= 1023 Then
            Speed1 = Math.Round((DownloadProgress.Value / 1024), 2)
            LabelSpeed.Text = Math.Round((Speed1), 2) - Math.Round((Speed2), 2) & " KB\s"
            Try
                TimeLeft = Math.Round((Math.Round(DownloadProgress.Maximum / 1024) - Math.Round(DownloadProgress.Value / 1024)) / (Math.Round(Speed1) - Math.Round(Speed2)))
                Sec = TimeLeft Mod 60
                Min = ((TimeLeft - Sec) / 60) Mod 60
                Hrs = ((TimeLeft - (Sec + (Min * 60))) / 3600) Mod 60
                LabelTime.Text = Format(Hrs, "00") & "h " & Format(Min, "00") & "m " & Format(Sec, "00") & "s"
            Catch ex As Exception
                LabelTime.Text = "∞"
            End Try
            Speed2 = Math.Round((DownloadProgress.Value / 1024), 2)
        End If
    End Sub

    Private Sub TimerSpeed_Tick(sender As Object, e As EventArgs) Handles TimerSpeed.Tick
        If DownloadProgress.Value >= 1 Then
            TimerDownloadSpeed.Start()
        Else
            TimerDownloadSpeed.Stop()
            LabelSpeed.Text = ""
            LabelTime.Text = ""
        End If
    End Sub
End Class
