Public Class frmRegistroPagos

    Private Pago As PagoVenta = Nothing
    Private Cheque As ChequeVenta = Nothing
    Private Deposito As DepositoVenta = Nothing
    Private Tarjeta As TarjetaVenta = Nothing

    Sub AbrirPago(ByVal wMonto As Double)
        Dim frm As New frmDocumentoVenta
        Me.ShowDialog()
        lblMontoAPagar.Text = Math.Round(wMonto, 2)
        'frm.Pago = Me.Pago
        'frm.Cheque = Me.Cheque
        'frm.Deposito = Me.Deposito
        'frm.Tarjeta = Me.Tarjeta
    End Sub

    Private Sub CalcularMontoEstaPagando()
        If lblMontoPagando.Text <> "" And lblMontoAPagar.Text <> "" And lblMontoFaltante.Text <> "" Then
            lblMontoPagando.Text = Math.Round((CDbl(numPagaCon.Value) - CDbl(txtVuelto.Text) + CDbl(numMontoDEP.Value) + CDbl(numMontoTAR.Value) + CDbl(numMontoCHE.Value)), 2)
            lblMontoFaltante.Text = Math.Round(CDbl(lblMontoAPagar.Text) - CDbl(lblMontoPagando.Text), 2)
        End If
    End Sub

    Private Function CargarBancos() As List(Of Banco)
        Dim rn As RNBanco
        Dim Bancos As List(Of Banco) = Nothing

        Try
            rn = New RNBanco
            Bancos = rn.Listar()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

        Return Bancos
    End Function

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

    Private Function CargarTipoTarjetas() As List(Of TipoTarjetaVentas)
        Dim rn As RNTipoTarjeta
        Dim Tipos As List(Of TipoTarjetaVentas) = Nothing

        Try
            rn = New RNTipoTarjeta
            Tipos = rn.ListarTodo()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

        Return Tipos
    End Function

    Sub LimpiarEfectivo()
        numPagaCon.Value = 0.0
        txtVuelto.Text = "0.00"
    End Sub

    Sub LimpiarDeposito()
        numMontoDEP.Value = 0.0
    End Sub

    Sub LimpiarTarjeta()
        txtNumTAR1.Text = ""
        txtNumTAR2.Text = ""
        txtNumTAR3.Text = ""
        txtNumTAR4.Text = ""
        numMontoTAR.Value = 0.0
    End Sub

    Sub LimpiarCheque()
        txtNumeroCH.Text = ""
        dtpFechaGiro.Value = Now
        numMontoCHE.Value = 0.0
    End Sub

    Private Function AsignarMedioPago() As String
        Dim medio As String = Nothing

        If numPagaCon.Value > 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "EF"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "DE"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "TA"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "CH"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "C-D"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "C-T"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "C-E"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "D-T"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "D-E"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "T-E"
        End If
        If numPagaCon.Value <= 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "CDT"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value <= 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "CDE"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value <= 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "CTE"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value <= 0.0 Then
            medio = "DTE"
        End If
        If numPagaCon.Value > 0.0 And numMontoDEP.Value > 0.0 And numMontoTAR.Value > 0.0 And numMontoCHE.Value > 0.0 Then
            medio = "CDTE"
        End If

        Return medio
    End Function

    Private Sub tglEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglEfectivo.CheckedChanged
        If tglEfectivo.Checked = True Then
            gbEfectivo.Enabled = True
            numPagaCon.Focus()
        Else
            LimpiarEfectivo()
            gbEfectivo.Enabled = False
        End If
    End Sub

    Private Sub tglDeposito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglDeposito.CheckedChanged
        If tglDeposito.Checked = True Then
            Dim Bancos As List(Of Banco)
            gbDeposito.Enabled = True
            Bancos = CargarBancos()
            modFunciones.ListarComboBox(Me.cboBancoDEP, Bancos, "Codigo", "Nombre")
            cboBancoDEP.Focus()
        Else
            LimpiarDeposito()
            gbDeposito.Enabled = False
        End If

    End Sub

    Private Sub tglTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglTarjeta.CheckedChanged
        If tglTarjeta.Checked = True Then
            Dim Bancos As List(Of Banco)
            Dim TiposTar As List(Of TipoTarjetaVentas)
            gbTarjeta.Enabled = True
            txtNumTAR1.Focus()
            TiposTar = CargarTipoTarjetas()
            modFunciones.ListarComboBox(Me.cboTarjeta, TiposTar, "Codigo", "Nombre")
            Bancos = CargarBancos()
            modFunciones.ListarComboBox(Me.cboBancoTAR, Bancos, "Codigo", "Nombre")
        Else
            LimpiarTarjeta()
            gbTarjeta.Enabled = False
        End If

    End Sub

    Private Sub tglCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglCheque.CheckedChanged
        If tglCheque.Checked = True Then
            gbCheque.Enabled = True
            txtNumeroCH.Focus()
        Else
            LimpiarCheque()
            gbCheque.Enabled = False
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        Pago = Nothing
    End Sub

    Private Sub numPagaCon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPagaCon.ValueChanged
        If numPagaCon.Value = 0 Then
            txtVuelto.Text = "0.00"
        Else
            If lblMontoAPagar.Text <> "" Then
                If CDbl(numPagaCon.Value) - CDbl(lblMontoAPagar.Text) > 0 Then
                    txtVuelto.Text = Math.Round(CDbl(numPagaCon.Value) - CDbl(lblMontoAPagar.Text), 2)
                Else
                    txtVuelto.Text = "0.00"
                End If
            End If
        End If
        CalcularMontoEstaPagando()
    End Sub

    Private Sub cboBancoDEP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBancoDEP.SelectedIndexChanged
        If cboBancoDEP.SelectedIndex >= 0 Then
            Dim selecc As Banco
            selecc = DirectCast(cboBancoDEP.SelectedItem, Banco)
            CargarCuentas(selecc.Codigo)
            cboCuentaDEP.Focus()
        End If
    End Sub

    Private Sub txtNumTAR1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTAR1.TextChanged
        If txtNumTAR1.Text.Length = 4 Then
            txtNumTAR2.Focus()
        End If
    End Sub

    Private Sub txtNumTAR2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTAR2.TextChanged
        If txtNumTAR2.Text.Length = 4 Then
            txtNumTAR3.Focus()
        End If
        If txtNumTAR2.Text.Length = 0 Then
            txtNumTAR1.Focus()
        End If
    End Sub

    Private Sub txtNumTAR3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTAR3.TextChanged
        If txtNumTAR3.Text.Length = 4 Then
            txtNumTAR4.Focus()
        End If
        If txtNumTAR3.Text.Length = 0 Then
            txtNumTAR2.Focus()
        End If
    End Sub

    Private Sub txtNumTAR4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTAR4.TextChanged
        If txtNumTAR4.Text.Length = 0 Then
            txtNumTAR3.Focus()
        End If
    End Sub

    Private Sub txtVuelto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVuelto.TextChanged
        
    End Sub

    Private Sub numMontoDEP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMontoDEP.ValueChanged, numMontoTAR.ValueChanged, numMontoCHE.ValueChanged
        CalcularMontoEstaPagando()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        If CDbl(lblMontoPagando.Text) > 0.0 Then
            'REGISTRO DEL PAGO:
            Pago = New PagoVenta
            Pago.FechaPago = dtFecha.Value
            Pago.MedioPago = AsignarMedioPago()
            Pago.Monto = Math.Round(CDbl(lblMontoPagando.Text), 2)

            If numMontoDEP.Value > 0.0 Then 'Si paga con DEPÓSITO
                Deposito = New DepositoVenta
                Deposito.Monto = Math.Round(CDbl(numMontoDEP.Value), 2)
                Deposito.IdCuenta = DirectCast(cboCuentaDEP.SelectedItem, CuentaVenta).Codigo
                Deposito.PagoVentas = New PagoVenta
            End If

            If numMontoTAR.Value > 0.0 Then 'Si paga con TARJETA DE CRÉDITO
                Tarjeta = New TarjetaVenta
                Tarjeta.Monto = Math.Round(CDbl(numMontoTAR.Value), 2)
                Tarjeta.NumeroCuenta = txtNumTAR1.Text & " " & txtNumTAR2.Text & " " & txtNumTAR3.Text & " " & txtNumTAR4.Text
                Tarjeta.IdTipoTarjeta = DirectCast(cboTarjeta.SelectedItem, TipoTarjetaVentas).Codigo
                Tarjeta.IdBanco = DirectCast(cboBancoTAR.SelectedItem, Banco).Codigo
                Tarjeta.PagoVentas = New PagoVenta
            End If

            If numMontoCHE.Value > 0.0 Then 'Si paga con CHEQUE
                Cheque = New ChequeVenta
                Cheque.Numero = txtNumeroCH.Text
                Cheque.Monto = Math.Round(CDbl(numMontoCHE.Value), 2)
                Cheque.FechaGiro = dtpFechaGiro.Text
                Cheque.Vigencia = True
                Cheque.PagoVentas = New PagoVenta
            End If

            Me.Close()
        Else
            MetroMessageBox.Show(Me, "No se puede registrar un Pago vacío.", "REGISTRO DE PAGOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class