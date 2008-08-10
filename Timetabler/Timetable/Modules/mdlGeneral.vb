Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Module mdlGeneral
    ' Deletes contents of arrays that can be resized
    Public Sub UpdateCustomControlArray(ByVal ctrlArray As Array)
        ' Create an entry variable
        Dim intEntry As Integer

        ' If the array hasn't been sized then exit
        If ctrlArray Is Nothing Then Return

        Do Until intEntry = ctrlArray.Length
            ' Check to see if there is a control in the entry
            If ctrlArray(intEntry) IsNot Nothing Then
                ' Delete the control
                ctrlArray(intEntry).Dispose()
                ctrlArray(intEntry) = Nothing
            End If

            ' Increase the entry integer by one
            intEntry = intEntry + 1
        Loop
    End Sub

    ' Event which updates the grid view for the week
    Public Sub UpdateWeekView()
        ' Variables to find the start day and finish day
        Dim intStartDay As Integer
        Dim intFinishDay As Integer

        ' Variables to create the week view
        Dim intFromDay As Integer
        Dim intToDay As Integer

        ' Variables to hold the start and end time
        Dim strStartTime As String = Nothing
        Dim strFinishTime As String = Nothing

        ' Hide the week view panel
        frmMainScreen.pnlWeekEvent.Visible = False

        ' Get the time boundaries for the view
        GetTimeBoundaries(strStartTime, strFinishTime)

        ' Get the day boundaries for the view
        FindDayBoundaries(intStartDay, intFinishDay)

        ' Decide what to do depending on the results
        Select Case intStartDay
            Case 0 To 5
                If intFinishDay < 6 Then
                    intFromDay = 1
                    intToDay = 5
                    CreateWeekView(intFromDay, intToDay, strStartTime, strFinishTime)
                Else
                    intFromDay = 1
                    intToDay = intFinishDay
                    CreateWeekView(intFromDay, intToDay, strStartTime, strFinishTime)
                End If
            Case Is > 6
                intFromDay = 6
                intToDay = 7
                CreateWeekView(intFromDay, intToDay, strStartTime, strFinishTime)
        End Select
    End Sub

    ' The event for creating the week view grid
    Public Sub CreateWeekView(ByVal intDayFrom As Integer, ByVal intDayTo As Integer, ByVal strStartTime As String, ByVal strFinishTime As String)
        ' Control creation variables
        Dim strName As String
        Dim wkvNew As New WeekView
        Dim wktNew As New WeekTime

        ' Sql statements
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Position variables for the control
        Dim intY As Integer

        ' Varaible to add to the week view control to the array
        Dim intEntry As Integer = 1

        ' Hide the week view panel
        frmMainScreen.pnlWeekEvent.Visible = False

        ' Delete the old week view
        frmMainScreen.ClearWeekView()

        ' Resize the week view and entry array by one
        Array.Resize(wkvControls, 1)
        Array.Resize(intWeekViewEntrys, 1)

        ' Create the new week time control
        wktNew.Location = New System.Drawing.Point(0, 0)
        wktNew.Name = "wktTime"
        wktNew.Size = New System.Drawing.Size(1259, 19)
        wktNew.StartTime = strStartTime
        wktNew.FinishTime = strFinishTime
        wktNew.StartUp = True
        frmMainScreen.pnlWeekEvent.Controls.Add(wktNew)

        ' Set the week time to a array to allow manipulation
        wktControl = New WeekTime()
        wktControl = wktNew

        ' Find the height of the week time bar
        intY = wktNew.Height

        ' Construct the sql statment
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Day WHERE DayID BETWEEN " & intDayFrom & " AND " & intDayTo, ctnTimetable)

        ' Execute the statement
        sqlResults = sqlStatement.ExecuteReader
        Do While sqlResults.Read
            ' Resize the week view and entry array by one
            Array.Resize(wkvControls, wkvControls.Length + 1)
            Array.Resize(intWeekViewEntrys, intWeekViewEntrys.Length + 1)

            ' Create a string for the name of the control
            strName = "wev" & sqlResults!DayID

            ' Create the control
            wkvNew.Day = UCase(sqlResults!Day)
            wkvNew.Location = New System.Drawing.Point(0, intY)
            wkvNew.Size = New System.Drawing.Size(24, 123)
            wkvNew.Height = 123
            wkvNew.Name = strName
            wkvNew.StartTime = strStartTime
            wkvNew.FinishTime = strFinishTime

            ' Week to the week event panel
            frmMainScreen.pnlWeekEvent.Controls.Add(wkvNew)

            ' Set the control to the arrays
            wkvControls(intEntry) = wkvNew
            intWeekViewEntrys(intEntry) = sqlResults!DayID

            ' Increase the y position of the control the size of the previous control
            intY = intY + wkvControls(intEntry).Height - 1

            ' Increase the entry ID by one
            intEntry += 1

            ' Reset the new control variable
            wkvNew = New WeekView
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Show the week view panel
        frmMainScreen.pnlWeekEvent.Visible = True
    End Sub

    ' The event for finding out the boundaries of the time for a term
    Private Sub GetTimeBoundaries(ByRef strStartTime, ByRef strFinishTime)
        ' Sql statements
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Variables for working out when the finish time is
        Dim intFinishTime As Integer
        Dim intDuration As Integer
        Dim intTime As Integer
        Dim intHours As Integer
        Dim strTime As String
        Dim intMinutes As Integer

        ' Variables for getting the start time of the timetable
        Dim intStartTime As Integer
        Dim boolStart As Boolean = True

        ' Construct the sql statment
        sqlStatement = New SqlClient.SqlCommand("SELECT TermEntryWeek.TermID, Entry.EntryID, Entry.Time, Entry.Duration FROM TermEntryWeek INNER JOIN Entry ON TermEntryWeek.EntryID = Entry.EntryID WHERE TermEntryWeek.TermID = " & intTimetable(intEnumTimetable.TermID) & " ORDER BY Entry.Time", ctnTimetable)

        ' Execute the statement
        sqlResults = sqlStatement.ExecuteReader
        Do While sqlResults.Read
            If boolStart = True Then
                intStartTime = CInt(sqlResults!Time)

                ' Reset the starting boolean to false
                boolStart = False
            Else
                ' Get the start time and duration of the event
                intDuration = CInt(sqlResults!Duration)
                intTime = CInt(sqlResults!Time)

                ' Work out the finish time
                intTime = CalculateTime(intTime, intDuration)

                ' Check to see if the new finishing time is greater than the current one
                If intFinishTime < intTime Then
                    intFinishTime = intTime
                End If
            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Split up the start time to make it a whole hour
        SplitTime(intStartTime, intMinutes, intHours)

        ' Check to see if the time is a whole hour if not make it one
        If intMinutes > 0 Then
            intHours = intHours * 100
            strTime = CheckTimes(CStr(intHours))
        Else
            strTime = CheckTimes(CStr(intStartTime))
        End If

        ' Check the value of the time string
        If strTime > 0 Then
            ' Set the start time
            strStartTime = strTime
        Else
            ' Set the start time
            strStartTime = "0900"
        End If
       
        ' Split up the finish time to make it a whole hour
        SplitTime(intFinishTime, intMinutes, intHours)

        ' Check to see if the time is a whole hour if not make it one
        If intMinutes > 0 Then
            intHours = (intHours + 1) * 100
            strTime = CheckTimes(CStr(intHours))
        Else
            strTime = CheckTimes(CStr(intFinishTime))
        End If

        ' Check the value of the time string
        If strTime > 0 Then
            ' Set the finish time
            strFinishTime = strTime
        Else
            ' Set the finish time
            strFinishTime = "1800"
        End If
        
    End Sub

    ' The event that populates the week grid with events
    Public Sub PopulateWeekView(ByVal strWeek As String)
        ' Sql variables
        Dim strCommandString As String
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Control creation variables
        Dim intCreatedControlEntry As Integer = 1
        Dim strName As String = "wev"
        Dim wevNew As New WeekEventView
        Dim intEntry As Integer = 1

        ' Hide the week view grid panel
        frmMainScreen.pnlWeekEvent.Visible = False

        ' Delete any current week event views on the panel
        UpdateCustomControlArray(wevControls)

        ' Resize the week event view array
        Array.Resize(wevControls, 1)

        ' Construct the sql statement
        strCommandString = "SELECT TermEntryWeek.TermID, TermEntryWeek.Week, Entry.EntryID, Entry.Time, Entry.Duration, Entry.Notes, Entry.Optional, Module.Code, Module.Name, Contact.Type, Contact.Colour, Day.DayID, Staff.Initials, Room.Number "
        strCommandString += "FROM (TermEntryWeek "
        strCommandString += "INNER JOIN Entry ON TermEntryWeek.EntryID = Entry.EntryID) "
        strCommandString += "INNER JOIN Module ON Entry.ModuleID = Module.ModuleID "
        strCommandString += "INNER JOIN Contact ON Entry.ContactID = Contact.ContactID "
        strCommandString += "INNER JOIN Day ON Entry.DayID = Day.DayID "
        strCommandString += "INNER JOIN Staff ON Entry.StaffID = Staff.StaffID "
        strCommandString += "INNER JOIN Room ON Entry.RoomID = Room.RoomID "
        strCommandString += "WHERE TermEntryWeek.TermID = " & intTimetable(intEnumTimetable.TermID)
        strCommandString += " AND TermEntryWeek.Week = " & strWeek
        strCommandString += " ORDER BY DayID"
        sqlStatement = New SqlClient.SqlCommand(strCommandString, ctnTimetable)

        ' Execute the command
        sqlResults = sqlStatement.ExecuteReader

        ' Read from the data reader
        Do While sqlResults.Read
            ' Resize the week event view array
            Array.Resize(wevControls, wevControls.Length + 1)

            ' Create the control
            wevNew.StartTime = sqlResults!Time
            wevNew.Contact = sqlResults!Type
            wevNew.Duration = sqlResults!Duration
            wevNew.Location = New System.Drawing.Point(26, 3)
            wevNew.ModuleCode = sqlResults!code
            wevNew.ModuleName = sqlResults!Name
            wevNew.Name = "wev" & sqlResults!DayID & sqlResults!Time
            wevNew.Notes = sqlResults!Notes
            wevNew.Room = sqlResults!Number
            wevNew.Staff = sqlResults!Initials
            wevNew.Day = sqlResults!DayID
            wevNew.Colour = sqlResults!Colour
            wkvControls(Array.IndexOf(intWeekViewEntrys, sqlResults!DayID)).Controls.Add(wevNew)

            ' Add to the week event view control array
            wevControls(intEntry) = wevNew

            ' Add one to the entry integer
            intEntry = intEntry + 1

            ' Create a new week event view
            wevNew = New WeekEventView
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
        intEntry = 1

        ' Position the controls
        PositionEvent()

        ' Show the week grid panel
        frmMainScreen.pnlWeekEvent.Visible = True

    End Sub

    ' Event that positions the week event views
    Private Sub PositionEvent()
        ' Variables for the event time
        Dim intEventTime As Integer
        Dim intEventMinutes As Integer
        Dim intEventHours As Integer

        ' Variables for getting the positions of a line
        Dim intPixelEntry As Integer = 0
        Dim intTimeEntry As Integer = 1
        Dim intEntry As Integer = 0

        ' Array variables
        Dim intDayEntry As Integer = 1
        Dim intEventEntry As Integer = 1

        ' Event position variables
        Dim intLinePixel As Integer
        Dim intPadding As Integer = 3
        Dim intXPosition As Integer
        Dim decHourFraction As Decimal
        Dim decPixels As Decimal
        Const intHourWidth As Integer = 90
        Dim intMinutePixel As Integer

        ' Event size variables
        Dim intLargestHeight(0) As Integer
        Dim intHeight As Integer
        Dim intDay As Integer

        ' Resize the largest height array
        Array.Resize(intLargestHeight, intWeekViewEntrys.Length)

        If wevControls.Length > 1 Then
            Do Until intEventEntry = wevControls.Length
                ' Get the start time of the event
                intEventTime = wevControls(intEventEntry).StartTime

                ' Split the event time into minutes and hours
                SplitTime(intEventTime, intEventMinutes, intEventHours)

                ' Convert the hours integer back to a time
                intEventHours = intEventHours * 100

                ' Compare the drawn line times to the event time
                Do Until intWeekViewLines(intEntry, intTimeEntry) = 0
                    If intWeekViewLines(intEntry, intTimeEntry) = intEventHours Then
                        ' Get the pixel entry for the line
                        intLinePixel = intWeekViewLines(intEntry, intPixelEntry)

                        ' Calculate the fraction of an hour of the starting time minutes of the event
                        decHourFraction = intEventMinutes / 60

                        ' Find out the number of pixels the fraction of the hour equates to
                        decPixels = decHourFraction * intHourWidth

                        ' Convert the decimal to an integer
                        intMinutePixel = CInt(decPixels)

                        ' Find out if the pixel value is a whole number and act accordingly
                        If intMinutePixel - decPixels < 0 Then
                            ' Calculate the x position of the control
                            intXPosition = intPadding + intLinePixel + intMinutePixel
                        Else
                            ' Take 0.5 off the decPixel value and convert into an integer
                            intMinutePixel = CInt(decPixels - 0.5)

                            ' Calculate the x position of the control
                            intXPosition = intPadding + intLinePixel + intMinutePixel
                        End If

                    End If

                    ' Increase the entry number by one
                    intEntry = intEntry + 1
                Loop

                ' Set the x position of the control
                wevControls(intEventEntry).Location = New System.Drawing.Point(intXPosition, intPadding)

                ' Get the height of the control
                intHeight = wevControls(intEventEntry).Height

                ' Get the day
                intDay = wevControls(intEventEntry).Day

                If intHeight > intLargestHeight(Array.IndexOf(intWeekViewEntrys, intDay)) Then
                    ' Get the height
                    intLargestHeight(Array.IndexOf(intWeekViewEntrys, intDay)) = intHeight
                End If

                ' Increase the day entry integer by one
                intEventEntry = intEventEntry + 1

                ' Reset the week lines entry integer
                intEntry = 0
            Loop

            ResizeWeekView(intLargestHeight)
        End If
    End Sub

    Private Sub ResizeWeekView(ByVal arrHeight As Array)
        ' Control constants
        Const intDefaultHeight As Integer = 123
        Const intAreaHeight As Integer = 118

        ' Array search variables
        Dim intEntryHeight = 1

        ' Position variables
        Dim intY As Integer
        Dim intX As Integer

        ' Set the starting points of the days
        intY = wktControl.Location.Y + wktControl.Height
        intX = wktControl.Location.X

        Do Until intEntryHeight = arrHeight.Length
            '  If wkvControls(intEntryHeight) Is Nothing Then
            ' Return
            'End If
            If arrHeight(intEntryHeight) < intAreaHeight Then
                ' Set the height of the control
                wkvControls(intEntryHeight).ControlHeight = intDefaultHeight

                ' Set the position of the conrol
                wkvControls(intEntryHeight).Location = New Point(intX, intY)

                ' Add the control height to the y variable
                intY = intY + intDefaultHeight - 1

                ' Refresh the control
                wkvControls(intEntryHeight).ControlResize = True
            Else
                ' Set the height of the control
                wkvControls(intEntryHeight).ControlHeight = arrHeight(intEntryHeight) + 6

                ' Set the position of the conrol
                wkvControls(intEntryHeight).Location = New Point(intX, intY)

                ' Add the control height to the y variable
                intY = intY + arrHeight(intEntryHeight) + 5

                ' Refresh the control
                wkvControls(intEntryHeight).ControlResize = True
            End If

            intEntryHeight = intEntryHeight + 1
        Loop
    End Sub

    ' Event that checks for combo box errors
    Public Sub ComboBoxError(ByVal frmSource As Form, ByRef cboSource As ComboBox, ByRef lblErrorLabel As Label, ByVal strErrorMessage As String)
        ' Hide the error label
        lblErrorLabel.Visible = False

        ' Check the selected index of the combo box
        If cboSource.SelectedIndex = 0 Then
            ' Set the error message to the error label
            lblErrorLabel.Text = strErrorMessage

            ' Centre the error label
            LabelCentreX(lblErrorLabel, frmSource)

            ' Show the error label
            lblErrorLabel.Visible = True

            Return
        End If
    End Sub

    Function EncryptPassword(ByVal strUsername As String, ByVal strPassword As String) As String
        Dim hshFunction As HMACSHA1
        Dim bytSecretKey() As Byte
        Dim bytHashValue() As Byte
        Dim intValue As Integer
        Dim strResult As String = ""

        ' Put the secret key into a byte array
        bytSecretKey = (New UnicodeEncoding).GetBytes(strUsername)

        ' Create the hashing component
        hshFunction = New HMACSHA1(bytSecretKey, True)

        ' Force the password into lowercase and calculate the hash value
        bytHashValue = hshFunction.ComputeHash((New UnicodeEncoding).GetBytes(LCase(strPassword)))

        ' Convert the hash value to text
        For intValue = 0 To bytHashValue.Length - 1
            strResult &= Hex(bytHashValue(intValue))
        Next

        ' Store the password to 40 characters
        EncryptPassword = Left(strResult, 40)
        Return EncryptPassword

    End Function

    ' Centers a label in the x axis
    Public Sub LabelCentreX(ByRef lblSource As Label, ByVal frmSource As Form)
        ' Variable holding the width of the label
        Dim intLabelWidth As Integer

        ' Variable holding the width of the form
        Dim intFormWidth As Integer

        ' Variable holding the location of the label
        Dim pntLocation As Point

        ' Get the width of the form and label
        intLabelWidth = lblSource.Width
        intFormWidth = frmSource.Width

        ' Get the point where the label is now
        pntLocation = lblSource.Location

        ' Work out the location of the label
        pntLocation.X = (intFormWidth - intLabelWidth) / 2

        ' Set the new location of the label
        lblSource.Location = pntLocation
    End Sub

    Function ConvertColourToText(ByVal clrColour As Color) As String
        ' Check to see if the colour is a known colour
        If clrColour.ToKnownColor > 0 Then
            ' Get the known colour value of the colour
            ConvertColourToText = clrColour.ToKnownColor
        Else
            ' Convert the colour to an argb colour
            ConvertColourToText = clrColour.ToArgb
        End If
    End Function

    Function ConvertTextToColour(ByVal strColour As String) As Color
        ' Check the format of the string
        If strColour.Length < 6 Then
            ' Convert the known colour to the colour
            ConvertTextToColour = System.Drawing.Color.FromKnownColor(strColour)
        Else
            ' Convert the argb to the colour
            ConvertTextToColour = Drawing.Color.FromArgb(strColour)
        End If
    End Function

    ' Event for finding the week bounds for a term
    Public Sub FindWeekBoundaries(ByVal intTermID As Integer, ByRef intStartWeek As Integer, ByRef intEndWeek As Integer, ByRef intDuration As Integer)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Construct the sql statement to find the week start and end
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Term WHERE TermID = " & intTermID, ctnTimetable)

        ' Execute the reader and get the results
        sqlResults = sqlStatement.ExecuteReader
        sqlResults.Read()

        ' Get the start and end week
        intStartWeek = sqlResults!WeekStart
        intEndWeek = sqlResults!WeekEnd
        intDuration = sqlResults!Weeks

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    ' Event for finding the day bounds for a term
    Private Sub FindDayBoundaries(ByRef intStartDay As Integer, ByRef intEndDay As Integer)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Variable to see if the database reading has just started
        Dim boolStart As Boolean = True

        ' Create the select statement
        sqlStatement = New SqlClient.SqlCommand("SELECT TermEntryWeek.TermID, Entry.EntryID, Entry.DayID FROM TermEntryWeek INNER JOIN Entry ON TermEntryWeek.EntryID = Entry.EntryID WHERE TermEntryWeek.TermID = " & intTimetable(intEnumTimetable.TermID) & " ORDER BY Entry.DayID", ctnTimetable)

        ' Execute the statement
        sqlResults = sqlStatement.ExecuteReader

        ' Update the start and end integers
        Do While sqlResults.Read
            If boolStart = True Then
                intStartDay = sqlResults!DayID

                ' Reset the starting boolean to false
                boolStart = False
            Else
                intEndDay = sqlResults!DayID
            End If
        Loop

        If intEndDay = 0 Then
            intEndDay = intStartDay
        End If

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Public Sub GeneralError(ByVal routineName As String, _
           ByVal theError As System.Exception)
        ' ----- Report an error to the user.
        On Error Resume Next

        MsgBox("The following error occurred at location '" & routineName & "':" & vbCrLf & vbCrLf & theError.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation)
        My.Application.Log.WriteException(theError)
    End Sub

