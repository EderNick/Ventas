Public Class RNProvincia
    Inherits CADO

    Public Function ListarxDepartamento(ByVal wDepar As Departamento) As List(Of Provincia)
        Dim Provincias As List(Of Provincia)
        Dim param As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim prov As Provincia = Nothing

        param.Add(New CParametro("codDep", wDepar.Codigo))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liprovinciaspordepa", param)
            Provincias = New List(Of Provincia)

            Do While dr.Read = True
                prov = New Provincia
                prov.Codigo = dr.Item("idprovincia")
                prov.Nombre = dr.Item("nombre")
                Provincias.Add(prov)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Provincias
    End Function
End Class
