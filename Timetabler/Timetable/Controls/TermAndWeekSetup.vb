Public Class TermAndWeekSetup
    ''' <summary>
    ''' Enumeration to hold the size of the control for different states
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum intControlHeight As Integer
        ''' <summary>
        ''' The height of the control, in pixels, for a term system
        ''' </summary>
        ''' <remarks></remarks>
        Term = 47
        ''' <summary>
        ''' The height of the control, in pixels, for a term system
        ''' </summary>
        ''' <remarks></remarks>
        Both = 73
    End Enum

    ''' <summary>
    ''' Enumeration to identify the different controls
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum intControls As Integer
        ''' <summary>
        ''' The value to identify the start date date time picker
        ''' </summary>
        ''' <remarks></remarks>
        StartDate = 0
        ''' <summary>
        ''' The value to identify the finish date date time picker
        ''' </summary>
        ''' <remarks></remarks>
        FinishDate = 1
        ''' <summary>
        ''' The value to identify the length text box
        ''' </summary>
        ''' <remarks></remarks>
        Length = 2
        ''' <summary>
        ''' The value to identify the start week text box
        ''' </summary>
        ''' <remarks></remarks>
        StartWeek = 3
        ''' <summary>
        ''' The value to identify the finish week text box
        ''' </summary>
        ''' <remarks></remarks>
        FinishWeek = 4
    End Enum

    ''' <summary>
    ''' True if the controls are updating otherwise false
    ''' </summary>
    ''' <remarks></remarks>
    Dim bolUpdating As Boolean = False

    ''' <summary>
    ''' Stores the result of the term setup property
    ''' </summary>
    ''' <remarks></remarks>
    Dim bolTermSetup As Boolean

    ''' <summary>
    ''' Variable to hold the term number
    ''' </summary>
    ''' <remarks></remarks>
    Dim intTerm As Integer

#Region "Control Properties"
    ''' <summary>
    ''' The property for setting the state of the control
    ''' </summary>
    ''' <value>Boolean to decide if the control is meant to be a term setup system, true = term system, false = week system</value>
    ''' <returns>Returns true if the control is meant to be a term setup system</returns>
    ''' <remarks></remarks>
    Public Property TermSetup() As Boolean
        Get
            ' Return the value of the term setup boolean
            Return bolTermSetup
        End Get
        Set(ByVal value As Boolean)
            ' Get the value set
            bolTermSetup = value

            ' Call the control resize event
            ControlResize()
        End Set
    End Property

    ''' <summary>
    ''' Property to set the term of the control
    ''' </summary>
    ''' <value>Integer value indicating the term number of the control</value>
    ''' <returns>Returns the integer value of the term</returns>
    ''' <remarks></remarks>
    Public Property TermNumber() As Integer
        Get
            Return intTerm
        End Get
        Set(ByVal value As Integer)
            ' Get the value of the term
            intTerm = value

            ' Set the term label depending on the value
            If intTerm <= 0 Then
                ' Set the label to it's default
                lblTerm.Text = "Term X"
            Else
                ' Set the label to display the week number
                lblTerm.Text = "Term " & CStr(intTerm)
            End If
        End Set
    End Property
#End Region

