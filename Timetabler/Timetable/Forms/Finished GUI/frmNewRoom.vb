Public Class frmNewRoom

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
        AddFourFields("Room", "Number", txtRoomNumber.Text, "Department", txtDepartment.Text, "UserID", strUserInfo(intUserInfo.ID), "TimetableID", intTimetable(intEnumTimetable.TimetableID))

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the add form
        Me.Close()

    End Sub

    Private Sub frmNewRoom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default contact startup events
        RoomStartUpEvents()
    End Sub
End Class
