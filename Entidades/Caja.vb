Public Class Caja
    Public Property Codigo As Integer
    Public Property Numero As Integer
    Public Property Descripcion As String
    Public Property MontoApertura As Double
    Public Property MontoCierre As Double
    Public Property FechaApertura As Date
    Public Property FechaCierre As Date
    Public Property Estado As Boolean

    Public Property Empleado As Empleado
    Public Property Sucursal As Sucursal

    Public ReadOnly Property Estado_Caja As String
        Get
            If Estado = True Then
                Return "Abierta"
            Else
                Return "Cerrada"
            End If
        End Get
    End Property

    Public ReadOnly Property Fecha_Cierre As String
        Get
            If FechaCierre = FechaApertura Then
                Return "-"
            Else
                Return CStr(FechaCierre)
            End If
        End Get
    End Property

    Public ReadOnly Property Monto_Cierre As String
        Get
            If MontoCierre = MontoApertura Then
                Return "-"
            Else
                Return CStr(MontoCierre)
            End If
        End Get
    End Property
End Class
