Public Class RNDepositoVentas
    Inherits CADO

    Sub Registrar(ByVal wDeposito As DepositoVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pmonto", wDeposito.Monto))
        pars.Add(New CParametro("pidcuenta", wDeposito.IdCuenta))
        pars.Add(New CParametro("pidpagoventas", wDeposito.PagoVentas.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_idepositoventas", pars)
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
