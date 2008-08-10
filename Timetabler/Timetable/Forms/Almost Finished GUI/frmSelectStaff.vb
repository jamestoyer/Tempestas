Public Class frmSelectStaff

    Private Sub frmSelectStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Update the error label
        UpdateErrorLabel("Please select a member of staff")

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
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM Staff WHERE UserID = " & strUserInfo(intUserInfo.ID) & " AND TimetableID = " & intTimetable(intEnumTimetable.TimetableID) & " ORDER BY Initials", ctnTimetable)
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Increase the size of the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the EntryID to the array
            intEntryID(intIndex) = sqlResults!StaffID

            Select Case sqlResults!Salutation
                Case Is = ""
                    If (sqlResults!FirstName <> "" And sqlResults!Surname <> "") Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!FirstName & " " & sqlResults!Surname)
                    ElseIf sqlResults!FirstName <> "" Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!FirstName)
                    ElseIf sqlResults!Surname <> "" Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!Surname)
                    Else
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials)
                    End If
                Case Else
                    If (sqlResults!FirstName <> "" And sqlResults!Surname <> "") Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!Salutation & " " & sqlResults!FirstName & " " & sqlResults!Surname)
                    ElseIf sqlResults!FirstName <> "" Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!FirstName)
                    ElseIf sqlResults!Surname <> "" Then
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials & " - " & sqlResults!Salutation & " " & sqlResults!Surname)
                    Else
                        ' Add the data to the list box
                        lstEvents.Items.Add(sqlResults!Initials)
                    End If
            End Select

            ' Increase the index by one
            intIndex = intIndex + 1
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        ' Call the modify button event
        ModifyButtonClicked(frmUpdateStaff)

        ' Repopulate the items list
        PopulateItemsList()
    End Sub
End Class
