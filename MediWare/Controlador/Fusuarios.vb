Imports System.Data.SqlClient

Public Class Fusuarios
    Inherits BDconexion
    Dim comandoSQL As SqlCommand

    Public Function ValidarUsuario(ByRef credenciales As Eusuarios) As DataTable
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_LoginUsuarios")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("@Clave", credenciales.Clave)
            comandoSQL.Parameters.AddWithValue("@Usuario", credenciales.Usuario)
            If comandoSQL.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comandoSQL)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("upss no pudimos verificar los datos, contacte al administrador del sistema")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function


End Class
