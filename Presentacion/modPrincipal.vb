﻿Module modPrincipal
    Public nombre_user As String = ""
    Public UsuarioActual As Usuario

    Public Sub Main()
        Dim frm As New frmLogin
        Dim frmPrinc As frmSucursal

        UsuarioActual = frm.Identificar()
        If UsuarioActual IsNot Nothing Then
            frmPrinc = New frmSucursal
            frmPrinc.ShowDialog()
        End If

    End Sub

End Module
