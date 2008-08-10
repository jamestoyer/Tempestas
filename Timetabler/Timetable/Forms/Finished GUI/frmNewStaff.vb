Public Class frmNewStaff

    Private Sub frmNewStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Clear the text boxes
        txtEmail.Text = ""
        txtFirstName.Text = ""
        txtSalutation.Text = ""
        txtStaffInitials.Text = ""
        txtSurname.Text = ""

        ' Run the default load event
        DefaultLoad()

    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        If lblError.Visible = True Then
            ' Enable the form and exit the event
            Me.Enabled = True
            Return
        End If

        ' Add the values to the database
        AddEightFields("Staff", "Initials", txtStaffInitials.Text, "FirstName", txtFirstName.Text, "Salutation", txtSalutation.Text, "Surname", txtSurname.Text, "Email", txtEmail.Text, "RoomID", intEntryID(cboOffice.SelectedIndex), "UserID", strUserInfo(intUserInfo.ID), "TimetableID", intTimetable(intEnumTimetable.TimetableID))

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the add form
        Me.Close()
    End Sub
End Class
