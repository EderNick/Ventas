Public Class RNBanco
    Inherits CADO

    Function Listar() As List(Of Banco)
        Dim bancos As List(Of Banco)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim ba As Banco = Nothing

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_libancos", Nothing)
            bancos = New List(Of Banco)
            Do While dr.Read = True
                ba = New Banco
                ba.Codigo = dr.Item("idbanco")
                ba.Nombre = dr.Item("nombre")
                bancos.Add(ba)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return bancos
    End Function

End Class
