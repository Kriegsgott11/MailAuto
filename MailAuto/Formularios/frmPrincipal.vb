Imports System.ComponentModel

Public Class frmPrincipal

    Private Perfiles As Perfil

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub FrmPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadPerfiles()
    End Sub

    Private Async Sub CmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        SaveSettings()

        Dim C As Configuracion = GetSelectedProfile()

        If Await Send_Mail(C) Then
            MsgBox("Mensaje Enviado.", vbInformation, sTitulo)
        End If
    End Sub

    Private Sub CmdSelAdjunto_Click(sender As Object, e As EventArgs) Handles cmdSelAdjunto.Click
        Dim OpenFile As New OpenFileDialog With {
            .Title = "Seleccione un archivo"
        }
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Len(txtAdjunto.Text) = 0 Then
                txtAdjunto.Text = OpenFile.FileName
            Else
                txtAdjunto.Text = txtAdjunto.Text & "; " & OpenFile.FileName
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPerfiles()
    End Sub

#Region "Log de errores"
    Private Sub VerArchivoDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerArchivoDeErroresToolStripMenuItem.Click
        If Not System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt") Then
            MsgBox("No existe el archivo de errores.", vbInformation, sTitulo)
            Return
        End If

        Dim Proceso As New Process
        Proceso.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt"
        Proceso.Start()
    End Sub

    Private Sub VaciarArchivoDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaciarArchivoDeErroresToolStripMenuItem.Click
        If Not System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "\ProgramLog.txt") Then
            MsgBox("No existe el archivo de errores.", vbInformation, sTitulo)
            Return
        End If

        If MsgBox("Se eliminarán todos los registros del archivo de errores, ¿Está seguro?", vbYesNoCancel, sTitulo) = vbYes Then
            ClearLog()
        End If
    End Sub
#End Region

#Region "Perfiles"
    Private Sub LoadPerfiles()
        Dim Index As String
        Perfiles = New Perfil()
        Perfiles.LoadConfig()

        If Perfiles.Perfiles Is Nothing Then
            Perfiles.Perfiles = New List(Of Configuracion)
        End If

        If Perfiles.Perfiles.Count = 0 Then
            cmbPerfiles.DataSource = Nothing
            Return
        End If

        Index = ""

        For Each C As Configuracion In Perfiles.Perfiles

            If C.Seleccionado Then
                Index = C.ID
                Exit For
            End If
        Next

        ChargeCmbPerfiles(Index)
    End Sub
    Private Sub ChargeCmbPerfiles(ByVal Optional value As String = "")
        cmbPerfiles.DataSource = Nothing
        cmbPerfiles.DataSource = Perfiles.Perfiles
        cmbPerfiles.DisplayMember = "Nombre"
        cmbPerfiles.ValueMember = "ID"

        If value.Length > 0 Then
            cmbPerfiles.SelectedValue = value
        End If
    End Sub

    Private Function GetSelectedProfile() As Configuracion
        Return Perfiles.Perfiles.Find(Function(p) p.ID = cmbPerfiles.SelectedValue.ToString())
    End Function

    Private Function ValidateProfileName(ByVal Name As String) As Boolean
        If Name.ToUpper() = "EXECUTE" Then
            MessageBox.Show("El nombre del perfil no puede ser igual a la palabra clave EXECUTE.")
            Return False
        ElseIf Name.Length = 0 Then
            MessageBox.Show("El nombre del perfil no puede estar vacío.")
            Return False
        ElseIf Name.Length > 255 Then
            MessageBox.Show("El nombre del perfil excede el límite de caracteres disponible.")
            Return False
        End If

        If CheckProfileNameExists(Name) Then
            Return False
        End If

        Return True
    End Function
    Private Function CheckProfileNameExists(ByVal Name As String) As Boolean
        If Perfiles.Perfiles.Any(Function(p) p.Nombre.ToUpper() = Name.ToUpper()) Then
            MessageBox.Show("Ya existe un perfil con el nombre '" & Name & "'.")
            Return True
        End If

        Return False
    End Function
#End Region

