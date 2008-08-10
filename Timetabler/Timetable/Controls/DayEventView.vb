Public Class DayEventView
    ' Height of the control
    Dim intControlHeight As Integer
    Dim intControlWidth As Integer = 200

    ' Panel size variables
    Dim intTopPanel As Integer
    Dim intMiddlePanel As Integer
    Dim intBottomPanel As Integer

    ' Size of pad between panels
    Dim intPanelPad As Integer = 8

    ' Property variables
    Public penRectangle As Pen = Pens.Black

    Private Sub DayEventView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the size of the control
        SetControlSize()
    End Sub

    Private Sub DayEventView_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Rectangle variables
        Dim intRectHeight As Integer
        Dim intRectWidth As Integer
        Dim intRectY As Integer

        ' Determin the size of the rectangle to be drawn
        intRectHeight = intControlHeight - 1
        intRectWidth = intControlWidth - 1
        intRectY = intTopPanel - (intPanelPad / 2)

        ' Draw the rectangle
        e.Graphics.DrawRectangle(penRectangle, 0, intRectY, intRectWidth, intRectHeight - 21)

        ' Fill a rectangle around the time
        e.Graphics.FillRectangle(Brushes.SkyBlue, 0, 0, 200, 13)
    End Sub

#Region "Event Properties"
    ''' <summary>
    ''' Properties that update the control to show a timetabled event
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    <System.ComponentModel.DefaultValue("Time")> <System.ComponentModel.Category("Layout")> Public Property Time() As String
        Get
            Return lblTime.Text
        End Get
        Set(ByVal value As String)
            lblTime.Text = value
            CheckInput(lblTime)
            SetControlSize()
        End Set
    End Property

    <System.ComponentModel.Category("Layout")> <System.ComponentModel.DefaultValue("Contact")> Public Property Contact() As String
        Get
            Return lblContact.Text
        End Get
        Set(ByVal value As String)
            lblContact.Text = value
            CheckInput(lblContact)
            SetControlSize()
        End Set
    End Property

    <System.ComponentModel.Category("Layout")> <System.ComponentModel.DefaultValue("Module")> Public Property ModuleName() As String
        Get
            Return lblModule.Text
        End Get
        Set(ByVal value As String)
            lblModule.Text = value
            CheckInput(lblModule)
            SetControlSize()
        End Set
    End Property

    <System.ComponentModel.Category("Layout")> <System.ComponentModel.DefaultValue("Staff")> Public Property Staff() As String
        Get
            Return lblStaff.Text
        End Get
        Set(ByVal value As String)
            lblStaff.Text = value
            CheckInput(lblStaff)
            SetControlSize()
        End Set
    End Property

    <System.ComponentModel.Category("Layout")> <System.ComponentModel.DefaultValue("Room")> Public Property Room() As String
        Get
            Return lblRoom.Text
        End Get
        Set(ByVal value As String)
            lblRoom.Text = value
            CheckInput(lblRoom)
            SetControlSize()
        End Set
    End Property

    <System.ComponentModel.Category("Layout")> <System.ComponentModel.DefaultValue("Notes")> Public Property Notes() As String
        Get
            Return lblNotes.Text
        End Get
        Set(ByVal value As String)
            lblNotes.Text = value
            CheckInput(lblNotes)
            SetControlSize()
        End Set
    End Property

  
#End Region

#Region "Other Routines"
    ''' <summary>
    ''' Routines the control calls but have no real association
    ''' </summary>
    ''' <param name="lblSource"></param>
    ''' <remarks></remarks>

    Private Sub CheckInput(ByVal lblSource As Label)
        If lblSource.Text = "" Then
            lblSource.Visible = False
        Else
            lblSource.Visible = True
        End If
    End Sub

    Private Sub SetControlSize()
        ' Declare variables
        Dim intTime As Integer
        Dim intContact As Integer
        Dim intModule As Integer
        Dim intStaff As Integer
        Dim intRoom As Integer
        Dim intNotes As Integer

        intTime = CheckVisibility(lblTime)
        intContact = CheckVisibility(lblContact)
        intModule = CheckVisibility(lblModule)
        intStaff = CheckVisibility(lblStaff)
        intRoom = CheckVisibility(lblRoom)
        intNotes = CheckVisibility(lblNotes)

        ' Get the heights of the panels
        intTopPanel = intTime + intPanelPad
        intMiddlePanel = intContact + intModule + intStaff + intRoom + intPanelPad
        intBottomPanel = intNotes + intPanelPad

        ' Set the heights of the panels
        pnlTop.Height = intTopPanel
        pnlMiddle.Height = intMiddlePanel
        pnlBottom.Height = intBottomPanel

        ' Set the position of labels in the middle panel
        lblContact.BringToFront()
        lblModule.BringToFront()
        lblStaff.BringToFront()
        lblRoom.BringToFront()

        ' Set the size of the control
        intControlHeight = intTopPanel + intMiddlePanel + intBottomPanel
        Me.Height = intControlHeight
        Me.Refresh()
    End Sub

    Private Function CheckVisibility(ByVal lblSource As Label) As Integer
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
