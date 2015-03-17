Public Class RNUsuario
    Inherits CADO

    Public Sub Registrar(ByVal wUsuario As Usuario)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pIdTipoUsuario", wUsuario.TipoUsuario.Codigo))
        pars.Add(New CParametro("pIdEmpleado", wUsuario.Empleado.Codigo))
        pars.Add(New CParametro("pNombre", wUsuario.Nombre))
        pars.Add(New CParametro("pClave", BCrypt.Net.BCrypt.HashPassword(wUsuario.Clave, BCrypt.Net.BCrypt.GenerateSalt())))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_iusuario", pars)

            Me.Cerrar(True)
        Catch ex As Exception

            Me.Cerrar(False)
            Throw ex

        Finally
            pars.Clear()
            pars = Nothing
        End Try

    End Sub

    Public Function Identificar(ByVal wUsuario As Usuario) As Usuario
        Dim pars As New List(Of CParametro)
        Dim usu As Usuario = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("pNombre", wUsuario.Nombre))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_identificarusuario", pars)
            If dr.Read = True Then
                If (BCrypt.Net.BCrypt.Verify(wUsuario.Clave, dr.Item("clave"))) Then
                    usu = New Usuario
                    usu.Codigo = dr.Item("idusuario")
                    usu.Nombre = wUsuario.Nombre
                    usu.TipoUsuario = New TipoUsuario
                    usu.TipoUsuario.Modulo = dr.Item("modulo")
                    usu.TipoUsuario.Nombre = dr.Item("tipousuario")
                    usu.Empleado = New Empleado
                    usu.Empleado.Codigo = dr.Item("idempleado")
                    usu.Empleado.Nombres = dr.Item("nombres")
                    usu.Empleado.Ap_Paterno = dr.Item("ap_paterno")
                    usu.Empleado.Ap_Materno = dr.Item("ap_materno")
                    usu.Empleado.Cargo = dr.Item("cargo")
                    usu.Empleado.Sucursal = New Sucursal
                    usu.Empleado.Sucursal.Codigo = dr.Item("idsucursal")
                    usu.Empleado.Sucursal.Nombre = dr.Item("sucursal")
                    usu.Empleado.Sucursal.Empresa = New Empresa
                    usu.Empleado.Sucursal.Empresa.Codigo = dr.Item("idempresa")
                    usu.Empleado.Sucursal.Empresa.RazonSocial = dr.Item("razonsocial")
                    usu.Empleado.Sucursal.Empresa.Ruc = dr.Item("ruc")
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
            If dr IsNot Nothing Then
                dr.Close()
                dr = Nothing
            End If
        End Try

        Return usu
    End Function

    Public Function VerificarUser(ByVal wUsuario As String) As Boolean
        Dim pars As New List(Of CParametro)
        Dim usu As Usuario = Nothing
        Dim dr As NpgsqlDataReader = Nothing
        Dim UserDisponible As Boolean = False
        pars.Add(New CParametro("pNombre", wUsuario))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_identificarusuario", pars)
            If dr.Read = True Then
                UserDisponible = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
            If dr IsNot Nothing Then
                dr.Close()
                dr = Nothing
            End If
        End Try

        Return UserDisponible
    End Function


    Public Function ListarUsuarios(ByVal wUsuario As String) As List(Of Usuario)
        Dim pars As New List(Of CParametro)
        Dim usu As New List(Of Usuario)
        Dim usua As Usuario = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("pnombre", wUsuario))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liusuarios", pars)
            usu = New List(Of Usuario)
            While dr.Read = True
                usua = New Usuario
                usua.Codigo = dr.Item("idusuario")
                usua.Nombre = dr.Item("username")
                usua.Vigencia = dr.Item("vigencia")
                usua.Empleado = New Empleado
                usua.Empleado.Codigo = dr.Item("idempleado")
                usua.Empleado.Nombres = dr.Item("nombres")
                usua.Empleado.Ap_Paterno = dr.Item("ap_paterno")
                usua.Empleado.Ap_Materno = dr.Item("ap_materno")
                usua.TipoUsuario = New TipoUsuario
                usua.TipoUsuario.Nombre = dr.Item("tipousuario")
                usu.Add(usua)
            End While

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try

        Return usu
    End Function

    Public Function Leer(ByVal wUsuario As Usuario) As Usuario
        Dim pars As New List(Of CParametro)
        Dim usu As Usuario = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("pcodigo", wUsuario.Codigo))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_leerusuario", pars)
            While dr.Read = True
                usu = New Usuario
                With usu
                    .Codigo = wUsuario.Codigo
                    .Nombre = dr.Item("username").ToString
                    .Vigencia = dr.Item("vigencia").ToString
                    .TipoUsuario = New TipoUsuario
                    .TipoUsuario.Nombre = dr.Item("tipousuario")
                    .Empleado = New Empleado
                    .Empleado.Codigo = dr.Item("idempleado")
                    .Empleado.Nombres = dr.Item("nombres")
                    .Empleado.Ap_Paterno = dr.Item("ap_paterno")
                    .Empleado.Ap_Materno = dr.Item("ap_materno")
                End With
            End While
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            If dr IsNot Nothing Then
                dr.Close()
                dr = Nothing
            End If
        End Try
        Return usu

    End Function

    Public Sub Actualizar(ByVal wUsuario As Usuario, ByVal CambioPass As Boolean)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidusuario", wUsuario.Codigo))
        pars.Add(New CParametro("pidtipousuario", wUsuario.TipoUsuario.Codigo))
        pars.Add(New CParametro("pidempleado", wUsuario.Empleado.Codigo))
        pars.Add(New CParametro("pNombre", wUsuario.Nombre))
        pars.Add(New CParametro("pClave", BCrypt.Net.BCrypt.HashPassword(wUsuario.Clave, BCrypt.Net.BCrypt.GenerateSalt())))
        pars.Add(New CParametro("pestado", wUsuario.Vigencia))
        pars.Add(New CParametro("pcambiopass", CambioPass))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_ausuario", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub

End Class
