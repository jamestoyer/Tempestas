Public Class frmAddStaff
    Private Sub frmAddStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Remove the text from the text boxes
        txtStaffInitials.Text = Nothing
        txtStaffName.Text = Nothing

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the Staff Initials text box
        Me.ActiveControl = txtStaffInitials

    End Sub

    Private Sub pbbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbAdd.Click
        If txtStaffInitials.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Exit the sub
            Return
        Else
            ' Add the values to the database
            AddToCBOTwoFields("Staff", "Initials", "Surname", txtStaffInitials.Text, txtStaffName.Text)

            ' Update the module combo box on the parent form
            PopulateCBOThreeFieldsArray(frmAddNewEntry.cboStaff, intStaff, "Staff", "Initials", "StaffID", "Initials", "Surname", "FirstName")
            PopulateCBOThreeFieldsArray(frmModifyEntry.cboStaff, intStaff, "Staff", "Initials", "StaffID", "Initials", "Surname", "FirstName")

            ' Close the add form
            Me.Close()
        End If  
    End Sub

    Private Sub pbbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbCancel.Click
        ' Close the current from without any changes
        Me.Close()
    End Sub

#Region "Form Movement"

    Private Sub frmAddStaff_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntMouseLocation = e.Location
    End Sub

    Private Sub frmAddStaff_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' Declare a variable to position the form
        Dim pntLocation As Point

        ' Variable to determin size of the title bar
        Dim intTitleBarSize As Integer = 29

        ' Check to see if the mouse is clicked on the title bar
        If pntMouseLocation.Y <= intTitleBarSize Then
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

    Private Sub frmAddStaff_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Draw the form name onto the top bar
        e.Graphics.DrawString("New Staff Member", fntHeader, Brushes.White, 9, 7)
    End Sub

    Private Sub pbbStaffInitialsHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbStaffInitialsHelp.Click
        tipHelp.Show("The intials of a staff member, maximum 3. This is a required field", pbbStaffInitialsHelp)
    End Sub

    Private Sub pbbStaffNameHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbStaffNameHelp.Click
        tipHelp.Show("The member of staff's name", pbbStaffNameHelp)
    End Sub
End Class