
Public Class RNSucursal
    Inherits CADO

    Public Sub Registrar(ByVal wSucursal As Sucursal)
        Dim paramSucursal As New List(Of CParametro)
        Dim paramZona As New List(Of CParametro)
        Dim val As Integer = 0

        paramZona.Add(New CParametro("pcodigo", 0, CParametro.DireccionParametro.SALIDA))
        paramZona.Add(New CParametro("piddepartamento", wSucursal.zona.Departamento.Codigo))
        paramZona.Add(New CParametro("pidprovincia", wSucursal.zona.Provincia.Codigo))
        paramZona.Add(New CParametro("piddistrito", wSucursal.zona.Distrito.Codigo))

        Try
            Me.Conectar(True)
            Me.EjecutarOrden("fu_izona", paramZona)
            val = CInt(paramZona.ElementAt(0).Valor)

            paramSucursal.Add(New CParametro("pZona", val))
            paramSucursal.Add(New CParametro("pempresa", wSucursal.Empresa.Codigo))
            paramSucursal.Add(New CParametro("pnombre", wSucursal.Nombre))
            paramSucursal.Add(New CParametro("pCorreo", wSucursal.Correo))
            paramSucursal.Add(New CParametro("pDireccion", wSucursal.Direccion))
            paramSucursal.Add(New CParametro("pTelefono", wSucursal.Telefono))
            Me.EjecutarOrden("fu_isucursal", paramSucursal)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            paramSucursal.Clear()
            paramSucursal = Nothing
            paramZona.Clear()
            paramZona = Nothing
        End Try
    End Sub

    Public Sub Actualizar(ByVal wSucursal As Sucursal)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pcodigosucursal", wSucursal.Codigo))
        pars.Add(New CParametro("pcodigozona", wSucursal.zona.Codigo))
        pars.Add(New CParametro("pnombre", wSucursal.Nombre))
        pars.Add(New CParametro("pCorreo", wSucursal.Correo))
        pars.Add(New CParametro("pDireccion", wSucursal.Direccion))
        pars.Add(New CParametro("pTelefono", wSucursal.Telefono))
        pars.Add(New CParametro("piddepartamento", wSucursal.zona.Departamento.Codigo))
        pars.Add(New CParametro("pidprovincia", wSucursal.zona.Provincia.Codigo))
        pars.Add(New CParametro("piddistrito", wSucursal.zona.Distrito.Codigo))
        pars.Add(New CParametro("pvigencia", wSucursal.Vigencia))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_asucursal", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try
    End Sub

    Public Function Leer(ByVal wSucursal As Sucursal) As Sucursal
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim s As Sucursal = Nothing

        pars.Add(New CParametro("pcodigo", wSucursal.Codigo))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_leersucursal", pars)
            While dr.Read = True
                s = New Sucursal
                With s
                    .Codigo = wSucursal.Codigo
                    .Nombre = dr.Item("nombre")
                    .Correo = dr.Item("correo")
                    .Direccion = dr.Item("direccion")
                    .Telefono = dr.Item("telefono")
                    .Vigencia = dr.Item("vigencia")
                    .zona = New zona
                    .zona.Codigo = wSucursal.zona.Codigo
                    .zona.Departamento = New Departamento
                    .zona.Departamento.Nombre = dr.Item("departamento")
                    .zona.Provincia = New Provincia
                    .zona.Provincia.Nombre = dr.Item("provincia")
                    .zona.Distrito = New Distrito
                    .zona.Distrito.nombre = dr.Item("distrito")
                End With
            End While
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
        Return s
    End Function

    Public Function Listar(ByVal wNombre As String) As List(Of Sucursal)
        Dim sucursal As List(Of Sucursal)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim s As Sucursal = Nothing

        pars.Add(New CParametro("pnombre", wNombre))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lisucursal", pars)
            sucursal = New List(Of Sucursal)
            Do While dr.Read = True
                s = New Sucursal
                s.Codigo = dr.Item("idsucursal")
                s.zona = New zona
                s.zona.Codigo = dr.Item("idzona")
                s.Nombre = dr.Item("nombre")
                s.Correo = dr.Item("correo")
                s.Telefono = dr.Item("telefono")
                s.Direccion = dr.Item("direccion")
                s.ZonaNombre = dr.Item("NomZona")
                s.Vigencia = dr.Item("vigencia")
                sucursal.Add(s)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
        Return sucursal
    End Function


End Class
