Public Class Persona
    Public Property Codigo As Integer
    Public Property Nombres As String
    Public Property Ap_Paterno As String
    Public Property Ap_Materno As String
    Public Property DNI As String
    Public Property Sexo As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Correo As String

    Public ReadOnly Property NombrePersona As String
        Get
            Return Me.Nombres + " " + Me.Ap_Paterno + " " + Me.Ap_Materno
        End Get
    End Property

    Public ReadOnly Property Sexo_M_F As String
        Get
            Dim s As String = Nothing
            If Sexo = "M" Then
                s = "Hombre"
            End If
            If Sexo = "F" Then
                s = "Mujer"
            End If
            Return s
        End Get
    End Property
End Class
