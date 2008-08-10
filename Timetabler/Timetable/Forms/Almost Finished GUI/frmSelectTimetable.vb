Public Class frmSelectTimetable
    ' Array to hold the timetables for the user
    Dim intTimetables(0) As Integer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result of the form to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ' Load the create new timetable form
        frmNewTimetableSystem.ShowDialog()

        ' Act according to the dialog result
        If frmNewTimetableSystem.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Set the dialog result of the form to ok
            Me.DialogResult = Windows.Forms.DialogResult.OK

            ' Close the form
            Me.Close()
        End If
    End Sub

    Private Sub frmSelectTimetable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Hide the error label
        lblError.Visible = False

        ' Populate the combo box
        ComboOneFieldWithArray(cboTimetable, intTimetables, "Timetable", "TimetableName", "TimetableID", "UserID", strUserInfo(intUserInfo.ID), "TimetableName")
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        ' Error label constant
        Const strNoTimetableSelected As String = "Please select a timetable"

        ' Sql variables
        Dim cmdSelect As SqlClient.SqlCommand
        Dim rdrResults As SqlClient.SqlDataReader

        ' Check to see if a timetable has been selected
        If cboTimetable.SelectedIndex < 1 Then
            ' Set the error message of the label
            lblError.Text = strNoTimetableSelected

            ' Centre the label
            LabelCentreX(lblError, Me)

            ' Make the label visible
            lblError.Visible = True
        Else
            ' Get the corresponding timetable id of the selected item and set it to the global timetable variable
            intTimetable(intEnumTimetable.TimetableID) = intTimetables(cboTimetable.SelectedIndex)

            ' Construct the statemetn to find the timetable system
            cmdSelect = New SqlClient.SqlCommand("SELECT System FROM Timetable WHERE TimetableID = " & intTimetable(intEnumTimetable.TimetableID), ctnTimetable)

            ' Read from the database
            rdrResults = cmdSelect.ExecuteReader
            rdrResults.Read()

            ' Get the results from the reader
            intTimetable(intEnumTimetable.System) = rdrResults!System

            ' Close the reader and dispose of the command
            cmdSelect.Dispose()
            rdrResults.Close()

            ' Set the dialog result to ok
            Me.DialogResult = Windows.Forms.DialogResult.OK

            ' Close the form
            Me.Close()
        End If
    End Sub
End Class
