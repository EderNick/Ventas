Public Class frmCaja

    Private Empleado As Empleado = modPrincipal.UsuarioLogeado.Empleado
    Private Sucursal As Sucursal = modPrincipal.UsuarioLogeado.Empleado.Sucursal
    Private campos_faltan As String

    Private Sub LimpiarControles()
        txtNumero.Text = ""
        txtDescripcion.Text = ""
        txtMontoApertura.Text = ""
        txtMontoCierre.Text = ""
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

    Private Function CamposCompletosIniciar() As Boolean
        Dim Completo As Boolean = True
        If txtNumero.Text = "" Then
            campos_faltan = campos_faltan & "  - Número de caja (Falta completar)." & vbNewLine
            Completo = False
        End If
        If txtMontoApertura.Text = "" Then
            campos_faltan = campos_faltan & "  - Monto de apertura (Falta completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function

    Private Function CamposCompletosCerrar() As Boolean
        Dim Completo As Boolean = True
        If cboCajasAbiertas.Text = "" Then
            campos_faltan = campos_faltan & "  - Número de caja (Falta seleccionar)." & vbNewLine
            Completo = False
        End If
        If txtMontoCierre.Text = "" Then
            campos_faltan = campos_faltan & "  - Monto de cierre (Falta completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function

    Private Sub btnGuardarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInicio.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.CamposCompletosIniciar = True Then
            ca = New Caja
            ca.Numero = Me.txtNumero.Text
            ca.Descripcion = Me.txtDescripcion.Text
            ca.MontoApertura = CDbl(txtMontoApertura.Text)
            ca.MontoCierre = ca.MontoApertura
            ca.FechaApertura = Now
            ca.FechaCierre = ca.FechaApertura
            ca.Estado = True 'la caja esta abierta
            ca.Empleado = New Empleado
            ca.Empleado.Codigo = Empleado.Codigo
            'ca.Empleado.Codigo = 1
            ca.Sucursal = New Sucursal
            ca.Sucursal.Codigo = Sucursal.Codigo
            'ca.Sucursal.Codigo = 1
            rn = New RNCaja
            Try

                rn.Registrar(ca)
                MetroMessageBox.Show(Me, "Se inició caja corectamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCajasAbiertas()
                'ListarCajas("")
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                ca = Nothing
            End Try

        Else
            MetroMessageBox.Show(Me, "Es necesario completar estos datos correctamente: " & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            campos_faltan = ""
        End If
    End Sub

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCajasAbiertas()
    End Sub

    Private Sub btnCancelarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarInicio.Click
        LimpiarControles()
        Me.Close()
    End Sub

    Private Sub btnGuardarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCierre.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.CamposCompletosCerrar = True Then
            ca = New Caja

            ca.Codigo = DirectCast(cboCajasAbiertas.SelectedItem, Caja).Codigo
            ca.Descripcion = Me.txtObservacion.Text
            ca.MontoCierre = CDbl(txtMontoCierre.Text)
            ca.FechaCierre = Now
            ca.Estado = False 'la caja se cierra

            rn = New RNCaja
            Try

                rn.Actualizar(ca)
                MetroMessageBox.Show(Me, "Se cerró la caja " + cboCajasAbiertas.Text + " exitosamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCajasAbiertas()
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                ca = Nothing
            End Try
        Else
            MetroMessageBox.Show(Me, "Es necesario completar estos datos correctamente: " & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            campos_faltan = ""
        End If
    End Sub

    Private Sub btnCancelarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCierre.Click
        LimpiarControles()
        Me.Close()
    End Sub
End Class