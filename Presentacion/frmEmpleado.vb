Imports System.Text.RegularExpressions
Public Class frmEmpleado

    Private Actual As Empleado
    Private sucursal As New Sucursal
    Private campos_faltan As String
    Private idsucursal As Integer = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Codigo

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If rbNombre.Checked = True Then
            ListarTodosEmpleados()
        Else
            ListarEmpleadosDNI()
        End If
    End Sub

    Private Sub ListarTodosEmpleados()
        Dim rn As New RNEmpleado
        Dim empleado As List(Of Empleado)
        Try
            empleado = rn.Listar(Me.txtEmpleado.Text, 1, idsucursal)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarEmpleadosDNI()
        Dim rn As New RNEmpleado
        Dim empleado As List(Of Empleado)
        Try
            empleado = rn.Listar(Me.txtEmpleado.Text, 0, idsucursal)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListarTodosEmpleados()
        gbEmpleado.Enabled = False
    End Sub
    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim rn As RNEmpleado
        Dim Em As Empleado
        campos_faltan = ""
        If CamposCompletos() = True Then
            If Me.ValidateChildren = True Then
                Em = New Empleado
                Em.Nombres = Me.txtNombres.Text
                Em.Ap_Paterno = Me.txtAPaterno.Text
                Em.Ap_Materno = Me.txtAMaterno.Text
                Em.Dni = Me.txtDNI.Text
                Em.Telefono = Me.txtTelefono.Text
                Em.Correo = Me.txtCorreo.Text
                Em.Cargo = Me.cmbTipo.Text
                Em.Direccion = Me.txtDireccion.Text
                Em.Celular = Me.txtCelular.Text
                Em.Vigencia = Me.cboVigencia.Text
                Em.Num_Licencia = Me.txtNLicencia.Text
                rn = New RNEmpleado
                Try
                    If Me.Actual Is Nothing Then
                        rn.Registrar(Em, idsucursal)
                        MessageBox.Show("Se Registro el Empleado con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        limpiar()
                        Me.ActivarControles(False)
                        gbEmpleado.Enabled = False
                        ListarTodosEmpleados()
                        limpiar()
                    Else
                        If (MessageBox.Show("¿Esta seguro de Modificar los datos del Empleado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                            Em.Codigo = Me.Actual.Codigo
                            rn.Actualizar(Em, idsucursal)
                            limpiar()
                            Me.ActivarControles(False)
                            gbEmpleado.Enabled = False
                            ListarTodosEmpleados()
                        Else
                            Me.ActivarControles(True)
                        End If
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    rn = Nothing
                    e = Nothing
                End Try
            End If
        Else
            MessageBox.Show(Me, "Es necesario completar todos los campos" & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CamposCompletos() As Boolean
        Dim Completo As Boolean = True
        If txtNombres.Text = "" Then
            campos_faltan = campos_faltan & "  - Nombre(Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtAPaterno.Text = "" Then
            campos_faltan = campos_faltan & "  - Apellido-Paterno(Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtAMaterno.Text = "" Then
            campos_faltan = campos_faltan & "  - Apellido-aterno(Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtDNI.Text = "" Or Len(txtDNI.Text) < 8 Then
            campos_faltan = campos_faltan & "  - DNI(Debe tener 8 digitos de DNI)." & vbNewLine
            Completo = False
        End If
        If txtDireccion.Text = "" Then
            campos_faltan = campos_faltan & "  - Direccion( falta completar)." & vbNewLine
            Completo = False
        End If
        If cmbTipo.Text = "" Then
            campos_faltan = campos_faltan & "  - TipoEmpleado(Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboVigencia.Text = "" Then
            campos_faltan = campos_faltan & "  - Vigencia(Seleccionar Vigencia)." & vbNewLine
            Completo = False
        End If
        If txtCelular.Text <> "" Then
            If Len(txtCelular.Text) < 9 Then
                campos_faltan = campos_faltan & "  - Celular ( 9 digitos de celular)." & vbNewLine
                Completo = False
            End If
        End If
        If txtTelefono.Text <> "" Then
            If Len(txtTelefono.Text) < 6 Then
                campos_faltan = campos_faltan & "  - telefono ( 6 digitos de celular)." & vbNewLine
                Completo = False
            End If
        End If
        Return Completo
    End Function


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvEmpleados.CurrentRow IsNot Nothing Then
            Me.Actual = DirectCast(Me.dgvEmpleados.CurrentRow.DataBoundItem, Empleado)
            Me.PresentarDatos()
        Else
            MessageBox.Show("Debe seleccionar un Empleado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PresentarDatos()
        Dim rn As New RNEmpleado
        Try
            Me.Actual = rn.Leer(Me.Actual, idsucursal)
            If Me.Actual IsNot Nothing Then
                With Me.Actual
                    Me.txtNombres.Text = .Nombres
                    Me.txtAPaterno.Text = .Ap_Paterno
                    Me.txtAMaterno.Text = .Ap_Materno
                    cmbTipo.SelectedItem = .Cargo
                    Me.txtDNI.Text = .Dni
                    Me.txtNLicencia.Text = .Num_Licencia
                    Me.txtDireccion.Text = .Direccion
                    Me.txtTelefono.Text = .Telefono
                    Me.txtCelular.Text = .Celular
                    Me.txtCorreo.Text = .Correo
                    Me.cboVigencia.SelectedItem = .Vigencia
                End With
                Me.ActivarControles(True)
            Else
                MessageBox.Show("No se encontró el Empleado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub limpiar()
        Me.txtNombres.Clear()
        Me.txtAPaterno.Clear()
        Me.txtAMaterno.Clear()
        Me.txtDNI.Clear()
        Me.txtTelefono.Clear()
        Me.txtCorreo.Clear()
        Me.cmbTipo.selecteditem = -1
        Me.txtDireccion.Clear()
        Me.txtCelular.Clear()
        Me.cboVigencia.SelectedItem = -1
        Me.txtNLicencia.Clear()
        Me.MetroRadioButton1.Checked = False
        Me.txtNLicencia.Enabled = False
        Me.txtEmpleado.Clear()
    
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
        Me.Actual = Nothing
        limpiar()
    End Sub
    Private Sub ActivarControles(ByVal wEstado As Boolean)
        Me.gbEmpleado.Enabled = wEstado
        Me.gbListar.Enabled = Not wEstado
        If wEstado = True Then
            Me.btnGuardar.Focus()
        Else
            Me.txtNombres.Focus()
        End If
    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress, txtTelefono.KeyPress, txtDNI.KeyPress, txtNLicencia.KeyPress
        teclear(e, False)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress, txtAMaterno.KeyPress, txtAPaterno.KeyPress
        teclear(e, True)
    End Sub

    Sub teclear(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal val As Boolean)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = val
        ElseIf Char.IsPunctuation(e.KeyChar) And val = True Then
            e.Handled = val
        ElseIf Char.IsSymbol(e.KeyChar) And val = True Then
            e.Handled = val
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = Not val
        Else
            e.Handled = Not val
        End If
    End Sub

    Private Sub txtEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpleado.KeyPress
        If rbNombre.Checked = True Then
            teclear(e, True)
        ElseIf rbDNI.Checked = True Then
            teclear(e, False)
        Else
            MessageBox.Show("Seleccione un tipo de busqueda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmpleado.Clear()
            txtEmpleado.Focus()
        End If
    End Sub

    Private Sub rbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombre.CheckedChanged
        If rbNombre.Checked = True Then
            txtEmpleado.Clear()
            txtEmpleado.MaxLength = 25
        Else
            txtEmpleado.Clear()
            txtEmpleado.MaxLength = 8
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        Me.ActivarControles(False)
    End Sub

    Public Function validar_Mail(ByVal Mail As String) As Boolean
        Return Regex.IsMatch(Mail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function



    Private Sub txtCorreo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorreo.Leave
        If validar_Mail(LCase(txtCorreo.Text)) = False Then
            If (txtCorreo.Text <> "") Then
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, ingrese un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
                txtCorreo.Focus()
                txtCorreo.Clear()
            End If
        End If
    End Sub


    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub MetroRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroRadioButton1.CheckedChanged
        txtNLicencia.Enabled = True
    End Sub
End Class
