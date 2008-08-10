Public Class frmAddModule

    Private Sub frmAddModule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Remove the text from the text boxes
        txtModuleCode.Text = Nothing
        txtModuleTitle.Text = Nothing

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the module code text box
        Me.ActiveControl = txtModuleCode

    End Sub

#Region "Form Movement"

    Private Sub frmAddModule_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntMouseLocation = e.Location
    End Sub

    Private Sub frmAddModule_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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

    Private Sub pbbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbAdd.Click
        ' Check to see that the module code has been entered
        If txtModuleCode.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Exit the sub
            Return
        Else
            ' Add the values to the database
            AddToCBOTwoFields("Module", "ModuleCode", "ModuleName", txtModuleCode.Text, txtModuleTitle.Text)

            ' Update the module combo box on the parent form
            PopulateCBOTwoFieldsArray(frmAddNewEntry.cboModule, intModule, "Module", "ModuleCode", "ModuleID", "ModuleCode", "ModuleName")
            PopulateCBOTwoFieldsArray(frmModifyEntry.cboModule, intModule, "Module", "ModuleCode", "ModuleID", "ModuleCode", "ModuleName")

            ' Close the add form
            Me.Close()
        End If
    End Sub

    Private Sub pbbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbCancel.Click
        ' Close the current from without any changes
        Me.Close()
    End Sub

    Private Sub frmAddModule_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Draw the form name onto the top bar
        e.Graphics.DrawString("New Module", fntHeader, Brushes.White, 9, 7)

    End Sub

    Private Sub pbbModuleCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbModuleCodeHelp.Click
        tipHelp.Show("The module code associated with module. This is a required field", pbbModuleCodeHelp)

    End Sub

    Private Sub pbbModuleTitleHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbModuleTitleHelp.Click
        tipHelp.Show("The name of the module", pbbModuleTitleHelp)

    End Sub
End Class