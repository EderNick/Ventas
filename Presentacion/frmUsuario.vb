Public Class frmUsuario
    Private Actual As Sucursal

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
            'u.Empleado .Codigo = Me.txtEmpleado .Text
            u.Clave = Me.txtClave.Text
            u.TipoUsuario = DirectCast(Me.cboTipoUsuario.SelectedItem, TipoUsuario)
            rn = New RNUsuario
            Try
                If Me.Actual Is Nothing Then
                    rn.Registrar(u)
                    MessageBox.Show("Su Registro se Guardo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.ActivarControles(False)
                    'ListarUsuarios("")
                Else
                    If (MessageBox.Show("¿Esta seguro de Guardar los cambios de este registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                        u.Codigo = Me.Actual.Codigo
                        'rn.Actualizar(u)
                        Me.ActivarControles(False)
                        'ListarUsuarios("")
                    Else
                        Me.ActivarControles(True)
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
        'ListarUsuarios()
    End Sub
End Class