Public Class frmCaja

    Private Empleado As Empleado
    Private Sucursal As Sucursal

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

    Private Sub CargarCajasAbiertas()
        Dim rn As RNCaja
        Dim cajasAb As List(Of Caja)

        rn = New RNCaja

        Try
            cajasAb = rn.ListarCajasAbiertas()
            modFunciones.ListarComboBox(Me.cboCajasAbiertas, cajasAb, "Codigo", "Numero")
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub ListarCajas()
        Dim rn As RNCaja
        Dim cajas As List(Of Caja)

        rn = New RNCaja

        Try
            cajas = rn.Listar()
            modFunciones.EnlazarDatagridView(Me.dgvCaja, cajas)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub btnGuardarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInicio.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.ValidateChildren = True Then
            ca = New Caja
            ca.Numero = Me.txtNumero.Text
            ca.Descripcion = Me.txtDescripcion.Text
            ca.MontoApertura = CDbl(txtMontoApertura.Text)
            ca.MontoCierre = ca.MontoApertura
            ca.FechaApertura = dtpApertura.Value
            ca.FechaCierre = ca.FechaApertura
            ca.Estado = True 'la caja esta abierta
            ca.Empleado = New Empleado
            'ca.Empleado.Codigo = Empleado.Codigo
            ca.Empleado.Codigo = 1
            ca.Sucursal = New Sucursal
            'ca.Sucursal.Codigo = Sucursal.Codigo
            ca.Sucursal.Codigo = 1
            rn = New RNCaja
            Try

                rn.Registrar(ca)
                MetroMessageBox.Show(Me, "Se inició caja corectamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ListarCajas()
                CargarCajasAbiertas()
                Me.ActivarControles(False)
                'ListarCajas("")
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAhoraI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAhoraI.Click, btnAhoraI.Click
        dtpApertura.Value = Now
    End Sub

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarCajas()
        CargarCajasAbiertas()
    End Sub

    Private Sub btnCancelarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarInicio.Click
        LimpiarControles()
        ActivarControles(False)
    End Sub

    Private Sub btnGuardarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCierre.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.ValidateChildren = True Then
            ca = New Caja

            ca.Codigo = DirectCast(cboCajasAbiertas.SelectedItem, Caja).Codigo
            ca.Descripcion = Me.txtObservacion.Text
            ca.MontoCierre = CDbl(txtMontoCierre.Text)
            ca.FechaCierre = dtpCierre.Value
            ca.Estado = False 'la caja se cierra

            rn = New RNCaja
            Try

                rn.Actualizar(ca)
                MetroMessageBox.Show(Me, "Se cerró la caja " + cboCajasAbiertas.Text + " exitosamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ListarCajas()
                CargarCajasAbiertas()
                Me.ActivarControles(False)
                'ListarCajas("")
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                ca = Nothing
            End Try

        End If
    End Sub

    Private Sub btnCancelarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCierre.Click
        LimpiarControles()
    End Sub
End Class