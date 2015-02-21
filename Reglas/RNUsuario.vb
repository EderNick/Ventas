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
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_identificarusuario", pars)
            If dr.Read = True Then
                If (BCrypt.Net.BCrypt.Verify(wUsuario.Clave, dr.Item("clave"))) Then
                    usu = New Usuario
                    usu.Codigo = dr.Item("idusuario")
                    usu.Nombre = wUsuario.Nombre
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
            Me.Conectar(False)
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
                usua.Empleado = New Empleado
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

    'Public Function LeerUsuario(ByVal wUsuario As Usuario
    '                   ) As Usuario
    '    Dim pars As New List(Of CParametro)
    '    Dim usu As Usuario = Nothing
    '    Dim dr As NpgsqlDataReader = Nothing
    '    Dim sql As String

    '    'dr = Me.PedirDataReader("listar_personal", wPersonal.codigo)
    '    sql = "SELECT  *FROM usuario WHERE idusuario = " & wUsuario.codigo
    '    Try
    '        Me.Conectar(False)
    '        dr = Me.PedirDataReader(sql)
    '        'dr = Me.PedirDataReader("buscar_personal", pars)
    '        If dr.Read = True Then
    '            usu = New Usuario
    '            With usu
    '                .codigo = wUsuario.codigo
    '                .usuario = dr.Item("usuario").ToString
    '                .clave = dr.Item("clave").ToString
    '                .estado = dr.Item("estado_u").ToString
    '                .persona = New Personal
    '                .persona.codigo = CInt(dr.Item("personal"))
    '            End With
    '        End If
    '        Me.Cerrar(True)
    '    Catch ex As Exception
    '        Me.Cerrar(False)
    '        Throw ex
    '    Finally
    '        If dr IsNot Nothing Then
    '            dr.Close()
    '            dr = Nothing
    '        End If
    '    End Try
    '    Return usu

    'End Function

End Class
