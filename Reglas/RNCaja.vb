Public Class RNCaja
    Inherits CADO

    Sub Registrar(ByVal wCaja As Caja)
        Dim pars As New List(Of CParametro)
        pars.Add(New CParametro("pNumero", wCaja.Numero))
        pars.Add(New CParametro("pDescripcion", wCaja.Descripcion))
        pars.Add(New CParametro("pFechaApertura", wCaja.FechaApertura))
        pars.Add(New CParametro("pFechaCierre", wCaja.FechaCierre))
        pars.Add(New CParametro("pMontoApertura", wCaja.MontoApertura))
        pars.Add(New CParametro("pMontoCierre", wCaja.MontoCierre))
        pars.Add(New CParametro("pEstado", wCaja.Estado)) 'siempre estaran activadas las cajas por ahora
        pars.Add(New CParametro("pEmpleado", wCaja.Empleado.Codigo))
        pars.Add(New CParametro("pSucursal", wCaja.Sucursal.Codigo))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_icaja", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Function Listar() As List(Of Caja)
        Dim cajas As List(Of Caja)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim ca As Caja = Nothing

        'pars.Add(New CParametro("pnumero", wNumCaja))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_licaja", Nothing)
            cajas = New List(Of Caja)
            Do While dr.Read = True
                ca = New Caja
                ca.Codigo = dr.Item("idcaja")
                ca.Numero = dr.Item("numero")
                'If dr.Item("descripcion") Is Nothing Then
                '    ca.Descripcion = ""
                'End If
                ca.FechaApertura = CDate(dr.Item("fechaapertura"))
                ca.FechaCierre = CDate(dr.Item("fechacierre"))
                ca.MontoApertura = dr.Item("montoapertura")
                ca.MontoCierre = dr.Item("montocierre")
                ca.Estado = CBool(dr.Item("estado"))
                cajas.Add(ca)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return cajas
    End Function

    Sub Actualizar(ByVal wCaja As Caja)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pIdCaja", wCaja.Codigo))
        pars.Add(New CParametro("pDescripcion", wCaja.Descripcion))
        pars.Add(New CParametro("pFechaCierre", wCaja.FechaCierre))
        pars.Add(New CParametro("pMontoCierre", wCaja.MontoCierre))
        pars.Add(New CParametro("pEstado", wCaja.Estado))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_acaja", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Function ListarCajasAbiertas() As List(Of Caja)
        Dim cajAb As List(Of Caja) = Nothing
        Dim dr As NpgsqlDataReader = Nothing
        Dim ca As Caja

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_licajasabiertas", Nothing)
            cajAb = New List(Of Caja)

            Do While dr.Read = True
                ca = New Caja
                ca.Codigo = dr.Item("idcaja")
                ca.Numero = dr.Item("numero")
                cajAb.Add(ca)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Throw ex
        End Try

        Return cajAb
    End Function

    Function BuscarPorNumero(ByVal wNumCaja As Integer)
        Dim cajas As List(Of Caja) = Nothing
        Dim param As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim ca As Caja

        param.Add(New CParametro("pNumCaja", wNumCaja))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_buscarcaja", param)
            cajas = New List(Of Caja)
            Do While dr.Read = True
                ca = New Caja
                ca.Codigo = dr.Item("idcaja")
                ca.Numero = dr.Item("numero")
                ca.FechaApertura = CDate(dr.Item("fechaapertura"))
                ca.FechaCierre = CDate(dr.Item("fechacierre"))
                ca.MontoApertura = dr.Item("montoapertura")
                ca.MontoCierre = dr.Item("montocierre")
                ca.Estado = CBool(dr.Item("estado"))
                cajas.Add(ca)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Throw ex
        End Try

        Return cajas
    End Function

End Class

