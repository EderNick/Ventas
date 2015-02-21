Imports MetroFramework
Public Class frmCaja

    Private Sub ActivarControles(ByVal valor As Boolean)
        gbCaja.Enabled = valor
        dgvCaja.Enabled = Not valor
    End Sub

    Private Sub LimpiarControles()
        txtNumero.Text = ""
        txtDescripcion.Text = ""
        txtMontoApertura.Text = ""
        txtMontoCierre.Text = ""
        dtpApertura.Value = Now
        dtpCierre.Value = Now
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.ValidateChildren = True Then
            ca = New Caja
            ca.Numero = Me.txtNumero.Text
            ca.Descripcion = Me.txtDescripcion.Text
            ca.MontoApertua = CDbl(txtMontoApertura.Text)
            ca.MontoCierre = CDbl(txtMontoCierre.Text)
            ca.FechaApertura = dtpApertura.Value
            ca.FechaCierre = dtpCierre.Value
            rn = New RNCaja
            Try

                rn.Registrar(ca)
                MetroMessageBox.Show(Me, "Su Registro se Guardo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.ActivarControles(False)
                'ListarCajas("")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                ca = Nothing
            End Try

        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ActivarControles(True)
        LimpiarControles()
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class