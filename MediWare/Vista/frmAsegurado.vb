Imports System.ComponentModel

Public Class frmAsegurado
    Private tablaInfo As New DataTable
    Protected objetoFaseg As New Fasegurados
    Protected objetoEaseg As New Easegurado
    Private Sub frmAsegurado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMediwareDataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
        Me.CiudadesTableAdapter1.Fill(Me.BDMediwareDataSet4.Ciudades)
        'TODO: esta línea de código carga datos en la tabla 'BDMediwareDataSet3.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter1.Fill(Me.BDMediwareDataSet3.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'BDMediwareDataSet2.Ciudades' Puede moverla o quitarla según sea necesario.
        Me.CiudadesTableAdapter.Fill(Me.BDMediwareDataSet2.Ciudades)
        'TODO: esta línea de código carga datos en la tabla 'BDMediwareDataSet1.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BDMediwareDataSet1.Departamento)
        mostrarInfo()
        pasarInfo()
    End Sub

    Private Sub mostrarInfo()
        Try
            tablaInfo = objetoFaseg.Mostrar
            If tablaInfo.Rows.Count > 0 Then
                dgvAseg.DataSource = tablaInfo
                dgvAseg.Rows(0).Selected = True
            Else
                MessageBox.Show("No hay Asegurados Registrados", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmAsegurado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub pasarInfo()
        lbl_Id.Text = dgvAseg.SelectedCells.Item(0).Value
        txtDni.Text = dgvAseg.SelectedCells.Item(1).Value
        txtNombre1.Text = dgvAseg.SelectedCells.Item(2).Value
        txtApellido1.Text = dgvAseg.SelectedCells.Item(3).Value
        txtPais.Text = dgvAseg.SelectedCells.Item(4).Value
        cbbDeptoNac.Text = dgvAseg.SelectedCells.Item(5).Value
        cbbCiuNac.Text = dgvAseg.SelectedCells.Item(6).Value
        txtfechaNac.Text = dgvAseg.SelectedCells.Item(7).Value
        txtAltura.Text = dgvAseg.SelectedCells.Item(8).Value
        txtPeso.Text = dgvAseg.SelectedCells.Item(9).Value
        cbbDeptoRes.Text = dgvAseg.SelectedCells.Item(13).Value
        cbbCiuRes.Text = dgvAseg.SelectedCells.Item(14).Value
        txtDirComp.Text = dgvAseg.SelectedCells.Item(15).Value
        txtNomEmp.Text = dgvAseg.SelectedCells.Item(16).Value
        txtWebEmp.Text = dgvAseg.SelectedCells.Item(17).Value
        txtTiempoL.Text = dgvAseg.SelectedCells.Item(18).Value
        txtPuesto.Text = dgvAseg.SelectedCells.Item(19).Value

        ''txtTiemAseg.Text = dgvAseg.SelectedCells.Item(21).Value
        If dgvAseg.SelectedCells.Item(10).Value = "M" Then
            rbM.Checked = True
        Else
            rdF.Checked = True
        End If

        If dgvAseg.SelectedCells.Item(10).Value = "M" Then
            rbM.Checked = True
        Else
            rdF.Checked = True
        End If

        If dgvAseg.SelectedCells.Item(11).Value = "S" Then
            rbS.Checked = True
        ElseIf dgvAseg.SelectedCells.Item(11).Value = "C" Then
            txtConyugue.Text = dgvAseg.SelectedCells.Item(12).Value
            rbC.Checked = True
        ElseIf dgvAseg.SelectedCells.Item(11).Value = "V" Then
            rbV.Checked = True
        End If

        'If dgvAseg.SelectedCells.Item(20).Value <> NULL Then
        '    txtNomAseg.Text = dgvAseg.SelectedCells.Item(20).Value
        'End If

    End Sub

    Private Sub dgvAseg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAseg.CellClick
        pasarInfo()
    End Sub

    Private Sub limpiar()
        lbl_Id.Text = ""
        txtDni.Text = ""
        txtNombre1.Text = ""
        txtApellido1.Text = ""
        txtPais.Text = ""
        cbbDeptoNac.Text = ""
        cbbCiuNac.Text = ""
        txtfechaNac.Text = ""
        txtAltura.Text = ""
        txtPeso.Text = ""
        cbbDeptoRes.Text = ""
        cbbCiuRes.Text = ""
        txtDirComp.Text = ""
        txtNomEmp.Text = ""
        txtWebEmp.Text = ""
        txtTiempoL.Text = ""
        txtPuesto.Text = ""
        txtTiemAseg.Text = ""
        txtConyugue.Text = ""
        txtNomAseg.Text = ""
    End Sub

    Private Sub asignaValores()
        objetoEaseg.Aseg_Id = txtDni.Text
        objetoEaseg.Aseg_Nombre = txtNombre1.Text
        objetoEaseg.Aseg_Apellido = txtApellido1.Text
        objetoEaseg.Aseg_Nacionalidad = (cbbDeptoNac.SelectedValue)
        objetoEaseg.Aseg_DeptoNac = Convert.ToInt16(cbbDeptoNac.SelectedValue)
        objetoEaseg.Aseg_CiudadNac = Convert.ToInt16(cbbCiuNac.SelectedValue)
        objetoEaseg.Aseg_FechaNac = txtfechaNac.Text
        objetoEaseg.Aseg_Estatura = txtAltura.Text
        objetoEaseg.Aseg_Peso = txtPeso.Text
        objetoEaseg.Aseg_nomConyugue = txtConyugue.Text
        objetoEaseg.Aseg_DeptoRes = Convert.ToInt16(cbbDeptoRes.SelectedValue)
        objetoEaseg.Aseg_CiudadRes = Convert.ToInt16(cbbCiuRes.SelectedValue)
        objetoEaseg.Aseg_direccionRes = txtDirComp.Text
        objetoEaseg.Aseg_NomEmpresa = txtNomEmp.Text
        objetoEaseg.Aseg_EmpresaWeb = txtWebEmp.Text
        objetoEaseg.Aseg_AntiguedadLab = txtTiempoL.Text
        objetoEaseg.Aseg_puestoTrab = txtPuesto.Text
        objetoEaseg.Aseg_nomAseguradoraT = txtNomAseg.Text
        objetoEaseg.Aseg_tiempoT = txtTiemAseg.Text

        If rbM.Checked Then
            objetoEaseg.Aseg_Genero = "M"
        Else
            objetoEaseg.Aseg_Genero = "F"
        End If
        If rbC.Checked Then
            objetoEaseg.Aseg_EstadoCivil = "C"
        ElseIf rbV.Checked Then
            objetoEaseg.Aseg_EstadoCivil = "V"
        Else
            objetoEaseg.Aseg_EstadoCivil = "S"
        End If

    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        btnNuevo.Visible = False
        btnGuardar.Visible = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        asignaValores()
        If objetoFaseg.InsertarDatos(objetoEaseg) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            limpiar()
            btnNuevo.Visible = True
        End If
    End Sub
End Class