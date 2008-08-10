Public Class WeekView
    ' Size and rectangle variables
    Dim intNumberOfBlocks As Integer
    Dim intWidthOfBlock As Integer = 95
    Dim intInitialWidth As Integer = 24
    Dim intHeight As Integer = 123

    ' Day label variable
    Dim strDay As String

    ' Boolean variables
    Dim boolResize As Boolean = False

    ' Time variables
    Dim strStartTime As String = 900
    Dim strFinishTime As String = 1700

    Private Sub WeekView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Resize the control
        ResizeControl()

        ' Set the day text
        SetDay()
    End Sub

    Private Sub WeekView_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Variables for drawing blocks
        Dim intBlock As Integer
        Dim intX As Integer = 23
        Dim intY As Integer

        ' Calculate the height
        intY = intHeight - 1

        If boolResize = True Then
            Me.BackColor = Color.White
        End If

        boolResize = False

        ' Draw a box around the day label
        e.Graphics.DrawRectangle(Pens.Black, 0, 0, 23, intY)

        ' Find out the number of blocks
        intNumberOfBlocks = NumberOfBlocks()

        ' Draw the number of blocks required
        If intNumberOfBlocks > 0 Then
            For intBlock = 1 To intNumberOfBlocks
                ' Draw the block
                e.Graphics.DrawRectangle(Pens.Black, intX, 0, intWidthOfBlock, intY)

                ' Add the width of a block to the start position
                intX = intX + intWidthOfBlock
            Next
        End If
    End Sub

    Public Property Day() As String
        Get
            Return strDay
        End Get
        Set(ByVal value As String)
            strDay = value
            ResizeControl()
        End Set
    End Property

    Public Property ControlResize() As Boolean
        Get
            Return boolResize
        End Get
        Set(ByVal value As Boolean)
            boolResize = value
            If boolResize = True Then
                Me.Refresh()
                boolResize = False

            End If
        End Set
    End Property

    Public Property ControlHeight() As Integer
        Get
            Return intHeight
        End Get
        Set(ByVal value As Integer)
            intHeight = value
            ResizeControl()
        End Set
    End Property

    Private Sub ResizeControl()
        ' Control size variables
        Dim intWidth As Integer

        ' Find out the number of blocks
        intNumberOfBlocks = NumberOfBlocks()

        ' Resize the control accordingly
        intWidth = intInitialWidth + (intWidthOfBlock * intNumberOfBlocks)
        Me.Width = intWidth
        Me.Height = intHeight
    End Sub

    Private Sub SetDay()
        ' Variable to hold the letter left in the day to split
        Dim strLetterLeft As String

        ' Get the day from the day string
        strLetterLeft = strDay

        ' Set the first letter to the label with no return
        lblDay.Text = Microsoft.VisualBasic.Left(strLetterLeft, 1)

        ' Work out the length of the string and take out the letter just added to the label
        strLetterLeft = Microsoft.VisualBasic.Right(strLetterLeft, strLetterLeft.Length - 1)

        Do Until strLetterLeft.Length = 0
            ' Start a new line and set the next letter to the string
            lblDay.Text += vbNewLine & Microsoft.VisualBasic.Left(strLetterLeft, 1)

            ' Work out the length of the string and take out the letter just added to the label
            strLetterLeft = Microsoft.VisualBasic.Right(strLetterLeft, strLetterLeft.Length - 1)
        Loop

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
End Class
