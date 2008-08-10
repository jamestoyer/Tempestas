Module mdlGlobalVariables
    ' The SQL connection
    Public ctnTimetable As System.Data.SqlClient.SqlConnection

    ' The original point the mouse down function is called when moving the form
    Public pntMouseLocation As Point

    ' Create array variables to store a controls name
    Public devControlNames(100) As DayEventView
    Public wkbControls(0) As WeekButton
    Public wkvControlNames(8) As WeekView
    Public wevControlNames(1000) As WeekEventView
    Public wktControlNames(2) As WeekTime

    ' Array for storing the position of the lines of the week view
    Public intWeekViewLines(25, 1) As Integer

    ' Create arrays for storing information about the combo boxes on the add entry form
    Public intModule(1000) As Integer
    Public intContact(1000) As Integer
    Public intStaff(1000) As Integer
    Public intRoom(1000) As Integer

    ' Create arrays for storing user information
    Public intUserName(1000) As Integer

    ' The boolean to determin if a correct connection string was constructed
    Public boolErrorShutDown As Boolean = False

    ' GUI variables
    Public fntHeader As New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel)

    ' User id variable
    Public strLoginID As String

    ' Timetable ID variable
    Public intTimetableID As Integer

End Module
