Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class AppHelper

    Public Shared Property UserDataTable_Control() As DataTable

        Set(value As DataTable)
            Dim path As String
            If frm_FacebookApplication.SFD_Accounts.ShowDialog = DialogResult.OK Then
                path = frm_FacebookApplication.SFD_Accounts.FileName

                Using stream As Stream = System.IO.File.Create(path)
                    Try
                        Dim formatter As New BinaryFormatter()
                        formatter.Serialize(stream, value)

                    Catch e As Exception
                        MsgBox("Problem writing AccountsFile to disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                    End Try
                End Using
            End If


        End Set

        Get
            Try
                Dim path As String

                If frm_FacebookApplication.OFD_Accounts.ShowDialog = DialogResult.OK Then
                    path = frm_FacebookApplication.OFD_Accounts.FileName


                    Using stream As Stream = System.IO.File.Open(path, FileMode.Open)
                        Dim formatter As New BinaryFormatter()
                        Return CType(formatter.Deserialize(stream), DataTable)
                    End Using

                Else
                    Return New DataTable()
                End If
            Catch e As Exception
                MsgBox("Problem Reading AccountsFile from disk: " & vbNewLine & e.Message, MsgBoxStyle.Critical)
                Return New DataTable()
            End Try

        End Get
    End Property

End Class
