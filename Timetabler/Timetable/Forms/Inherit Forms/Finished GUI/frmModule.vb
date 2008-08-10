Public Class frmModule
    ' Array to hold the database entry ids of the staff
    Public intEntryID() As Integer

    ' Variable to hold the dialog result of the new room form
    Public diaNewStaff As DialogResult

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If diaNewStaff = Windows.Forms.DialogResult.OK Then
            ' Set the dialog result to that of the new room form
            Me.DialogResult = diaNewStaff
        Else
            ' Set the dialog result to cancel
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        ' Close the form
        Me.Close()
    End Sub

    ' Event holding the default loading procedures
    Public Sub DefaultLoad()
        ' Remove the text from the text boxes
        txtModuleCode.Text = Nothing
        txtModuleTitle.Text = Nothing

        ' Populate the combo box
        ComboFourFieldsWithArray(cboStaff, intEntryID, "Staff", "Initials", "StaffID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Initials", "Salutation", "FirstName", "Surname")

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the text box
        Me.ActiveControl = txtModuleCode
    End Sub

    Private Sub btnNewStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewStaff.Click
        ' Open the new room form
        frmNewStaff.ShowDialog()

        ' Get the dialog result of the form
        diaNewStaff = frmNewStaff.DialogResult

        If diaNewStaff = Windows.Forms.DialogResult.OK Then
            ' Populate the Staff combo box
            ComboFourFieldsWithArray(cboStaff, intEntryID, "Staff", "Initials", "StaffID", "TimetableID", intTimetable(intEnumTimetable.TimetableID), "Initials", "Salutation", "FirstName", "Surname")

            ' Hide the error label
            lblError.Visible = False

            ' Set the focus to the text box
            Me.ActiveControl = txtModuleCode
        End If
    End Sub

    ' Event to check for errors
    Public Sub ErrorCheck()
        ' Hide the error label
        lblError.Visible = False

        ' Check to see if a value has been entered
        If txtModuleCode.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Set the back colour of the text box to misty rose
            txtModuleCode.BackColor = Color.MistyRose
        End If
    End Sub
End Class