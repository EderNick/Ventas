Public Class PagoVenta
    Public Property Codigo As Integer
    Public Property FechaPago As Date
    Public Property MedioPago As String 'CH cheqe / DE deposito/ TA tarjeta
    Public Property Monto As Double
    Public Property DocumVenta As DocumentoVenta
End Class
