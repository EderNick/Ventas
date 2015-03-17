Public Class frmMantenimientoCuentasBancarias

    Private Sub frmMantenimientoCuentasBancarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarBancos()
        ListarCuentas()
    End Sub

    Private Sub CargarBancos()
        Dim rn As RNBanco
        Dim Bancos As List(Of Banco)

        Try
            rn = New RNBanco
            Bancos = rn.Listar()
            modFunciones.ListarComboBox(Me.cboBanco, Bancos, "Codigo", "Nombre")
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarControles()
        tabLista.Enabled = True
        tabDatos.Enabled = False
    End Sub

    Private Sub LimpiarControles()
        cboBanco.SelectedIndex = -1
        txtCCI.Text = ""
        chkVigencia.Checked = True
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarControles()
        tabDatos.Enabled = True
        tabLista.Enabled = False
        chkVigencia.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNCuentaVenta
        Dim cu As CuentaVenta
        If txtCCI.Text <> "" Then
            cu = New CuentaVenta
            cu.CCI = txtCCI.Text
            If chkVigencia.Checked = True Then
                cu.Vigencia = True
            Else
                cu.Vigencia = False
            End If
            cu.Banco = New Banco
            cu.Banco = DirectCast(cboBanco.SelectedItem, Banco)
            rn = New RNCuentaVenta
            Try

                rn.Registrar(cu)
                MetroMessageBox.Show(Me, "Se registró correctamente la Cuenta Bancaria.", "REGISTRO DE CUENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarCuentas()
                LimpiarControles()
                tabDatos.Enabled = False
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
            End Try

        Else
            MetroMessageBox.Show(Me, "Es necesario completar los datos correctamente.", "CAMPOS INCOMPLETOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ListarCuentas()
        Dim rn As New RNCuentaVenta
        Dim Cuentas As List(Of CuentaVenta)

        Try
            Cuentas = rn.Listar()
            modFunciones.EnlazarDatagridView(Me.dgvCuentas, Cuentas)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
