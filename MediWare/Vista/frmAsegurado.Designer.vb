<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsegurado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsegurado))
        Me.gbDataAseg = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtConyugue = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbEstadoCivil = New System.Windows.Forms.GroupBox()
        Me.rbV = New System.Windows.Forms.RadioButton()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbS = New System.Windows.Forms.RadioButton()
        Me.gbGenero = New System.Windows.Forms.GroupBox()
        Me.rdF = New System.Windows.Forms.RadioButton()
        Me.rbM = New System.Windows.Forms.RadioButton()
        Me.cbbCiuNac = New System.Windows.Forms.ComboBox()
        Me.cbbDeptoNac = New System.Windows.Forms.ComboBox()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.txtfechaNac = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.dgvAseg = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnElim = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTiemAseg = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNomAseg = New System.Windows.Forms.TextBox()
        Me.gbSeguro = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTiempoL = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtWebEmp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNomEmp = New System.Windows.Forms.TextBox()
        Me.cbbCiuRes = New System.Windows.Forms.ComboBox()
        Me.cbbDeptoRes = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDirComp = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.BDMediwareDataSet = New MediWare.BDMediwareDataSet()
        Me.BDMediwareDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMediwareDataSet1 = New MediWare.BDMediwareDataSet1()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New MediWare.BDMediwareDataSet1TableAdapters.DepartamentoTableAdapter()
        Me.BDMediwareDataSet2 = New MediWare.BDMediwareDataSet2()
        Me.CiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesTableAdapter = New MediWare.BDMediwareDataSet2TableAdapters.CiudadesTableAdapter()
        Me.BDMediwareDataSet3 = New MediWare.BDMediwareDataSet3()
        Me.DepartamentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter1 = New MediWare.BDMediwareDataSet3TableAdapters.DepartamentoTableAdapter()
        Me.BDMediwareDataSet4 = New MediWare.BDMediwareDataSet4()
        Me.CiudadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesTableAdapter1 = New MediWare.BDMediwareDataSet4TableAdapters.CiudadesTableAdapter()
        Me.gbDataAseg.SuspendLayout()
        Me.gbEstadoCivil.SuspendLayout()
        Me.gbGenero.SuspendLayout()
        CType(Me.dgvAseg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbSeguro.SuspendLayout()
        CType(Me.BDMediwareDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMediwareDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDataAseg
        '
        Me.gbDataAseg.BackColor = System.Drawing.Color.Transparent
        Me.gbDataAseg.Controls.Add(Me.Label10)
        Me.gbDataAseg.Controls.Add(Me.txtPais)
        Me.gbDataAseg.Controls.Add(Me.txtConyugue)
        Me.gbDataAseg.Controls.Add(Me.Label14)
        Me.gbDataAseg.Controls.Add(Me.gbEstadoCivil)
        Me.gbDataAseg.Controls.Add(Me.gbGenero)
        Me.gbDataAseg.Controls.Add(Me.cbbCiuNac)
        Me.gbDataAseg.Controls.Add(Me.cbbDeptoNac)
        Me.gbDataAseg.Controls.Add(Me.lbl_Id)
        Me.gbDataAseg.Controls.Add(Me.Label9)
        Me.gbDataAseg.Controls.Add(Me.Label8)
        Me.gbDataAseg.Controls.Add(Me.Label7)
        Me.gbDataAseg.Controls.Add(Me.Label6)
        Me.gbDataAseg.Controls.Add(Me.Label5)
        Me.gbDataAseg.Controls.Add(Me.Label4)
        Me.gbDataAseg.Controls.Add(Me.Label3)
        Me.gbDataAseg.Controls.Add(Me.Label2)
        Me.gbDataAseg.Controls.Add(Me.Label1)
        Me.gbDataAseg.Controls.Add(Me.txtNombre1)
        Me.gbDataAseg.Controls.Add(Me.txtfechaNac)
        Me.gbDataAseg.Controls.Add(Me.txtApellido1)
        Me.gbDataAseg.Controls.Add(Me.txtAltura)
        Me.gbDataAseg.Controls.Add(Me.txtPeso)
        Me.gbDataAseg.Controls.Add(Me.txtDni)
        Me.gbDataAseg.Location = New System.Drawing.Point(12, 69)
        Me.gbDataAseg.Name = "gbDataAseg"
        Me.gbDataAseg.Size = New System.Drawing.Size(440, 214)
        Me.gbDataAseg.TabIndex = 0
        Me.gbDataAseg.TabStop = False
        Me.gbDataAseg.Text = "Informacion de Asegurado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Nacionalidad"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(297, 67)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(111, 20)
        Me.txtPais.TabIndex = 38
        '
        'txtConyugue
        '
        Me.txtConyugue.Enabled = False
        Me.txtConyugue.Location = New System.Drawing.Point(171, 188)
        Me.txtConyugue.Name = "txtConyugue"
        Me.txtConyugue.Size = New System.Drawing.Size(237, 20)
        Me.txtConyugue.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Nombre Completo de conyugue"
        '
        'gbEstadoCivil
        '
        Me.gbEstadoCivil.Controls.Add(Me.rbV)
        Me.gbEstadoCivil.Controls.Add(Me.rbC)
        Me.gbEstadoCivil.Controls.Add(Me.rbS)
        Me.gbEstadoCivil.Location = New System.Drawing.Point(277, 137)
        Me.gbEstadoCivil.Name = "gbEstadoCivil"
        Me.gbEstadoCivil.Size = New System.Drawing.Size(131, 45)
        Me.gbEstadoCivil.TabIndex = 37
        Me.gbEstadoCivil.TabStop = False
        Me.gbEstadoCivil.Text = "Estado Civil"
        '
        'rbV
        '
        Me.rbV.AutoSize = True
        Me.rbV.Location = New System.Drawing.Point(86, 19)
        Me.rbV.Name = "rbV"
        Me.rbV.Size = New System.Drawing.Size(32, 17)
        Me.rbV.TabIndex = 35
        Me.rbV.TabStop = True
        Me.rbV.Text = "V"
        Me.rbV.UseVisualStyleBackColor = True
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(48, 19)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(32, 17)
        Me.rbC.TabIndex = 34
        Me.rbC.TabStop = True
        Me.rbC.Text = "C"
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbS
        '
        Me.rbS.AutoSize = True
        Me.rbS.Location = New System.Drawing.Point(10, 19)
        Me.rbS.Name = "rbS"
        Me.rbS.Size = New System.Drawing.Size(32, 17)
        Me.rbS.TabIndex = 33
        Me.rbS.TabStop = True
        Me.rbS.Text = "S"
        Me.rbS.UseVisualStyleBackColor = True
        '
        'gbGenero
        '
        Me.gbGenero.Controls.Add(Me.rdF)
        Me.gbGenero.Controls.Add(Me.rbM)
        Me.gbGenero.Location = New System.Drawing.Point(169, 137)
        Me.gbGenero.Name = "gbGenero"
        Me.gbGenero.Size = New System.Drawing.Size(88, 45)
        Me.gbGenero.TabIndex = 36
        Me.gbGenero.TabStop = False
        Me.gbGenero.Text = "Genero"
        '
        'rdF
        '
        Me.rdF.AutoSize = True
        Me.rdF.Location = New System.Drawing.Point(50, 19)
        Me.rdF.Name = "rdF"
        Me.rdF.Size = New System.Drawing.Size(31, 17)
        Me.rdF.TabIndex = 34
        Me.rdF.TabStop = True
        Me.rdF.Text = "F"
        Me.rdF.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Location = New System.Drawing.Point(10, 19)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(34, 17)
        Me.rbM.TabIndex = 33
        Me.rbM.TabStop = True
        Me.rbM.Text = "M"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'cbbCiuNac
        '
        Me.cbbCiuNac.DataSource = Me.CiudadesBindingSource1
        Me.cbbCiuNac.DisplayMember = "Ciu_nombre"
        Me.cbbCiuNac.FormattingEnabled = True
        Me.cbbCiuNac.Location = New System.Drawing.Point(289, 108)
        Me.cbbCiuNac.Name = "cbbCiuNac"
        Me.cbbCiuNac.Size = New System.Drawing.Size(119, 21)
        Me.cbbCiuNac.TabIndex = 32
        Me.cbbCiuNac.ValueMember = "ciu_Id"
        '
        'cbbDeptoNac
        '
        Me.cbbDeptoNac.DataSource = Me.DepartamentoBindingSource1
        Me.cbbDeptoNac.DisplayMember = "dep_nombre"
        Me.cbbDeptoNac.FormattingEnabled = True
        Me.cbbDeptoNac.Location = New System.Drawing.Point(145, 108)
        Me.cbbDeptoNac.Name = "cbbDeptoNac"
        Me.cbbDeptoNac.Size = New System.Drawing.Size(123, 21)
        Me.cbbDeptoNac.TabIndex = 31
        Me.cbbDeptoNac.ValueMember = "dep_Id"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(265, 28)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Id.TabIndex = 30
        Me.lbl_Id.Text = "#ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "DNI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Altura (cm)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "peso (Lbs)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Depto. Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Ciudad de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "#ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Fecha de Nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombres "
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(6, 67)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(148, 20)
        Me.txtNombre1.TabIndex = 20
        '
        'txtfechaNac
        '
        Me.txtfechaNac.Location = New System.Drawing.Point(6, 109)
        Me.txtfechaNac.Name = "txtfechaNac"
        Me.txtfechaNac.Size = New System.Drawing.Size(111, 20)
        Me.txtfechaNac.TabIndex = 15
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(160, 67)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(131, 20)
        Me.txtApellido1.TabIndex = 14
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(6, 149)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(68, 20)
        Me.txtAltura.TabIndex = 12
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(80, 149)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(68, 20)
        Me.txtPeso.TabIndex = 11
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(36, 28)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(111, 20)
        Me.txtDni.TabIndex = 10
        '
        'dgvAseg
        '
        Me.dgvAseg.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dgvAseg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAseg.Location = New System.Drawing.Point(12, 299)
        Me.dgvAseg.MultiSelect = False
        Me.dgvAseg.Name = "dgvAseg"
        Me.dgvAseg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAseg.Size = New System.Drawing.Size(953, 242)
        Me.dgvAseg.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 18)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(154, 28)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnElim
        '
        Me.BtnElim.Location = New System.Drawing.Point(337, 18)
        Me.BtnElim.Name = "BtnElim"
        Me.BtnElim.Size = New System.Drawing.Size(154, 28)
        Me.BtnElim.TabIndex = 3
        Me.BtnElim.Text = "Eliminar"
        Me.BtnElim.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(172, 18)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(154, 28)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTiemAseg)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtNomAseg)
        Me.GroupBox1.Controls.Add(Me.gbSeguro)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtTiempoL)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtWebEmp)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNomEmp)
        Me.GroupBox1.Controls.Add(Me.cbbCiuRes)
        Me.GroupBox1.Controls.Add(Me.cbbDeptoRes)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDirComp)
        Me.GroupBox1.Location = New System.Drawing.Point(512, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 214)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Otros Datos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(273, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Tiempo"
        '
        'txtTiemAseg
        '
        Me.txtTiemAseg.Location = New System.Drawing.Point(321, 110)
        Me.txtTiemAseg.Name = "txtTiemAseg"
        Me.txtTiemAseg.Size = New System.Drawing.Size(91, 20)
        Me.txtTiemAseg.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Nombre  de Aseguradora"
        '
        'txtNomAseg
        '
        Me.txtNomAseg.Location = New System.Drawing.Point(144, 103)
        Me.txtNomAseg.Name = "txtNomAseg"
        Me.txtNomAseg.Size = New System.Drawing.Size(121, 20)
        Me.txtNomAseg.TabIndex = 41
        '
        'gbSeguro
        '
        Me.gbSeguro.Controls.Add(Me.rbNo)
        Me.gbSeguro.Controls.Add(Me.rbSi)
        Me.gbSeguro.Location = New System.Drawing.Point(271, 61)
        Me.gbSeguro.Name = "gbSeguro"
        Me.gbSeguro.Size = New System.Drawing.Size(141, 42)
        Me.gbSeguro.TabIndex = 40
        Me.gbSeguro.TabStop = False
        Me.gbSeguro.Text = "Posee otro Seguro?"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(50, 19)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 34
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(10, 19)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 33
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(141, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Tiempo de laborar (años)"
        '
        'txtTiempoL
        '
        Me.txtTiempoL.Location = New System.Drawing.Point(144, 73)
        Me.txtTiempoL.Name = "txtTiempoL"
        Me.txtTiempoL.Size = New System.Drawing.Size(121, 20)
        Me.txtTiempoL.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Puesto de Trabajo"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(19, 73)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(116, 20)
        Me.txtPuesto.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(220, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Direccion Web"
        '
        'txtWebEmp
        '
        Me.txtWebEmp.Location = New System.Drawing.Point(220, 31)
        Me.txtWebEmp.Name = "txtWebEmp"
        Me.txtWebEmp.Size = New System.Drawing.Size(192, 20)
        Me.txtWebEmp.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Nombre de la Empresa Donde labora"
        '
        'txtNomEmp
        '
        Me.txtNomEmp.Location = New System.Drawing.Point(22, 31)
        Me.txtNomEmp.Name = "txtNomEmp"
        Me.txtNomEmp.Size = New System.Drawing.Size(192, 20)
        Me.txtNomEmp.TabIndex = 32
        '
        'cbbCiuRes
        '
        Me.cbbCiuRes.DataSource = Me.CiudadesBindingSource
        Me.cbbCiuRes.DisplayMember = "Ciu_nombre"
        Me.cbbCiuRes.FormattingEnabled = True
        Me.cbbCiuRes.Location = New System.Drawing.Point(170, 139)
        Me.cbbCiuRes.Name = "cbbCiuRes"
        Me.cbbCiuRes.Size = New System.Drawing.Size(142, 21)
        Me.cbbCiuRes.TabIndex = 31
        Me.cbbCiuRes.ValueMember = "ciu_Id"
        '
        'cbbDeptoRes
        '
        Me.cbbDeptoRes.DataSource = Me.DepartamentoBindingSource
        Me.cbbDeptoRes.DisplayMember = "dep_nombre"
        Me.cbbDeptoRes.FormattingEnabled = True
        Me.cbbDeptoRes.Location = New System.Drawing.Point(22, 139)
        Me.cbbDeptoRes.Name = "cbbDeptoRes"
        Me.cbbDeptoRes.Size = New System.Drawing.Size(142, 21)
        Me.cbbDeptoRes.TabIndex = 30
        Me.cbbDeptoRes.ValueMember = "dep_Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Direccion Completa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(170, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Ciudad de Residencia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Depto.Residencia"
        '
        'txtDirComp
        '
        Me.txtDirComp.Location = New System.Drawing.Point(22, 173)
        Me.txtDirComp.Name = "txtDirComp"
        Me.txtDirComp.Size = New System.Drawing.Size(384, 20)
        Me.txtDirComp.TabIndex = 24
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 18)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(154, 28)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'BDMediwareDataSet
        '
        Me.BDMediwareDataSet.DataSetName = "BDMediwareDataSet"
        Me.BDMediwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDMediwareDataSetBindingSource
        '
        Me.BDMediwareDataSetBindingSource.DataSource = Me.BDMediwareDataSet
        Me.BDMediwareDataSetBindingSource.Position = 0
        '
        'BDMediwareDataSet1
        '
        Me.BDMediwareDataSet1.DataSetName = "BDMediwareDataSet1"
        Me.BDMediwareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDMediwareDataSet1
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'BDMediwareDataSet2
        '
        Me.BDMediwareDataSet2.DataSetName = "BDMediwareDataSet2"
        Me.BDMediwareDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadesBindingSource
        '
        Me.CiudadesBindingSource.DataMember = "Ciudades"
        Me.CiudadesBindingSource.DataSource = Me.BDMediwareDataSet2
        '
        'CiudadesTableAdapter
        '
        Me.CiudadesTableAdapter.ClearBeforeFill = True
        '
        'BDMediwareDataSet3
        '
        Me.BDMediwareDataSet3.DataSetName = "BDMediwareDataSet3"
        Me.BDMediwareDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoBindingSource1
        '
        Me.DepartamentoBindingSource1.DataMember = "Departamento"
        Me.DepartamentoBindingSource1.DataSource = Me.BDMediwareDataSet3
        '
        'DepartamentoTableAdapter1
        '
        Me.DepartamentoTableAdapter1.ClearBeforeFill = True
        '
        'BDMediwareDataSet4
        '
        Me.BDMediwareDataSet4.DataSetName = "BDMediwareDataSet4"
        Me.BDMediwareDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadesBindingSource1
        '
        Me.CiudadesBindingSource1.DataMember = "Ciudades"
        Me.CiudadesBindingSource1.DataSource = Me.BDMediwareDataSet4
        '
        'CiudadesTableAdapter1
        '
        Me.CiudadesTableAdapter1.ClearBeforeFill = True
        '
        'frmAsegurado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 553)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.BtnElim)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvAseg)
        Me.Controls.Add(Me.gbDataAseg)
        Me.Name = "frmAsegurado"
        Me.Text = "Asegurado"
        Me.gbDataAseg.ResumeLayout(False)
        Me.gbDataAseg.PerformLayout()
        Me.gbEstadoCivil.ResumeLayout(False)
        Me.gbEstadoCivil.PerformLayout()
        Me.gbGenero.ResumeLayout(False)
        Me.gbGenero.PerformLayout()
        CType(Me.dgvAseg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSeguro.ResumeLayout(False)
        Me.gbSeguro.PerformLayout()
        CType(Me.BDMediwareDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMediwareDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDataAseg As GroupBox
    Friend WithEvents dgvAseg As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BtnElim As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtConyugue As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents gbEstadoCivil As GroupBox
    Friend WithEvents rbV As RadioButton
    Friend WithEvents rbC As RadioButton
    Friend WithEvents rbS As RadioButton
    Friend WithEvents gbGenero As GroupBox
    Friend WithEvents rdF As RadioButton
    Friend WithEvents rbM As RadioButton
    Friend WithEvents cbbCiuNac As ComboBox
    Friend WithEvents cbbDeptoNac As ComboBox
    Friend WithEvents lbl_Id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtfechaNac As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTiemAseg As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNomAseg As TextBox
    Friend WithEvents gbSeguro As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTiempoL As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtWebEmp As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNomEmp As TextBox
    Friend WithEvents cbbCiuRes As ComboBox
    Friend WithEvents cbbDeptoRes As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDirComp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents BDMediwareDataSetBindingSource As BindingSource
    Friend WithEvents BDMediwareDataSet As BDMediwareDataSet
    Friend WithEvents BDMediwareDataSet1 As BDMediwareDataSet1
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDMediwareDataSet1TableAdapters.DepartamentoTableAdapter
    Friend WithEvents BDMediwareDataSet2 As BDMediwareDataSet2
    Friend WithEvents CiudadesBindingSource As BindingSource
    Friend WithEvents CiudadesTableAdapter As BDMediwareDataSet2TableAdapters.CiudadesTableAdapter
    Friend WithEvents BDMediwareDataSet3 As BDMediwareDataSet3
    Friend WithEvents DepartamentoBindingSource1 As BindingSource
    Friend WithEvents DepartamentoTableAdapter1 As BDMediwareDataSet3TableAdapters.DepartamentoTableAdapter
    Friend WithEvents BDMediwareDataSet4 As BDMediwareDataSet4
    Friend WithEvents CiudadesBindingSource1 As BindingSource
    Friend WithEvents CiudadesTableAdapter1 As BDMediwareDataSet4TableAdapters.CiudadesTableAdapter
End Class
