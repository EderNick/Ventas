Public Class frmUsuario
    Private Actual As Usuario
    Private Empleado As Empleado

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
        Me.Actual = Nothing
        Me.txtEmpleado.Text = ""
        Me.txtUser.Text = ""
        Me.txtClave.Text = ""
        Me.cboTipoUsuario.SelectedIndex = Nothing

    End Sub

    Private Sub ActivarControles(ByVal wEstado As Boolean)
        Me.gbDatos.Enabled = wEstado
        Me.gbListado.Enabled = Not wEstado
        If wEstado = True Then
            Me.btnAgregarEmpleado.Focus()
        Else
            Me.txtUsuario.Focus()
        End If
    End Sub
    Private Sub ListarTipoUsuario()
        Dim rn As New RNTipoUsuario
        Dim TipoUsuario As List(Of TipoUsuario)

        Try
            TipoUsuario = rn.Listar()
            modFunciones.ListarComboBox(Me.cboTipoUsuario, TipoUsuario, "Codigo", "Nombre")

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNUsuario
        Dim u As Usuario

        If Me.ValidateChildren = True Then
            u = New Usuario
            u.Nombre = Me.txtUser.Text
            u.Empleado = New Empleado
            u.Empleado.Codigo = Empleado.Codigo
            u.Clave = Me.txtclave.Text
            u.TipoUsuario = DirectCast(Me.cboTipoUsuario.SelectedItem, TipoUsuario)
            rn = New RNUsuario
            Try
                If Me.Actual Is Nothing Then
                    If rn.VerificarUser(txtUser.Text) Then
                        MessageBox.Show("El UserName escrito ya esta en uso porfavor utilize otro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtUser.Text = ""
                    Else
                        rn.Registrar(u)
                        MessageBox.Show("Su Registro se Guardo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.ActivarControles(False)
                        ListarUsuarios()
                    End If

                Else
                    If rn.VerificarUser(txtUser.Text) Then
                        MessageBox.Show("El UserName escrito ya esta en uso porfavor utilize otro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtUser.Text = ""
                    Else
                        If (MessageBox.Show("¿Esta seguro de Guardar los cambios de este registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                            u.Codigo = Me.Actual.Codigo
                            'rn.Actualizar(u)
                            Me.ActivarControles(False)
                            ListarUsuarios()
                        Else
                            Me.ActivarControles(True)
                        End If
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                u = Nothing
            End Try

        End If
    End Sub


    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarUsuarios()
        ListarTipoUsuario()
    End Sub

    Private Sub btnAgregarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEmpleado.Click
        Dim frm As New frmBuscarEmpleado

        Empleado = frm.Buscar()
        'Me.numCantidad.Value = 1
        If Empleado IsNot Nothing Then
            Me.txtEmpleado.Text = Empleado.Nombres
            'Me.AcceptButton = Me.btnAgregar
        Else
            Me.txtEmpleado.Text = ""
            'Me.numPrecio.Value = Me.numPrecio.Minimum
        End If
    End Sub

    
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarUsuarios()
    End Sub

    Private Sub ListarUsuarios()
        Dim rn As New RNUsuario
        Dim usuario As List(Of Usuario)

        Try
            usuario = rn.ListarUsuarios(Me.txtUsuario.Text)
            modFunciones.EnlazarDatagridView(Me.dgvUsuarios, usuario)
            Me.dgvUsuarios.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.txtEmpleado.Text = ""
        Me.txtUser.Text = ""
        Me.txtclave.Text = ""
        Me.cboTipoUsuario.SelectedIndex = Nothing
        Me.gbDatos.Enabled = False
    End Sub

    Private Sub btnVerificarUserDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarUserDisponible.Click
        Dim rn As New RNUsuario

        Try
            If rn.VerificarUser(txtUser.Text) Then
                MessageBox.Show("UserName ya en Uso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUser.Text = ""
            Else
                MessageBox.Show("UserName Disponible", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub


End Class