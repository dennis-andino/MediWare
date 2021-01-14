Public Class frmRecXfech
    Private Sub frmRecXfech_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecharec As String
        fecharec = InputBox("Ingrese Fecha de Reporte [y-m-d] : ", "Reclamos por fecha", "2018-1-1")
        Dim RepRecxFec = New CRrecxFech
        RepRecxFec.SetParameterValue("@fecha", fecharec)
        CRVrecxFech.ReportSource = RepRecxFec
    End Sub
End Class