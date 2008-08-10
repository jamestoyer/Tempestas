Public Class frmMainScreen
    ' Counter variable
    Dim intClickDuration As Integer

    ' Varable to hold the difference between the button panel widths
    Dim intPanelWidthDifference As Integer

    ' Integer array to hold the IDs of the selected timetable's years
    Dim intYearID(0) As Integer

    ' Integer array to hold the IDs of the selected year's terms
    Dim intTermID(0) As Integer

    Private Sub frmMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Run the no database attached event
        NoDatabaseAttached()

        ' Check the status of the connection to the database
        If boolConnectionStatus <> True Then
            ' Load the unable to connect form as a dialog
            frmUnableToConnect.ShowDialog()

            ' Check to see if a database is attached
            If boolConnectionStatus = False Then
                ' Leave the loading routine
                Return
            End If
        End If

        ' Check to see if this is the first time the program has started
        If My.Settings.FirstTimeStartup = True Then
            ' Load the create new user form
            frmNewUser.ShowDialog()

            ' Set the first time start setting to false
            My.Settings.FirstTimeStartup = False
        End If

        ' Run the database attached event
        DatabaseAttached()
    End Sub

    'Private Sub cboDVDay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDVDay.SelectedIndexChanged
    '    ' Database Variables
    '    Dim sqlResults As SqlClient.SqlDataReader
    '    Dim sqlStatement As SqlClient.SqlCommand

    '    ' Create a new control
    '    Dim devNew As New DayEventView
    '    Dim strName As String

    '    ' Create array variables to store the controls name
    '    Dim intEntry As Integer = 1

    '    ' Position variables for the control
    '    Dim intY As Integer = 12

    '    ' Week and day variables
    '    Dim intWeek As Integer
    '    Dim intDay As Integer
    '    Dim intWeekIndex As Integer

    '    ' Get the selected index of the day combo box
    '    intDay = cboDVDay.SelectedIndex

    '    ' Get the selected week button
    '    intWeekIndex = CheckSelectedWeekButton()

    '    ' Determin what to do with respect to the selected index
    '    If intDay = 0 Then
    '        ' Clear the information from the form
    '        DeleteCustomControl(devControlNames)
    '        Return
    '    ElseIf intWeekIndex = 0 Then
    '        ' Temp error message
    '        MessageBox.Show("Please select a week first")

    '        ' Set the selected index back to 0
    '        cboDVDay.SelectedIndex = 0
    '        Return
    '    Else
    '        ' Clear all information from form
    '        DeleteCustomControl(devControlNames)

    '        ' Find out the week and convert it into an integer
    '        intWeek = CInt(wkbControls(intWeekIndex).ButtonText)


    '        ' Construct the sql statement
    '        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Events WHERE Week = '" & intWeek & "' AND DayID = '" & intDay & "' ORDER BY Time", ctnTimetable)
    '        sqlResults = sqlStatement.ExecuteReader

    '        ' Populate the text box
    '        Do While sqlResults.Read

    '            ' Set the name of the new control
    '            strName = "dev" & sqlResults!Time

    '            ' Create the new control
    '            devNew.Location = New System.Drawing.Point(12, intY)
    '            devNew.Name = strName
    '            devNew.Time = CreateEventTime(sqlResults!Time, sqlResults!Duration)
    '            devNew.Contact = sqlResults!Type
    '            devNew.ModuleName = sqlResults!code & ", " & sqlResults!Name

    '            ' Check to see if there is a name with the initials
    '            If sqlResults!Surname <> Nothing Then
    '                devNew.Staff = sqlResults!Initials & " - " & sqlResults!Surname
    '            Else
    '                devNew.Staff = sqlResults!Initials
    '            End If

    '            devNew.Room = sqlResults!Number
    '            devNew.Notes = sqlResults!Notes
    '            devNew.Size = New System.Drawing.Size(200, 102)
    '            devNew.TabIndex = intEntry

    '            ' Add the new control to the panel
    '            pnlDayEvent.Controls.Add(devNew)

    '            ' Set the control to an array
    '            devControlNames(intEntry) = devNew

    '            ' Increase the y position of the control the size of the previous control
    '            intY = intY + devControlNames(intEntry).Height

    '            ' Set the entry number to increase by 1
    '            intEntry = intEntry + 1

    '            ' Reset the new control variable
    '            devNew = New DayEventView
    '        Loop

    '        ' Reset the variables
    '        sqlStatement = Nothing
    '        sqlResults.Close()
    '    End If
    'End Sub

    Private Sub frmMainScreen_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Resize the week button panels
        WeekButtonPanelResize()
    End Sub

