Imports System.Runtime.CompilerServices
Imports System

Namespace Simple_Facebook_Auto_Poster.Poster.Facebook

    Public Class [Like]
        Public Sub New(ByVal e_ID As String, ByVal e_Name As String, ByVal e_CanPost As Boolean)
            Me.ID = e_ID
            Me.Name = e_Name
            Me.CanPost = e_CanPost
        End Sub

        Public Property CanPost() As Boolean

        Public Property ID() As String

        Public Property Name() As String
    End Class
End Namespace
