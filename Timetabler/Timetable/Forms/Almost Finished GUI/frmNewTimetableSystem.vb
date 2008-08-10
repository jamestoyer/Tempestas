Public Class frmNewTimetableSystem

    Private Sub frmNewTimetableSystem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Run the default load event
        DefaultLoad()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ' Check to see which radio button is selected and act accordingly
        If radWeek.Checked = True Then
            ' Load the new week timetable form
            frmNewWeekTimetable.ShowDialog()

            ' Check to see if the dialog result is ok and close the form
            If frmNewWeekTimetable.DialogResult = Windows.Forms.DialogResult.OK Then
                ' Set the dialog result of the form to ok
                Me.DialogResult = Windows.Forms.DialogResult.OK

                ' Close the form
                Me.Close()
            End If
        ElseIf radTerm.Checked = True Then
            ' Load the new term timetable form
            frmNewTermTimetable.ShowDialog()

            ' Check to see if the dialog result is ok and close the form
            If frmNewTermTimetable.DialogResult = Windows.Forms.DialogResult.OK Then
                ' Set the dialog result of the form to ok
                Me.DialogResult = Windows.Forms.DialogResult.OK

                ' Close the form
                Me.Close()
            End If
        ElseIf radBoth.Checked = True Then
            ' Load the new term timetable form
            frmNewBothTimetable.ShowDialog()

            ' Check to see if the dialog result is ok and close the form
            If frmNewBothTimetable.DialogResult = Windows.Forms.DialogResult.OK Then
                ' Set the dialog result of the form to ok
                Me.DialogResult = Windows.Forms.DialogResult.OK

                ' Close the form
                Me.Close()
            End If
        Else
            ' Show the error label
            lblError.Show()

            ' Exit the event
            Return
        End If
    End Sub
End Class
