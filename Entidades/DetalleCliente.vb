Public Class DetalleCliente
    Public Property Codigo As Integer
    Public Property Cliente As Cliente
    Public Property Persona As Persona
    Public Property EmpresaJuridica As EmpresaJuridica


    Public ReadOnly Property NombreCliente As String
        Get
            Dim nombre As String = ""
            nombre = Persona.NombrePersona
            Return nombre
        End Get

    End Property

    Public ReadOnly Property DniCliente As String
        Get
            Dim dni As String = ""
            dni = Persona.DNI
            Return dni
        End Get

    End Property

    Public ReadOnly Property ZonaNomb As String
        Get
            Dim nombre As String = ""
            nombre = Cliente.Zona.ZonaNomb
            Return nombre
        End Get
    End Property

    Public ReadOnly Property NombreEmpleado As String
        Get
            Dim nombre As String = ""
            nombre = Cliente.Empleado.NombreEmpleado
            Return nombre
        End Get

    End Property

    Public ReadOnly Property SexoCliente As String
        Get
            Dim sexo As String = ""
            sexo = Persona.Sexo_M_F
            Return sexo
        End Get
    End Property

    Public ReadOnly Property DireccionCliente As String
        Get
            Dim direc As String = ""
            direc = Persona.Direccion
            Return direc
        End Get
    End Property

    Public ReadOnly Property TelefonoCliente As String
        Get
            Dim telef As String = ""
            telef = Persona.Telefono
            Return telef
        End Get
    End Property
End Class
