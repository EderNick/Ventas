Public Class RNDetalleSucursal
    Inherits CADO

    Public Function ListarDetalle(ByVal wDetalle As String) As List(Of DetalleSucursal)
        Dim pars As New List(Of CParametro)
        Dim dsu As New List(Of DetalleSucursal)
        Dim detsu As DetalleSucursal = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("pdirecc", wDetalle))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lidetallesucursal", pars)
            dsu = New List(Of DetalleSucursal)

            While dr.Read = True
                detsu = New DetalleSucursal
                detsu.precio = dr.Item("precio")
                detsu.Sucursal = New Sucursal
                detsu.Sucursal.Codigo = dr.Item("codigo")
                detsu.Sucursal.Direccion = dr.Item("direccion")
                detsu.Modelo = New Modelo
                detsu.Modelo.Codigo = dr.Item("codigo")
                detsu.Modelo.Descripcion = dr.Item("descripcion")
                dsu.Add(detsu)
            End While
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try

        Return dsu
    End Function

    Public Sub Registrar(ByVal wDetalleSu As DetalleSucursal)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pprecio", wDetalleSu.precio))
        pars.Add(New CParametro("psucursal", wDetalleSu.Sucursal.Codigo))
        pars.Add(New CParametro("pmodelo", wDetalleSu.Modelo.Codigo))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_iDetalleSu", pars)

            Me.Cerrar(True)
        Catch ex As Exception

            Me.Cerrar(False)
            Throw ex

        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub


    Public Function Leer(ByVal wDetalleSucursal As DetalleSucursal) As DetalleSucursal
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim DS As DetalleSucursal = Nothing

        pars.Add(New CParametro("pCodigosu", wDetalleSucursal.Sucursal.Codigo))
        pars.Add(New CParametro("pCodigomo", wDetalleSucursal.Modelo.Codigo))
        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leerDetalleSucursal", pars)
            If dr.Read = True Then
                DS = New DetalleSucursal
                DS.precio = dr.Item("precio")
                DS.Sucursal = New Sucursal
                DS.Sucursal.Direccion = dr.Item("direccion")
                DS.Modelo = New Modelo
                DS.Modelo.Descripcion = dr.Item("descripcion")
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
        Return DS
    End Function

    Public Sub Actualizar(ByVal wDetalleSucursal As DetalleSucursal)

        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pcodSucursal", wDetalleSucursal.Sucursal.Codigo))
        pars.Add(New CParametro("pcodModelo", wDetalleSucursal.Modelo.Codigo))
        pars.Add(New CParametro("pPrecio", wDetalleSucursal.precio))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_MdetalleSucursal", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub

End Class
