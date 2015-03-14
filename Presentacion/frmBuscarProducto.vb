Public Class frmBuscarProducto

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListarModelos()
    End Sub

    Sub ListarModelos()
        Dim rn As New RNModelo
        Dim Modelo As List(Of Modelo)

        Try
            Modelo = rn.Listar()
            modFunciones.EnlazarDatagridView(dgvProducto, Modelo)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub
End Class