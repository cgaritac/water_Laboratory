Public Class FrmUsuario
    Dim usuario As String = "admin"
    Dim contrasena As String = "123"

    Private Sub btnAccesoIngresar_Click(sender As Object, e As EventArgs) Handles btnAccesoIngresar.Click
        If txtUsuario.Text.Equals(usuario) = True And txtContrasena.Text.Equals(contrasena) = True Then
            FrmPadreMenu.Show()
        Else
            If txtUsuario.Text = "" Or txtContrasena.Text = "" Then
                MessageBox.Show("Error, Favor ingrese todos los datos", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                If txtUsuario.Text.Equals(usuario) = False Then
                    MessageBox.Show("Error, Favor ingrese nuevamente el nombre de usuario", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End If

                If txtContrasena.Text.Equals(contrasena) = False Then
                    MessageBox.Show("Error, Favor ingrese nuevamente la contraseña", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End If
            End If

        End If
    End Sub

    Private Sub btnAccesoSalir_Click(sender As Object, e As EventArgs) Handles btnAccesoSalir.Click
        End
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToolStripStatusLabel1.Text = DateTime.Now.ToLocalTime()
    End Sub

End Class
