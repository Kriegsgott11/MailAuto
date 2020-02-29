Public Class Configuracion
    'Mensaje
    Public Property Para() As String
    Public Property Asunto() As String
    Public Property Mensaje() As String
    Public Property Adjunto() As String

    'Cuenta
    Public Property MailAddress() As String
    Public Property SMTPHost() As String
    Public Property SMTPPort() As Integer
    Public Property SMTPSSL() As Boolean
    Public Property SMTPUser() As String
    Public Property SMTPPass() As String

    Public Sub New()
        Asunto = ""
        Mensaje = ""
        Adjunto = ""

        MailAddress = ""
        SMTPHost = ""
        SMTPPort = 0
        SMTPSSL = True
        SMTPUser = ""
        SMTPPass = ""
    End Sub
End Class

