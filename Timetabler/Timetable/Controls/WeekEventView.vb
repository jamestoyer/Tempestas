Public Class WeekEventView
    ' Duration of the contact and start time
    Dim intDuration As Integer
    Dim intStartTime As Integer

    ' Control size variables
    Dim intControlHeight As Integer
    Dim intControlWidth As Integer

    ' Panel size variables
    Dim intTopPanel As Integer
    Dim intMiddlePanel As Integer
    Dim intBottomPanel As Integer

    ' Size of pad between panels
    Dim intPanelPad As Integer = 8

    ' Property variables
    Public penRectangle As Pen
    Dim strColour As String

    ' The day ID variable
    Dim intDayID As Integer

    Private Sub WeekEventView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set the size of the control
        SetControlSize()
    End Sub

    Private Sub WeekEventView_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Rectangle variables
        Dim intRectHeight As Integer
        Dim intRectWidth As Integer

        ' Determin the size of the rectangle to be drawn and draw it
        intRectHeight = intControlHeight - 1
        intRectWidth = intControlWidth - 1
        e.Graphics.DrawRectangle(penRectangle, 0, 0, intRectWidth, intRectHeight)

        ' Determin the size of the rectangle to be drawn and draw it
        intRectHeight = intRectHeight - 2
        intRectWidth = intRectWidth - 2
        e.Graphics.DrawRectangle(penRectangle, 1, 1, intRectWidth, intRectHeight)

    End Sub

#Region "Event Properties"
    ''' <summary>
    ''' Properties of the control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Property Contact() As String
        Get
            Return lblContact.Text
        End Get
        Set(ByVal value As String)
            lblContact.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property ModuleCode() As String
        Get
            Return lblModuleCode.Text
        End Get
        Set(ByVal value As String)
            lblModuleCode.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property ModuleName() As String
        Get
            Return lblModule.Text
        End Get
        Set(ByVal value As String)
            lblModule.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property Staff() As String
        Get
            Return lblStaff.Text
        End Get
        Set(ByVal value As String)
            lblStaff.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property Room() As String
        Get
            Return lblRoom.Text
        End Get
        Set(ByVal value As String)
            lblRoom.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property Notes() As String
        Get
            Return lblNotes.Text
        End Get
        Set(ByVal value As String)
            lblNotes.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    Public Property Duration() As Integer
        Get
            Return intDuration
        End Get
        Set(ByVal value As Integer)
            intDuration = value
            SetControlSize()
        End Set
    End Property

    Public Property StartTime() As Integer
        Get
            Return intStartTime
        End Get
        Set(ByVal value As Integer)
            intStartTime = value
        End Set
    End Property

    Public Property Day() As Integer
        Get
            Return intDayID
        End Get
        Set(ByVal value As Integer)
            intDayID = value
        End Set
    End Property

    Public Property Colour() As String
        Get
            Return strColour
        End Get
        Set(ByVal value As String)
            Dim clrColour As Color
            strColour = value
            If strColour <> Nothing Then
                clrColour = ConvertTextToColour(strColour)
                'penRectangle.Color = New Color
                'penRectangle.Color = clrColour
                penRectangle = New Pen(clrColour)
            End If

        End Set
    End Property
#End Region

