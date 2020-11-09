
Public Class GroupSearchResult
    Public Sub New(ByVal e_ID As String, ByVal e_Name As String, ByVal e_Privacy As String)
        Me.ID = e_ID
        Me.Name = e_Name
        Me.Privacy = e_Privacy
    End Sub

    Public Property ID As String

    Public Property Name As String

    Public Property Privacy As String
End Class