Public Class RNChequeVentas
    Inherits CADO

    Sub Registrar(ByVal wCheque As ChequeVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pnumero", wCheque.Numero))
        pars.Add(New CParametro("pmonto", wCheque.Monto))
        pars.Add(New CParametro("pfechagiro", wCheque.FechaGiro))
        pars.Add(New CParametro("pvigencia", wCheque.Vigencia))
        pars.Add(New CParametro("pidpagoventas", wCheque.PagoVentas.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_ichequeventas", pars)
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
