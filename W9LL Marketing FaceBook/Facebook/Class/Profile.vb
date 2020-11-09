Public Class MyResponse
    Public Property id() As String
    Public Property name() As String
    Public Property email() As String
    Public Property gender() As String
    Public Property friends() As [friend]

    Public Class [friend]
        Public Property data() As List(Of datas)

        Public Class datas
            Private Property id() As String
            Private Property name() As String
        End Class
    End Class
End Class