#Region "OLD Combo box update routines"



    Public Sub FindBounds1(ByVal strTable As String, ByVal strID As String, ByRef intStart As Integer, ByRef intEnd As Integer)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Variable to see if the database reading has just started
        Dim boolStart As Boolean = True

        ' Read from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strID, ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        ' Update the start and end integers
        Do While sqlResults.Read
            If boolStart = True Then
                intStart = CInt(sqlResults.Item(strID))

                ' Reset the starting boolean to false
                boolStart = False
            Else
                intEnd = CInt(sqlResults.Item(strID))
            End If
        Loop

        If intEnd = 0 Then
            intEnd = intStart
        End If

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub



#End Region

#Region "Time Routines"

    ' Event for calculating the difference between two times in minutes
    Function TimeDifference(ByVal strStartTime As String, ByVal strFinishTime As String) As Integer
        ' Variables for holding the minutes and hours
        Dim intStartTimeHours As Integer
        Dim intStartTimeMinutes As Integer
        Dim intFinishTimeHours As Integer
        Dim intFinishTimeMinutes As Integer

        ' Split the start time string up into minutes and hours
        intStartTimeMinutes = CInt(Microsoft.VisualBasic.Right(strStartTime, 2))
        intStartTimeHours = CInt(Microsoft.VisualBasic.Left(strStartTime, 2))

        ' Split the finish time string
        intFinishTimeMinutes = CInt(Microsoft.VisualBasic.Right(strFinishTime, 2))
        intFinishTimeHours = CInt(Microsoft.VisualBasic.Left(strFinishTime, 2))

        ' Calculate the minute difference between hours
        TimeDifference = (intFinishTimeHours - intStartTimeHours) * 60

        ' Add the difference between the minutes to the time difference
        TimeDifference += intFinishTimeMinutes - intStartTimeMinutes

        ' Return the value
        Return TimeDifference
    End Function

    ' The event for calculating minutes added to an hour
    Function CalculateTime(ByVal intTime As Integer, ByVal intMinutes As Integer) As Integer
        ' Declare variables
        Dim intTotalHours As Integer
        Dim intTotalMinutes As Integer
        Dim intHours As Integer

        ' Split the time up
        SplitTime(intTime, intTotalMinutes, intTotalHours)

        ' Convert the minutes into hours and split it into hours and minutes
        SplitTime(ConvertMinutesToHours(intMinutes), intMinutes, intHours)

        ' Find the total number of hours
        intTotalHours = intTotalHours + intHours

        ' Find the total number of minutes
        intTotalMinutes = intTotalMinutes + intMinutes

        ' Convert the total hours to hours
        intTotalHours = intTotalHours * 100

        ' Find the time
        CalculateTime = intTotalHours + intTotalMinutes

        Return CalculateTime
    End Function

    ' The event for splitting up a time into minutes and hours
    Private Sub SplitTime(ByVal intTime As Integer, ByRef intMinutes As Integer, ByRef intHours As Integer)
        ' Declare variables
        Dim strTime As String

        ' Convert the integer to a string and check it's format 
        strTime = CStr(intTime)
        strTime = CheckTimes(strTime)

        ' Split the string up into minutes and hours
        intMinutes = CInt(Microsoft.VisualBasic.Right(strTime, 2))
        intHours = CInt(Microsoft.VisualBasic.Left(strTime, 2))
    End Sub

    Function ConvertMinutesToHours(ByVal intMinutes As Integer) As Integer
        ' Declare variables
        Dim intRemainder As Integer
        Dim intHours As Integer

        intRemainder = (intMinutes Mod 60)
        intMinutes = intMinutes - intRemainder

        If intMinutes = 0 Then
            ConvertMinutesToHours = intRemainder
            Return ConvertMinutesToHours
        Else
            intHours = intMinutes / 60
            intHours = intHours * 100
            ConvertMinutesToHours = intHours + intRemainder
            Return ConvertMinutesToHours
        End If
    End Function

    'Function CreateEventTime(ByVal strStartTime As String, ByVal strDuration As String) As String
    '    ' Variables for converting the strings to integers
    '    Dim intStartTime As Integer
    '    Dim intDuration As Integer

    '    ' The variables for creating the finish time
    '    Dim intFinishTime As Integer
    '    Dim strFinishTime As String

    '    ' Convert the strings into integers
    '    intStartTime = CInt(strStartTime)
    '    intDuration = CInt(strDuration)

    '    ' Work out the finish time
    '    intFinishTime = CalculateTime(intStartTime, intDuration)

    '    ' Convert the times back to strings and check they are in 24 hr format
    '    strStartTime = CheckTimes(CStr(intStartTime))
    '    strFinishTime = CheckTimes(CStr(intFinishTime))

    '    CreateEventTime = strStartTime & " - " & strFinishTime
    '    Return CreateEventTime
    'End Function

    Function CheckTimes(ByVal strTime As String) As String
        ' Declare variables
        Dim intSize As Integer

        intSize = Len(strTime)

        Select Case intSize
            Case 0
                CheckTimes = "0000"
                Return CheckTimes
            Case 1
                CheckTimes = "000" & strTime
                Return CheckTimes
            Case 2
                CheckTimes = "00" & strTime
                Return CheckTimes
            Case 3
                CheckTimes = "0" & strTime
                Return CheckTimes
        End Select

        CheckTimes = strTime
        Return CheckTimes
    End Function
#End Region


End Module
