Public Class frmOrdenPedido

    Private Cliente As Cliente
    Private DetCliente As DetalleCliente

    Private Sub frmOrdenPedido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyData = Keys.Control + Keys.X Then 'salir
                Me.Close()
            End If
            If e.KeyData = Keys.Control + Keys.N Then 'Nuevo
                LimpiarControles()
            End If
            If e.KeyData = Keys.Control + Keys.G Then 'Nuevo
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
        txtProducto.Text = ""
        txtPrecioUnitario.Text = ""
        txtCantidad.Text = ""
        txtMonto.Text = ""
        dgvProductos.DataSource = ""
        'dgvProductos.Rows.Clear()
        txtSubTotal.Text = "0.00"
        Me.AcceptButton = btnBuscarCliente
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
            Me.AcceptButton = btnBuscarProducto
        End If
    End Sub
End Class