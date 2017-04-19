Public Class frmMain

    Public mloggedin As Boolean
    Public mName As String


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' a new requirement: The application will refer to the customer by the first name they provided.

        mloggedin = False




    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        'users must be online to access check out

        If mloggedin Then
            My.Forms.frmCheckout.Show()
        Else
            lblStat.Text = "You must log in before proceeding to checkout"
            My.Forms.frmLogin.Show()
        End If

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        My.Forms.frmLogin.Show()
    End Sub
End Class
