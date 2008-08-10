Public Class frmUpdateUser

    Private Sub frmUpdateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call the default load event
        DefaultLoad()

        ' Populate the form
        txtUsername.Text = strUserInfo(intUserInfo.LoginID)
        txtFirstName.Text = strUserInfo(intUserInfo.FirstName)
        txtSurname.Text = strUserInfo(intUserInfo.Surname)
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Variable to hold the encrypted password
        Dim strHashedPassword As String

        ' Database Variable
        Dim sqlStatement As SqlClient.SqlCommand

        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        If lblError.Visible = True Then
            ' Enable the form and exit the event
            Me.Enabled = True
            Return
        End If

        ' Load the are you sure dialog
        frmAreYouSure.ShowDialog()

        If frmAreYouSure.DialogResult = Windows.Forms.DialogResult.Cancel Then
            ' Enable the form and exit the event
            Me.Enabled = True
            Return
        End If

        If chkPassword.Checked = True Then
            ' Encrypt the password using the username
            strHashedPassword = EncryptPassword(txtUsername.Text.Trim, txtPassword.Text.Trim)

            ' Construct the statement
            sqlStatement = New SqlClient.SqlCommand("UPDATE UserName SET LoginID = '" & txtUsername.Text.Trim & "', FirstName = '" & txtFirstName.Text.Trim & "', Surname = '" & txtSurname.Text.Trim & "', Password = '" & strHashedPassword & "' WHERE ID = " & strUserInfo(intUserInfo.ID), ctnTimetable)
        Else
            ' Construct the statement
            sqlStatement = New SqlClient.SqlCommand("UPDATE UserName SET LoginID = '" & txtUsername.Text.Trim & "', FirstName = '" & txtFirstName.Text.Trim & "', Surname = '" & txtSurname.Text.Trim & "' WHERE ID = " & strUserInfo(intUserInfo.ID), ctnTimetable)
        End If

        ' Execute the update
        sqlStatement.ExecuteNonQuery()

        ' Set the new values the the user array
        strUserInfo(intUserInfo.LoginID) = txtUsername.Text
        strUserInfo(intUserInfo.FirstName) = txtFirstName.Text
        strUserInfo(intUserInfo.Surname) = txtSurname.Text

        ' Set the return dialog to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the form
        Me.Close()
    End Sub
End Class
