Module modPrincipal
    Public nombre_user As String = ""
    Public UsuarioLogeado As New Usuario
    Public CajaActualAbierta As New Caja

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



            If UCase(UsuarioLogeado.TipoUsuario.Nombre) = "NORMAL" Then
                If UsuarioLogeado.TipoUsuario.Modulo.Trim = "Ventas" Then
                    Dim frmC As New frmCajaInicio
                    Dim frmV As New frmDocumentoVenta


                    Dim rn As New RNCaja
                    Dim caja As New Caja
                    caja = rn.CargarCajaAbiertaxEmpleado(UsuarioLogeado.Empleado.Codigo)
                    If caja Is Nothing Then
                        'si llega vacio, este usuario no tiene cajas abiertas
                        CajaActualAbierta = frmC.IniciarCaja()

                    Else
                        CajaActualAbierta = caja
                        MessageBox.Show("Su caja ha sido reanudada.", "Caja Reanudada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                    frmV.ShowDialog()

                    If MessageBox.Show("¿Desea cerrar su caja ahora mismo?", "Cerrar Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim frmCerrar As New frmCajaCierre
                        frmCerrar.ShowDialog()
                    End If
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
