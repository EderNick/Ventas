Public Class Sucursal

    Public Property Codigo As Integer
    Public Property Nombre As String
    Public Property Correo As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Vigencia As Boolean
    Public Property ZonaNombre As String
    Public Property zona As zona
    Public Property Empresa As Empresa

    Public ReadOnly Property Estado As String
        Get
            Dim nombre As String = ""
            If Vigencia = True Then
                nombre = "Activa"
            Else
                nombre = "Inactiva"
            End If

            Return nombre
        End Get

    End Property

End Class
