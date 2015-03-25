Public Class RNDetalleDocumentoVenta
    Inherits CADO

    Sub Agregar(ByVal wDetalleDV As DetalleDocumentoVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidmodelo", wDetalleDV.Modelo.Codigo))
        pars.Add(New CParametro("piddocventa", wDetalleDV.DocVenta.Codigo))
        pars.Add(New CParametro("pigv", wDetalleDV.IGV))
        pars.Add(New CParametro("pCantidad", wDetalleDV.Cantidad))
        pars.Add(New CParametro("pTotal", wDetalleDV.Total))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_idetalledocventa", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Public Sub ActualizarStok(ByVal pidmodelo As Integer, ByVal pidsucursal As Integer, ByVal pcantidad As Integer)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidsucursal", pidsucursal))
        pars.Add(New CParametro("pidmodelo", pidmodelo))
        pars.Add(New CParametro("pcantidad", pcantidad))
       
        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_astokdetallemodelosucursal", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub

End Class
