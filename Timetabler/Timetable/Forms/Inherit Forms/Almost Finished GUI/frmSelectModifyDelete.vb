Public Class frmSelectModifyDelete
    ' Create an array to store the ID of each event
    Public intEntryID() As Integer

    ' Create a variable to hold the selected ID for use when deleting and modifying
    Public intSelectedID As Integer

    ' Variable to hold the dialog result of the destination form
    Public diaDestinationResult As DialogResult = Windows.Forms.DialogResult.Cancel

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If diaDestinationResult <> Windows.Forms.DialogResult.Cancel Then
            ' Set the dialog result to the dialog result of the update item form
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

        ' Close the form
        Me.Close()
    End Sub

    Public Sub UpdateErrorLabel(ByVal strErrorText As String)
        ' Hide the label
        lblError.Visible = False

        ' Set the new error text to the label 
        lblError.Text = strErrorText

        ' Centre the label
        LabelCentreX(lblError, Me)
    End Sub

    Public Sub ModifyButtonClicked(ByRef frmDestinationForm As Form)
        ' Declare Other Variables
        Dim intIndex As Integer

        ' Get the selected item from the list box
        intIndex = lstEvents.SelectedIndex

        ' Determin what to do depending on the selected index
        If intIndex = -1 Then
            ' Show the error label
            lblError.Visible = True
        Else

            ' Set the selected ID
            intSelectedID = intEntryID(intIndex)

            ' Hide the error label
            lblError.Visible = False

            ' Open update item form as dialog
            frmDestinationForm.ShowDialog()

            ' If the dialog result is already okm retry or yes, exit end the event to ensure the main screen is refreshed 
            Select Case diaDestinationResult
                Case Windows.Forms.DialogResult.OK, Windows.Forms.DialogResult.Retry, Windows.Forms.DialogResult.Yes
                    ' Set the dialog result to ok
                    diaDestinationResult = Windows.Forms.DialogResult.OK
                    Return
            End Select


            ' Get the dialog result from the update item form
            diaDestinationResult = frmDestinationForm.DialogResult
        End If
    End Sub
End Class
