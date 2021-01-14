Imports System.Data.SqlClient

Public Class Fasegurados
    Inherits BDconexion
    Dim SQLcomando As SqlCommand

    Public Function Mostrar() As DataTable

        Try
            conectar()
            SQLcomando = New SqlCommand("sp_verAsegurados")
            SQLcomando.CommandType = CommandType.StoredProcedure
            SQLcomando.Connection = miconexion
            If SQLcomando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(SQLcomando)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> " & ex.Message, MsgBoxStyle.Critical, "problemas de conexion")
            Return Nothing
        Finally
            desconectar()

        End Try
    End Function

    Public Function InsertarDatos(dt As Easegurado) As Boolean
        Try
            conectar()
            SQLcomando = New SqlCommand("sp_insertarAsegurados")
            SQLcomando.CommandType = CommandType.StoredProcedure
            SQLcomando.Connection = miconexion
            SQLcomando.Parameters.AddWithValue("Aseg_Id", dt.Aseg_Id)
            SQLcomando.Parameters.AddWithValue("Aseg_Nombre", dt.Aseg_Nombre)
            SQLcomando.Parameters.AddWithValue("Aseg_Apellido", dt.Aseg_Apellido)
            SQLcomando.Parameters.AddWithValue("Aseg_Nacionalidad", dt.Aseg_Nacionalidad)
            SQLcomando.Parameters.AddWithValue("Aseg_Estatura", dt.Aseg_Estatura)
            SQLcomando.Parameters.AddWithValue("Aseg_Peso", dt.Aseg_Peso)
            SQLcomando.Parameters.AddWithValue("Aseg_Genero", dt.Aseg_Genero)
            SQLcomando.Parameters.AddWithValue("Aseg_EstadoCivil", dt.Aseg_EstadoCivil)
            SQLcomando.Parameters.AddWithValue("Aseg_nomConyugue", dt.Aseg_nomConyugue)
            SQLcomando.Parameters.AddWithValue("Aseg_CiudadRes", dt.Aseg_CiudadRes)
            SQLcomando.Parameters.AddWithValue("Aseg_direccionRes", dt.Aseg_direccionRes)
            SQLcomando.Parameters.AddWithValue("Aseg_NomEmpresa", dt.Aseg_NomEmpresa)
            SQLcomando.Parameters.AddWithValue("Aseg_EmpresaWeb", dt.Aseg_EmpresaWeb)
            SQLcomando.Parameters.AddWithValue("Aseg_AntiguedadLab", dt.Aseg_AntiguedadLab)
            SQLcomando.Parameters.AddWithValue("Aseg_puestoTrab", dt.Aseg_puestoTrab)
            SQLcomando.Parameters.AddWithValue("Aseg_nomAseguradoraT", dt.Aseg_nomAseguradoraT)
            SQLcomando.Parameters.AddWithValue("Aseg_tiempoT", dt.Aseg_tiempoT)


            If SQLcomando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema al Insertar los datos :| ==> " & ex.Message)
            Return False
        Finally
            desconectar()
        End Try

    End Function

End Class
