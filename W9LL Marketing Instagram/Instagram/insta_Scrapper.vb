Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.XtraEditors
Imports Newtonsoft.Json.Linq
Public Class insta_Scrapper
    Public Cookies_2, T_Username, urlidX, nodename, csrftoken_code, useridx As String
    Dim sCfollower As New instgram_Func
    Public NumOfScrap As Integer
    Public currentUser As String
    Public proxy As String
    Public Property NatrulUserName As String
    Public Property ProxyString As String
    Function Scrap_followers(ByVal username As String, ByVal urlid As String, Optional pagecode As String = "") As String
        Dim head As New WebHeaderCollection
        Dim url, method, Referer, postdatax, Cookies As String
        url = "https://www.instagram.com/graphql/query/?query_id=" & urlid & "&variables={" & Chr(34) & "id" & Chr(34) & ":" & Chr(34) & useridx & Chr(34) & "," & Chr(34) & "first" & Chr(34) & ":50," & Chr(34) & "after" & Chr(34) & ":" & Chr(34) & pagecode & Chr(34) & "}"
        method = "GET"
        Referer = "https://www.instagram.com/" & username & "/followers/"
        postdatax = ""
        Cookies = Cookies_2
        Return sCfollower.CreatReq(url, method, Referer, postdatax, Cookies, head, "", proxy)
    End Function

    Dim t As New Thread(AddressOf ScrapFollwers)
    Public UsedToScrap As Boolean
    Private Sub insta_Scrapper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If UsedToScrap = True Then
            ToolStripStatusLabel1.Text = "Downloading .... " & DataGridView1.Rows.Count & " of " & NumOfScrap
            t.IsBackground = True
            t.Start()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sCfollower.preventHttp = True
            Do While t.IsAlive = True
                t.Abort()
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "E_thread")
        End Try
        Dim x As New instgram_Func
        Button1.Enabled = False
        ToolStripProgressBar1.Visible = False
        ToolStripStatusLabel1.Text = "Downloaded .... " & DataGridView1.Rows.Count & " of " & NumOfScrap
        lbl_Target_Count.Text = "Target Count : " & DataGridView1.Rows.Count
        Panel2.Enabled = True
    End Sub
    Private Sub btn_selectAll_DG2_Click(sender As Object, e As EventArgs) Handles btn_selectAll_DG2.Click
        If DataGridView2.Rows.Count = 0 Then
        Else
            For Each x As DataGridViewRow In DataGridView2.Rows
                If x.Cells(0).Value = True Then
                    x.Cells(0).Value = False
                    x.Selected = False
                ElseIf x.Cells(0).Value = False Then
                    x.Cells(0).Value = True

                    x.Selected = True
                End If
            Next
            DataGridView2.Focus()
        End If
    End Sub
    Sub loadDataGrid()
        For Each x As String In IO.File.ReadAllLines(OpenFileDialog1.FileName, System.Text.Encoding.UTF8)
            Dim ss() As String = x.Split("*_*")
            If x.Contains("*_*") Then
                If x.Length > 10 Then
                    If ss(0) = "" Then
                    Else
                        DataGridView2.Invoke(New Action(Sub() DataGridView2.Rows.Add(False, ss(0), ss(2), ss(4))))
                    End If

                End If
            End If
        Next
        Panel1.Invoke(New Action(Sub() Panel1.Enabled = True))
        StatusStrip1.Invoke(New Action(Sub() ToolStripProgressBar1.Visible = False))

    End Sub
    Sub ExportDataGrid()
        For Each x As DataGridViewRow In DataGridView1.Rows
            Dim LineX As String = x.Cells(1).Value.ToString & "*_*" & x.Cells(2).Value.ToString & "*_*" & x.Cells(3).Value.ToString
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, LineX & vbNewLine, True, System.Text.Encoding.UTF8)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "لا يجب لمس الملف حتي تنتهي عمليه الحفظ!")
            End Try
        Next
        Panel1.Invoke(New Action(Sub() Panel1.Enabled = True))
        StatusStrip1.Invoke(New Action(Sub() ToolStripProgressBar1.Visible = False))
        MsgBox("تم الحفظ بنجاح", MsgBoxStyle.Information, "تم!")
    End Sub
    Private Async Sub btn_Import_DG2_Click(sender As Object, e As EventArgs) Handles btn_Import_DG2.Click
        DataGridView2.Rows.Clear()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Panel_Fol_UnFol.Enabled = False
            ToolStripProgressBar1.Visible = True
            ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
            Dim xq As New Task(AddressOf loadDataGrid)
            Me.Enabled = False

            xq.Start()
            Await xq
            Me.Enabled = True


        End If
    End Sub
    Function CheackDelay() As Boolean
        If num1.Value > num2.Value Then
            XtraMessageBox.Show("خطأ في تكوين العمليه الفاصل الزمني الرقم الاول اكبر من الثاني", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Export_DG1.Click
        Try
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                ToolStripProgressBar1.Visible = True : ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
                Panel1.Enabled = False
                Dim xa As New Thread(AddressOf ExportDataGrid)
                xa.IsBackground = True
                xa.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Err")
        End Try
    End Sub
    Private Async Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_Follow.Click
        Try
            If CheackDelay() = False Then
                Exit Sub
            End If
            btn_Follow.Enabled = False
            btn_UnFollow.Enabled = False
            num1.Enabled = False
            num2.Enabled = False

            ToolStripProgressBar1.Visible = True : ToolStripProgressBar1.Maximum = DataGridView2.Rows.Count : ToolStripProgressBar1.Style = ProgressBarStyle.Blocks : ToolStripProgressBar1.Value = 0
            For Each x As DataGridViewRow In DataGridView2.Rows

                Dim randx As New Random
                Dim delay As Integer = randx.Next(num1.Value, num2.Value) * 1000
                Await Task.Delay(delay)

                Try

                    Dim newuser As New SaveLoadState()
                    newuser.Username = NatrulUserName
                    Dim reqx As Boolean
                    reqx = Await newuser.doshowAsyncFollow(x.Cells(2).Value, "follow", ProxyString)
                    If reqx = True Then

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ER_1134 _ follow")
                    Exit For
                End Try
                ToolStripProgressBar1.Value += 1
                ToolStripStatusLabel1.Text = ToolStripProgressBar1.Value & " of " & DataGridView2.Rows.Count

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ER_1134 _ follow")
            Exit Sub
        End Try

    End Sub
    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_UnFollow.Click
        Try
            If CheackDelay() = False Then
                Exit Sub
            End If

            btn_Follow.Enabled = False
            btn_UnFollow.Enabled = False
            num1.Enabled = False
            num2.Enabled = False

            ToolStripProgressBar1.Visible = True : ToolStripProgressBar1.Maximum = DataGridView2.Rows.Count : ToolStripProgressBar1.Style = ProgressBarStyle.Blocks : ToolStripProgressBar1.Value = 0
            For Each x As DataGridViewRow In DataGridView2.Rows

                Dim randx As New Random
                Dim delay As Integer = randx.Next(num1.Value, num2.Value) * 1000
                Await Task.Delay(delay)


                Try

                    Dim newuser As New SaveLoadState()
                    newuser.Username = NatrulUserName
                    Dim reqx As Boolean
                    reqx = Await newuser.doshowAsyncFollow(x.Cells(2).Value, "unfollow", ProxyString)
                    If reqx = True Then

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ER_1134 _ unfollow")
                    Exit For
                End Try

                ToolStripProgressBar1.Value += 1
                ToolStripStatusLabel1.Text = ToolStripProgressBar1.Value + " of " + DataGridView2.Rows.Count
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ER_1134 _ follow")
            Exit Sub
        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_selectAll_DG1.Click
        If DataGridView1.Rows.Count = 0 Then
        Else
            For Each x As DataGridViewRow In DataGridView1.Rows
                If x.Cells(0).Value = True Then
                    x.Cells(0).Value = False
                    x.Selected = False
                ElseIf x.Cells(0).Value = False Then
                    x.Cells(0).Value = True
                    x.Selected = True
                End If
            Next
            DataGridView1.Focus()
        End If
    End Sub
    Async Sub ScrapFollwers()
        Try
            Dim Itratorx As Integer = 0
            Dim Formatted_Data As New List(Of String)
            Formatted_Data.Clear()
            Dim rawJson As String = Scrap_followers(T_Username, urlidX)
1:          Dim ss As String = rawJson
            Await Task.Delay(3000)
            If sCfollower.preventHttp = True Then
                Exit Sub
            End If
            Dim o As JObject = JObject.Parse(rawJson)
            Dim results As List(Of JToken) = o.Children().ToList
            Dim hasNextPage As Boolean
            Dim end_cursor As String


            StatusStrip1.Invoke(New Action(Sub() ToolStripStatusLabel1.Text = "Downloading .... " & DataGridView1.Rows.Count & " of " & NumOfScrap))

            For Each item As JProperty In o.Item("data").Item("user").Item(nodename).Item("edges").Values
                item.CreateReader()
                If item.Name = "node" And item.Value.ToString <> Nothing Then
                    For Each subitem As JObject In item
                        'Formatted_Data.Add(subitem("full_name").ToString & "||" & subitem("id").ToString & "||" & subitem("username").ToString)
                        DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows.Add(False, subitem("full_name").ToString, subitem("id").ToString, subitem("username").ToString)))
                    Next
                End If
            Next
            If DataGridView1.Rows.Count >= NumOfScrap Then
                Button1.Invoke(New Action(Sub() Button1.Enabled = False))
                StatusStrip1.Invoke(New Action(Sub() ToolStripProgressBar1.Visible = False))
                For j = DataGridView1.RowCount - 1 To 0 Step -1
                    Itratorx = j
                    If DataGridView1.Rows.Count <> NumOfScrap Then
                        DataGridView1.Invoke(New Action(Sub() DataGridView1.Rows.RemoveAt(Itratorx)))
                    End If
                Next
                lbl_Target_Count.Invoke(New Action(Sub() lbl_Target_Count.Text = "Target Count : " & DataGridView1.Rows.Count))
                StatusStrip1.Invoke(New Action(Sub() ToolStripStatusLabel1.Text = "Downloading .... " & DataGridView1.Rows.Count & " of " & NumOfScrap))
                Panel2.Invoke(New Action(Sub() Panel2.Enabled = True))
                t.Abort()
                Exit Sub
            End If
            For Each itemx As JProperty In o.Item("data").Item("user").Item(nodename).Item("page_info")
                If itemx.Name.ToString.ToLower = "has_next_page" Then
                    If itemx.Value.ToString.ToLower = "true" Then
                        hasNextPage = True
                    Else
                        hasNextPage = False
                    End If
                End If

                If hasNextPage = True Then

                    If itemx.Name.ToString.ToLower = "end_cursor" Then
                        If itemx.Value.ToString <> Nothing Then
                            end_cursor = itemx.Value.ToString
                            rawJson = Scrap_followers(T_Username, urlidX, end_cursor)
                            GoTo 1
                        End If
                    End If
                End If
            Next


            Button1.Invoke(New Action(Sub() Button1.Enabled = False))
            StatusStrip1.Invoke(New Action(Sub() ToolStripProgressBar1.Visible = False))
            StatusStrip1.Invoke(New Action(Sub() ToolStripStatusLabel1.Text = "Downloaded .... " & DataGridView1.Rows.Count & " of " & NumOfScrap))
            lbl_Target_Count.Invoke(New Action(Sub() lbl_Target_Count.Text = "Target Count : " & DataGridView1.Rows.Count))
            Panel2.Invoke(New Action(Sub() Panel2.Enabled = True))


        Catch ex As Exception

        End Try



    End Sub
End Class