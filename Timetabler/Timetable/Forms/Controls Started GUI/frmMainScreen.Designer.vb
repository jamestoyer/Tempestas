<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip
        Me.tsiFile = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiLogin = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiLogout = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiExit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddContact = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddEvent = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddModule = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddRooms = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAddStaff = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyContact = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyEvent = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyModules = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyRooms = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiModifyStaff = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiTools = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiTimetable = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiNewTimetable = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiModifyTimetable = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiSelectTimetable = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiUserDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.tisEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.tsiSuggestions = New System.Windows.Forms.ToolStripMenuItem
        Me.tsiAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrScrollWeekButtonLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrClickWeekButton = New System.Windows.Forms.Timer(Me.components)
        Me.imgArrowLeft = New System.Windows.Forms.ImageList(Me.components)
        Me.imgArrowRight = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrScrollWeekButtonRight = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenuStripHolder = New System.Windows.Forms.Panel
        Me.pnlWeekEvent = New System.Windows.Forms.Panel
        Me.pnlWeekButtonHolder = New System.Windows.Forms.Panel
        Me.pnlWeekScroll = New System.Windows.Forms.Panel
        Me.pnlWeekButtons = New System.Windows.Forms.Panel
        Me.btnWeekLeft = New Tempestas.PictureBoxButton
        Me.btnWeekRight = New Tempestas.PictureBoxButton
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.cboTerm = New System.Windows.Forms.ComboBox
        Me.pnlToolStripHolder = New System.Windows.Forms.Panel
        Me.tlsToolStrip = New System.Windows.Forms.ToolStrip
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.tsbNewTimetable = New System.Windows.Forms.ToolStripButton
        Me.tsbSelectTimetable = New System.Windows.Forms.ToolStripButton
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAdd = New System.Windows.Forms.ToolStripSplitButton
        Me.AddEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.AddContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbUpdate = New System.Windows.Forms.ToolStripSplitButton
        Me.UpdateEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbOptions = New System.Windows.Forms.ToolStripButton
        Me.tsbLogout = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuMenu.SuspendLayout()
        Me.pnlMenuStripHolder.SuspendLayout()
        Me.pnlWeekButtonHolder.SuspendLayout()
        Me.pnlWeekScroll.SuspendLayout()
        CType(Me.btnWeekLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWeekRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolStripHolder.SuspendLayout()
        Me.tlsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.BackColor = System.Drawing.Color.Transparent
        Me.mnuMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiFile, Me.tsiEdit, Me.tsiTools, Me.tisEdit})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuMenu.Size = New System.Drawing.Size(798, 24)
        Me.mnuMenu.TabIndex = 9
        Me.mnuMenu.Text = "mnuMenu"
        '
        'tsiFile
        '
        Me.tsiFile.BackColor = System.Drawing.Color.White
        Me.tsiFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiLogin, Me.tsiLogout, Me.ToolStripSeparator11, Me.tsiPrint, Me.ToolStripSeparator4, Me.tsiExit})
        Me.tsiFile.Name = "tsiFile"
        Me.tsiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsiFile.Text = "&File"
        Me.tsiFile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsiLogin
        '
        Me.tsiLogin.Name = "tsiLogin"
        Me.tsiLogin.Size = New System.Drawing.Size(112, 22)
        Me.tsiLogin.Text = "Login"
        '
        'tsiLogout
        '
        Me.tsiLogout.Name = "tsiLogout"
        Me.tsiLogout.Size = New System.Drawing.Size(112, 22)
        Me.tsiLogout.Text = "Logout"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(109, 6)
        '
        'tsiPrint
        '
        Me.tsiPrint.Name = "tsiPrint"
        Me.tsiPrint.Size = New System.Drawing.Size(112, 22)
        Me.tsiPrint.Text = "Print"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(109, 6)
        '
        'tsiExit
        '
        Me.tsiExit.BackColor = System.Drawing.Color.White
        Me.tsiExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsiExit.Name = "tsiExit"
        Me.tsiExit.Size = New System.Drawing.Size(112, 22)
        Me.tsiExit.Text = "E&xit"
        Me.tsiExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsiEdit
        '
        Me.tsiEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiAdd, Me.tsiModifyDelete})
        Me.tsiEdit.Name = "tsiEdit"
        Me.tsiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsiEdit.Text = "&Edit"
        Me.tsiEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsiAdd
        '
        Me.tsiAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiAddContact, Me.tsiAddEvent, Me.tsiAddModule, Me.tsiAddRooms, Me.tsiAddStaff})
        Me.tsiAdd.Name = "tsiAdd"
        Me.tsiAdd.Size = New System.Drawing.Size(150, 22)
        Me.tsiAdd.Text = "&Add"
        Me.tsiAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsiAddContact
        '
        Me.tsiAddContact.Name = "tsiAddContact"
        Me.tsiAddContact.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddContact.Text = "Contact"
        '
        'tsiAddEvent
        '
        Me.tsiAddEvent.Name = "tsiAddEvent"
        Me.tsiAddEvent.Size = New System.Drawing.Size(116, 22)
        Me.tsiAddEvent.Text = "Event"
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
        Me.tsiModifyDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiModifyDelete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiModifyContact, Me.tsiModifyEvent, Me.tsiModifyModules, Me.tsiModifyRooms, Me.tsiModifyStaff})
        Me.tsiModifyDelete.Name = "tsiModifyDelete"
        Me.tsiModifyDelete.Size = New System.Drawing.Size(150, 22)
        Me.tsiModifyDelete.Text = "&Modify/Delete"
        Me.tsiModifyDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsiModifyContact
        '
        Me.tsiModifyContact.Name = "tsiModifyContact"
        Me.tsiModifyContact.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyContact.Text = "Contact"
        '
        'tsiModifyEvent
        '
        Me.tsiModifyEvent.Name = "tsiModifyEvent"
        Me.tsiModifyEvent.Size = New System.Drawing.Size(120, 22)
        Me.tsiModifyEvent.Text = "Event"
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
        'tsiTools
        '
        Me.tsiTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiTimetable, Me.tsiUserDetails, Me.ToolStripSeparator1, Me.tsiOptions})
        Me.tsiTools.Name = "tsiTools"
        Me.tsiTools.Size = New System.Drawing.Size(48, 20)
        Me.tsiTools.Text = "&Tools"
        '
        'tsiTimetable
        '
        Me.tsiTimetable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiNewTimetable, Me.ToolStripSeparator8, Me.tsiModifyTimetable, Me.tsiSelectTimetable})
        Me.tsiTimetable.Name = "tsiTimetable"
        Me.tsiTimetable.Size = New System.Drawing.Size(135, 22)
        Me.tsiTimetable.Text = "Timetable"
        '
        'tsiNewTimetable
        '
        Me.tsiNewTimetable.Name = "tsiNewTimetable"
        Me.tsiNewTimetable.Size = New System.Drawing.Size(112, 22)
        Me.tsiNewTimetable.Text = "New"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(109, 6)
        '
        'tsiModifyTimetable
        '
        Me.tsiModifyTimetable.Name = "tsiModifyTimetable"
        Me.tsiModifyTimetable.Size = New System.Drawing.Size(112, 22)
        Me.tsiModifyTimetable.Text = "Modify"
        '
        'tsiSelectTimetable
        '
        Me.tsiSelectTimetable.Name = "tsiSelectTimetable"
        Me.tsiSelectTimetable.Size = New System.Drawing.Size(112, 22)
        Me.tsiSelectTimetable.Text = "Select"
        '
        'tsiUserDetails
        '
        Me.tsiUserDetails.Name = "tsiUserDetails"
        Me.tsiUserDetails.Size = New System.Drawing.Size(135, 22)
        Me.tsiUserDetails.Text = "User Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'tsiOptions
        '
        Me.tsiOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsiOptions.Name = "tsiOptions"
        Me.tsiOptions.Size = New System.Drawing.Size(135, 22)
        Me.tsiOptions.Text = "&Options"
        '
        'tisEdit
        '
        Me.tisEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tisEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiHelp, Me.ToolStripSeparator10, Me.tsiSuggestions, Me.tsiAbout})
        Me.tisEdit.Name = "tisEdit"
        Me.tisEdit.Size = New System.Drawing.Size(44, 20)
        Me.tisEdit.Text = "Help"
        '
        'tsiHelp
        '
        Me.tsiHelp.Name = "tsiHelp"
        Me.tsiHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsiHelp.Size = New System.Drawing.Size(202, 22)
        Me.tsiHelp.Text = "Help"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(199, 6)
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
        'tmrScrollWeekButtonLeft
        '
        Me.tmrScrollWeekButtonLeft.Interval = 1
        '
        'imgArrowLeft
        '
        Me.imgArrowLeft.ImageStream = CType(resources.GetObject("imgArrowLeft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgArrowLeft.TransparentColor = System.Drawing.Color.Transparent
        Me.imgArrowLeft.Images.SetKeyName(0, "btnLeftEnabled.png")
        Me.imgArrowLeft.Images.SetKeyName(1, "btnLeftEnabled.png")
        Me.imgArrowLeft.Images.SetKeyName(2, "btnLeftEnabled.png")
        '
        'imgArrowRight
        '
        Me.imgArrowRight.ImageStream = CType(resources.GetObject("imgArrowRight.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgArrowRight.TransparentColor = System.Drawing.Color.Transparent
        Me.imgArrowRight.Images.SetKeyName(0, "media_play_green.png")
        Me.imgArrowRight.Images.SetKeyName(1, "media_play_green.png")
        Me.imgArrowRight.Images.SetKeyName(2, "media_play_green.png")
        '
        'tmrScrollWeekButtonRight
        '
        Me.tmrScrollWeekButtonRight.Interval = 1
        '
        'pnlMenuStripHolder
        '
        Me.pnlMenuStripHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenuStripHolder.BackColor = System.Drawing.Color.White
        Me.pnlMenuStripHolder.Controls.Add(Me.mnuMenu)
        Me.pnlMenuStripHolder.Location = New System.Drawing.Point(1, 29)
        Me.pnlMenuStripHolder.Name = "pnlMenuStripHolder"
        Me.pnlMenuStripHolder.Size = New System.Drawing.Size(798, 24)
        Me.pnlMenuStripHolder.TabIndex = 10
        '
        'pnlWeekEvent
        '
        Me.pnlWeekEvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWeekEvent.AutoScroll = True
        Me.pnlWeekEvent.BackColor = System.Drawing.Color.White
        Me.pnlWeekEvent.Location = New System.Drawing.Point(18, 111)
        Me.pnlWeekEvent.Name = "pnlWeekEvent"
        Me.pnlWeekEvent.Size = New System.Drawing.Size(764, 422)
        Me.pnlWeekEvent.TabIndex = 12
        '
        'pnlWeekButtonHolder
        '
        Me.pnlWeekButtonHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWeekButtonHolder.BackColor = System.Drawing.Color.Transparent
        Me.pnlWeekButtonHolder.Controls.Add(Me.pnlWeekScroll)
        Me.pnlWeekButtonHolder.Controls.Add(Me.btnWeekLeft)
        Me.pnlWeekButtonHolder.Controls.Add(Me.btnWeekRight)
        Me.pnlWeekButtonHolder.Location = New System.Drawing.Point(18, 542)
        Me.pnlWeekButtonHolder.Name = "pnlWeekButtonHolder"
        Me.pnlWeekButtonHolder.Size = New System.Drawing.Size(764, 40)
        Me.pnlWeekButtonHolder.TabIndex = 14
        '
        'pnlWeekScroll
        '
        Me.pnlWeekScroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlWeekScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlWeekScroll.Controls.Add(Me.pnlWeekButtons)
        Me.pnlWeekScroll.Location = New System.Drawing.Point(149, 0)
        Me.pnlWeekScroll.Name = "pnlWeekScroll"
        Me.pnlWeekScroll.Size = New System.Drawing.Size(466, 40)
        Me.pnlWeekScroll.TabIndex = 11
        '
        'pnlWeekButtons
        '
        Me.pnlWeekButtons.BackColor = System.Drawing.Color.White
        Me.pnlWeekButtons.Location = New System.Drawing.Point(0, 0)
        Me.pnlWeekButtons.Name = "pnlWeekButtons"
        Me.pnlWeekButtons.Size = New System.Drawing.Size(466, 40)
        Me.pnlWeekButtons.TabIndex = 10
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
        Me.btnWeekRight.Location = New System.Drawing.Point(740, 8)
        Me.btnWeekRight.Name = "btnWeekRight"
        Me.btnWeekRight.Size = New System.Drawing.Size(24, 24)
        Me.btnWeekRight.TabIndex = 11
        Me.btnWeekRight.TabStop = False
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(18, 84)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 15
        '
        'cboTerm
        '
        Me.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(145, 84)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(121, 21)
        Me.cboTerm.TabIndex = 16
        '
        'pnlToolStripHolder
        '
        Me.pnlToolStripHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlToolStripHolder.BackColor = System.Drawing.Color.White
        Me.pnlToolStripHolder.Controls.Add(Me.tlsToolStrip)
        Me.pnlToolStripHolder.Location = New System.Drawing.Point(1, 53)
        Me.pnlToolStripHolder.Name = "pnlToolStripHolder"
        Me.pnlToolStripHolder.Size = New System.Drawing.Size(798, 25)
        Me.pnlToolStripHolder.TabIndex = 11
        '
        'tlsToolStrip
        '
        Me.tlsToolStrip.BackColor = System.Drawing.Color.White
        Me.tlsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator, Me.tsbNewTimetable, Me.tsbSelectTimetable, Me.tsbPrint, Me.ToolStripSeparator3, Me.tsbAdd, Me.tsbUpdate, Me.ToolStripSeparator7, Me.tsbOptions, Me.tsbLogout, Me.toolStripSeparator2, Me.tsbHelp, Me.ToolStripSeparator9})
        Me.tlsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.tlsToolStrip.Name = "tlsToolStrip"
        Me.tlsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsToolStrip.Size = New System.Drawing.Size(798, 25)
        Me.tlsToolStrip.TabIndex = 0
        Me.tlsToolStrip.Text = "Tool Strip 1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'tsbNewTimetable
        '
        Me.tsbNewTimetable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNewTimetable.Image = Global.Tempestas.My.Resources.Images.table_sql_add
        Me.tsbNewTimetable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewTimetable.Name = "tsbNewTimetable"
        Me.tsbNewTimetable.Size = New System.Drawing.Size(23, 22)
        Me.tsbNewTimetable.Text = "ToolStripButton1"
        '
        'tsbSelectTimetable
        '
        Me.tsbSelectTimetable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSelectTimetable.Image = Global.Tempestas.My.Resources.Images.table_sql_select
        Me.tsbSelectTimetable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelectTimetable.Name = "tsbSelectTimetable"
        Me.tsbSelectTimetable.Size = New System.Drawing.Size(23, 22)
        Me.tsbSelectTimetable.Text = "ToolStripButton2"
        '
        'tsbPrint
        '
        Me.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrint.Image = Global.Tempestas.My.Resources.Images.printer
        Me.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrint.Text = "&Print"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEntryToolStripMenuItem, Me.ToolStripSeparator5, Me.AddContactToolStripMenuItem, Me.AddModuleToolStripMenuItem, Me.AddRoomToolStripMenuItem, Me.AddStaffToolStripMenuItem})
        Me.tsbAdd.Image = Global.Tempestas.My.Resources.Images.add2
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(32, 22)
        Me.tsbAdd.Text = "ToolStripSplitButton1"
        '
        'AddEntryToolStripMenuItem
        '
        Me.AddEntryToolStripMenuItem.Name = "AddEntryToolStripMenuItem"
        Me.AddEntryToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddEntryToolStripMenuItem.Text = "Add Event"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(138, 6)
        '
        'AddContactToolStripMenuItem
        '
        Me.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem"
        Me.AddContactToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddContactToolStripMenuItem.Text = "Add Contact"
        '
        'AddModuleToolStripMenuItem
        '
        Me.AddModuleToolStripMenuItem.Name = "AddModuleToolStripMenuItem"
        Me.AddModuleToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddModuleToolStripMenuItem.Text = "Add Module"
        '
        'AddRoomToolStripMenuItem
        '
        Me.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem"
        Me.AddRoomToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddRoomToolStripMenuItem.Text = "Add Room"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'tsbUpdate
        '
        Me.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUpdate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateEventToolStripMenuItem, Me.ToolStripSeparator6, Me.UpdateContactToolStripMenuItem, Me.UpdateModuleToolStripMenuItem, Me.UpdateRoomToolStripMenuItem, Me.UpdateStaffToolStripMenuItem})
        Me.tsbUpdate.Image = Global.Tempestas.My.Resources.Images.export1
        Me.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdate.Name = "tsbUpdate"
        Me.tsbUpdate.Size = New System.Drawing.Size(32, 22)
        Me.tsbUpdate.Text = "ToolStripSplitButton1"
        '
        'UpdateEventToolStripMenuItem
        '
        Me.UpdateEventToolStripMenuItem.Name = "UpdateEventToolStripMenuItem"
        Me.UpdateEventToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateEventToolStripMenuItem.Text = "Update Event"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(154, 6)
        '
        'UpdateContactToolStripMenuItem
        '
        Me.UpdateContactToolStripMenuItem.Name = "UpdateContactToolStripMenuItem"
        Me.UpdateContactToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateContactToolStripMenuItem.Text = "Update Contact"
        '
        'UpdateModuleToolStripMenuItem
        '
        Me.UpdateModuleToolStripMenuItem.Name = "UpdateModuleToolStripMenuItem"
        Me.UpdateModuleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateModuleToolStripMenuItem.Text = "Update Module"
        '
        'UpdateRoomToolStripMenuItem
        '
        Me.UpdateRoomToolStripMenuItem.Name = "UpdateRoomToolStripMenuItem"
        Me.UpdateRoomToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateRoomToolStripMenuItem.Text = "Update Room"
        '
        'UpdateStaffToolStripMenuItem
        '
        Me.UpdateStaffToolStripMenuItem.Name = "UpdateStaffToolStripMenuItem"
        Me.UpdateStaffToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateStaffToolStripMenuItem.Text = "Update Staff"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsbOptions
        '
        Me.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOptions.Image = Global.Tempestas.My.Resources.Images.preferences
        Me.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOptions.Name = "tsbOptions"
        Me.tsbOptions.Size = New System.Drawing.Size(23, 22)
        Me.tsbOptions.Text = "Options"
        '
        'tsbLogout
        '
        Me.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogout.Image = Global.Tempestas.My.Resources.Images.delete2
        Me.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(23, 22)
        Me.tsbLogout.Text = "Logout"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbHelp
        '
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.Image = Global.Tempestas.My.Resources.Images.help
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(23, 22)
        Me.tsbHelp.Text = "He&lp"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pnlToolStripHolder)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.pnlWeekEvent)
        Me.Controls.Add(Me.pnlWeekButtonHolder)
        Me.Controls.Add(Me.pnlMenuStripHolder)
        Me.DoubleBuffered = False
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "Tempestas"
        Me.TitleText = "Tempestas"
        Me.Controls.SetChildIndex(Me.pnlMenuStripHolder, 0)
        Me.Controls.SetChildIndex(Me.pnlWeekButtonHolder, 0)
        Me.Controls.SetChildIndex(Me.pnlWeekEvent, 0)
        Me.Controls.SetChildIndex(Me.cboYear, 0)
        Me.Controls.SetChildIndex(Me.cboTerm, 0)
        Me.Controls.SetChildIndex(Me.pnlToolStripHolder, 0)
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.pnlMenuStripHolder.ResumeLayout(False)
        Me.pnlMenuStripHolder.PerformLayout()
        Me.pnlWeekButtonHolder.ResumeLayout(False)
        Me.pnlWeekScroll.ResumeLayout(False)
        CType(Me.btnWeekLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWeekRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolStripHolder.ResumeLayout(False)
        Me.pnlToolStripHolder.PerformLayout()
        Me.tlsToolStrip.ResumeLayout(False)
        Me.tlsToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddEvent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAddStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyEvent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyModules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tisEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiSuggestions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrScrollWeekButtonLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrClickWeekButton As System.Windows.Forms.Timer
    Friend WithEvents imgArrowLeft As System.Windows.Forms.ImageList
    Friend WithEvents imgArrowRight As System.Windows.Forms.ImageList
    Friend WithEvents tmrScrollWeekButtonRight As System.Windows.Forms.Timer
    Friend WithEvents pnlMenuStripHolder As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekEvent As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekButtonHolder As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekScroll As System.Windows.Forms.Panel
    Friend WithEvents pnlWeekButtons As System.Windows.Forms.Panel
    Friend WithEvents btnWeekLeft As Tempestas.PictureBoxButton
    Friend WithEvents btnWeekRight As Tempestas.PictureBoxButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents tsiTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiTimetable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiNewTimetable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiModifyTimetable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiSelectTimetable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlToolStripHolder As System.Windows.Forms.Panel
    Friend WithEvents tlsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAdd As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AddEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiUserDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbUpdate As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents UpdateEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbNewTimetable As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSelectTimetable As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLogout As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsiPrint As System.Windows.Forms.ToolStripMenuItem

End Class
