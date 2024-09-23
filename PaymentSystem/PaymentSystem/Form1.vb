Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtusername.Text = "Account" And txtpassword.Text = "Pass123" Then
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username/Password")
        End If
    End Sub
End Class
