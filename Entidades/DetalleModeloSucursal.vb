Public Class DetalleModeloSucursal
    Public Property Sucursal As Sucursal
    Public Property Modelo As Modelo
    Public Property PrecioVenta As Double
    Public Property Cantidad As Integer

    Public ReadOnly Property NombreSucursal As String
        Get
            Dim nombre As String = ""

            nombre = Me.Sucursal.nombre

            Return nombre
        End Get
    End Property

    Public ReadOnly Property NombreCompletoProducto As String
        Get
            Return Modelo.Producto.Descripcion & " - " & Modelo.Marca.Descripcion & " - " & Modelo.Descripcion & " - " & Modelo.Producto.Categoria.Descripcion
        End Get
    End Property

    Public ReadOnly Property NombreModelo As String
        Get
            Dim nombre As String = ""

            nombre = Me.Modelo.Descripcion

            Return nombre
        End Get
    End Property

    Public ReadOnly Property NombreMarca As String
        Get
            Return Modelo.Marca.Descripcion
        End Get
    End Property

    Public ReadOnly Property NombreProducto As String
        Get
            Return Modelo.Producto.Descripcion
        End Get
    End Property

    Public ReadOnly Property NombreCategoria As String
        Get
            Return Modelo.Producto.Categoria.Descripcion
        End Get
    End Property
End Class
