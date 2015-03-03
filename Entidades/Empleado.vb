Public Class Empleado
    Public Property Codigo As Integer
    Public Property Sucursal As Sucursal
    Public Property Nombres As String
    Public Property Ap_Paterno As String
    Public Property Ap_Materno As String
    Public Property Cargo As String
    Public Property Dni As String
    Public Property Num_Licencia As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Celular As String
    Public Property Correo As String
    Public Property Vigencia As Boolean

    Public ReadOnly Property NombreEmpleado As String
        Get
            Dim nombre As String = ""

            nombre = Me.Nombres + " " + Me.Ap_Paterno + " " + Me.Ap_Materno

            Return nombre
        End Get
    End Property
    Public ReadOnly Property NombSucursal As String
        Get
            Dim nombre As String = ""

            nombre = Me.Sucursal.ZonaNombre

            Return nombre
        End Get
    End Property
End Class
