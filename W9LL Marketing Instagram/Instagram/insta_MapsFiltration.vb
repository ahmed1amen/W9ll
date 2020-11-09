Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class insta_MapsFiltration

    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Import.Click
        If XtraOpenFileDialog1.ShowDialog = DialogResult.OK Then
            ProgWait.Visible = True
            GroupControl1.Visible = False
            Dim xa As New Threading.Thread(Sub() loadDataGrid())
            xa.IsBackground = True
            xa.Start()

        End If
    End Sub
    Public DT_users As DataTable = New DataTable
    Public Sub RemoveDuplicateRows(ByVal colName As String)

        Dim hTable As Hashtable = New Hashtable()
        Dim duplicateList As ArrayList = New ArrayList()

        For Each drow As DataRow In DT_users.Rows

            If hTable.Contains(drow(colName)) Then

                duplicateList.Add(drow)
            Else

                hTable.Add(drow(colName), String.Empty)

            End If
        Next

        For Each dRow As DataRow In duplicateList

            DT_users.Rows.Remove(dRow)

        Next


        Grid_Control_Following_Report.DataSource = DT_users
        GroupControl1.Invoke(New Action(Sub() GroupControl1.Visible = True))
        ProgWait.Invoke(New Action(Sub() ProgWait.Visible = False))
        MsgBox("Done", MsgBoxStyle.Information, "Done")

    End Sub
    Private StartRowHandle As Integer = -1
    Private CurrentRowHandle As Integer = -1
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


    Sub loadDataGrid()

        For Each filePath As String In XtraOpenFileDialog1.FileNames
            For Each x As String In IO.File.ReadAllLines(filePath, System.Text.Encoding.UTF8)
                Dim ss() As String = x.Split("*_*")
                If x.Contains("*_*") Then
                    If x.Length > 10 Then
                        If ss(0) = "" Then
                        Else
                            DT_users.Rows.Add({ss(0), ss(2), ss(4)})
                        End If

                    End If
                End If
            Next
        Next



        Grid_Control_Following_Report.DataSource = DT_users


        GroupControl1.Invoke(New Action(Sub() GroupControl1.Visible = True))
        ProgWait.Invoke(New Action(Sub() ProgWait.Visible = False))


    End Sub

    Private Sub Insta_MapsFiltration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_users.Columns.Add("acc_name")
        DT_users.Columns.Add("acc_ID")
        DT_users.Columns.Add("acc_UserName")

        Grid_View_Following_Report.PopulateColumns()





        AddHandler Grid_View_Following_Report.MouseUp, AddressOf gridView1_MouseUp
        AddHandler Grid_View_Following_Report.MouseMove, AddressOf gridView1_MouseMove
        AddHandler Grid_View_Following_Report.MouseDown, AddressOf gridView1_MouseDown
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btn_RemoveDup.Click
        ProgWait.Visible = True
        GroupControl1.Visible = False
        Grid_Control_Following_Report.DataSource = Nothing
        Dim xa As New Threading.Thread(Sub() RemoveDuplicateRows("acc_ID"))
        xa.IsBackground = True
        xa.Start()
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



            XtraMessageBox.Show("تم الحفظ بنجاح", "تم ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
        GroupControl1.Invoke(New Action(Sub() GroupControl1.Visible = True))
        ProgWait.Invoke(New Action(Sub() ProgWait.Visible = False))

    End Sub
    Private Sub Btn_Export_Click_1(sender As Object, e As EventArgs) Handles btn_Export.Click
        If XtraSaveFileDialog1.ShowDialog = DialogResult.OK Then
            ProgWait.Visible = True
            GroupControl1.Visible = False
            Dim xa As New Threading.Thread(AddressOf ExportDataGrid)
            xa.IsBackground = True
            xa.Start()
        End If
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class