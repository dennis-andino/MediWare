Public Class frmRecMax
    Private Sub frmRecMax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporterecMax = New CRmaxRec
        CRVmaxRec.ReportSource = reporterecMax
    End Sub
End Class