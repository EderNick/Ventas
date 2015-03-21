Public Class DetalleOrdenPedido
    Public Property Modelo As Modelo
    Public Property OrdenPedido As OrdenPedido
    Public Property Cantidad As Integer
    Public Property IGV As Double
    Public Property Total As Double

    Public ReadOnly Property CodigoModelo As String
        Get
            Return Modelo.Codigo
        End Get
    End Property

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
