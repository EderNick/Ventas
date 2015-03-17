Public Class RNDocumentoVenta
    Inherits CADO

    Public Function BuscarNumDocumento() As Integer
        Dim pars As New List(Of CParametro)
        Dim numero As Integer = Nothing
        Dim dr As NpgsqlDataReader = Nothing

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_leernumdocventa", Nothing)
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

    Public Function Buscar_Orden_de_Pedido(ByVal wNumOrden As String) As OrdenPedido
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim orden As OrdenPedido = Nothing

        pars.Add(New CParametro("pnum", wNumOrden))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_buscar_orden_pedido", pars)
            While dr.Read = True
                orden = New OrdenPedido
                With orden
                    .Codigo = dr.Item("idordenpedido")
                    .Numero = wNumOrden
                    .Total = dr.Item("total")
                    .Empleado = New Empleado
                    .Empleado.Codigo = dr.Item("idempleado")
                    .Empleado.Nombres = dr.Item("nombres")
                    .Empleado.Ap_Paterno = dr.Item("ap_paterno")
                    .Empleado.Ap_Materno = dr.Item("ap_materno")
                   

                End With
            End While
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            pars = Nothing
        End Try
        Return s
    End Function


End Class
