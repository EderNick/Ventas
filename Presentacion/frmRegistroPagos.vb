Public Class frmRegistroPagos

    Private Pago As PagoVenta

    Function AbrirPago(ByVal wMonto As Double)
        Me.ShowDialog()
        lblMontoAPagar.Text = Math.Round(wMonto, 2)
        Return Pago
    End Function

    Private Sub tglEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglEfectivo.CheckedChanged
        If tglEfectivo.Checked = True Then
            gbEfectivo.Enabled = True
            txtPagaCon.Focus()
        Else
            gbEfectivo.Enabled = False
        End If
    End Sub

    Private Sub tglDeposito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglDeposito.CheckedChanged
        If tglDeposito.Enabled = True Then
            gbDeposito.Enabled = True
            CargarBancos()
            cboBancoDEP.Focus()
        Else
            gbDeposito.Enabled = False
        End If

    End Sub

    Private Sub tglTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglTarjeta.CheckedChanged
        gbTarjeta.Enabled = True
    End Sub

    Private Sub tglCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglCheque.CheckedChanged
        gbCheque.Enabled = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        Pago = Nothing
    End Sub

    Private Sub btnRegistrarTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarTarjeta.Click
        'Dim frm As frmRegistrarTarjeta
        'frm.Agregar()
        'CargarTipoTarjeta()
    End Sub

    Private Sub txtPagaCon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPagaCon.TextChanged
        If txtPagaCon.Text = "" Then
            txtVuelto.Text = "0.00"
        Else
            If lblMontoAPagar.Text <> "" Then
                If CDbl(txtPagaCon.Text) - CDbl(lblMontoAPagar.Text) > 0 Then
                    txtVuelto.Text = Math.Round(CDbl(txtPagaCon.Text) - CDbl(lblMontoAPagar.Text))
                Else
                    txtVuelto.Text = "0.00"
                End If
            End If
        End If
    End Sub

    Private Sub CargarBancos()
        Dim rn As RNBanco
        Dim Bancos As List(Of Banco)

        Try
            rn = New RNBanco
            Bancos = rn.Listar()
            modFunciones.ListarComboBox(Me.cboBancoDEP, Bancos, "Codigo", "Nombre")
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub CargarCuentas(ByVal wCodBanco As Integer)
        Dim rn As RNCuentaVenta
        Dim Cuentas As List(Of CuentaVenta)

        Try
            rn = New RNCuentaVenta
            Cuentas = rn.ListarxIdBanco(wCodBanco)
            modFunciones.ListarComboBox(Me.cboCuentaDEP, Cuentas, "Codigo", "CCI")
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub cboBancoDEP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBancoDEP.SelectedIndexChanged
        Dim selecc As Banco
        selecc = DirectCast(cboBancoDEP.SelectedItem, Banco)
        CargarCuentas(selecc.Codigo)
    End Sub
End Class