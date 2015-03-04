Module modPrincipal
    Public nombre_user As String = ""
    Public UsuarioLogeado As New Usuario

    Public Sub Main()
        Dim frm As New frmLogin
        Dim frmPrinc As frmMenu

        UsuarioLogeado = frm.Identificar()
        If UsuarioLogeado IsNot Nothing Then
            frmPrinc = New frmMenu

            frmPrinc.lblEmpleado.Text = UsuarioLogeado.Empleado.NombreEmpleado
            frmPrinc.lblSucursal.Text = UsuarioLogeado.Empleado.Sucursal.Nombre
            frmPrinc.ShowDialog()
        End If

    End Sub

End Module
