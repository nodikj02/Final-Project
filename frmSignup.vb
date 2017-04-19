Public Class frmSignup
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'initially clear errors
        ErrorProvider.Clear()
        lblStatus.Text = ""

        Dim valid As Boolean = True




        'check remaining text fields for blanks
        For Each txt As Control In Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    txt.Focus()
                    ErrorProvider.SetError(txt, "Textbox Can't be empty")
                    lblStatus.Text = ErrorProvider.GetError(txt)
                    valid = False

                End If

            End If


        Next

        'check if username is taken. if the username provided returns a first name then it is taken
        If Not CustomersTableAdapter.getNameByUsername(txtuser.Text) = Nothing Then
            ErrorProvider.SetError(txtuser, "Username is already taken!")
            lblStatus.Text = ErrorProvider.GetError(txtuser)
            valid = False
        End If


        'check if passwords match
        If Not txtpass.Text = txtvpass.Text Then
            ErrorProvider.SetError(txtvpass, "Passwords do not match!")
            lblStatus.Text = ErrorProvider.GetError(txtvpass)
            valid = False
        End If


        'Add all information to the customer table as a new customer
        If valid Then
            CustomersTableAdapter.AddCustomer(txtfname.Text, txtlname.Text, txtemail.Text, txtuser.Text, txtpass.Text)
            MessageBox.Show("Successfully Registered!")
            CustomersTableAdapter.Update(FinalProjectDBDataSet.Customers)
            FinalProjectDBDataSet.AcceptChanges()
            My.Forms.frmSignup.Close()

        End If



    End Sub
End Class