Public Class frmMain

    Public loggedin As Boolean


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' a new requirement: The application will refer to the customer by the first name they provided.

        loggedin = False




    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        'users must be online to access check out

        If loggedin Then
            My.Forms.frmCheckout.Show()
        Else
            lblStat.Text = "You must log in before proceeding to checkout"
            My.Forms.frmLogin.Show()
        End If

    End Sub
End Class
