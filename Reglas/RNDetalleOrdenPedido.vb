Public Class RNDetalleOrdenPedido
    Inherits CADO

    Sub Agregar(ByVal wDetalleOP As DetalleOrdenPedido)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pIdOrdenPedido", wDetalleOP.OrdenPedido.Codigo))
        pars.Add(New CParametro("pIdModelo", wDetalleOP.Modelo.Codigo))
        pars.Add(New CParametro("pCantidad", wDetalleOP.Cantidad))
        pars.Add(New CParametro("pTotal", wDetalleOP.Total))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_idetalleordenpedido", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub


End Class
