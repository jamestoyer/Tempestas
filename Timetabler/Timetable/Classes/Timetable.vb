''' <summary>
''' Provides methods, constants and instances for manipulating timetables. Not inheritable
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class Timetable
    ''' <summary>
    ''' Represents an instance of the basic timetable information
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class TimetableInformation
#Region "Constants and Variables"
        ''' <summary>
        ''' Enumeration for accessing data from the timetable information array
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum Timetable As Integer
            ''' <summary>
            ''' The array value for the timetable ID
            ''' </summary>
            ''' <remarks></remarks>
            ID = 0
            ''' <summary>
            ''' The array value for the timetable name
            ''' </summary>
            ''' <remarks></remarks>
            Name = 1
            ''' <summary>
            ''' The array value for the user ID
            ''' </summary>
            ''' <remarks></remarks>
            UserID = 2
            ''' <summary>
            ''' The array value for the system type
            ''' </summary>
            ''' <remarks></remarks>
            System = 3
        End Enum

        ''' <summary>
        ''' Object array to store the timetable information
        ''' </summary>
        ''' <remarks></remarks>
        Private strInformation(3) As String
#End Region

#Region "Properties"
        ''' <summary>
        ''' Gets the ID number of the timetable
        ''' </summary>
        ''' <value>The ID number of the timetable</value>
        ''' <returns>The ID number of the timetable</returns>
        ''' <remarks></remarks>
        Public Property ID() As Integer
            Get
                ' Return the ID number
                Return CInt(strInformation(Timetable.ID))
            End Get
            Set(ByVal value As Integer)
                ' Set the value of the ID
                strInformation(Timetable.ID) = CStr(value)
            End Set
        End Property

        ''' <summary>
        ''' Gets the name of the timetable
        ''' </summary>
        ''' <value>The string of the timetable</value>
        ''' <returns>A string of the timetable name</returns>
        ''' <remarks></remarks>
        Public Property Name() As String
            Get
                Return strInformation(Timetable.Name)
            End Get
            Set(ByVal value As String)
                strInformation(Timetable.Name) = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the user ID for the timetable
        ''' </summary>
        ''' <value>The integer of the user ID</value>
        ''' <returns>The integer of the user ID</returns>
        ''' <remarks></remarks>
        Public Property UserID() As Integer
            Get
                Return CInt(strInformation(Timetable.UserID))
            End Get
            Set(ByVal value As Integer)
                strInformation(Timetable.UserID) = CStr(value)
            End Set
        End Property

        ''' <summary>
        ''' Gets the integer that represents system type of the timetable
        ''' </summary>
        ''' <value>The integer value of the system type</value>
        ''' <returns>The integer value of the system type</returns>
        ''' <remarks></remarks>
        Public Property System() As Integer
            Get
                Return CInt(strInformation(Timetable.System))
            End Get
            Set(ByVal value As Integer)
                strInformation(Timetable.System) = CStr(value)
            End Set
        End Property

        ''' <summary>
        ''' Gets an array of information for the timetable
        ''' </summary>
        ''' <value>An array to update the timetable information</value>
        ''' <returns>The array of timetable information</returns>
        ''' <remarks></remarks>
        Public Property Information() As Array
            Get
                Return strInformation
            End Get
            Set(ByVal value As Array)
                strInformation = value
            End Set
        End Property
#End Region

