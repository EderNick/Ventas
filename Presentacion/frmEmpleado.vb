Public Class frmEmpleado

    Private Actual As Empleado

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If rbNombre.Checked = True Then
            ListarEmpleados()
        Else
            ListarEmpleadosDNI()
        End If
    End Sub

    Private Sub ListarEmpleados()
        Dim rn As New RNEmpleado
        Dim empleado As List(Of Empleado)

        Try
            empleado = rn.Listar(Me.txtEmpleado.Text, 1)
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
            empleado = rn.Listar(Me.txtEmpleado.Text, 0)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarEmpleados()
        ListarSucursal()
    End Sub
    Private Sub ListarSucursal()
        Dim rn As New RNSucursal
        Dim sucursal As List(Of Sucursal)

        Try
            sucursal = rn.Listar("")
            modFunciones.ListarComboBox(Me.cboSucursal, sucursal, "Codigo", "ZonaNombre")

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim rn As RNEmpleado
        Dim Em As Empleado


        If Me.ValidateChildren = True Then
            Em = New Empleado
            Em.Nombres = Me.txtNombres.Text
            Em.Ap_Paterno = Me.txtAPaterno.Text
            Em.Ap_Materno = Me.txtAMaterno.Text
            Em.Dni = Me.txtDNI.Text
            Em.Telefono = Me.txtTelefono.Text
            Em.Correo = Me.txtCorreo.Text
            Em.Cargo = Me.txtCargo.Text
            Em.Sucursal = DirectCast(Me.cboSucursal.SelectedItem, Sucursal)
            Em.Direccion = Me.txtDireccion.Text
            Em.Celular = Me.txtCelular.Text
            Em.Vigencia = Me.cboVigencia.Text
            Em.Num_Licencia = Me.txtNLicencia.Text

            rn = New RNEmpleado
            Try
                If Me.Actual Is Nothing Then
                    rn.Registrar(Em)
                    MessageBox.Show("Se Registro el Empleado con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    limpiar()
                    Me.ActivarControles(False)
                    ListarEmpleados()
                    limpiar()
                Else
                    If (MessageBox.Show("¿Esta seguro de Modificar los datos del Empleado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        Em.Codigo = Me.Actual.Codigo
                        rn.Actualizar(Em)
                        limpiar()
                        Me.ActivarControles(False)
                        ListarEmpleados()
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
    End Sub

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
            Me.Actual = rn.Leer(Me.Actual)
            If Me.Actual IsNot Nothing Then
                With Me.Actual
                    Me.txtNombres.Text = .Nombres
                    Me.txtAPaterno.Text = .Ap_Paterno
                    Me.txtAMaterno.Text = .Ap_Materno
                    Me.txtCargo.Text = .Cargo
                    Me.txtDNI.Text = .Dni
                    Me.txtNLicencia.Text = .Num_Licencia
                    Me.txtDireccion.Text = .Direccion
                    Me.txtTelefono.Text = .Telefono
                    Me.txtCelular.Text = .Celular
                    Me.txtCorreo.Text = .Correo
                    Me.cboVigencia.Text = .Vigencia
                    Me.cboSucursal.Text = .Sucursal.Direccion
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
        Me.txtCargo.Clear()
        Me.cboSucursal.SelectedItem = -1
        Me.txtDireccion.Clear()
        Me.txtCelular.Clear()
        Me.cboVigencia.SelectedItem = -1
        Me.txtNLicencia.Clear()
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

    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress, txtTelefono.KeyPress, txtDNI.KeyPress
        teclear(e, False)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress, txtAMaterno.KeyPress, txtAPaterno.KeyPress, txtCargo.KeyPress
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.ActivarControles(False)
    End Sub
End Class
