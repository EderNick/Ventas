Public Class RNModelo
    Inherits CADO

    Public Function Listar() As List(Of Modelo)
        Dim Modelo As List(Of Modelo)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim M As Modelo = Nothing

        'pars.Add(New CParametro("pIdEmpresa", wIdEmpresa))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liModelo", Nothing)
            Modelo = New List(Of Modelo)

            Do While dr.Read = True
                M = New Modelo
                M.Codigo = dr.Item("idmodelo")
                M.Descripcion = dr.Item("descripcion")
                M.Vigencia = dr.Item("vigencia")
                M.Marca = New Marca
                M.Marca.Codigo = dr.Item("idmarca")
                M.Marca.Descripcion = dr.Item("des_Marca")
                M.Producto = New Producto
                M.Producto.Codigo = dr.Item("idproducto")
                M.Producto.Descripcion = dr.Item("des_Producto")
                M.Producto.Categoria = New Categoria
                M.Producto.Categoria.Codigo = dr.Item("idcategoria")
                M.Producto.Categoria.Descripcion = dr.Item("des_Categoria")
                Modelo.Add(M)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Modelo
    End Function

    Function Buscar(ByVal wProducto As String) As List(Of Modelo)
        Throw New NotImplementedException
    End Function

End Class
