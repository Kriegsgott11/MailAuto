Imports System.ComponentModel

Public Class frmCuenta
    Private mConfig As Configuracion

    Public Sub New(ByVal lConfig As Configuracion)
        mConfig = lConfig

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If mConfig Is Nothing Then
            mConfig = New Configuracion
        End If

        With mConfig
            .MailAddress = txtMailAddress.Text
            .SMTPHost = txtSMTPHost.Text
            If Len(txtSMTPPort.Text) > 0 AndAlso IsTextInteger(txtSMTPPort) Then
                .SMTPPort = txtSMTPPort.Text
            Else
                .SMTPPort = 0
            End If
            .SMTPUser = txtSMTPUser.Text
            .SMTPPass = txtSMTPPass.Text
            .SMTPSSL = chkSMTPSSL.Checked
        End With

        If Save_Config(mConfig) Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub FrmCuenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Load_Data()
    End Sub

    Private Sub Load_Data()
        If mConfig Is Nothing Then
            Return
        End If

        With mConfig
            txtMailAddress.Text = .MailAddress
            txtSMTPHost.Text = .SMTPHost
            txtSMTPPort.Text = .SMTPPort
            txtSMTPUser.Text = .SMTPUser
            txtSMTPPass.Text = .SMTPPass
            chkSMTPSSL.Checked = .SMTPSSL
        End With
    End Sub

    Private Sub TxtSMTPPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSMTPPort.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSMTPPort_Validating(sender As Object, e As CancelEventArgs) Handles txtSMTPPort.Validating
        e.Cancel = Not IsTextInteger(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) AndAlso CInt(target.Text) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class