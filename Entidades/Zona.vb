Public Class Zona

    Public Property Codigo As Integer
    Public Property Distrito As Distrito
    Public Property Provincia As Provincia
    Public Property Departamento As Departamento
    Public Property Vigencia As Boolean

    Public Property ZonaNomb As String  'added by Eder

    Public Property Sucursales As List(Of Sucursal)


    Public ReadOnly Property ZonaNombre As String
        Get
            Dim nombre As String = ""
            nombre = Me.Distrito.nombre + ", " + Me.Provincia.Nombre + ", " +
                     Me.Departamento.Nombre
            Return nombre
        End Get

    End Property





End Class