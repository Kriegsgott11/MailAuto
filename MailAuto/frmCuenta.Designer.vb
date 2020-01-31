<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuenta))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSMTPSSL = New System.Windows.Forms.CheckBox()
        Me.txtSMTPHost = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSMTPUser = New System.Windows.Forms.TextBox()
        Me.txtSMTPPass = New System.Windows.Forms.TextBox()
        Me.txtMailAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SMTP Host"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SMTP Port"
        '
        'chkSMTPSSL
        '
        Me.chkSMTPSSL.AutoSize = True
        Me.chkSMTPSSL.Location = New System.Drawing.Point(203, 121)
        Me.chkSMTPSSL.Name = "chkSMTPSSL"
        Me.chkSMTPSSL.Size = New System.Drawing.Size(79, 17)
        Me.chkSMTPSSL.TabIndex = 4
        Me.chkSMTPSSL.Text = "SMTP SSL"
        Me.chkSMTPSSL.UseVisualStyleBackColor = True
        '
        'txtSMTPHost
        '
        Me.txtSMTPHost.Location = New System.Drawing.Point(203, 69)
        Me.txtSMTPHost.MaxLength = 255
        Me.txtSMTPHost.Name = "txtSMTPHost"
        Me.txtSMTPHost.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPHost.TabIndex = 2
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Location = New System.Drawing.Point(203, 95)
        Me.txtSMTPPort.MaxLength = 10
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPPort.TabIndex = 3
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardar.Location = New System.Drawing.Point(359, 214)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 22
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "SMTP Authorization User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SMTP Authorization Password"
        '
        'txtSMTPUser
        '
        Me.txtSMTPUser.Location = New System.Drawing.Point(203, 144)
        Me.txtSMTPUser.MaxLength = 255
        Me.txtSMTPUser.Name = "txtSMTPUser"
        Me.txtSMTPUser.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPUser.TabIndex = 5
        '
        'txtSMTPPass
        '
        Me.txtSMTPPass.Location = New System.Drawing.Point(203, 170)
        Me.txtSMTPPass.MaxLength = 255
        Me.txtSMTPPass.Name = "txtSMTPPass"
        Me.txtSMTPPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTPPass.Size = New System.Drawing.Size(194, 20)
        Me.txtSMTPPass.TabIndex = 6
        '
        'txtMailAddress
        '
        Me.txtMailAddress.Location = New System.Drawing.Point(203, 43)
        Me.txtMailAddress.MaxLength = 255
        Me.txtMailAddress.Name = "txtMailAddress"
        Me.txtMailAddress.Size = New System.Drawing.Size(194, 20)
        Me.txtMailAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mail Address"
        '
        'frmCuenta
        '
        Me.AcceptButton = Me.cmdGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 249)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMailAddress)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtSMTPPass)
        Me.Controls.Add(Me.txtSMTPUser)
        Me.Controls.Add(Me.txtSMTPPort)
        Me.Controls.Add(Me.txtSMTPHost)
        Me.Controls.Add(Me.chkSMTPSSL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkSMTPSSL As CheckBox
    Friend WithEvents txtSMTPHost As TextBox
    Friend WithEvents txtSMTPPort As TextBox
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSMTPUser As TextBox
    Friend WithEvents txtSMTPPass As TextBox
    Friend WithEvents txtMailAddress As TextBox
    Friend WithEvents Label1 As Label
End Class
