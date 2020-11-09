Imports System.Net
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports InstagramApiSharp
Imports InstagramApiSharp.API
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Imports InstagramApiSharp.Classes.Models
Imports InstagramApiSharp.Logger

Public Class insta_LocationScrapper
    Public scrapFollowers As Boolean = True
    Public Loggeduser As String
    Public Tatgetuser As String
    Public maxload As Integer
    Public proxyAdd As String
    Public Externalid As String
    Private List As New InstaMediaList()

    Public DT_users As DataTable = New DataTable
    Private LatestMaxId As String = ""
    Dim anotherInstance As IInstaApi


    Public Shared Sub RemoveDuplicatesFromDataTable(ByRef table As DataTable, ByVal keyColumns As List(Of String))

        Dim uniquenessDict As New Dictionary(Of String, String)(table.Rows.Count)

        Dim stringBuilder As StringBuilder = Nothing

        Dim rowIndex As Integer = 0

        Dim row As DataRow

        Dim rows As DataRowCollection = table.Rows

        Do While rowIndex < rows.Count

            row = rows(rowIndex)

            stringBuilder = New StringBuilder()

            For Each colname As String In keyColumns

                stringBuilder.Append((DirectCast(row(colname), String)))

            Next colname

            If uniquenessDict.ContainsKey(stringBuilder.ToString()) Then

                rows.Remove(row)


            Else

                uniquenessDict.Add(stringBuilder.ToString(), String.Empty)

                rowIndex += 1

            End If

        Loop

    End Sub


    Private Sub SelectRows(ByVal view As GridView, ByVal startRow As Integer, ByVal endRow As Integer)

        If startRow > -1 AndAlso endRow > -1 Then

            view.BeginSelection()

            view.ClearSelection()

            view.SelectRange(startRow, endRow)

            view.EndSelection()

        End If

    End Sub
    Private Function GetRowAt(ByVal view As GridView, ByVal x As Integer, ByVal y As Integer) As Integer
        Return view.CalcHitInfo(New Point(x, y)).RowHandle
    End Function
    Private StartRowHandle As Integer = -1
    Private CurrentRowHandle As Integer = -1
    Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
    End Sub
    Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim newRowHandle As Integer = GetRowAt(TryCast(sender, GridView), e.X, e.Y)
        If CurrentRowHandle <> newRowHandle Then
            CurrentRowHandle = newRowHandle
            SelectRows(TryCast(sender, GridView), StartRowHandle, CurrentRowHandle)
        End If
    End Sub
    Private Sub gridView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        StartRowHandle = -1
        CurrentRowHandle = -1
    End Sub
    Private Async Function GetFeedsByLocation(ByVal maxloadf As Integer) As Threading.Tasks.Task(Of Boolean)


        Dim locationStories = Await anotherInstance.LocationProcessor.GetRecentLocationFeedsAsync(Long.Parse(Externalid), PaginationParameters.MaxPagesToLoad(1).StartFromMaxId(LatestMaxId))

        'For Each media As InstaMedia In locationStories.Value.Medias

        '    media.User.UserName

        'Next






        LatestMaxId = locationStories.Value.NextMaxId
        If locationStories.Succeeded Then
            List.AddRange(locationStories.Value.Medias)
            Label1.Text = "Count : " & List.Count
            If List.Count >= maxload Then
                Return True
            Else
                Await GetFeedsByLocation(maxload)
            End If
        Else
            Return False
        End If
        Return True
    End Function
    Async Function initilizeAccount() As Threading.Tasks.Task(Of Boolean)
        Dim datastring As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\instAcc\" & Loggeduser & ".dat", System.Text.Encoding.UTF8)
        Dim proxy = New Net.WebProxy()
        If proxyAdd <> Nothing Then
            Dim str1 As String() = proxyAdd.Split(":")
            Dim ipandportNumber, ProxyUserName, ProxyPassword As String

            ipandportNumber = str1(0) & ":" & str1(1)


            Dim p As WebProxy = New WebProxy(ipandportNumber, True)
            If str1.Length > 2 Then
                ProxyUserName = str1(2)
                ProxyPassword = str1(3)

                p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)
            End If


           ' WebRequest.DefaultWebProxy = p
        Else
            ' WebRequest.DefaultWebProxy = New WebProxy()
        End If



        ' Now create a client handler which uses that proxy
        Dim httpClientHandler = New Http.HttpClientHandler()
        'httpClientHandler.Proxy = proxy





        Dim Logger As New DebugLogger(LogLevel.All, True, Application.StartupPath & "\log.txt")
        anotherInstance = InstaApiBuilder.CreateBuilder().SetUser(UserSessionData.Empty).UseLogger(Logger).SetRequestDelay(RequestDelay.FromSeconds(2, 3)).UseHttpClientHandler(httpClientHandler).Build()
        anotherInstance.LoadStateDataFromString(datastring)
        Dim anotherResult = Await anotherInstance.GetCurrentUserAsync()

        If Not anotherResult.Succeeded Then
            XtraMessageBox.Show(String.Format("[{0}] >> [{1}] error : {2} ", Now, Loggeduser, anotherResult.Info?.Message), "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        Return True



    End Function
    Dim firstLocation
    Private Async Sub insta_scrapperfast_LoadAsync(sender As Object, e As EventArgs) Handles Me.Load
        DT_users.Columns.Add("acc_name")
        DT_users.Columns.Add("acc_ID")
        DT_users.Columns.Add("acc_UserName")
        Grid_Control_Following_Report.DataSource = DT_users

        AddHandler Grid_View_Following_Report.MouseUp, AddressOf gridView1_MouseUp
        AddHandler Grid_View_Following_Report.MouseMove, AddressOf gridView1_MouseMove
        AddHandler Grid_View_Following_Report.MouseDown, AddressOf gridView1_MouseDown

        ProgWait.Visible = True
        Dim IsAccountLoaded As Boolean = Await initilizeAccount()


        If IsAccountLoaded = True Then


            Try




                Await GetFeedsByLocation(maxload)
                ProgWait.Visible = False

                For Each item In List
                    DT_users.Rows.Add(item.User.FullName, item.User.Pk, item.User.UserName)
                Next



                'RemoveDuplicatesFromDataTable(DT_users, [{"as"}])

                btn_Export.Enabled = True
            Catch ex As Exception

            End Try

        Else

            Beep()
            Me.Dispose()
            Me.Close()

        End If







    End Sub
    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        If XtraSaveFileDialog1.ShowDialog = DialogResult.OK Then


            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\mapslog", Externalid + vbNewLine, True)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("[{0}] >> [{1}] error : {2} ", Now, Loggeduser, ex.Message), "Maps Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            btn_Export.Enabled = False
            Dim xa As New Threading.Thread(AddressOf ExportDataGrid)
            xa.IsBackground = True
            xa.Start()
        End If
    End Sub
    Sub ExportDataGrid()
        Try
            For Each x As DataRow In DT_users.Rows

                Dim LineX As String = x("acc_name").ToString & "*_*" & x("acc_ID").ToString & "*_*" & x("acc_UserName").ToString
                Try
                    My.Computer.FileSystem.WriteAllText(XtraSaveFileDialog1.FileName, LineX & vbNewLine, True, System.Text.Encoding.UTF8)
                Catch ex As Exception

                    XtraMessageBox.Show(ex.Message, "لا يجب لمس الملف حتي تنتهي عمليه الحفظ!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            btn_Export.Invoke(New Action(Sub() btn_Export.Enabled = True))
            XtraMessageBox.Show("تم الحفظ بنجاح", "تم ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try


    End Sub

End Class