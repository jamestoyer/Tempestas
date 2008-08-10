Module mdlGlobalVariables
    ' The SQL connection
    Public ctnTimetable As System.Data.SqlClient.SqlConnection

    ' Boolean to hold the connection success
    Public boolConnectionStatus As Boolean

    ' String array to hold the users details
    Public strUserInfo(3) As String

    ' Enumeration for accessing data from the user details array
    Public Enum intUserInfo As Integer
        ID = 0
        LoginID = 1
        FirstName = 2
        Surname = 3
    End Enum

    ' Integer array to hold selected timetable details
    Public intTimetable(3) As Integer

    ' Enumeration for accessing data from the timetable details array
    Public Enum intEnumTimetable As Integer
        TimetableID = 0
        YearID = 1
        TermID = 2
        System = 3
    End Enum

    ' Enumeration for deciding which timetable system is being used
    Public Enum intTimetableSystem As Integer
        WeekSystem = 0
        TermSystem = 1
        BothSystem = 2
    End Enum

    ' Array to store Week Button Controls
    Public wkbControls(0) As WeekButton

    ' Array for holding the week view controls
    Public wkvControls(0) As WeekView

    ' Variable to hold the week time control
    Public wktControl As WeekTime

    ' Array to hold the week event view controls
    Public wevControls(0) As WeekEventView

    ' Integer array to hold indexes of the days for the week view controls
    Public intWeekViewEntrys(0) As Integer











    ' Create array variables to store a controls name
    Public devControlNames(100) As DayEventView
    Public wkvControlNames(8) As WeekView
    Public wevControlNames(1000) As WeekEventView
    Public wktControlNames(2) As WeekTime

    ' Array for storing the position of the lines of the week view
    Public intWeekViewLines(25, 1) As Integer

    ' GUI variables
    Public fntHeader As New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel)

End Module
