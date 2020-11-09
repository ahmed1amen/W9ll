Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Cache
Imports System.Text


' Token: 0x02000089 RID: 137
Public Class HttpRequest
        ' Token: 0x06000A5E RID: 2654 RVA: 0x000AE2A4 File Offset: 0x000AC4A4
        Public Shared Function GetRequestText(url As String, method As String, postData As Byte(), referer As String, cookie As String, userAgent As String, proxy As WebProxy, getResponseHTML As Boolean, returnURI As Boolean, Optional contentType As String = "application/x-www-form-urlencoded;") As String
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            httpWebRequest.CachePolicy = New RequestCachePolicy(RequestCacheLevel.NoCacheNoStore)
            httpWebRequest.Method = method
            Dim flag As Boolean = proxy IsNot Nothing
            If flag Then
                httpWebRequest.Proxy = proxy
            End If
            httpWebRequest.ContentType = contentType
        Dim flag2 As Boolean = Not cookie = ""
        If flag2 Then
                httpWebRequest.Headers("Cookie") = cookie
            End If
        Dim flag3 As Boolean = Not userAgent = ""
        If flag3 Then
                httpWebRequest.UserAgent = userAgent
            End If
        Dim flag4 As Boolean = Not referer = ""
        If flag4 Then
                httpWebRequest.Referer = referer
                httpWebRequest.Headers("origin") = referer
            End If
            Dim flag5 As Boolean = method = "POST" AndAlso postData IsNot Nothing
            If flag5 Then
                httpWebRequest.ContentLength = CLng(postData.Length)
                Try
                    Using requestStream As Stream = httpWebRequest.GetRequestStream()
                        requestStream.Write(postData, 0, postData.Length)
                    End Using
                Catch
                    Return ""
                End Try
            End If
            Dim result As String = ""
            Try
                Using httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
                    If getResponseHTML Then
                        Using responseStream As Stream = httpWebResponse.GetResponseStream()
                            Using streamReader As StreamReader = New StreamReader(responseStream, Encoding.UTF8)
                                result = streamReader.ReadToEnd()
                            End Using
                        End Using
                    ElseIf returnURI Then
                        result = httpWebResponse.ResponseUri.AbsoluteUri
                    End If
                End Using
            Catch
            End Try
            Return result
        End Function
    End Class
