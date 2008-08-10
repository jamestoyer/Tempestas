Public NotInheritable Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        ' Create a variable to hold the size of the primary screen
        Dim sizPrimaryScreen As Size

        ' Point to store where the form should be displayed
        Dim pntLocation As Point

        ' Get the size of the working area
        sizPrimaryScreen = New Size(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)

        ' Calculate the position of the form
        pntLocation.X = (sizPrimaryScreen.Width - Me.Size.Width) / 2
        pntLocation.Y = (sizPrimaryScreen.Height - Me.Size.Height) / 2

        Me.StartPosition = FormStartPosition.Manual

        Me.Location = pntLocation

    End Sub

End Class
