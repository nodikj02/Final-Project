Public Class frmLogin
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'check if the username and combo is in database
        If CustomersTableAdapter.validateLogin(txtUsername.Text, txtPass.Text) > 0 Then
            My.Forms.frmMain.mloggedin = True
            My.Forms.frmMain.Name = CustomersTableAdapter.getNameByUsername(txtUsername.Text)
            My.Forms.frmMain.lblName.Text = "Welcome " + My.Forms.frmMain.Name
            My.Forms.frmLogin.Close()

        End If

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        My.Forms.frmSignup.Show()
    End Sub
End Class