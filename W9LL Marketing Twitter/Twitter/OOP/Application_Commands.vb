Imports System.Data
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Module Application_Commands
    Public Function GetAll(ByVal control As Control, ByVal type As Type) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAll(ctrl, type)).Concat(controls).Where(Function(c) c.GetType() Is type)
    End Function
    Public Sub Notify_DataTable_Update()



        Controller.ComboBoxEdit_Enter(Controller.Comb_Following, Nothing)

        Controller.ComboBoxEdit_Enter(Controller.comb_scrapper, Nothing)
        Controller.ComboBoxEdit_Enter(Controller.Comb_Tweeting, Nothing)



    End Sub
    Public Property UserDataTable_Control(Optional path As String = "UserDataTable.dll") As DataTable

        Set(value As DataTable)

            Using stream As Stream = System.IO.File.Create(path)
                Try
                    Dim formatter As New BinaryFormatter()
                    formatter.Serialize(stream, value)

                Catch e As Exception
                    MsgBox("Problem writing TweetsDataTable to disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                End Try
            End Using


        End Set

        Get
            Try
                Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                    Dim formatter As New BinaryFormatter()
                    Return CType(formatter.Deserialize(stream), DataTable)
                End Using
            Catch e As Exception
                MsgBox("Problem reading UserDataTable from disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                Return New DataTable()
            End Try

        End Get
    End Property
    Public Property ScrapperDataTable_Control() As DataTable

        Set(value As DataTable)
            Dim path As String
            If Controller.SFD_Scrapper.ShowDialog = DialogResult.OK Then
                path = Controller.SFD_Scrapper.FileName

                Using stream As Stream = System.IO.File.Create(path)
                    Try
                        Dim formatter As New BinaryFormatter()
                        formatter.Serialize(stream, value)

                    Catch e As Exception
                        MsgBox("Problem writing TweetsDataTable to disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                    End Try
                End Using
            End If


        End Set

        Get
            Try
                Dim path As String

                If Controller.OFD_Scrapper.ShowDialog = DialogResult.OK Then
                    path = Controller.OFD_Scrapper.FileName


                    Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                        Dim formatter As New BinaryFormatter()
                        Return CType(formatter.Deserialize(stream), DataTable)
                    End Using

                Else
                    Return New DataTable()
                End If
            Catch e As Exception
                MsgBox("Problem reading TweetsDataTable from disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                Return New DataTable()
            End Try

        End Get
    End Property

    Public Property TweetsDataTable_Control(Optional path As String = "TweetsDataTable.dll") As DataTable

        Set(value As DataTable)

            Using stream As Stream = System.IO.File.Create(path)
                Try
                    Dim formatter As New BinaryFormatter()
                    formatter.Serialize(stream, value)

                Catch e As Exception
                    MsgBox("Problem writing TweetsDataTable to disk: " & vbNewLine & e.Message)
                End Try
            End Using


        End Set

        Get
            Try
                Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                    Dim formatter As New BinaryFormatter()
                    Return CType(formatter.Deserialize(stream), DataTable)
                End Using
            Catch e As Exception
                MsgBox("Problem reading TweetsDataTable from disk: " & vbNewLine & e.Message)
                Return New DataTable()
            End Try

        End Get
    End Property

    '''<CheckTweet>
    ''' For Check The Avalible tweet in every account
    ''' </CheckTweet>

    Public Property TweetLimitDataTable_Control(Optional path As String = "TweetLimitDataTable.dll") As DataTable

        Set(value As DataTable)

            Using stream As Stream = System.IO.File.Create(path)
                Try
                    Dim formatter As New BinaryFormatter()
                    formatter.Serialize(stream, value)

                Catch e As Exception
                    MsgBox("Problem writing TweetLimitDataTable to disk: " & vbNewLine & e.Message)
                End Try
            End Using


        End Set

        Get
            Try
                Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                    Dim formatter As New BinaryFormatter()
                    Return CType(formatter.Deserialize(stream), DataTable)
                End Using
            Catch e As Exception
                MsgBox("Problem reading TweetLimitDataTable from disk: " & vbNewLine & e.Message)
                Return New DataTable()
            End Try

        End Get
    End Property







End Module
