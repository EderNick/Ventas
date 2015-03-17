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
            txtMontoRestante.Text = txtTotal.Text
            txtMontoInicial.Text = "0"
        Else
            gbCuotas.Enabled = False
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
        Else
            txtMontoRestante.Text = CDbl(txtTotal.Text) - CDbl(txtMontoInicial.Text)
        End If
    End Sub

 
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub
End Class