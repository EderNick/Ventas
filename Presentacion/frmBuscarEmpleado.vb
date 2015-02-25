Public Class frmBuscarEmpleado

    Private Empleado As Empleado

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarEmpleados()
    End Sub

    Private Sub ListarEmpleados()
        Dim rn As New RNEmpleado
        Dim empleado As List(Of Empleado)

        Try
            empleado = rn.Listar(Me.txtEmpleado.Text, 1)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
            Me.AcceptButton = Me.btnSeleccionar
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Buscar() As Entidades.Empleado
        Me.ShowDialog()
        Return Me.Empleado
    End Function

    Private Sub txtPrenda_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.AcceptButton = Me.btnBuscar
    End Sub

    Private Sub frmBuscarPrenda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.GetNumericValue(e.KeyChar) = Keys.Enter AndAlso Me.ActiveControl Is Me.dgvEmpleados Then
            Me.btnSeleccionar.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    
    
    Private Sub frmBuscarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarEmpleados()
    End Sub

    Private Sub btnSeleccionar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvEmpleados.CurrentRow IsNot Nothing Then
            Me.Empleado = DirectCast(Me.dgvEmpleados.CurrentRow.DataBoundItem, Empleado)
            Me.Close()
        Else
            MessageBox.Show("Debe Seleccionar un Empleado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class