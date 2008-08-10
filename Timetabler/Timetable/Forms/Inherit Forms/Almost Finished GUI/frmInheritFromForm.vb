Public Class frmInheritFromForm
    ' Constant for the padding in which the cursor will change
    Const intPad As Integer = 5

    ' Variable that will hold the size of the form
    Dim sizFormSize As Size

    ' Variable that will hold the location of the mouse pointer
    Dim pntCursorChangeMouseLocation As Point

    ' Variable that will hold the location of the mouse pointer when the mouse is clicked
    Dim pntFormMoveMouseLocation As Point

    ' Boolean to find out if the form can be resized or not
    Dim boolResizeable As Boolean = True

    ' Boolean to find out if the title bar buttons are shown
    Dim boolHide As Boolean

    ' Variables for setting the title text of the form
    Dim strTitleString As String
    Dim fntHeader As New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel)

    ''' <summary>
    ''' Integer to hold the current state of the window
    ''' </summary>
    ''' <remarks></remarks>
    Dim intWindowState As Integer

    ''' <summary>
    ''' Stores the size of the window before maximising it
    ''' </summary>
    ''' <remarks></remarks>
    Dim sizWindowSize As Size

    ''' <summary>
    ''' Stores the location of the window before maximising it
    ''' </summary>
    ''' <remarks></remarks>
    Dim pntWindowLocation As Point

    Public Overridable Sub frmInheritFromForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set the backcolour of the form
        Me.BackColor = Color.Lime

        ' Get the window state
        intWindowState = Me.WindowState
    End Sub

    Public Overridable Sub frmInheritFromForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        ' Set the form size variable to the size of the form
        sizFormSize = Me.Size

        ' Check to see if the left mouse button is clicked and act accordingly
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Call the resize form sub
            ResizeForm(e)
        ElseIf (boolResizeable = True) And (intWindowState <> FormWindowState.Maximized) Then
            ' Set the mouse point variable to the point where the mouse is
            pntCursorChangeMouseLocation = e.Location

            ' Find out where the mouse is and change the cursor accordingly
            If (pntCursorChangeMouseLocation.X >= (sizFormSize.Width - intPad)) And (pntCursorChangeMouseLocation.Y >= (sizFormSize.Height - intPad)) Then
                ' If the mouse reaches the bottom right corner change the cursor to a diagnal one
                Me.Cursor = Cursors.SizeNWSE
            ElseIf pntCursorChangeMouseLocation.X >= (sizFormSize.Width - intPad) Then
                ' If the mouse reaches the right hand side of the form change the cursor to a left-right one
                Me.Cursor = Cursors.SizeWE
            ElseIf pntCursorChangeMouseLocation.Y >= (sizFormSize.Height - intPad) Then
                ' If the mouse reaches the bottom of the form change the cursor to an up-down one
                Me.Cursor = Cursors.SizeNS
            Else
                ' If none of the above conditions apply, reset the cursor
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Public Overridable Sub pnlHeaderBar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeaderBar.MouseDoubleClick
        ' If the resizeable boolean is false then exit the sub
        If boolResizeable = False Then Return

        ' Call the resize method
        RestoreMaximise()

    End Sub

    Public Overridable Sub pnlHeaderBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeaderBar.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntFormMoveMouseLocation = e.Location
    End Sub

    Public Overridable Sub pnlHeaderBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeaderBar.MouseMove
        ' Declare a variable to position the form
        Dim pntLocation As Point

        ' Set the form size variable to the size of the form
        sizFormSize = Me.Size

        ' Set the mouse point variable to the point where the mouse is
        pntCursorChangeMouseLocation = e.Location

        ' Decide on the status of the cursor, buttons clicked and mouse position and act accordingly
        If (e.Button = Windows.Forms.MouseButtons.Left) And (Me.Cursor = Cursors.SizeWE) Then
            ' Call the resize form sub
            ResizeForm(e)
        ElseIf e.Button = Windows.Forms.MouseButtons.Left And (intWindowState <> FormWindowState.Maximized) Then
            ' Moves the form when the left hand mouse button is pressed
            Do Until e.Button <> Windows.Forms.MouseButtons.Left
                ' Find out where the location of the form should be 
                pntLocation = MousePosition - CType(pntFormMoveMouseLocation, Size)

                ' Set the location of the form in respect to the desktop
                Me.Location = pntLocation

                ' Refresh the form
                Me.Refresh()
                Exit Do
            Loop
        ElseIf (pntCursorChangeMouseLocation.X >= (sizFormSize.Width - intPad)) And (boolResizeable = True) And (intWindowState <> FormWindowState.Maximized) Then
            ' If the mouse reaches the right hand side of the form change the cursor to a left-right one
            Me.Cursor = Cursors.SizeWE
        Else
            ' Reset the cursor to it's default
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Public Overridable Sub ResizeForm(ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Variable that will hold the new size of the form
        Dim sizNewFormSize As Size

        ' Set the new form size variable to the current form size
        sizNewFormSize = sizFormSize
        ' Find out what the cursor is and act accordingly
        Select Case Me.Cursor
            Case Cursors.SizeWE
                ' Set the new form size variable width to that of the position of the mouse
                sizNewFormSize.Width = e.X
            Case Cursors.SizeNS
                ' Set the new form size variable height to that of the position of the mouse
                sizNewFormSize.Height = e.Y
            Case Cursors.SizeNWSE
                ' Set the new form size variable to that of the position of the mouse
                sizNewFormSize = CType(e.Location, Size)
            Case Else
                Return
        End Select

        ' Set the new size variable to the be the size of the form
        Me.Size = sizNewFormSize

        ' Refresh the form and panel
        Me.Refresh()
        pnlHeaderBar.Refresh()
    End Sub

    ' Property to determin if the form is resizable or not
    Public Overridable Property Resizeable() As Boolean
        Get
            Return boolResizeable
        End Get
        Set(ByVal value As Boolean)
            boolResizeable = value
        End Set
    End Property

    ' Property to set the title text of the form
    Public Property TitleText() As String
        Get
            Return strTitleString
        End Get
        Set(ByVal value As String)
            strTitleString = value
            Me.Text = strTitleString
        End Set
    End Property

    Public Property HideTitleButtons() As Boolean
        Get
            Return boolHide
        End Get
        Set(ByVal value As Boolean)
            boolHide = value

            ' Check the status of the boolean and act accordingly
            If boolHide = True Then
                btnCloseCross.Visible = False
                btnMaximise.Visible = False
                btnMinimise.Visible = False
            Else
                btnCloseCross.Visible = True
                btnMaximise.Visible = True
                btnMinimise.Visible = True
            End If
          
        End Set
    End Property

    Public Overridable Sub frmInheritFromForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Set the form size variable to the size of the form
        sizFormSize = Me.Size

        ' Determin the window state
        If intWindowState = FormWindowState.Normal Then
            ' Draw the bottom left arc border
            e.Graphics.FillPie(Brushes.Black, 0, sizFormSize.Height - 30, 30, 30, 90, 90)

            ' Draw the line boarders
            e.Graphics.DrawLine(Pens.Black, 0, 29, 0, sizFormSize.Height - 16)
            e.Graphics.DrawLine(Pens.Black, sizFormSize.Width - 1, 29, sizFormSize.Width - 1, sizFormSize.Height)
            e.Graphics.DrawLine(Pens.Black, 15, sizFormSize.Height - 1, sizFormSize.Width, sizFormSize.Height - 1)

            ' Draw the fill arc
            e.Graphics.FillPie(Brushes.White, 1, sizFormSize.Height - 31, 30, 30, 90, 90)

            ' Draw the fill rectangles
            e.Graphics.FillRectangle(Brushes.White, 1, 29, sizFormSize.Width - 2, sizFormSize.Height - 45)
            e.Graphics.FillRectangle(Brushes.White, 16, sizFormSize.Height - 16, sizFormSize.Width - 17, 15)

            ' Reset the back colour
            Me.BackColor = Color.Lime
        ElseIf intWindowState = FormWindowState.Maximized Then
            ' Set the back colour of the form to white
            Me.BackColor = Color.White
        End If
    End Sub

    Public Overridable Sub pnlHeaderBar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlHeaderBar.Paint
        ' Set the width of the panel to that of the form
        pnlHeaderBar.Width = Me.Width

        ' Draw the form name onto the top bar
        e.Graphics.DrawString(strTitleString, fntHeader, Brushes.White, 5, 7)

        ' Check the state of the form
        If intWindowState = FormWindowState.Normal Then
            ' Draw the right hand title bar image in the correct place
            e.Graphics.DrawImage(My.Resources.resInheritFromFormImages.TitleBarRightEdge, sizFormSize.Width - 30, 0, 30, 29)
        End If
    End Sub

    Private Sub btnCloseCross_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCloseCross.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnMaximise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaximise.Click
        ' Call the resize method
        RestoreMaximise()
    End Sub

    Private Sub btnMinimise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimise.Click
        ' Minimise the form
        Me.WindowState = FormWindowState.Minimized

        ' Refresh the form
        Me.Refresh()
    End Sub

    ''' <summary>
    ''' Method to ensure that the form maximises and restores to the correct size
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RestoreMaximise()
        ' Decide the window state and act accordingly
        If intWindowState = FormWindowState.Normal Then
            ' Variable for holding the bounds of where the form should be
            Dim recFormBounds As Rectangle

            ' Get the current location of the form
            pntWindowLocation = Me.Location

            ' Get the current size of the form
            sizWindowSize = Me.Size

            ' Get the new bounds of the form
            recFormBounds = CheckScreen()

            ' Set the new bounds to the form bounds
            Me.Bounds = recFormBounds

            ' Set the position of the buttons
            PositionTitleButtons()

            ' Set the state variable
            intWindowState = FormWindowState.Maximized
            Me.Refresh()
        ElseIf intWindowState = FormWindowState.Maximized Then
            ' Restore the window to it's original size and location
            Me.Size = sizWindowSize
            Me.Location = pntWindowLocation

            ' Set the position of the buttons
            PositionTitleButtons()

            ' Set the state variable
            intWindowState = FormWindowState.Normal
            Me.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' Checks to see which screen the form is in
    ''' </summary>
    ''' <returns>Returns the rectangle the form should be</returns>
    ''' <remarks></remarks>
    Private Function CheckScreen() As Rectangle
        ' Array to hold all the screens available
        Dim scnAllScreens(0) As Windows.Forms.Screen

        ' Array to hold the rectangle of the screens
        Dim recScreens(0) As Rectangle

        ' Resize the screen array
        Array.Resize(scnAllScreens, My.Computer.Screen.AllScreens.Length)

        ' Get he all screens array
        Array.Copy(My.Computer.Screen.AllScreens, scnAllScreens, My.Computer.Screen.AllScreens.Length)

        ' Resize the rectangle array
        Array.Resize(recScreens, scnAllScreens.Length)

        For intIndex As Integer = 0 To scnAllScreens.Length
            ' Check to see if the for is within the current screen
            If ((scnAllScreens(intIndex).Bounds.X) <= pntWindowLocation.X) And (pntWindowLocation.X <= (scnAllScreens(intIndex).Bounds.X + scnAllScreens(intIndex).Bounds.Width)) Then
                If ((scnAllScreens(intIndex).Bounds.Y) <= pntWindowLocation.Y) And (pntWindowLocation.Y <= (scnAllScreens(intIndex).Bounds.Y + scnAllScreens(intIndex).Bounds.Height)) Then
                    ' Return the rectangle for the working bounds of the screen
                    Return scnAllScreens(intIndex).WorkingArea
                End If
            End If
            ' Get the rectangle for each screen
            recScreens(intIndex) = scnAllScreens(intIndex).Bounds
        Next

        Return scnAllScreens(scnAllScreens.Length).WorkingArea
    End Function

    Private Sub PositionTitleButtons()

        ' Set the position of the cross button
        btnCloseCross.Location = New Point(Me.Size.Width - (800 - 772), btnCloseCross.Location.Y)
        btnMaximise.Location = New Point(Me.Size.Width - (800 - 746), btnMaximise.Location.Y)
        btnMinimise.Location = New Point(Me.Size.Width - (800 - 720), btnMinimise.Location.Y)
    End Sub
End Class