#Region "New Methods"
        ''' <summary>
        ''' Initialises a new instance of the Timetable.TimetableInformation class
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TimetableInformation class
        ''' </summary>
        ''' <param name="strName">The name of the timetable as a string</param>
        ''' <param name="intSystem">The system of the the timetable as an integer</param>
        ''' <param name="intUserID">The associated user of the timetable as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal strName As String, ByVal intSystem As Integer, ByVal intUserID As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next

            ' Set the given values to the array
            strInformation(Timetable.Name) = strName
            strInformation(Timetable.System) = intSystem
            strInformation(Timetable.UserID) = intUserID
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TimetableInformation class
        ''' </summary>
        ''' <param name="strName">The name of the timetable as a string</param>
        ''' <param name="intSystem">The system of the the timetable as an integer</param>
        ''' <param name="intUserID">The associated user of the timetable as an integer</param>
        ''' <param name="intID">The ID number of the timetable as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal strName As String, ByVal intSystem As Integer, ByVal intUserID As Integer, ByVal intID As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next

            ' Set the given values to the array
            strInformation(Timetable.Name) = strName
            strInformation(Timetable.System) = intSystem
            strInformation(Timetable.UserID) = intUserID
            strInformation(Timetable.ID) = intID
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Represents an instance of a year
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class YearInformation
#Region "Constants and Variables"
        ''' <summary>
        ''' String array to store a years information
        ''' </summary>
        ''' <remarks></remarks>
        Private strInformation(3) As String

        ''' <summary>
        ''' Enumeration for accessing data from the year information array
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum Year
            ''' <summary>
            ''' The ID of the year
            ''' </summary>
            ''' <remarks></remarks>
            ID = 0
            ''' <summary>
            ''' The number of the year
            ''' </summary>
            ''' <remarks></remarks>
            Number = 1
            ''' <summary>
            ''' The name of the year
            ''' </summary>
            ''' <remarks></remarks>
            Name = 2
            ''' <summary>
            ''' The related timetable ID of the year
            ''' </summary>
            ''' <remarks></remarks>
            TimetableID = 3
        End Enum
#End Region

#Region "Properties"
        ''' <summary>
        ''' Gets the ID number of the year
        ''' </summary>
        ''' <value>The ID number of the year</value>
        ''' <returns>The ID number of the year</returns>
        ''' <remarks></remarks>
        Public Property ID() As Integer
            Get
                Return strInformation(Year.ID)
            End Get
            Set(ByVal value As Integer)
                strInformation(Year.ID) = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the name of the year
        ''' </summary>
        ''' <value>The string of the year</value>
        ''' <returns>A string of the year name</returns>
        ''' <remarks></remarks>
        Public Property Name() As String
            Get
                Return strInformation(Year.Name)
            End Get

            Set(ByVal value As String)
                strInformation(Year.Name) = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the year number for the timetable
        ''' </summary>
        ''' <value>The integer of the year number</value>
        ''' <returns>The integer of the year number</returns>
        ''' <remarks></remarks>
        Public Property YearNumber() As Integer
            Get
                Return CInt(strInformation(Year.Number))
            End Get
            Set(ByVal value As Integer)
                strInformation(Year.Number) = CStr(value)
            End Set
        End Property

        ''' <summary>
        ''' Gets the integer that represents the timetable ID of the year
        ''' </summary>
        ''' <value>The integer value of the timetable ID</value>
        ''' <returns>The integer value of the timetable ID</returns>
        ''' <remarks></remarks>
        Public Property TimetableID() As Integer
            Get
                Return CInt(strInformation(Year.TimetableID))
            End Get
            Set(ByVal value As Integer)
                strInformation(Year.TimetableID) = CStr(value)
            End Set
        End Property

        ''' <summary>
        ''' Gets an array of information for the year
        ''' </summary>
        ''' <value>An array to update the year information</value>
        ''' <returns>The array of year information</returns>
        ''' <remarks></remarks>
        Public Property Information() As Array
            Get
                Return strInformation
            End Get
            Set(ByVal value As Array)
                strInformation = value
            End Set
        End Property

#End Region

#Region "New Methods"
        ''' <summary>
        ''' Initialises a new instance of the Timetable.YearInformation class
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.YearInformation class
        ''' </summary>
        ''' <param name="intNumber">The year number of the timetable as an integer</param>
        ''' <param name="strName">The name of the year as a string</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal strName As String)
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next

            ' Set the given values to the array
            strInformation(Year.Number) = intNumber
            strInformation(Year.Name) = strName
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.YearInformation class
        ''' </summary>
        ''' <param name="intID">The ID number of the year as an integer</param>
        ''' <param name="intNumber">The year number of the timetable as an integer</param>
        ''' <param name="strName">The name of the year as a string</param>
        ''' <param name="intTimetableID">The timetable ID of the year as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal strName As String, ByVal intID As Integer, ByVal intTimetableID As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 3
                strInformation(i) = Nothing
            Next

            ' Set the given values to the array
            strInformation(Year.Number) = intNumber
            strInformation(Year.Name) = strName
            strInformation(Year.ID) = intID
            strInformation(Year.TimetableID) = intTimetableID
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' Represents and instance of a term
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class TermInformation
        ''' <summary>
        ''' Object array to store a terms information
        ''' </summary>
        ''' <remarks></remarks>
        Private objInformation(7) As Object

        ''' <summary>
        ''' Enumeration for accessing data from the term information array
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum Term As Integer
            ''' <summary>
            ''' The ID of the term
            ''' </summary>
            ''' <remarks></remarks>
            ID = 0
            ''' <summary>
            ''' The number of the term
            ''' </summary>
            ''' <remarks></remarks>
            Number = 1
            ''' <summary>
            ''' The start date of the term
            ''' </summary>
            ''' <remarks></remarks>
            StartDate = 2
            ''' <summary>
            ''' The finish date of the term
            ''' </summary>
            ''' <remarks></remarks>
            FinishDate = 3
            ''' <summary>
            ''' The start week of the term
            ''' </summary>
            ''' <remarks></remarks>
            WeekStart = 4
            ''' <summary>
            ''' The end week of the term
            ''' </summary>
            ''' <remarks></remarks>
            WeekEnd = 5
            ''' <summary>
            ''' The related year ID of the term
            ''' </summary>
            ''' <remarks></remarks>
            YearID = 6
            ''' <summary>
            ''' The number of weeks in the term
            ''' </summary>
            ''' <remarks></remarks>
            Weeks = 7
        End Enum

        Public Property ID() As Integer
            Get
                Return objInformation(Term.ID)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.ID) = value
            End Set
        End Property

        Public Property Number() As Integer
            Get
                Return objInformation(Term.Number)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.Number) = value
            End Set
        End Property

        Public Property StartDate() As Date
            Get
                Return objInformation(Term.StartDate)
            End Get
            Set(ByVal value As Date)
                objInformation(Term.StartDate) = value
            End Set
        End Property

        Public Property FinishDate() As Date
            Get
                Return objInformation(Term.FinishDate)
            End Get
            Set(ByVal value As Date)
                objInformation(Term.FinishDate) = value
            End Set
        End Property

        Public Property WeekStart() As Integer
            Get
                Return objInformation(Term.WeekStart)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.WeekStart) = value
            End Set
        End Property

        Public Property WeekEnd() As Integer
            Get
                Return objInformation(Term.WeekEnd)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.WeekEnd) = value
            End Set
        End Property

        Public Property YearID() As Integer
            Get
                Return objInformation(Term.YearID)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.YearID) = value
            End Set
        End Property

        Public Property Weeks() As Integer
            Get
                Return objInformation(Term.Weeks)
            End Get
            Set(ByVal value As Integer)
                objInformation(Term.Weeks) = value
            End Set
        End Property

#Region "New Methods"
        ''' <summary>
        ''' Initialises a new instance of the Timetable.TermInformation class
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            ' Instantiate the information array
            For i As Integer = 0 To 7
                objInformation(i) = Nothing
            Next
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TermInformation class
        ''' </summary>
        ''' <param name="intNumber">The term number of the term as an integer</param>
        ''' <param name="intWeekStart">The start week of the term as an integer</param>
        ''' <param name="intWeekLength">The length of the term as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal intWeekStart As Integer, ByVal intWeekLength As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 7
                objInformation(i) = Nothing
            Next

            ' Set the given values to the array
            objInformation(Term.Number) = intNumber
            objInformation(Term.WeekStart) = intWeekStart
            objInformation(Term.Weeks) = intWeekLength
            objInformation(Term.WeekEnd) = (intWeekStart + intWeekLength - 1)

        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TermInformation class
        ''' </summary>
        ''' <param name="intNumber">The term number of the term as an integer</param>
        ''' <param name="intWeekStart">The start week of the term as an integer</param>
        ''' <param name="intWeekLength">The length of the term as an integer</param>
        ''' <param name="intWeekEnd">The end week of the term as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal intWeekStart As Integer, ByVal intWeekLength As Integer, ByVal intWeekEnd As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 7
                objInformation(i) = Nothing
            Next

            ' Set the given values to the array
            objInformation(Term.Number) = intNumber
            objInformation(Term.WeekStart) = intWeekStart
            objInformation(Term.Weeks) = intWeekLength
            objInformation(Term.WeekEnd) = intWeekEnd

        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TermInformation class
        ''' </summary>
        ''' <param name="intNumber">The term number of the term as an integer</param>
        ''' <param name="intWeekStart">The start week of the term as an integer</param>
        ''' <param name="intWeekLength">The length of the term as an integer</param>
        ''' <param name="intWeekEnd">The end week of the term as an integer</param>
        ''' <param name="datStartDate">The start date of the term as a date</param>
        ''' <param name="datFinishDate">The finish date of the term as a date</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal intWeekStart As Integer, ByVal intWeekLength As Integer, ByVal intWeekEnd As Integer, ByVal datStartDate As Date, ByVal datFinishDate As Date)
            ' Instantiate the information array
            For i As Integer = 0 To 7
                objInformation(i) = Nothing
            Next

            ' Set the given values to the array
            objInformation(Term.Number) = intNumber
            objInformation(Term.WeekStart) = intWeekStart
            objInformation(Term.Weeks) = intWeekLength
            objInformation(Term.WeekEnd) = intWeekEnd
            objInformation(Term.StartDate) = datStartDate
            objInformation(Term.FinishDate) = datFinishDate
        End Sub

        ''' <summary>
        ''' Initialises a new instance of the Timetable.TermInformation class
        ''' </summary>
        ''' <param name="intNumber">The term number of the term as an integer</param>
        ''' <param name="intWeekStart">The start week of the term as an integer</param>
        ''' <param name="intWeekLength">The length of the term as an integer</param>
        ''' <param name="intWeekEnd">The end week of the term as an integer</param>
        ''' <param name="datStartDate">The start date of the term as a date</param>
        ''' <param name="datFinishDate">The finish date of the term as a date</param>
        ''' <param name="intID">The ID of the term as an integer</param>
        ''' <param name="intYearID">The year ID of the term as an integer</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal intNumber As Integer, ByVal intWeekStart As Integer, ByVal intWeekLength As Integer, ByVal intWeekEnd As Integer, ByVal datStartDate As Date, ByVal datFinishDate As Date, ByVal intID As Integer, ByVal intYearID As Integer)
            ' Instantiate the information array
            For i As Integer = 0 To 7
                objInformation(i) = Nothing
            Next

            ' Set the given values to the array
            objInformation(Term.Number) = intNumber
            objInformation(Term.WeekStart) = intWeekStart
            objInformation(Term.Weeks) = intWeekLength
            objInformation(Term.WeekEnd) = intWeekEnd
            objInformation(Term.StartDate) = datStartDate
            objInformation(Term.FinishDate) = datFinishDate
            objInformation(Term.ID) = intID
            objInformation(Term.YearID) = intYearID
        End Sub
#End Region

#Region "Other Methods"

#End Region
    End Class

End Class
