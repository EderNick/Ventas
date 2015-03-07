Module modPrincipal
    Public nombre_user As String = ""
    Public UsuarioLogeado As New Usuario

    Public Sub Main()
        Dim frm As New frmLogin
        Dim frmPrinc As frmMenu

        UsuarioLogeado = frm.Identificar()
        If UsuarioLogeado IsNot Nothing Then
            
            If UCase(UsuarioLogeado.TipoUsuario.Nombre) = "SUPERADMIN" Then
                'cargar un formulario para SUPER ADMIN , q elija entrar a modulo de ventas/compras/almacen
            End If



            If UCase(UsuarioLogeado.TipoUsuario.Nombre) = "ADMIN" Then
                'cargar un formulario para ADMIN ya sea de ventas/compras/almacen

                If UsuarioLogeado.TipoUsuario.Modulo = "Ventas" Then
                    frmPrinc = New frmMenu
                    frmPrinc.lblEmpleado.Text = UsuarioLogeado.Empleado.NombreEmpleado
                    frmPrinc.lblSucursal.Text = UsuarioLogeado.Empleado.Sucursal.Nombre
                    frmPrinc.ShowDialog()
                End If

                If UsuarioLogeado.TipoUsuario.Modulo = "Compras" Then
                    'cargar MENU de Compras
                End If

                If UsuarioLogeado.TipoUsuario.Modulo = "Almacen" Then
                    'cargar MENU de Almacen
                End If

            End If



            If UCase(UsuarioLogeado.TipoUsuario.Nombre) = "USUARIO" Then
                If UsuarioLogeado.TipoUsuario.Modulo.Trim = "Ventas" Then
                    Dim frmC As New frmCaja
                    frmC.ShowDialog()
                End If

                If UsuarioLogeado.TipoUsuario.Modulo = "Compras" Then
                    'cargar MENU de Compras
                End If

                If UsuarioLogeado.TipoUsuario.Modulo = "Almacen" Then
                    'cargar MENU de Almacen
                End If
            End If


        End If
    End Sub

End Module
