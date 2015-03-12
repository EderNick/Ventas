
Public Class frmSucursal

    Private Actual As Sucursal
    Dim prov As Provincia
    Dim DEP As Departamento
    Dim Distri As Distrito
    Private campos_faltan As String

    Private Sub frmSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ToolTip1 As New ToolTip
        ToolTip1.SetToolTip(btnGuardar, "Guardar Datos")
        ToolTip1.SetToolTip(btnModificar, "Modificar Datos")
        ToolTip1.SetToolTip(btnNuevo, "Nuevos Datos")
        ToolTip1.SetToolTip(btnSalir, "Salir")
        Me.ActivarControles(False)
        ListarSucursales("")
        ListarDepartamentos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
        Me.Actual = Nothing
        Me.txtSucursal.Text = ""
        Me.txtNombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtTelefono.Text = ""
        Me.cboDepartamento.SelectedIndex = -1
        Me.cboProvincia.SelectedIndex = -1
        Me.cboDistrito.SelectedIndex = -1
        Me.ckVigencia.Checked = True
        Me.ckVigencia.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.txtNombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtTelefono.Text = ""
        Me.cboDepartamento.SelectedIndex = -1
        Me.cboProvincia.SelectedIndex = -1
        Me.cboDistrito.SelectedIndex = -1
        ActivarControles(False)
    End Sub

    Private Sub ActivarControles(ByVal wEstado As Boolean)
        Me.gbDatos.Enabled = wEstado
        Me.gbListado.Enabled = Not wEstado
        If wEstado = True Then
            Me.txtNombre.Focus()
        Else
            Me.txtSucursal.Focus()
        End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvSucursal.CurrentRow IsNot Nothing Then
            Me.Actual = DirectCast(Me.dgvSucursal.CurrentRow.DataBoundItem, Sucursal)
            Me.PresentarDatos()
        Else
            MetroMessageBox.Show(Me, "Debe seleccionar una sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PresentarDatos()
        Dim rn As New RNSucursal

        Try
            Me.Actual = rn.Leer(Me.Actual)
            If Me.Actual IsNot Nothing Then
                With Me.Actual

                    Me.txtNombre.Text = .Nombre
                    Me.txtCorreo.Text = .Correo
                    Me.cboDepartamento.Text = .Zona.Departamento.Nombre
                    Me.cboProvincia.Text = .Zona.Provincia.Nombre
                    Me.cboDistrito.Text = .Zona.Distrito.nombre
                    Me.txtDireccion.Text = .Direccion
                    Me.txtTelefono.Text = .Telefono
                    Me.ckVigencia.Enabled = True
                    Me.ckVigencia.Checked = .Vigencia
                End With

                Me.ActivarControles(True)
            Else
                MetroMessageBox.Show(Me, "No se encontró la Sucursal solicitada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarSucursales(txtSucursal.Text)
    End Sub

    Private Sub ListarSucursales(ByVal wNombre As String)
        Dim rn As RNSucursal
        Dim sucursal As List(Of Sucursal)


        rn = New RNSucursal
        Try
            sucursal = rn.Listar(wNombre)
            modFunciones.EnlazarDatagridView(Me.dgvSucursal, sucursal)
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNSucursal
        Dim s As Sucursal

        If Me.CamposCompletos = True Then
            s = New Sucursal
            s.Nombre = Me.txtNombre.Text
            s.Correo = Me.txtCorreo.Text
            s.Direccion = Me.txtDireccion.Text
            s.Telefono = Me.txtTelefono.Text
            s.zona = New Zona
            s.zona.Distrito = New Distrito
            s.zona.Distrito = DirectCast(cboDistrito.SelectedItem, Distrito)
            s.zona.Provincia = New Provincia
            s.zona.Provincia = DirectCast(cboProvincia.SelectedItem, Provincia)
            s.zona.Departamento = New Departamento
            s.zona.Departamento = DirectCast(cboDepartamento.SelectedItem, Departamento)
            s.Empresa = New Empresa
            s.Empresa.Codigo = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Empresa.Codigo
            rn = New RNSucursal
            Try
                If Me.Actual Is Nothing Then
                    rn.Registrar(s)
                    MetroMessageBox.Show(Me, "Su Registro se Guardo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.ActivarControles(False)
                    ListarSucursales("")
                Else
                    If (MetroMessageBox.Show(Me, "¿Esta seguro de Guardar los cambios de este registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                        s.Codigo = Me.Actual.Codigo
                        s.zona.Codigo = Me.Actual.zona.Codigo
                        s.Vigencia = ckVigencia.Checked
                        rn.Actualizar(s)
                        Me.ActivarControles(False)
                        ListarSucursales("")
                    Else
                        Me.ActivarControles(True)
                    End If
                End If

            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                s = Nothing
            End Try
        Else
            MetroMessageBox.Show(Me, "Es necesario completar todos los campos" & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ListarDepartamentos()
        Dim rn As New RNDepartamento
        Dim Departamentos As List(Of Departamento)

        Try
            Departamentos = rn.Listar()
            modFunciones.ListarComboBox(Me.cboDepartamento, Departamentos, "Codigo", "Nombre")

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If cboDepartamento.Text <> "" Then
            Dim Provincias As List(Of Provincia)
            Dim rn As RNProvincia
            Try
                DEP = New Departamento
                DEP = DirectCast(Me.cboDepartamento.SelectedItem, Departamento)
                rn = New RNProvincia
                Provincias = rn.ListarxDepartamento(DEP)
                modFunciones.ListarComboBox(Me.cboProvincia, Provincias, "Codigo", "Nombre")

            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Else
            cboDepartamento.Text = Nothing
        End If
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        If cboProvincia.Text <> "" Then
            Dim Distritos As List(Of Distrito)
            Dim rn As RNDistrito

            Try
                prov = New Provincia
                prov = DirectCast(Me.cboProvincia.SelectedItem, Provincia)
                rn = New RNDistrito
                Distritos = rn.ListarxProvincia(prov)
                modFunciones.ListarComboBox(Me.cboDistrito, Distritos, "Codigo", "Nombre")

            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            cboProvincia.Text = Nothing
        End If
    End Sub


   

    Private Function CamposCompletos() As Boolean
        Dim Completo As Boolean = True
        If txtNombre.Text = "" Then
            campos_faltan = campos_faltan & "  - Nombre Sucursal (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtCorreo.Text = "" Then
            campos_faltan = campos_faltan & "  - Correo (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtDireccion.Text = "" Then
            campos_faltan = campos_faltan & "  - Dirección (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtTelefono.Text = "" Then
            campos_faltan = campos_faltan & "  - Telefono (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboDepartamento.Text = "" Then
            campos_faltan = campos_faltan & "  - Departamento (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboProvincia.Text = "" Then
            campos_faltan = campos_faltan & "  - Provincia (Falta Completar)." & vbNewLine
            Completo = False
        End If
        If cboDistrito.Text = "" Then
            campos_faltan = campos_faltan & "  - Distrito (Falta Completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function


    Private Sub dgvSucursal_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvSucursal.RowPrePaint

        Select Case dgvSucursal.Rows(e.RowIndex).Cells("Estado").Value
            Case "Activa"
                dgvSucursal.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Black
            Case "Inactiva"
                dgvSucursal.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Red
            
        End Select

    End Sub

    Private Sub txtTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.Click

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And AscW(e.KeyChar) <> 8 Then ' ascw-->convierte la tecla a numero 
            e.Handled = True ' no permite pasar al numero 
        End If
    End Sub



End Class