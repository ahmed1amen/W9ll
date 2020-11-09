Imports System.Text.RegularExpressions
Imports InstagramApiSharp.API
Imports InstagramApiSharp.Classes

Public Class Frm_InstaVerify
    Dim ChallengeSize As Size = New Size(432, 604)
    Public InstaApi As IInstaApi
    Private Async Sub SubmitPhoneChallengeButton_ClickAsync(sender As Object, e As EventArgs) Handles SubmitPhoneChallengeButton.Click
        Try
            If (String.IsNullOrEmpty(txtSubmitPhoneForChallenge.Text) OrElse String.IsNullOrWhiteSpace(txtSubmitPhoneForChallenge.Text)) Then
                MessageBox.Show("Please type a valid phone number(with country code)." & vbCrLf & "i.e: +989123456789", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim phoneNumber = txtSubmitPhoneForChallenge.Text
            If Not phoneNumber.StartsWith("+") Then
                phoneNumber = $"+{phoneNumber}"
            End If


            Dim submitPhone = Await InstaApi.SubmitPhoneNumberForChallengeRequireAsync(phoneNumber)
            If submitPhone.Succeeded Then
                SubmitPhoneChallengeGroup.Visible = False
                VerifyCodeGroupBox.Visible = True
            Else
                MessageBox.Show(submitPhone.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            resizing()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub resizing()


        If SubmitPhoneChallengeGroup.Visible = True Then

            Size = SubmitPhoneChallengeGroup.Size
            SubmitPhoneChallengeGroup.Location = New Point(15, 12)


        ElseIf TwoFactorGroupBox.Visible = True Then

            Size = TwoFactorGroupBox.Size
            TwoFactorGroupBox.Location = New Point(15, 12)

        ElseIf SelectMethodGroupBox.Visible = True Then

            Size = SelectMethodGroupBox.Size
            SelectMethodGroupBox.Location = New Point(15, 12)


        ElseIf VerifyCodeGroupBox.Visible = True Then

            Size = VerifyCodeGroupBox.Size
            VerifyCodeGroupBox.Location = New Point(15, 12)


        End If


        Me.Width += 60
        Me.Height += 60

    End Sub

    Private Sub Frm_InstaVerify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resizing()
    End Sub

    Private Async Sub TwoFactorButton_ClickAsync(sender As Object, e As EventArgs) Handles TwoFactorButton.Click
        If (InstaApi Is Nothing) Then
            Return
        End If

        If String.IsNullOrEmpty(txtTwoFactorCode.Text) Then
            MessageBox.Show("Please type your two factor code and then press Auth button.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' send two factor code
        Dim twoFactorLogin = Await InstaApi.TwoFactorLoginAsync(txtTwoFactorCode.Text)
        Debug.WriteLine(twoFactorLogin.Value)
        If twoFactorLogin.Succeeded Then
            ' connected


            Size = ChallengeSize
            TwoFactorGroupBox.Visible = False

            Me.Close()
        Else
            MessageBox.Show(twoFactorLogin.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Async Sub ResendButton_ClickAsync(sender As Object, e As EventArgs) Handles ResendButton.Click
        Dim isEmail As Boolean = False
        If RadioVerifyWithEmail.Checked Then
            isEmail = True
        End If

        Try
            ' Note: every request to this endpoint is limited to 60 seconds                 
            If isEmail Then
                ' send verification code to email
                Dim email = Await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync(replayChallenge:=True)
                If email.Succeeded Then
                    LblForSmsEmail.Text = "We sent verification code one more time to this email:" & vbLf & $"{email.Value.StepData.ContactPoint}"
                    VerifyCodeGroupBox.Visible = True
                    SelectMethodGroupBox.Visible = False
                Else
                    MessageBox.Show(email.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                ' send verification code to phone number
                Dim phoneNumber = Await InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync(replayChallenge:=True)
                If phoneNumber.Succeeded Then
                    LblForSmsEmail.Text = "We sent verification code one more time to this phone number(it's end with this): " & vbLf & $"{phoneNumber.Value.StepData.ContactPoint}"
                    VerifyCodeGroupBox.Visible = True
                    SelectMethodGroupBox.Visible = False
                Else
                    MessageBox.Show(phoneNumber.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            resizing()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub VerifyButton_ClickAsync(sender As Object, e As EventArgs) Handles VerifyButton.Click
        VerifyButton.Enabled = False
        ResendButton.Enabled = False
        txtVerifyCode.Text = txtVerifyCode.Text.Trim
        txtVerifyCode.Text = txtVerifyCode.Text.Replace(" ", "")
        Dim regex = New Regex("^-*[0-9,\.]+$")
        If Not regex.IsMatch(txtVerifyCode.Text) Then
            MessageBox.Show("Verification code is numeric!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (txtVerifyCode.Text.Length <> 6) Then
            MessageBox.Show("Verification code must be 6 digits!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Note: calling VerifyCodeForChallengeRequireAsync function, 
            ' if user has two factor enabled, will wait 15 seconds and it will try to
            ' call LoginAsync.
            Dim verifyLogin = Await InstaApi.VerifyCodeForChallengeRequireAsync(txtVerifyCode.Text)
            If verifyLogin.Succeeded Then
                ' you are logged in sucessfully.
                SelectMethodGroupBox.Visible = False
                VerifyCodeGroupBox.Visible = False
                Size = ChallengeSize
                ' InstgramClient.InstaApi = InstaApi
                Me.Close()
            Else
                SelectMethodGroupBox.Visible = False
                VerifyCodeGroupBox.Visible = False
                ' two factor is required
                If (verifyLogin.Value = InstaLoginResult.TwoFactorRequired) Then
                    TwoFactorGroupBox.Visible = True
                Else
                    MessageBox.Show(verifyLogin.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            resizing()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        VerifyButton.Enabled = True
        ResendButton.Enabled = True
    End Sub

    Private Async Sub SendCodeButton_ClickAsync(sender As Object, e As EventArgs) Handles SendCodeButton.Click
        Dim isEmail As Boolean = False
        If RadioVerifyWithEmail.Checked Then
            isEmail = True
        End If

        'if (RadioVerifyWithPhoneNumber.Checked)
        '    isEmail = false;
        Try
            ' Note: every request to this endpoint is limited to 60 seconds                 
            If isEmail Then
                ' send verification code to email
                Dim email = Await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync()
                If email.Succeeded Then
                    LblForSmsEmail.Text = "We sent verify code to this email:" & vbLf & $"{email.Value.StepData.ContactPoint}"
                    VerifyCodeGroupBox.Visible = True
                    SelectMethodGroupBox.Visible = False
                Else
                    MessageBox.Show(email.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                ' send verification code to phone number
                Dim phoneNumber = Await InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync()
                If phoneNumber.Succeeded Then
                    LblForSmsEmail.Text = "We sent verify code to this phone number(it's end with this):" & vbLf & $"{phoneNumber.Value.StepData.ContactPoint}"
                    VerifyCodeGroupBox.Visible = True
                    SelectMethodGroupBox.Visible = False
                Else
                    MessageBox.Show(phoneNumber.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            resizing()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class