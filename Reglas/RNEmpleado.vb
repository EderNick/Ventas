Public Class RNEmpleado
    Inherits CADO
    Function Listar(ByVal wEmpleado As String) As List(Of Empleado)
        Dim param As New List(Of CParametro)
        Dim emp As Empleado = Nothing
        Dim empleados As List(Of Empleado) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pnombre", wEmpleado))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_liempleados", param)
            empleados = New List(Of Empleado)
            While dr.Read
                emp = New Empleado
                emp.Codigo = CInt(dr.Item("idempleado"))
                emp.Nombres = dr.Item("nombres")
                emp.Ap_Paterno = dr.Item("ap_paterno")
                emp.Ap_Materno = dr.Item("ap_materno")
                emp.Cargo = dr.Item("cargo")
                emp.Dni = dr.Item("dni")
                emp.Direccion = dr.Item("direccion")
                emp.Correo = dr.Item("correo")
                emp.Telefono = dr.Item("telefono")
                emp.Celular = dr.Item("celular")
                empleados.Add(emp)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return empleados
    End Function


End Class
