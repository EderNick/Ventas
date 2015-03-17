Public Class frmOrdenPedido

    Private idEmpleado As Integer = modPrincipal.UsuarioLogeado.Empleado.Codigo
    Private DetCliente As DetalleCliente
    Private DetalleModeloSuc As DetalleModeloSucursal

    Private ListaDetProd As New List(Of DetalleOrdenPedido)

    Private Sub frmOrdenPedido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyData = Keys.Control + Keys.X Then 'salir
                Me.Close()
            End If
            If e.KeyData = Keys.Control + Keys.N Then 'Nuevo
                LimpiarControles()
            End If
            If e.KeyData = Keys.Control + Keys.G Then 'guardar
                'Registrar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LimpiarControles()
        txtCliente.Text = ""
        dtpFecha.Value = Now
        LimpiarControlesProducto()
        gbProducto.Enabled = False
        dgvProductos.DataSource = ""
        ListaDetProd.Clear()
        DetCliente = Nothing
        DetalleModeloSuc = Nothing
        'dgvProductos.Rows.Clear()
        txtSubTotal.Text = "0.00"
        Me.AcceptButton = btnBuscarCliente
    End Sub

    Private Sub LimpiarControlesProducto()
        txtProducto.Text = ""
        txtPrecioUnitario.Text = ""
        txtCantidad.Text = ""
        txtCantidad.Enabled = False
        txtMonto.Text = "0.00"
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim frm As New frmBuscarCliente
        DetCliente = frm.Buscar()

        If DetCliente IsNot Nothing Then
            If DetCliente.Cliente.Tipo = "N" Then
                Me.txtCliente.Text = DetCliente.Persona.Nombres + " " + DetCliente.Persona.Ap_Paterno + " " + DetCliente.Persona.Ap_Materno
            End If
            If DetCliente.Cliente.Tipo = "J" Then
                Me.txtCliente.Text = DetCliente.EmpresaJuridica.RazonSocial
            End If
            gbProducto.Enabled = True
            LimpiarControlesProducto()
            Me.AcceptButton = btnBuscarProducto
        Else
            LimpiarControles()
            Me.AcceptButton = btnBuscarCliente
        End If
    End Sub

    Private Sub frmOrdenPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnBuscarCliente
        gbProducto.Enabled = False
    End Sub

    Private Sub btnBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProducto.Click
        Dim frm As New frmBuscarProducto
        DetalleModeloSuc = frm.Buscar()

        If DetalleModeloSuc IsNot Nothing Then
            txtProducto.Text = DetalleModeloSuc.Modelo.NombreCompletoProducto
            txtPrecioUnitario.Text = DetalleModeloSuc.PrecioVenta
            txtCantidad.Enabled = True
            txtCantidad.Focus()
            txtCantidad.Text = ""
            txtMonto.Text = "0.00"
            Me.AcceptButton = btnAgregar
        Else
            LimpiarControlesProducto()
            Me.AcceptButton = btnBuscarProducto
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Then
            txtMonto.Text = "0.00"
        Else
            txtMonto.Text = CDbl(txtPrecioUnitario.Text) * CInt(txtCantidad.Text)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCantidad.Text <> "" Then
            If CInt(txtCantidad.Text) > 0 Then
                Dim DetOrdenPedido As New DetalleOrdenPedido
                DetOrdenPedido.Modelo = DetalleModeloSuc.Modelo
                DetOrdenPedido.Cantidad = CInt(txtCantidad.Text)
                DetOrdenPedido.Total = CDbl(txtMonto.Text)

                ListaDetProd.Add(DetOrdenPedido)

                modFunciones.EnlazarDatagridView(dgvProductos, ListaDetProd)
                SumarSubTotales()
                LimpiarControlesProducto()
                Me.AcceptButton = btnBuscarProducto
            Else
                MetroMessageBox.Show(Me, "La cantidad debe ser mayor a 0.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCantidad.Focus()
            End If

        End If


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        EliminarProductoSeleccionado()
        SumarSubTotales()
    End Sub

    Private Sub EliminarProductoSeleccionado()
        Dim elemSelec As DetalleOrdenPedido

        If Me.dgvProductos.CurrentRow IsNot Nothing Then
            elemSelec = DirectCast(dgvProductos.CurrentRow.DataBoundItem, DetalleOrdenPedido) 'capturo el elemento a eliminar
            For i As Integer = 0 To ListaDetProd.Count - 1
                If elemSelec.Modelo.Codigo = ListaDetProd(i).Modelo.Codigo Then
                    ListaDetProd.Remove(elemSelec) 'elimina el elemento del List(Of )
                    modFunciones.EnlazarDatagridView(dgvProductos, ListaDetProd) 'Vuelve a cargar la lista sin el elemento eliminado
                    Exit For
                End If
            Next

            'dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index) 'eliminacion directa sin DataSource
        End If
    End Sub

    Private Sub SumarSubTotales()
        Dim subTotal As Double = 0.0
        For Each elem As DetalleOrdenPedido In ListaDetProd
            subTotal = subTotal + elem.Total
        Next
        txtSubTotal.Text = Math.Round(subTotal, 2)
    End Sub

    Private Sub btnGuardarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCierre.Click
        Dim OP As OrdenPedido
        Dim rnOP As RNOrdenPedido
        Dim rnDetOP As RNDetalleOrdenPedido
        Dim idOrdenPedido As Integer

        If ListaDetProd IsNot Nothing And DetCliente IsNot Nothing Then
            OP = New OrdenPedido
            OP.Numero = CInt(txtNumero.Text)
            OP.FechaEmision = dtpFecha.Value
            OP.Total = CDbl(txtSubTotal.Text)
            OP.Estado = "P"
            OP.Vigencia = True
            OP.Empleado = New Empleado
            OP.Empleado.Codigo = idEmpleado
            OP.Cliente = New Cliente
            OP.Cliente.Codigo = DetCliente.Cliente.Codigo
            Try
                rnOP = New RNOrdenPedido
                idOrdenPedido = rnOP.Agregar(OP)
                rnDetOP = New RNDetalleOrdenPedido
                For Each elem As DetalleOrdenPedido In ListaDetProd
                    elem.OrdenPedido = New OrdenPedido
                    elem.OrdenPedido.Codigo = idOrdenPedido

                    rnDetOP.Agregar(elem)
                Next
                MetroMessageBox.Show(Me,
                                     "Se registró correctamente la orden de pedido." & vbNewLine & "N° de Pedido: " & txtNumero.Text,
                                     "ODEN DE PEDIDO REGISTRADA",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                LimpiarControles()
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        
    End Sub


End Class