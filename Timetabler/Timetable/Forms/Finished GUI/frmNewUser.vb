Public Class frmNewUser

    Private Sub frmNewUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Call the default load event
        DefaultLoad()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Variable to hold the encrypted password
        Dim strHashedPassword As String

        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        If lblError.Visible = True Then
            ' Enable the form and exit the event
            Me.Enabled = True
            Return
        End If

        If chkPassword.Checked = True Then
            ' Encrypt the password using the username
            strHashedPassword = EncryptPassword(txtUsername.Text.Trim, txtPassword.Text.Trim)
        Else
            ' Encrypt the password using the username
            strHashedPassword = EncryptPassword(txtUsername.Text.Trim, "")
        End If
        
        ' Add the values to the database
        AddFourFields("UserName", "LoginID", Trim(txtUsername.Text), "FirstName", Trim(txtFirstName.Text), "Surname", Trim(txtSurname.Text), "Password", strHashedPassword)

        ' Set the return dialog to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the form
        Me.Close()
    End Sub
End Class
