Public Class RNModelo
    Inherits CADO

    Public Function Listar() As List(Of Modelo)
        Dim Modelo As List(Of Modelo)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim M As Modelo = Nothing


        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liModelo", Nothing)
            Modelo = New List(Of Modelo)

            Do While dr.Read = True
                M = New Modelo
                M.Codigo = dr.Item("idmodelo")
                M.Descripcion = dr.Item("descripcion")
                M.Vigencia = dr.Item("vigencia")
                Modelo.Add(M)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Modelo
    End Function
End Class
