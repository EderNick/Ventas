Public Class CuentaVenta
    Public Property Codigo As Integer
    Public Property Banco As Banco
    Public Property CCI As String
    Public Property Vigencia As Boolean

    Public ReadOnly Property NombreBanco As String
        Get
            Return Banco.Nombre
        End Get
    End Property
End Class
