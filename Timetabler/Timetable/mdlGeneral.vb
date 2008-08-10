Imports System.Text
Imports System.Security.Cryptography

Module mdlGeneral

    ' Declare the start and finish time variables
    Dim strStartTime As String
    Dim strFinishTime As String

    Function IsNumeric(ByVal strEntry As String)
        ' Create variable to test the incoming string
        Dim intTest As Integer

        ' If the string is not an integer, throw an exception
        Try

            intTest = CInt(strEntry)
            ' The value is an integer
            Return True

        Catch ex As System.InvalidCastException
            ' The value is not an integer
            Return False
        End Try
    End Function

    Function OpenConnection()

        ' Connect to the database. Return True on success
        Dim strConnection As String

        ' Build the connection string
        strConnection = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & My.Settings.ConnectionString & ";Integrated Security=True;User Instance=True"

        ' Attempt to open the database
        Try
            ctnTimetable = New SqlClient.SqlConnection(strConnection)
            ctnTimetable.Open()

            ' Success
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function CloseConnection()
        ' Close the timetable connection
        ctnTimetable.Close()

        Return True
    End Function

    Public Sub DeleteCustomControl(ByVal ctrlArray As Array)
        'Declare Variables
        Dim intEntry As Integer = 1

        ' If the array hasn't been sized then exit
        If ctrlArray Is Nothing Then Return

        ' If the array is only one element then return
        If ctrlArray.Length = 1 Then Return

        Do Until ctrlArray(intEntry) Is Nothing
            ' Delete the control
            ctrlArray(intEntry).Dispose()
            ctrlArray(intEntry) = Nothing

            ' Increase the entry integer by one
            intEntry = intEntry + 1
        Loop
    End Sub

    
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

    Function NumberOfBlocks() As Integer
        ' Declare the start and finish time variables
        Dim intStartTime As Integer
        Dim intFinishTime As Integer

        ' Set values to the variables
        intStartTime = CInt(strStartTime)
        intFinishTime = CInt(strFinishTime)

        ' Work out how many blocks are required
        NumberOfBlocks = (intFinishTime - intStartTime) / 100

        Select Case NumberOfBlocks
            Case Is < 0
                NumberOfBlocks = 24
                Return NumberOfBlocks
            Case Is = 0
                If intFinishTime > 0 Then
                    NumberOfBlocks = 24
                    Return NumberOfBlocks
                End If
            Case Is > 0
                Return NumberOfBlocks
        End Select

    End Function

    Public Sub UpdateWeekView()
        ' Variables to find the start day and finish day
        Dim intStartDay As Integer
        Dim intFinishDay As Integer
        Dim strTable As String = "TimetableEntry"
        Dim strOrderByID As String = "DayID"

        ' Variables to create the week view
        Dim intFrom As Integer
        Dim intTo As Integer

        ' Hide the week view panel
        frmMainScreen.pnlWeekEvent.Visible = False

        ' Delete the old week view
        DeleteCustomControl(wkvControlNames)
        DeleteCustomControl(wktControlNames)

        ' Get the time boundaries for the view
        GetTimeBoundaries()

        ' Find the bounds of the days
        FindBounds(strTable, strOrderByID, intStartDay, intFinishDay)

        ' Decide what to do depending on the results
        Select Case intStartDay
            Case 0 To 5
                If intFinishDay < 6 Then
                    intFrom = 1
                    intTo = 5
                    CreateWeekView(intFrom, intTo)
                Else
                    intFrom = 1
                    intTo = intFinishDay
                    CreateWeekView(intFrom, intTo)
                End If
            Case Is > 6
                intFrom = 6
                intTo = 7
                CreateWeekView(intFrom, intTo)
        End Select

        ' Show the week view panel
        frmMainScreen.pnlWeekEvent.Visible = True
    End Sub

    Private Sub CreateWeekView(ByVal intFrom As Integer, ByVal intTo As Integer)
        ' Control creation variables
        Dim strName As String
        Dim wkvNew As New WeekView
        Dim wktNew As New WeekTime

        ' Sql statements
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Position variables for the control
        Dim intY As Integer

        ' Create the new week time control
        wktNew.Location = New System.Drawing.Point(0, 0)
        wktNew.Name = "wktTime"
        wktNew.Size = New System.Drawing.Size(1259, 19)
        wktNew.TabIndex = 0
        wktNew.StartTime = strStartTime
        wktNew.StartUp = True
        frmMainScreen.pnlWeekEvent.Controls.Add(wktNew)

        ' Set the week time to a array to allow manipulation
        wktControlNames(1) = wktNew

        ' Find the height of the week time bar
        intY = wktNew.Height

        ' Construct the sql statment
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Day WHERE DayID BETWEEN " & intFrom & " AND " & intTo, ctnTimetable)

        ' Execute the statement
        sqlResults = sqlStatement.ExecuteReader
        Do While sqlResults.Read
            ' Create a string for the name of the control
            strName = "wev" & sqlResults!DayID

            ' Create the control
            wkvNew.Day = UCase(sqlResults!Day)
            wkvNew.Location = New System.Drawing.Point(0, intY)
            wkvNew.Size = New System.Drawing.Size(24, 123)
            wkvNew.Height = 123
            wkvNew.Name = strName
            wkvNew.TabIndex = 1

            ' Week to the week event panel
            frmMainScreen.pnlWeekEvent.Controls.Add(wkvNew)

            ' Set the control to an array
            wkvControlNames(sqlResults!DayID) = wkvNew

            ' Increase the y position of the control the size of the previous control
            intY = intY + wkvControlNames(sqlResults!DayID).Height - 1

            ' Reset the new control variable
            wkvNew = New WeekView
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Private Sub GetTimeBoundaries()
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
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM TimetableEntry ORDER BY Time", ctnTimetable)

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

        ' Set the start time
        strStartTime = strTime

        ' Split up the finish time to make it a whole hour
        SplitTime(intFinishTime, intMinutes, intHours)

        ' Check to see if the time is a whole hour if not make it one
        If intMinutes > 0 Then
            intHours = (intHours + 1) * 100
            strTime = CheckTimes(CStr(intHours))
        Else
            strTime = CheckTimes(CStr(intFinishTime))
        End If

        ' Set the finish time
        strFinishTime = strTime
    End Sub

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

    Public Sub PopulateWeekView(ByVal strWeek As String)
        ' Sql variables
        Dim sqlStatement As SqlClient.SqlCommand
        Dim sqlResults As SqlClient.SqlDataReader

        ' Control creation variables
        Dim intCreatedControlEntry As Integer = 1
        Dim strName As String = "wev"
        Dim wevNew As New WeekEventView
        Dim intEntry As Integer = 1

        ' Delete any current week event views
        DeleteCustomControl(wevControlNames)

        ' Construct the sql statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Events WHERE Week = " & strWeek & " ORDER BY DayID, Time", ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read

            ' Create the control
            wevNew.StartTime = sqlResults!Time
            wevNew.Contact = sqlResults!Type
            wevNew.Duration = sqlResults!Duration
            wevNew.Location = New System.Drawing.Point(26, 3)
            wevNew.ModuleCode = sqlResults!ModuleCode
            wevNew.ModuleName = sqlResults!ModuleName
            wevNew.Name = "wev" & sqlResults!DayID & sqlResults!Time
            wevNew.Notes = sqlResults!Notes
            wevNew.Room = sqlResults!Number
            wevNew.Staff = sqlResults!Initials
            wevNew.TabIndex = 8
            wevNew.Day = sqlResults!DayID
            wevNew.Visible = False
            wkvControlNames(sqlResults!DayID).Controls.Add(wevNew)

            ' Add to the week event view control array
            wevControlNames(intEntry) = wevNew

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

        ' Show the controls
        Do Until wevControlNames(intEntry) Is Nothing
            wevControlNames(intEntry).Visible = True

            ' Increase the entry integer by one
            intEntry = intEntry + 1
        Loop
    End Sub

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
        Dim intHourWidth As Integer = 90
        Dim intMinutePixel As Integer

        ' Event size variables
        Dim intLargestHeight(7) As Integer
        Dim intHeight As Integer
        Dim intDay As Integer

        Array.Clear(intLargestHeight, 0, 8)

        Do Until wevControlNames(intEventEntry) Is Nothing
            ' Get the start time of the event
            intEventTime = wevControlNames(intEventEntry).StartTime

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
            wevControlNames(intEventEntry).Location = New System.Drawing.Point(intXPosition, intPadding)

            ' Get the height of the control
            intHeight = wevControlNames(intEventEntry).Height

            ' Get the day
            intDay = wevControlNames(intEventEntry).Day

            If intHeight > intLargestHeight(intDay) Then
                ' Get the height
                intLargestHeight(intDay) = intHeight
            End If

            ' Increase the day entry integer by one
            intEventEntry = intEventEntry + 1

            ' Reset the week lines entry integer
            intEntry = 0
        Loop

        ResizeWeekView(intLargestHeight)
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
        intY = wktControlNames(1).Location.Y + wktControlNames(1).Height
        intX = wktControlNames(1).Location.X
        Do Until arrHeight(intEntryHeight) = -1
            If wkvControlNames(intEntryHeight) Is Nothing Then
                Return
            End If
            If arrHeight(intEntryHeight) < intAreaHeight Then
                ' Set the height of the control
                wkvControlNames(intEntryHeight).ControlHeight = intDefaultHeight

                ' Set the position of the conrol
                wkvControlNames(intEntryHeight).Location = New Point(intX, intY)

                ' Add the control height to the y variable
                intY = intY + intDefaultHeight - 1

                ' Refresh the control
                wkvControlNames(intEntryHeight).ControlResize = True
            Else
                ' Set the height of the control
                wkvControlNames(intEntryHeight).ControlHeight = arrHeight(intEntryHeight) + 6

                ' Set the position of the conrol
                wkvControlNames(intEntryHeight).Location = New Point(intX, intY)

                ' Add the control height to the y variable
                intY = intY + arrHeight(intEntryHeight) + 5

                ' Refresh the control
                wkvControlNames(intEntryHeight).ControlResize = True
            End If

            intEntryHeight = intEntryHeight + 1
        Loop

        Array.Clear(arrHeight, 0, 8)
    End Sub

    Function CalculateTime(ByVal intTime As Integer, ByVal intMinutes As Integer)
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

