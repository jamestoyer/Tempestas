''' <summary>
''' Events for checking and modifying text boxes.
''' </summary>
''' <remarks></remarks>
Public Class TextBoxEvents

    ''' <summary>
    ''' Allows only numbers to be entered into a text box. Can only be placed in the keydown event
    ''' </summary>
    ''' <param name="sender">The sender of the the text box</param>
    ''' <param name="e">The key event argument of the text box</param>
    ''' <remarks></remarks>
    Public Shared Sub AllowOnlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Allow only number entry
        Select Case e.KeyData
            Case (Keys.Shift + Keys.D0) To (Keys.Shift + Keys.D9)
                e.SuppressKeyPress = True
        End Select
        Select Case e.KeyCode
            Case Is > Keys.NumPad9
                e.SuppressKeyPress = True
            Case Keys.A To Keys.Z
                e.SuppressKeyPress = True
            Case Keys.Space
                e.SuppressKeyPress = True
        End Select
    End Sub

    ''' <summary>
    ''' Allows only text to be entered into a text box. Can only be placed in the keydown event
    ''' </summary>
    ''' <param name="sender">The sender of the the text box</param>
    ''' <param name="e">The key event argument of the text box</param>
    ''' <remarks></remarks>
    Public Shared Sub AllowOnlyText(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Allow only text entry
        Select Case e.KeyCode
            Case Keys.D0 To Keys.D9
                e.SuppressKeyPress = True
            Case Is > Keys.Z
                e.SuppressKeyPress = True
        End Select
    End Sub

    Public Shared Sub AllowAlphaNumeric(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Allow alpha numeric entry
        Select Case e.KeyData
            Case (Keys.Shift + Keys.D0) To (Keys.Shift + Keys.D9)
                e.SuppressKeyPress = True
        End Select
        Select Case e.KeyCode
            Case Is > Keys.NumPad9
                e.SuppressKeyPress = True
        End Select
    End Sub

    ''' <summary>
    ''' Event for displaying an error message and turning a text box back colour to misty red when there is an error with the input for the text box
    ''' </summary>
    ''' <param name="frmParent">The form text box belongs to</param>
    ''' <param name="strErrorMessage">The string to add to the error label</param>
    ''' <param name="lblError">The error label of the form</param>
    ''' <param name="txtErrorTextBox">The text box to be highlighted for the error</param>
    ''' <remarks></remarks>
    Public Shared Sub EntryError(ByRef frmParent As Form, ByVal strErrorMessage As String, ByRef lblError As Label, ByRef txtErrorTextBox As TextBox)

        ' Set the error label text
        lblError.Text = strErrorMessage

        ' Set the text box background to misty rose
        txtErrorTextBox.BackColor = Color.MistyRose

        ' Centre the error label
        LabelCentreX(lblError, frmParent)

        ' Show the error label
        lblError.Visible = True

        ' Enable the screen 
        frmParent.Enabled = True
    End Sub
End Class