#Region "Other Events"
    Private Sub CheckInput(ByVal lblSource As Label)
        If lblSource.Text = "" Then
            lblSource.Visible = False
        Else
            lblSource.Visible = True
        End If
    End Sub

    Private Sub SetControlSize()
        ' Label visibility variables
        Dim intContact As Integer
        Dim intModuleCode As Integer
        Dim intModule As Integer
        Dim intStaff As Integer
        Dim intRoom As Integer
        Dim intNotes As Integer

        ' Check to see if the label is visible and if so what it's size is
        intContact = CheckVisibility(lblContact)
        intModuleCode = CheckVisibility(lblModuleCode)
        intModule = CheckVisibility(lblModule)
        intStaff = CheckVisibility(lblStaff)
        intRoom = CheckVisibility(lblRoom)
        intNotes = CheckVisibility(lblNotes)

        ' Get the heights of the panels
        intTopPanel = intContact + intPanelPad
        intMiddlePanel = intModuleCode + intModule + intStaff + intRoom + intPanelPad

        ' If there are notes then give the value otherwise 0
        If intNotes > 0 Then
            intBottomPanel = intNotes + intPanelPad
        Else
            intBottomPanel = 0
        End If

        ' Set the heights of the panels
        pnlTop.Height = intTopPanel
        pnlMiddle.Height = intMiddlePanel
        pnlBottom.Height = intBottomPanel

        ' Calculate the width of the control
        intControlWidth = ControlWidth()

        ' Set the maximum sizes of the labels
        lblContact.MaximumSize = New Size(ControlWidth, 0)
        lblModule.MaximumSize = New Size(ControlWidth, 0)
        lblModuleCode.MaximumSize = New Size(ControlWidth, 0)
        lblNotes.MaximumSize = New Size(ControlWidth, 0)
        lblRoom.MaximumSize = New Size(ControlWidth, 0)
        lblStaff.MaximumSize = New Size(ControlWidth, 0)


        ' Set the size of the control
        intControlHeight = intTopPanel + intMiddlePanel + intBottomPanel
        Me.Height = intControlHeight
        Me.Width = intControlWidth
        Me.Refresh()
    End Sub

    Private Function ControlWidth()
        ' Control constants
        Const decSizeOfOneMinute As Decimal = 1.5
        Const intWidthPad As Integer = 5

        ' End time variables
        Dim intEndTime As Integer

        ' Time difference variables
        Dim intTimeDifference As Integer
        Dim intStartMod As Integer
        Dim intEndMod As Integer
        Dim intStartHour As Integer
        Dim intEndHour As Integer
        Dim intHourDifference As Integer

        ' Block variables
        Dim intBlocks As Integer

        ' Find the end time of the control
        intEndTime = CalculateTime(intStartTime, intDuration)

        ' Find the difference between the start and finish time
        intTimeDifference = intEndTime - intStartTime

        Select Case intTimeDifference
            Case Is < 41
                ' The control is less than one block big
                ControlWidth = CInt(decSizeOfOneMinute * intDuration)

                Return ControlWidth
            Case 41 To 59
                ' Calculate the mods of the start and finish time
                intStartMod = intStartTime Mod 100
                intEndMod = intEndTime Mod 100

                If intStartMod < intEndMod Then
                    ' The control is less than one block big
                    ControlWidth = CInt(decSizeOfOneMinute * intDuration)
                Else
                    ' The control is bigger than one block
                    ControlWidth = CInt(intWidthPad + (decSizeOfOneMinute * intDuration))
                End If

                Return ControlWidth
            Case Is > 59
                ' Calculate the mods of the start and finish time
                intStartMod = intStartTime Mod 100
                intEndMod = intEndTime Mod 100

                ' Work out the start and end hour
                intStartHour = intStartTime - intStartMod
                intEndHour = intEndTime - intEndMod

                ' Work out the difference between the start and end hour
                intHourDifference = (intEndHour - intStartHour) / 100

                If intEndMod > 0 Then
                    ' Calculate the number of blocks taken up
                    intBlocks = intHourDifference

                    ' The control is bigger than one block
                    ControlWidth = CInt((intWidthPad * intBlocks) + (decSizeOfOneMinute * intDuration))
                Else
                    ' Calculate the number of blocks taken up
                    intBlocks = intHourDifference - 1

                    ' The control is bigger than one block
                    ControlWidth = CInt((intWidthPad * intBlocks) + (decSizeOfOneMinute * intDuration))
                End If

                Return ControlWidth
        End Select

        Return 0

    End Function
    Private Function CheckVisibility(ByVal lblSource As Label) As Integer
        CheckInput(lblSource)

        If lblSource.Visible = False Then
            CheckVisibility = 0
            Return CheckVisibility
        Else
            CheckVisibility = lblSource.Height
            Return CheckVisibility
        End If
    End Function
#End Region
    
End Class
