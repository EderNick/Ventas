Public Class RNTarjetaVentas
    Inherits CADO

    Sub Registrar(ByVal wTarjeta As TarjetaVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pnumero", wTarjeta.NumeroCuenta))
        pars.Add(New CParametro("pmonto", wTarjeta.Monto))
        pars.Add(New CParametro("pidpagoventa", wTarjeta.PagoVentas.Codigo))
        pars.Add(New CParametro("pidtipotarjetaventa", wTarjeta.IdTipoTarjeta))
        pars.Add(New CParametro("pidbanco", wTarjeta.IdBanco))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_itarjetaventas", pars)
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
