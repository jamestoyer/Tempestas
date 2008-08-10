Public Class frmAddContact
    ' The original point the mouse down function is called when moving the form
    Private pntMouseLocation As Point

    Private Sub frmAddContact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Hide the error label
        lblError.Visible = False

        ' Ensure that the text box is empty
        txtContact.Text = Nothing

        ' Set the focus to the text box
        Me.ActiveControl = txtContact
    End Sub

#Region "Form Movement"

    Private Sub frmAddContact_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntMouseLocation = e.Location
    End Sub

    Private Sub frmAddContact_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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
        ' Check to see if a value has been entered
        If txtContact.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Exit the sub
            Return
        Else
            ' Add the values to the database
            AddToCBOOneField("Contact", "Type", txtContact.Text)

            ' Update the module combo box on the parent form
            PopulateCBOOneFieldArray(frmAddNewEntry.cboContactType, intContact, "Contact", "Type", "ContactID", "Type")
            PopulateCBOOneFieldArray(frmModifyEntry.cboContactType, intContact, "Contact", "Type", "ContactID", "Type")

            ' Close the add form
            Me.Close()
        End If
    End Sub

    Private Sub PictureBoxButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbCancel.Click
        ' Close the current from without any changes
        Me.Close()
    End Sub
End Class