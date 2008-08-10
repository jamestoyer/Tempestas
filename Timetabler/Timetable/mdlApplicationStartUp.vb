Module mdlApplicationStartUp
    Public Sub FirstTimeStartUp()
        ' Timetable name variables
        Dim strTempTimetableVersionName As String
        Dim strTempTimetableLocation As String

        ' Connection boolean
        Dim boolConnect As Boolean = False

        ' Construct the temporary timetable name
        strTempTimetableVersionName = "dbTimetables" & My.Settings.TimetableVersion & "temp.mdf"

        ' Contstruct the location of the temporary timetable
        strTempTimetableLocation = My.Application.Info.DirectoryPath & "\Data\" & strTempTimetableVersionName

        ' Set the actual path of the timetable to the setting
        My.Settings.ConnectionString = strTempTimetableLocation

        If boolConnect = False Then
            ' Attempt to connect to the databse
            boolConnect = OpenConnection()

            ' Inform the user of not being able to find the database file
            MessageBox.Show("The program has failed to connect to the timetable database", "Connection Error")

            ' Load the location selection form
            frmFindDatabase.ShowDialog()

            ' Check to see if the form was cancelled and if so exit the application
            If frmFindDatabase.DialogResult = Windows.Forms.DialogResult.Abort Then
                ' Set the error shut down boolean to true
                boolErrorShutDown = True
                Return
            End If

            ' Set the first time starting boolean to false
            My.Settings.FirstTimeStartup = False
        End If

    End Sub

    Public Sub NormalStartUp()
        ' Connection boolean
        Dim boolConnect As Boolean = False

        ' Attempt to connect to the database
        boolConnect = OpenConnection()

        If boolConnect = False Then
            ' Load the location selection form
            frmFindDatabase.ShowDialog()

            ' Check to see if the form was cancelled and if so exit the application
            If frmFindDatabase.DialogResult = Windows.Forms.DialogResult.Abort Then
                ' Set the error shut down boolean to true
                boolErrorShutDown = True
                Return
            End If
        End If
    End Sub
End Module
