Public Class RNCuotaPagoVenta
    Inherits CADO
    Function ListarMorosos(ByVal wZona As String) As List(Of CuotaPagoVentas)
        Dim param As New List(Of CParametro)
        Dim cpv As CuotaPagoVentas = Nothing
        Dim cuotapv As List(Of CuotaPagoVentas) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pZona", wZona))

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_ListarMorosos", param)

            cuotapv = New List(Of CuotaPagoVentas)
            While dr.Read
                cpv.CuotaVenta.DocVenta.Cliente = New Cliente
                cpv.CuotaVenta.DocVenta.Cliente.Codigo = CInt(dr.Item("idcliente"))
                cpv.CuotaVenta.DocVenta = New DocumentoVenta
                cpv.CuotaVenta.DocVenta.Codigo = CInt(dr.Item("iddocumentoventa"))
                cpv.CuotaVenta = New CuotaVenta
                cpv.CuotaVenta.Monto = dr.Item("monto")
                cuotapv.Add(cpv)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return cuotapv
    End Function

End Class
