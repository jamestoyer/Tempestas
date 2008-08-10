<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen1))
        Me.cboDVDay = New System.Windows.Forms.ComboBox
        Me.pnlDayEvent = New System.Windows.Forms.Panel
        Me.pnlWeekEvent = New System.Windows.Forms.Panel
        Me.mnuMenu = New System.Windows.Forms.MenuStrip
        Me.tsiFile = New System.Windows.Forms.ToolStripMenuItem
        Me.FindDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddWizard = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiAddContact = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddEntry = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddModule = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddRooms = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddStaff = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyWizard = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiModifyContact = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyEntry = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyModules = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyRooms = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyStaff = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.tisEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiSuggestions = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.imgArrowRight = New System.Windows.Forms.ImageList(Me.components)
        Me.imgArrowLeft = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlWeekButtonHolder = New System.Windows.Forms.Panel
        Me.pnlWeekScroll = New System.Windows.Forms.Panel
        Me.pnlWeekButtons = New System.Windows.Forms.Panel
        Me.tmrClickWeekButton = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScrollWeekButtonLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScrollWeekButtonRight = New System.Windows.Forms.Timer(Me.components)
        Me.btnWeekLeft = New Timetable.PictureBoxButton
        Me.btnWeekRight = New Timetable.PictureBoxButton
        Me.mnuMenu.SuspendLayout()
        Me.pnlWeekButtonHolder.SuspendLayout()
        Me.pnlWeekScroll.SuspendLayout()
        CType(Me.btnWeekLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWeekRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDVDay
        '
        Me.cboDVDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboDVDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDVDay.FormattingEnabled = True
        Me.cboDVDay.Location = New System.Drawing.Point(12, 520)
        Me.cboDVDay.Name = "cboDVDay"
        Me.cboDVDay.Size = New System.Drawing.Size(121, 21)
        Me.cboDVDay.TabIndex = 3
        '
        'pnlDayEvent
        '
        Me.pnlDayEvent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlDayEvent.AutoScroll = True
        Me.pnlDayEvent.BackColor = System.Drawing.Color.Transparent
        Me.pnlDayEvent.Location = New System.Drawing.Point(12, 27)
        Me.pnlDayEvent.Name = "pnlDayEvent"
        Me.pnlDayEvent.Size = New System.Drawing.Size(240, 479)
        Me.pnlDayEvent.TabIndex = 0
        '
        'pnlWeekEvent
        '
        Me.pnlWeekEvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWeekEvent.AutoScroll = True
        Me.pnlWeekEvent.BackColor = System.Drawing.Color.Transparent
        Me.pnlWeekEvent.Location = New System.Drawing.Point(258, 27)
        Me.pnlWeekEvent.Name = "pnlWeekEvent"
        Me.pnlWeekEvent.Size = New System.Drawing.Size(514, 479)
        Me.pnlWeekEvent.TabIndex = 1
        '
        'mnuMenu
        '
        Me.mnuMenu.BackColor = System.Drawing.Color.Transparent
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiFile, Me.tsiEdit, Me.tisEdit, Me.TestToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(784, 24)
        Me.mnuMenu.TabIndex = 8
        Me.mnuMenu.Text = "mnuMenu"
        '
        'tsiFile
        '
        Me.tsiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindDatabaseToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.tsiFile.Name = "tsiFile"
        Me.tsiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsiFile.Text = "File"
        '
        'FindDatabaseToolStripMenuItem
        '
        Me.FindDatabaseToolStripMenuItem.Name = "FindDatabaseToolStripMenuItem"
        Me.FindDatabaseToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FindDatabaseToolStripMenuItem.Text = "Find Database"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(145, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tsiEdit
        '
        Me.tsiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiAdd, Me.tsiModifyDelete, Me.ToolStripSeparator3, Me.tsiOptions})
        Me.tsiEdit.Name = "tsiEdit"
        Me.tsiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsiEdit.Text = "Edit"
        '
        'tsiAdd
        '
        Me.tsiAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiAddWizard, Me.ToolStripSeparator2, Me.tsiAddContact, Me.tsiAddEntry, Me.tsiAddModule, Me.tsiAddRooms, Me.tsiAddStaff})
        Me.tsiAdd.Name = "tsiAdd"
        Me.tsiAdd.Size = New System.Drawing.Size(150, 22)
        Me.tsiAdd.Text = "Add"
        '
        'tsiAddWizard
        '
        Me.tsiAddWizard.Name = "tsiAddWizard"
        Me.tsiAddWizard.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddWizard.Text = "Wizard"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(113, 6)
        '
        'tsiAddContact
        '
        Me.tsiAddContact.Name = "tsiAddContact"
        Me.tsiAddContact.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddContact.Text = "Contact"
        '
        'tsiAddEntry
        '
        Me.tsiAddEntry.Name = "tsiAddEntry"
        Me.tsiAddEntry.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddEntry.Text = "Entry"
        '
        'tsiAddModule
        '
        Me.tsiAddModule.Name = "tsiAddModule"
        Me.tsiAddModule.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddModule.Text = "Module"
        '
        'tsiAddRooms
        '
        Me.tsiAddRooms.Name = "tsiAddRooms"
        Me.tsiAddRooms.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddRooms.Text = "Rooms"
        '
        'tsiAddStaff
        '
        Me.tsiAddStaff.Name = "tsiAddStaff"
        Me.tsiAddStaff.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddStaff.Text = "Staff"
        '
        'tsiModifyDelete
        '
        Me.tsiModifyDelete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiModifyWizard, Me.ToolStripSeparator1, Me.tsiModifyContact, Me.tsiModifyEntry, Me.tsiModifyModules, Me.tsiModifyRooms, Me.tsiModifyStaff})
        Me.tsiModifyDelete.Name = "tsiModifyDelete"
        Me.tsiModifyDelete.Size = New System.Drawing.Size(150, 22)
        Me.tsiModifyDelete.Text = "Modify/Delete"
        '
        'tsiModifyWizard
        '
        Me.tsiModifyWizard.Name = "tsiModifyWizard"
        Me.tsiModifyWizard.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyWizard.Text = "Wizard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'tsiModifyContact
        '
        Me.tsiModifyContact.Name = "tsiModifyContact"
        Me.tsiModifyContact.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyContact.Text = "Contact"
        '
        'tsiModifyEntry
        '
        Me.tsiModifyEntry.Name = "tsiModifyEntry"
        Me.tsiModifyEntry.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyEntry.Text = "Entry"
        '
        'tsiModifyModules
        '
        Me.tsiModifyModules.Name = "tsiModifyModules"
        Me.tsiModifyModules.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyModules.Text = "Modules"
        '
        'tsiModifyRooms
        '
        Me.tsiModifyRooms.Name = "tsiModifyRooms"
        Me.tsiModifyRooms.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyRooms.Text = "Rooms"
        '
        'tsiModifyStaff
        '
        Me.tsiModifyStaff.Name = "tsiModifyStaff"
        Me.tsiModifyStaff.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyStaff.Text = "Staff"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(147, 6)
        '
        'tsiOptions
        '
        Me.tsiOptions.Name = "tsiOptions"
        Me.tsiOptions.Size = New System.Drawing.Size(150, 22)
        Me.tsiOptions.Text = "Options"
        '
        'tisEdit
        '
        Me.tisEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiSuggestions, Me.tsiAbout})
        Me.tisEdit.Name = "tisEdit"
        Me.tisEdit.Size = New System.Drawing.Size(44, 20)
        Me.tisEdit.Text = "Help"
        '
        'tsiSuggestions
        '
        Me.tsiSuggestions.Name = "tsiSuggestions"
        Me.tsiSuggestions.Size = New System.Drawing.Size(202, 22)
        Me.tsiSuggestions.Text = "Comments/Suggestions"
        '
        'tsiAbout
        '
        Me.tsiAbout.Name = "tsiAbout"
        Me.tsiAbout.Size = New System.Drawing.Size(202, 22)
        Me.tsiAbout.Text = "About"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginScreenToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'LoginScreenToolStripMenuItem
        '
        Me.LoginScreenToolStripMenuItem.Name = "LoginScreenToolStripMenuItem"
        Me.LoginScreenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LoginScreenToolStripMenuItem.Text = "Login Screen"
        '
        'imgArrowRight
        '
        Me.imgArrowRight.ImageStream = CType(resources.GetObject("imgArrowRight.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgArrowRight.TransparentColor = System.Drawing.Color.Transparent
        Me.imgArrowRight.Images.SetKeyName(0, "media_play_green.png")
        Me.imgArrowRight.Images.SetKeyName(1, "media_play_green.png")
        Me.imgArrowRight.Images.SetKeyName(2, "media_play_green.png")
        '
        'imgArrowLeft
        '
        Me.imgArrowLeft.ImageStream = CType(resources.GetObject("imgArrowLeft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgArrowLeft.TransparentColor = System.Drawing.Color.Transparent
        Me.imgArrowLeft.Images.SetKeyName(0, "btnLeftEnabled.png")
        Me.imgArrowLeft.Images.SetKeyName(1, "btnLeftEnabled.png")
        Me.imgArrowLeft.Images.SetKeyName(2, "btnLeftEnabled.png")
        '
        'pnlWeekButtonHolder
        '
        Me.pnlWeekButtonHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWeekButtonHolder.BackColor = System.Drawing.Color.Transparent
        Me.pnlWeekButtonHolder.Controls.Add(Me.pnlWeekScroll)
        Me.pnlWeekButtonHolder.Controls.Add(Me.btnWeekLeft)
        Me.pnlWeekButtonHolder.Controls.Add(Me.btnWeekRight)
        Me.pnlWeekButtonHolder.Location = New System.Drawing.Point(258, 512)
        Me.pnlWeekButtonHolder.Name = "pnlWeekButtonHolder"
        Me.pnlWeekButtonHolder.Size = New System.Drawing.Size(514, 40)
        Me.pnlWeekButtonHolder.TabIndex = 9
        '
        'pnlWeekScroll
        '
        Me.pnlWeekScroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlWeekScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlWeekScroll.Controls.Add(Me.pnlWeekButtons)
        Me.pnlWeekScroll.Location = New System.Drawing.Point(26, 0)
        Me.pnlWeekScroll.Name = "pnlWeekScroll"
        Me.pnlWeekScroll.Size = New System.Drawing.Size(462, 40)
        Me.pnlWeekScroll.TabIndex = 11
        '
        'pnlWeekButtons
        '
        Me.pnlWeekButtons.BackColor = System.Drawing.Color.White
        Me.pnlWeekButtons.Location = New System.Drawing.Point(0, 0)
        Me.pnlWeekButtons.Name = "pnlWeekButtons"
        Me.pnlWeekButtons.Size = New System.Drawing.Size(462, 40)
        Me.pnlWeekButtons.TabIndex = 10
        '
        'tmrScrollWeekButtonLeft
        '
        Me.tmrScrollWeekButtonLeft.Interval = 1
        '
        'tmrScrollWeekButtonRight
        '
        Me.tmrScrollWeekButtonRight.Interval = 1
        '
        'btnWeekLeft
        '
        Me.btnWeekLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnWeekLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnWeekLeft.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnWeekLeft.Image = CType(resources.GetObject("btnWeekLeft.Image"), System.Drawing.Image)
        Me.btnWeekLeft.ImageList = Me.imgArrowLeft
        Me.btnWeekLeft.Location = New System.Drawing.Point(0, 8)
        Me.btnWeekLeft.Name = "btnWeekLeft"
        Me.btnWeekLeft.Size = New System.Drawing.Size(24, 24)
        Me.btnWeekLeft.TabIndex = 10
        Me.btnWeekLeft.TabStop = False
        '
        'btnWeekRight
        '
        Me.btnWeekRight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnWeekRight.BackColor = System.Drawing.Color.Transparent
        Me.btnWeekRight.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnWeekRight.Image = CType(resources.GetObject("btnWeekRight.Image"), System.Drawing.Image)
        Me.btnWeekRight.ImageList = Me.imgArrowRight
        Me.btnWeekRight.Location = New System.Drawing.Point(490, 8)
        Me.btnWeekRight.Name = "btnWeekRight"
        Me.btnWeekRight.Size = New System.Drawing.Size(24, 24)
        Me.btnWeekRight.TabIndex = 11
        Me.btnWeekRight.TabStop = False
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 564)
        Me.Controls.Add(Me.pnlWeekButtonHolder)
        Me.Controls.Add(Me.pnlWeekEvent)
        Me.Controls.Add(Me.pnlDayEvent)
        Me.Controls.Add(Me.cboDVDay)
        Me.Controls.Add(Me.mnuMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Screen"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.pnlWeekButtonHolder.ResumeLayout(False)
        Me.pnlWeekScroll.ResumeLayout(False)
        CType(Me.btnWeekLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWeekRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDVDay As System.Windows.Forms.ComboBox
    Friend WithEvents pnlDayEvent As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekEvent As System.Windows.Forms.Panel
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tisEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiSuggestions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyWizard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiModifyContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyModules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddWizard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiAddContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgArrowRight As System.Windows.Forms.ImageList
    Friend WithEvents imgArrowLeft As System.Windows.Forms.ImageList
    Friend WithEvents pnlWeekButtonHolder As System.Windows.Forms.Panel
    Friend WithEvents btnWeekLeft As Timetable.PictureBoxButton
    Friend WithEvents btnWeekRight As Timetable.PictureBoxButton
    Friend WithEvents pnlWeekButtons As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekScroll As System.Windows.Forms.Panel
    Friend WithEvents tmrClickWeekButton As System.Windows.Forms.Timer
    Friend WithEvents tmrScrollWeekButtonLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrScrollWeekButtonRight As System.Windows.Forms.Timer
End Class
