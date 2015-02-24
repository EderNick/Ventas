Public Class frmLogin
    Dim sw As Boolean
    Private Usuario As Usuario = Nothing

    Private Sub txtPasword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPasword.GotFocus
        If txtPasword.Text = "CONTRASEÑA" Then
            txtPasword.Text = ""
            txtPasword.ForeColor = Color.Black
            txtPasword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPasword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPasword.LostFocus
        If txtPasword.Text = "" Then
            txtPasword.PasswordChar = ""
            txtPasword.Text = "CONTRASEÑA"
            txtPasword.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Text = "USUARIO"
        txtPasword.Text = "CONTRASEÑA"
        txtPasword.ForeColor = Color.Gray
        txtUser.ForeColor = Color.Gray
        sw = False
    End Sub

    Private Sub txtUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.GotFocus
        If txtUser.Text = "USUARIO" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.LostFocus
        If txtUser.Text = "" Then
            txtUser.Text = "USUARIO"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        Dim rn As RNUsuario

        Me.Usuario = New Usuario
        Me.Usuario.Nombre = Me.txtUser.Text
        Me.Usuario.Clave = Me.txtPasword.Text
        rn = New RNUsuario
        Try
            Me.Usuario = rn.Identificar(Me.Usuario)
            If Me.Usuario IsNot Nothing Then
                Me.Close()
                modPrincipal.nombre_user = txtUser.Text
                'frmSucursal.Show()
            Else
                MessageBox.Show("Datos Incorrectos",
                  Me.Text, MessageBoxButtons.OK,
                  MessageBoxIcon.Information)
                Me.txtUser.Text = ""
                Me.txtPasword.Text = ""
                Me.txtUser.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            rn = Nothing
        End Try
    End Sub

    Public Function Identificar()
        Me.ShowDialog()
        Return Usuario
    End Function
End Class