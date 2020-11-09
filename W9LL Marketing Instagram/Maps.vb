Imports System.Globalization
Imports System.Net
Imports DevExpress.XtraEditors
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports InstagramApiSharp.API
Imports InstagramApiSharp.API.Builder
Imports InstagramApiSharp.Classes
Imports InstagramApiSharp.Classes.Models
Imports InstagramApiSharp.Logger

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class Maps
    Dim anotherInstance As IInstaApi
    Dim latt, longtt As Double
    Public proxyAdd As String
    Public Loggeduser As String
    Public DT_Location As DataTable = New DataTable
    Private MAPS_LOG_PATH As String = Application.StartupPath & "\mapslog"
    Private marker As GMapMarker

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


            WebRequest.DefaultWebProxy = p
        Else
            '   WebRequest.DefaultWebProxy = New WebProxy()
        End If



        ' Now create a client handler which uses that proxy
        Dim httpClientHandler = New Http.HttpClientHandler()
        '  httpClientHandler.Proxy = proxy





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
    Private Async Sub Maps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = True
        GMapControl1.DragButton = MouseButtons.Left

        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.Position = New PointLatLng(24.7255541, 46.5416539)
        GMapControl1.MinZoom = 0
        GMapControl1.MaxZoom = 24
        GMapControl1.Zoom = 9
        GMapControl1.MarkersEnabled = True
        GMapControl1.DragButton = MouseButtons.Left
        GMapControl1.IgnoreMarkerOnMouseWheel = True
        GMapControl1.ShowCenter = True

        DT_Location.Columns.Add("Address")
        DT_Location.Columns.Add("Name")
        DT_Location.Columns.Add("Longttt")
        DT_Location.Columns.Add("Lattt")
        DT_Location.Columns.Add("ExternalID")




        Grid_Control_Location.DataSource = DT_Location


        Dim IsAccountLoaded As Boolean = Await initilizeAccount()


        If IsAccountLoaded = True Then



        Else
            Beep()
            Me.Dispose()
            Me.Close()

        End If

        SimpleButton2.Enabled = True
        SimpleButton1.Enabled = True
    End Sub
    Private Async Sub SimpleButton1_ClickAsync(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim x As New insta_LocationScrapper
        x.proxyAdd = proxyAdd
        x.Loggeduser = Loggeduser
        x.maxload = NumericUpDown1.Value
        x.Externalid = Grid_View_Location.GetRowCellValue(Grid_View_Location.GetSelectedRows().First, "ExternalID").ToString()

        x.lbl_Login_Account.Text = "Login Account : " + Loggeduser

        Dim tar As String = Grid_View_Location.GetRowCellValue(Grid_View_Location.GetSelectedRows().First, "Address").ToString() + "," + Grid_View_Location.GetRowCellValue(Grid_View_Location.GetSelectedRows().First, "Name").ToString()

        x.lbl_Target_Account.Text = "Target Location : " + tar


        x.Show()






    End Sub
    Dim MapsLog As String
    Private Async Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False
        Dim result = Await anotherInstance.LocationProcessor.SearchLocationAsync(latt, longtt, "")
        DT_Location.Rows.Clear()
        GMapControl1.Overlays.Clear()
        If My.Computer.FileSystem.FileExists(MAPS_LOG_PATH) Then
            MapsLog = My.Computer.FileSystem.ReadAllText(MAPS_LOG_PATH)
        Else
            MapsLog = ""
        End If


        Dim points As New List(Of PointLatLng)
        For Each loc As InstaLocationShort In result.Value

            DT_Location.Rows.Add(loc.Address, loc.Name, loc.Lng, loc.Lat, loc.ExternalId)


            points.Add(New PointLatLng(loc.Lat, loc.Lng))
            Dim Markers As GMapOverlay = New GMapOverlay(loc.Name)
            Dim polyOverlay As GMapOverlay = New GMapOverlay("polygons")
            If MapsLog.Contains(loc.ExternalId) Then
                marker = New GMarkerGoogle(New PointLatLng(loc.Lat, loc.Lng), GMarkerGoogleType.green_dot)
            Else
                marker = New GMarkerGoogle(New PointLatLng(loc.Lat, loc.Lng), GMarkerGoogleType.yellow_dot)
            End If

            marker.ToolTipText = loc.Name
            marker.ToolTip.Fill = Brushes.Black
            marker.ToolTip.Foreground = Brushes.White
            marker.ToolTip.Stroke = Pens.Black
            marker.ToolTip.TextPadding = New Size(20, 20)




            Dim polygon As GMapPolygon = New GMapPolygon(points, "polygons")

            polygon.Fill = New SolidBrush(Color.FromArgb(1, Color.Transparent))
            polygon.Stroke = New Pen(Color.Red, 1)
            polyOverlay.Polygons.Add(polygon)
            GMapControl1.Overlays.Add(polyOverlay)

            Markers.Markers.Add(marker)

            GMapControl1.Overlays.Add(Markers)
            GMapControl1.Overlays.Add(polyOverlay)




        Next
        GMapControl1.Refresh()


        If DT_Location.Rows.Count = 0 Then

            SimpleButton2.Enabled = True
        Else

            SimpleButton2.Enabled = True
            SimpleButton1.Enabled = True


        End If


    End Sub

    Private Sub Maps_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Oemplus Then

            GMapControl1.Zoom += 1
        End If


        If e.KeyCode = Keys.OemMinus Then

            GMapControl1.Zoom -= 1
        End If

    End Sub


    Private Sub Grid_Control_Location_DragDrop(sender As Object, e As DragEventArgs) Handles Grid_Control_Location.DragDrop

    End Sub

    Private Sub Grid_Control_Location_Click(sender As Object, e As EventArgs) Handles Grid_Control_Location.Click

    End Sub

    Private Sub GMapControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseMove
        latt = GMapControl1.Position.Lat
        longtt = GMapControl1.Position.Lng
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If XtraMessageBox.Show("هل انت متأكد من حذف سجل البحث", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(MAPS_LOG_PATH)
            MapsLog = ""
        End If
    End Sub

    Private Sub Grid_View_Location_RowStyle(sender As Object, e As RowCellCustomDrawEventArgs) Handles Grid_View_Location.CustomDrawCell
        Dim gv As GridView = sender

        If MapsLog.Contains(gv.GetRowCellValue(e.RowHandle, "ExternalID").ToString) Then

            e.Appearance.BackColor = Color.Green

        End If

    End Sub
End Class