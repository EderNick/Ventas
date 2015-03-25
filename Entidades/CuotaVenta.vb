Public Class CuotaVenta
    Public Property Codigo As Integer
    Public Property DocVenta As DocumentoVenta
    Public Property Cliente As Cliente
    Public Property NumeroCuota As Integer
    Public Property fecha As Date
    Public Property Monto As Double
    Public Property Estado As Boolean

    Public ReadOnly Property codigodocumento As String
        Get
            Dim codigodoc As Integer

            codigodoc = DocVenta.Codigo

            Return codigodoc
        End Get
    End Property


    Public ReadOnly Property estadodeuda As String
        Get
            Dim estad As String
            If Estado = False Then
                estad = "Debe"
            Else
                estad = "Pagado"
            End If
            Return estad
        End Get

    End Property
End Class
