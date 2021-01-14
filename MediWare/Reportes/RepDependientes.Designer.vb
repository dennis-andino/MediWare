<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDependientes
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
        Me.CRDependientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRDependientes
        '
        Me.CRDependientes.ActiveViewIndex = -1
        Me.CRDependientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRDependientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRDependientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRDependientes.Location = New System.Drawing.Point(0, 0)
        Me.CRDependientes.Name = "CRDependientes"
        Me.CRDependientes.Size = New System.Drawing.Size(887, 624)
        Me.CRDependientes.TabIndex = 0
        Me.CRDependientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepDependientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 624)
        Me.Controls.Add(Me.CRDependientes)
        Me.Name = "RepDependientes"
        Me.Text = "Reporte de Dependientes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRDependientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
