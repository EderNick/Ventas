Public Class frmGestionCuota
    Dim rn As New RNCliente
    Dim cuotaventa As New CuotaVenta
    Dim cuotapago As New CuotaPagoVentas
    Dim detacliente As List(Of DetalleCliente)
    Dim codcliente As String


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnbusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusqueda.Click
        If rbDNI.Checked = True Then
            listarCliDNI()
        ElseIf rbRUC.Checked = True Then
            listarCliRUC()
        Else
            MessageBox.Show("Seleccione un método de busqueda ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub listarCliDNI()
        Try
            detacliente = rn.BuscarxDNI(Me.txtBuscar.Text)
            If detacliente.Count <> 0 Then
                For Each deta As DetalleCliente In detacliente
                    txtnombre.Text = deta.Persona.NombrePersona
                    txtDNIRUC.Text = deta.Persona.DNI
                    codcliente = deta.Cliente.Codigo
                Next
                listarcuotas()
            Else
                MessageBox.Show("no existe el cliente ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvcuota.DataSource = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listarCliRUC()
        Try
            detacliente = rn.BuscarxRUC(Me.txtBuscar.Text)
            If detacliente.Count <> 0 Then
                For Each deta As DetalleCliente In detacliente
                    txtnombre.Text = deta.EmpresaJuridica.RazonSocial & " " & deta.EmpresaJuridica.Direccion
                    txtDNIRUC.Text = deta.EmpresaJuridica.RUC
                    codcliente = deta.Cliente.Codigo
                Next
                listarcuotas()
            Else

                MessageBox.Show("no existe la empresa buscada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listarcuotas()
        Dim rn As New RNCuotaVenta
        Dim cuotas As List(Of CuotaVenta)
        Try
            cuotas = rn.ListarCuotas(codcliente)
            If cuotas Is Nothing Then
                MessageBox.Show("no existen cuotas a pagar para este cliente ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvcuota.DataSource = ""
            Else
                modFunciones.EnlazarDatagridView(Me.dgvCuota, cuotas)
                Me.dgvCuota.Focus()
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbRUC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRUC.CheckedChanged
        lbltipo.Text = "RUC"
        gbdatos.Text = "EMPRESA"
        txtBuscar.MaxLength = 11
        '  limpiar()
    End Sub

    Private Sub rbDNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDNI.CheckedChanged
        lbltipo.Text = "DNI"
        gbdatos.Text = "CLIENTE"
        txtBuscar.MaxLength = 8
        ' limpiar()
    End Sub

    Private Sub frmGestionCuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDNIRUC.BackColor = Color.White
        txtnombre.BackColor = Color.White
        txtnombre.BackColor = Color.White
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If


    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Sub limpiar()
        rn = New RNCliente
        detacliente = New List(Of DetalleCliente)()

        rbDNI.Checked = False
        rbRUC.Checked = False
        txtBuscar.Clear()
        txtDNIRUC.Clear()
        txtnombre.Clear()
        dgvcuota.DataSource = Nothing
    End Sub

    Private Sub btnpagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagar.Click
        cuotaventa = New CuotaVenta
        cuotapago = New CuotaPagoVentas
        Dim rnPago As New RNPagoVentas
        Dim idPagoVenta As Integer = 0
        Dim rnCheque As New RNChequeVentas
        Dim rnDeposito As New RNDepositoVentas
        Dim rnTarjeta As New RNTarjetaVentas
        Dim cuotaApagar As CuotaVenta = Nothing
        Dim rnCuotaPago As RNCuotaPagoVenta = Nothing
        Dim CuotaPagoV As CuotaPagoVentas

        If Me.dgvcuota.CurrentRow IsNot Nothing Then
            cuotaApagar = DirectCast(dgvcuota.CurrentRow.DataBoundItem, CuotaVenta)
            If cuotaApagar.estadodeuda = "Debe" Then
                Me.cuotaventa = DirectCast(Me.dgvcuota.CurrentRow.DataBoundItem, CuotaVenta)

                Dim frm As New frmRegistroPagos
                frm.lblMontoAPagar.Text = cuotaApagar.Monto
                frm.ShowDialog()
                Pago = modPrincipal.Pago

                If Pago Is Nothing Then
                    MetroMessageBox.Show(Me, "No se realizò el pago de la cuota ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    '****Registramos el Pago***
                    Pago.DocumVenta = New DocumentoVenta
                    Pago.DocumVenta.Codigo = cuotaApagar.DocVenta.Codigo
                    idPagoVenta = rnPago.Registrar(Pago)

                    modPrincipal.Pago = Nothing
                    '***********Registramos el tipo de pago****************
                    If modPrincipal.Cheque.Monto IsNot Nothing Then
                        Cheque = modPrincipal.Cheque
                        Cheque.PagoVentas = New PagoVenta
                        Cheque.PagoVentas.Codigo = idPagoVenta
                        rnCheque.Registrar(Cheque)
                        modPrincipal.Cheque = Nothing
                    End If
                    If modPrincipal.Deposito.Monto <> 0.0 Then
                        Deposito = modPrincipal.Deposito
                        Deposito.PagoVentas = New PagoVenta
                        Deposito.PagoVentas.Codigo = idPagoVenta
                        rnDeposito.Registrar(Deposito)
                        modPrincipal.Deposito = Nothing
                    End If
                    If modPrincipal.Tarjeta.Monto <> 0.0 Then
                        Tarjeta = modPrincipal.Tarjeta
                        Tarjeta.PagoVentas = New PagoVenta
                        Tarjeta.PagoVentas.Codigo = idPagoVenta
                        rnTarjeta.Registrar(Tarjeta)
                        modPrincipal.Tarjeta = Nothing
                    End If

                    If idPagoVenta <> 0 Then
                        CuotaPagoV = New CuotaPagoVentas
                        CuotaPagoV.CuotaVenta = New CuotaVenta
                        CuotaPagoV.CuotaVenta = cuotaApagar
                        CuotaPagoV.PagoVenta = New PagoVenta
                        CuotaPagoV.PagoVenta.Codigo = idPagoVenta
                        rnCuotaPago = New RNCuotaPagoVenta
                        rnCuotaPago.Registrar(CuotaPagoV)

                        MetroMessageBox.Show(Me, "Cuota pagada correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        listarcuotas()
                    End If
                    End If




            Else
                    MetroMessageBox.Show(Me, "Debe Seleccionar una cuota que no este pagada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MetroMessageBox.Show(Me, "Debe Seleccionar una cuota ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class