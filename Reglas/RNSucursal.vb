
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

        pars.Add(New CParametro("pCodigo", wSucursal.Codigo))
        pars.Add(New CParametro("pCorreo", wSucursal.Correo))
        pars.Add(New CParametro("pDireccion", wSucursal.Direccion))
        pars.Add(New CParametro("pTelefono", wSucursal.Telefono))

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

        pars.Add(New CParametro("pCodigo", wSucursal.Codigo))

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("fu_leersucursal", pars)
            If dr.Read = True Then
                s = New Sucursal
                s.Codigo = wSucursal.Codigo
                s.Correo = dr.Item("correo")
                s.Direccion = dr.Item("direccion")
                s.Telefono = dr.Item("telefono")

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
        Return s
    End Function

    Public Function Listar(ByVal wNombre As String) As List(Of Sucursal)
        Dim sucursal As List(Of Sucursal)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim s As Sucursal = Nothing

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lisucursal", Nothing)
            sucursal = New List(Of Sucursal)
            Do While dr.Read = True
                s = New Sucursal
                s.Codigo = dr.Item("idsucursal")
                s.Correo = dr.Item("correo")
                s.Telefono = dr.Item("telefono")
                s.Direccion = dr.Item("direccion")
                s.ZonaNombre = dr.Item("NomZona")
                sucursal.Add(s)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return sucursal
    End Function


End Class
