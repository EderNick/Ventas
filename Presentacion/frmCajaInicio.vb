Public Class frmCajaInicio

    Private Empleado As Empleado = modPrincipal.UsuarioLogeado.Empleado
    Private Sucursal As Sucursal = modPrincipal.UsuarioLogeado.Empleado.Sucursal
    Private CajaAbierta As Caja
    Private campos_faltan As String

    Private Sub LimpiarControles()
        txtNumero.Text = ""
        txtDescripcion.Text = ""
        txtMontoApertura.Text = ""
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

    Public Function IniciarCaja()
        Me.ShowDialog()
        Return CajaAbierta
    End Function

    Private Sub btnGuardarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInicio.Click
        Dim rn As RNCaja
        'Dim ca As Caja
        If Me.CamposCompletosIniciar = True Then
            CajaAbierta = New Caja
            CajaAbierta = New Caja
            CajaAbierta.Numero = Me.txtNumero.Text
            CajaAbierta.Descripcion = Me.txtDescripcion.Text
            CajaAbierta.MontoApertura = CDbl(txtMontoApertura.Text)
            CajaAbierta.MontoCierre = CajaAbierta.MontoApertura
            CajaAbierta.FechaApertura = Now
            CajaAbierta.FechaCierre = CajaAbierta.FechaApertura
            CajaAbierta.Estado = True 'la caja esta abierta
            CajaAbierta.Empleado = New Empleado
            CajaAbierta.Empleado.Codigo = Empleado.Codigo
            'ca.Empleado.Codigo = 1
            CajaAbierta.Sucursal = New Sucursal
            CajaAbierta.Sucursal.Codigo = Sucursal.Codigo
            'ca.Sucursal.Codigo = 1
            rn = New RNCaja
            Try

                rn.Registrar(CajaAbierta)
                MetroMessageBox.Show(Me, "Se inició caja corectamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                CajaAbierta = Nothing
            End Try

        Else
            MetroMessageBox.Show(Me, "Es necesario completar estos datos correctamente: " & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            campos_faltan = ""
        End If
    End Sub

    Private Sub btnCancelarInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarInicio.Click
        LimpiarControles()
        Me.Close()
    End Sub
End Class