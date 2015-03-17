Public Class RNOrdenPedido
    Inherits CADO
    Function Agregar(ByVal wOP As OrdenPedido) As Integer
        Dim pars As New List(Of CParametro)
        Dim idOP As Integer = 0

        pars.Add(New CParametro("pcodigo", 0, CParametro.DireccionParametro.SALIDA))
        pars.Add(New CParametro("pnumero", wOP.Numero))
        pars.Add(New CParametro("pfecha", wOP.FechaEmision))
        pars.Add(New CParametro("ptotal", wOP.Total))
        pars.Add(New CParametro("pestado", wOP.Estado))
        pars.Add(New CParametro("pvigencia", wOP.Vigencia))
        pars.Add(New CParametro("pidempleado", wOP.Empleado.Codigo))
        pars.Add(New CParametro("pidcliente", wOP.Cliente.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_iordenpedido", pars)
            idOP = CInt(pars.ElementAt(0).Valor)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try

        Return idOP
    End Function

    Public Function BuscarNumOrdenPedido() As Integer
        Dim pars As New List(Of CParametro)
        Dim numero As Integer = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_leernumordenpedido", Nothing)
            While dr.Read = True
                numero = dr.Item("numero")
            End While
        Catch ex As Exception
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
            If dr IsNot Nothing Then
                dr.Close()
                dr = Nothing
            End If
        End Try

        Return numero
    End Function

End Class

