Public Class RNTipoUsuario
    Inherits CADO

    Public Function Listar() As List(Of TipoUsuario)
        Dim TipoUsuario As List(Of TipoUsuario)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim tu As TipoUsuario = Nothing


        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_litipousuario", Nothing)
            TipoUsuario = New List(Of TipoUsuario)

            Do While dr.Read = True
                tu = New TipoUsuario
                tu.Codigo = dr.Item("idtipousuario")
                tu.Nombre = dr.Item("nombre")
                TipoUsuario.Add(tu)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return TipoUsuario
    End Function
End Class
