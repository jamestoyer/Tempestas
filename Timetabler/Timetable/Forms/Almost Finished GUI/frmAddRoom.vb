Public Class frmAddRoom
    Private Sub pbbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbAdd.Click
        ' Check to see if a room number has been entered
        If txtRoomNumber.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Exit the sub
            Return
        Else
            ' Add the values to the database
            AddToCBOTwoFields("Room", "Number", "Department", txtRoomNumber.Text, txtDepartment.Text)

            ' Update the module combo box on the parent form
            PopulateCBOTwoFieldsArray(frmAddNewEntry.cboRoom, intRoom, "Room", "Number", "RoomID", "Number", "Department")
            PopulateCBOTwoFieldsArray(frmModifyEntry.cboRoom, intRoom, "Room", "Number", "RoomID", "Number", "Department")

            ' Close the add form
            Me.Close()
        End If
    End Sub

    Private Sub pbbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbCancel.Click
        ' Close the current from without any changes
        Me.Close()
    End Sub

    Private Sub frmAddRoom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Remove the text from the text boxes
        txtRoomNumber.Text = Nothing
        txtDepartment.Text = Nothing

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the Room Number text box
        Me.ActiveControl = txtRoomNumber
    End Sub

#Region "Form Movement"

    Private Sub frmAddRoom_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntMouseLocation = e.Location
    End Sub

    Private Sub frmAddRoom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' Declare a variable to position the form
        Dim pntLocation As Point

        ' Variable to determin size of the title bar
        Dim intTitleBarSize As Integer = 29

        ' Check to see if the mouse is clicked on the title bar
        If pntMouseLocation.Y < intTitleBarSize Then
            ' Moves the form when the left hand mouse button is pressed
            Do Until e.Button <> Windows.Forms.MouseButtons.Left
                ' Find out where the location of the form should be 
                pntLocation = MousePosition - pntMouseLocation

                ' Set the location of the form in respect to the desktop
                Me.Location = pntLocation

                ' Refresh the form
                Me.Refresh()
                Exit Do
            Loop
        End If
    End Sub
#End Region

    Private Sub frmAddRoom_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Draw the form name onto the top bar
        e.Graphics.DrawString("New Room", fntHeader, Brushes.White, 9, 7)
    End Sub

    Private Sub pbbRoomNumberHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbRoomNumberHelp.Click
        tipHelp.Show("The room number. This is a required field", pbbRoomNumberHelp)
    End Sub

    Private Sub pbbDepartmentHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbDepartmentHelp.Click
        tipHelp.Show("The department in which the room is located", pbbDepartmentHelp)
    End Sub
End Class