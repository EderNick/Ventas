Public Class frmBuscarCliente

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rdoRUC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRUC.CheckedChanged
        txtRUC.Enabled = True
        txtRUC.BackColor = Color.White 'cambiarlo a color blanco(activo)
        txtDNI.Enabled = False
        txtDNI.BackColor = Color.Gainsboro 'cambiarlo a color gris(inactivo)
        txtDNI.Text = ""
        txtRUC.Focus()
        Me.AcceptButton = btnBuscar
        dgvClientes.Visible = False
        dgvEmpresas.Visible = True
    End Sub

    Private Sub rdoDNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDNI.CheckedChanged
        txtDNI.Enabled = True
        txtDNI.BackColor = Color.White 'cambiarlo a color blanco(activo)
        txtRUC.Enabled = False
        txtRUC.BackColor = Color.Gainsboro 'cambiarlo a color gris(inactivo)
        txtRUC.Text = ""
        txtDNI.Focus()
        Me.AcceptButton = btnBuscar
        dgvClientes.Visible = True
        dgvEmpresas.Visible = False
    End Sub

    Private Sub frmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtDNI.Focus()
        txtDNI.BackColor = Color.Gainsboro
        txtRUC.BackColor = Color.Gainsboro
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim rn As New RNCliente
        Dim DetCliente As List(Of DetalleCliente)

        Try
            If rdoDNI.Checked = True Then
                If txtDNI.Text <> "" And txtDNI.Text.Length = 8 Then
                    DetCliente = rn.BuscarxDNI(txtDNI.Text.Trim)
                    If DetCliente.Count <> 0 Then
                        modFunciones.EnlazarDatagridView(Me.dgvClientes, DetCliente)
                        Me.dgvClientes.Focus()
                        Me.AcceptButton = Me.btnSeleccionar
                    Else 'cliente no encontrado: desea registrarlo?
                        If MetroMessageBox.Show(Me, "El Cliente no se ha encontrado." & vbNewLine & "¿Desea registrarlo en este momentos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show("Aqui debe cargar el formulario de registo de cliente")
                        End If
                    End If
                Else
                    MetroMessageBox.Show(Me, "Debe completar el campo DNI correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDNI.Focus()
                End If
            End If



            If rdoRUC.Checked = True Then
                If txtRUC.Text <> "" And txtRUC.Text.Length = 11 Then
                    DetCliente = rn.BuscarxRUC(txtRUC.Text.Trim)
                    If DetCliente.Count <> 0 Then
                        modFunciones.EnlazarDatagridView(Me.dgvEmpresas, DetCliente)
                        Me.dgvClientes.Focus()
                        Me.AcceptButton = Me.btnSeleccionar
                    Else 'cliente no encontrado: desea registrarlo?
                        If MetroMessageBox.Show(Me, "El Cliente no se ha encontrado." & vbNewLine & "¿Desea registrarlo en este momentos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show("Aqui debe cargar el formulario de registo de cliente")
                        End If
                    End If

                Else
                    MetroMessageBox.Show(Me, "Debe completar el campo RUC correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDNI.Focus()
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Dim elem As DetalleCliente
        elem = DirectCast(Me.dgvClientes.CurrentRow.DataBoundItem, DetalleCliente)
        MessageBox.Show("Seleccionado: " & elem.Persona.NombrePersona)
    End Sub
End Class