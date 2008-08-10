Imports System.Data.SqlClient

Module mdlDatabaseRelated

#Region "Connections events"
    Function OpenConnection()

        ' Connect to the database. Return True on success
        Dim strConnection As String

        ' Build the connection string
        strConnection = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & My.Settings.dbPath & ";Integrated Security=True;User Instance=True"

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

    ' The function which closes the connection to the database
    Function CloseConnection() As Boolean
        ' Attempt to close the database
        Try
            ' Close the database
            ctnTimetable.Close()

            ' Success
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
#End Region

#Region "DB Addition"
    ''' <summary> Procedures that add data to the database </summary>

    Public Sub AddThreeFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String)
        ' Sql statement variable
        Dim sqlStatement As SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlCommand("INSERT INTO " & strTableName & "(" & strColumnOne & ", " & strColumnTwo & ", " & strColumnThree & ") VALUES ('" & strValueOne & "', '" & strValueTwo & "', '" & strValueThree & "')", ctnTimetable)

        ' Insert the values into the database
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing
    End Sub

    Public Sub AddFourFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String)
        ' Sql statement variable
        Dim sqlStatement As SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlCommand("INSERT INTO " & strTableName & "(" & strColumnOne & ", " & strColumnTwo & ", " & strColumnThree & ", " & strColumnFour & ") VALUES ('" & strValueOne & "', '" & strValueTwo & "', '" & strValueThree & "', '" & strValueFour & "')", ctnTimetable)

        ' Insert the values into the database
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing
    End Sub

    Public Sub AddFiveFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String)
        ' Sql statement variable
        Dim sqlStatement As SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlCommand("INSERT INTO " & strTableName & "(" & strColumnOne & ", " & strColumnTwo & ", " & strColumnThree & ", " & strColumnFour & ", " & strColumnFive & ") VALUES ('" & strValueOne & "', '" & strValueTwo & "', '" & strValueThree & "', '" & strValueFour & "', '" & strValueFive & "')", ctnTimetable)

        ' Insert the values into the database
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing
    End Sub

    Public Sub AddSevenFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String, ByVal strColumnSix As String, ByVal strValueSix As String, ByVal strColumnSeven As String, ByVal strValueSeven As String)
        ' Sql statement variable
        Dim sqlStatement As SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlCommand("INSERT INTO " & strTableName & "(" & strColumnOne & ", " & strColumnTwo & ", " & strColumnThree & ", " & strColumnFour & ", " & strColumnFive & ", " & strColumnSix & ", " & strColumnSeven & ") VALUES ('" & strValueOne & "', '" & strValueTwo & "', '" & strValueThree & "', '" & strValueFour & "', '" & strValueFive & "', '" & strValueSix & "', '" & strValueSeven & "')", ctnTimetable)

        ' Insert the values into the database
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing
    End Sub

    Public Sub AddEightFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String, ByVal strColumnSix As String, ByVal strValueSix As String, ByVal strColumnSeven As String, ByVal strValueSeven As String, ByVal strColumnEight As String, ByVal strValueEight As String)
        ' Sql statement variable
        Dim sqlStatement As SqlCommand

        ' Create the statement to add to the database
        sqlStatement = New SqlCommand("INSERT INTO " & strTableName & "(" & strColumnOne & ", " & strColumnTwo & ", " & strColumnThree & ", " & strColumnFour & ", " & strColumnFive & ", " & strColumnSix & ", " & strColumnSeven & ", " & strColumnEight & ") VALUES ('" & strValueOne & "', '" & strValueTwo & "', '" & strValueThree & "', '" & strValueFour & "', '" & strValueFive & "', '" & strValueSix & "', '" & strValueSeven & "', '" & strValueEight & "')", ctnTimetable)

        ' Insert the values into the database
        sqlStatement.ExecuteNonQuery()

        ' Reset the statement
        sqlStatement = Nothing
    End Sub
#End Region

#Region "Populating Combo Boxes"

#Region "With Array"
    ' Event for populating a combo box with one field and an array to sort them
    Public Sub ComboOneFieldWithArray(ByVal cboSource As ComboBox, ByRef intEntryID() As Integer, ByVal strTable As String, ByVal strSortField As String, ByVal strDatabaseEntryID As String, ByVal strSearchColumn As String, ByVal strSearchID As String, ByVal strPrimaryFieldName As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Resize the array to 0
        Array.Resize(intEntryID, 1)

        ' Add the first item to the combo box
        cboSource.Items.Add("<Please Select>")

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " WHERE " & strSearchColumn & " = " & strSearchID & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Resize the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strDatabaseEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Populate the combo box
            cboSource.Items.Add(sqlResults(strPrimaryFieldName))
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the selected index to 0
        cboSource.SelectedIndex = 0
    End Sub

    ' Event for populating a combo box with two fields and an array to sort them
    Public Sub ComboTwoFieldsWithArray(ByVal cboSource As ComboBox, ByRef intEntryID() As Integer, ByVal strTable As String, ByVal strSortField As String, ByVal strDatabaseEntryID As String, ByVal strSearchColumn As String, ByVal strSearchID As String, ByVal strPrimaryFieldName As String, ByVal strSecondaryFieldName As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Resize the array to 0
        Array.Resize(intEntryID, 1)

        ' Add the first item to the combo box
        cboSource.Items.Add("<Please Select>")

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " WHERE " & strSearchColumn & " = " & strSearchID & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Resize the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strDatabaseEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Determin if the second field has data and act accordingly
            If sqlResults(strSecondaryFieldName) = Nothing Then
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strPrimaryFieldName))
            Else
                ' Populate the combo box
                cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName))
            End If
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the selected index to 0
        cboSource.SelectedIndex = 0
    End Sub

    ' Event for populating a combo box with four fields and an array to sort them
    Public Sub ComboFourFieldsWithArray(ByVal cboSource As ComboBox, ByRef intEntryID() As Integer, ByVal strTable As String, ByVal strSortField As String, ByVal strDatabaseEntryID As String, ByVal strSearchColumn As String, ByVal strSearchID As String, ByVal strPrimaryFieldName As String, ByVal strSecondaryFieldName1 As String, ByVal strSecondaryFieldName2 As String, ByVal strSecondaryFieldName3 As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Create a variable for the index of the combo box
        Dim intIndex As Integer = 1

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Resize the array to 0
        Array.Resize(intEntryID, 1)

        ' Add the first item to the combo box
        cboSource.Items.Add("<Please Select>")

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " WHERE " & strSearchColumn & " = " & strSearchID & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Resize the array by one
            Array.Resize(intEntryID, intEntryID.Length + 1)

            ' Set the ID to the array
            intEntryID(intIndex) = sqlResults(strDatabaseEntryID)

            ' Add one to the Index integer
            intIndex = intIndex + 1

            ' Determin if the secondary fields have data and act accordingly
            Select Case sqlResults(strSecondaryFieldName1)
                Case Is = ""
                    If (sqlResults(strSecondaryFieldName2) <> "" And sqlResults(strSecondaryFieldName3) <> "") Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName2) & " " & sqlResults(strSecondaryFieldName3))
                    ElseIf sqlResults(strSecondaryFieldName2) <> "" Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName2))
                    ElseIf sqlResults(strSecondaryFieldName3) <> "" Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName3))
                    Else
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName))
                    End If
                Case Else
                    If (sqlResults(strSecondaryFieldName2) <> "" And sqlResults(strSecondaryFieldName3) <> "") Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName1) & " " & sqlResults(strSecondaryFieldName2) & " " & sqlResults(strSecondaryFieldName3))
                    ElseIf sqlResults(strSecondaryFieldName2) <> "" Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName1) & " " & sqlResults(strSecondaryFieldName2))
                    ElseIf sqlResults(strSecondaryFieldName3) <> "" Then
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName1) & " " & sqlResults(strSecondaryFieldName3))
                    Else
                        ' Add the data to the list box
                        cboSource.Items.Add(sqlResults(strPrimaryFieldName) & " - " & sqlResults(strSecondaryFieldName1))
                    End If
            End Select
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the selected index to 0
        cboSource.SelectedIndex = 0
    End Sub
#End Region

#Region "Without Array"
    ' Event for populating a combo box with one field
    Public Sub ComboOneField(ByVal cboSource As ComboBox, ByVal strTable As String, ByVal strSortField As String, ByVal strDatabaseEntryID As String, ByVal strPrimaryFieldName As String)
        ' Database Variables
        Dim sqlResults As SqlClient.SqlDataReader
        Dim sqlStatement As SqlClient.SqlCommand

        ' Clear the source combo box of data
        cboSource.Items.Clear()

        ' Add the first item to the combo box
        cboSource.Items.Add("<Please Select>")

        ' Construct the sql read statement
        sqlStatement = New SqlClient.SqlCommand("SELECT * FROM " & strTable & " ORDER BY " & strSortField, ctnTimetable)

        ' Read from the database
        sqlResults = sqlStatement.ExecuteReader

        Do While sqlResults.Read
            ' Populate the combo box
            cboSource.Items.Add(sqlResults(strPrimaryFieldName))
        Loop

        ' Reset the variables
        sqlStatement = Nothing
        sqlResults.Close()

        ' Set the selected index to 0
        cboSource.SelectedIndex = 0
    End Sub
#End Region

#End Region
End Module
