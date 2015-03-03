Module modPrincipal
    Public nombre_user As String = ""
    Public UsuarioActual As Usuario

    Public Sub Main()
        Dim frm As New frmLogin
        Dim frmPrinc As frmMenu

        UsuarioActual = frm.Identificar()
        If UsuarioActual IsNot Nothing Then
            frmPrinc = New frmMenu
            frmPrinc.lblEmpleado.Text = UsuarioActual.Empleado.NombreEmpleado
            frmPrinc.lblSucursal.Text = UsuarioActual.Empleado.Sucursal.Nombre
            frmPrinc.ShowDialog()
        End If

    End Sub

End Module
