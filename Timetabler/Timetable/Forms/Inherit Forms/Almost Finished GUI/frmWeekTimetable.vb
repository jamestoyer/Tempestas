Public Class frmWeekTimetable
    ' Array to store the year panels
    Public pnlYearPanel As Panel

    ' Array to store the week set up controls
    Public wsuWeekWSU(0) As WeekSetUp

    ' Boolean to tell whether the back button has been pressed or not
    Public bolBackPressed As Boolean

    ' Variables to store data from the first page to check for changes and to add to the database
    Public strTimetableName As String
    Public intYears As Integer

    ' The event that is run to load the default start values
    Public Sub DefaultLoad()
        ' Hide the error labels 
        lblPage1Error.Visible = False
        lblPage2Error.Visible = False

        ' Clear the text boxes
        txtTimetableName.Text = Nothing
        txtYears.Text = Nothing

        ' Hide the page 2 panel and make the page one panel visible
        pnlPage2.Visible = False
        pnlPage1.Visible = True

        ' Set the page 2 panel to the same position as page one
        pnlPage2.Location = pnlPage1.Location

        ' Set the active control to the timetable name text box
        Me.ActiveControl = txtTimetableName

        ' Set the accept and cancel buttons
        Me.AcceptButton = btnToPage2
        Me.CancelButton = btnPage1Cancel
    End Sub

    Private Sub txtYears_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYears.KeyDown
        ' Call the allow only numbers event
        TextBoxEvents.AllowOnlyNumbers(sender, e)
    End Sub

