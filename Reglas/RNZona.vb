Public Class RNZona
    Inherits CADO

    Public Sub Registrar(ByVal wZona As Zona)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pidDistrito", wZona.Distrito.Codigo))
        pars.Add(New CParametro("pidProvincia", wZona.Provincia.Codigo))
        pars.Add(New CParametro("pidDepartamento", wZona.Departamento.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_izona", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub


    'Public Function Listar() As List(Of zona)
    '    Dim zona As List(Of zona)
    '    Dim pars As New List(Of CParametro)
    '    Dim dr As NpgsqlDataReader = Nothing
    '    Dim z As zona = Nothing


    '    Try
    '        Me.Conectar(True)
    '        dr = Me.PedirDataReader("fu_lizonas", Nothing)
    '        zona = New List(Of zona)

    '        Do While dr.Read = True
    '            z = New zona
    '            z.Codigo = dr.Item("idzona")
    '            z.Distrito = New Distrito
    '            z.Distrito.nombre = dr.Item("distrito")
    '            z.Distrito.Provincia = New Provincia
    '            z.Distrito.Provincia.Nombre = dr.Item("provincia")
    '            z.Distrito.Provincia.Departamento = New Departamento
    '            z.Distrito.Provincia.Departamento.Nombre = dr.Item("departamento")
    '            zona.Add(z)
    '        Loop

    '        Me.Cerrar(True)
    '    Catch ex As Exception
    '        Me.Cerrar(False)
    '        Throw ex
    '    End Try

    '    Return zona
    'End Function
End Class
