Public Class frmTermTimetable

    ' Variables to store data from the first page to check for changes and to add to the database
    Public strTimetableName As String
    Public intYears As Integer
    Public intTerms As Integer

    ' Boolean to tell whether the back button has been pressed or not
    Public bolBackPressed As Boolean

    ' Array to store the years names
    Public strYearName() As String

    ' Array to store the year panels
    Public pnlYearPanel() As Panel

    ''' <summary>
    ''' Stores the term and week setup controls
    ''' </summary>
    ''' <remarks></remarks>
    Public twsTerm(0, 0) As TermAndWeekSetup

    ' Array to store the term set up controls
    'Public tsuTermTSU(0, 0) As TermSetUp

    ' The event that is run to load the default start values
    Public Sub DefaultLoad()
        ' Hide the error label on the first page
        lblPage1Error.Visible = False

        ' Clear the text boxes
        txtTerms.Text = Nothing
        txtYearName.Text = Nothing
        txtTimetableName.Text = Nothing

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


#Region "Form Inherited Events"
    '''<summary>Events that are inheritable or useable for other inherited forms</summary>
    ''' 
    Public Overridable Sub btnPage2Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPage2Cancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Exit the form
        Me.Close()
    End Sub

    Public Overridable Sub cboYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        ' Variable to hold the current year while hiding and showing the panels
        Dim intCurrentYearEntry As Integer

        ' Check the selected index and act accordingly
        Select Case cboYear.SelectedIndex
            Case Is = 0
                ' For each year hide the panel
                For intCurrentYearEntry = 1 To intYears
                    ' Hide the panel
                    pnlYearPanel(intCurrentYearEntry).Visible = False

                    ' Hide the name text box and label
                    txtYearName.Visible = False
                    lblYearName.Visible = False
                Next
            Case Is > 0
                ' For each year hide the panel
                For intCurrentYearEntry = 1 To intYears
                    ' Hide the panel
                    pnlYearPanel(intCurrentYearEntry).Visible = False
                Next

                ' Show the selected panel
                pnlYearPanel(cboYear.SelectedIndex).Visible = True

                ' Set the value of the text box to that of the array
                txtYearName.Text = strYearName(cboYear.SelectedIndex)

                ' Show the name text box and label
                txtYearName.Visible = True
                lblYearName.Visible = True
        End Select
    End Sub

    Private Sub txtYearName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYearName.KeyDown, txtTimetableName.KeyDown
        TextBoxEvents.AllowAlphaNumeric(sender, e)
    End Sub

    Public Overridable Sub txtYearName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYearName.TextChanged
        ' Variable to hold the selected index of the combo box
        Dim intIndex As Integer

        ' Get the selected index
        intIndex = cboYear.SelectedIndex

        ' Check the selected index
        If intIndex > 0 Then
            ' Set the text in the text box to the array
            strYearName(intIndex) = txtYearName.Text

            ' Check the contents of the text box
            If strYearName(intIndex) = "" Then
                ' Reset the name of the year in the combo box
                cboYear.Items.Item(intIndex) = "Year " & intIndex
            Else
                ' Set the name of the year in the combo box
                cboYear.Items.Item(intIndex) = "Year " & intIndex & " - " & strYearName(intIndex)
            End If
        End If
    End Sub

    Public Overridable Function CheckValues() As Boolean
        ' Variables for contructing a reading statement and reading from the DB
        Dim cmdSelect As SqlClient.SqlCommand
        Dim rdrResults As SqlClient.SqlDataReader

        ' Constants for the error label
        Const strTimetableNameError As String = "Please enter a name for the timetable"
        Const strYearsError As String = "Please enter the number of years for the timetable"
        Const strTermsError As String = "Please enter the number of terms in a year"
        Const strNumericYearError As String = "Please ensure an integer value for the years greater than 0 is entered"
        Const strNumericTermError As String = "Please ensure an integer value for the terms greater than 0 is entered"
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
        cmdSelect = New SqlClient.SqlCommand("SELECT TimetableName FROM Timetable", ctnTimetable)

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
        ElseIf IsNumeric(txtYears.Text) = False Or CInt(txtYears.Text) < 1 Then
            ' Set the error label text
            lblPage1Error.Text = strNumericYearError

            ' Set the position of the label
            LabelCentreX(lblPage1Error, Me)

            ' Make the label visible
            lblPage1Error.Visible = True

            Return True
        End If

        ' Check to see if a value for the term is entered and numeric
        If txtTerms.Text = Nothing Then
            ' Set the error label text
            lblPage1Error.Text = strTermsError

            ' Set the position of the label
            LabelCentreX(lblPage1Error, Me)

            ' Make the label visible
            lblPage1Error.Visible = True

            Return True
        ElseIf IsNumeric(txtTerms.Text) = False Or CInt(txtTerms.Text) < 1 Then
            ' Set the error label text
            lblPage1Error.Text = strNumericTermError

            ' Set the position of the label
            LabelCentreX(lblPage1Error, Me)

            ' Make the label visible
            lblPage1Error.Visible = True

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

    Public Overridable Sub CreateNewYears(ByVal intStartYear As Integer, ByVal intEndYear As Integer, ByVal intStartTerm As Integer, ByVal intEndTerm As Integer)
        ' Variable to hold the current year
        Dim intCurrentYearEntry As Integer

        ' Set up the page 2 panel
        For intCurrentYearEntry = intStartYear To intEndYear
            ' Add the year to the combo box
            cboYear.Items.Add("Year " & CStr(intCurrentYearEntry))

            ' Create a new instance of the panel in the array to hold the term set up controls
            pnlYearPanel(intCurrentYearEntry) = New Panel

            ' Create the panel to hold the term controls for the year
            pnlYearPanel(intCurrentYearEntry).Visible = False
            pnlYearPanel(intCurrentYearEntry).AutoScroll = True
            pnlYearPanel(intCurrentYearEntry).BackColor = System.Drawing.Color.Transparent
            pnlYearPanel(intCurrentYearEntry).Location = New System.Drawing.Point(0, 54)
            pnlYearPanel(intCurrentYearEntry).Name = "pnlYear" & intCurrentYearEntry
            pnlYearPanel(intCurrentYearEntry).Size = New System.Drawing.Size(476, 141)

            ' Add terms to the panel
            CreateNewTerms(intCurrentYearEntry, intStartTerm, intEndTerm)

            ' Add the new panel to the page panel
            pnlPage2.Controls.Add(pnlYearPanel(intCurrentYearEntry))
        Next

        ' Set the selected index to 0
        cboYear.SelectedIndex = 0
    End Sub

    Public Overridable Sub CreateNewTerms(ByVal intCurrentYearEntry As Integer, ByVal intStartTerm As Integer, ByVal intEndTerm As Integer)
        ' Variable for creating the term control
        Dim intCurrentTermEntry As Integer

        ' Create the term set up controls
        For intCurrentTermEntry = intStartTerm To intEndTerm
            ' Create a new instance of the term set up control
            twsTerm(intCurrentYearEntry, intCurrentTermEntry) = New TermAndWeekSetup

            ' Create the term set up control
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).BackColor = System.Drawing.Color.White
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).TermNumber = intCurrentTermEntry
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).Dock = System.Windows.Forms.DockStyle.Top
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).Location = New System.Drawing.Point(0, 10)
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).Name = "twsTerm" & intCurrentTermEntry
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).TermSetup = True

            ' Add the term set up to the panel
            pnlYearPanel(intCurrentYearEntry).Controls.Add(twsTerm(intCurrentYearEntry, intCurrentTermEntry))

            ' Send the control to the bottom of the panel
            twsTerm(intCurrentYearEntry, intCurrentTermEntry).BringToFront()
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

    Private Sub txtTerms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTerms.KeyDown, txtYears.KeyDown
        ' Call the allow only numbers event
        TextBoxEvents.AllowOnlyNumbers(sender, e)
    End Sub



End Class
