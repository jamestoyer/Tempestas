Public Class frmTimetableSystem

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Public Sub DefaultLoad()
        ' Position the error label
        LabelCentreX(lblError, Me)

        ' Hide the label
        lblError.Visible = False
    End Sub
End Class
