Public Class DetalleSucursal
    Public Property Sucursal As Sucursal
    Public Property Modelo As Modelo
    Public Property precio As Double


    Public ReadOnly Property NomSucursal As String
        Get
            Dim nombre As String = ""

            nombre = Me.Sucursal.Direccion

            Return nombre
        End Get
    End Property
    Public ReadOnly Property NomModelo As String
        Get
            Dim nombre As String = ""

            nombre = Me.Modelo.Descripcion

            Return nombre
        End Get
    End Property



End Class
