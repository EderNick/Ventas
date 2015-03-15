Public Class DetalleOrdenPedido
    Public Property Modelo As Modelo
    Public Property OrdenPedido As OrdenPedido
    Public Property Cantidad As Integer
    Public Property Total As Double

    Public ReadOnly Property NombreModelo As String
        Get
            Return Modelo.NombreCompletoProducto
        End Get
    End Property

    Public ReadOnly Property PrecioUnitario As Double
        Get
            Return Total / Cantidad
        End Get
    End Property
End Class
