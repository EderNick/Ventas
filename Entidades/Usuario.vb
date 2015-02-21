Public Class Usuario
    Public Property Codigo As Integer
    Public Property TipoUsuario As TipoUsuario
    Public Property Empleado As Empleado
    Public Property Nombre As String
    Public Property Clave As String

    Public ReadOnly Property NombreEmpleado As String
        Get
            Dim nombre As String = ""

            nombre = Me.Empleado.Nombres + " " + Me.Empleado.Ap_Paterno + " " + Me.Empleado.Ap_Materno

            Return nombre
        End Get
    End Property
    Public ReadOnly Property NombTipoUsuario As String
        Get
            Dim nombre As String = ""

            nombre = Me.TipoUsuario.Nombre

            Return nombre
        End Get
    End Property

End Class
