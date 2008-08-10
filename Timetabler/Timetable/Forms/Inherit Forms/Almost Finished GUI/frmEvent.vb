Public Class frmEvent
    ' Variable to hold the dialog result of any of the add forms if they return ok
    Public diaNew As DialogResult

    ' Arrays to hold the database entry ids of the combo boxes
    Public intModuleID() As Integer
    Public intContactID() As Integer
    Public intStaffID() As Integer
    Public intRoomID() As Integer
    Public intYearID() As Integer
    Public intTermID(0) As Integer

    ' Event run when the cancel button is clicked
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If diaNew = Windows.Forms.DialogResult.OK Then
            ' Set the dialog result to that of the new room form
            Me.DialogResult = diaNew
        Else
            ' Set the dialog result to cancel
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        ' Close the form
        Me.Close()
    End Sub

    ' Event holding the default loading procedures
    Public Sub DefaultLoad()
        ' Hide the term combo box and label
        lblTerm.Visible = False
        cboTerm.Visible = False

        ' Clear the notes textbox
        txtNotes.Text = Nothing

        ' Populate the Module combo box
        ComboTwoFieldsWithArray(cboModule, intModuleID, "Module", "Code", "ModuleID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Code", "Name")

        ' Populate the Contact combo box
        ComboOneFieldWithArray(cboContact, intContactID, "Contact", "Type", "ContactID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Type")

        ' Populate the Staff combo box
        ComboFourFieldsWithArray(cboStaff, intStaffID, "Staff", "Initials", "StaffID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Initials", "Salutation", "FirstName", "Surname")

        ' Populate the Room combo box
        ComboTwoFieldsWithArray(cboRoom, intRoomID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

        ' Populate the Year combo box
        ComboTwoFieldsWithArray(cboYear, intYearID, "Year", "YearNumber", "YearID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "YearNumber", "YearName")

        ' Populate the day combo box
        ComboOneField(cboDay, "Day", "DayID", "DayID", "Day")

        ' Resize the form to hide the week time and day
        HideWeekDayTime()

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the module combo box
        Me.ActiveControl = cboContact
    End Sub

    ' Event resizes the the form and moves the group panels when no term is selected
    Public Sub HideWeekDayTime()
        ' The screen size without the weeks day and time visible
        Const intNotVisibleFormSize As Integer = 423

        ' The size of the group panel with the weeks, days and time visible
        Const intNotVisiblePanelHeight As Integer = 48

        ' The position of the other information panel
        Const intNotVisiblePanelYLocation As Integer = 239

        ' Hide the week and day combo boxes
        cboWeekFrom.Visible = False
        cboWeekTo.Visible = False
        cboDay.Visible = False

        ' Resize the date and time panel
        grpTimeAndDate.Height = intNotVisiblePanelHeight

        ' Move the other information panel up
        grpOtherInformation.Location = New Point(grpOtherInformation.Location.X, intNotVisiblePanelYLocation)

        ' Resize the form
        Me.Height = intNotVisibleFormSize

        ' Refresh the form
        Me.Refresh()

        ' Hide the week and day combo boxes
        cboWeekFrom.Visible = False
        cboWeekTo.Visible = False
        cboDay.Visible = False
    End Sub

    ' Event resizes the the form and moves the group panels when a is term selected
    Public Sub ShowWeekDayTime(ByVal intSelectedTerm As Integer)
        ' The screen size without the weeks day and time visible
        Const intVisibleFormSize As Integer = 479

        ' The size of the group panel with the weeks, days and time visible
        Const intVisiblePanelHeight As Integer = 104

        ' The position of the other information panel
        Const intVisiblePanelYLocation As Integer = 295

        ' Populate the week boxes
        PopulateWeeksBox(intSelectedTerm, cboWeekFrom)
        PopulateWeeksBox(intSelectedTerm, cboWeekTo)

        ' Resize the date and time panel
        grpTimeAndDate.Height = intVisiblePanelHeight

        ' Move the other information panel up
        grpOtherInformation.Location = New Point(grpOtherInformation.Location.X, intVisiblePanelYLocation)

        ' Resize the form
        Me.Height = intVisibleFormSize

        ' Refresh the form
        Me.Refresh()

        ' Hide the week and day combo boxes
        cboWeekFrom.Visible = True
        cboWeekTo.Visible = True
        cboDay.Visible = True
    End Sub

    ' Event to populate the week boxes
    Public Sub PopulateWeeksBox(ByVal intIndex As Integer, ByRef cboSource As ComboBox)
        ' Variables for the start and end week of the term
        Dim intStartWeek As Integer
        Dim intFinishWeek As Integer

        ' Variable to hold the index number of the week
        Dim intWeekNumber As Integer

        ' Find the boundaries for the term
        FindWeekBoundaries(intTermID(intIndex), intStartWeek, intFinishWeek, intWeekNumber)

        ' Clear the source combo box
        cboSource.Items.Clear()

        ' Create a starting entry
        cboSource.Items.Add("")

        ' Populate the combo box
        For intWeekNumber = intStartWeek To intFinishWeek
            cboSource.Items.Add(intWeekNumber)
        Next

        ' Set the selected index to 0
        cboSource.SelectedIndex = 0
    End Sub

    ' Event to check the form has correct entries
    Public Sub ErrorCheck()
        ' Error label constants
        Const strContactError As String = "Please select a contact"
        Const strModuleError As String = "Please select a module"
        Const strStaffError As String = "Please select a member of staff"
        Const strRoomError As String = "Please select a room"
        Const strYearError As String = "Please select a year"
        Const strTermError As String = "Please select a term"
        Const strWeekError As String = "Please select a start week"
        Const strDayError As String = "Please select a day"
        Const strTimeError As String = "Please ensure the finish time is after the start time"

        ' Hide the error label
        lblError.Visible = False

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboContact, lblError, strContactError)
        If lblError.Visible = True Then Return

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboModule, lblError, strModuleError)
        If lblError.Visible = True Then Return

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboStaff, lblError, strStaffError)
        If lblError.Visible = True Then Return

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboRoom, lblError, strRoomError)
        If lblError.Visible = True Then Return

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboYear, lblError, strYearError)
        If lblError.Visible = True Then Return

        ' Check to see if a term is selected
        If intTermID(0) = 0 Then
            lblError.Text = strTermError

            ' Centre the error label
            LabelCentreX(lblError, Me)

            ' Show the error label
            lblError.Visible = True
        End If

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboWeekFrom, lblError, strWeekError)
        If lblError.Visible = True Then Return

        ' Check for errors with the combo box and return if there is
        ComboBoxError(Me, cboDay, lblError, strDayError)
        If lblError.Visible = True Then Return

        ' Check to make sure the finish time is after the start time
        If dtpStartTime.Value.Hour > dtpEndTime.Value.Hour Then
            ' Set the error label test
            lblError.Text = strTimeError

            ' Centre the error label
            LabelCentreX(lblError, Me)

            ' Show the error label
            lblError.Visible = True
        ElseIf dtpStartTime.Value.Hour = dtpEndTime.Value.Hour Then
            ' Check to see if the minutes of the start time are less then the end time
            If dtpStartTime.Value.Minute >= dtpEndTime.Value.Minute Then
                ' Set the error label test
                lblError.Text = strTimeError

                ' Centre the error label
                LabelCentreX(lblError, Me)

                ' Show the error label
                lblError.Visible = True
            End If
        End If
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

                ' Hide the week days and time from view
                HideWeekDayTime()
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

                    ' Show the weeks days and time
                    ShowWeekDayTime(0)
                End If
        End Select
    End Sub

    ' The event that is called when a new term is selected from the combo box
    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        ' Determin the selected index
        Select Case cboTerm.SelectedIndex
            Case Is < 1
                ' Hide the week days and time from view
                HideWeekDayTime()

                ' Set the term ID to 0
                intTermID(0) = 0
            Case Else
                ' Get the term ID
                intTermID(0) = intTermID(cboTerm.SelectedIndex)

                ' Show the weeks days and time
                ShowWeekDayTime(0)
        End Select
    End Sub

    ' The event to add a new contact
    Private Sub btnNewContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewContact.Click

        ' Open the new room form
        frmNewContact.ShowDialog()

        ' Get the dialog result of the form
        diaNew = frmNewContact.DialogResult

        If frmNewContact.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Get the dialog result of the form
            diaNew = frmNewContact.DialogResult

            ' Populate the Contact combo box
            ComboOneFieldWithArray(cboContact, intContactID, "Contact", "Type", "ContactID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Type")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = cboContact
        End If

    End Sub

    ' The event to add a new module
    Private Sub btnNewModule_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewModule.Click

        ' Open the new room form
        frmNewModule.ShowDialog()

        If frmNewModule.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Get the dialog result of the form
            diaNew = frmNewModule.DialogResult

            ' Populate the Module combo box
            ComboTwoFieldsWithArray(cboModule, intModuleID, "Module", "Code", "ModuleID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Code", "Name")

            ' Populate the Staff combo box
            ComboFourFieldsWithArray(cboStaff, intStaffID, "Staff", "Initials", "StaffID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Initials", "Salutation", "FirstName", "Surname")

            ' Populate the Room combo box
            ComboTwoFieldsWithArray(cboRoom, intRoomID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = cboModule
        End If
    End Sub

    ' The event to add a new staff member
    Private Sub btnNewStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewStaff.Click
        ' Open the new room form
        frmNewStaff.ShowDialog()

        If frmNewStaff.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Get the dialog result of the form
            diaNew = frmNewStaff.DialogResult

            ' Populate the Staff combo box
            ComboFourFieldsWithArray(cboStaff, intStaffID, "Staff", "Initials", "StaffID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Initials", "Salutation", "FirstName", "Surname")

            ' Populate the Room combo box
            ComboTwoFieldsWithArray(cboRoom, intRoomID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = cboStaff
        End If
    End Sub

    ' The event to add a new room
    Private Sub btnNewRoom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewRoom.Click
        ' Open the new room form
        frmNewRoom.ShowDialog()

        If frmNewRoom.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Get the dialog result of the form
            diaNew = frmNewRoom.DialogResult

            ' Populate the Room combo box
            ComboTwoFieldsWithArray(cboRoom, intRoomID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = cboRoom
        End If
    End Sub
End Class
