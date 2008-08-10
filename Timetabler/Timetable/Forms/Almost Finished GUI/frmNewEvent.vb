Public Class frmNewEvent

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Sql Command variable
        Dim sqlStatement As SqlClient.SqlCommand

        ' String for the sql commant
        Dim strCommand As String

        ' Sql reader variable
        Dim rdrResults As SqlClient.SqlDataReader

        ' String variable for holding the start time
        Dim strStartTime As String

        ' Integer to hold the duration of the event
        Dim intDuration As Integer

        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        ' Check to see if the error label is visible
        If lblError.Visible = True Then
            ' Enable the form
            Me.Enabled = True

            ' Exit the sub
            Return
        End If

        ' Get the start time to a format complient with the database
        strStartTime = Microsoft.VisualBasic.Left(dtpStartTime.Text, 2) & Microsoft.VisualBasic.Right(dtpStartTime.Text, 2)

        ' Calculate the duration
        intDuration = TimeDifference(dtpStartTime.Text, dtpEndTime.Text)

        ' Create the statement to add to the database
        strCommand = "INSERT INTO Entry"
        strCommand += "(ModuleID, ContactID, DayID, Time, Duration, StaffID, RoomID, Notes, Optional, TimetableID)"
        strCommand += " VALUES "
        strCommand += "('" & intModuleID(cboModule.SelectedIndex)
        strCommand += "', '" & intContactID(cboContact.SelectedIndex)
        strCommand += "', '" & cboDay.SelectedIndex
        strCommand += "', '" & strStartTime
        strCommand += "', '" & intDuration
        strCommand += "', '" & intStaffID(cboStaff.SelectedIndex)
        strCommand += "', '" & intRoomID(cboRoom.SelectedIndex)
        strCommand += "', '" & txtNotes.Text
        strCommand += "', '" & chkOptional.Checked
        strCommand += "', '" & intTimetable(intEnumTimetable.TimetableID)
        strCommand += "')"

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

        ' Execute the insert
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing

        ' Get the id of the recently entered entry
        strCommand = "SELECT EntryID FROM Entry "
        strCommand += "WHERE"
        strCommand += " ModuleID = " & intModuleID(cboModule.SelectedIndex)
        strCommand += " AND ContactID = " & intContactID(cboContact.SelectedIndex)
        strCommand += " AND DayID = " & cboDay.SelectedIndex
        strCommand += " AND Time = '" & strStartTime
        strCommand += "' AND Duration = '" & intDuration
        strCommand += "' AND StaffID = " & intStaffID(cboStaff.SelectedIndex)
        strCommand += " AND RoomID = " & intRoomID(cboRoom.SelectedIndex)
        strCommand += " AND Notes = '" & txtNotes.Text
        strCommand += "' AND Optional = '" & chkOptional.Checked
        strCommand += "' AND TimetableID = " & intTimetable(intEnumTimetable.TimetableID)

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

        ' Execute the reader
        rdrResults = sqlStatement.ExecuteReader

        ' Variable to hold the id of the new event
        Dim intEventID As Integer

        ' Read from the database
        Do While rdrResults.Read
            intEventID = rdrResults!EntryID
        Loop

        ' Reset the statement and reader
        sqlStatement = Nothing
        rdrResults.Close()

        ' Variables for adding to the termentryweek table
        Dim intFrom As Integer
        Dim intTo As Integer
        Dim intWeek As Integer

        ' Set the week from text box to a variable
        intFrom = CInt(cboWeekFrom.SelectedItem)

        If cboWeekTo.SelectedIndex = 0 Then
            ' Make the week from equal the week to
            intTo = intFrom
        Else
            ' Send the variable to the value
            intTo = CInt(cboWeekTo.SelectedItem)
        End If

        ' Add to the termentryweek table
        For intWeek = intFrom To intTo
            ' Create the statement to add to the database
            strCommand = "INSERT INTO TermEntryWeek"
            strCommand += "(TermID, EntryID, Week)"
            strCommand += " VALUES "
            strCommand += "('" & intTermID(0)
            strCommand += "', '" & intEventID
            strCommand += "', '" & intWeek
            strCommand += "')"

            ' Create a new sql command
            sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

            ' Execute the insert
            sqlStatement.ExecuteNonQuery()

            ' Reset the statement
            sqlStatement = Nothing
        Next

        ' Re enable the form
        Me.Enabled = True

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Close the form
        Me.Close()
    End Sub

    Private Sub frmNewEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default load event
        DefaultLoad()
    End Sub
End Class
