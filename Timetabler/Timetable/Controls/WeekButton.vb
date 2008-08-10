Public Class WeekButton
    ' The week number of the button
    Dim strWeekNumber As String

    ' Declarations for deciding the state of a button
    Dim intCurrentState As Integer
    Private Enum intState
        Selected = 1
        ClickSelected = 3
        Unselected = 2
    End Enum

    Private Sub WeekButton_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set the default state of the button
        intCurrentState = intState.Unselected
    End Sub

    Private Sub WeekButton_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ' Run the button clicked routine
        WeekButtonClicked(strWeekNumber)

        ' Set the button to click selected
        intCurrentState = intState.ClickSelected

        ' Refresh the button
        Me.Refresh()
    End Sub

    Private Sub WeekButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        ' Decide if the button has be clicked
        If intCurrentState = intState.ClickSelected Then
            Return
        Else
            ' Set the button to selected
            intCurrentState = intState.Selected

            ' Refresh the button
            Me.Refresh()
        End If
      
    End Sub

    Private Sub WeekButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        ' Decide if the button has be clicked
        If intCurrentState = intState.ClickSelected Then
            Return
        Else
            ' Set the button to unselected
            intCurrentState = intState.Unselected

            ' Refresh the button
            Me.Refresh()
        End If
    End Sub

    Private Sub WeekButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Declare text variables
        Dim fntWeek As New Font("Gill Sans MT", 30, FontStyle.Bold, GraphicsUnit.Pixel)
        Dim objStringSize As SizeF
        Dim intStringHeight As Integer
        Dim intStringWidth As Integer
        Dim intControlHeight As Integer
        Dim intControlWidth As Integer
        Dim intXPosition As Integer
        Dim intYPosition As Integer

        ' Brush variables for different states
        Dim brsSelectedForeground As Brush = Brushes.SkyBlue
        Dim brsSelectedBackground As Brush = Brushes.White
        Dim brsUnselectedForeground As Brush = Brushes.Gray
        Dim brsUnselectedBackground As Brush = Brushes.White

        ' Find the size of the string
        objStringSize = e.Graphics.MeasureString(strWeekNumber, fntWeek)

        ' Calculate the size of the text
        intStringHeight = objStringSize.Height
        intStringWidth = objStringSize.Width

        ' Set the height and width of the control to variables
        intControlHeight = Me.Height
        intControlWidth = Me.Width

        ' Calculate the position of the text
        intYPosition = (intControlHeight - intStringHeight) / 2
        intXPosition = (intControlWidth - intStringWidth) / 2

        Select Case intCurrentState
            Case intState.Selected
                ' Draw the boarder of the button
                e.Graphics.FillRectangle(brsSelectedForeground, 0, 0, 40, 40)
                e.Graphics.FillRectangle(brsSelectedBackground, 2, 2, 36, 36)

                ' Draw text on the button
                e.Graphics.DrawString(strWeekNumber, fntWeek, brsSelectedForeground, intXPosition, intYPosition)
            Case intState.Unselected
                ' Draw the boarder of the button
                e.Graphics.FillRectangle(brsUnselectedForeground, 0, 0, 40, 40)
                e.Graphics.FillRectangle(brsUnselectedBackground, 2, 2, 36, 36)

                ' Draw text on the button
                e.Graphics.DrawString(strWeekNumber, fntWeek, brsUnselectedForeground, intXPosition, intYPosition)
            Case intState.ClickSelected
                ' Draw the boarder of the button
                e.Graphics.FillRectangle(brsSelectedForeground, 0, 0, 40, 40)
                e.Graphics.FillRectangle(brsSelectedBackground, 2, 2, 36, 36)

                ' Draw text on the button
                e.Graphics.DrawString(strWeekNumber, fntWeek, brsSelectedForeground, intXPosition, intYPosition)
        End Select
    End Sub

    <System.ComponentModel.DefaultValue(1)> <System.ComponentModel.Category("Appearance")> Public Property ButtonText() As String
        Get
            Return strWeekNumber
        End Get
        Set(ByVal value As String)
            strWeekNumber = value
        End Set
    End Property

    Public Property Selected() As Integer
        Get
            Return intCurrentState
        End Get
        Set(ByVal value As Integer)
            intCurrentState = value
            Me.Refresh()
        End Set
    End Property
End Class
