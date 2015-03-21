Public Class RNPagoVentas
    Inherits CADO

    Function Registrar(ByVal wPago As PagoVenta) As Integer
        Dim pars As New List(Of CParametro)
        Dim idPago As Integer = 0

        pars.Add(New CParametro("pcodigo", 0, CParametro.DireccionParametro.SALIDA))
        pars.Add(New CParametro("pfecha", wPago.FechaPago))
        pars.Add(New CParametro("pmediopago", wPago.MedioPago))
        pars.Add(New CParametro("pmonto", wPago.Monto))
        pars.Add(New CParametro("piddocumentoventa", wPago.DocumVenta.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_ipagoventas", pars)
            idPago = CInt(pars.ElementAt(0).Valor)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try

        Return idPago
    End Function
End Class
