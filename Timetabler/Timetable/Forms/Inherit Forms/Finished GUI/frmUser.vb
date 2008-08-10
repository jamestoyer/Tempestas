Public Class frmUser

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Private Sub TextOnlyTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFirstName.KeyDown, txtSurname.KeyDown
       ' Call the allow only letters event
        TextBoxEvents.AllowOnlyText(sender, e)
    End Sub

    ' The default load event
    Public Sub DefaultLoad()
        ' Clear the form
        txtConfirm.Text = Nothing
        txtFirstName.Text = Nothing
        txtPassword.Text = Nothing
        txtSurname.Text = Nothing
        txtUsername.Text = Nothing

        ' Disable the password labels and text boxes
        lblPassword.Enabled = False
        lblConfirm.Enabled = False
        txtPassword.Enabled = False
        txtConfirm.Enabled = False

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the text box
        Me.ActiveControl = txtUsername
    End Sub

    ' Check for errors on the form
    Public Sub ErrorCheck()
        ' Constants containing error messages
        Const strNoUsername As String = "Please enter a username"
        Const strUsernameTaken As String = "Username is already taken"
        Const strPasswordMatch As String = "The entered passwords do not match"

        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Variables to hold the encrypted passwords
        Dim strPassword As String
        Dim strConfirmPassword As String

        ' Reset the back colours of the text boxes
        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White
        txtConfirm.BackColor = Color.White

        ' Hide the error label
        lblError.Visible = False

        ' Check to make sure a user name has been entered
        If txtUsername.Text = "" Then
            ' Set the error state
            SetErrorState(strNoUsername, txtUsername)

            ' Exit the sub
            Return
        End If

        ' Check to see if the update user form is open
        If frmUpdateUser.Enabled = True Then
            ' Construct the sql read statement
            sqlStatement = New SqlClient.SqlCommand("SELECT LoginID FROM UserName", ctnTimetable)

            ' Read from the database
            sqlResults = sqlStatement.ExecuteReader

            Do While sqlResults.Read
                ' Check to see if the username is taken
                If txtUsername.Text.Trim = sqlResults!LoginID Then
                    ' Set the error state
                    SetErrorState(strUsernameTaken, txtUsername)

                    ' Reset the variables
                    sqlStatement = Nothing
                    sqlResults.Close()

                    ' Exit the sub
                    Return
                End If
            Loop

            ' Reset the variables
            sqlStatement = Nothing
            sqlResults.Close()
        End If

        ' If the password check box is checked then check the passwords entered
        If chkPassword.Checked = True Then
            ' Get the hash codes of the text entered into the password text boxes
            strPassword = txtPassword.Text.GetHashCode
            strConfirmPassword = txtConfirm.Text.GetHashCode

            ' Compare the passwords hash codes
            If strPassword <> strConfirmPassword Then
                ' Set the error state
                SetErrorState(strPasswordMatch, txtPassword)
                SetErrorState(strPasswordMatch, txtConfirm)

                ' Exit the sub
                Return
            End If
        End If
    End Sub

    ' Event to show the error label and highlight the erroneus text box
    Private Sub SetErrorState(ByVal strErrorLabel As String, ByVal txtErrorTextBox As TextBox)
        ' Set the text of the error label
        lblError.Text = strErrorLabel

        ' Position the label
        LabelCentreX(lblError, Me)

        ' Set the back colour of the text box to misty rose
        txtErrorTextBox.BackColor = Color.MistyRose

        ' Show the label
        lblError.Visible = True
    End Sub

    ' Event run when the check state is change
    Private Sub chkPassword_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPassword.CheckedChanged
        Select Case chkPassword.Checked
            Case True
                ' Enable the password labels and text boxes
                lblPassword.Enabled = True
                lblConfirm.Enabled = True
                txtPassword.Enabled = True
                txtConfirm.Enabled = True
            Case False
                ' Disable the password labels and text boxes
                lblPassword.Enabled = False
                lblConfirm.Enabled = False
                txtPassword.Enabled = False
                txtConfirm.Enabled = False
        End Select
    End Sub
End Class
