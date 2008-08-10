Public Class frmUpdateContact
    ' Variable for the selectedID of the record
    Dim intSelectedID As Integer

    Private Sub frmUpdateContact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Run the default contact startup events
        ContactStartUpEvents()

        ' Get the seletected ID from the Delete Event form
        intSelectedID = frmSelectContact.intSelectedID

        ' Read the data from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Contact WHERE ContactID = " & intSelectedID, ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Update the contact type text box
            txtContact.Text = sqlResults!Type

            ' Set the colour of the combo box
            cboColour.BackColor = ConvertTextToColour(sqlResults!Colour)
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the the focus to the first combo box
        Me.ActiveControl = txtContact
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Create a variable to record the resulf of the dialog box
        Dim diaAreYouSure As DialogResult

        ' Database Variable
        Dim sqlStatement As SqlClient.SqlCommand

        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        ' Check to see if the error label is visible
        If lblError.Visible = True Then
            ' Enable the form and exit the sub
            Me.Enabled = True
        End If

        ' Load the are you sure dialog
        frmAreYouSure.ShowDialog()

        ' Get the dialog result from it
        diaAreYouSure = frmAreYouSure.DialogResult

        ' If the result is cancel exit the event
        If diaAreYouSure = Windows.Forms.DialogResult.Cancel Then Return

        ' Variable to hold the string of the colour
        Dim strColour As String

        ' Convert the colour to a string
        strColour = ConvertColourToText(cboColour.BackColor)

        ' Construct the statement
        sqlStatement = New SqlClient.SqlCommand("UPDATE Contact SET Colour = '" & strColour & "', Type = '" & txtContact.Text & "' WHERE ContactID = " & intSelectedID, ctnTimetable)

        ' Execute the update
        sqlStatement.ExecuteNonQuery()

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the add form
        Me.Close()

    End Sub
End Class