#Region "Configuraciones"
    Private Sub SaveSettings()
        If cmbPerfiles.SelectedValue Is Nothing Then

            If Perfiles.Perfiles.Count = 0 Then
                Perfiles.SaveConfig()
            End If

            Return
        End If

        For Each P As Configuracion In Perfiles.Perfiles
            P.Seleccionado = False
        Next

        Dim index As Integer = Perfiles.Perfiles.FindIndex(Function(p) p.ID = cmbPerfiles.SelectedValue.ToString())
        With Perfiles.Perfiles(index)
            .Seleccionado = True
            .Para = txtPara.Text
            .Asunto = txtAsunto.Text
            .Mensaje = txtMensaje.Text
            .Adjunto = txtAdjunto.Text

            .SMTPHost = txtSMTPHost.Text
            .SMTPPass = txtSMTPPass.Text
            If Len(txtSMTPPort.Text) > 0 AndAlso IsTextInteger(txtSMTPPort) Then
                .SMTPPort = txtSMTPPort.Text
            Else
                .SMTPPort = 0
            End If
            .SMTPUser = txtSMTPUser.Text
            .SMTPSSL = chkSMTPSSL.Checked
        End With

        Perfiles.SaveConfig()
    End Sub

    Private Sub LoadSettings()
        Dim C As Configuracion = Perfiles.Perfiles.Find(Function(p) p.ID = cmbPerfiles.SelectedValue.ToString())

        If C Is Nothing Then
            Return
        End If

        txtPara.Text = C.Para
        txtAsunto.Text = C.Asunto
        txtMensaje.Text = C.Mensaje
        txtAdjunto.Text = C.Adjunto

        txtSMTPHost.Text = C.SMTPHost
        txtSMTPPass.Text = C.SMTPPass
        txtSMTPPort.Text = C.SMTPPort
        txtSMTPUser.Text = C.SMTPUser
        chkSMTPSSL.Checked = C.SMTPSSL

    End Sub
#End Region

#Region "Botones Perfiles"
    Private Sub CmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim Nombre As String = ""
        Dim Config As Configuracion = New Configuracion()

        If InputBox.InputB(sTitulo, "Ingrese el nombre del perfil de configuración.", Nombre) = DialogResult.OK Then
            Config.Nombre = Nombre.Trim()
        Else
            Return
        End If

        If Not ValidateProfileName(Nombre.Trim()) Then
            Return
        End If

        Perfiles.Perfiles.Add(Config)
        ChargeCmbPerfiles(Config.ID)
    End Sub

    Private Sub CmdDuplicar_Click(sender As Object, e As EventArgs) Handles cmdDuplicar.Click
        If Perfiles.Perfiles.Count = 0 Then
            Return
        End If

        Dim Config As Configuracion
        Dim ConfigDupli As Configuracion
        Dim Nombre As String = ""

        If Not (InputB(sTitulo, "Ingrese el nombre del perfil de configuración.", Nombre) = DialogResult.OK) Then
            Return
        End If

        If Not ValidateProfileName(Nombre.Trim()) Then
            Return
        End If

        Config = GetSelectedProfile()
        ConfigDupli = New Configuracion With {
            .Nombre = Nombre.Trim(),
            .Para = Config.Para,
            .Asunto = Config.Asunto,
            .Mensaje = Config.Mensaje,
            .Adjunto = Config.Adjunto,
            .SMTPHost = Config.SMTPHost,
            .SMTPPass = Config.SMTPPass,
            .SMTPPort = Config.SMTPPort,
            .SMTPUser = Config.SMTPUser,
            .SMTPSSL = Config.SMTPSSL
        }
        Perfiles.Perfiles.Add(ConfigDupli)
        ChargeCmbPerfiles(ConfigDupli.ID)
    End Sub

    Private Sub CmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If Perfiles.Perfiles.Count = 0 Then
            Return
        End If

        Dim index As String = cmbPerfiles.SelectedValue.ToString()
        Dim Nombre As String = ""

        If Not (InputBox.InputB(sTitulo, "Ingrese el nombre del perfil de configuración.", Nombre) = DialogResult.OK) Then
            Return
        End If

        If Not ValidateProfileName(Nombre.Trim()) Then
            Return
        End If

        Perfiles.Perfiles.Find(Function(p) p.ID = index).Nombre = Nombre
        ChargeCmbPerfiles(index)
    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If Perfiles.Perfiles.Count > 0 Then

            If MessageBox.Show("¿Está seguro de que desea eliminar el perfil de configuración '" & cmbPerfiles.Text & "' permanentemente?", "TXT Validator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Perfiles.Perfiles.Remove(Perfiles.Perfiles.Find(Function(p) p.ID = cmbPerfiles.SelectedValue.ToString()))
                ChargeCmbPerfiles()
            End If
        End If
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        SaveSettings()
    End Sub

    Private Sub CmbPerfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPerfiles.SelectedIndexChanged

        If cmbPerfiles.SelectedValue Is Nothing Then
            Return
        End If

        If cmbPerfiles.SelectedValue.[GetType]() = GetType(String) AndAlso cmbPerfiles.SelectedValue.ToString().Length > 0 Then
            LoadSettings()
        End If

    End Sub

#End Region

    Private Sub TxtSMTPPort_Validating(sender As Object, e As CancelEventArgs) Handles txtSMTPPort.Validating
        e.Cancel = Not IsTextInteger(CType(sender, TextBox))
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

    Private Function IsTextInteger(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) AndAlso CInt(target.Text) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
