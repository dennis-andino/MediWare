<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecMax
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
        Me.CRVmaxRec = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVmaxRec
        '
        Me.CRVmaxRec.ActiveViewIndex = -1
        Me.CRVmaxRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVmaxRec.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVmaxRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVmaxRec.Location = New System.Drawing.Point(0, 0)
        Me.CRVmaxRec.Name = "CRVmaxRec"
        Me.CRVmaxRec.Size = New System.Drawing.Size(800, 450)
        Me.CRVmaxRec.TabIndex = 0
        Me.CRVmaxRec.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRecMax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CRVmaxRec)
        Me.Name = "frmRecMax"
        Me.Text = "Reclamo Mas Costoso"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVmaxRec As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