#Region "Tool Strip Events"

#Region "File Tool Strip Events"

    Private Sub tsiLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiLogin.Click
        ' Load the login form
        frmLogin.ShowDialog()

        ' Check to see if someone is logged in
        If frmLogin.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Call the user logged in event
            UserLoggedIn()
        End If
    End Sub

    Private Sub tsiLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiLogout.Click, tsbLogout.Click
        ' Run the user logged out event
        UserLoggedOut()
    End Sub

    Private Sub tsiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiExit.Click
        ' Close the form
        Me.Close()
    End Sub

#End Region

#Region "Edit Tool Strip Events"

#Region "Add Tool Strip Events"

    Private Sub tsiAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddContact.Click, AddContactToolStripMenuItem.Click
        ' Show the add contact form
        frmNewContact.ShowDialog()
    End Sub

    Private Sub tsiAddModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddModule.Click, AddModuleToolStripMenuItem.Click
        ' Show the add module form
        frmNewModule.ShowDialog()
    End Sub

    Private Sub tsiAddRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddRooms.Click, AddRoomToolStripMenuItem.Click
        ' Show the add rooms form
        frmNewRoom.ShowDialog()
    End Sub

    Private Sub tsiAddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddStaff.Click, AddStaffToolStripMenuItem.Click
        ' Show the add staff form
        frmNewStaff.ShowDialog()
    End Sub

    Private Sub tsiAddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddEvent.Click, tsbAdd.ButtonClick, AddEntryToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmNewEvent.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmNewEvent.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub
#End Region

#Region "Modify Tool Strip Events"

    Private Sub tsiModifyContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyContact.Click, UpdateContactToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmSelectContact.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmSelectContact.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub

    Private Sub tsiModifyModules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyModules.Click, UpdateModuleToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmSelectModule.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmSelectModule.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub

    Private Sub tsiModifyRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyRooms.Click, UpdateRoomToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmSelectRoom.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmSelectRoom.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub

    Private Sub tsiModifyStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyStaff.Click, UpdateStaffToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmSelectStaff.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmSelectStaff.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub

    Private Sub tsiModifyEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyEvent.Click, tsbUpdate.ButtonClick, UpdateEventToolStripMenuItem.Click
        ' Variable to get the dialog result of the form
        Dim diaDialogResult As DialogResult

        ' Open the select contact form as a dialog
        frmSelectEvent.ShowDialog()

        ' Get the dialog result
        diaDialogResult = frmSelectEvent.DialogResult

        ' Show the week if one is selected
        ShowSelectedWeekAfterUpdate(diaDialogResult)
    End Sub
#End Region

#End Region

#Region "Tools Tool Strip Events"

#Region "Timetable Tool Strip Events"

    Private Sub tsiSelectTimetable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiSelectTimetable.Click, tsbSelectTimetable.Click
        ' Show the select timetable form
        frmSelectTimetable.ShowDialog()

        ' Check the dialog result and act accordingly
        If frmSelectTimetable.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Run the timetable selected event
            TimetableSelected()
        End If
    End Sub

    Private Sub tsiNewTimetable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiNewTimetable.Click, tsbNewTimetable.Click
        ' Show the select timetable form
        frmNewTimetableSystem.ShowDialog()

        ' Check the dialog result and act accordingly
        If frmNewTimetableSystem.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Run the timetable selected event
            TimetableSelected()
        End If
    End Sub

    Private Sub tsiUserDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsiUserDetails.Click
        ' Show the modify user form
        frmUpdateUser.ShowDialog()

    End Sub
#End Region

#End Region

#Region "Help Tool Strip Events"

    Private Sub tsiHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiHelp.Click, tsbHelp.Click
        ' Show the help file
        Windows.Forms.Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Help\Tempestas Help.chm")
    End Sub

    Private Sub tsiSuggestions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiSuggestions.Click
        ' Open the comments from
        frmSuggestionsAndComments.ShowDialog()
    End Sub
#End Region

#End Region

