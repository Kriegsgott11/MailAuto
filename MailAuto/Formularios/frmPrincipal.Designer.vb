<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdjunto = New System.Windows.Forms.TextBox()
        Me.cmdSelAdjunto = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivoDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarArchivoDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxPerfiles = New System.Windows.Forms.GroupBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdDuplicar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPerfiles = New System.Windows.Forms.ComboBox()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabCorreo = New System.Windows.Forms.TabPage()
        Me.TabCuenta = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMailAddress = New System.Windows.Forms.TextBox()
        Me.txtSMTPPass = New System.Windows.Forms.TextBox()
        Me.txtSMTPUser = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.txtSMTPHost = New System.Windows.Forms.TextBox()
        Me.chkSMTPSSL = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxPerfiles.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TabCorreo.SuspendLayout()
        Me.TabCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPara
        '
        Me.txtPara.Location = New System.Drawing.Point(83, 70)
        Me.txtPara.MaxLength = 255
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(448, 20)
        Me.txtPara.TabIndex = 0
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(83, 96)
        Me.txtAsunto.MaxLength = 255
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(448, 20)
        Me.txtAsunto.TabIndex = 1
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(83, 122)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMensaje.Size = New System.Drawing.Size(448, 184)
        Me.txtMensaje.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Para"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Asunto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mensaje"
        '
        'cmdEnviar
        '
        Me.cmdEnviar.Location = New System.Drawing.Point(445, 19)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(86, 45)
        Me.cmdEnviar.TabIndex = 5
        Me.cmdEnviar.Text = "Enviar"
        Me.cmdEnviar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Adjunto"
        '
        'txtAdjunto
        '
        Me.txtAdjunto.Location = New System.Drawing.Point(83, 312)
        Me.txtAdjunto.Name = "txtAdjunto"
        Me.txtAdjunto.Size = New System.Drawing.Size(418, 20)
        Me.txtAdjunto.TabIndex = 3
        '
        'cmdSelAdjunto
        '
        Me.cmdSelAdjunto.Location = New System.Drawing.Point(507, 310)
        Me.cmdSelAdjunto.Name = "cmdSelAdjunto"
        Me.cmdSelAdjunto.Size = New System.Drawing.Size(24, 23)
        Me.cmdSelAdjunto.TabIndex = 11
        Me.cmdSelAdjunto.Text = "..."
        Me.cmdSelAdjunto.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerArchivoDeErroresToolStripMenuItem, Me.VaciarArchivoDeErroresToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'VerArchivoDeErroresToolStripMenuItem
        '
        Me.VerArchivoDeErroresToolStripMenuItem.Name = "VerArchivoDeErroresToolStripMenuItem"
        Me.VerArchivoDeErroresToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VerArchivoDeErroresToolStripMenuItem.Text = "Ver Archivo de errores"
        '
        'VaciarArchivoDeErroresToolStripMenuItem
        '
        Me.VaciarArchivoDeErroresToolStripMenuItem.Name = "VaciarArchivoDeErroresToolStripMenuItem"
        Me.VaciarArchivoDeErroresToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VaciarArchivoDeErroresToolStripMenuItem.Text = "Vaciar Archivo de errores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SalirToolStripMenuItem.Text = "Guardar y salir"
        '
        'gbxPerfiles
        '
        Me.gbxPerfiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPerfiles.Controls.Add(Me.cmdGuardar)
        Me.gbxPerfiles.Controls.Add(Me.cmdDuplicar)
        Me.gbxPerfiles.Controls.Add(Me.cmdEliminar)
        Me.gbxPerfiles.Controls.Add(Me.cmdEditar)
        Me.gbxPerfiles.Controls.Add(Me.cmdAgregar)
        Me.gbxPerfiles.Controls.Add(Me.Label5)
        Me.gbxPerfiles.Controls.Add(Me.cmbPerfiles)
        Me.gbxPerfiles.Location = New System.Drawing.Point(12, 27)
        Me.gbxPerfiles.Name = "gbxPerfiles"
        Me.gbxPerfiles.Size = New System.Drawing.Size(564, 63)
        Me.gbxPerfiles.TabIndex = 16
        Me.gbxPerfiles.TabStop = False
        Me.gbxPerfiles.Text = "Perfiles"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(481, 17)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(54, 23)
        Me.cmdGuardar.TabIndex = 6
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdDuplicar
        '
        Me.cmdDuplicar.Location = New System.Drawing.Point(421, 17)
        Me.cmdDuplicar.Name = "cmdDuplicar"
        Me.cmdDuplicar.Size = New System.Drawing.Size(54, 23)
        Me.cmdDuplicar.TabIndex = 5
        Me.cmdDuplicar.Text = "Duplicar"
        Me.cmdDuplicar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(361, 17)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(54, 23)
        Me.cmdEliminar.TabIndex = 4
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(301, 17)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(54, 23)
        Me.cmdEditar.TabIndex = 3
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(241, 17)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(54, 23)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Perfil"
        '
        'cmbPerfiles
        '
        Me.cmbPerfiles.FormattingEnabled = True
        Me.cmbPerfiles.Location = New System.Drawing.Point(99, 19)
        Me.cmbPerfiles.Name = "cmbPerfiles"
        Me.cmbPerfiles.Size = New System.Drawing.Size(121, 21)
        Me.cmbPerfiles.TabIndex = 0
        '
        'TabMain
        '
        Me.TabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMain.Controls.Add(Me.TabCorreo)
        Me.TabMain.Controls.Add(Me.TabCuenta)
        Me.TabMain.Location = New System.Drawing.Point(12, 96)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(564, 376)
        Me.TabMain.TabIndex = 17
        '
        'TabCorreo
        '
        Me.TabCorreo.Controls.Add(Me.txtPara)
        Me.TabCorreo.Controls.Add(Me.txtAsunto)
        Me.TabCorreo.Controls.Add(Me.cmdSelAdjunto)
        Me.TabCorreo.Controls.Add(Me.txtMensaje)
        Me.TabCorreo.Controls.Add(Me.cmdEnviar)
        Me.TabCorreo.Controls.Add(Me.Label4)
        Me.TabCorreo.Controls.Add(Me.Label1)
        Me.TabCorreo.Controls.Add(Me.txtAdjunto)
        Me.TabCorreo.Controls.Add(Me.Label2)
        Me.TabCorreo.Controls.Add(Me.Label3)
        Me.TabCorreo.Location = New System.Drawing.Point(4, 22)
        Me.TabCorreo.Name = "TabCorreo"
        Me.TabCorreo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCorreo.Size = New System.Drawing.Size(556, 350)
        Me.TabCorreo.TabIndex = 0
        Me.TabCorreo.Text = "Correo"
        Me.TabCorreo.UseVisualStyleBackColor = True
        '
        'TabCuenta
        '
        Me.TabCuenta.Controls.Add(Me.Label6)
        Me.TabCuenta.Controls.Add(Me.txtMailAddress)
        Me.TabCuenta.Controls.Add(Me.txtSMTPPass)
        Me.TabCuenta.Controls.Add(Me.txtSMTPUser)
        Me.TabCuenta.Controls.Add(Me.txtSMTPPort)
        Me.TabCuenta.Controls.Add(Me.txtSMTPHost)
        Me.TabCuenta.Controls.Add(Me.chkSMTPSSL)
        Me.TabCuenta.Controls.Add(Me.Label9)
        Me.TabCuenta.Controls.Add(Me.Label8)
        Me.TabCuenta.Controls.Add(Me.Label7)
        Me.TabCuenta.Controls.Add(Me.Label10)
        Me.TabCuenta.Location = New System.Drawing.Point(4, 22)
        Me.TabCuenta.Name = "TabCuenta"
        Me.TabCuenta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCuenta.Size = New System.Drawing.Size(556, 350)
        Me.TabCuenta.TabIndex = 1
        Me.TabCuenta.Text = "Cuenta"
        Me.TabCuenta.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Mail Address"
        '
        'txtMailAddress
        '
        Me.txtMailAddress.Location = New System.Drawing.Point(253, 99)
        Me.txtMailAddress.MaxLength = 255
        Me.txtMailAddress.Name = "txtMailAddress"
        Me.txtMailAddress.Size = New System.Drawing.Size(194, 20)
        Me.txtMailAddress.TabIndex = 25
        '
        'txtSMTPPass
        '
        Me.txtSMTPPass.Location = New System.Drawing.Point(253, 226)
        Me.txtSMTPPass.MaxLength = 255
        Me.txtSMTPPass.Name = "txtSMTPPass"
        Me.txtSMTPPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTPPass.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPPass.TabIndex = 32
        '
        'txtSMTPUser
        '
        Me.txtSMTPUser.Location = New System.Drawing.Point(253, 200)
        Me.txtSMTPUser.MaxLength = 255
        Me.txtSMTPUser.Name = "txtSMTPUser"
        Me.txtSMTPUser.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPUser.TabIndex = 31
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Location = New System.Drawing.Point(253, 151)
        Me.txtSMTPPort.MaxLength = 10
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPPort.TabIndex = 28
        '
        'txtSMTPHost
        '
        Me.txtSMTPHost.Location = New System.Drawing.Point(253, 125)
        Me.txtSMTPHost.MaxLength = 255
        Me.txtSMTPHost.Name = "txtSMTPHost"
        Me.txtSMTPHost.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPHost.TabIndex = 26
        '
        'chkSMTPSSL
        '
        Me.chkSMTPSSL.AutoSize = True
        Me.chkSMTPSSL.Location = New System.Drawing.Point(253, 177)
        Me.chkSMTPSSL.Name = "chkSMTPSSL"
        Me.chkSMTPSSL.Size = New System.Drawing.Size(79, 17)
        Me.chkSMTPSSL.TabIndex = 30
        Me.chkSMTPSSL.Text = "SMTP SSL"
        Me.chkSMTPSSL.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(95, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "SMTP Authorization Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "SMTP Authorization User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "SMTP Port"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(95, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "SMTP Host"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 484)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.gbxPerfiles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MailAuto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxPerfiles.ResumeLayout(False)
        Me.gbxPerfiles.PerformLayout()
        Me.TabMain.ResumeLayout(False)
        Me.TabCorreo.ResumeLayout(False)
        Me.TabCorreo.PerformLayout()
        Me.TabCuenta.ResumeLayout(False)
        Me.TabCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPara As TextBox
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdEnviar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdjunto As TextBox
    Friend WithEvents cmdSelAdjunto As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerArchivoDeErroresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VaciarArchivoDeErroresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Private WithEvents gbxPerfiles As GroupBox
    Private WithEvents cmdGuardar As Button
    Private WithEvents cmdDuplicar As Button
    Private WithEvents cmdEliminar As Button
    Private WithEvents cmdEditar As Button
    Private WithEvents cmdAgregar As Button
    Private WithEvents Label5 As Label
    Private WithEvents cmbPerfiles As ComboBox
    Friend WithEvents TabMain As TabControl
    Friend WithEvents TabCorreo As TabPage
    Friend WithEvents TabCuenta As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMailAddress As TextBox
    Friend WithEvents txtSMTPPass As TextBox
    Friend WithEvents txtSMTPUser As TextBox
    Friend WithEvents txtSMTPPort As TextBox
    Friend WithEvents txtSMTPHost As TextBox
    Friend WithEvents chkSMTPSSL As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
End Class
