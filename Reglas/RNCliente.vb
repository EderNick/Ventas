Public Class RNCliente
    Inherits CADO

    Function BuscarxDNI(ByVal wDNI As String) As List(Of DetalleCliente)
        Dim param As New List(Of CParametro)
        Dim dcli As DetalleCliente = Nothing
        Dim detclientes As List(Of DetalleCliente) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pDNI", wDNI))

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_buscarClienteXDNI", param)

            detclientes = New List(Of DetalleCliente)
            While dr.Read
                dcli = New DetalleCliente
                dcli.Codigo = CInt(dr.Item("iddetallecliente"))
                dcli.Persona = New Persona
                dcli.Persona.Codigo = CInt(dr.Item("idpersona"))
                dcli.Persona.Nombres = dr.Item("nombres")
                dcli.Persona.Ap_Paterno = dr.Item("ap_paterno")
                dcli.Persona.Ap_Materno = dr.Item("ap_materno")
                dcli.Persona.DNI = wDNI
                dcli.Persona.Sexo = dr.Item("sexo")
                dcli.Persona.Direccion = dr.Item("direccion")
                dcli.Persona.Telefono = dr.Item("telefono")
                dcli.Cliente = New Cliente
                dcli.Cliente.Codigo = CInt(dr.Item("idcliente"))
                dcli.Cliente.Tipo = dr.Item("tipo")
                dcli.Cliente.Empleado = New Empleado
                dcli.Cliente.Empleado.Nombres = dr.Item("enombres")
                dcli.Cliente.Empleado.Ap_Paterno = dr.Item("epaterno")
                dcli.Cliente.Empleado.Ap_Materno = dr.Item("ematerno")
                dcli.Cliente.Zona = New Zona
                dcli.Cliente.Zona.ZonaNomb = dr.Item("NomZona")
                detclientes.Add(dcli)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return detclientes
    End Function

    Function BuscarxRUC(ByVal wRUC As String) As List(Of DetalleCliente)
        Dim param As New List(Of CParametro)
        Dim dcli As DetalleCliente = Nothing
        Dim detclientes As List(Of DetalleCliente) = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        param.Add(New CParametro("pRUC", wRUC))

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_buscarClienteXRUC", param)

            detclientes = New List(Of DetalleCliente)
            While dr.Read
                dcli = New DetalleCliente
                dcli.Codigo = CInt(dr.Item("iddetallecliente"))
                dcli.EmpresaJuridica = New EmpresaJuridica
                dcli.EmpresaJuridica.Codigo = CInt(dr.Item("idempresajuridica"))
                dcli.EmpresaJuridica.RazonSocial = dr.Item("razonsocial")
                dcli.EmpresaJuridica.RUC = wRUC
                dcli.EmpresaJuridica.Direccion = dr.Item("direccion")
                dcli.EmpresaJuridica.Telefono = dr.Item("telefono")
                dcli.EmpresaJuridica.Correo = dr.Item("correo")
                dcli.Cliente = New Cliente
                dcli.Cliente.Codigo = CInt(dr.Item("idcliente"))
                dcli.Cliente.Tipo = dr.Item("tipo")
                dcli.Cliente.Empleado = New Empleado
                dcli.Cliente.Empleado.Nombres = dr.Item("enombres")
                dcli.Cliente.Empleado.Ap_Paterno = dr.Item("epaterno")
                dcli.Cliente.Empleado.Ap_Materno = dr.Item("ematerno")
                dcli.Cliente.Zona = New Zona
                dcli.Cliente.Zona.ZonaNomb = dr.Item("NomZona")
                detclientes.Add(dcli)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            param.Clear()
            param = Nothing
        End Try

        Return detclientes
    End Function

    Function ListarClientexCuota() As List(Of DetalleCliente)
        Dim DetalleCli As List(Of DetalleCliente) = Nothing
        Dim DC As DetalleCliente = Nothing
        Dim dr As Npgsql.NpgsqlDataReader = Nothing

        Try
            Me.Conectar(True)

            dr = Me.PedirDataReader("fu_liCuotaClientesNaturales", Nothing)

            DetalleCli = New List(Of DetalleCliente)
            While dr.Read
                DC = New DetalleCliente
                DC.Codigo = CInt(dr.Item("iddetallecliente"))
                DC.Cliente = New Cliente
                DC.Cliente.Codigo = CInt(dr.Item("idcliente"))
                DC.Cliente.Tipo = dr.Item("tipo")
                DC.Persona = New Persona
                DC.Persona.Codigo = CInt(dr.Item("idcliente"))
                DC.Persona.Nombres = dr.Item("nombres")
                DC.Persona.Ap_Paterno = dr.Item("ap_paterno")
                DC.Persona.Ap_Materno = dr.Item("ap_materno")
                DC.Persona.Correo = dr.Item("correo")
                DetalleCli.Add(DC)
            End While


            dr = Me.PedirDataReader("fu_licuotaclientesjuridicos", Nothing)

            While dr.Read
                DC = New DetalleCliente
                DC.Codigo = CInt(dr.Item("iddetallecliente"))
                DC.Cliente = New Cliente
                DC.Cliente.Codigo = CInt(dr.Item("idcliente"))
                DC.Cliente.Tipo = dr.Item("tipo")
                DC.EmpresaJuridica = New EmpresaJuridica
                DC.EmpresaJuridica.Codigo = CInt(dr.Item("idempresajuridica"))
                DC.EmpresaJuridica.RazonSocial = dr.Item("razonsocial")
                DC.EmpresaJuridica.Correo = dr.Item("correo")
                DetalleCli.Add(DC)
            End While
        Catch ex As Exception
            Throw ex
        End Try

        Return DetalleCli
    End Function


End Class