#Region "Form Inherited Events"
    Public Overridable Sub btnPage2Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPage2Cancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Exit the form
        Me.Close()
    End Sub

    Public Overridable Function CheckPageOneValues() As Boolean
        ' Variables for contructing a reading statement and reading from the DB
        Dim cmdSelect As SqlClient.SqlCommand
        Dim rdrResults As SqlClient.SqlDataReader

        ' Constants for the error label
        Const strTimetableNameError As String = "Please enter a name for the timetable"
        Const strYearsError As String = "Please enter the number of years for the timetable"
        Const strTimetableNameExists As String = "Timetable name taken, please select another"

        ' Check to see if a timetable name has been entered
        If txtTimetableName.Text = Nothing Then
            ' Set the error label text
            lblPage1Error.Text = strTimetableNameError

            ' Set the position of the label
            LabelCentreX(lblPage1Error, Me)

            ' Make the label visible
            lblPage1Error.Visible = True

            Return True
        End If

        ' Construct the sql command
        cmdSelect = New SqlClient.SqlCommand("SELECT TimetableName FROM Timetable WHERE UserID = " & strUserInfo(intUserInfo.ID), ctnTimetable)

        ' Execute the command
        rdrResults = cmdSelect.ExecuteReader

        Do While rdrResults.Read
            ' Check to see if the username is taken
            If txtTimetableName.Text.Trim = rdrResults!TimetableName Then
                ' Set the text of the error label to the username taken constant
                lblPage1Error.Text = strTimetableNameExists

                ' Position the label
                LabelCentreX(lblPage1Error, Me)

                ' Show the error label
                lblPage1Error.Visible = True

                ' Reset the variables
                cmdSelect = Nothing
                rdrResults.Close()

                ' Exit the sub
                Return True
            End If
        Loop

        ' Reset the variables
        cmdSelect = Nothing
        rdrResults.Close()

        ' Check to see if a value for the year is entered and numeric
        If txtYears.Text = Nothing Then
            ' Set the error label text
            lblPage1Error.Text = strYearsError

            ' Set the position of the label
            LabelCentreX(lblPage1Error, Me)

            ' Make the label visible
            lblPage1Error.Visible = True

            Return True
        End If

        Return False
    End Function

    Public Overridable Function CheckPageTwoValues() As Boolean
        ' Constants for the error label
        Const strSeveralWeekError As String = "Please enter a duration for years "
        Const strOneWeekError As String = "Please enter a duration for year "

        ' Variable to hold the current entry in week set up array
        Dim intEntry As Integer

        ' Array to hold the weeks that have no duration
        Dim intWeekError(0) As Integer

        For intEntry = 1 To wsuWeekWSU.Length - 1
            ' Check to see if a duration is entered
            If wsuWeekWSU(intEntry).Duration = 0 Then
                ' Resize the array
                Array.Resize(intWeekError, intWeekError.Length + 1)

                ' Add the year number to the array
                intWeekError(intWeekError.Length - 1) = wsuWeekWSU(intEntry).ControlYear
            End If
        Next

        ' Check to see if there are years without duration
        If intWeekError.Length = 2 Then
            ' Set the error label text
            lblPage2Error.Text = strOneWeekError & intWeekError(1)

            ' Set the position of the label
            LabelCentreX(lblPage2Error, Me)

            ' Make the label visible
            lblPage2Error.Visible = True

            Return True
        ElseIf intWeekError.Length > 2 Then
            ' Set the error label text to the constant
            lblPage2Error.Text = strSeveralWeekError

            ' Add the week to the error label
            lblPage2Error.Text &= intWeekError(1)

            For intEntry = 2 To intWeekError.Length - 2
                ' Add the week to the error label
                lblPage2Error.Text &= ", "
                lblPage2Error.Text &= intWeekError(intEntry)
            Next

            ' Add the week to the error label
            lblPage2Error.Text &= " and "
            lblPage2Error.Text &= intWeekError(intWeekError.Length - 1)

            ' Set the position of the label
            LabelCentreX(lblPage2Error, Me)

            ' Make the label visible
            lblPage2Error.Visible = True

            Return True
        End If

        Return False
    End Function

    Public Overridable Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPage1Cancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Exit the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' Create a new panel to to store the week controls then adds the controls to the panel
    ''' </summary>
    ''' <param name="intStartYear">The year number to start adding from</param>
    ''' <param name="intEndYear">The year number to add to</param>
    ''' <remarks></remarks>
    Public Overridable Sub CreateNewYears(ByVal intStartYear As Integer, ByVal intEndYear As Integer)
        ' Create a new instance of the panel in the array to hold the week set up controls
        pnlYearPanel = New Panel

        ' Create the panel to hold the year controls for the timetable
        pnlYearPanel.Visible = False
        pnlYearPanel.AutoScroll = True
        pnlYearPanel.BackColor = System.Drawing.Color.Transparent
        pnlYearPanel.Location = New System.Drawing.Point(0, 10)
        pnlYearPanel.Name = "pnlYears"
        pnlYearPanel.Size = New System.Drawing.Size(477, 147)

        ' Add the new panel to the page panel
        pnlPage2.Controls.Add(pnlYearPanel)

        ' Add Years to the panel
        CreateNewYear(intStartYear, intEndYear)

        ' Make the panel visible
        pnlYearPanel.Visible = True
    End Sub

    ''' <summary>
    ''' Creates new week setup controls and adds them to the panel
    ''' </summary>
    ''' <param name="intStartYear">The year number to start adding from</param>
    ''' <param name="intEndYear">The year number to add to</param>
    ''' <remarks></remarks>
    Public Overridable Sub CreateNewYear(ByVal intStartYear As Integer, ByVal intEndYear As Integer)
        ' Variable for creating the week control
        Dim intCurrentYearEntry As Integer

        ' Create the week set up controls
        For intCurrentYearEntry = intStartYear To intEndYear
            ' Create a new instance of the week set up control
            wsuWeekWSU(intCurrentYearEntry) = New WeekSetUp

            ' Create the week set up control
            wsuWeekWSU(intCurrentYearEntry).ControlYear = intCurrentYearEntry
            wsuWeekWSU(intCurrentYearEntry).Dock = System.Windows.Forms.DockStyle.Top
            wsuWeekWSU(intCurrentYearEntry).Location = New System.Drawing.Point(0, 0)
            wsuWeekWSU(intCurrentYearEntry).Name = "wsuYear" & intCurrentYearEntry
            wsuWeekWSU(intCurrentYearEntry).Size = New System.Drawing.Size(477, 49)

            ' Add the week set up to the panel
            pnlYearPanel.Controls.Add(wsuWeekWSU(intCurrentYearEntry))

            ' Send the control to the bottom of the panel
            wsuWeekWSU(intCurrentYearEntry).BringToFront()
        Next
    End Sub

    Public Overridable Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' Set the button back boolean to true
        bolBackPressed = True

        ' Hide the page two panel and show the page one panel
        pnlPage1.Visible = True
        pnlPage2.Visible = False

        ' Set the active control to the timetable name text box
        Me.ActiveControl = txtTimetableName

        ' Set the accept and cancel buttons
        Me.AcceptButton = btnToPage2
        Me.CancelButton = btnPage1Cancel
    End Sub
#End Region


    Private Sub txtTimetableName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTimetableName.KeyDown
        ' Call the allow alpha numeric event
        TextBoxEvents.AllowAlphaNumeric(sender, e)
    End Sub
End Class
