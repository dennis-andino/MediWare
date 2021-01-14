Public Class FrmLogin
    Private tablaDatos As DataTable
    Private objUsuarioE As New Eusuarios
    Private objUsuarioF As New Fusuarios
    Private nombreUsuario As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuarioL.Text <> "" And txtClaveL.Text <> "" Then
                objUsuarioE.Clave = txtClaveL.Text.ToString
                objUsuarioE.Usuario = txtUsuarioL.Text.ToString
                tablaDatos = objUsuarioF.ValidarUsuario(objUsuarioE)
                If tablaDatos.Rows.Count = 1 Then
                    nombreUsuario = tablaDatos.Rows(0)("log_NombreCompleto")
                    Me.Hide()
                    MessageBox.Show("Bienvenido " & nombreUsuario & "!!", "MediWare", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmPrincipal.Show()
                Else
                    MessageBox.Show("Upss parece que el usuario no existe, verifica tu informacion e intentalo de nuevo. :(")
                End If

            Else
                MessageBox.Show("No se aceptan espacios vacios, verifica e intentalo nuevamente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al conectar con la base de datos , verifica la coneccion. " & vbLf & ex.Message)
        End Try
    End Sub
End Class
