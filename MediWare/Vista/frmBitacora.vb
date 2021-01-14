Public Class frmBitacora
    Private Sub frmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VerBtacoraTableAdapter.Fill(Me.BDMediwareDataSet.VerBtacora)

    End Sub
End Class