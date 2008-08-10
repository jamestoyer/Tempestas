Public Class frmNewContact

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        ' Variable to hold the string of the colour
        Dim strColour As String

        ' Disable the form
        Me.Enabled = False

        ' Check for errors
        ErrorCheck()

        ' Check to see if the error label is visible
        If lblError.Visible = True Then
            ' Enable the from and exit the event
            Me.Enabled = True
            Return
        End If

        ' Convert the colour to a string
        strColour = ConvertColourToText(cboColour.BackColor)

        ' Add the values to the database
        AddFourFields("Contact", "Type", txtContact.Text, "Colour", strColour, "UserID", strUserInfo(intUserInfo.ID), "TimetableID", intTimetable(intEnumTimetable.TimetableID))

        ' Set the dialog result to ok
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Enable the form
        Me.Enabled = True

        ' Close the add form
        Me.Close()

    End Sub

    Private Sub frmNewContact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default contact startup events
        ContactStartUpEvents()
    End Sub
End Class
