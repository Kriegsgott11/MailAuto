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
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.cmdConfigurarCuenta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdjunto = New System.Windows.Forms.TextBox()
        Me.cmdSelAdjunto = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivoDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarArchivoDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPara
        '
        Me.txtPara.Location = New System.Drawing.Point(77, 117)
        Me.txtPara.MaxLength = 255
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(496, 20)
        Me.txtPara.TabIndex = 0
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(77, 143)
        Me.txtAsunto.MaxLength = 255
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(496, 20)
        Me.txtAsunto.TabIndex = 1
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(77, 172)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMensaje.Size = New System.Drawing.Size(496, 161)
        Me.txtMensaje.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Para"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Asunto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mensaje"
        '
        'cmdEnviar
        '
        Me.cmdEnviar.Location = New System.Drawing.Point(487, 53)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(86, 45)
        Me.cmdEnviar.TabIndex = 5
        Me.cmdEnviar.Text = "Enviar"
        Me.cmdEnviar.UseVisualStyleBackColor = True
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(24, 69)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(161, 13)
        Me.lblCuenta.TabIndex = 7
        Me.lblCuenta.Text = "Cuenta de correo: Sin Configurar"
        '
        'cmdConfigurarCuenta
        '
        Me.cmdConfigurarCuenta.Location = New System.Drawing.Point(27, 39)
        Me.cmdConfigurarCuenta.Name = "cmdConfigurarCuenta"
        Me.cmdConfigurarCuenta.Size = New System.Drawing.Size(118, 23)
        Me.cmdConfigurarCuenta.TabIndex = 4
        Me.cmdConfigurarCuenta.Text = "Configurar Cuenta"
        Me.cmdConfigurarCuenta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Adjunto"
        '
        'txtAdjunto
        '
        Me.txtAdjunto.Location = New System.Drawing.Point(77, 339)
        Me.txtAdjunto.Name = "txtAdjunto"
        Me.txtAdjunto.Size = New System.Drawing.Size(466, 20)
        Me.txtAdjunto.TabIndex = 3
        '
        'cmdSelAdjunto
        '
        Me.cmdSelAdjunto.Location = New System.Drawing.Point(549, 337)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
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
        Me.VerArchivoDeErroresToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.VerArchivoDeErroresToolStripMenuItem.Text = "Ver Archivo de errores"
        '
        'VaciarArchivoDeErroresToolStripMenuItem
        '
        Me.VaciarArchivoDeErroresToolStripMenuItem.Name = "VaciarArchivoDeErroresToolStripMenuItem"
        Me.VaciarArchivoDeErroresToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.VaciarArchivoDeErroresToolStripMenuItem.Text = "Vaciar Archivo de errores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SalirToolStripMenuItem.Text = "Guardar y salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 380)
        Me.Controls.Add(Me.cmdSelAdjunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdjunto)
        Me.Controls.Add(Me.cmdConfigurarCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.cmdEnviar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MailAuto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents lblCuenta As Label
    Friend WithEvents cmdConfigurarCuenta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdjunto As TextBox
    Friend WithEvents cmdSelAdjunto As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerArchivoDeErroresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VaciarArchivoDeErroresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
