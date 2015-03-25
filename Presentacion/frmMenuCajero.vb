Public Class frmMenuCajero

    Private Sub MetroPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MetroPanel2.Paint

    End Sub

    Private Sub btnEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleado.Click
        Dim frm As New frmDocumentoVenta
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm As New frmGestionCuota
        frm.ShowDialog()
    End Sub
End Class