#Region "Week Button Events"

    ' Event for resizing the week button panel after the screen has been resized
    Public Sub WeekButtonPanelResize()
        ' Width of a single week button
        Const intControlWidth As Integer = 40

        ' Variable to hold the week panel width
        Dim intWeekPanelWidth As Integer

        ' Default starting point of te week button panel
        Const intStartPoint As Integer = 26

        ' Position variables for the control
        Dim intTotalControlWidth As Integer
        Dim intX As Integer

        ' Variable to hold the number of week buttons
        Dim intNumberOfControls As Integer

        ' Find the width of the week button holder panel
        intWeekPanelWidth = pnlWeekButtonHolder.Width

        ' Find the number of week buttons
        intNumberOfControls = wkbControls.Length - 1

        ' Find out how wide all the buttons will be together
        intTotalControlWidth = intControlWidth * intNumberOfControls

        ' Check to see if the controls are bigger than the panel and calculate the starting position of the controls accordingly
        If intTotalControlWidth <= intWeekPanelWidth Then
            ' Hide the week scroll buttons
            btnWeekLeft.Visible = False
            btnWeekRight.Visible = False

            ' Find the starting point of the scroll panel so it is centre
            intX = (intWeekPanelWidth - intTotalControlWidth) / 2

            ' Set the starting position of the week scroll panel in the week button holder panel
            pnlWeekScroll.Location = New Point(intX, 0)

            ' Set the starting position of the week buttons panel to 0 in the scroll panel
            pnlWeekButtons.Location = New Point(0, 0)

            ' Resize the scroll panel and the week button panel
            pnlWeekScroll.Width = intTotalControlWidth
            pnlWeekButtons.Width = intTotalControlWidth
        Else
            ' Show the week scroll buttons
            btnWeekLeft.Visible = True
            btnWeekRight.Visible = True

            ' Set the starting point to the default starting point
            intX = intStartPoint

            ' Set the starting position of the week scroll panel in the week button holder panel
            pnlWeekScroll.Location = New Point(intX, 0)

            ' Set the starting position of the week buttons panel to 0 in the scroll panel
            pnlWeekButtons.Location = New Point(0, 0)

            ' Resize the scroll panel and the week button panel
            pnlWeekScroll.Width = intWeekPanelWidth - (intStartPoint * 2)
            pnlWeekButtons.Width = intTotalControlWidth
        End If
    End Sub

#Region "Week Scroll Buttons"
    Private Sub btnWeekLeft_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnWeekLeft.MouseDown
        ' Start the scroll week button left counter
        tmrScrollWeekButtonLeft.Start()
    End Sub

    Private Sub btnWeekLeft_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnWeekLeft.MouseUp
        ' Stop the scroll week button left timer
        tmrScrollWeekButtonLeft.Stop()
    End Sub

    Private Sub btnWeekRight_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnWeekRight.MouseDown
        ' Calculate the difference between the button panel widths
        intPanelWidthDifference = pnlWeekScroll.Width - pnlWeekButtons.Width

        ' Start the scroll week button right counter
        tmrScrollWeekButtonRight.Start()
    End Sub

    Private Sub btnWeekRight_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnWeekRight.MouseUp
        ' Stop the scroll week button right timer
        tmrScrollWeekButtonRight.Stop()
    End Sub

    Private Sub tmrScrollWeekButtonLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScrollWeekButtonLeft.Tick
        ' Variable to hold the new point of the panel
        Dim pntNewLocation As New Point(0, 0)

        ' Amount to move the button panel
        Const intPanelMovmentSize As Integer = 2

        If pnlWeekButtons.Location.X = 0 Then
            Return
        Else
            ' Get the current position
            pntNewLocation = pnlWeekButtons.Location

            ' Create a new location
            pntNewLocation.X += intPanelMovmentSize

            ' Check to see if this will move the panel too much
            If pntNewLocation.X > 0 Then
                ' Set the point to 0
                pntNewLocation.X = 0
            End If

            ' Set the new location of the panel
            pnlWeekButtons.Location = pntNewLocation
        End If
    End Sub

    Private Sub tmrScrollWeekButtonRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScrollWeekButtonRight.Tick
        ' Variable to hold the new point of the panel
        Dim pntNewLocation As New Point(0, 0)

        ' Size of one button
        Const intButtonWidth As Integer = 2

        If pnlWeekButtons.Location.X > 0 Then
            Return
        Else
            ' Get the current position
            pntNewLocation = pnlWeekButtons.Location

            ' Create a new location
            pntNewLocation.X -= intButtonWidth

            ' Check to see if this will move the panel too much
            If pntNewLocation.X < intPanelWidthDifference Then
                ' Set the point to 0
                pntNewLocation.X = intPanelWidthDifference
            End If

            ' Set the new location of the panel
            pnlWeekButtons.Location = pntNewLocation
        End If
    End Sub
#End Region