#Region "Non handles events"
    ''' <summary>
    ''' Event to check the state of the control and resize it accordingly
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ControlResize()
        ' Determin the state of the control and act accordingly
        If bolTermSetup = True Then
            ' Resize the control
            Me.Height = intControlHeight.Term
        Else
            ' Resize the control
            Me.Height = intControlHeight.Both
        End If
    End Sub

    ''' <summary>
    ''' Gets the number of weeks from the days
    ''' </summary>
    ''' <param name="intDays">The number of days to be converted to weeks</param>
    ''' <returns>The number of weeks as an integer</returns>
    ''' <remarks></remarks>
    Private Function GetWeeks(ByVal intDays As Integer) As Integer

        ' The decimal variable to store the mod of the days
        Dim intModulusDays As Integer

        'Work out if the number of days divides by 7
        intModulusDays = intDays Mod 7

        ' Check the value of the days
        If intDays < 7 Then
            ' Set the value of the weeks to one
            GetWeeks = 1
        Else
            'Work out if the number of days divides by 7
            intModulusDays = intDays Mod 7

            ' Take the modulus away from the day total
            intDays = intDays - intModulusDays

            ' Get the integer number of weeks
            GetWeeks = intDays / 7

            ' Check if there is a modulus of the week interger
            If intModulusDays > 0 Then
                ' Add one to the integer value of weeks 
                GetWeeks = GetWeeks + 1
            End If
        End If

        Return GetWeeks
    End Function

    ''' <summary>
    ''' Calulates the value the length box should be
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateWeekLength()
        ' Variable to store the days in the difference in date
        Dim intDays As Integer

        ' Variable to convert this difference into weeks
        Dim intWeeks As Integer

        ' Get the difference between the dates in days
        intDays = (dtpFinishDate.Value - dtpStartDate.Value).Days

        ' Get the number of weeks
        intWeeks = GetWeeks(intDays)

        ' Set the value to that of the text box
        txtLength.Text = CStr(intWeeks)
    End Sub

    ''' <summary>
    ''' Calculates the the amount the two date time pickers should be apart
    ''' </summary>
    ''' <param name="dtpChangedDate">The date time picker that has had its value changed</param>
    ''' <param name="dtpDateToChange">The date time picker that hasn't had it's value changed</param>
    ''' <remarks></remarks>
    Private Sub CalculateDTPDifference(ByRef dtpChangedDate As DateTimePicker, ByRef dtpDateToChange As DateTimePicker)
        ' Variable to store the days in the difference in date
        Dim intDays As Integer

        ' Get the difference between the dates in days
        intDays = (dtpFinishDate.Value - dtpStartDate.Value).Days

        ' Act according to the number of days
        If intDays <= 0 Then
            ' Set the finish date to the start date
            dtpDateToChange.Value = dtpChangedDate.Value
        End If

        ' Calculate the value for the length text box
        CalculateWeekLength()
    End Sub

    ''' <summary>
    ''' Event to update the controls on the user control
    ''' </summary>
    ''' <param name="intControlValue">The enumaration value of the sending control</param>
    ''' <remarks></remarks>
    Private Sub UpdateControls(ByRef intControlValue)
        ' Check to see if the updating boolean is false 
        If bolUpdating = False Then
            ' Set the value of the updating boolean to true
            bolUpdating = True
        End If

        Try
            ' Call the updating procedure for the sending control
            Select Case intControlValue
                Case intControls.StartDate
                    ' Calculate the difference between the start and finish dates
                    CalculateDTPDifference(dtpStartDate, dtpFinishDate)

                    ' Calculate the end week
                    txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
                Case intControls.FinishDate
                    ' Calculate the difference between the finish and start dates
                    CalculateDTPDifference(dtpFinishDate, dtpStartDate)

                    ' Calculate the end week
                    txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
                Case intControls.Length
                    ' Variable to hold the number of days
                    Dim intDays As Integer

                    ' Check to see if a number has been entered and if not exit
                    If txtStartWeek.Text = "" Or txtFinishWeek.Text = "" Or txtLength.Text = "" Then Exit Select

                    ' Check to if the number is greater than 0
                    If txtLength.Text > 0 Then
                        ' Set the end week the the duration from the start week
                        txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
                    Else
                        ' Set the finish week to the start week
                        txtFinishWeek.Text = txtStartWeek.Text
                    End If

                    ' Calculate the number of days from the value entered
                    intDays = CInt(txtLength.Text) * 7

                    ' Set the end date to the number of days away from the start date
                    dtpFinishDate.Value = dtpStartDate.Value.AddDays(intDays)
                Case intControls.StartWeek
                    ' Check to see if a number has been entered and if not exit
                    If txtStartWeek.Text = "" Or txtFinishWeek.Text = "" Or txtLength.Text = "" Then Exit Select

                    ' Set the end week the the duration from the start week
                    txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
                Case intControls.FinishWeek
                    ' Variable to hold the number of days
                    Dim intDays As Integer

                    ' Check to see if a number has been entered and if not exit
                    If txtStartWeek.Text = "" Or txtFinishWeek.Text = "" Or txtLength.Text = "" Then Exit Select

                    ' Calculate the number of days from the value entered
                    intDays = (CInt(txtFinishWeek.Text) - CInt(txtStartWeek.Text) + 1) * 7

                    ' Set the end date to the number of days away from the start date
                    dtpFinishDate.Value = dtpStartDate.Value.AddDays(intDays)

                    ' Calculate the value for the length text box
                    CalculateWeekLength()
            End Select
        Catch ex As Exception
            ' Check that the length text box has a value
            If txtLength.Text = "" Then
                CalculateWeekLength()
            ElseIf txtLength.Text = 0 Then
                CalculateWeekLength()
            End If

            ' Check that the start week text box has a value
            If txtStartWeek.Text = "" Then
                ' Set the end week the the duration from the start week
                txtStartWeek.Text = CInt(txtFinishWeek.Text) - CInt(txtLength.Text) + 1
            End If

            ' Check that the finish week text box has a value
            If txtFinishWeek.Text = "" Or txtFinishWeek.Text = 0 Then
                ' Set the end week the the duration from the start week
                txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
            End If
        Finally
            ' Reset the updating boolean
            bolUpdating = False
        End Try
    End Sub
#End Region

#Region "Handles Events"
    Private Sub dtpStartDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        ' Check to see if the updating boolean is set to true
        If bolUpdating = False Then
            ' Call the update controls event
            UpdateControls(intControls.StartDate)
        End If
    End Sub

    Private Sub dtpFinishDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFinishDate.ValueChanged
        ' Check to see if the updating boolean is set to true
        If bolUpdating = False Then
            ' Call the update controls event
            UpdateControls(intControls.FinishDate)
        End If

    End Sub

    Private Sub txtLength_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLength.LostFocus
        ' Check that the length text box has a value
        If txtLength.Text = "" Then
            CalculateWeekLength()
        ElseIf txtLength.Text = 0 Then
            CalculateWeekLength()
        End If
    End Sub

    Private Sub txtLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLength.TextChanged
        ' Check to see if the updating boolean is set to true
        If bolUpdating = False Then
            ' Call the update controls event
            UpdateControls(intControls.Length)
        End If
    End Sub

    Private Sub txtStartWeek_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartWeek.LostFocus
        ' Check that the start week text box has a value
        If txtStartWeek.Text = "" Then
            ' Set the end week the the duration from the start week
            txtStartWeek.Text = CInt(txtFinishWeek.Text) - CInt(txtLength.Text) + 1
        End If
    End Sub

    Private Sub txtStartWeek_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartWeek.TextChanged
        ' Check to see if the updating boolean is set to true
        If bolUpdating = False Then
            ' Call the update controls event
            UpdateControls(intControls.StartWeek)
        End If
    End Sub

    Private Sub txtFinishWeek_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinishWeek.LostFocus
        ' Check that the finish week text box has a value
        If txtFinishWeek.Text = "" Or txtFinishWeek.Text = 0 Then
            ' Set the end week the the duration from the start week
            txtFinishWeek.Text = CInt(txtStartWeek.Text) + CInt(txtLength.Text) - 1
        End If
    End Sub

    Private Sub txtFinishWeek_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinishWeek.TextChanged
        ' Check to see if the updating boolean is set to true
        If bolUpdating = False Then
            ' Call the update controls event
            UpdateControls(intControls.FinishWeek)
        End If
    End Sub

    ''' <summary>
    ''' Checks the entered keystrokes to allow only numbers
    ''' </summary>
    ''' <param name="sender">The sender object</param>
    ''' <param name="e">The key event argument</param>
    ''' <remarks></remarks>
    Private Sub CheckTextBoxEntry(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFinishWeek.KeyDown, txtLength.KeyDown, txtStartWeek.KeyDown
        ' Call the allow only numbers event
        TextBoxEvents.AllowOnlyNumbers(sender, e)
    End Sub
#End Region
End Class
