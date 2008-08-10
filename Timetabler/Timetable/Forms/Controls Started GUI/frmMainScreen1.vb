Public Class frmMainScreen1
    ' Counter variable
    Dim intClickDuration As Integer

    ' Varable to hold the difference between the button panel widths
    Dim intPanelWidthDifference As Integer

    Private Sub frmMainScreen_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If boolErrorShutDown = False Then
            ' Close the connection to the database
            CloseConnection()
        End If
    End Sub

    Private Sub frmMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If boolErrorShutDown = True Then
            ' Disable the edit menu
            tsiEdit.Enabled = False

        Else
            ' Load in the days to the Daily View combo box
            PopulateCBOOneFieldNoArray(cboDVDay, "Day", "DayID", "Day")

            ' Load the week buttons into the form
            UpdateWeekButtons()

            ' Load the week view layout
            UpdateWeekView()
        End If

    End Sub

    Private Sub cboDVDay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDVDay.SelectedIndexChanged
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a new control
        Dim devNew As New DayEventView
        Dim strName As String

        ' Create array variables to store the controls name
        Dim intEntry As Integer = 1

        ' Position variables for the control
        Dim intY As Integer = 12

        ' Week and day variables
        Dim intWeek As Integer
        Dim intDay As Integer
        Dim intWeekIndex As Integer

        ' Get the selected index of the day combo box
        intDay = cboDVDay.SelectedIndex

        ' Get the selected week button
        intWeekIndex = CheckSelectedWeekButton()

        ' Determin what to do with respect to the selected index
        If intDay = 0 Then
            ' Clear the information from the form
            DeleteCustomControl(devControlNames)
            Return
        ElseIf intWeekIndex = 0 Then
            ' Temp error message
            MessageBox.Show("Please select a week first")

            ' Set the selected index back to 0
            cboDVDay.SelectedIndex = 0
            Return
        Else
            ' Clear all information from form
            DeleteCustomControl(devControlNames)

            ' Find out the week and convert it into an integer
            intWeek = CInt(wkbControls(intWeekIndex).ButtonText)


            ' Construct the sql statement
            sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Events WHERE Week = '" & intWeek & "' AND DayID = '" & intDay & "' ORDER BY Time", ctnTimetable)
            sqlResults = sqlStatement.ExecuteReader

            ' Populate the text box
            Do While sqlResults.Read

                ' Set the name of the new control
                strName = "dev" & sqlResults!Time

                ' Create the new control
                devNew.Location = New System.Drawing.Point(12, intY)
                devNew.Name = strName
                devNew.Time = CreateEventTime(sqlResults!Time, sqlResults!Duration)
                devNew.Contact = sqlResults!Type
                devNew.ModuleName = sqlResults!ModuleCode & ", " & sqlResults!ModuleName

                ' Check to see if there is a name with the initials
                If sqlResults!Surname <> Nothing Then
                    devNew.Staff = sqlResults!Initials & " - " & sqlResults!Surname
                Else
                    devNew.Staff = sqlResults!Initials
                End If

                devNew.Room = sqlResults!Number
                devNew.Notes = sqlResults!Notes
                devNew.Size = New System.Drawing.Size(200, 102)
                devNew.TabIndex = intEntry

                ' Add the new control to the panel
                pnlDayEvent.Controls.Add(devNew)

                ' Set the control to an array
                devControlNames(intEntry) = devNew

                ' Increase the y position of the control the size of the previous control
                intY = intY + devControlNames(intEntry).Height

                ' Set the entry number to increase by 1
                intEntry = intEntry + 1

                ' Reset the new control variable
                devNew = New DayEventView
            Loop

            ' Reset the variables
            sqlStatement = Nothing
            sqlResults.Close()
        End If
    End Sub

    Private Sub frmMainScreen_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Resize the week button panels
        WeekButtonPanelResize()
    End Sub

    Public Sub WeekButtonClicked(ByVal strWeek As String)
        ' Variable for the result returned by the check selected week function
        Dim intEntry As Integer

        ' Control state constants
        Const intButtonUnselected As Integer = 2

        ' Set the array search variable
        Dim intArraySize As Integer

        ' Find the size of the zero based array and convert it to non-zero
        intArraySize = wkbControls.GetLongLength(0) - 1

        ' Check to see if another button is selected
        intEntry = CheckSelectedWeekButton()

        Select Case intEntry
            Case 1 To intArraySize
                ' Set the selected control to unselected
                wkbControls(intEntry).Selected = intButtonUnselected
                wkbControls(intEntry).Refresh()
        End Select

        ' Reset the selected index of the day to 0
        cboDVDay.SelectedIndex = 0

        ' Display all the events related to that week
        PopulateWeekView(strWeek)

        ' Clear any data on the form
        DeleteCustomControl(devControlNames)
    End Sub

