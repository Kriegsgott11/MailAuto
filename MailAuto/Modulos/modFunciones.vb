﻿Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports Newtonsoft.Json

Module modFunciones
    Private Const sEncodeKey As String = "d@#dsrf#e?sr654982345"
    Public Const sTitulo As String = "MailAuto"

    Public Function SaveToIni(ByVal Texto As String, ByVal FileName As String) As Boolean
        SaveToIni = SaveTextToFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\" & FileName & ".ini", Encryption.Encrypt(Texto, sEncodeKey))
    End Function

    Public Function SaveTextToFile(ByVal FullPath As String, ByVal Texto As String) As Boolean
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

    Public Async Function Send_Mail(ByVal C As Configuracion) As Task(Of Boolean)
        Dim Para As String()
        Dim Adjuntos As String()
        Dim sep As Char() = New Char() {";"c}
        Dim smtpClient As SmtpClient = Nothing
        Dim email As MailMessage = Nothing

        Try
            smtpClient = New SmtpClient(C.SMTPHost) With {
                .Port = C.SMTPPort,
                .EnableSsl = C.SMTPSSL,
                .Credentials = New Net.NetworkCredential(C.SMTPUser, C.SMTPPass)
            }

            email = New MailMessage With {
                .From = New MailAddress(C.MailAddress),
                .Subject = C.Asunto,
                .Body = C.Mensaje
            }

            Para = C.Para.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(Function(p) p.Trim()).ToArray()
            For Each m As String In Para
                email.To.Add(m)
            Next

            Adjuntos = C.Adjunto.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(Function(p) p.Trim()).ToArray()
            For Each a As String In Adjuntos
                If File.Exists(a) Then
                    email.Attachments.Add(New Attachment(a))
                End If
            Next

            Await smtpClient.SendMailAsync(email)
            Return True

        Catch ex As Exception
            MsgBox("Error al enviar el correo: " & ex.Message, vbCritical, sTitulo)
            Return False
        Finally
            If Not email Is Nothing Then
                email.Dispose()
            End If
            If Not smtpClient Is Nothing Then
                smtpClient.Dispose()
            End If
        End Try

    End Function


#End Region

#Region "Configuración"
    Public Function Save_Config(ByVal P As List(Of Configuracion)) As Boolean
        Dim json As String = JsonConvert.SerializeObject(P)
        Return SaveToIni(json, "Config")
    End Function

    Public Function Load_Config() As List(Of Configuracion)
        Return JsonConvert.DeserializeObject(Of List(Of Configuracion))(Encryption.Decrypt(GetTextFromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\Config.ini"), sEncodeKey))
    End Function
#End Region
End Module
