Public Class RNCuotaVenta
    Inherits CADO

    'Raul:
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

    'Reluz:
    Public Function ListarCuotas(ByVal wcliente As Integer) As List(Of CuotaVenta)
        Dim pars As New List(Of CParametro)
        Dim CuotasVenta As New List(Of CuotaVenta)
        Dim cuota As CuotaVenta = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        pars.Add(New CParametro("pcliente", wcliente))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liCuotasXcliente", pars)
            CuotasVenta = New List(Of CuotaVenta)
            While dr.Read = True
                cuota = New CuotaVenta
                cuota.codigo = dr.Item("idCuotaVenta")
                cuota.numerocuota = dr.Item("NumeroCuota")
                cuota.monto = dr.Item("monto")
                cuota.fecha = dr.Item("fecha")
                cuota.estado = dr.Item("estado")
                cuota.DocVenta = New DocumentoVenta
                cuota.DocVenta.Codigo = dr.Item("iddocumentoventa")
                cuota.DocVenta.FormaPago = dr.Item("formapago")
                cuota.cliente = New Cliente
                cuota.cliente.Codigo = wcliente
                CuotasVenta.Add(cuota)
            End While

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
        Return CuotasVenta
    End Function

End Class
