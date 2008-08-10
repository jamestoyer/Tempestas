Public Class frmFindDatabase

    Private Sub frmFindDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Hide the error label
        lblError.Visible = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Set the dialog result of the form to cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Variable to store the original location in case of error
        Dim strPreviousLocation As String

        ' Check to see if there is a value in the text box
        If txtLocation.Text = "" Then
            ' Show the error label
            lblError.Visible = True
        Else
            ' Check to see if there is a connection already and if so close it
            If ctnTimetable IsNot Nothing Then CloseConnection()

            ' Set the current connection string to the backup variable
            strPreviousLocation = My.Settings.dbPath

            ' Set the text box string to the location string
            My.Settings.dbPath = Trim(txtLocation.Text)

            ' Connect to the database
            boolConnectionStatus = OpenConnection()

            ' If there is no connection inform the user
            If boolConnectionStatus <> True Then
                ' Show the error label
                lblError.Visible = True

                ' Reset the connection string
                My.Settings.dbPath = strPreviousLocation
            Else
                ' Set the dialog result of the form to return
                Me.DialogResult = Windows.Forms.DialogResult.OK

                ' Close the form
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ' Create a variable to place the file location string in
        Dim strFileLocation As String

        ' If ok is pressed put the file location into the string and convert it to the array
        If ofdLocation.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Get the location from the dialog
            strFileLocation = Trim(ofdLocation.FileName)

            ' Set the text box to show the location
            txtLocation.Text = strFileLocation
        Else
            txtLocation.Text = ""
        End If
    End Sub
End Class
