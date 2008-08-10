<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuggestionsAndComments
    Inherits Tempestas.frmInheritFromForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuggestionsAndComments))
        Me.imgError = New System.Windows.Forms.ImageList(Me.components)
        Me.imgSend = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrDisposeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSend = New Tempestas.PictureBoxButton
        Me.lblEmail = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.SendingProgress = New System.Windows.Forms.Panel
        Me.btnError = New Tempestas.PictureBoxButton
        Me.Progress4 = New System.Windows.Forms.Label
        Me.Progress3 = New System.Windows.Forms.Label
        Me.Progress2 = New System.Windows.Forms.Label
        Me.Progress1 = New System.Windows.Forms.Label
        Me.LblVersion = New System.Windows.Forms.Label
        Me.lblSuggestions = New System.Windows.Forms.Label
        Me.TxtSuggestion = New System.Windows.Forms.TextBox
        Me.lblProgramVersion = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SendingProgress.SuspendLayout()
        CType(Me.btnError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgError
        '
        Me.imgError.ImageStream = CType(resources.GetObject("imgError.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgError.TransparentColor = System.Drawing.Color.Lime
        Me.imgError.Images.SetKeyName(0, "btnOKUp.png")
        Me.imgError.Images.SetKeyName(1, "btnOKDown.png")
        Me.imgError.Images.SetKeyName(2, "btnOKDisabled.png")
        '
        'imgSend
        '
        Me.imgSend.ImageStream = CType(resources.GetObject("imgSend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgSend.TransparentColor = System.Drawing.Color.Lime
        Me.imgSend.Images.SetKeyName(0, "btnSendUp.png")
        Me.imgSend.Images.SetKeyName(1, "btnSendDown.png")
        Me.imgSend.Images.SetKeyName(2, "btnSendDisabled.png")
        '
        'tmrDisposeTimer
        '
        Me.tmrDisposeTimer.Interval = 6000
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(21, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.TabStop = False
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageList = Me.imgSend
        Me.btnSend.Location = New System.Drawing.Point(318, 293)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(79, 23)
        Me.btnSend.TabIndex = 23
        Me.btnSend.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(18, 76)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(83, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email (Optional):"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(147, 73)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(250, 20)
        Me.TxtEmail.TabIndex = 4
        '
        'SendingProgress
        '
        Me.SendingProgress.BackColor = System.Drawing.Color.White
        Me.SendingProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SendingProgress.Controls.Add(Me.btnError)
        Me.SendingProgress.Controls.Add(Me.Progress4)
        Me.SendingProgress.Controls.Add(Me.Progress3)
        Me.SendingProgress.Controls.Add(Me.Progress2)
        Me.SendingProgress.Controls.Add(Me.Progress1)
        Me.SendingProgress.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.SendingProgress.Location = New System.Drawing.Point(67, 125)
        Me.SendingProgress.Name = "SendingProgress"
        Me.SendingProgress.Size = New System.Drawing.Size(282, 91)
        Me.SendingProgress.TabIndex = 9
        Me.SendingProgress.Visible = False
        '
        'btnError
        '
        Me.btnError.BackColor = System.Drawing.Color.Transparent
        Me.btnError.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnError.Image = CType(resources.GetObject("btnError.Image"), System.Drawing.Image)
        Me.btnError.ImageList = Me.imgError
        Me.btnError.Location = New System.Drawing.Point(101, 60)
        Me.btnError.Name = "btnError"
        Me.btnError.Size = New System.Drawing.Size(79, 23)
        Me.btnError.TabIndex = 14
        Me.btnError.TabStop = False
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
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.Location = New System.Drawing.Point(144, 102)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(70, 13)
        Me.LblVersion.TabIndex = 6
        Me.LblVersion.Text = "{0}.{1:00}.{2}"
        '
        'lblSuggestions
        '
        Me.lblSuggestions.AutoSize = True
        Me.lblSuggestions.BackColor = System.Drawing.Color.Transparent
        Me.lblSuggestions.Location = New System.Drawing.Point(18, 128)
        Me.lblSuggestions.Name = "lblSuggestions"
        Me.lblSuggestions.Size = New System.Drawing.Size(123, 13)
        Me.lblSuggestions.TabIndex = 7
        Me.lblSuggestions.Text = "Suggestion/Comment(s):"
        '
        'TxtSuggestion
        '
        Me.TxtSuggestion.Location = New System.Drawing.Point(147, 125)
        Me.TxtSuggestion.Multiline = True
        Me.TxtSuggestion.Name = "TxtSuggestion"
        Me.TxtSuggestion.Size = New System.Drawing.Size(250, 160)
        Me.TxtSuggestion.TabIndex = 8
        '
        'lblProgramVersion
        '
        Me.lblProgramVersion.AutoSize = True
        Me.lblProgramVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramVersion.Location = New System.Drawing.Point(18, 102)
        Me.lblProgramVersion.Name = "lblProgramVersion"
        Me.lblProgramVersion.Size = New System.Drawing.Size(87, 13)
        Me.lblProgramVersion.TabIndex = 5
        Me.lblProgramVersion.Text = "Program Version:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Location = New System.Drawing.Point(18, 50)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(86, 13)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name (Optional):"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(147, 47)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(250, 20)
        Me.TxtName.TabIndex = 2
        '
        'frmSuggestionsAndComments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(415, 334)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.SendingProgress)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.lblSuggestions)
        Me.Controls.Add(Me.TxtSuggestion)
        Me.Controls.Add(Me.lblProgramVersion)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "frmSuggestionsAndComments"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Comments and Suggestions"
        Me.TitleText = "Comments and Suggestions"
        Me.Controls.SetChildIndex(Me.TxtName, 0)
        Me.Controls.SetChildIndex(Me.LblName, 0)
        Me.Controls.SetChildIndex(Me.lblProgramVersion, 0)
        Me.Controls.SetChildIndex(Me.TxtSuggestion, 0)
        Me.Controls.SetChildIndex(Me.lblSuggestions, 0)
        Me.Controls.SetChildIndex(Me.LblVersion, 0)
        Me.Controls.SetChildIndex(Me.SendingProgress, 0)
        Me.Controls.SetChildIndex(Me.TxtEmail, 0)
        Me.Controls.SetChildIndex(Me.lblEmail, 0)
        Me.Controls.SetChildIndex(Me.btnSend, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SendingProgress.ResumeLayout(False)
        Me.SendingProgress.PerformLayout()
        CType(Me.btnError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgError As System.Windows.Forms.ImageList
    Friend WithEvents imgSend As System.Windows.Forms.ImageList
    Friend WithEvents tmrDisposeTimer As System.Windows.Forms.Timer
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents btnSend As Tempestas.PictureBoxButton
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents SendingProgress As System.Windows.Forms.Panel
    Friend WithEvents btnError As Tempestas.PictureBoxButton
    Friend WithEvents Progress4 As System.Windows.Forms.Label
    Friend WithEvents Progress3 As System.Windows.Forms.Label
    Friend WithEvents Progress2 As System.Windows.Forms.Label
    Friend WithEvents Progress1 As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents lblSuggestions As System.Windows.Forms.Label
    Friend WithEvents TxtSuggestion As System.Windows.Forms.TextBox
    Friend WithEvents lblProgramVersion As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox

End Class
