﻿Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Module modFunciones
    Private Const sEncodeKey As String = "d@#dsrf#e?sr654982345"
    Public Const sTitulo As String = "MailAuto"

    Public Function SaveToIni(ByVal Texto As String, ByVal FileName As String) As Boolean
        SaveToIni = SaveTextToFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\" & FileName & ".ini", Encrypt(Texto, sEncodeKey))
    End Function

    Public Function Encrypt(ByVal value As String, ByVal WithKey As String) As String

        Dim dC As Chilkat.Crypt2

        dC = New Chilkat.Crypt2

        With dC
            .UnlockComponent("STacticCrypt_veIRRBKPNJTT")
            .CryptAlgorithm = "rijndael"
            .KeyLength = 128
            .SecretKey = .GenerateSecretKey(WithKey)
            .EncodingMode = "Base64"
            .Charset = "ANSI"
            Encrypt = .EncryptStringENC(value)
        End With

        dC = Nothing
    End Function

    Public Function Decrypt(ByVal value As String, ByVal WithKey As String) As String

        Dim dC As New Chilkat.Crypt2

        With dC
            .UnlockComponent("STacticCrypt_veIRRBKPNJTT")
            .CryptAlgorithm = "rijndael"
            .KeyLength = 128
            .SecretKey = .GenerateSecretKey(WithKey)
            .EncodingMode = "Base64"

            Decrypt = .DecryptStringENC(value)
        End With

        dC = Nothing

    End Function

    Private Function SaveTextToFile(ByVal FullPath As String, ByVal Texto As String) As Boolean
        Try
            File.WriteAllText(FullPath, Texto, Encoding.UTF8)
            Return True
        Catch ex As Exception
            AddLine2Log("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetTextFromFile(ByVal FullPath As String) As String
        Dim strText As String = ""
        GetTextFromFile = ""

        Try
            If File.Exists(FullPath) Then
                strText = File.ReadAllText(FullPath)
                GetTextFromFile = strText
            End If
        Catch ex As Exception
            AddLine2Log("Error: " & ex.Message)
        End Try
    End Function

    Public Sub ClearLog()
        SaveTextToFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt", "")
    End Sub

    Public Sub AddLine2Log(ByVal strLog As String)

        Dim strText As String

        strText = GetTextFromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt")

        strText = Now & ": " & strLog & vbNewLine & strText

        SaveTextToFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt", strText)

    End Sub

#Region "Correo"
    Public Function Send_Mail(ByVal C As Configuracion) As Boolean
        Dim Para As String()
        Dim Adjuntos As String()
        Dim sep As Char() = New Char() {";"c}
        Dim mailMan As Chilkat.MailMan
        Dim email As Chilkat.Email

        Try
            mailMan = New Chilkat.MailMan
            mailMan.UnlockComponent("STacticMAILQ_O7skmIlsDwAG")
            With mailMan
                .SmtpHost = C.SMTPHost
                .SmtpPort = C.SMTPPort
                .SmtpUsername = C.SMTPUser
                .SmtpPassword = C.SMTPPass
                .SmtpSsl = C.SMTPSSL
                .ReadTimeout = 30
                .AutoGenMessageId = False
            End With

            If Not mailMan.VerifySmtpLogin Then
                If Not VerifySmtpLogin(mailMan) Then
                    Return False
                End If
            End If

            email = New Chilkat.Email With {
                .Subject = C.Asunto,
                .Body = C.Mensaje,
                .From = C.MailAddress
            }

            Para = C.Para.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(Function(p) p.Trim()).ToArray()
            For Each m As String In Para
                email.AddTo("", m)
            Next

            Adjuntos = C.Adjunto.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(Function(p) p.Trim()).ToArray()
            For Each a As String In Adjuntos
                If File.Exists(a) Then
                    email.AddFileAttachment(a)
                End If
            Next

            If Not mailMan.SendEmail(email) Then
                AddLine2Log("Ocurrió un error al enviar el correo: " & mailMan.LastErrorText)
                MsgBox("Ocurrió un error al enviar el correo, para mas información, revise el archivo de errores.", vbInformation, sTitulo)
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, sTitulo)
            Return False
        Finally
            If Not mailMan Is Nothing Then
                mailMan.CloseSmtpConnection()
            End If
        End Try

    End Function

    Private Function VerifySmtpLogin(ByRef Man As Chilkat.MailMan) As Boolean

        VerifySmtpLogin = False

        Man.SmtpAuthMethod = "LOGIN"
        If Man.VerifySmtpLogin Then
            Return True
        End If

        Man.SmtpAuthMethod = "PLAIN"
        If Man.VerifySmtpLogin Then
            Return True
        End If

        Man.SmtpAuthMethod = "CRAM-MD5"
        If Man.VerifySmtpLogin Then
            Return True
        End If

        Man.SmtpAuthMethod = "NTLM"
        If Man.VerifySmtpLogin Then
            Return True
        End If

        Man.SmtpAuthMethod = "NONE"
        If Man.VerifySmtpLogin Then
            Return True
        End If

        Man.SmtpAuthMethod = ""

        If Man.VerifySmtpLogin Then
            Return True
        Else
            AddLine2Log("Error al enviar el correo. " & Man.LastErrorText)
        End If

        Return False

    End Function
#End Region

#Region "Configuración"
    Public Function Save_Config(ByVal C As Configuracion) As Boolean
        Dim json As String = JsonConvert.SerializeObject(C)
        Return SaveToIni(json, "Config")
    End Function

    Public Function Load_Config() As Configuracion
        Return JsonConvert.DeserializeObject(Of Configuracion)(Decrypt(GetTextFromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\Config.ini"), sEncodeKey))
    End Function
#End Region
End Module
