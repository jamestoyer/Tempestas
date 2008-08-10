Public Class BothSetUp
    ' Variable to hold the term number
    Dim intTerm As Integer

    ' Property to set the term of the control
    Public Property ControlTerm() As Integer
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
                lblTerm.Text = "Term " & intTerm
            End If
        End Set
    End Property

    ' Gets the number of weeks from the days
    Private Sub GetWeeks(ByVal intDays As Integer, ByRef intWeeks As Integer)
        ' The decimal value of weeks from days
        Dim decWeek As Decimal

        ' Get the decimal number of weeks
        decWeek = intDays / 7

        ' Get the integer number of weeks
        intWeeks = intDays / 7

        ' Work out if the decimal number of weeks is greater than the integer value
        If intWeeks < decWeek Then
            ' Add one to the integer value of weeks 
            intWeeks = intWeeks + 1
        End If

        Return
    End Sub

    Private Sub dtpFinishDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFinishDate.ValueChanged
        ' Variable to store the days in the difference in date
        Dim intDays As Integer

        ' Variable to convert this difference into weeks
        Dim intWeeks As Integer

        ' Get the difference between the dates in days
        intDays = (dtpFinishDate.Value - dtpStartDate.Value).Days

        ' Act according to the number of days
        Select Case intDays
            Case Is <= 0
                ' Set the start date to the finish date
                dtpStartDate.Value = dtpFinishDate.Value

                ' Set the week text box to 0
                txtLength.Text = 0

                ' Set the finish week to be the amount of weeks away from the start week
                txtFinishWeek.Text = txtStartWeek.Text
            Case Else
                ' Get the number of weeks
                GetWeeks(intDays, intWeeks)

                ' Set the value to that of the text box
                txtLength.Text = CStr(intWeeks)

                ' Set the finish week to be the amount of weeks away from the start week
                txtFinishWeek.Text = txtStartWeek.Text + CInt(intWeeks) - 1
        End Select
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        ' Variable to store the days in the difference in date
        Dim intDays As Integer

        ' Variable to convert this difference into weeks
        Dim intWeeks As Integer

        ' Get the difference between the dates in days
        intDays = (dtpFinishDate.Value - dtpStartDate.Value).Days

        ' Act according to the number of days
        Select Case intDays
            Case Is <= 0
                ' Set the finish date to the start date
                dtpFinishDate.Value = dtpStartDate.Value

                ' Set the week text box to 0
                txtLength.Text = 0

                ' Set the end week number
                txtFinishWeek.Text = txtStartWeek.Text
            Case Else
                ' Get the number of weeks
                GetWeeks(intDays, intWeeks)

                ' Set the value to that of the text box
                txtLength.Text = CStr(intWeeks)

                ' Set the end week number
                txtFinishWeek.Text = CStr(intWeeks - 1 + CInt(txtStartWeek.Text))
        End Select
    End Sub

    Private Sub txtLength_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLength.Leave
        ' Variable to hold the number of days
        Dim intDays As Integer

        ' Variable to hold the number of weeks
        Dim intWeeks As Integer

        ' If the text box text is nothing and recalculate the amount of weeks
        If txtLength.Text = Nothing Then
            ' Get the difference between the dates in days
            intDays = (dtpFinishDate.Value - dtpStartDate.Value).Days

            ' Get the number of weeks
            GetWeeks(intDays, intWeeks)

            ' Set the value to that of the text box
            txtLength.Text = CStr(intWeeks)

            ' Set the end week number
            txtFinishWeek.Text = CStr(intWeeks - 1 + CInt(txtStartWeek.Text))
            Return
        End If

        ' Calculate the number of days from the value entered
        intDays = CInt(txtLength.Text) * 7

        ' Set the end date to the number of days away from the start date
        dtpFinishDate.Value = dtpStartDate.Value.AddDays(intDays)

        ' Set the end week number
        txtFinishWeek.Text = CStr(CInt(txtLength.Text) - 1 + CInt(txtStartWeek.Text))

    End Sub

    Private Sub TermSetUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set the date to today
        dtpStartDate.Value = Now

        ' Set the values of the text boxes
        txtStartWeek.Text = 1
        txtFinishWeek.Text = 1
    End Sub

#Region "Key Down Events"

    Private Sub NumberEntryTextBoxValidation(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFinishWeek.KeyDown, txtStartWeek.KeyDown, txtLength.KeyDown
        ' Call the allow only numbers event
        TextBoxEvents.AllowOnlyNumbers(sender, e)
    End Sub
#End Region

End Class
