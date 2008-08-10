Public Class frmSelectRoom

    Private Sub frmSelectRoom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Update the error label
        UpdateErrorLabel("Please select a room")

        ' Populate the item list
        PopulateItemsList()
    End Sub

    Public Sub PopulateItemsList()
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Declare the item index number
        Dim intIndex As Integer = 0

        ' Clear the list box
        lstEvents.Items.Clear()

        ' Resize the array to be 0
        Array.Resize(intEntryID, 0)

        ' Clear the array
        Array.Clear(intEntryID, 0, 0)

        ' Read the data from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Room WHERE UserID = " & strUserInfo(intUserInfo.ID) & " AND TimetableID = " & intTimetable(intEnumTimetable.TimetableID) & " ORDER BY Number", ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Increase the size of the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the EntryID to the array
            intEntryID(intIndex) = sqlResults!RoomID

            If sqlResults!Department = "" Then
                ' Add the data to the list box
                lstEvents.Items.Add(sqlResults!Number)
            Else
                ' Add the data to the list box
                lstEvents.Items.Add(sqlResults!Number & " - " & sqlResults!Department)
            End If

            ' Increase the index by one
            intIndex = intIndex + 1
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        ' Call the modify button event
        ModifyButtonClicked(frmUpdateRoom)

        ' Repopulate the items list
        PopulateItemsList()
    End Sub
End Class
