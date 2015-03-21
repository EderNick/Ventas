Public Class frmTipoTarjeta

    Private actual As TipoTarjetaVentas
    Private campos_faltan As String


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Sub limpiar()
        Me.txtNombre.Clear()
        txtarjeta.Clear()
        txtDescripcion.Clear()
        ckbVigencia.Checked = False

    End Sub

    Private Sub ActivarControles(ByVal wEstado As Boolean)
        Me.gbDatos.Enabled = wEstado
        Me.gblistar.Enabled = Not wEstado

        If wEstado = True Then
            Me.btnGuardar.Focus()
        Else
            Me.txtarjeta.Focus()
        End If
    End Sub

    Private Sub frmBancoVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listartipotarjeta()

    End Sub

    Private Sub listartipotarjeta()
        Dim rn As New RNTipoTarjeta
        Dim tipo As List(Of TipoTarjetaVentas)
        Try
            ActivarControles(False)
            tipo = rn.Listar(txtarjeta.Text)
            modFunciones.EnlazarDatagridView(Me.dgvlistar, tipo)
            Me.dgvlistar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim rn As RNTipoTarjeta
        Dim Tipo As TipoTarjetaVentas
        campos_faltan = ""

        If CamposCompletos() = True Then
            If Me.ValidateChildren = True Then
                Tipo = New TipoTarjetaVentas

                Tipo.Nombre = Me.txtNombre.Text
                Tipo.descripcion = Me.txtDescripcion.Text
                Tipo.vigencia = ckbVigencia.Checked
                rn = New RNTipoTarjeta
                Try
                    If Me.actual Is Nothing Then
                        rn.Registrar(Tipo)
                        MessageBox.Show("Se Registro el tipo de tarjeta con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        limpiar()
                        Me.ActivarControles(False)
                        gbDatos.Enabled = False
                        listartipotarjeta()
                        limpiar()
                    Else
                        If (MessageBox.Show("¿Esta seguro de Modificar los datos de esta tipo tarjeta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                            Tipo.codigo = Me.actual.codigo
                            rn.Actualizar(Tipo, Tipo.codigo)
                            limpiar()
                            Me.ActivarControles(False)
                            gblistar.Enabled = False
                            listartipotarjeta()
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
        If txtNombre.Text = "" Then
            campos_faltan = campos_faltan & "  - Nombre(Falta Completar)." & vbNewLine
            Completo = False
        End If
        If txtDescripcion.Text = "" Then
            campos_faltan = campos_faltan & "  - Apellido-Paterno(Falta Completar)." & vbNewLine
            Completo = False
        End If
        Return Completo
    End Function


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        limpiar()
    End Sub

    Private Sub btnbusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusqueda.Click
        listartipotarjeta()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        If Me.dgvlistar.CurrentRow IsNot Nothing Then
            Me.actual = DirectCast(Me.dgvlistar.CurrentRow.DataBoundItem, TipoTarjetaVentas)
            Me.PresentarDatos()
        Else
            MessageBox.Show("Debe seleccionar un tipo de tarjeta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PresentarDatos()
        Dim rn As New RNTipoTarjeta
        Try
            Me.actual = rn.Leer(Me.actual)
            If Me.Actual IsNot Nothing Then
                With Me.Actual
                    Me.txtNombre.Text = .nombre
                    Me.txtDescripcion.Text = .descripcion
                    Me.ckbVigencia.Checked = .vigencia
                End With
                Me.ActivarControles(True)
            Else
                MessageBox.Show("No se encontró el tipo de tarjeta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class