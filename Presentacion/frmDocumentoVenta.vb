Public Class frmDocumentoVenta
    Private Actual As DocumentoVenta
    Dim Lista_detalle_orden_pedido As New List(Of DetalleOrdenPedido)
    Dim orden_pedido As New OrdenPedido
    Dim campos_faltan As String
    Dim MontoCuota As Double
    Dim num As Integer = 0
    Dim rn As New RNDocumentoVenta
    Dim Pago As New PagoVenta


    Private Sub frmDocumentoVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If rn.BuscarNumDocumento.ToString Is Nothing Then
            txtNumero.Text = "0000000001"
        Else
            num = Val(rn.BuscarNumDocumento) + 1
            txtNumero.Text = String.Format("{0:0000000000}", num)
        End If

        Me.txtSucursal.Text = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Nombre
        Me.txtRuc.Text = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Empresa.Ruc
        Me.txtNumCaja.Text = modPrincipal.CajaActualAbierta.Numero
        Me.txtCajero.Text = modPrincipal.UsuarioLogeado.Empleado.NombreEmpleado
        LimpiarControles()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LimpiarControles()
        btnGuardar.Enabled = False
        btnImprimir.Enabled = False
        Me.txtSubTotal.Text = "0"
        Me.txtIGV.Text = "0"
        Me.txtDescuento.Text = "0"
        Me.txtTotal.Text = "0"
        Me.txtMontoInicial.Text = "0"
        Me.txtMontoRestante.Text = "0"
        txtNumOrdenPedido.Text = ""
        txtVendedor.Text = ""
        txtCliente.Text = ""
        txtDoc.Text = ""
        Lista_detalle_orden_pedido = Nothing
        dgvProductos.DataSource = ""
        dgvCuotas.Rows.Clear()
        cboFormaPago.SelectedIndex = -1
        cboTipoDoc.SelectedIndex = -1
        cboTipoDoc.Enabled = True
        txtNumOrdenPedido.Enabled = True
        cboFormaPago.Enabled = True
        Pago = Nothing
    End Sub

    Private Sub cboTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.SelectedIndexChanged
        If cboTipoDoc.SelectedItem = "FACTURA" Then
            lblCliente.Text = "RAZON SOCIAL"
            lblDoc.Text = "RUC"
        Else
            lblCliente.Text = "      NOMBRE"
            lblDoc.Text = "DNI"
        End If
    End Sub

    Private Sub cboFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaPago.SelectedIndexChanged
        If cboFormaPago.SelectedItem = "CREDITO" Then
            gbCuotas.Enabled = True
            txtMontoRestante.Text = txtSubTotal.Text
            txtMontoInicial.Text = "0"
            btnEfectuarPago.Enabled = False
        Else
            gbCuotas.Enabled = False
            btnEfectuarPago.Enabled = True
            txtMontoInicial.Text = "0"
            txtMontoRestante.Text = "0"
            numCuotas.Value = 0
            dgvCuotas.Rows.Clear()
        End If
    End Sub


    Private Sub txtMontoInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoInicial.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And AscW(e.KeyChar) <> 8 Then ' ascw-->convierte la tecla a numero 
            e.Handled = True ' no permite pasar al numero 

        End If

    End Sub


    Private Sub txtMontoInicial_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoInicial.TextChanged
        If txtMontoInicial.Text = "" Or txtMontoInicial.Text = "0" Then
            txtMontoInicial.Text = "0"
            btnEfectuarPago.Enabled = False
        Else
            txtMontoRestante.Text = CDbl(txtSubTotal.Text) - CDbl(txtMontoInicial.Text)
            btnEfectuarPago.Enabled = True
        End If
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtNumOrdenPedido.Text = "" Then
            MetroMessageBox.Show(Me, "Debe ingresar un Numero de Orden", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim rn As New RNDocumentoVenta


            orden_pedido = rn.Buscar_Orden_de_Pedido(txtNumOrdenPedido.Text)
            If orden_pedido IsNot Nothing Then
                txtVendedor.Text = orden_pedido.Empleado.NombreEmpleado
                txtSubTotal.Text = orden_pedido.Total
                Dim detalle_cliente As New DetalleCliente
                detalle_cliente = rn.Buscar_cliente_x_id(orden_pedido.Cliente.Codigo, orden_pedido.Cliente.Tipo)
                If orden_pedido.Cliente.Tipo = "natural" Then
                    txtCliente.Text = detalle_cliente.Persona.NombrePersona
                    txtDoc.Text = detalle_cliente.Persona.DNI
                Else
                    txtCliente.Text = detalle_cliente.EmpresaJuridica.RazonSocial
                    txtDoc.Text = detalle_cliente.EmpresaJuridica.RUC
                End If
                Lista_detalle_orden_pedido = rn.Buscar_detalle_de_orden(orden_pedido.Codigo)
                modFunciones.EnlazarDatagridView(dgvProductos, Lista_detalle_orden_pedido)
            Else
                MetroMessageBox.Show(Me, "Este numero de Orden de Pedido ya esta facturado. Ingrese un numero de Orden de Pedido aun Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNumOrdenPedido.Text = ""
                txtNumOrdenPedido.Focus()
            End If

        End If
    End Sub

    Private Sub btnEfectuarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEfectuarPago.Click
        If cboFormaPago.SelectedItem <> "" Then
            Dim frm As New frmRegistroPagos
            frm.ShowDialog()
        Else
            MetroMessageBox.Show(Me, "Debe Seleccionar una forma de Pago", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txtNumOrdenPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumOrdenPedido.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And AscW(e.KeyChar) <> 8 Then ' ascw-->convierte la tecla a numero 
            e.Handled = True ' no permite pasar al numero 

        End If
    End Sub

    Private Sub numCuotas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCuotas.ValueChanged
        If numCuotas.Value <> 0 And txtMontoRestante.Text <> 0 Then
            Dim iAnual, iMensual, montoInteres, IGV, MontoTotalInteres As Double
            iAnual = 0.2999
            iMensual = iAnual / 12
            montoInteres = iMensual * CInt(numCuotas.Value) * CDbl(txtMontoRestante.Text)
            IGV = montoInteres * 0.18
            MontoTotalInteres = montoInteres + IGV
            MontoCuota = Math.Round((MontoTotalInteres + CDbl(txtMontoRestante.Text)) / CInt(numCuotas.Value), 2)
            dgvCuotas.Rows.Clear()
            For i As Integer = 0 To CInt(numCuotas.Value) - 1
                dgvCuotas.Rows.Add()
                dgvCuotas.Rows(i).Cells(0).Value = dtFecha.Value.Date.AddDays(30 * (i + 1)).ToString("dd/MM/yyyy")
                dgvCuotas.Rows(i).Cells(1).Value = i + 1
                dgvCuotas.Rows(i).Cells(2).Value = Math.Round(MontoTotalInteres / CInt(numCuotas.Value), 2)
                dgvCuotas.Rows(i).Cells(3).Value = MontoCuota

            Next

        Else
            dgvCuotas.Rows.Clear()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarControles()
    End Sub

   
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If CamposCompletos() = True Then
            Dim rnDV As New RNDocumentoVenta
            Dim rnDDV As New RNDetalleDocumentoVenta
            Dim idDocVenta As Integer = 0
            Dim DV As DocumentoVenta
            Dim DDV As DetalleDocumentoVenta
            Dim Lista_DetalleDocVenta As New List(Of DetalleDocumentoVenta)
            Dim CV As CuotaVenta
            Dim rnCV As New RNCuotaVenta

            If Lista_detalle_orden_pedido IsNot Nothing Then
                DV = New DocumentoVenta
                DV.TipoDoc = cboTipoDoc.SelectedItem.ToString
                DV.Serie = "1"
                DV.Numero = CInt(txtNumero.Text)
                DV.FechaEmision = dtFecha.Value
                DV.Total = txtTotal.Text
                DV.FormaPago = cboFormaPago.SelectedItem.ToString
                If cboFormaPago.SelectedItem = "CREDITO" Then
                    DV.Estado = "P"
                Else
                    DV.Estado = "E"
                End If
                DV.Caja = New Caja
                DV.Caja.Codigo = modPrincipal.CajaActualAbierta.Codigo
                DV.Caja.Empleado = New Empleado
                DV.Caja.Empleado.Codigo = modPrincipal.UsuarioLogeado.Empleado.Codigo
                DV.Cliente = New Cliente
                DV.Cliente.Codigo = orden_pedido.Cliente.Codigo
                DV.OrdenPedido = New OrdenPedido
                DV.OrdenPedido.Codigo = orden_pedido.Codigo
                DV.Empresa = New Empresa
                DV.Empresa.Codigo = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Empresa.Codigo

                Try
                    idDocVenta = rnDV.Agregar(DV)

                    For Each elem As DetalleOrdenPedido In Lista_detalle_orden_pedido
                        DDV = New DetalleDocumentoVenta
                        DDV.Modelo = New Modelo
                        DDV.Modelo.Codigo = elem.CodigoModelo
                        DDV.DocVenta = New DocumentoVenta
                        DDV.DocVenta.Codigo = idDocVenta
                        DDV.IGV = 0.18
                        DDV.Cantidad = elem.Cantidad
                        DDV.Total = elem.Total
                        rnDDV.Agregar(DDV)
                    Next

                    'rnPago.Agregar(Pago)
                    If cboFormaPago.SelectedItem = "CREDITO" Then
                        For i As Integer = 1 To numCuotas.Value
                            CV = New CuotaVenta
                            CV.DocVenta = New DocumentoVenta
                            CV.DocVenta.Codigo = idDocVenta
                            CV.Cliente = New Cliente
                            CV.Cliente.Codigo = orden_pedido.Cliente.Codigo
                            CV.NumeroCuota = i
                            CV.fecha = dtFecha.Value.Date.AddDays(30 * (i)).ToString("dd/MM/yyyy")
                            CV.Monto = MontoCuota
                            CV.Estado = False
                            rnCV.Registrar(CV)
                        Next
                    End If

                    Dim rnOrden As New RNOrdenPedido
                    rnOrden.Actualizar(orden_pedido)

                    MetroMessageBox.Show(Me,
                                     "Se registró correctamente la Venta." & vbNewLine & "N° de Documento de Venta: " & txtNumero.Text,
                                     "DOCUMENTO VENTA REGISTRADO",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                    btnImprimir.Enabled = True
                    num = Val(rn.BuscarNumDocumento) + 1
                    txtNumero.Text = String.Format("{0:0000000000}", num)
                    cboTipoDoc.Enabled = False
                    txtNumOrdenPedido.Enabled = False
                    cboFormaPago.Enabled = False
                    gbCuotas.Enabled = False
                    btnEfectuarPago.Enabled = False
                Catch ex As Exception
                    MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If

        Else
            MetroMessageBox.Show(Me, "Es necesario completar " & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CamposCompletos() As Boolean
        Dim Completo As Boolean = True
        If cboTipoDoc.SelectedItem = "" Then
            campos_faltan = campos_faltan & "  - Tipo de Documento (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboFormaPago.SelectedItem = "" Then
            campos_faltan = campos_faltan & "  - Forma de Pago (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If Pago Is Nothing And txtMontoInicial.Text <> "0" Then
            campos_faltan = campos_faltan & "  - No ha Registrado el Pago Respectivo." & vbNewLine
            Completo = False
        End If
        If cboFormaPago.SelectedItem = "CREDITO" And numCuotas.Value = 0 Then
            campos_faltan = campos_faltan & "  - No especifico Numero de Cuotas." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function

    Private Sub txtVendedor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVendedor.TextChanged
        If txtVendedor.Text <> "" Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub
End Class