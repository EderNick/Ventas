Public Class frmCajaCierre

    Private Empleado As Empleado = modPrincipal.UsuarioLogeado.Empleado
    Private Sucursal As Sucursal = modPrincipal.UsuarioLogeado.Empleado.Sucursal
    Private CajaAbierta As Caja = modPrincipal.CajaActualAbierta
    Private campos_faltan As String

    Private Sub LimpiarControles()
        txtObservacion.Text = ""
        txtMontoCierre.Text = ""
    End Sub

    'Private Sub CargarCajaAbierta()
    '    Dim rn As RNCaja
    '    rn = New RNCaja

    '    Try
    '        CajaAbierta = New Caja
    '        CajaAbierta = rn.CargarCajaAbiertaxEmpleado(Empleado.Codigo)
    '    Catch ex As Exception
    '        MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        rn = Nothing
    '    End Try
    'End Sub

    Private Function CamposCompletosCerrar() As Boolean
        Dim Completo As Boolean = True
        If txtMontoCierre.Text = "" Then
            campos_faltan = campos_faltan & "  - Monto de cierre (Falta completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CargarCajaAbierta()
        txtNumCaja.Text = CajaAbierta.Numero
        'txtMontoCierre.Text = 'total de ventas hechas en su caja
    End Sub

    Private Sub btnGuardarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCierre.Click
        Dim rn As RNCaja
        Dim ca As Caja

        If Me.CamposCompletosCerrar = True Then
            ca = New Caja

            ca.Codigo = CInt(txtNumCaja.Text)
            ca.Descripcion = CajaAbierta.Descripcion & Me.txtObservacion.Text
            ca.MontoCierre = CDbl(txtMontoCierre.Text)
            If CajaAbierta.FechaApertura.Hour = CajaAbierta.FechaCierre.Hour Then 'la caja aun está abierta
                ca.FechaCierre = Now
                ca.Estado = False 'la caja se cierra
            End If
            rn = New RNCaja
            Try

                rn.Actualizar(ca)
                MetroMessageBox.Show(Me, "Se cerró la caja " + txtNumCaja.Text + " exitosamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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