Public Class frmUpdateRoom
    ' Variable for the selectedID of the record
    Dim intSelectedID As Integer


    Private Sub frmUpdateRoom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Run the default room startup events
        RoomStartUpEvents()

        ' Get the seletected ID from the Delete Event form
        intSelectedID = frmSelectRoom.intSelectedID

        ' Read the data from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Room WHERE RoomID = " & intSelectedID, ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Update the room number text box
            txtRoomNumber.Text = sqlResults!Number

            ' Update the department text box
            txtDepartment.Text = sqlResults!Department
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the the focus to the first combo box
        Me.ActiveControl = txtRoomNumber
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

        If lblError.Visible = True Then
            ' Enable the form and exit the event
            Me.Enabled = True
            Return
        End If

        ' Load the are you sure dialog
        frmAreYouSure.ShowDialog()

        ' Get the dialog result from it
        diaAreYouSure = frmAreYouSure.DialogResult

        ' If the result is cancel exit the event
        If diaAreYouSure = Windows.Forms.DialogResult.Cancel Then Return

        ' Construct the statement
        sqlStatement = New SqlClient.SqlCommand("UPDATE Room SET Number = '" & txtRoomNumber.Text & "', Department = '" & txtDepartment.Text & "' WHERE RoomID = " & intSelectedID, ctnTimetable)

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
