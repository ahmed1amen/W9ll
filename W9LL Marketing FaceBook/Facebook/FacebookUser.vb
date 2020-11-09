Imports System.Runtime.CompilerServices
Imports System.Collections.Generic
Imports System

Public Class FacebookUser
        Public Sub SetAllProprtiesNull()
            ' FacebookPoster.GlobalError = ""
            Me.AccessToken = String.Empty
            Me.Name = String.Empty
            Me.ID = String.Empty
            Me.IsUserLogin = False
            Me.FotoUrl = String.Empty


        Me.Cookies = String.Empty
            Me.UserAgent = String.Empty
            Me.ManuallyID = String.Empty
            Me.CookiesExpireDate = Nothing
            Me.HtcAccessToken = String.Empty
            Me.HtcAccessTokenExpireDate = String.Empty
            Me.GraphAccessToken = String.Empty
            Me.GraphAccessTokenExpireDate = String.Empty
            Me.isSaved = False
        End Sub
    Public Property UserName As String
    Public Property Password As String

    Public Property AccessToken() As String

        Public Property Cookies() As String

        Public Property CookiesExpireDate() As String

        Public Property FotoUrl() As String



    Public Property GraphAccessToken() As String

        Public Property GraphAccessTokenExpireDate() As String



        Public Property HtcAccessToken() As String

        Public Property HtcAccessTokenExpireDate() As String

        Public Property ID() As String

        Public Property isSaved() As Boolean

        Public Property IsUserLogin() As Boolean


    Public Property ManuallyID() As String

        Public Property Name() As String

    Public Property UserAgent() As String
    End Class
