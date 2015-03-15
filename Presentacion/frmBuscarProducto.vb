Public Class frmBuscarProducto

    Private DetalleModeloSuc As DetalleModeloSucursal
    'Private idSucursal = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Codigo
    Private idSucursal = 1

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListarModelos()
    End Sub

    Sub ListarModelos()
        Dim rn As New RNDetalleModeloSucursal
        Dim DetModSuc As List(Of DetalleModeloSucursal)

        Try
            DetModSuc = rn.ListarModelosDetallados(idSucursal)
            modFunciones.EnlazarDatagridView(dgvProducto, DetModSuc)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Function Buscar() As DetalleModeloSucursal
        Me.ShowDialog()
        Return DetalleModeloSuc
    End Function

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvProducto.CurrentRow IsNot Nothing Then
            DetalleModeloSuc = DirectCast(Me.dgvProducto.CurrentRow.DataBoundItem, DetalleModeloSucursal)
            Me.Close()
        Else
            MetroMessageBox.Show(Me, "Debe Seleccionar un Producto.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class