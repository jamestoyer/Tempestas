Public Class frmRoom
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Public Sub RoomStartUpEvents()
        ' Clear the text boxes of content
        txtDepartment.Text = Nothing
        txtRoomNumber.Text = Nothing

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the text box
        Me.ActiveControl = txtRoomNumber
    End Sub

    ' Event to check for errors
    Public Sub ErrorCheck()
        ' Hide the error label
        lblError.Visible = False

        ' Check to see if a value has been entered
        If txtRoomNumber.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Set the back colour of the text box to misty rose
            txtRoomNumber.BackColor = Color.MistyRose
        End If
    End Sub

End Class
