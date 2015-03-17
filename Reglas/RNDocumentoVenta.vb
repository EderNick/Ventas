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
                    .Cliente = New Cliente
                    .Cliente.Codigo = dr.Item("idcliente")
                    .Cliente.Tipo = dr.Item("tipo")

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
        Return orden
    End Function

    Public Function Buscar_detalle_de_orden(ByVal wcodigo As Integer) As List(Of DetalleOrdenPedido)
        Dim Ordenes_Pedido As List(Of DetalleOrdenPedido)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim detalle_orden As DetalleOrdenPedido = Nothing

        pars.Add(New CParametro("pcodigo", wcodigo))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_buscar_detalleordendepedido", pars)
            Ordenes_Pedido = New List(Of DetalleOrdenPedido)
            Do While dr.Read = True
                detalle_orden = New DetalleOrdenPedido
                With detalle_orden
                    .OrdenPedido = New OrdenPedido
                    .OrdenPedido.Codigo = wcodigo
                    .Modelo = New Modelo
                    .Modelo.Codigo = dr.Item("idmodelo")
                    .Modelo.Descripcion = dr.Item("modelo")
                    .Modelo.Marca = New Marca
                    .Modelo.Marca.Descripcion = dr.Item("marca")
                    .Modelo.Producto = New Producto
                    .Modelo.Producto.Descripcion = dr.Item("producto")
                    .Modelo.Producto.Categoria = New Categoria
                    .Modelo.Producto.Categoria.Descripcion = dr.Item("categoria")
                    .Cantidad = dr.Item("cantidad")
                    '.PrecioUnitario = dr.Item("precio")
                    .Total = dr.Item("total")
                End With
                Ordenes_Pedido.Add(detalle_orden)
            Loop

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
        Return Ordenes_Pedido
    End Function

    Public Function Buscar_cliente_x_id(ByVal wcodigo As Integer, ByVal wtipo As String) As DetalleCliente
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim detallecliente As DetalleCliente = Nothing
        pars.Add(New CParametro("pcodigo", wcodigo))
        pars.Add(New CParametro("ptipo", wtipo))

        Try
            Me.Conectar(True)
            If wtipo = "natural" Then
                dr = Me.PedirDataReader("fu_buscar_clientexid", pars)
                While dr.Read = True
                    detallecliente = New DetalleCliente
                    With detallecliente
                        .Codigo = dr.Item("iddetallecliente")
                        .Persona = New Persona
                        .Persona.Codigo = dr.Item("idpersona")
                        .Persona.Nombres = dr.Item("nombres")
                        .Persona.Ap_Paterno = dr.Item("ap_paterno")
                        .Persona.Ap_Materno = dr.Item("ap_materno")
                        .Persona.DNI = dr.Item("dni")
                    End With
                End While
            Else
                dr = Me.PedirDataReader("fu_buscar_clientexid", pars)
                While dr.Read = True
                    detallecliente = New DetalleCliente
                    With detallecliente
                        .Codigo = dr.Item("iddetallecliente")
                        .EmpresaJuridica = New EmpresaJuridica
                        .EmpresaJuridica.Codigo = dr.Item("idempresajuridica")
                        .EmpresaJuridica.RazonSocial = dr.Item("razonsocial")
                        .EmpresaJuridica.RUC = dr.Item("ruc")
                    End With
                End While
            End If

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
        Return detallecliente
    End Function
End Class
