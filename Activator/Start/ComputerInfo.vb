Imports System.Management
Imports DevExpress.XtraEditors

Public Class ComputerInfo
    'Get processor ID
    Public Shared Function GetProcessorId() As String
        Dim strProcessorID As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorID = info("processorID").ToString()
        Next
        Return strProcessorID
    End Function
    ' Get MAC Address
    Public Shared Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MacAddress As String = String.Empty
        For Each mo As ManagementObject In moc
            If (MacAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MacAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MacAddress = MacAddress.Replace(":", String.Empty)
        Next
        Return MacAddress
    End Function
    ' Get Motherboard ID
    Public Shared Function GetMotherboardID() As String
        Dim strMotherboardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherboardID = info("product").ToString()
        Next
        Return strMotherboardID
    End Function
    ' Encrypt HWID
    Public Shared Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
    Public Shared Function GetHwid() As String
        Try
            Dim cpu As String
            Dim mb As String
            Dim mac As String
            Dim hwid As String
            cpu = GetProcessorId()
            mb = GetMotherboardID()
            mac = GetMACAddress()
            hwid = cpu + mb + mac
            Dim hwidEncrypted As String = Strings.UCase(getMD5Hash(cpu & mb & mac))
            hwid = hwidEncrypted
            Return hwid
        Catch ex As Exception

            XtraMessageBox.Show(ex.Message, " Activator: HWID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return ""
        End Try

    End Function

End Class
