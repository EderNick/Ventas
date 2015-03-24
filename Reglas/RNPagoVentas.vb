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

    Function ListarVentaMes(ByVal wAñoMes As String) As List(Of PagoVenta)
        Dim param As New List(Of CParametro)
        Dim pv As PagoVenta = Nothing
        Dim pagov As List(Of PagoVenta) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pAñoMes", wAñoMes))

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_ListarVentaMes", param)

            pagov = New List(Of PagoVenta)
            While dr.Read
                pv.DocumVenta.Cliente = New Cliente
                pv.DocumVenta.Cliente.Codigo = CInt(dr.Item("idcliente"))
                pv = New PagoVenta
                pv.Codigo = CInt(dr.Item("idpagoventas"))
                pv.FechaPago = dr.Item("fechapago")
                pv.MedioPago = dr.Item("mediopago")
                pv.Monto = dr.Item("monto")
                pv.DocumVenta = dr.Item("iddocumentoventa")
                pagov.Add(pv)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return pagov
    End Function

End Class
