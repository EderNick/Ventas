Public Class frmDocumentoVenta
    Private Actual As DocumentoVenta

    Private Sub frmDocumentoVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rn As New RNDocumentoVenta
        Dim num As Integer = 0
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
        Me.txtSubTotal.Text = "0"
        Me.txtIGV.Text = "0"
        Me.txtDescuento.Text = "0"
        Me.txtTotal.Text = "0"
        Me.txtMontoInicial.Text = "0"
        Me.txtMontoRestante.Text = "0"
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
        If txtMontoInicial.Text = "" Then
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
            Dim orden_pedido As New OrdenPedido
            Dim detalle_orden_pedido As New List(Of DetalleOrdenPedido)
            orden_pedido = rn.Buscar_Orden_de_Pedido(txtNumOrdenPedido.Text)
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
            detalle_orden_pedido = rn.Buscar_detalle_de_orden(orden_pedido.Codigo)
            modFunciones.EnlazarDatagridView(dgvProductos, detalle_orden_pedido)
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
            Dim iAnual, iMensual, montoInteres, IGV, MontoTotalInteres, MontoCuota As Double
            iAnual = 0.2999
            iMensual = iAnual / 12
            montoInteres = iMensual * CInt(numCuotas.Value) * CDbl(txtMontoRestante.Text)
            IGV = montoInteres * 0.18
            MontoTotalInteres = montoInteres + IGV
            MontoCuota = Math.Round((MontoTotalInteres + CDbl(txtMontoRestante.Text)) / CInt(numCuotas.Value), 2)
            dgvCuotas.Rows.Clear()
            For i As Integer = 0 To CInt(numCuotas.Value) - 1
                dgvCuotas.Rows.Add()
                dgvCuotas.Rows(i).Cells(0).Value = MetroDateTime1.Value.Date.AddDays(30 * (i + 1)).ToString("dd/MM/yyyy")
                dgvCuotas.Rows(i).Cells(1).Value = i + 1
                dgvCuotas.Rows(i).Cells(2).Value = Math.Round(MontoTotalInteres / CInt(numCuotas.Value), 2)
                dgvCuotas.Rows(i).Cells(3).Value = MontoCuota
            Next

        Else
            dgvCuotas.Rows.Clear()
        End If
    End Sub
End Class