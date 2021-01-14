<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnAsegurado = New System.Windows.Forms.Button()
        Me.btnBitacora = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbReportes = New System.Windows.Forms.GroupBox()
        Me.btnDepReport = New System.Windows.Forms.Button()
        Me.tnReclamos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPoliza = New System.Windows.Forms.Button()
        Me.btnRepRxf = New System.Windows.Forms.Button()
        Me.gbReportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAsegurado
        '
        Me.btnAsegurado.BackgroundImage = CType(resources.GetObject("btnAsegurado.BackgroundImage"), System.Drawing.Image)
        Me.btnAsegurado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsegurado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsegurado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAsegurado.Location = New System.Drawing.Point(330, 229)
        Me.btnAsegurado.Name = "btnAsegurado"
        Me.btnAsegurado.Size = New System.Drawing.Size(111, 118)
        Me.btnAsegurado.TabIndex = 0
        Me.btnAsegurado.Text = "Asegurado"
        Me.btnAsegurado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAsegurado.UseVisualStyleBackColor = True
        '
        'btnBitacora
        '
        Me.btnBitacora.BackgroundImage = CType(resources.GetObject("btnBitacora.BackgroundImage"), System.Drawing.Image)
        Me.btnBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBitacora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBitacora.Location = New System.Drawing.Point(531, 210)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(111, 137)
        Me.btnBitacora.TabIndex = 1
        Me.btnBitacora.Text = "Bitacora"
        Me.btnBitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBitacora.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.Location = New System.Drawing.Point(109, 210)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(111, 137)
        Me.btnReportes.TabIndex = 2
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(591, 457)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 67)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gbReportes
        '
        Me.gbReportes.BackColor = System.Drawing.Color.Transparent
        Me.gbReportes.Controls.Add(Me.btnRepRxf)
        Me.gbReportes.Controls.Add(Me.btnPoliza)
        Me.gbReportes.Controls.Add(Me.Button1)
        Me.gbReportes.Controls.Add(Me.tnReclamos)
        Me.gbReportes.Controls.Add(Me.btnDepReport)
        Me.gbReportes.Location = New System.Drawing.Point(2, 435)
        Me.gbReportes.Name = "gbReportes"
        Me.gbReportes.Size = New System.Drawing.Size(555, 116)
        Me.gbReportes.TabIndex = 4
        Me.gbReportes.TabStop = False
        Me.gbReportes.Text = "Reportes"
        Me.gbReportes.Visible = False
        '
        'btnDepReport
        '
        Me.btnDepReport.BackgroundImage = CType(resources.GetObject("btnDepReport.BackgroundImage"), System.Drawing.Image)
        Me.btnDepReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDepReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDepReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDepReport.Location = New System.Drawing.Point(6, 13)
        Me.btnDepReport.Name = "btnDepReport"
        Me.btnDepReport.Size = New System.Drawing.Size(110, 97)
        Me.btnDepReport.TabIndex = 0
        Me.btnDepReport.Text = "Dependientes"
        Me.btnDepReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDepReport.UseVisualStyleBackColor = True
        '
        'tnReclamos
        '
        Me.tnReclamos.BackgroundImage = CType(resources.GetObject("tnReclamos.BackgroundImage"), System.Drawing.Image)
        Me.tnReclamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tnReclamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnReclamos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tnReclamos.Location = New System.Drawing.Point(122, 13)
        Me.tnReclamos.Name = "tnReclamos"
        Me.tnReclamos.Size = New System.Drawing.Size(111, 97)
        Me.tnReclamos.TabIndex = 1
        Me.tnReclamos.Text = "Reclamos"
        Me.tnReclamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tnReclamos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(239, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 97)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reclamo Mas Costoso"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPoliza
        '
        Me.btnPoliza.BackgroundImage = CType(resources.GetObject("btnPoliza.BackgroundImage"), System.Drawing.Image)
        Me.btnPoliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPoliza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoliza.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPoliza.Location = New System.Drawing.Point(449, 13)
        Me.btnPoliza.Name = "btnPoliza"
        Me.btnPoliza.Size = New System.Drawing.Size(100, 97)
        Me.btnPoliza.TabIndex = 3
        Me.btnPoliza.Text = "Polizas"
        Me.btnPoliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPoliza.UseVisualStyleBackColor = True
        '
        'btnRepRxf
        '
        Me.btnRepRxf.BackgroundImage = CType(resources.GetObject("btnRepRxf.BackgroundImage"), System.Drawing.Image)
        Me.btnRepRxf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRepRxf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRepRxf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepRxf.Location = New System.Drawing.Point(344, 13)
        Me.btnRepRxf.Name = "btnRepRxf"
        Me.btnRepRxf.Size = New System.Drawing.Size(99, 97)
        Me.btnRepRxf.TabIndex = 4
        Me.btnRepRxf.Text = "Reclamos Por Fecha"
        Me.btnRepRxf.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 563)
        Me.Controls.Add(Me.gbReportes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnBitacora)
        Me.Controls.Add(Me.btnAsegurado)
        Me.DoubleBuffered = True
        Me.Name = "frmPrincipal"
        Me.Text = "MediWare"
        Me.gbReportes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAsegurado As Button
    Friend WithEvents btnBitacora As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbReportes As GroupBox
    Friend WithEvents btnDepReport As Button
    Friend WithEvents tnReclamos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPoliza As Button
    Friend WithEvents btnRepRxf As Button
End Class
