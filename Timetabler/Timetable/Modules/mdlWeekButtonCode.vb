Module mdlWeekButtonCode

    ' Event for creating and updating the week buttons
    Public Sub UpdateWeekButtons()
        ' Variables for storing the start and end weeks and the duration
        Dim intStartWeek As Integer
        Dim intEndWeek As Integer
        Dim intDuration As Integer

        ' Variable for storing the entry number
        Dim intEntry As Integer = 1

        ' Create a new week button
        Dim wkbNew As New WeekButton
        Dim strName As String
        Dim intWeek As Integer
        Dim pntLocation As New Point(0, 0)

        ' Delete the old week buttons
        UpdateCustomControlArray(wkbControls)

        ' Get the week start and end for the term
        FindWeekBoundaries(intTimetable(intEnumTimetable.TermID), intStartWeek, intEndWeek, intDuration)

        ' Resize the week button array
        Array.Resize(wkbControls, intDuration + 1)

        ' Resize the week button panels
        frmMainScreen.WeekButtonPanelResize()

        ' Exit the event if the duration is 0
        If intDuration = 0 Then Return

        For intWeek = intStartWeek To intEndWeek
            ' Add the new week button to the panel on the main form
            frmMainScreen.pnlWeekButtons.Controls.Add(wkbNew)

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

    ' The event that is called when a week button is clicked
    Public Sub WeekButtonClicked(ByVal strWeek As String)
        ' Set the array search variable
        Dim intArraySize As Integer

        ' Variable for the result returned by the check selected week function
        Dim intEntry As Integer

        ' Control state constants
        Const intButtonUnselected As Integer = 2

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

        ' Display all the events related to that week
        PopulateWeekView(strWeek)
    End Sub

    ' The function that is called to check if a button is clicked
    Function CheckSelectedWeekButton() As Integer
        ' Set the array search variables
        Dim intEntry As Integer = 1
        Dim intArraySize As Integer
        Dim intButtonSelected As Integer = 3

        ' Find the size of the zero based array and convert it to non-zero
        intArraySize = wkbControls.GetLongLength(0) - 1

        ' Check to see if another week is selected
        For intEntry = 1 To intArraySize
            If wkbControls(intEntry) Is Nothing Then
                CheckSelectedWeekButton = 0
                Return CheckSelectedWeekButton
            ElseIf wkbControls(intEntry).Selected = intButtonSelected Then
                CheckSelectedWeekButton = intEntry
                Return CheckSelectedWeekButton
            End If
        Next
    End Function

    ' Event to delete the week buttons from the main screen
    Public Sub DeleteWeekButtons()
        ' Delete the week buttons
        UpdateCustomControlArray(wkbControls)

        ' Resize the week button array
        Array.Resize(wkbControls, 0)

        ' Resize the week button panels
        frmMainScreen.WeekButtonPanelResize()
    End Sub

    ' The event that updates the main screen and selected week after a entry relating to an event has been modified
    Public Sub ShowSelectedWeekAfterUpdate(ByVal diaDialogResult As DialogResult)

        ' Variable to hold the week if one is selected
        Dim intSelectedWeek As Integer

        ' Constant for seeing if a week is selected
        Const intButtonSelected As Integer = 1

        ' If the dialog result is ok then reset the form
        If diaDialogResult = Windows.Forms.DialogResult.OK Then
            ' Determin which system the timetable is using
            If intTimetable(intEnumTimetable.System) <> intTimetableSystem.WeekSystem Then
                ' Check to see if a term is selected
                If frmMainScreen.cboTerm.SelectedIndex > 0 Then
                    ' Check to see if a week is selected
                    intSelectedWeek = CheckSelectedWeekButton()

                    ' Update the week buttons
                    UpdateWeekButtons()

                    ' If a week is selected, populate the week view
                    If intSelectedWeek > 0 Then
                        ' Populate the week view
                        PopulateWeekView(wkbControls(intSelectedWeek).ButtonText)

                        ' Select the correct week button
                        wkbControls(intSelectedWeek).Selected = intButtonSelected
                    End If
                End If
            Else
                ' Check to see if a year is selected
                If frmMainScreen.cboYear.SelectedIndex > 0 Then
                    ' Check to see if a week is selected
                    intSelectedWeek = CheckSelectedWeekButton()

                    ' Update the week buttons
                    UpdateWeekButtons()

                    ' If a week is selected, populate the week view
                    If intSelectedWeek > 0 Then
                        ' Populate the week view
                        PopulateWeekView(wkbControls(intSelectedWeek).ButtonText)

                        ' Select the correct week button
                        wkbControls(intSelectedWeek).Selected = intButtonSelected
                    End If
                End If
            End If
        End If
    End Sub

End Module
