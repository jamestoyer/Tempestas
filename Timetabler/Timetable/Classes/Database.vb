' Imports the sql client class
Imports System.Data.SqlClient

''' <summary>
''' Methods for interfacing with the Tempestas database
''' </summary>
''' <remarks></remarks>
Public Class Database
    ''' <summary>
    ''' Methods for adding information to the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Addition
        ''' <summary>
        ''' Function for adding three fields to the database
        ''' </summary>
        ''' <param name="strTableName">The name of the table to add to</param>
        ''' <param name="strColumnOne">The name of the first column to add to</param>
        ''' <param name="strValueOne">The value to add to the first column</param>
        ''' <param name="strColumnTwo">The name of the second column to add to</param>
        ''' <param name="strValueTwo">The value to add to the second column</param>
        ''' <param name="strColumnThree">The name of the third column to add to</param>
        ''' <param name="strValueThree">The value to add to the third column</param>
        ''' <returns>Returns true if successful, or an error string if not</returns>
        ''' <remarks></remarks>
        Public Shared Function ThreeFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String)
            ' Sql command variable
            Dim sqlAddition As New SqlCommand

            ' Set the command text property
            sqlAddition.CommandText = "INSERT INTO @Table "
            sqlAddition.CommandText += "(@Col1, @Col2, @Col3) "
            sqlAddition.CommandText += "VALUES ('@Value1', '@Value2', '@Value3')"

            ' Designate the command type
            sqlAddition.CommandType = CommandType.Text

            ' Set the connection property
            sqlAddition.Connection = ctnTimetable

            ' Add the parameters to the command
            sqlAddition.Parameters.Add(CreateParameter("@Table", strTableName))
            sqlAddition.Parameters.Add(CreateParameter("@Col1", strColumnOne))
            sqlAddition.Parameters.Add(CreateParameter("@Col2", strColumnTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Col3", strColumnThree))
            sqlAddition.Parameters.Add(CreateParameter("@Value1", strValueOne))
            sqlAddition.Parameters.Add(CreateParameter("@Value2", strValueTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Value3", strValueThree))

            ' Create error handling
            Try
                ' Execute the command
                sqlAddition.ExecuteNonQuery()

                ' Return true
                Return True
            Catch ex As Exception
                ' Send the error to a string and return it
                Return ex.ToString
            End Try
        End Function

        ''' <summary>
        ''' Function for adding four fields to the database
        ''' </summary>
        ''' <param name="strTableName">The name of the table to add to</param>
        ''' <param name="strColumnOne">The name of the first column to add to</param>
        ''' <param name="strValueOne">The value to add to the first column</param>
        ''' <param name="strColumnTwo">The name of the second column to add to</param>
        ''' <param name="strValueTwo">The value to add to the second column</param>
        ''' <param name="strColumnThree">The name of the third column to add to</param>
        ''' <param name="strValueThree">The value to add to the third column</param>
        ''' <param name="strColumnFour">The name of the fourth column to add to</param>
        ''' <param name="strValueFour">The value to add to the fourth column</param>
        ''' <returns>Returns true if successful, or an error string if not</returns>
        ''' <remarks></remarks>
        Public Shared Function FourFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String)
            ' Sql command variable
            Dim sqlAddition As SqlCommand

            ' Instantiate the command
            sqlAddition = New SqlCommand

            ' Set the command text property
            sqlAddition.CommandText = "INSERT INTO @Table "
            sqlAddition.CommandText += "(@Col1, @Col2, @Col3, @Col4) "
            sqlAddition.CommandText += "VALUES ('@Value1', '@Value2', '@Value3', '@Value4')"

            ' Designate the command type
            sqlAddition.CommandType = CommandType.Text

            ' Set the connection property
            sqlAddition.Connection = ctnTimetable

            ' Add the parameters to the command
            sqlAddition.Parameters.Add(CreateParameter("@Table", strTableName))
            sqlAddition.Parameters.Add(CreateParameter("@Col1", strColumnOne))
            sqlAddition.Parameters.Add(CreateParameter("@Col2", strColumnTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Col3", strColumnThree))
            sqlAddition.Parameters.Add(CreateParameter("@Col4", strColumnFour))
            sqlAddition.Parameters.Add(CreateParameter("@Value1", strValueOne))
            sqlAddition.Parameters.Add(CreateParameter("@Value2", strValueTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Value3", strValueThree))
            sqlAddition.Parameters.Add(CreateParameter("@Value4", strValueFour))

            ' Create error handling
            Try
                ' Execute the command
                sqlAddition.ExecuteNonQuery()

                ' Return true
                Return True
            Catch ex As Exception
                ' Send the error to a string and return it
                Return ex.ToString
            End Try
        End Function

        ''' <summary>
        ''' Function for adding five fields to the database
        ''' </summary>
        ''' <param name="strTableName">The name of the table to add to</param>
        ''' <param name="strColumnOne">The name of the first column to add to</param>
        ''' <param name="strValueOne">The value to add to the first column</param>
        ''' <param name="strColumnTwo">The name of the second column to add to</param>
        ''' <param name="strValueTwo">The value to add to the second column</param>
        ''' <param name="strColumnThree">The name of the third column to add to</param>
        ''' <param name="strValueThree">The value to add to the third column</param>
        ''' <param name="strColumnFour">The name of the fourth column to add to</param>
        ''' <param name="strValueFour">The value to add to the fourth column</param>
        ''' <param name="strColumnFive">The name of the fifth column to add to</param>
        ''' <param name="strValueFive">The value to add to the fifth column</param>
        ''' <returns>Returns true if successful, or an error string if not</returns>
        ''' <remarks></remarks>
        Public Shared Function FiveFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String)
            ' Sql command variable
            Dim sqlAddition As SqlCommand

            ' Instantiate the command
            sqlAddition = New SqlCommand

            ' Set the command text property
            sqlAddition.CommandText = "INSERT INTO @Table "
            sqlAddition.CommandText += "(@Col1, @Col2, @Col3, @Col4, @Col5) "
            sqlAddition.CommandText += "VALUES ('@Value1', '@Value2', '@Value3', '@Value4', '@Value5')"

            ' Designate the command type
            sqlAddition.CommandType = CommandType.Text

            ' Set the connection property
            sqlAddition.Connection = ctnTimetable

            ' Add the parameters to the command
            sqlAddition.Parameters.Add(CreateParameter("@Table", strTableName))
            sqlAddition.Parameters.Add(CreateParameter("@Col1", strColumnOne))
            sqlAddition.Parameters.Add(CreateParameter("@Col2", strColumnTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Col3", strColumnThree))
            sqlAddition.Parameters.Add(CreateParameter("@Col4", strColumnFour))
            sqlAddition.Parameters.Add(CreateParameter("@Col5", strColumnFive))
            sqlAddition.Parameters.Add(CreateParameter("@Value1", strValueOne))
            sqlAddition.Parameters.Add(CreateParameter("@Value2", strValueTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Value3", strValueThree))
            sqlAddition.Parameters.Add(CreateParameter("@Value4", strValueFour))
            sqlAddition.Parameters.Add(CreateParameter("@Value5", strValueFive))

            ' Create error handling
            Try
                ' Execute the command
                sqlAddition.ExecuteNonQuery()

                ' Return true
                Return True
            Catch ex As Exception
                ' Send the error to a string and return it
                Return ex.ToString
            End Try
        End Function

        ''' <summary>
        ''' Function for adding seven fields to the database
        ''' </summary>
        ''' <param name="strTableName">The name of the table to add to</param>
        ''' <param name="strColumnOne">The name of the first column to add to</param>
        ''' <param name="strValueOne">The value to add to the first column</param>
        ''' <param name="strColumnTwo">The name of the second column to add to</param>
        ''' <param name="strValueTwo">The value to add to the second column</param>
        ''' <param name="strColumnThree">The name of the third column to add to</param>
        ''' <param name="strValueThree">The value to add to the third column</param>
        ''' <param name="strColumnFour">The name of the fourth column to add to</param>
        ''' <param name="strValueFour">The value to add to the fourth column</param>
        ''' <param name="strColumnFive">The name of the fifth column to add to</param>
        ''' <param name="strValueFive">The value to add to the fifth column</param>
        ''' <param name="strColumnSix">The name of the sixth column to add to</param>
        ''' <param name="strValueSix">The value to add to the sixth column</param>
        ''' <param name="strColumnSeven">The name of the seventh column to add to</param>
        ''' <param name="strValueSeven">The value to add to the seventh column</param>
        ''' <returns>Returns true if successful, or an error string if not</returns>
        ''' <remarks></remarks>
        Public Shared Function SevenFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String, ByVal strColumnSix As String, ByVal strValueSix As String, ByVal strColumnSeven As String, ByVal strValueSeven As String)
            ' Sql command variable
            Dim sqlAddition As SqlCommand

            ' Instantiate the command
            sqlAddition = New SqlCommand

            ' Set the command text property
            sqlAddition.CommandText = "INSERT INTO @Table "
            sqlAddition.CommandText += "(@Col1, @Col2, @Col3, @Col4, @Col5, @Col6, @Col7) "
            sqlAddition.CommandText += "VALUES ('@Value1', '@Value2', '@Value3', '@Value4', '@Value5', "
            sqlAddition.CommandText += "'@Value6', '@Value7')"
            ' Designate the command type
            sqlAddition.CommandType = CommandType.Text

            ' Set the connection property
            sqlAddition.Connection = ctnTimetable

            ' Add the parameters to the command
            sqlAddition.Parameters.Add(CreateParameter("@Table", strTableName))
            sqlAddition.Parameters.Add(CreateParameter("@Col1", strColumnOne))
            sqlAddition.Parameters.Add(CreateParameter("@Col2", strColumnTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Col3", strColumnThree))
            sqlAddition.Parameters.Add(CreateParameter("@Col4", strColumnFour))
            sqlAddition.Parameters.Add(CreateParameter("@Col5", strColumnFive))
            sqlAddition.Parameters.Add(CreateParameter("@Col6", strColumnSix))
            sqlAddition.Parameters.Add(CreateParameter("@Col7", strColumnSeven))
            sqlAddition.Parameters.Add(CreateParameter("@Value1", strValueOne))
            sqlAddition.Parameters.Add(CreateParameter("@Value2", strValueTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Value3", strValueThree))
            sqlAddition.Parameters.Add(CreateParameter("@Value4", strValueFour))
            sqlAddition.Parameters.Add(CreateParameter("@Value5", strValueFive))
            sqlAddition.Parameters.Add(CreateParameter("@Value6", strValueSix))
            sqlAddition.Parameters.Add(CreateParameter("@Value7", strValueSeven))

            ' Create error handling
            Try
                ' Execute the command
                sqlAddition.ExecuteNonQuery()

                ' Return true
                Return True
            Catch ex As Exception
                ' Send the error to a string and return it
                Return ex.ToString
            End Try
        End Function

        ''' <summary>
        ''' Function for adding eight fields to the database
        ''' </summary>
        ''' <param name="strTableName">The name of the table to add to</param>
        ''' <param name="strColumnOne">The name of the first column to add to</param>
        ''' <param name="strValueOne">The value to add to the first column</param>
        ''' <param name="strColumnTwo">The name of the second column to add to</param>
        ''' <param name="strValueTwo">The value to add to the second column</param>
        ''' <param name="strColumnThree">The name of the third column to add to</param>
        ''' <param name="strValueThree">The value to add to the third column</param>
        ''' <param name="strColumnFour">The name of the fourth column to add to</param>
        ''' <param name="strValueFour">The value to add to the fourth column</param>
        ''' <param name="strColumnFive">The name of the fifth column to add to</param>
        ''' <param name="strValueFive">The value to add to the fifth column</param>
        ''' <param name="strColumnSix">The name of the sixth column to add to</param>
        ''' <param name="strValueSix">The value to add to the sixth column</param>
        ''' <param name="strColumnSeven">The name of the seventh column to add to</param>
        ''' <param name="strValueSeven">The value to add to the seventh column</param>
        ''' <param name="strColumnEight">The name of the eighth column to add to</param>
        ''' <param name="strValueEight">The value to add to the eighth column</param>
        ''' <returns>Returns true if successful, or an error string if not</returns>
        ''' <remarks></remarks>
        Public Shared Function EightFields(ByVal strTableName As String, ByVal strColumnOne As String, ByVal strValueOne As String, ByVal strColumnTwo As String, ByVal strValueTwo As String, ByVal strColumnThree As String, ByVal strValueThree As String, ByVal strColumnFour As String, ByVal strValueFour As String, ByVal strColumnFive As String, ByVal strValueFive As String, ByVal strColumnSix As String, ByVal strValueSix As String, ByVal strColumnSeven As String, ByVal strValueSeven As String, ByVal strColumnEight As String, ByVal strValueEight As String)
            ' Sql command variable
            Dim sqlAddition As SqlCommand

            ' Instantiate the command
            sqlAddition = New SqlCommand

            ' Set the command text property
            sqlAddition.CommandText = "INSERT INTO @Table "
            sqlAddition.CommandText += "(@Col1, @Col2, @Col3, @Col4, @Col5, @Col6, @Col7, @Col8) "
            sqlAddition.CommandText += "VALUES ('@Value1', '@Value2', '@Value3', '@Value4', '@Value5', "
            sqlAddition.CommandText += "'@Value6', '@Value7', '@Value8')"
            ' Designate the command type
            sqlAddition.CommandType = CommandType.Text

            ' Set the connection property
            sqlAddition.Connection = ctnTimetable

            ' Add the parameters to the command
            sqlAddition.Parameters.Add(CreateParameter("@Table", strTableName))
            sqlAddition.Parameters.Add(CreateParameter("@Col1", strColumnOne))
            sqlAddition.Parameters.Add(CreateParameter("@Col2", strColumnTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Col3", strColumnThree))
            sqlAddition.Parameters.Add(CreateParameter("@Col4", strColumnFour))
            sqlAddition.Parameters.Add(CreateParameter("@Col5", strColumnFive))
            sqlAddition.Parameters.Add(CreateParameter("@Col6", strColumnSix))
            sqlAddition.Parameters.Add(CreateParameter("@Col7", strColumnSeven))
            sqlAddition.Parameters.Add(CreateParameter("@Col8", strColumnEight))
            sqlAddition.Parameters.Add(CreateParameter("@Value1", strValueOne))
            sqlAddition.Parameters.Add(CreateParameter("@Value2", strValueTwo))
            sqlAddition.Parameters.Add(CreateParameter("@Value3", strValueThree))
            sqlAddition.Parameters.Add(CreateParameter("@Value4", strValueFour))
            sqlAddition.Parameters.Add(CreateParameter("@Value5", strValueFive))
            sqlAddition.Parameters.Add(CreateParameter("@Value6", strValueSix))
            sqlAddition.Parameters.Add(CreateParameter("@Value7", strValueSeven))
            sqlAddition.Parameters.Add(CreateParameter("@Value8", strValueEight))

            ' Create error handling
            Try
                ' Execute the command
                sqlAddition.ExecuteNonQuery()

                ' Return true
                Return True
            Catch ex As Exception
                ' Send the error to a string and return it
                Return ex.ToString
            End Try
        End Function


#Region "Old Methods"
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

    End Class

    ''' <summary>
    ''' Methods relating to the database connection
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Connection
        ''' <summary>
        ''' SQL connection variable
        ''' </summary>
        ''' <remarks></remarks>
        Public ctnTempestasPrime As SqlConnection

        ''' <summary>
        ''' Opens a new connection to the tempestas database
        ''' </summary>
        ''' <returns>Boolean value of success</returns>
        ''' <remarks></remarks>
        Public Function Open() As Boolean

            ' Connect to the database. Return True on success
            Dim strConnection As String

            ' Build the connection string
            strConnection = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & My.Settings.dbPath & ";Integrated Security=True;User Instance=True"

            ' Attempt to open the database
            Try
                ctnTempestasPrime = New SqlClient.SqlConnection(strConnection)
                ctnTempestasPrime.Open()

                ' Success
                Return True
            Catch ex As Exception
                ' Return false
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Closes the connection to the database
        ''' </summary>
        ''' <returns>Boolean value of success</returns>
        ''' <remarks></remarks>
        Public Function Close() As Boolean
            ' Attempt to close the database
            Try
                ' Close the database
                ctnTempestasPrime.Close()

                ' Success
                Return True
            Catch ex As Exception
                ' Return false
                Return False
            End Try
        End Function

#Region "Old Methods"
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
    End Class

#Region "Private Methods"
    ''' <summary>
    ''' Function to create the parameters for an sql command
    ''' </summary>
    ''' <param name="strParamName">The name of the parameter</param>
    ''' <param name="strParamValue">The value to be assigned to the parameter</param>
    ''' <returns>Returns a sql parameter instance</returns>
    ''' <remarks></remarks>
    Private Shared Function CreateParameter(ByRef strParamName As String, ByRef strParamValue As String) As SqlParameter
        ' Sql parameter variable
        Dim sqlValue As New SqlParameter

        ' Create a parameters
        sqlValue.ParameterName = strParamName
        sqlValue.Value = strParamValue

        Return sqlValue
    End Function
#End Region

End Class
