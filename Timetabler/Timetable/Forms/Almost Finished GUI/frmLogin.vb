Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Clear the login screen
        txtUsername.Text = Nothing
        txtPassword.Text = Nothing

        ' Reset the back colours of the text boxes
        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White

        ' Centre the info label
        LabelCentreX(lblInfo, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the active control to the username box
        Me.ActiveControl = txtUsername

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ' Show the create new user dialog
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Variable to hold the hashed entered password
        Dim strHashedPassword As String

        ' Constants holding error messages
        Const strNoUsername As String = "Please enter a username"
        Const strWrongUsername As String = "Username entered is incorrect"
        Const strWrongPassword As String = "Password entered is incorrect"

        ' Disable the screen
        Me.Enabled = False

        ' Reset the backgrounds of the text boxes
        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White

        ' Check to see if a username has been entered
        If txtUsername.Text = "" Then
            ' Run error code and exit the event
            ErrorDetected(strNoUsername, txtUsername)
            Return
        End If

        ' Encrypt the entered password
        strHashedPassword = EncryptPassword(txtUsername.Text.Trim, txtPassword.Text.Trim)

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM UserName", ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Check to see if the username exists
            If txtUsername.Text.Trim = sqlResults!LoginID Then
                ' Compare the passwords
                If strHashedPassword = sqlResults!Password Then
                    ' Get the user info from the database
                    strUserInfo(intUserInfo.ID) = sqlResults!ID
                    strUserInfo(intUserInfo.LoginID) = sqlResults!LoginID
                    strUserInfo(intUserInfo.FirstName) = sqlResults!FirstName
                    strUserInfo(intUserInfo.Surname) = sqlResults!Surname

                    ' Set the dialog result to ok
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                    ' Reset the variables
                    sqlStatement = Nothing
                    sqlResults.Close()

                    ' Enable the screen 
                    Me.Enabled = True

                    ' Close the form
                    Me.Close()
                End If

                ' Reset the variables
                sqlStatement = Nothing
                sqlResults.Close()

                ' Run error code and exit the event
                ErrorDetected(strWrongPassword, txtPassword)
                Return
            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Run error code and exit the event
        ErrorDetected(strWrongUsername, txtUsername)
    End Sub

    ' Event that is called to when an error is detected
    Private Sub ErrorDetected(ByVal strErrorMessage As String, ByVal txtErrorTextBox As TextBox)

        ' Set the error label text
        lblError.Text = strErrorMessage

        ' Set the text box background to misty rose
        txtErrorTextBox.BackColor = Color.MistyRose

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Show the error label
        lblError.Visible = True

        ' Enable the screen 
        Me.Enabled = True
    End Sub
End Class
