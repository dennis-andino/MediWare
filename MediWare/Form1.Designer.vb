<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txtUsuarioL = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtClaveL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtUsuarioL
        '
        Me.txtUsuarioL.BackColor = System.Drawing.Color.DarkGray
        Me.txtUsuarioL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuarioL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuarioL.Location = New System.Drawing.Point(89, 196)
        Me.txtUsuarioL.Name = "txtUsuarioL"
        Me.txtUsuarioL.Size = New System.Drawing.Size(262, 19)
        Me.txtUsuarioL.TabIndex = 0
        Me.txtUsuarioL.Text = "0801199318270"
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(55, 286)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(304, 42)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Iniciar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtClaveL
        '
        Me.txtClaveL.BackColor = System.Drawing.Color.DarkGray
        Me.txtClaveL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClaveL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtClaveL.Location = New System.Drawing.Point(89, 250)
        Me.txtClaveL.MaxLength = 10
        Me.txtClaveL.Name = "txtClaveL"
        Me.txtClaveL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveL.Size = New System.Drawing.Size(262, 19)
        Me.txtClaveL.TabIndex = 2
        Me.txtClaveL.Text = "password"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 497)
        Me.Controls.Add(Me.txtClaveL)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUsuarioL)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuarioL As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtClaveL As TextBox
End Class
