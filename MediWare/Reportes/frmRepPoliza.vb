Public Class frmRepPoliza
    Private Sub frmRepPoliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numPoliza As String
        Dim CRPoliza = New CRrepPolizas
        numPoliza = InputBox("Ingrese el numero de Poliza", "Polizas")
        CRPoliza.SetParameterValue("@numerop", Convert.ToInt16(numPoliza))
        CRVpolizas.ReportSource = CRPoliza
    End Sub
End Class