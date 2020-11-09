Imports System.Runtime.CompilerServices
Imports System

Namespace Simple_Facebook_Auto_Poster.Poster.Facebook

    Public Class Page
        Public Sub New(ByVal e_ID As String, ByVal e_Name As String, ByVal e_AccessToken As String)
            Me.ID = e_ID
            Me.Name = e_Name
            Me.AccessToken = e_AccessToken
        End Sub

        Public Property AccessToken() As String

        Public Property ID() As String

        Public Property Name() As String
    End Class
End Namespace
