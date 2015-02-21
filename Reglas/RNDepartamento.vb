Public Class RNDepartamento

    Inherits CADO

    Public Function Listar() As List(Of Departamento)
        Dim Departamentos As List(Of Departamento)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim d As Departamento = Nothing


        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lidepartamentos", Nothing)
            Departamentos = New List(Of Departamento)

            Do While dr.Read = True
                d = New Departamento
                d.Codigo = dr.Item("iddepartamento")
                d.Nombre = dr.Item("nombre")
                Departamentos.Add(d)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Departamentos
    End Function
End Class
