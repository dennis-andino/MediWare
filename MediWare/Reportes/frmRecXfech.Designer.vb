<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecXfech
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
        Me.CRVrecxFech = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVrecxFech
        '
        Me.CRVrecxFech.ActiveViewIndex = -1
        Me.CRVrecxFech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVrecxFech.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVrecxFech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVrecxFech.Location = New System.Drawing.Point(0, 0)
        Me.CRVrecxFech.Name = "CRVrecxFech"
        Me.CRVrecxFech.Size = New System.Drawing.Size(800, 450)
        Me.CRVrecxFech.TabIndex = 0
        Me.CRVrecxFech.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRecXfech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CRVrecxFech)
        Me.Name = "frmRecXfech"
        Me.Text = "Reclamos por Fecha"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVrecxFech As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
