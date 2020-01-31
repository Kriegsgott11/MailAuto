Public Class frmPrincipal
    Private mConfig As Configuracion

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mConfig = Load_Config()
    End Sub

    Private Sub CmdConfigurarCuenta_Click(sender As Object, e As EventArgs) Handles cmdConfigurarCuenta.Click
        Dim FormCuenta As New frmCuenta(mConfig)
        If FormCuenta.ShowDialog() = DialogResult.OK Then
            mConfig = Load_Config()
            CargarDatos()
        End If
    End Sub

    Private Sub FrmPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CargarDatos()
    End Sub

    Private Sub CmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        If GuardarDatos() Then
            Send_Mail(mConfig)
        End If
    End Sub

    Private Sub CargarDatos()
        If mConfig Is Nothing Then
            Return
        End If

        With mConfig
            txtPara.Text = .Para
            txtAsunto.Text = .Asunto
            txtMensaje.Text = .Mensaje
            txtAdjunto.Text = .Adjunto
            lblCuenta.Text = "Cuenta de correo: " & .MailAddress
        End With
    End Sub

    Private Function GuardarDatos() As Boolean
        If mConfig Is Nothing Then
            mConfig = New Configuracion
        End If

        With mConfig
            .Para = txtPara.Text
            .Asunto = txtAsunto.Text
            .Mensaje = txtMensaje.Text
            .Adjunto = txtAdjunto.Text
        End With

        Return Save_Config(mConfig)
    End Function

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
        GuardarDatos()
        Me.Close()
    End Sub

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
End Class
