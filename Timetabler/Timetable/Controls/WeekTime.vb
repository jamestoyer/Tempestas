Public Class WeekTime
    ' Variables for working out the size of the control and times
    Dim intNumberOfBlocks As Integer
    Dim intWidthOfBlock As Integer = 95
    Dim intInitialWidth As Integer = 24
    Dim strStartTime As String = 900
    Dim strFinishTime As String = 1700
    Dim boolStartUp As Boolean
    Dim strTime As String

    Private Sub WeekTime_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Variables for drawing the rectangles
        Dim intBlock As Integer
        Dim intX As Integer = 23

        ' Variables for a new label
        Dim lblNew As New Label
        Dim intTime As Integer
        Dim intPadding As Integer = 3

        ' Variables for getting the positions of a line
        Dim intPixelEntry As Integer = 0
        Dim intTimeEntry As Integer = 1
        Dim intEntry As Integer = 0

        ' Draw the starting rectangle
        e.Graphics.DrawRectangle(Pens.Black, 0, 0, 23, 18)

        ' Set the start time to the time addition string
        strTime = strStartTime

        ' Check to see if the number of blocks is greater than 0
        If intNumberOfBlocks > 0 Then
            ' Set up the labels and rectangles for the times
            For intBlock = 1 To intNumberOfBlocks
                ' Draw the rectangle
                e.Graphics.DrawRectangle(Pens.Black, intX, 0, intWidthOfBlock, 18)

                If boolStartUp = True Then
                    ' Create a new label
                    lblNew.AutoSize = True
                    lblNew.Location = New System.Drawing.Point((intX + intPadding), intPadding)
                    lblNew.Name = "lbl" & strTime
                    lblNew.Size = New System.Drawing.Size(39, 13)
                    lblNew.TabIndex = 0
                    lblNew.Text = strTime
                    Controls.Add(lblNew)

                    ' Set the time string to an integer
                    intTime = CInt(strTime)

                    ' Set the pixel size and time to the array
                    intWeekViewLines(intEntry, intPixelEntry) = intX
                    intWeekViewLines(intEntry, intTimeEntry) = intTime

                    ' Increase the entry number by 1
                    intEntry = intEntry + 1

                    ' Add an hour to the time
                    intTime = intTime + 100

                    ' Set the time integer back to a string and check it's format
                    strTime = CheckTimes(CStr(intTime))

                    ' Reset the new label variable
                    lblNew = New Label
                End If

                ' Increase the x co-ordinate by the size of a block
                intX = intX + intWidthOfBlock
            Next
        End If

        ' Set the starting boolean to false
        boolStartUp = False
    End Sub

    Public Property StartTime() As String
        Get
            Return strStartTime
        End Get
        Set(ByVal value As String)
            strStartTime = value
            ResizeControl()
        End Set
    End Property

    Public Property FinishTime() As String
        Get
            Return strFinishTime
        End Get
        Set(ByVal value As String)
            strFinishTime = value
            ResizeControl()
        End Set
    End Property

    Public Property StartUp() As Boolean
        Get
            Return boolStartUp
        End Get
        Set(ByVal value As Boolean)
            boolStartUp = value
        End Set
    End Property

    Private Sub ResizeControl()
        ' Variables for working out the size of the control
        Dim intWidth As Integer

        ' Find the number of blocks required
        intNumberOfBlocks = NumberOfBlocks()

        ' Check to see if the number of blocks is greater than 0
        If intNumberOfBlocks > 0 Then
            ' Work out the new size of the control
            intWidth = intInitialWidth + (intWidthOfBlock * intNumberOfBlocks)

            ' Resize the control
            Me.Width = intWidth
        End If
    End Sub

    Private Function NumberOfBlocks() As Integer
        ' Work out how many blocks are required
        NumberOfBlocks = (CInt(strFinishTime) - CInt(strStartTime)) / 100

        Select Case NumberOfBlocks
            Case Is < 0
                NumberOfBlocks = 24
                Return NumberOfBlocks
            Case Is = 0
                If CInt(strFinishTime) > 0 Then
                    NumberOfBlocks = 24
                    Return NumberOfBlocks
                End If
            Case Is > 0
                Return NumberOfBlocks
        End Select

    End Function
End Class
