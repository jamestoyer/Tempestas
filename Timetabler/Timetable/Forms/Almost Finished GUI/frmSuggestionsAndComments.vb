Imports System.Net.Mail  'import the dll for sending emails

Public Class frmSuggestionsAndComments
    'Resets the progress bar labels to their orginal values
    Private Sub Reset_Progress_Box()
        btnError.Visible = False
        SendingProgress.Visible = False
        Progress1.Visible = True
        Progress2.Text = ""
        Progress3.Visible = False
        Progress4.Visible = False
        Progress1.ForeColor = Color.DarkSlateGray
        Progress2.ForeColor = Color.DarkSlateGray
    End Sub

    'Creates the message of the email to go into the body section
    Private Function Build_Mail_Message(ByVal name As String, ByVal email As String, ByVal version As String, ByVal comment As String)
        Dim BuildMessage As String
        Dim Today As Date = Now

        BuildMessage = "Toyer Technologies TimeTable App: v" & version.ToString & ControlChars.Cr & ControlChars.Cr + _
                        "Name: " & name.ToString & ControlChars.Cr + _
                        "Email: " & email.ToString & ControlChars.Cr + _
                        "Suggestion/Comment: " & comment.ToString & ControlChars.Cr + _
                        "-----------------------------------------------------------" & ControlChars.Cr + _
                        "Generated on: " & Today
        Return BuildMessage
    End Function

    'Timer - counts down 5 secs then starts getting rid of the progress box and then closes the form
    Private Sub DisposeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDisposeTimer.Tick
        If SendingProgress.Height <= 0 Then
            'IF the progress box is either to small to see or a negative size then
            'close the form
            SendingProgress.Visible = False

            ' Enable the form and close it
            Me.Enabled = True
            Me.Close()
        Else
            'if the height of the progressbox is still not zero take a little bit more off
            'giving it an animated effect of it scrolling up
            SendingProgress.Height = SendingProgress.Height - 10
            tmrDisposeTimer.Interval = 20
        End If
    End Sub

    'Send button click
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'Disable the form
        Me.Enabled = False

        Call Reset_Progress_Box() 'Reset all the values of the controls within the progressbox to their defaults


        If TxtSuggestion.Text = Nothing Then 'if the user hasn't entered a suggestion or comment, tell em' and exit sub
            MessageBox.Show("Please enter a comment or suggestion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Enable the form
            Me.Enabled = True

            ' Exit the event
            Return
        End If

        'Update the progress box
        SendingProgress.Visible = True
        SendingProgress.Refresh()

        Try
            Dim client As New SmtpClient("mail.toyertechnologies.com") 'Declare the smtp client used to send through
            'Email address this email will appear from
            Dim fromAdd As New MailAddress("comments@toyertechnologies.com", "TimeTable - Comments")
            'Email adddress the message will go to
            Dim toAdd As New MailAddress("comments@toyertechnologies.com", "Comments - Program")
            'Create a message
            Dim message As New MailMessage(fromAdd, toAdd)
            'Set the subject of the email
            message.Subject = "TimeTable Suggestion or Comment"
            'go to another sub and build the actual body of the email message
            message.Body = Build_Mail_Message(TxtName.Text, TxtEmail.Text, LblVersion.Text, TxtSuggestion.Text)
            'Select the port number
            client.Port = 26

            'Update the progress box
            Progress2.Visible = True
            Progress2.Text = "Sending your Suggestion/Comment(s)..."
            SendingProgress.Refresh()

            'The main bit! - Send the god damn message, will require access to internet via firewall!!
            client.Send(message)

            'Update the progress box
            Progress1.ForeColor = Color.Gray    'Fade out previous messages
            Progress2.ForeColor = Color.Gray
            Progress3.Visible = True
            Progress4.Visible = True
            'Enable the timer, which will count down until the form closes
            tmrDisposeTimer.Enabled = True

        Catch err As Exception
            'Argh! an error occured!

            'Update the progress box
            Progress1.ForeColor = Color.Gray    'Fade out previous messages
            Progress2.Text = "An unknown error occured."
            btnError.Visible = True 'Display OK button on the progress bar (Meaning go and try again)
            Console.WriteLine(err.ToString) 'Write error out to console window

            ' Enable the form
            Me.Enabled = True
        End Try
    End Sub

    'Cancel button click - closes the form
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Error OK button click - closes the status box and allows the user to try again
    Private Sub btnError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnError.Click
        SendingProgress.Visible = False
    End Sub

    Private Sub frmSuggestionsAndComments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        LblVersion.Text = System.String.Format(LblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
    End Sub
End Class
