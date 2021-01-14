<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacora
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBitacora))
        Me.dgvBitacora = New System.Windows.Forms.DataGridView()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComputadoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerBtacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMediwareDataSet = New MediWare.BDMediwareDataSet()
        Me.VerBtacoraTableAdapter = New MediWare.BDMediwareDataSetTableAdapters.VerBtacoraTableAdapter()
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerBtacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBitacora
        '
        Me.dgvBitacora.AllowUserToAddRows = False
        Me.dgvBitacora.AllowUserToDeleteRows = False
        Me.dgvBitacora.AllowUserToOrderColumns = True
        Me.dgvBitacora.AutoGenerateColumns = False
        Me.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvBitacora.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioDataGridViewTextBoxColumn, Me.ComputadoraDataGridViewTextBoxColumn, Me.EventoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.dgvBitacora.DataSource = Me.VerBtacoraBindingSource
        Me.dgvBitacora.Location = New System.Drawing.Point(7, 167)
        Me.dgvBitacora.MultiSelect = False
        Me.dgvBitacora.Name = "dgvBitacora"
        Me.dgvBitacora.ReadOnly = True
        Me.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBitacora.Size = New System.Drawing.Size(833, 330)
        Me.dgvBitacora.TabIndex = 0
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComputadoraDataGridViewTextBoxColumn
        '
        Me.ComputadoraDataGridViewTextBoxColumn.DataPropertyName = "Computadora"
        Me.ComputadoraDataGridViewTextBoxColumn.HeaderText = "Computadora"
        Me.ComputadoraDataGridViewTextBoxColumn.Name = "ComputadoraDataGridViewTextBoxColumn"
        Me.ComputadoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EventoDataGridViewTextBoxColumn
        '
        Me.EventoDataGridViewTextBoxColumn.DataPropertyName = "Evento"
        Me.EventoDataGridViewTextBoxColumn.HeaderText = "Evento"
        Me.EventoDataGridViewTextBoxColumn.Name = "EventoDataGridViewTextBoxColumn"
        Me.EventoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VerBtacoraBindingSource
        '
        Me.VerBtacoraBindingSource.DataMember = "VerBtacora"
        Me.VerBtacoraBindingSource.DataSource = Me.BDMediwareDataSet
        '
        'BDMediwareDataSet
        '
        Me.BDMediwareDataSet.DataSetName = "BDMediwareDataSet"
        Me.BDMediwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerBtacoraTableAdapter
        '
        Me.VerBtacoraTableAdapter.ClearBeforeFill = True
        '
        'frmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 501)
        Me.Controls.Add(Me.dgvBitacora)
        Me.Name = "frmBitacora"
        Me.Text = "Bitacora"
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerBtacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBitacora As DataGridView
    Friend WithEvents BDMediwareDataSet As BDMediwareDataSet
    Friend WithEvents VerBtacoraBindingSource As BindingSource
    Friend WithEvents VerBtacoraTableAdapter As BDMediwareDataSetTableAdapters.VerBtacoraTableAdapter
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComputadoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
