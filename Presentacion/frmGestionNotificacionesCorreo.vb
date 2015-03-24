Imports System.Net.Mail

Public Class frmGestionNotificacionesCorreo

    Dim message As New MailMessage
    Dim smtp As New SmtpClient
    Dim Detalles As List(Of DetalleCliente)

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ListarClientes()
        Dim rn As New RNCliente


        Try
            Detalles = rn.ListarClientexCuota()
            modFunciones.EnlazarDatagridView(dgvCliente, Detalles)
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each elem As DetalleCliente In Detalles
            message.From = New MailAddress("empresaconectividad4@gmail.com")

            message.To.Add(elem.Persona.Correo)

            message.Body = "NOTIFICACIÓN DE PAGO" & vbNewLine _
                            & "Fecha de Pago: " & vbNewLine _
                            & "Monto a pagar: "
            message.Subject = "NOTIFICACIÓN: PAGO DE CUOTA"
            message.Priority = MailPriority.Normal

            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.gmail.com"

            smtp.Credentials = New System.Net.NetworkCredential("empresaconectividad4@gmail.com", "cone2015")
            smtp.Send(message)
        Next
    End Sub
End Class