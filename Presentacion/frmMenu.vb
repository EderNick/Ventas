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
End Class