Public Class WeekSetUp
    ' Variable to hold the term number
    Dim intYear As Integer

    ' Property to set the term of the control
    Public Property ControlYear() As Integer
        Get
            Return intYear
        End Get
        Set(ByVal value As Integer)
            ' Get the value of the term
            intYear = value

            ' Set the term label depending on the value
            If intYear <= 0 Then
                ' Set the label to it's default
                lblYear.Text = "Year X"
            Else
                ' Set the label to display the week number
                lblYear.Text = "Year " & intYear
            End If
        End Set
    End Property

    Public Property YearName() As String
        Get
            Return txtYearName.Text
        End Get
        Set(ByVal value As String)
            ' Get the name of the year
            txtYearName.Text = value
        End Set
    End Property

    Public Property Duration() As Integer
        Get
            Return CInt(txtLength.Text.Trim)
        End Get
        Set(ByVal value As Integer)
            ' Get the duration of the year
            txtLength.Text = value
        End Set
    End Property

    Private Sub txtLength_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLength.KeyDown
        ' Call the allow only numbers event
        TextBoxEvents.AllowOnlyNumbers(sender, e)
    End Sub


    Private Sub txtYearName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYearName.KeyDown
        ' Call the allow alpha numeric event
        TextBoxEvents.AllowAlphaNumeric(sender, e)
    End Sub
End Class
