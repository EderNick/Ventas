Public Class RNCuotaVenta
    Inherits CADO

    Public Sub Registrar(ByVal wcuota As CuotaVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("piddocventa", wcuota.DocVenta.Codigo))
        pars.Add(New CParametro("pidcliente", wcuota.Cliente.Codigo))
        pars.Add(New CParametro("pnumerocuota", wcuota.NumeroCuota))
        pars.Add(New CParametro("pfecha", wcuota.fecha))
        pars.Add(New CParametro("pmonto", wcuota.Monto))
        pars.Add(New CParametro("pestado", wcuota.Estado))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_icuotaventa", pars)

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
