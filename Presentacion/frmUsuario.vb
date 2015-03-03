Public Class frmUsuario
    Private Actual As Usuario
    Private Empleado As Empleado
    Private campos_faltan As String
    Private CambiarPass As Boolean = False

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ActivarControles(False)
        ListarUsuarios()
        ListarTipoUsuario()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
        Me.Actual = Nothing
        Me.txtEmpleado.Text = ""
        Me.txtUser.Text = ""
        Me.txtclave.Text = ""
        Me.txtRepClave.Text = ""
        Me.cboTipoUsuario.SelectedIndex = -1
        Me.gbEstado.Enabled = False
        Me.lbPassword.Text = "PASSWORD"
        Me.lbPassword2.Text = "REPITA PASSWORD"
        Me.btnCambiarPass.Visible = False
        Me.gbEstado.Enabled = False
        Me.rbActivo.Checked = True
    End Sub
    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.txtEmpleado.Text = ""
        Me.txtUser.Text = ""
        Me.txtclave.Text = ""
        Me.txtRepClave.Text = ""
        Me.cboTipoUsuario.SelectedIndex = -1
        ActivarControles(False)
        lbPassword.Text = "PASSWORD"
        lbPassword2.Text = "REPITA PASSWORD"
        btnCambiarPass.Visible = False
        Me.CambiarPass = False
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
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

    End Sub


    Private Sub btnAgregarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEmpleado.Click
        Dim frm As New frmBuscarEmpleado

        Empleado = frm.Buscar()

        If Empleado IsNot Nothing Then
            Me.txtEmpleado.Text = Empleado.Nombres + " " + Empleado.Ap_Paterno + " " + Empleado.Ap_Materno
            Me.txtUser.Text = ""
            Me.txtUser.Text = LCase(Empleado.Nombres.Substring(0, 1) + Empleado.Ap_Paterno + Empleado.Ap_Materno.Substring(0, 1))
        Else
            Me.txtEmpleado.Text = ""
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
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtEmpleado.Text = ""
        Me.txtUser.Text = ""
        Me.txtclave.Text = ""
        Me.cboTipoUsuario.SelectedIndex = Nothing
        Me.GroupBox.Enabled = False
    End Sub

    Private Sub btnVerificarUserDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarUserDisponible.Click
        Dim rn As New RNUsuario

        Try
            If rn.VerificarUser(txtUser.Text) Then
                MetroMessageBox.Show(Me, "UserName ya en Uso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUser.Text = ""
            Else
                MetroMessageBox.Show(Me, "UserName Disponible", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Function CamposCompletos() As Boolean
        Dim Completo As Boolean = True
        If txtclave.Text = "" Then
            campos_faltan = campos_faltan & "  - Clave (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtUser.Text = "" Then
            campos_faltan = campos_faltan & "  - UserName (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtEmpleado.Text = "" Then
            campos_faltan = campos_faltan & "  - Empleado (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboTipoUsuario.Text = "" Then
            campos_faltan = campos_faltan & "  - TipoUsuario (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtRepClave.Text = "" Then
            campos_faltan = campos_faltan & "  - Repetir Clave (Falta Completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function

    
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNUsuario
        Dim u As Usuario

        If Me.CamposCompletos = True Then
            If txtclave.Text = txtRepClave.Text Then
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
                            MetroMessageBox.Show(Me, "El UserName escrito ya esta en uso porfavor utilize otro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtUser.Text = ""
                        Else
                            If (MetroMessageBox.Show(Me, "¿Esta seguro de Guardar los cambios de este registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                                lbPassword.Text = "PASSWORD"
                                lbPassword2.Text = "REPITA PASSWORD"
                                btnCambiarPass.Visible = False
                                u.Codigo = Me.Actual.Codigo
                                If Me.rbActivo.Checked = True Then
                                    u.Vigencia = True
                                Else
                                    u.Vigencia = False
                                End If
                                rn.Actualizar(u, CambiarPass)
                                Me.ActivarControles(False)
                                ListarUsuarios()
                            Else
                                Me.ActivarControles(True)
                            End If
                        End If

                    End If

                Catch ex As Exception
                    MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    rn = Nothing
                    u = Nothing
                End Try
            Else
                MetroMessageBox.Show(Me, "Las Contraseña no Coinciden ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
           
        Else
            MetroMessageBox.Show(Me, "Es necesario completar todos los campos" & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvUsuarios.CurrentRow IsNot Nothing Then
            Me.Actual = DirectCast(Me.dgvUsuarios.CurrentRow.DataBoundItem, Usuario)
            Me.PresentarDatos()
        Else
            MetroMessageBox.Show(Me, "Debe seleccionar un usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PresentarDatos()
        Dim rn As New RNUsuario

        Try
            Me.Actual = rn.Leer(Me.Actual)
            If Me.Actual IsNot Nothing Then
                With Me.Actual
                    Me.Empleado = New Empleado
                    Me.Empleado.Codigo = .Empleado.Codigo
                    Me.txtEmpleado.Text = .Empleado.Nombres + " " + .Empleado.Ap_Paterno + " " + .Empleado.Ap_Materno
                    Me.cboTipoUsuario.Text = .NombTipoUsuario
                    Me.txtUser.Text = .Nombre
                    Me.txtclave.Enabled = False
                    Me.txtRepClave.Enabled = False
                    Me.txtclave.Text = "*********"
                    Me.txtRepClave.Text = "*********"
                    Me.btnCambiarPass.Visible = True
                    Me.gbEstado.Enabled = True
                    If .Vigencia = True Then
                        Me.rbActivo.Checked = True
                        Me.rbInactivo.Checked = False
                    Else
                        Me.rbActivo.Checked = False
                        Me.rbInactivo.Checked = True
                    End If
                End With

                Me.ActivarControles(True)

            Else
                MetroMessageBox.Show(Me, "No se encontró el Usuario solicitado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    
    Private Sub btnCambiarPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPass.Click
        txtclave.Enabled = True
        txtRepClave.Enabled = True
        txtclave.Text = ""
        txtRepClave.Text = ""
        lbPassword.Text = "PASSWORD NUEVO"
        lbPassword2.Text = "REPITE PASSWORD NUEVO"
        txtclave.Focus()
        Me.CambiarPass = True
    End Sub

    Private Sub dgvUsuarios_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvUsuarios.RowPrePaint

        Select Case dgvUsuarios.Rows(e.RowIndex).Cells("Estado").Value
            Case "Activo"
                dgvUsuarios.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Black
            Case "Inactivo"
                dgvUsuarios.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Red

        End Select

    End Sub

    Private Sub dgvUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

    End Sub
End Class