#End Region

    ' The event that clears the main form when a new database is attached or new user logged in
    Private Sub ClearMainScreen()
        ' Hide the term combo box
        cboTerm.Visible = False

        ' Hide the year combo box
        cboYear.Visible = False

        ' Clear the main screen of the week view
        ClearWeekView()

        ' Delete the week buttons
        DeleteWeekButtons()
    End Sub

    ' The event that clears the week view
    Public Sub ClearWeekView()
        ' Clear the time bar
        If wktControl IsNot Nothing Then
            wktControl.Dispose()
        End If

        ' Clear the grid
        UpdateCustomControlArray(wkvControls)

        ' Resize the entry array to 0
        Array.Resize(intWeekViewEntrys, 1)
    End Sub

    ' The event that has the states of objects on the form when no database is selected
    Public Sub NoDatabaseAttached()
        ' Disable the login and logout menus and buttons
        tsiLogin.Enabled = False
        tsiLogout.Enabled = False
        tsbLogout.Enabled = False

        ' Disable the print button and menu 
        tsiPrint.Enabled = False
        tsbPrint.Enabled = False

        ' Disable the edit menu and buttons
        tsiEdit.Enabled = False
        tsbAdd.Enabled = False
        tsbUpdate.Enabled = False

        ' Disable the timetable options and buttons
        tsiNewTimetable.Enabled = False
        tsiModifyTimetable.Enabled = False
        tsiSelectTimetable.Enabled = False
        tsbNewTimetable.Enabled = False
        tsbSelectTimetable.Enabled = False

        ' Disable the user options 
        tsiUserDetails.Enabled = False

        ' Clear the screen
        ClearMainScreen()

    End Sub

    ' The event that has the starts of object when a user logs out
    Private Sub UserLoggedOut()
        ' Enable the login menu and disable the logout menu and button
        tsiLogin.Enabled = True
        tsiLogout.Enabled = False
        tsbLogout.Enabled = False

        ' Disable the print button and menu 
        tsiPrint.Enabled = False
        tsbPrint.Enabled = False

        ' Disable the edit menu and buttons
        tsiEdit.Enabled = False
        tsbAdd.Enabled = False
        tsbUpdate.Enabled = False

        ' Disable the timetable options and buttons
        tsiNewTimetable.Enabled = False
        tsiModifyTimetable.Enabled = False
        tsiSelectTimetable.Enabled = False
        tsbNewTimetable.Enabled = False
        tsbSelectTimetable.Enabled = False

        ' Disable the user options 
        tsiUserDetails.Enabled = False

        ' Clear the main screen
        ClearMainScreen()
    End Sub

    ' The event that is run when a new database is loaded
    Public Sub DatabaseAttached()
        ' Call the user logged out event
        UserLoggedOut()

        ' Load the login form
        frmLogin.ShowDialog()

        ' Check to see if someone is logged in
        If frmLogin.DialogResult = Windows.Forms.DialogResult.Cancel Then Return

        ' Call the user logged in event
        UserLoggedIn()

    End Sub

    ' The event that is run when a new user is logged in
    Public Sub UserLoggedIn()
        ' Sql variables
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Integer to hold the number of timetables associated with a user
        Dim intNumberOfTimetables As Integer

        ' Disable the login menu and enable the logout menu and button
        tsiLogin.Enabled = False
        tsiLogout.Enabled = True
        tsbLogout.Enabled = True

        ' Disable the print button and menu 
        tsiPrint.Enabled = False
        tsbPrint.Enabled = False

        ' Disable the edit menu and buttons
        tsiEdit.Enabled = False
        tsbAdd.Enabled = False
        tsbUpdate.Enabled = False

        ' Disable the timetable options and buttons
        tsiNewTimetable.Enabled = False
        tsiModifyTimetable.Enabled = False
        tsiSelectTimetable.Enabled = False
        tsbNewTimetable.Enabled = False
        tsbSelectTimetable.Enabled = False

        ' Enable the user options 
        tsiUserDetails.Enabled = True

        ' Clear the main screen
        ClearMainScreen()

        ' Reset the timetable array
        Array.Clear(intTimetable, 0, intTimetable.Length)

        ' Construct sql statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Timetable", ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader()

        Do While sqlResults.Read
            If sqlResults!UserID = strUserInfo(intUserInfo.ID) Then
                ' Get the number of timetables associated with the user
                intNumberOfTimetables += 1

                ' Get the ID of the last timetable read
                intTimetable(intEnumTimetable.TimetableID) = sqlResults!TimetableID
                intTimetable(intEnumTimetable.System) = sqlResults!System
            End If
        Loop

        ' Reset the sql variables
        sqlResults.Dispose()
        sqlStatement = Nothing

        ' Check to see if user has a timetable associated with them and if so how many
        If intNumberOfTimetables < 1 Then
            ' Load the form to start creating the timetable
            frmNewTimetableSystem.ShowDialog()

            ' Check to see if a timetable is created
            If frmNewTimetableSystem.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' Enable the new timetable options and buttons and disable the others
                tsiNewTimetable.Enabled = True
                tsiModifyTimetable.Enabled = False
                tsiSelectTimetable.Enabled = False
                tsbNewTimetable.Enabled = True
                tsbSelectTimetable.Enabled = False

                ' Exit the sub
                Return
            End If
        ElseIf intNumberOfTimetables > 1 Then
            ' Load the select timetable form
            frmSelectTimetable.ShowDialog()

            ' Check to see if a timetable has been selected
            If frmSelectTimetable.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' Enable the new and select timetable options and buttons only
                tsiNewTimetable.Enabled = True
                tsiModifyTimetable.Enabled = False
                tsiSelectTimetable.Enabled = True
                tsbNewTimetable.Enabled = True
                tsbSelectTimetable.Enabled = True

                ' Exit the sub
                Return
            End If

        End If

        ' Call the timetable selected event
        TimetableSelected()
    End Sub

    ' The event that is run when a timetable is selected
    Public Sub TimetableSelected()
        ' Disable the login menue and enable the logout menu and button
        tsiLogin.Enabled = False
        tsiLogout.Enabled = True
        tsbLogout.Enabled = True

        ' Enable the print button and menu 
        tsiPrint.Enabled = True
        tsbPrint.Enabled = True

        ' Enable the edit menu and buttons
        tsiEdit.Enabled = True
        tsbAdd.Enabled = True
        tsbUpdate.Enabled = True

        ' Enable the timetable options and buttons
        tsiNewTimetable.Enabled = True
        tsiModifyTimetable.Enabled = True
        tsiSelectTimetable.Enabled = True
        tsbNewTimetable.Enabled = True
        tsbSelectTimetable.Enabled = True

        ' Enable the user options 
        tsiUserDetails.Enabled = True

        ' Clear the main screen
        ClearMainScreen()

        ' Populate the year combo box
        ComboTwoFieldsWithArray(cboYear, intYearID, "Year", "YearNumber", "YearID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "YearNumber", "YearName")

        ' Show the year combo box
        cboYear.Visible = True
    End Sub

    ' The event that is called when a new year is selected from the combo box
    Private Sub cboYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        ' Determin the selected index
        Select Case cboYear.SelectedIndex
            Case 0
                ' Hide the term combo box
                cboTerm.Visible = False

                ' Delete the week buttons
                DeleteWeekButtons()

                ' Create the standard grid
                CreateWeekView(1, 5, "0900", "1800")

            Case Else
                ' Set the selected year number to the timetable array
                intTimetable(intEnumTimetable.YearID) = intYearID(cboYear.SelectedIndex)

                ' Determin which system the timetable is using
                If intTimetable(intEnumTimetable.System) <> intTimetableSystem.WeekSystem Then
                    ' Populate the term combo box
                    ComboOneFieldWithArray(cboTerm, intTermID, "Term", "Number", "TermID", "YearID", intTimetable(intEnumTimetable.YearID), "Number")

                    ' Show the term combo box
                    cboTerm.Visible = True
                Else
                    ' Sql variables
                    Dim sqlStatement As SqlClient.SqlCommand
                    Dim sqlResults As SqlClient.SqlDataReader

                    ' Create a statement to get the id of the term
                    sqlStatement = New SqlClient.SqlCommand("SELECT TermID FROM Term WHERE YearID = " & intTimetable(intEnumTimetable.YearID), ctnTimetable)

                    ' Execute the statement adn read from the database
                    sqlResults = sqlStatement.ExecuteReader
                    sqlResults.Read()

                    ' Get the term ID
                    intTimetable(intEnumTimetable.TermID) = sqlResults!TermID

                    ' Reset the variables
                    sqlStatement = Nothing
                    sqlResults.Close()

                    ' Create the week buttons
                    UpdateWeekButtons()

                    ' Update the grid
                    UpdateWeekView()
                End If
        End Select
    End Sub

    ' The event that is called when a new term is selected from the combo box
    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        ' Determin the selected index
        Select Case cboTerm.SelectedIndex
            Case 0
                ' Delete the week buttons
                DeleteWeekButtons()

                ' Create the standard grid
                CreateWeekView(1, 5, "0900", "1800")
            Case Else
                ' Get the term ID
                intTimetable(intEnumTimetable.TermID) = intTermID(cboTerm.SelectedIndex)

                ' Create the week buttons
                UpdateWeekButtons()

                ' Update the grid
                UpdateWeekView()
        End Select
    End Sub
End Class