#Region "Combo box update routines"

    Public Sub PopulateCBOOneFieldArray(ByVal cboSource As ComboBox, ByVal intEntryID As Array, ByVal strTable As String, ByVal strSortField As String, ByVal strEntryID As String, ByVal strFieldName As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Clear the source array
        Array.Clear(intEntryID, 0, 1000)

        ' Load in the list
        ' Set combo box to starting entry
        SetStartingEntry(cboSource)

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader


        Do While sqlResults.Read
            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Populate the combo box
            cboSource.Items.Add(sqlResults(strFieldName))
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Public Sub PopulateCBOOneFieldNoArray(ByVal cboSource As ComboBox, ByVal strTable As String, ByVal strEntryID As String, ByVal strFieldName As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        cboSource.Items.Clear()

        ' Load in the list
        ' Set combo box to starting entry
        SetStartingEntry(cboSource)

        ' Read data from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strEntryID, ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        ' Populate the combo box
        Do While sqlResults.Read
            cboSource.Items.Add(sqlResults.Item(strFieldName))
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Public Sub PopulateCBOTwoFieldsArray(ByVal cboSource As ComboBox, ByVal intEntryID As Array, ByVal strTable As String, ByVal strSortField As String, ByVal strEntryID As String, ByVal strFieldName1 As String, ByVal strFieldName2 As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Clear the source array
        Array.Clear(intEntryID, 0, 1000)

        ' Load in the list
        ' Set combo box to starting entry
        SetStartingEntry(cboSource)

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Determin if the second field has data and act accordingly
            If sqlResults(strFieldName2) = Nothing Then
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strFieldName1))
            Else
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strFieldName1) & " - " & sqlResults(strFieldName2))
            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Public Sub PopulateCBOThreeFieldsArray(ByVal cboSource As ComboBox, ByVal intEntryID As Array, ByVal strTable As String, ByVal strSortField As String, ByVal strEntryID As String, ByVal strFieldName1 As String, ByVal strFieldName2 As String, ByVal strFieldName3 As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Clear the source array
        Array.Clear(intEntryID, 0, 1000)

        ' Load in the list
        ' Set combo box to starting entry
        SetStartingEntry(cboSource)

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Determin if the second field has data and act accordingly
            If sqlResults(strFieldName2) = Nothing Then
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strFieldName1))
            ElseIf sqlResults(strFieldName3) = Nothing Then
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strFieldName1) & " - " & sqlResults(strFieldName2))
            Else
                cboSource.Items.Add(sqlResults(strFieldName1) & " - " & sqlResults(strFieldName2) & ", " & sqlResults(strFieldName3))
            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Private Sub SetStartingEntry(ByVal cboSource As ComboBox)
        cboSource.Items.Add("<Please Select>")
        cboSource.SelectedIndex = 0
    End Sub

    Public Sub FindBounds(ByVal strTable As String, ByVal strID As String, ByRef intStart As Integer, ByRef intEnd As Integer)
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

    Public Sub PopulateCBOWeek(ByVal cboSource As ComboBox)
        ' Declare variables
        Dim intWeek As Integer
        Dim intStart As Integer
        Dim intEnd As Integer

        ' Set the starting entry
        SetStartingEntry(cboSource)

        FindBounds("TimetableEntry", "Week", intStart, intEnd)

        ' Populate the combo box
        For intWeek = intStart To intEnd
            cboSource.Items.Add("Week " & intWeek)
        Next
    End Sub

    Public Sub UpdateComboBoxSelection(ByVal cboSource As ComboBox, ByVal intSelectedID As Integer, ByVal intArray As Array)
        Dim intIndex As Integer

        ' Search through the array
        For intIndex = 0 To 1000
            ' See if the ID of the selected entry is the same as a value in the array
            If intArray(intIndex) = intSelectedID Then
                ' Change the selected index of the source combo box
                cboSource.SelectedIndex = intIndex
            End If
        Next

    End Sub

    Public Sub AddToCBOFourFields(ByVal strTable As String, ByVal strColumnOne As String, ByVal strColumnTwo As String, ByVal strColumnThree As String, ByVal strColumnFour As String, ByVal strInputOne As String, ByVal strInputTwo As String, ByVal strInputThree As String, ByVal strInputFour As String)
        ' Database Variables
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlClient.SqlCommand("INSERT INTO " & strTable & "(" & strColumnOne & "," & strColumnTwo & "," & strColumnThree & "," & strColumnFour & ") VALUES ('" & strInputOne & "', '" & strInputTwo & "', '" & strInputThree & "', '" & strInputFour & "')", ctnTimetable)

        ' Execute the insert
        sqlStatement.ExecuteNonQuery()
    End Sub

    Public Sub AddToCBOTwoFields(ByVal strTable As String, ByVal strColumnOne As String, ByVal strColumnTwo As String, ByVal strInputOne As String, ByVal strInputTwo As String)
        ' Database Variables
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlClient.SqlCommand("INSERT INTO " & strTable & "(" & strColumnOne & "," & strColumnTwo & ") VALUES ('" & strInputOne & "', '" & strInputTwo & "')", ctnTimetable)

        ' Execute the insert
        sqlStatement.ExecuteNonQuery()
    End Sub

    Public Sub AddToCBOOneField(ByVal strTable As String, ByVal strColumn As String, ByVal strInput As String)
        ' Database Variables
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlClient.SqlCommand("INSERT INTO " & strTable & "(" & strColumn & ") VALUES ('" & strInput & "')", ctnTimetable)

        ' Execute the insert
        sqlStatement.ExecuteNonQuery()

    End Sub
#End Region

#Region "Time Routines"

    ''' <summary>
    ''' Routines for checking the time and duration.
    ''' </summary>
    ''' <param name="strStartTime"></param>
    ''' <param name="strDuration"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Function CreateEventTime(ByVal strStartTime As String, ByVal strDuration As String) As String
        ' Variables for converting the strings to integers
        Dim intStartTime As Integer
        Dim intDuration As Integer

        ' The variables for creating the finish time
        Dim intFinishTime As Integer
        Dim strFinishTime As String

        ' Convert the strings into integers
        intStartTime = CInt(strStartTime)
        intDuration = CInt(strDuration)

        ' Work out the finish time
        intFinishTime = CalculateTime(intStartTime, intDuration)

        ' Convert the times back to strings and check they are in 24 hr format
        strStartTime = CheckTimes(CStr(intStartTime))
        strFinishTime = CheckTimes(CStr(intFinishTime))

        CreateEventTime = strStartTime & " - " & strFinishTime
        Return CreateEventTime
    End Function

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
