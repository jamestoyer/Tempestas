Public Class frmContact

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Public Sub ContactStartUpEvents()
        ' Reset the controls on the form
        txtContact.Text = Nothing
        txtContact.BackColor = Color.White
        cboColour.BackColor = Color.Black

        ' Centre the error label
        LabelCentreX(lblError, Me)

        ' Hide the error label
        lblError.Visible = False

        ' Set the focus to the text box
        Me.ActiveControl = txtContact
    End Sub

    Private Sub cboColour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColour.Click
        ' Set the colour of the colour dialog
        clrContactColour.Color = cboColour.BackColor

        ' Load the colour dialog
        clrContactColour.ShowDialog()

        ' Set the background of the combo box to the colour selected
        cboColour.BackColor = clrContactColour.Color

        ' Change the active control to accept
        ActiveControl = btnAccept
    End Sub

    ' Event to check for errors
    Public Sub ErrorCheck()
        ' Hide the error label
        lblError.Visible = False

        ' Check to see if a value has been entered
        If txtContact.Text = Nothing Then
            ' Show the error label
            lblError.Visible = True

            ' Set the back colour of the text box to misty rose
            txtContact.BackColor = Color.MistyRose
        End If
    End Sub
End Class
