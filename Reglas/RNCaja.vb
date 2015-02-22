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
        pars.Add(New CParametro("pEstado", True)) 'siempre estaran activadas las cajas por ahora
        pars.Add(New CParametro("pEmpleado", 1))
        pars.Add(New CParametro("pSucursal", 1))

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
                ca.IdCaja = dr.Item("idcaja")
                ca.Numero = dr.Item("numero")
                'ca.Descripcion = dr.Item("descripcion")
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

End Class

