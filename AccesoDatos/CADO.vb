﻿Imports System.Configuration.DefaultSettingValueAttribute
Imports Npgsql

Public Class CADO

    Private mOConexion As NpgsqlConnection
    Private mOTransaccion As NpgsqlTransaction

    Protected Property Conexion() As NpgsqlConnection
        Get
            Return mOConexion
        End Get
        Set(ByVal value As NpgsqlConnection)
            mOConexion = value
        End Set
    End Property

    Protected ReadOnly Property Transaccion() As NpgsqlTransaction
        Get
            Return mOTransaccion
        End Get
    End Property

    Protected Sub Conectar(ByVal wIniciarTransaccion As Boolean)
        mOConexion = New NpgsqlConnection(My.Settings.Conexion)
        mOConexion.Open()
        If wIniciarTransaccion = True Then
            mOTransaccion = Me.Conexion.BeginTransaction
        End If
    End Sub

    Protected Sub Cerrar(ByVal wCorrecto As Boolean)
        If Me.Transaccion IsNot Nothing Then
            If wCorrecto = True Then
                Me.Transaccion.Commit()
            Else
                Me.Transaccion.Rollback()
            End If
            Me.mOTransaccion = Nothing
        End If
        If Me.Conexion.State = ConnectionState.Open Then
            Me.Conexion.Close()
        End If
        Me.Conexion = Nothing
    End Sub

    Protected Function PedirDataReader(ByVal wSQL As String, ByVal wParametros As List(Of CParametro)) As NpgsqlDataReader
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim dr As NpgsqlDataReader = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        Me.LlenarParametros(cmd, wParametros)
        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If
        Try
            dr = cmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
        End Try

        Return dr
    End Function

    Protected Function PedirDataReader(ByVal wSQL As String) As NpgsqlDataReader
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim dr As NpgsqlDataReader = Nothing

        cmd.CommandType = CommandType.Text
        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If
        Try
            dr = cmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
        End Try

        Return dr
    End Function

    Protected Function PedirDatatable(ByVal wSQL As String, ByVal wParametros As List(Of CParametro)) As DataTable
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim da As New NpgsqlDataAdapter(cmd)
        Dim dt As New DataTable

        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        Me.LlenarParametros(cmd, wParametros)
        Try
            da.Fill(dt)
        Catch ex As Exception
            dt = Nothing
            Throw ex
        Finally
            cmd = Nothing
            da = Nothing
        End Try

        Return dt
    End Function

    Protected Function EjecutarOrden(ByVal wSQL As String, ByVal wParametros As List(Of CParametro)) As Integer
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim num As Integer

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If
        Me.LlenarParametros(cmd, wParametros)

        Try
            num = cmd.ExecuteNonQuery
            Me.VerParametrosSalida(cmd, wParametros)
        Catch ex As Exception
            Throw ex
        Finally
            cmd = Nothing
        End Try

        Return num
    End Function

    Protected Function EjecutarSQL(ByVal wSQL As String) As Integer
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim num As Integer

        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 0
        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If

        Try
            num = cmd.ExecuteNonQuery
        Catch ex As Exception
            Throw ex
        Finally
            cmd = Nothing
        End Try

        Return num
    End Function

    Protected Function EjecutarSQLDatos(ByVal wSQL As String) As DataTable
        Dim cmd As New NpgsqlCommand(wSQL, Me.Conexion)
        Dim da As New NpgsqlDataAdapter(cmd)
        Dim dt As New DataTable

        cmd.CommandType = CommandType.Text
        If mOTransaccion IsNot Nothing Then
            cmd.Transaction = mOTransaccion
        End If

        Try
            da.Fill(dt)
        Catch ex As Exception
            Throw ex
        Finally
            cmd = Nothing
        End Try

        Return dt
    End Function

    Private Sub LlenarParametros(ByVal cmd As NpgsqlCommand, ByVal wParametros As List(Of CParametro))

        If wParametros IsNot Nothing Then
            For Each par As CParametro In wParametros
                With cmd.Parameters
                    .AddWithValue(par.Nombre, par.Valor).Direction = par.DireccionBD
                End With
            Next
        End If
    End Sub

    Private Sub VerParametrosSalida(ByVal cmd As NpgsqlCommand, ByVal wParametros As List(Of CParametro))

        If wParametros IsNot Nothing Then
            With cmd.Parameters
                For i As Integer = 0 To .Count - 1
                    If .Item(i).Direction = ParameterDirection.Output Then
                        wParametros.Item(i).Valor = .Item(i).Value
                    End If
                Next
            End With
        End If
    End Sub

End Class

