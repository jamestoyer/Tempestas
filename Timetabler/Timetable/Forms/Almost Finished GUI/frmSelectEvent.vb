Public Class frmSelectEvent
    ' Array to store the year ID 
    Public intYearID() As Integer

    ' Array to store the term ID
    Public intTermID(0) As Integer

    Private Sub frmSelectEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Update the error label
        UpdateErrorLabel("Please select an event")

        ' Populate the Year combo box
        ComboTwoFieldsWithArray(cboYear, intYearID, "Year", "YearNumber", "YearID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "YearNumber", "YearName")

        ' Populate the item list
        PopulateItemsList()
    End Sub

    ' Event for populating the items list
    Public Sub PopulateItemsList()
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' String to create the sql command
        Dim strCommandString As String

        ' Declare the item index number
        Dim intIndex As Integer = 0

        ' String to construct the list item string
        Dim strItem As String

        ' Clear the list box
        lstEvents.Items.Clear()

        ' Resize the array to be 0
        Array.Resize(intEntryID, 0)

        ' Clear the array
        Array.Clear(intEntryID, 0, 0)

        ' Construct the command string
        strCommandString = "SELECT TermEntryWeek.TermEntryWeekID, TermEntryWeek.TermID, TermEntryWeek.Week, Entry.EntryID, Entry.Time, Module.Code, Module.Name, Contact.Type, Day.DayID, Day.Day "
        strCommandString += "FROM (TermEntryWeek "
        strCommandString += "INNER JOIN Entry ON TermEntryWeek.EntryID = Entry.EntryID) "
        strCommandString += "INNER JOIN Module ON Entry.ModuleID = Module.ModuleID "
        strCommandString += "INNER JOIN Contact ON Entry.ContactID = Contact.ContactID "
        strCommandString += "INNER JOIN Day ON Entry.DayID = Day.DayID "
        strCommandString += "WHERE TermEntryWeek.TermID = " & intTermID(0)
        strCommandString += " ORDER BY TermEntryWeek.Week, Day.DayID, Entry.Time, Contact.Type"

        ' Create the new sql command
        sqlStatement = New SqlClient.SqlCommand(strCommandString, ctnTimetable)

        ' Execute the command
        sqlResults = sqlStatement.ExecuteReader

        ' Read the results
        Do While sqlResults.Read
            ' Increase the size of the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the EntryID to the array
            intEntryID(intIndex) = sqlResults!EntryID

            ' Create the list box string
            strItem = "Week " & sqlResults!Week & " - "
            strItem += sqlResults!Day & " " & sqlResults!Time & " - "
            strItem += sqlResults!Type & " for module " & sqlResults!Code

            ' Add the data to the list box
            lstEvents.Items.Add(strItem)

            ' Increase the index by one
            intIndex = intIndex + 1
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    ' The event that is called when the selected index of the combo box is clicked
    Private Sub cboYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        ' Determin the selected index
        Select Case cboYear.SelectedIndex
            Case 0
                ' Hide the term combo box and label
                lblTerm.Visible = False
                cboTerm.Visible = False

                ' Set the term ID to 0
                intTermID(0) = 0
            Case Else
                ' Determin which system the timetable is using
                If intTimetable(intEnumTimetable.System) <> intTimetableSystem.WeekSystem Then
                    ' Populate the term combo box
                    ComboOneFieldWithArray(cboTerm, intTermID, "Term", "Number", "TermID", "YearID", intYearID(cboYear.SelectedIndex), "Number")

                    ' Show the term combo box and label
                    lblTerm.Visible = True
                    cboTerm.Visible = True
                Else
                    ' Sql variables
                    Dim sqlStatement As SqlClient.SqlCommand
                    Dim sqlResults As SqlClient.SqlDataReader

                    ' Create a statement to get the id of the term
                    sqlStatement = New SqlClient.SqlCommand("SELECT TermID FROM Term WHERE YearID = " & intYearID(cboYear.SelectedIndex), ctnTimetable)

                    ' Execute the statement adn read from the database
                    sqlResults = sqlStatement.ExecuteReader
                    sqlResults.Read()

                    ' Get the term ID
                    intTermID(0) = sqlResults!TermID

                    ' Reset the variables
                    sqlStatement = Nothing
                    sqlResults.Close()

                    ' Populate the list item box
                    PopulateItemsList()
                End If
        End Select
    End Sub

    ' The event that is called when a new term is selected from the combo box
    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        ' Determin the selected index
        Select Case cboTerm.SelectedIndex
            Case 0
                ' Set the term ID to 0
                intTermID(0) = 0
            Case Else
                ' Get the term ID
                intTermID(0) = intTermID(cboTerm.SelectedIndex)

                ' Populate the list items
                PopulateItemsList()
        End Select
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        ' Call the modify button event
        ModifyButtonClicked(frmUpdateEvent)

        ' Repopulate the items list
        PopulateItemsList()
    End Sub
End Class
