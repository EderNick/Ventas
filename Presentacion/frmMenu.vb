Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ToolTip1 As New ToolTip
        'ToolTip1.SetToolTip(btnEmpresa, "REGISTRAR EMPRESA")
       
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As frmCajaInicio
        frm = New frmCajaInicio
        frm.ShowDialog()
    End Sub

    Private Sub btnSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucursal.Click
        Dim frm As frmSucursal
        frm = New frmSucursal
        frm.ShowDialog()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        Dim frm As New frmUsuario
        frm.ShowDialog()
    End Sub

    Private Sub btnEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleado.Click
        Dim frm As New frmEmpleado
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmReporteEmpleadoSucursal
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmReporteMorosos
        frm.ShowDialog()
    End Sub

    Private Sub btnOrdenPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenPedido.Click
        Dim frm As New frmOrdenPedido
        frm.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frm As New frmDocumentoVenta
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm As New frmReporteVentasMes
        frm.ShowDialog()
    End Sub

    Private Sub btnPrecioProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrecioProd.Click
        Dim frm As New frmDetalleModeloSucursal
        frm.ShowDialog()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim frm As New frmMantenimientoCuentasBancarias
        frm.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frm As New frmTipoTarjeta
        frm.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim frm As New frmGestionCuota
        frm.ShowDialog()
    End Sub
End Class