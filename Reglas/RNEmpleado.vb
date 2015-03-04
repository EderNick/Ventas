Public Class RNEmpleado
    Inherits CADO
    Function Listar(ByVal wEmpleado As String, ByVal sw As Byte, ByVal id As Integer) As List(Of Empleado)
        Dim param As New List(Of CParametro)
        Dim emp As Empleado = Nothing
        Dim empleados As List(Of Empleado) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pnombre", wEmpleado))
        param.Add(New CParametro("pid", id))
        Try
            Me.Conectar(True)
            If (sw = 1) Then
                dr = Me.PedirDataReader("fu_liempleados", param)
            Else
                dr = Me.PedirDataReader("fu_lDniempleados", param)
            End If
            empleados = New List(Of Empleado)
            While dr.Read
                emp = New Empleado
                emp.Codigo = CInt(dr.Item("idempleado"))
                emp.Nombres = dr.Item("nombres")
                emp.Ap_Paterno = dr.Item("ap_paterno")
                emp.Ap_Materno = dr.Item("ap_materno")
                emp.Cargo = Convert.ToString(dr.Item("cargo"))
                emp.Dni = dr.Item("dni")
                emp.Direccion = Convert.ToString(dr.Item("direccion"))
                emp.Correo = Convert.ToString(dr.Item("correo"))
                emp.Telefono = Convert.ToString(dr.Item("telefono"))
                emp.Celular = Convert.ToString(dr.Item("celular"))
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

    Public Sub Registrar(ByVal wEmpleado As Empleado, ByVal sucursal As Integer)
        Dim pars As New List(Of CParametro)
        pars.Add(New CParametro("pnombres", wEmpleado.Nombres))
        pars.Add(New CParametro("pPaterno", wEmpleado.Ap_Paterno))
        pars.Add(New CParametro("pMaterno", wEmpleado.Ap_Materno))
        pars.Add(New CParametro("pdni", wEmpleado.Dni))
        pars.Add(New CParametro("pfono", wEmpleado.Telefono))
        pars.Add(New CParametro("pcorreo", wEmpleado.Correo))
        pars.Add(New CParametro("pcargo", wEmpleado.Cargo))
        pars.Add(New CParametro("pIdSucursal", sucursal))
        pars.Add(New CParametro("pdireccion", wEmpleado.Direccion))
        pars.Add(New CParametro("pcelular", wEmpleado.Celular))
        pars.Add(New CParametro("pvigencia", wEmpleado.Vigencia))
        pars.Add(New CParametro("plicencia", wEmpleado.Num_Licencia))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_iEmpleado", pars)

            Me.Cerrar(True)
        Catch ex As Exception

            Me.Cerrar(False)
            Throw ex

        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Public Function Leer(ByVal wEmpleado As Empleado, ByVal id As Integer) As Empleado
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim Em As Empleado = Nothing

        pars.Add(New CParametro("pCodigo", wEmpleado.Codigo))
        pars.Add(New CParametro("pid", id))

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leerempleado", pars)
            If dr.Read = True Then
                Em = New Empleado
                Em.Codigo = wEmpleado.Codigo
                Em.Nombres = dr.Item("nombres")
                Em.Ap_Paterno = dr.Item("ap_paterno")
                Em.Ap_Materno = dr.Item("ap_materno")
                Em.Cargo = Convert.ToString(dr.Item("cargo"))
                Em.Dni = dr.Item("dni")
                Em.Num_Licencia = Convert.ToString(dr.Item("num_licencia"))
                Em.Direccion = Convert.ToString(dr.Item("direccion"))
                Em.Telefono = Convert.ToString(dr.Item("telefono"))
                Em.Celular = Convert.ToString(dr.Item("celular"))
                Em.Correo = Convert.ToString(dr.Item("correo"))
                Em.Vigencia = dr.Item("vigencia")

            End If

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            pars = Nothing
        End Try
        Return Em
    End Function

    Public Sub Actualizar(ByVal wEmpleado As Empleado, ByVal id As Integer)

        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pcodigo", wEmpleado.Codigo))
        pars.Add(New CParametro("pnombres", wEmpleado.Nombres))
        pars.Add(New CParametro("pPaterno", wEmpleado.Ap_Paterno))
        pars.Add(New CParametro("pMaterno", wEmpleado.Ap_Materno))
        pars.Add(New CParametro("pdni", wEmpleado.Dni))
        pars.Add(New CParametro("pfono", wEmpleado.Telefono))
        pars.Add(New CParametro("pcorreo", wEmpleado.Correo))
        pars.Add(New CParametro("pcargo", wEmpleado.Cargo))
        pars.Add(New CParametro("pIdSucursal", id))
        pars.Add(New CParametro("pdireccion", wEmpleado.Direccion))
        pars.Add(New CParametro("pcelular", wEmpleado.Celular))
        pars.Add(New CParametro("pvigencia", wEmpleado.Vigencia))
        pars.Add(New CParametro("plicencia", wEmpleado.Num_Licencia))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_Mempleado", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub
End Class

