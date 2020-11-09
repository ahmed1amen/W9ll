Public Class TaskStatus
    Public Shared ReadOnly Property Running As String = "قيد التشغيل"
    Public Shared ReadOnly Property Ready As String = "جاهزه للتشغيل"
    Public Shared ReadOnly Property Finished As String = "تم الانتهاء"
    Public Shared ReadOnly Property Failed As String = "فشل"
    Public Shared ReadOnly Property Stopped As String = "متوقف"

End Class
Public Class AccountAuthenticationStatus
    Public Shared ReadOnly Property authenticated As String = "تم تسجيل الدخول بنجاح"
    Public Shared ReadOnly Property Checking As String = "جاري الفحص"
    Public Shared ReadOnly Property Failed As String = "فشل"
End Class
Public Class QureyTypes
    Public Shared ReadOnly Property Q_Like As String = "Like"
    Public Shared ReadOnly Property Q_Retweet As String = "Retweet"
    Public Shared ReadOnly Property Q_Comment As String = "Comment"
End Class

Public Class CurrentWorkingTask
    Public Shared Property PIDS As String = String.Empty             ' For Contain Background Workrs IDs ... To make Twitter Class Able To Kill Running Threads Fast
End Class

