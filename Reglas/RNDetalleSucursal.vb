Public Class RNDetalleSucursal
    Inherits CADO

    Public Function ListarDetalle(ByVal wDetalle As Integer) As List(Of DetalleSucursal)
        Dim pars As New List(Of CParametro)
        Dim dsu As New List(Of DetalleSucursal)
        Dim detsu As DetalleSucursal = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("codigo", wDetalle))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liDsucursal", pars)
            dsu = New List(Of DetalleSucursal)

            While dr.Read = True
                detsu = New DetalleSucursal
                detsu.precio = dr.Item("precio")
                detsu.cantidad = dr.Item("cantidad")
                detsu.Modelo = New Modelo
                detsu.Modelo.Codigo = dr.Item("idmodelo")
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

    Public Sub Registrar(ByVal wDetalleSu As DetalleSucursal, ByVal id As Integer)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("psucursal", id))
        pars.Add(New CParametro("pmodelo", wDetalleSu.Modelo.Codigo))
        pars.Add(New CParametro("pprecio", wDetalleSu.precio))
        pars.Add(New CParametro("pcantidad", wDetalleSu.cantidad))



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


    Public Function Leer(ByVal wDetalleSucursal As DetalleSucursal, ByVal codigo As Integer) As DetalleSucursal
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim DS As DetalleSucursal = Nothing

        pars.Add(New CParametro("pcodigosu", codigo))

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leerdesucursal", pars)
            If dr.Read = True Then
                DS = New DetalleSucursal
                DS.precio = dr.Item("precio")
                DS.cantidad = dr.Item("cantidad")
                DS.Modelo = New Modelo
                DS.Modelo.Codigo = dr.Item("idmodelo")

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

    Public Sub Actualizar(ByVal wdetalle As DetalleSucursal, ByVal id As Integer)

        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidmodelo", wdetalle.Modelo.Codigo))
        pars.Add(New CParametro("pprecio", wdetalle.precio))
        pars.Add(New CParametro("pcantidad", wdetalle.cantidad))
        pars.Add(New CParametro("pIdSucursal", id))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_Mdetallesu", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub
End Class
