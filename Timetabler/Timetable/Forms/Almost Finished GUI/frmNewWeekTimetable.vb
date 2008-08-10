Public Class frmNewWeekTimetable
#Region "Page One"
    '''<summary>Page one events</summary>

    Public Sub btnToPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToPage2.Click
        ' Variable for populating the year combo box
        Dim intCurrentYearEntry As Integer

        ' Variable to hold the boolean result of checking the entries
        Dim bolError As Boolean

        ' Check to see if entered values are valid
        bolError = CheckPageOneValues()

        ' If there is an error exit the event
        If bolError = True Then Return

        ' Check to see if the back button was pressed
        If bolBackPressed = False Then
            ' Get the entries for the entered text
            strTimetableName = txtTimetableName.Text.Trim
            intYears = CInt(txtYears.Text)

            ' Resize the year set up array
            Array.Resize(wsuWeekWSU, intYears + 1)

            ' Add week set up contols and the year panel to the page
            CreateNewYears(1, intYears)
        ElseIf bolBackPressed = True Then
            ' Check to see if the timetable name has changed
            If strTimetableName <> txtTimetableName.Text.Trim Then
                ' Set the timetable text box name the the string
                strTimetableName = txtTimetableName.Text.Trim
            End If

            ' Check to see if the year value has changed
            If intYears > CInt(txtYears.Text) Then
                ' Delete the extra week set up controls
                For intCurrentYearEntry = CInt(txtYears.Text) + 1 To intYears
                    ' Delete the week set up control
                    wsuWeekWSU(intCurrentYearEntry).Dispose()
                Next

                ' Set the years integer to the new value
                intYears = CInt(txtYears.Text)

                ' Resize the week set up array
                Array.Resize(wsuWeekWSU, intYears + 1)
            ElseIf intYears < CInt(txtYears.Text) Then
                ' Resize the week set up array
                Array.Resize(wsuWeekWSU, CInt(txtYears.Text) + 1)

                ' Add extra week set up controls to the panel
                CreateNewYear(intYears + 1, CInt(txtYears.Text))

                ' Set the years integer to the new value
                intYears = CInt(txtYears.Text)
            End If
        End If
        ' Hide the page one panel and show the page two panel
        pnlPage1.Visible = False
        pnlPage2.Visible = True

        ' Hide the error label on the first page
        lblPage1Error.Visible = False

        ' Set the accept and cancel buttons
        Me.AcceptButton = Nothing
        Me.CancelButton = btnBack
    End Sub

#End Region

#Region "Page Two"
    ''' <summary>
    ''' Page two events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        ' Sql variables to get ID's
        Dim cmdSelect As SqlClient.SqlCommand
        Dim rdrReader As SqlClient.SqlDataReader

        ' Strings to convert the date to sql format
        Dim strStartDate As String
        Dim strFinishDate As String

        ' Variable to hold the boolean result of checking the entries
        Dim bolError As Boolean

        ' Variable to hold the start date
        Dim datStartDate As DateTime

        ' Check to see if entered values are valid
        bolError = CheckPageTwoValues()

        ' If there is an error exit the event
        If bolError = True Then Return

        ' Create a new timetable entry
        AddThreeFields("Timetable", "TimetableName", strTimetableName, "UserID", strUserInfo(intUserInfo.ID), "System", intTimetableSystem.WeekSystem)

        ' Construct the sql command to get the id of the timetable created
        cmdSelect = New SqlClient.SqlCommand("SELECT * FROM Timetable WHERE UserID = " & strUserInfo(intUserInfo.ID), ctnTimetable)

        ' Execute the command
        rdrReader = cmdSelect.ExecuteReader

        ' Get the timetable id
        Do While rdrReader.Read
            ' Check for the timetable name
            If rdrReader!TimetableName = strTimetableName Then
                intTimetable(intEnumTimetable.TimetableID) = rdrReader!TimetableID
                intTimetable(intEnumTimetable.System) = rdrReader!System
            End If
        Loop

        ' Reset the database variables
        cmdSelect = Nothing
        rdrReader.Close()

        ' Add the years to the database
        For intCurrentYear As Integer = 1 To CInt(txtYears.Text.Trim)
            ' Create a new year
            AddThreeFields("Year", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "YearNumber", intCurrentYear, "YearName", wsuWeekWSU(intCurrentYear).YearName)

            ' Construct the sql command to find out the ID of the recently inserted Year
            cmdSelect = New SqlClient.SqlCommand("SELECT YearID FROM Year WHERE TimetableID = " & intTimetable(intEnumTimetable.TimetableID) & " AND YearNumber = " & intCurrentYear, ctnTimetable)

            ' Execute the command
            rdrReader = cmdSelect.ExecuteReader

            ' Get the Year ID
            rdrReader.Read()
            intTimetable(intEnumTimetable.YearID) = rdrReader!YearID

            ' Add the term for that year to the database
            With wsuWeekWSU(intCurrentYear)
                With .dtpStartDate.Value
                    ' Create the start date
                    strStartDate = .Month & "/" & .Day & "/" & .Year

                    ' Get the start date from the control to manipulate
                    datStartDate = .Date
                End With

                ' Add the duration to the date
                datStartDate.AddDays(.Duration * 7)

                With datStartDate
                    ' Create the start date
                    strFinishDate = .Month & "/" & .Day & "/" & .Year
                End With


                ' Reset the database variables
                cmdSelect = Nothing
                rdrReader.Close()

                ' Create a new term
                AddSevenFields("Term", "Number", 0, "StartDate", strStartDate, "FinishDate", strFinishDate, "Weeks", .Duration, "YearID", intTimetable(intEnumTimetable.YearID), "WeekStart", 1, "WeekEnd", .Duration)
            End With
        Next
        ' Set the dialog result to ok
        DialogResult = Windows.Forms.DialogResult.OK

        ' Close the form
        Me.Close()
    End Sub

#End Region

    Private Sub frmNewWeekTimetable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default load event
        DefaultLoad()

    End Sub

End Class
