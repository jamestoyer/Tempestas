Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Populate the combo box
        PopulateCBOOneFieldArray(cboUserName, intUserName, "UserName", "LoginID", "ID", "LoginID")

        ' Hide the error label
        lblError.Visible = False

        ' Check to see if any users are already added
        If cboUserName.Items.Count < 2 Then
            ' Show the add user form as a dialog
            frmAddUser.ShowDialog()

            ' Check the dialog result
            If frmAddUser.DialogResult = Windows.Forms.DialogResult.OK Then
                ' Populate the combo box
                PopulateCBOOneFieldArray(cboUserName, intUserName, "UserName", "LoginID", "ID", "LoginID")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Show the add user form as a dialog
        frmAddUser.ShowDialog()

        ' Check the dialog result
        If frmAddUser.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Populate the combo box
            PopulateCBOOneFieldArray(cboUserName, intUserName, "UserName", "LoginID", "ID", "LoginID")
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Password variables
        Dim strDBPassword As String = ""
        Dim strInputPassword As String

        Const strUserNameError As String = "Please select a user"
        Const strPasswordError As String = "Password is incorrect"

        ' Check to see if a username has been selected
        If cboUserName.SelectedIndex = 0 Then
            ' Set the text of the error label
            lblError.Text = strUserNameError

            ' Set the position of the label
            ErrorLabelLocation()

            Return
        End If

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM UserName", ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Check to see if the username in the database matches that of the combo box
            If cboUserName.Text = sqlResults!LoginID Then
                ' Get the stored hashed password value
                strDBPassword = sqlResults!Password

                ' Set the user id
                strLoginID = sqlResults!FirstName

            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Hash the inputted password
        strInputPassword = Microsoft.VisualBasic.Left(EncryptPassword(cboUserName.Text, txtPassword.Text), 40)

        ' Compare the two password values
        If strDBPassword = strInputPassword Then
            ' Close the form
            Me.Close()
        Else
            ' Set the text of the error label
            lblError.Text = strPasswordError

            ' Set the position of the label
            ErrorLabelLocation()
        End If

    End Sub

    Private Sub ErrorLabelLocation()
        ' Label location variables
        Dim intFormWidth As Integer
        Dim intLabelWidth As Integer
        Dim intXLocation As Integer

        ' Hide the label
        lblError.Visible = False

        ' Get the width of the form
        intFormWidth = Me.Width

        ' Get the width of the label
        intLabelWidth = lblError.Width

        ' Set the x location of the label
        intXLocation = (intFormWidth - intLabelWidth) / 2
        lblError.Location = New Point(intXLocation, lblError.Location.Y)

        ' Show the label
        lblError.Visible = True

    End Sub
End Class