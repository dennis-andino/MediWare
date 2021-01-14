Public Class frmRepReclamos
    Private Sub frmRepReclamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim asegNombre As String
        Dim reporterec = New CRreclamos()
        asegNombre = InputBox("Ingrse el Nombre del Asegurado : ", "Reportes Reclamos", "Nombre1 Nombre2")
        reporterec.SetParameterValue("@AsegNom", asegNombre)
        CrystalReportViewer1.ReportSource = reporterec
    End Sub
End Class