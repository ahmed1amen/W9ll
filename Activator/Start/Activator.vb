Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.XtraEditors
Imports Newtonsoft.Json

Public Class Activator
    Public Shared Somestring As String
    Public JsonSenderOBJ As Object
    Public Shared Function EncryptString(ByVal plainText As String, ByVal key() As Byte) As String
        Try
            Dim iv() As Byte = {&H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0}
            ' Instantiate a new Aes object to perform string symmetric encryption
            Dim encryptor As Aes = Aes.Create()

            encryptor.Mode = CipherMode.CBC

            ' Set key and IV
            Dim aesKey(31) As Byte
            Array.Copy(key, 0, aesKey, 0, 32)
            encryptor.Key = aesKey
            encryptor.IV = iv

            ' Instantiate a new MemoryStream object to contain the encrypted bytes
            Dim memoryStream As New MemoryStream()

            ' Instantiate a new encryptor from our Aes object
            Dim aesEncryptor As ICryptoTransform = encryptor.CreateEncryptor()

            ' Instantiate a new CryptoStream object to process the data and write it to the 
            ' memory stream
            Dim cryptoStream As New CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write)
            ' Convert the plainText string into a byte array
            Dim plainBytes() As Byte = Encoding.ASCII.GetBytes(plainText)

            ' Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length)

            ' Complete the encryption process
            cryptoStream.FlushFinalBlock()

            ' Convert the encrypted data from a MemoryStream to a byte array
            Dim cipherBytes() As Byte = memoryStream.ToArray()

            ' Close both the MemoryStream and the CryptoStream
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert the encrypted byte array to a base64 encoded string
            Dim cipherText As String = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length)

            ' Return the encrypted data as a string
            Return cipherText

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, " Activator: Enc", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return ""
        End Try
    End Function
    Public Shared Function DecryptString(ByVal cipherText As String, ByVal key() As Byte) As String
        Try

            Dim iv() As Byte = {&H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0}
            ' Instantiate a new Aes object to perform string symmetric ~encryption~
            Dim encryptor As Aes = Aes.Create()

            encryptor.Mode = CipherMode.CBC

            ' Set key and IV
            Dim aesKey(31) As Byte
            Array.Copy(key, 0, aesKey, 0, 32)
            encryptor.Key = aesKey
            encryptor.IV = iv

            ' Instantiate a new MemoryStream object to contain the encrypted bytes
            Dim memoryStream As New MemoryStream()

            ' Instantiate a new encryptor from our Aes object
            Dim aesDecryptor As ICryptoTransform = encryptor.CreateDecryptor()

            ' Instantiate a new CryptoStream object to process the data and write it to the 
            ' memory stream
            Dim cryptoStream As New CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write)

            ' Will contain decrypted plaintext
            Dim plainText As String = String.Empty

            Try
                ' Convert the ciphertext string into a byte array
                Dim cipherBytes() As Byte = Convert.FromBase64String(cipherText)

                ' Decrypt the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length)

                ' Complete the decryption process
                cryptoStream.FlushFinalBlock()

                ' Convert the decrypted data from a MemoryStream to a byte array
                Dim plainBytes() As Byte = memoryStream.ToArray()

                ' Convert the decrypted byte array to string
                plainText = Encoding.UTF8.GetString(plainBytes, 0, plainBytes.Length)
            Finally
                ' Close both the MemoryStream and the CryptoStream
                memoryStream.Close()
                cryptoStream.Close()
            End Try

            ' Return the decrypted data as a string
            Return plainText


        Catch ex As Exception


            XtraMessageBox.Show(ex.Message, " Activator: Dec", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return ""
        End Try
    End Function

    Public Shared Function RequestFromServer(ByVal serverurl As String, ByVal postdatax As String, ByVal host As String) As String
        Try
            Dim httpRequest As HttpWebRequest = Nothing
            Dim httpPostStream As Stream = Nothing
            Dim httpResponseStream As BinaryReader = Nothing
            httpRequest = CType(WebRequest.Create(serverurl & WebUtility.UrlEncode(postdatax)), HttpWebRequest)
            httpRequest.Method = "GET"
            httpRequest.Host = host
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.67 Safari/537.36"
            httpRequest.ContentType = "application/application/json"
            httpRequest.KeepAlive = True

            'Dim proxy = New Net.WebProxy()



            'Dim ipandportNumber As String
            'ipandportNumber = "127.0.0.1" & ":" & "8888"
            ''     ProxyUserName = str1(2)
            ''    ProxyPassword = str1(3)


            'proxy.Address = New Uri(ipandportNumber)
            '        proxy.BypassProxyOnLocal = False
            '  httpRequest.Proxy = proxy


            '   p.Credentials = New NetworkCredential(ProxyUserName, ProxyPassword)




            '  WebRequest.DefaultWebProxy = New WebProxy()




            Dim Response As HttpWebResponse = httpRequest.GetResponse()
            Dim Postreqreader As New StreamReader(Response.GetResponseStream())

            Dim content As String = Postreqreader.ReadToEnd

            Return content

        Catch ex As Exception

            XtraMessageBox.Show(ex.Message, "Activator: Request", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return ""
        End Try





    End Function
    Public plainText As String
    Public Structure DataToServer
        Public serial As String
        Public hiwd As String
    End Structure
    Public Structure DataFromServer
        Public id As String
        Public serial As String
        Public hwid As String
        Public status As String
        Public reg_date As String
        Public expire_date As String
        Public message As String
        Public programversion As String
        Public avtweets As String
        Public avprogram As String
    End Structure


    Public Sub prepare(ByRef SN As String)
        Dim Datasender As New DataToServer
        Datasender.hiwd = ComputerInfo.GetHwid()
        Datasender.serial = SN.Trim
        JsonSenderOBJ = Datasender
        startval()
    End Sub
    Shared Sub spaccing_Remover()
        Try

            frm_Activation.TextEdit2.Text = frm_Activation.TextEdit2.Text.Replace(" ", "")

        Catch ex As Exception

        End Try
    End Sub
    Public Sub startval()
        Dim pwn As String = reqestpgpcert()
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        Dim PWWN() As Byte = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(pwn))
        Dim senderjson As String = JsonConvert.SerializeObject(JsonSenderOBJ)
        Dim resposebody As String = RequestFromServer("https://w9ll.co/socialmark/test.php?data=", EncryptString(senderjson, PWWN), "w9ll.co")
        plainText = DecryptString(resposebody, PWWN)
    End Sub
    Function reqestpgpcert() As String
        Dim cert As String = RequestFromServer("https://w9ll.co/socialmark/PublicPGBKey.json", "", "w9ll.co")
        Try
            Return cert.Substring(50, 20)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Async Function DoShow() As Task(Of Boolean)
        Try

            spaccing_Remover()
            frm_Activation.btn_validate.Enabled = False
            frm_Activation.ProgWait.Visible = True
            My.Settings.serial = frm_Activation.TextEdit2.Text
            My.Settings.Save()
            Dim SN As String = frm_Activation.TextEdit2.Text

            Dim t = Task.Factory.StartNew(Sub()
                                              prepare(SN)
                                          End Sub)

            Await t

            Await Task.Delay(2000)
            If plainText.Contains("Serial Not Found") Then
                XtraMessageBox.Show("You Are Not Register", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                frm_Activation.btn_validate.Enabled = True
                frm_Activation.ProgWait.Visible = False
                Return False

            End If

            Dim result = JsonConvert.DeserializeObject(Of List(Of DataFromServer))(plainText)
            If result(0).serial <> JsonSenderOBJ.serial Then
                XtraMessageBox.Show("Serial incorrect ! ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                frm_Activation.btn_validate.Enabled = True
                frm_Activation.ProgWait.Visible = False
                Return False
            End If
            If result(0).hwid <> JsonSenderOBJ.hiwd Then
                XtraMessageBox.Show("This Serial Number Is Not Bounded With This Machine", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                frm_Activation.btn_validate.Enabled = True
                frm_Activation.ProgWait.Visible = False
                Return False
            End If


            If result(0).avprogram.Contains(Activation.ProgramVersion.Program_Name) = False Then
                XtraMessageBox.Show("This Serial Number Can Activate Only Specific Versions", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
                frm_Activation.btn_validate.Enabled = True
                frm_Activation.ProgWait.Visible = False
                Return False
            End If




            frm_Activation.ProgWait.Visible = False
            If result(0).serial = JsonSenderOBJ.serial Then
                If result(0).hwid = JsonSenderOBJ.hiwd Then

                    If result(0).status = "active" Then


                        If result(0).programversion = Activation.ProgramVersion.Standard Then
                            Activation.ProgramVersion.current = Activation.ProgramVersion.Standard

                            '    ProgramVersion.maxSupport = 500
                            '    InstgramClient.Grop_DmSender.Visible = False
                            '    InstgramClient.Grop_Follow_unfollow.Visible = False
                        Else
                            Activation.ProgramVersion.current = Activation.ProgramVersion.VIP
                        End If
                        frm_Activation.Hide()
                        'InstgramClient.Show()
                        'frm_FacebookApplication.Show()
                    Else
                        XtraMessageBox.Show(result(0).message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                End If
            End If




            frm_Activation.btn_validate.Enabled = True
            frm_Activation.ProgWait.Visible = False
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Activation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Application.Exit()
            Return False
        End Try
        Return True

    End Function






End Class
