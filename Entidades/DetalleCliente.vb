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
            Return Cliente.Zona.ZonaNomb
        End Get
    End Property

    Public ReadOnly Property NombreEmpleado As String
        Get
            Return Cliente.Empleado.NombreEmpleado
        End Get

    End Property

    Public ReadOnly Property SexoCliente As String
        Get
            Return Persona.Sexo_M_F
        End Get
    End Property

    Public ReadOnly Property DireccionCliente As String
        Get
            Return Persona.Direccion
        End Get
    End Property

    Public ReadOnly Property TelefonoCliente As String
        Get
            Return Persona.Telefono
        End Get
    End Property

    Public ReadOnly Property RazonSocialEmpresa As String
        Get
            Return EmpresaJuridica.RazonSocial
        End Get
    End Property

    Public ReadOnly Property RUCEmpresa As String
        Get
            Return EmpresaJuridica.RUC
        End Get
    End Property

    Public ReadOnly Property DireccionEmpresa As String
        Get
            Return EmpresaJuridica.Direccion
        End Get
    End Property

    Public ReadOnly Property TelefonoEmpresa As String
        Get
            Return EmpresaJuridica.Telefono
        End Get
    End Property

    Public ReadOnly Property CorreoEmpresa As String
        Get
            Return EmpresaJuridica.Correo
        End Get
    End Property
End Class
