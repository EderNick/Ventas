Public Class frmEmpleado

    
    
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarEmpleados()
    End Sub

    Private Sub ListarEmpleados()
        Dim rn As New RNEmpleado
        Dim empleado As List(Of Empleado)

        Try
            empleado = rn.Listar(Me.txtEmpleado.Text)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarEmpleados()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class