Public Class frmSelectContact

    Private Sub frmSelectContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Update the error label
        UpdateErrorLabel("Please select a contact")

        ' Populate the item list
        PopulateItemsList()
    End Sub

    Public Sub PopulateItemsList()
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Declare the item index number
        Dim intIndex As Integer = 0

        ' Colour variable to convert the stored ARGB value to a known colour
        Dim clrColour As Color

        ' Clear the list box
        lstEvents.Items.Clear()

        ' Resize the array to be 0
        Array.Resize(intEntryID, 0)

        ' Clear the array
        Array.Clear(intEntryID, 0, 0)

        ' Read the data from the database
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Contact WHERE UserID = " & strUserInfo(intUserInfo.ID) & " AND TimetableID = " & intTimetable(intEnumTimetable.TimetableID) & " ORDER BY Type", ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Increase the size of the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the EntryID to the array
            intEntryID(intIndex) = sqlResults!ContactID

            ' Set the colour from the result to the colour
            clrColour = ConvertTextToColour(sqlResults!Colour)

            If clrColour.ToKnownColor > 0 Then
                ' Add the data to the list box
                lstEvents.Items.Add(sqlResults!Type & ", Colour: " & clrColour.Name)
            Else
                ' Add the data to the list box
                lstEvents.Items.Add(sqlResults!Type & ", Colour: " & clrColour.R & "," & clrColour.G & "," & clrColour.B)
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
        ModifyButtonClicked(frmUpdateContact)

        ' Repopulate the items list
        PopulateItemsList()
    End Sub
End Class
