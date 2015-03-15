Public Class RNDetalleModeloSucursal
    Inherits CADO

    Public Function ListarDetalle(ByVal wDetalle As Integer) As List(Of DetalleModeloSucursal)
        Dim pars As New List(Of CParametro)
        Dim dsu As New List(Of DetalleModeloSucursal)
        Dim detsu As DetalleModeloSucursal = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("codigo", wDetalle))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liDsucursal", pars)
            dsu = New List(Of DetalleModeloSucursal)

            While dr.Read = True
                detsu = New DetalleModeloSucursal
                detsu.PrecioVenta = dr.Item("precio")
                detsu.Cantidad = dr.Item("cantidad")
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

    Public Sub Registrar(ByVal wDetalleSu As DetalleModeloSucursal, ByVal id As Integer)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("psucursal", id))
        pars.Add(New CParametro("pmodelo", wDetalleSu.Modelo.Codigo))
        pars.Add(New CParametro("pprecio", wDetalleSu.PrecioVenta))
        pars.Add(New CParametro("pcantidad", wDetalleSu.Cantidad))



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


    Public Function Leer(ByVal wDetalleSucursal As DetalleModeloSucursal, ByVal codigo As Integer) As DetalleModeloSucursal
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim DS As DetalleModeloSucursal = Nothing

        pars.Add(New CParametro("pcodigosu", codigo))

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leerdesucursal", pars)
            If dr.Read = True Then
                DS = New DetalleModeloSucursal
                DS.PrecioVenta = dr.Item("precio")
                DS.Cantidad = dr.Item("cantidad")
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

    Public Sub Actualizar(ByVal wdetalle As DetalleModeloSucursal, ByVal id As Integer)

        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidmodelo", wdetalle.Modelo.Codigo))
        pars.Add(New CParametro("pprecio", wdetalle.PrecioVenta))
        pars.Add(New CParametro("pcantidad", wdetalle.Cantidad))
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

    Function ListarModelosDetallados(ByVal widSucursal As Object) As List(Of DetalleModeloSucursal)
        Dim DetModSuc As List(Of DetalleModeloSucursal)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim DMS As DetalleModeloSucursal = Nothing

        pars.Add(New CParametro("pIdSucursal", widSucursal))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liModelo", pars)
            DetModSuc = New List(Of DetalleModeloSucursal)

            Do While dr.Read = True
                DMS = New DetalleModeloSucursal
                DMS.PrecioVenta = CDbl(dr.Item("precioventa"))
                DMS.Cantidad = CDbl(dr.Item("cantidad"))
                DMS.Modelo = New Modelo
                DMS.Modelo.Codigo = dr.Item("idmodelo")
                DMS.Modelo.Descripcion = dr.Item("descripcion")
                DMS.Modelo.Vigencia = dr.Item("vigencia")
                DMS.Modelo.Marca = New Marca
                DMS.Modelo.Marca.Codigo = dr.Item("idmarca")
                DMS.Modelo.Marca.Descripcion = dr.Item("des_Marca")
                DMS.Modelo.Producto = New Producto
                DMS.Modelo.Producto.Codigo = dr.Item("idproducto")
                DMS.Modelo.Producto.Descripcion = dr.Item("des_Producto")
                DMS.Modelo.Producto.Categoria = New Categoria
                DMS.Modelo.Producto.Categoria.Codigo = dr.Item("idcategoria")
                DMS.Modelo.Producto.Categoria.Descripcion = dr.Item("des_Categoria")

                DetModSuc.Add(DMS)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return DetModSuc
    End Function

End Class
