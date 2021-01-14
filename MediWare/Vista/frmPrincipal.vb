Public Class frmPrincipal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnAsegurado_Click(sender As Object, e As EventArgs) Handles btnAsegurado.Click
        frmAsegurado.Show()
        Me.Hide()
    End Sub

    Private Sub btnDepReport_Click(sender As Object, e As EventArgs) Handles btnDepReport.Click
        gbReportes.Visible = False
        RepDependientes.Show()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        gbReportes.Visible = True
    End Sub

    Private Sub tnReclamos_Click(sender As Object, e As EventArgs) Handles tnReclamos.Click
        gbReportes.Visible = False
        frmRepReclamos.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbReportes.Visible = False
        frmRecMax.Show()
    End Sub

    Private Sub btnBitacora_Click(sender As Object, e As EventArgs) Handles btnBitacora.Click
        frmBitacora.Show()

    End Sub

    Private Sub btnPoliza_Click(sender As Object, e As EventArgs) Handles btnPoliza.Click
        frmRepPoliza.Show()

    End Sub

    Private Sub btnRepRxf_Click(sender As Object, e As EventArgs) Handles btnRepRxf.Click
        frmRecXfech.Show()
    End Sub
End Class