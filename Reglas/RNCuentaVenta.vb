Public Class RNCuentaVenta
    Inherits CADO

    Sub Registrar(ByVal wCuenta As CuentaVenta)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pCCI", wCuenta.CCI))
        pars.Add(New CParametro("pIdBanco", wCuenta.Banco.Codigo))
        pars.Add(New CParametro("pVigencia", wCuenta.Vigencia))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_icuentaventa", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

    Function Listar() As List(Of CuentaVenta)
        Dim Cuentas As List(Of CuentaVenta)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim cu As CuentaVenta = Nothing

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_licuentas", Nothing)
            Cuentas = New List(Of CuentaVenta)
            Do While dr.Read = True
                cu = New CuentaVenta
                cu.Codigo = dr.Item("idcuentaventa")
                cu.CCI = dr.Item("cci")
                cu.Vigencia = dr.Item("vigencia")
                cu.Banco = New Banco
                cu.Banco.Codigo = dr.Item("idbanco")
                cu.Banco.Nombre = dr.Item("nombre")
                Cuentas.Add(cu)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Cuentas
    End Function

    Function ListarxIdBanco(ByVal wCodBanco As Integer) As List(Of CuentaVenta)
        Dim Cuentas As List(Of CuentaVenta)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim cu As CuentaVenta = Nothing

        pars.Add(New CParametro("pIdBanco", wCodBanco))

        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_licuentasxidbanco", pars)
            Cuentas = New List(Of CuentaVenta)
            Do While dr.Read = True
                cu = New CuentaVenta
                cu.Codigo = dr.Item("idcuentaventa")
                cu.CCI = dr.Item("cci")
                Cuentas.Add(cu)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return Cuentas
    End Function

End Class
