Imports System.Net.Mail

Public Class frmGestionNotificacionesCorreo

    Dim message As New MailMessage
    Dim smtp As New SmtpClient

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ListarClientes()
        'Dim rn As RNCliente

    End Sub

    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCorreo.Click
        message.From = New MailAddress("miempresa@gmail.com")

        message.To.Add("eder.figueroa@outlook.com")
        'message.To.Add("edermax1992@gmail.com")

        message.Body = "NOTIFICACIÓN DE PAGO" & vbNewLine & "Fecha de Pago: " & vbNewLine & "Monto a pagar: "
        message.Subject = "NOTIFICACIÓN: PAGO DE CUOTA"
        message.Priority = MailPriority.Normal

        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = "smtp.gmail.com"

        smtp.Credentials = New System.Net.NetworkCredential("miempresa@gmail.com", "password123")
        smtp.Send(message)

    End Sub
End Class