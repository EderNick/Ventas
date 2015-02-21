Public Class RNDistrito
    Inherits CADO

    Public Function ListarxProvincia(ByVal wProv As Provincia) As List(Of Distrito)
        Dim Distritos As List(Of Distrito)
        Dim param As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim prov As Distrito = Nothing

        param.Add(New CParametro("codprov", wProv.Codigo))
        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lidistritosporprovincia", param)
            Distritos = New List(Of Distrito)

            Do While dr.Read = True
                prov = New Distrito
                prov.Codigo = dr.Item("iddistrito")
                prov.Nombre = dr.Item("nombre")
                Distritos.Add(prov)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Distritos
    End Function

End Class
