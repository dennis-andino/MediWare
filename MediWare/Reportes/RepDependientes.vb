Public Class RepDependientes

    Private Sub RepDependientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporteDep = New CRdep1()
        Dim aseguradoNombre As String
        aseguradoNombre = InputBox("Ingrese nombre de Asegurado", "Reportes", "Jorge Alberto")
        reporteDep.SetParameterValue("@Nombre", aseguradoNombre)
        CRDependientes.ReportSource = reporteDep
    End Sub
End Class