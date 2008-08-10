Public Class frmStaff
    ' Array to hold the database entry ids of the rooms
    Public intEntryID() As Integer

    ' Variable to hold the dialog result of the new room form
    Public diaNewRoom As DialogResult

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If diaNewRoom = Windows.Forms.DialogResult.OK Then
            ' Set the dialog result to that of the new room form
            Me.DialogResult = diaNewRoom
        Else
            ' Set the dialog result to cancel
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        
        ' Close the form
        Me.Close()
    End Sub

    ' Event holding the default loading procedures
    Public Sub DefaultLoad()
        ' Clear the form of data
        txtSalutation.Text = Nothing
        txtFirstName.Text = Nothing
        txtSurname.Text = Nothing
        txtStaffInitials.Text = Nothing
        txtEmail.Text = Nothing

        ' Populate the combo box
        ComboTwoFieldsWithArray(cboOffice, intEntryID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the text box
        Me.ActiveControl = txtSalutation
    End Sub

    Private Sub btnNewRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRoom.Click
        ' Open the new room form
        frmNewRoom.ShowDialog()

        ' Get the dialog result of the form
        diaNewRoom = frmNewRoom.DialogResult

        If diaNewRoom = Windows.Forms.DialogResult.OK Then
            ' Populate the combo box
            ComboTwoFieldsWithArray(cboOffice, intEntryID, "Room", "Number", "RoomID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Number", "Department")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = txtSalutation
        End If

    End Sub

    ' Event to check for errors
    Public Sub ErrorCheck()
        ' Hide the error label
        lblError.Visible = False

        ' Check to see if a value has been entered
        If txtStaffInitials.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Set the back colour of the text box to misty rose
            txtStaffInitials.BackColor = Color.MistyRose
        End If
    End Sub
End Class
