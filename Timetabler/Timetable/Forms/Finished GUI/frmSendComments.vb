Imports System.Net.Mail  'import the dll for sending emails

Public Class frmSendComments

    'Resets the progress bar labels to their orginal values
    Private Sub Reset_Progress_Box()
        pbbError.Visible = False
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
    Private Sub DisposeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisposeTimer.Tick
        If SendingProgress.Height <= 0 Then
            'IF the progress box is either to small to see or a negative size then
            'close the form
            SendingProgress.Visible = False
            Me.Close()
        Else
            'if the height of the progressbox is still not zero take a little bit more off
            'giving it an animated effect of it scrolling up
            SendingProgress.Height = SendingProgress.Height - 10
            DisposeTimer.Interval = 20
        End If
    End Sub

    'Send button click
    Private Sub pbbSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbSend.Click
        Call Reset_Progress_Box() 'Reset all the values of the controls within the progressbox to their defaults

        
        If TxtSuggestion.Text = Nothing Then 'if the user hasn't entered a suggestion or comment, tell em' and exit sub
            MessageBox.Show("Please enter a comment or suggestion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Update the progress box
        SendingProgress.Visible = True
        SendingProgress.Refresh()

        ' Disable the send button
        pbbSend.Enabled = False
        pbbSend.Refresh()

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
            DisposeTimer.Enabled = True
           
        Catch err As Exception
            'Argh! an error occured!

            'Update the progress box
            Progress1.ForeColor = Color.Gray    'Fade out previous messages
            Progress2.Text = "An unknown error occured."
            pbbError.Visible = True 'Display OK button on the progress bar (Meaning go and try again)
            Console.WriteLine(err.ToString) 'Write error out to console window

            ' Enable the send button
            pbbSend.Enabled = True
        End Try
    End Sub

    'Cancel button click - closes the form
    Private Sub pbbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbCancel.Click
        Me.Close()
    End Sub

    'Error OK button click - closes the status box and allows the user to try again
    Private Sub pbbError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbError.Click
        SendingProgress.Visible = False
    End Sub

    Private Sub frmSendComments_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Draw the form name onto the top bar
        e.Graphics.DrawString("Send Comment", fntHeader, Brushes.White, 9, 7)
    End Sub

#Region "Form Movement"

    Private Sub frmAddModule_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Gets the point where the mouse is on the form when clicked
        pntMouseLocation = e.Location
    End Sub

    Private Sub frmAddModule_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' Declare a variable to position the form
        Dim pntLocation As Point

        ' Variable to determin size of the title bar
        Dim intTitleBarSize As Integer = 29

        ' Check to see if the mouse is clicked on the title bar
        If pntMouseLocation.Y < intTitleBarSize Then
            ' Moves the form when the left hand mouse button is pressed
            Do Until e.Button <> Windows.Forms.MouseButtons.Left
                ' Find out where the location of the form should be 
                pntLocation = MousePosition - pntMouseLocation

                ' Set the location of the form in respect to the desktop
                Me.Location = pntLocation

                ' Refresh the form
                Me.Refresh()
                Exit Do
            Loop
        End If
    End Sub
#End Region
End Class
