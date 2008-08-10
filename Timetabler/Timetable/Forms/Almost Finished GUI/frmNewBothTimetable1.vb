Public Class frmNewBothTimetable1

    Private Sub frmNewBothTimetable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default load sub
        DefaultLoad()
    End Sub

#Region "Page One"
    '''<summary>Page one events</summary>

    Public Sub btnToPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToPage2.Click
        ' Variable for creating the term control
        Dim intCurrentTermEntry As Integer

        ' Variable for populating the year combo box
        Dim intCurrentYearEntry As Integer

        ' Variable to hold the boolean result of checking the entries
        Dim bolError As Boolean

        ' Check to see if entered values are valid
        bolError = CheckValues()

        ' If there is an error exit the event
        If bolError = True Then Return

        ' Check to see if the back button was pressed
        If bolBackPressed = False Then
            ' Get the entries for the entered text
            strTimetableName = txtTimetableName.Text.Trim
            intYears = CInt(txtYears.Text)
            intTerms = CInt(txtTerms.Text)

            ' Resize the year and term set up arrays
            Array.Resize(pnlYearPanel, intYears + 1)
            ReDim bsuTermBSU(intYears, intTerms)

            ' Set the starting entry of the combo box for the year
            cboYear.Items.Add("<Select a Year>")

            ' Add panels to the page
            CreateNewYears(1, intYears, 1, intTerms)

            ' Resize the array to the size of the years entered
            Array.Resize(strYearName, intYears + 1)
        ElseIf bolBackPressed = True Then
            ' Check to see if the timetable name has changed
            If strTimetableName <> txtTimetableName.Text.Trim Then
                ' Set the timetable text box name the the string
                strTimetableName = txtTimetableName.Text.Trim
            End If

            ' Check to see if the year value has changed
            If intYears > CInt(txtYears.Text) Then
                ' Create a copy array
                Dim bsuCopy(intYears, intTerms) As BothSetUp

                ' Copy the current setup array
                Array.Copy(bsuTermBSU, bsuCopy, bsuTermBSU.Length)

                ' Delete the extra panels
                For intCurrentYearEntry = CInt(txtYears.Text) + 1 To intYears
                    ' Delete the panel
                    pnlYearPanel(intCurrentYearEntry).Dispose()

                    ' Remove the year from the combo box
                    cboYear.Items.Remove("Year " & intCurrentYearEntry)
                Next

                ' Set the years integer to the new value
                intYears = CInt(txtYears.Text)

                ' Resize the panel array and the year name array
                Array.Resize(pnlYearPanel, intYears + 1)
                Array.Resize(strYearName, intYears + 1)

                ' Resize the term set up control array
                ReDim bsuTermBSU(intYears, intTerms)

                ' Populate the array
                For intCurrentYearEntry = 1 To intYears
                    For intCurrentTermEntry = 1 To intTerms
                        bsuTermBSU(intCurrentYearEntry, intCurrentTermEntry) = bsuCopy(intCurrentYearEntry, intCurrentTermEntry)
                    Next
                Next
            ElseIf intYears < CInt(txtYears.Text) Then
                ' Create a copy array
                Dim bsuCopy(intYears, intTerms) As BothSetUp

                ' Copy the current setup array
                Array.Copy(bsuTermBSU, bsuCopy, bsuTermBSU.Length)

                ' Resize the term set up control array
                ReDim bsuTermBSU(CInt(txtYears.Text), intTerms)

                ' Populate the original array
                For intCurrentYearEntry = 1 To intYears
                    For intCurrentTermEntry = 1 To intTerms
                        bsuTermBSU(intCurrentYearEntry, intCurrentTermEntry) = bsuCopy(intCurrentYearEntry, intCurrentTermEntry)
                    Next
                Next

                ' Resize the panel array and the year name array
                Array.Resize(pnlYearPanel, CInt(txtYears.Text) + 1)
                Array.Resize(strYearName, CInt(txtYears.Text) + 1)

                ' Add extra panels to the form
                CreateNewYears(intYears + 1, CInt(txtYears.Text), 1, intTerms)

                ' Set the years integer to the new value
                intYears = CInt(txtYears.Text)

            End If

            If intTerms > CInt(txtTerms.Text) Then
                ' Delete the extra terms from each panel
                For intCurrentYearEntry = 1 To intYears
                    For intCurrentTermEntry = CInt(txtTerms.Text) + 1 To intTerms
                        ' Delete the control
                        bsuTermBSU(intCurrentYearEntry, intCurrentTermEntry).Dispose()
                    Next
                Next

                ' Set the term integer to the new value
                intTerms = CInt(txtTerms.Text)

                ' Resize the term set up control array
                ReDim Preserve bsuTermBSU(intYears, intTerms)
            ElseIf intTerms < CInt(txtTerms.Text) Then
                ' Resize the term set up control array
                ReDim Preserve bsuTermBSU(intYears, CInt(txtTerms.Text))

                ' Add extra terms to each panel
                For intCurrentYearEntry = 1 To intYears
                    CreateNewTerms(intCurrentYearEntry, intTerms + 1, CInt(txtTerms.Text))
                Next

                ' Set the term integer to the new value
                intTerms = CInt(txtTerms.Text)
            End If
        End If

        ' Set the combo box selected index to 0
        cboYear.SelectedIndex = 0

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

        ' Create a new timetable entry
        AddThreeFields("Timetable", "TimetableName", strTimetableName, "UserID", strUserInfo(intUserInfo.ID), "System", intTimetableSystem.BothSystem)

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
            AddThreeFields("Year", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "YearNumber", intCurrentYear, "YearName", strYearName(intCurrentYear))

            ' Construct the sql command to find out the ID of the recently inserted Year
            cmdSelect = New SqlClient.SqlCommand("SELECT YearID FROM Year WHERE TimetableID = " & intTimetable(intEnumTimetable.TimetableID) & " AND YearNumber = " & intCurrentYear, ctnTimetable)

            ' Execute the command
            rdrReader = cmdSelect.ExecuteReader

            ' Get the Year ID
            rdrReader.Read()
            intTimetable(intEnumTimetable.YearID) = rdrReader!YearID

            ' Add the terms for that year to the database
            For intCurrentTerm As Integer = 1 To CInt(txtTerms.Text.Trim)
                With bsuTermBSU(intCurrentYear, intCurrentTerm)
                    With .dtpStartDate.Value
                        ' Create the start date
                        strStartDate = .Month & "/" & .Day & "/" & .Year
                    End With

                    With .dtpFinishDate.Value
                        ' Create the start date
                        strFinishDate = .Month & "/" & .Day & "/" & .Year
                    End With
                End With

                ' Reset the database variables
                cmdSelect = Nothing
                rdrReader.Close()

                ' Create a new term
                AddSevenFields("Term", "Number", intCurrentTerm, "StartDate", strStartDate, "FinishDate", strFinishDate, "Weeks", bsuTermBSU(intCurrentYear, intCurrentTerm).txtLength.Text.Trim, "YearID", intTimetable(intEnumTimetable.YearID), "WeekStart", bsuTermBSU(intCurrentYear, intCurrentTerm).txtStartWeek.Text.Trim, "WeekEnd", bsuTermBSU(intCurrentYear, intCurrentTerm).txtFinishWeek.Text.Trim)
            Next
        Next
        ' Set the dialog result to ok
        DialogResult = Windows.Forms.DialogResult.OK

        ' Close the form
        Me.Close()
    End Sub

#End Region


End Class
