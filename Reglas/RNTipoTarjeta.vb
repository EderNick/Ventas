Public Class RNTipoTarjeta
    Inherits CADO
    Function Listar(ByVal wtipo As String) As List(Of TipoTarjetaVentas)
        Dim param As New List(Of CParametro)
        Dim Tipo As TipoTarjetaVentas = Nothing
        Dim Tarjetas As List(Of TipoTarjetaVentas) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pnombre", wtipo))
        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_liTipoTarjeta", param)

            Tarjetas = New List(Of TipoTarjetaVentas)
            While dr.Read
                Tipo = New TipoTarjetaVentas
                Tipo.codigo = CInt(dr.Item("idtipotarjetaventa"))
                Tipo.nombre = dr.Item("nombre")
                Tipo.descripcion = dr.Item("descripcion")
                Tipo.vigencia = dr.Item("vigencia")
                Tarjetas.Add(Tipo)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return Tarjetas
    End Function

    Public Sub Registrar(ByVal wtipo As TipoTarjetaVentas)
        Dim pars As New List(Of CParametro)
        pars.Add(New CParametro("pnombre", wtipo.nombre))
        pars.Add(New CParametro("pdescripcion", wtipo.descripcion))
        pars.Add(New CParametro("pvigencia", wtipo.vigencia))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_iTipo", pars)

            Me.Cerrar(True)
        Catch ex As Exception

            Me.Cerrar(False)
            Throw ex

        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Public Function Leer(ByVal wtipo As TipoTarjetaVentas) As TipoTarjetaVentas
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim Tipo As TipoTarjetaVentas = Nothing

        pars.Add(New CParametro("pCodigo", wtipo.codigo))

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leerTipTarj", pars)
            If dr.Read = True Then
                Tipo = New TipoTarjetaVentas
                Tipo.codigo = wtipo.codigo
                Tipo.nombre = dr.Item("nombre")
                Tipo.descripcion = dr.Item("descripcion")
                Tipo.vigencia = dr.Item("vigencia")
            End If

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            pars = Nothing
        End Try
        Return Tipo
    End Function

    Public Sub Actualizar(ByVal wtipo As TipoTarjetaVentas, ByVal id As Integer)

        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pcodigo", id))
        pars.Add(New CParametro("pnombres", wtipo.nombre))
        pars.Add(New CParametro("pdescripcion", wtipo.descripcion))
        pars.Add(New CParametro("pvigencia", wtipo.vigencia))
        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_mtipotarjeta", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub

    Function ListarTodo() As List(Of TipoTarjetaVentas)
        Dim Tipo As TipoTarjetaVentas = Nothing
        Dim Tarjetas As List(Of TipoTarjetaVentas) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_litipotarjetaventas", Nothing)

            Tarjetas = New List(Of TipoTarjetaVentas)
            While dr.Read
                Tipo = New TipoTarjetaVentas
                Tipo.codigo = CInt(dr.Item("idtipotarjetaventa"))
                Tipo.nombre = dr.Item("nombre")
                Tarjetas.Add(Tipo)
            End While
        Catch ex As Exception
            Throw ex
        End Try

        Return Tarjetas

    End Function

End Class
