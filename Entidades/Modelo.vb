Public Class Modelo

    Public Property Codigo As Integer
    Public Property Descripcion As String
    Public Property Vigencia As Boolean
    Public Property Producto As Producto
    Public Property Marca As Marca

    Public ReadOnly Property NombreModelo As String
        Get
            Return Descripcion
        End Get
    End Property

    Public ReadOnly Property NombreCompletoProducto As String
        Get
            Return Producto.Descripcion & "-" & Marca.Descripcion & "-" & Descripcion
        End Get
    End Property
End Class
