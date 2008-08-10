<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendComments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendComments))
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.LblName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSuggestion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblVersion = New System.Windows.Forms.Label
        Me.SendingProgress = New System.Windows.Forms.Panel
        Me.pbbError = New Timetable.PictureBoxButton
        Me.imgError = New System.Windows.Forms.ImageList(Me.components)
        Me.Progress4 = New System.Windows.Forms.Label
        Me.Progress3 = New System.Windows.Forms.Label
        Me.Progress2 = New System.Windows.Forms.Label
        Me.Progress1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.DisposeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.imgSend = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.pbbCancel = New Timetable.PictureBoxButton
        Me.pbbSend = New Timetable.PictureBoxButton
        Me.SendingProgress.SuspendLayout()
        CType(Me.pbbError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(142, 42)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(250, 20)
        Me.TxtName.TabIndex = 1
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Location = New System.Drawing.Point(13, 45)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(86, 13)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name (Optional):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Program Version:"
        '
        'TxtSuggestion
        '
        Me.TxtSuggestion.Location = New System.Drawing.Point(142, 120)
        Me.TxtSuggestion.Multiline = True
        Me.TxtSuggestion.Name = "TxtSuggestion"
        Me.TxtSuggestion.Size = New System.Drawing.Size(250, 160)
        Me.TxtSuggestion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Suggestion/Comment(s):"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.Location = New System.Drawing.Point(139, 97)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(31, 13)
        Me.LblVersion.TabIndex = 5
        Me.LblVersion.Text = "1.0.5"
        '
        'SendingProgress
        '
        Me.SendingProgress.BackColor = System.Drawing.Color.White
        Me.SendingProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SendingProgress.Controls.Add(Me.pbbError)
        Me.SendingProgress.Controls.Add(Me.Progress4)
        Me.SendingProgress.Controls.Add(Me.Progress3)
        Me.SendingProgress.Controls.Add(Me.Progress2)
        Me.SendingProgress.Controls.Add(Me.Progress1)
        Me.SendingProgress.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.SendingProgress.Location = New System.Drawing.Point(62, 120)
        Me.SendingProgress.Name = "SendingProgress"
        Me.SendingProgress.Size = New System.Drawing.Size(282, 91)
        Me.SendingProgress.TabIndex = 8
        Me.SendingProgress.Visible = False
        '
        'pbbError
        '
        Me.pbbError.BackColor = System.Drawing.Color.Transparent
        Me.pbbError.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbError.Image = CType(resources.GetObject("pbbError.Image"), System.Drawing.Image)
        Me.pbbError.ImageList = Me.imgError
        Me.pbbError.Location = New System.Drawing.Point(101, 60)
        Me.pbbError.Name = "pbbError"
        Me.pbbError.Size = New System.Drawing.Size(79, 23)
        Me.pbbError.TabIndex = 14
        Me.pbbError.TabStop = False
        '
        'imgError
        '
        Me.imgError.ImageStream = CType(resources.GetObject("imgError.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgError.TransparentColor = System.Drawing.Color.Lime
        Me.imgError.Images.SetKeyName(0, "btnOKUp.png")
        Me.imgError.Images.SetKeyName(1, "btnOKDown.png")
        Me.imgError.Images.SetKeyName(2, "btnOKDisabled.png")
        '
        'Progress4
        '
        Me.Progress4.AutoSize = True
        Me.Progress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progress4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Progress4.Location = New System.Drawing.Point(95, 67)
        Me.Progress4.Name = "Progress4"
        Me.Progress4.Size = New System.Drawing.Size(80, 16)
        Me.Progress4.TabIndex = 3
        Me.Progress4.Text = "Thankyou!"
        '
        'Progress3
        '
        Me.Progress3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Progress3.Location = New System.Drawing.Point(28, 48)
        Me.Progress3.Name = "Progress3"
        Me.Progress3.Size = New System.Drawing.Size(215, 13)
        Me.Progress3.TabIndex = 2
        Me.Progress3.Text = "Your Suggestion/Comment(s) has been sent"
        Me.Progress3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Progress2
        '
        Me.Progress2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Progress2.Location = New System.Drawing.Point(39, 28)
        Me.Progress2.Name = "Progress2"
        Me.Progress2.Size = New System.Drawing.Size(194, 13)
        Me.Progress2.TabIndex = 1
        Me.Progress2.Text = "Sending your Suggestion/Comment(s)..."
        Me.Progress2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Progress1
        '
        Me.Progress1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Progress1.Location = New System.Drawing.Point(78, 10)
        Me.Progress1.Name = "Progress1"
        Me.Progress1.Size = New System.Drawing.Size(116, 13)
        Me.Progress1.TabIndex = 0
        Me.Progress1.Text = "Connecting to Server..."
        Me.Progress1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email (Optional):"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(142, 68)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(250, 20)
        Me.TxtEmail.TabIndex = 3
        '
        'DisposeTimer
        '
        Me.DisposeTimer.Interval = 6000
        '
        'imgSend
        '
        Me.imgSend.ImageStream = CType(resources.GetObject("imgSend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgSend.TransparentColor = System.Drawing.Color.Lime
        Me.imgSend.Images.SetKeyName(0, "btnSendUp.png")
        Me.imgSend.Images.SetKeyName(1, "btnSendDown.png")
        Me.imgSend.Images.SetKeyName(2, "btnSendDisabled.png")
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'pbbCancel
        '
        Me.pbbCancel.BackColor = System.Drawing.Color.Transparent
        Me.pbbCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbCancel.Image = CType(resources.GetObject("pbbCancel.Image"), System.Drawing.Image)
        Me.pbbCancel.ImageList = Me.imgCancelButton
        Me.pbbCancel.Location = New System.Drawing.Point(16, 288)
        Me.pbbCancel.Name = "pbbCancel"
        Me.pbbCancel.Size = New System.Drawing.Size(79, 23)
        Me.pbbCancel.TabIndex = 13
        Me.pbbCancel.TabStop = False
        '
        'pbbSend
        '
        Me.pbbSend.BackColor = System.Drawing.Color.Transparent
        Me.pbbSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbSend.Image = CType(resources.GetObject("pbbSend.Image"), System.Drawing.Image)
        Me.pbbSend.ImageList = Me.imgSend
        Me.pbbSend.Location = New System.Drawing.Point(313, 288)
        Me.pbbSend.Name = "pbbSend"
        Me.pbbSend.Size = New System.Drawing.Size(79, 23)
        Me.pbbSend.TabIndex = 12
        Me.pbbSend.TabStop = False
        '
        'frmSendComments
        '
        Me.AcceptButton = Me.pbbSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timetable.My.Resources.Images.AddEntryDialog
        Me.CancelButton = Me.pbbCancel
        Me.ClientSize = New System.Drawing.Size(405, 324)
        Me.Controls.Add(Me.pbbCancel)
        Me.Controls.Add(Me.pbbSend)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.SendingProgress)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSuggestion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSendComments"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Suggestions and Comments"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.SendingProgress.ResumeLayout(False)
        Me.SendingProgress.PerformLayout()
        CType(Me.pbbError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSuggestion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents SendingProgress As System.Windows.Forms.Panel
    Friend WithEvents Progress1 As System.Windows.Forms.Label
    Friend WithEvents Progress4 As System.Windows.Forms.Label
    Friend WithEvents Progress3 As System.Windows.Forms.Label
    Friend WithEvents Progress2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DisposeTimer As System.Windows.Forms.Timer
    Friend WithEvents pbbSend As Timetable.PictureBoxButton
    Friend WithEvents pbbCancel As Timetable.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents imgSend As System.Windows.Forms.ImageList
    Friend WithEvents imgError As System.Windows.Forms.ImageList
    Friend WithEvents pbbError As Timetable.PictureBoxButton

End Class