#Region "Tool Strip Events"
    Private Sub tsiAddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddEntry.Click
        ' Clear any data on the form
        DeleteCustomControl(devControlNames)

        ' Update the week buttons
        UpdateWeekButtons()

        ' Show the add new entry form as a dialog
        frmAddNewEntry.ShowDialog()
    End Sub

    Private Sub tsiModifyEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiModifyEntry.Click
        ' Clear any data on the form
        DeleteCustomControl(devControlNames)

        ' Update the week buttons
        UpdateWeekButtons()

        ' Show the delete event form as a dialog
        frmDeleteEvent.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        ' Close the form
        Me.Close()
    End Sub

    Private Sub tsiOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiOptions.Click
        ' Load the options screen
        frmOptions.ShowDialog()
    End Sub

    Private Sub tsiSuggestions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiSuggestions.Click
        ' Open the comments from
        FrmSendComments.ShowDialog()

    End Sub

    Private Sub tsiAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddContact.Click
        ' Show the add contact form
        frmAddContact.ShowDialog()
    End Sub

    Private Sub tsiAddModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddModule.Click
        ' Show the add module form
        frmAddModule.ShowDialog()
    End Sub

    Private Sub tsiAddRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddRooms.Click
        ' Show the add rooms form
        frmAddRoom.ShowDialog()
    End Sub

    Private Sub tsiAddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAddStaff.Click
        ' Show the add staff form
        frmAddStaff.ShowDialog()
    End Sub

    Private Sub FindDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindDatabaseToolStripMenuItem.Click
        ' Open the find database form
        frmFindDatabase.ShowDialog()

        If frmFindDatabase.DialogResult = Windows.Forms.DialogResult.Abort Then
            ' Connect back to the old location
            OpenConnection()

        Else
            ' Enable the edit menu
            tsiEdit.Enabled = True

            ' Clear any data on the form
            DeleteCustomControl(devControlNames)

            ' Load the week buttons into the form
            UpdateWeekButtons()

            ' Load the week view layout
            UpdateWeekView()
        End If
    End Sub

    Private Sub tsiAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsiAbout.Click
        ' Open the about screen in dialog mode
        frmAbout.ShowDialog()

    End Sub

    Private Sub LoginScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginScreenToolStripMenuItem.Click
        ' Show the login screen
        frmLogin.ShowDialog()

    End Sub
#End Region

    Public Sub UpdateWeekButtons()
        ' Find week boundary variables
        Dim strTable As String = "TimetableEntry"
        Dim strOrderByID As String = "Week"
        Dim intStartWeek As Integer
        Dim intEndWeek As Integer

        ' Create a new week button
        Dim wkbNew As New WeekButton
        Dim strName As String
        Dim intWeek As Integer
        Dim pntLocation As New Point(0, 0)

        ' Create array variables to store the controls name
        Dim intEntry As Integer = 1

        ' Delete the old week buttons
        DeleteCustomControl(wkbControls)

        ' Find the start and end week of the timetable
        FindBounds(strTable, strOrderByID, intStartWeek, intEndWeek)

        ' Resize the week button array
        Array.Resize(wkbControls, intEndWeek + 1)

        ' Resize the week button panels
        WeekButtonPanelResize()

        ' Exit the event if the end week is 0
        If intEndWeek = 0 Then Return

        For intWeek = intStartWeek To intEndWeek
            ' Add the new week button to the panel on the main form
            pnlWeekButtons.Controls.Add(wkbNew)

            ' Set the name of the control
            strName = "wkbWeek" & intWeek
            wkbNew.Name = strName

            ' Set the other properties of the control
            wkbNew.ButtonText = CStr(intWeek)
            wkbNew.Location = pntLocation
            wkbNew.Size = New System.Drawing.Size(40, 40)
            wkbNew.TabIndex = 8

            ' Set the control to the array
            wkbControls(intEntry) = wkbNew

            ' Set the entry number to increase by 1
            intEntry = intEntry + 1

            ' Add the width of a control to location point
            pntLocation.X += 40

            ' Create a neww week button
            wkbNew = New WeekButton
        Next
    End Sub

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

End Class