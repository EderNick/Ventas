Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ToolTip1 As New ToolTip
        ToolTip1.SetToolTip(btnBanco, "REGISTRAR BANCO")
        ToolTip1.SetToolTip(btnCaja, "REGISTRAR CAJA")
        ToolTip1.SetToolTip(btnEmpresa, "REGISTRAR EMPRESA")
       
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaja.Click
        Dim frm As frmCaja
        frm = New frmCaja
        frm.ShowDialog()
    End Sub

    Private Sub btnSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucursal.Click
        Dim frm As frmSucursal
        frm = New frmSucursal
        frm.ShowDialog()
    End Sub


    Private Sub btnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresa.Click
        Dim frm As frmEmpresa
        frm = New frmEmpresa
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

    Private Sub btnMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarca.Click
        Dim frm As New frmDetalleSucursal
        frm.ShowDialog()
    End Sub
End Class