<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvent))
        Me.grpEventDetails = New System.Windows.Forms.GroupBox
        Me.btnNewStaff = New Tempestas.PictureBoxButton
        Me.imgAddField = New System.Windows.Forms.ImageList(Me.components)
        Me.btnNewRoom = New Tempestas.PictureBoxButton
        Me.cboRoom = New System.Windows.Forms.ComboBox
        Me.cboStaff = New System.Windows.Forms.ComboBox
        Me.lblRoom = New System.Windows.Forms.Label
        Me.lblStaff = New System.Windows.Forms.Label
        Me.btnNewContact = New Tempestas.PictureBoxButton
        Me.btnNewModule = New Tempestas.PictureBoxButton
        Me.lblContact = New System.Windows.Forms.Label
        Me.lblModule = New System.Windows.Forms.Label
        Me.cboContact = New System.Windows.Forms.ComboBox
        Me.cboModule = New System.Windows.Forms.ComboBox
        Me.grpOtherInformation = New System.Windows.Forms.GroupBox
        Me.lblOptional = New System.Windows.Forms.Label
        Me.chkOptional = New System.Windows.Forms.CheckBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.lblNotes = New System.Windows.Forms.Label
        Me.grpTimeAndDate = New System.Windows.Forms.GroupBox
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboDay = New System.Windows.Forms.ComboBox
        Me.lblDay = New System.Windows.Forms.Label
        Me.cboWeekFrom = New System.Windows.Forms.ComboBox
        Me.cboWeekTo = New System.Windows.Forms.ComboBox
        Me.lblWeekTo = New System.Windows.Forms.Label
        Me.lblWeekFrom = New System.Windows.Forms.Label
        Me.cboTerm = New System.Windows.Forms.ComboBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.lblYear = New System.Windows.Forms.Label
        Me.lblTerm = New System.Windows.Forms.Label
        Me.imgAcceptButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblError = New System.Windows.Forms.Label
        Me.grpEventDetails.SuspendLayout()
        CType(Me.btnNewStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewModule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOtherInformation.SuspendLayout()
        Me.grpTimeAndDate.SuspendLayout()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEventDetails
        '
        Me.grpEventDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpEventDetails.Controls.Add(Me.btnNewStaff)
        Me.grpEventDetails.Controls.Add(Me.btnNewRoom)
        Me.grpEventDetails.Controls.Add(Me.cboRoom)
        Me.grpEventDetails.Controls.Add(Me.cboStaff)
        Me.grpEventDetails.Controls.Add(Me.lblRoom)
        Me.grpEventDetails.Controls.Add(Me.lblStaff)
        Me.grpEventDetails.Controls.Add(Me.btnNewContact)
        Me.grpEventDetails.Controls.Add(Me.btnNewModule)
        Me.grpEventDetails.Controls.Add(Me.lblContact)
        Me.grpEventDetails.Controls.Add(Me.lblModule)
        Me.grpEventDetails.Controls.Add(Me.cboContact)
        Me.grpEventDetails.Controls.Add(Me.cboModule)
        Me.grpEventDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpEventDetails.Location = New System.Drawing.Point(18, 47)
        Me.grpEventDetails.Name = "grpEventDetails"
        Me.grpEventDetails.Size = New System.Drawing.Size(402, 132)
        Me.grpEventDetails.TabIndex = 1
        Me.grpEventDetails.TabStop = False
        Me.grpEventDetails.Text = "Event Details"
        '
        'btnNewStaff
        '
        Me.btnNewStaff.BackColor = System.Drawing.Color.Transparent
        Me.btnNewStaff.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewStaff.Image = CType(resources.GetObject("btnNewStaff.Image"), System.Drawing.Image)
        Me.btnNewStaff.ImageList = Me.imgAddField
        Me.btnNewStaff.Location = New System.Drawing.Point(380, 78)
        Me.btnNewStaff.Name = "btnNewStaff"
        Me.btnNewStaff.Size = New System.Drawing.Size(16, 16)
        Me.btnNewStaff.TabIndex = 46
        Me.btnNewStaff.TabStop = False
        '
        'imgAddField
        '
        Me.imgAddField.ImageStream = CType(resources.GetObject("imgAddField.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAddField.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAddField.Images.SetKeyName(0, "add2.png")
        Me.imgAddField.Images.SetKeyName(1, "add2.png")
        Me.imgAddField.Images.SetKeyName(2, "add2.png")
        '
        'btnNewRoom
        '
        Me.btnNewRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnNewRoom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewRoom.Image = CType(resources.GetObject("btnNewRoom.Image"), System.Drawing.Image)
        Me.btnNewRoom.ImageList = Me.imgAddField
        Me.btnNewRoom.Location = New System.Drawing.Point(380, 106)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(16, 16)
        Me.btnNewRoom.TabIndex = 45
        Me.btnNewRoom.TabStop = False
        '
        'cboRoom
        '
        Me.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(88, 103)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(286, 21)
        Me.cboRoom.TabIndex = 7
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(88, 75)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(286, 21)
        Me.cboStaff.TabIndex = 5
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom.ForeColor = System.Drawing.Color.Black
        Me.lblRoom.Location = New System.Drawing.Point(6, 106)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(38, 13)
        Me.lblRoom.TabIndex = 6
        Me.lblRoom.Text = "Room:"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblStaff.ForeColor = System.Drawing.Color.Black
        Me.lblStaff.Location = New System.Drawing.Point(6, 78)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(73, 13)
        Me.lblStaff.TabIndex = 4
        Me.lblStaff.Text = "Staff Member:"
        '
        'btnNewContact
        '
        Me.btnNewContact.BackColor = System.Drawing.Color.Transparent
        Me.btnNewContact.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewContact.Image = CType(resources.GetObject("btnNewContact.Image"), System.Drawing.Image)
        Me.btnNewContact.ImageList = Me.imgAddField
        Me.btnNewContact.Location = New System.Drawing.Point(380, 22)
        Me.btnNewContact.Name = "btnNewContact"
        Me.btnNewContact.Size = New System.Drawing.Size(16, 16)
        Me.btnNewContact.TabIndex = 40
        Me.btnNewContact.TabStop = False
        '
        'btnNewModule
        '
        Me.btnNewModule.BackColor = System.Drawing.Color.Transparent
        Me.btnNewModule.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewModule.Image = CType(resources.GetObject("btnNewModule.Image"), System.Drawing.Image)
        Me.btnNewModule.ImageList = Me.imgAddField
        Me.btnNewModule.Location = New System.Drawing.Point(380, 50)
        Me.btnNewModule.Name = "btnNewModule"
        Me.btnNewModule.Size = New System.Drawing.Size(16, 16)
        Me.btnNewModule.TabIndex = 39
        Me.btnNewModule.TabStop = False
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.ForeColor = System.Drawing.Color.Black
        Me.lblContact.Location = New System.Drawing.Point(6, 22)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(74, 13)
        Me.lblContact.TabIndex = 0
        Me.lblContact.Text = "Contact Type:"
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.BackColor = System.Drawing.Color.Transparent
        Me.lblModule.ForeColor = System.Drawing.Color.Black
        Me.lblModule.Location = New System.Drawing.Point(6, 50)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(45, 13)
        Me.lblModule.TabIndex = 2
        Me.lblModule.Text = "Module:"
        '
        'cboContact
        '
        Me.cboContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContact.FormattingEnabled = True
        Me.cboContact.Location = New System.Drawing.Point(88, 19)
        Me.cboContact.Name = "cboContact"
        Me.cboContact.Size = New System.Drawing.Size(286, 21)
        Me.cboContact.TabIndex = 1
        '
        'cboModule
        '
        Me.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModule.FormattingEnabled = True
        Me.cboModule.Location = New System.Drawing.Point(88, 47)
        Me.cboModule.Name = "cboModule"
        Me.cboModule.Size = New System.Drawing.Size(286, 21)
        Me.cboModule.TabIndex = 3
        '
        'grpOtherInformation
        '
        Me.grpOtherInformation.BackColor = System.Drawing.Color.Transparent
        Me.grpOtherInformation.Controls.Add(Me.lblOptional)
        Me.grpOtherInformation.Controls.Add(Me.chkOptional)
        Me.grpOtherInformation.Controls.Add(Me.txtNotes)
        Me.grpOtherInformation.Controls.Add(Me.lblNotes)
        Me.grpOtherInformation.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpOtherInformation.Location = New System.Drawing.Point(18, 295)
        Me.grpOtherInformation.Name = "grpOtherInformation"
        Me.grpOtherInformation.Size = New System.Drawing.Size(402, 113)
        Me.grpOtherInformation.TabIndex = 3
        Me.grpOtherInformation.TabStop = False
        Me.grpOtherInformation.Text = "Other Information"
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.BackColor = System.Drawing.Color.Transparent
        Me.lblOptional.ForeColor = System.Drawing.Color.Black
        Me.lblOptional.Location = New System.Drawing.Point(6, 22)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(49, 13)
        Me.lblOptional.TabIndex = 0
        Me.lblOptional.Text = "Optional:"
        '
        'chkOptional
        '
        Me.chkOptional.AutoSize = True
        Me.chkOptional.ForeColor = System.Drawing.Color.Black
        Me.chkOptional.Location = New System.Drawing.Point(88, 22)
        Me.chkOptional.Name = "chkOptional"
        Me.chkOptional.Size = New System.Drawing.Size(15, 14)
        Me.chkOptional.TabIndex = 1
        Me.chkOptional.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(88, 42)
        Me.txtNotes.MaxLength = 8000
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(286, 60)
        Me.txtNotes.TabIndex = 3
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.BackColor = System.Drawing.Color.Transparent
        Me.lblNotes.ForeColor = System.Drawing.Color.Black
        Me.lblNotes.Location = New System.Drawing.Point(6, 45)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 13)
        Me.lblNotes.TabIndex = 2
        Me.lblNotes.Text = "Notes:"
        '
        'grpTimeAndDate
        '
        Me.grpTimeAndDate.BackColor = System.Drawing.Color.Transparent
        Me.grpTimeAndDate.Controls.Add(Me.dtpEndTime)
        Me.grpTimeAndDate.Controls.Add(Me.dtpStartTime)
        Me.grpTimeAndDate.Controls.Add(Me.lblStartTime)
        Me.grpTimeAndDate.Controls.Add(Me.Label2)
        Me.grpTimeAndDate.Controls.Add(Me.cboDay)
        Me.grpTimeAndDate.Controls.Add(Me.lblDay)
        Me.grpTimeAndDate.Controls.Add(Me.cboWeekFrom)
        Me.grpTimeAndDate.Controls.Add(Me.cboWeekTo)
        Me.grpTimeAndDate.Controls.Add(Me.lblWeekTo)
        Me.grpTimeAndDate.Controls.Add(Me.lblWeekFrom)
        Me.grpTimeAndDate.Controls.Add(Me.cboTerm)
        Me.grpTimeAndDate.Controls.Add(Me.cboYear)
        Me.grpTimeAndDate.Controls.Add(Me.lblYear)
        Me.grpTimeAndDate.Controls.Add(Me.lblTerm)
        Me.grpTimeAndDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpTimeAndDate.Location = New System.Drawing.Point(18, 185)
        Me.grpTimeAndDate.Name = "grpTimeAndDate"
        Me.grpTimeAndDate.Size = New System.Drawing.Size(402, 104)
        Me.grpTimeAndDate.TabIndex = 2
        Me.grpTimeAndDate.TabStop = False
        Me.grpTimeAndDate.Text = "Time and Date"
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(274, 73)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpEndTime.TabIndex = 13
        Me.dtpEndTime.Value = New Date(2008, 4, 1, 8, 30, 0, 0)
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(88, 73)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpStartTime.TabIndex = 11
        Me.dtpStartTime.Value = New Date(2008, 4, 1, 8, 0, 0, 0)
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
        Me.lblStartTime.ForeColor = System.Drawing.Color.Black
        Me.lblStartTime.Location = New System.Drawing.Point(6, 76)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(58, 13)
        Me.lblStartTime.TabIndex = 10
        Me.lblStartTime.Text = "Start Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(207, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "End Time:"
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Location = New System.Drawing.Point(274, 46)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(100, 21)
        Me.cboDay.TabIndex = 9
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.ForeColor = System.Drawing.Color.Black
        Me.lblDay.Location = New System.Drawing.Point(207, 49)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 8
        Me.lblDay.Text = "Day:"
        '
        'cboWeekFrom
        '
        Me.cboWeekFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeekFrom.FormattingEnabled = True
        Me.cboWeekFrom.Location = New System.Drawing.Point(88, 45)
        Me.cboWeekFrom.Name = "cboWeekFrom"
        Me.cboWeekFrom.Size = New System.Drawing.Size(36, 21)
        Me.cboWeekFrom.TabIndex = 5
        '
        'cboWeekTo
        '
        Me.cboWeekTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeekTo.FormattingEnabled = True
        Me.cboWeekTo.Items.AddRange(New Object() {"52"})
        Me.cboWeekTo.Location = New System.Drawing.Point(152, 45)
        Me.cboWeekTo.Name = "cboWeekTo"
        Me.cboWeekTo.Size = New System.Drawing.Size(36, 21)
        Me.cboWeekTo.TabIndex = 7
        '
        'lblWeekTo
        '
        Me.lblWeekTo.AutoSize = True
        Me.lblWeekTo.BackColor = System.Drawing.Color.Transparent
        Me.lblWeekTo.ForeColor = System.Drawing.Color.Black
        Me.lblWeekTo.Location = New System.Drawing.Point(128, 49)
        Me.lblWeekTo.Name = "lblWeekTo"
        Me.lblWeekTo.Size = New System.Drawing.Size(20, 13)
        Me.lblWeekTo.TabIndex = 6
        Me.lblWeekTo.Text = "To"
        '
        'lblWeekFrom
        '
        Me.lblWeekFrom.AutoSize = True
        Me.lblWeekFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblWeekFrom.ForeColor = System.Drawing.Color.Black
        Me.lblWeekFrom.Location = New System.Drawing.Point(6, 49)
        Me.lblWeekFrom.Name = "lblWeekFrom"
        Me.lblWeekFrom.Size = New System.Drawing.Size(39, 13)
        Me.lblWeekFrom.TabIndex = 4
        Me.lblWeekFrom.Text = "Week:"
        '
        'cboTerm
        '
        Me.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(274, 19)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(100, 21)
        Me.cboTerm.TabIndex = 3
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(88, 19)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(100, 21)
        Me.cboYear.TabIndex = 1
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.ForeColor = System.Drawing.Color.Black
        Me.lblYear.Location = New System.Drawing.Point(6, 22)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year:"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.BackColor = System.Drawing.Color.Transparent
        Me.lblTerm.ForeColor = System.Drawing.Color.Black
        Me.lblTerm.Location = New System.Drawing.Point(207, 22)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(34, 13)
        Me.lblTerm.TabIndex = 2
        Me.lblTerm.Text = "Term:"
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgAcceptButton.ImageSize = New System.Drawing.Size(79, 23)
        Me.imgAcceptButton.TransparentColor = System.Drawing.Color.Lime
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAcceptButton
        Me.btnAccept.Location = New System.Drawing.Point(341, 438)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 54
        Me.btnAccept.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 438)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.TabStop = False
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(127, 416)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 13)
        Me.lblError.TabIndex = 4
        Me.lblError.Text = "Error"
        '
        'frmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(438, 479)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.grpTimeAndDate)
        Me.Controls.Add(Me.grpOtherInformation)
        Me.Controls.Add(Me.grpEventDetails)
        Me.HideTitleButtons = True
        Me.Name = "frmEvent"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Event"
        Me.TitleText = "Event"
        Me.Controls.SetChildIndex(Me.grpEventDetails, 0)
        Me.Controls.SetChildIndex(Me.grpOtherInformation, 0)
        Me.Controls.SetChildIndex(Me.grpTimeAndDate, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        Me.grpEventDetails.ResumeLayout(False)
        Me.grpEventDetails.PerformLayout()
        CType(Me.btnNewStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewModule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOtherInformation.ResumeLayout(False)
        Me.grpOtherInformation.PerformLayout()
        Me.grpTimeAndDate.ResumeLayout(False)
        Me.grpTimeAndDate.PerformLayout()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEventDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewContact As Tempestas.PictureBoxButton
    Friend WithEvents imgAddField As System.Windows.Forms.ImageList
    Friend WithEvents btnNewModule As Tempestas.PictureBoxButton
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents cboContact As System.Windows.Forms.ComboBox
    Friend WithEvents cboModule As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewStaff As Tempestas.PictureBoxButton
    Friend WithEvents btnNewRoom As Tempestas.PictureBoxButton
    Friend WithEvents cboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents grpOtherInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblOptional As System.Windows.Forms.Label
    Friend WithEvents chkOptional As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents grpTimeAndDate As System.Windows.Forms.GroupBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboWeekFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cboWeekTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeekTo As System.Windows.Forms.Label
    Friend WithEvents lblWeekFrom As System.Windows.Forms.Label
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents imgAcceptButton As System.Windows.Forms.ImageList
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Public WithEvents btnAccept As Tempestas.PictureBoxButton
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker

End Class
