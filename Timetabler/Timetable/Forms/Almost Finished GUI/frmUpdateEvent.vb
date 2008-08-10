Public Class frmUpdateEvent
    ' Variable for the Entry ID of the record
    Dim intSelectedEntryID As Integer

    ' Variabels for the year and term ID's of the record
    Dim intSelectedTermID As Integer
    Dim intSelectedYearID As Integer

    Private Sub frmUpdateEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Sql Command variable
        Dim sqlStatement As SqlClient.SqlCommand

        ' Sql reader variable
        Dim rdrResults As SqlClient.SqlDataReader

        ' Run the default contact startup events
        DefaultLoad()

        ' Get the seletected IDs from the Delete Event form
        intSelectedEntryID = frmSelectEvent.intSelectedID
        intSelectedTermID = frmSelectEvent.intTermID(0)
        intSelectedYearID = frmSelectEvent.intYearID(frmSelectEvent.cboYear.SelectedIndex)

        ' Set the year
        cboYear.SelectedIndex = Array.IndexOf(intYearID, intSelectedYearID)

        ' Check the system of the timetable
        If intTimetable(intEnumTimetable.System) <> intTimetableSystem.WeekSystem Then
            ' Set the term
            cboTerm.SelectedIndex = Array.IndexOf(intTermID, intSelectedTermID)
        End If

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Entry WHERE EntryID = " & intSelectedEntryID, ctnTimetable)

        ' Exeecute the reader
        rdrResults = sqlStatement.ExecuteReader

        ' Read the results
        Do While rdrResults.Read
            ' Variable for the time
            Dim strFinishTime As String

            ' Update the form
            cboContact.SelectedIndex = Array.IndexOf(intContactID, rdrResults!ContactID)
            cboModule.SelectedIndex = Array.IndexOf(intModuleID, rdrResults!ModuleID)
            cboStaff.SelectedIndex = Array.IndexOf(intStaffID, rdrResults!StaffID)
            cboRoom.SelectedIndex = Array.IndexOf(intRoomID, rdrResults!RoomID)
            cboDay.SelectedIndex = rdrResults!DayID
            chkOptional.Checked = rdrResults!Optional
            txtNotes.Text = rdrResults!Notes

            ' Set the start time
            dtpStartTime.Text = Microsoft.VisualBasic.Left(rdrResults!Time, 2) & ":" & Microsoft.VisualBasic.Right(rdrResults!Time, 2)

            ' Get the finish time
            strFinishTime = CheckTimes(CalculateTime(rdrResults!Time, rdrResults!Duration))

            ' Set the finish time
            dtpEndTime.Text = Microsoft.VisualBasic.Left(strFinishTime, 2) & ":" & Microsoft.VisualBasic.Right(strFinishTime, 2)
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        rdrResults.Close()

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand("SELECT Week FROM TermEntryWeek WHERE EntryID = " & intSelectedEntryID & " ORDER BY Week", ctnTimetable)

        ' Exeecute the reader
        rdrResults = sqlStatement.ExecuteReader

        ' Set the start week
        rdrResults.Read()
        cboWeekFrom.SelectedItem = rdrResults!Week

        ' Read the results
        Do While rdrResults.Read
            ' Set the end week
            cboWeekTo.SelectedItem = rdrResults!Week
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        rdrResults.Close()

        ' Set the the focus to the first combo box
        Me.ActiveControl = cboContact
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Create a variable to record the resulf of the dialog box
        Dim diaAreYouSure As DialogResult

        ' Database Variable
        Dim sqlStatement As SqlClient.SqlCommand

        ' String for the sql commant
        Dim strCommand As String

        ' String variable for holding the start time
        Dim strStartTime As String

        ' Integer to hold the duration of the event
        Dim intDuration As Integer

        ' Sql Reader
        Dim rdrResults As SqlClient.SqlDataReader

        ' Array and entry interger to store the term entry week id's
        Dim intTewID(0) As Integer
        Dim intIndex As Integer

        ' Load the are you sure dialog
        frmUpdateAllEntries.ShowDialog()

        ' Get the dialog result from it
        diaAreYouSure = frmUpdateAllEntries.DialogResult

        ' If the result is cancel exit the event
        If diaAreYouSure = Windows.Forms.DialogResult.Cancel Then Return

        ' Check for errors
        ErrorCheck()

        ' Check to see if the error label is visible
        If lblError.Visible = True Then Return ' Exit the sub

        ' Disable the form
        Me.Enabled = False

        ' Get the start time to a format complient with the database
        strStartTime = Microsoft.VisualBasic.Left(dtpStartTime.Text, 2) & Microsoft.VisualBasic.Right(dtpStartTime.Text, 2)

        ' Calculate the duration
        intDuration = TimeDifference(dtpStartTime.Text, dtpEndTime.Text)

        ' Create the statement to add to the database
        strCommand = "UPDATE Entry SET"
        strCommand += " ModuleID = '" & intModuleID(cboModule.SelectedIndex)
        strCommand += "', ContactID = '" & intContactID(cboContact.SelectedIndex)
        strCommand += "', DayID = '" & cboDay.SelectedIndex
        strCommand += "', Time = '" & strStartTime
        strCommand += "', Duration = '" & intDuration
        strCommand += "', StaffID = '" & intStaffID(cboStaff.SelectedIndex)
        strCommand += "', RoomID = '" & intRoomID(cboRoom.SelectedIndex)
        strCommand += "', Notes = '" & txtNotes.Text
        strCommand += "', Optional = '" & chkOptional.Checked
        strCommand += "', TimetableID = '" & intTimetable(intEnumTimetable.TimetableID)
        strCommand += "' WHERE EntryID = " & intSelectedEntryID

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

        ' Execute the update
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing

        ' Create the string to search for the TermEntryWeekID values for the Entry
        strCommand = "SELECT * FROM TermEntryWeek WHERE EntryID = " & intSelectedEntryID & " ORDER BY TermEntryWeekID"

        ' Create a new sql command
        sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

        ' Execute the statement 
        rdrResults = sqlStatement.ExecuteReader

        Do While rdrResults.Read
            ' Add one to the index integer
            intIndex += 1

            ' Resize the array by one
            Array.Resize(intTewID, intTewID.Length + 1)

            ' Set the result to the array
            intTewID(intIndex) = rdrResults!TermEntryWeekID
        Loop

        ' Reset the statement and close the reader
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

        ' Reset the index integer
        intIndex = 0

        ' Add to the termentryweek table
        For intWeek = intFrom To intTo
            ' Add one to the index integer
            intIndex += 1

            ' Create the statement to add to the database
            strCommand = "UPDATE TermEntryWeek SET "
            strCommand += "Week = '" & intWeek
            strCommand += "' WHERE TermEntryWeekID = " & intTewID(intIndex)

            ' Create a new sql command
            sqlStatement = New SqlClient.SqlCommand(strCommand, ctnTimetable)

            ' Execute the insert
            sqlStatement.ExecuteNonQuery()

            ' Reset the statement
            sqlStatement = Nothing
        Next

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Close the add form
        Me.Close()
    End Sub
End Class
