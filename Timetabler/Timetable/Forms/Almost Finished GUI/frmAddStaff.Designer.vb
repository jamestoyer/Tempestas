<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStaff))
        Me.txtStaffName = New System.Windows.Forms.TextBox
        Me.txtStaffInitials = New System.Windows.Forms.TextBox
        Me.lblStaffName = New System.Windows.Forms.Label
        Me.lblStaffInitials = New System.Windows.Forms.Label
        Me.imgAddButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.lblRequired = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.pbbAdd = New Timetable.PictureBoxButton
        Me.pbbCancel = New Timetable.PictureBoxButton
        Me.pbbStaffInitialsHelp = New Timetable.PictureBoxButton
        Me.pbbStaffNameHelp = New Timetable.PictureBoxButton
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbStaffInitialsHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbStaffNameHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(137, 80)
        Me.txtStaffName.MaxLength = 100
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(100, 20)
        Me.txtStaffName.TabIndex = 4
        '
        'txtStaffInitials
        '
        Me.txtStaffInitials.Location = New System.Drawing.Point(137, 41)
        Me.txtStaffInitials.MaxLength = 3
        Me.txtStaffInitials.Name = "txtStaffInitials"
        Me.txtStaffInitials.Size = New System.Drawing.Size(39, 20)
        Me.txtStaffInitials.TabIndex = 1
        Me.txtStaffInitials.Text = "WWW"
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffName.Location = New System.Drawing.Point(60, 83)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(63, 13)
        Me.lblStaffName.TabIndex = 3
        Me.lblStaffName.Text = "Staff Name:"
        '
        'lblStaffInitials
        '
        Me.lblStaffInitials.AutoSize = True
        Me.lblStaffInitials.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffInitials.Location = New System.Drawing.Point(60, 44)
        Me.lblStaffInitials.Name = "lblStaffInitials"
        Me.lblStaffInitials.Size = New System.Drawing.Size(71, 13)
        Me.lblStaffInitials.TabIndex = 0
        Me.lblStaffInitials.Text = "Staff Initials: *"
        '
        'imgAddButton
        '
        Me.imgAddButton.ImageStream = CType(resources.GetObject("imgAddButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAddButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgAddButton.Images.SetKeyName(0, "btnAddUp.png")
        Me.imgAddButton.Images.SetKeyName(1, "btnAddDown.png")
        Me.imgAddButton.Images.SetKeyName(2, "btnAddDisabled.png")
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'lblRequired
        '
        Me.lblRequired.AutoSize = True
        Me.lblRequired.BackColor = System.Drawing.Color.Transparent
        Me.lblRequired.Location = New System.Drawing.Point(105, 103)
        Me.lblRequired.Name = "lblRequired"
        Me.lblRequired.Size = New System.Drawing.Size(87, 13)
        Me.lblRequired.TabIndex = 5
        Me.lblRequired.Text = "* Required Fields"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(55, 64)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(188, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Please Enter the Staff Members Initials"
        '
        'pbbAdd
        '
        Me.pbbAdd.BackColor = System.Drawing.Color.Transparent
        Me.pbbAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbAdd.Image = CType(resources.GetObject("pbbAdd.Image"), System.Drawing.Image)
        Me.pbbAdd.ImageList = Me.imgAddButton
        Me.pbbAdd.Location = New System.Drawing.Point(207, 120)
        Me.pbbAdd.Name = "pbbAdd"
        Me.pbbAdd.Size = New System.Drawing.Size(79, 23)
        Me.pbbAdd.TabIndex = 15
        Me.pbbAdd.TabStop = False
        '
        'pbbCancel
        '
        Me.pbbCancel.BackColor = System.Drawing.Color.Transparent
        Me.pbbCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbCancel.Image = CType(resources.GetObject("pbbCancel.Image"), System.Drawing.Image)
        Me.pbbCancel.ImageList = Me.imgCancelButton
        Me.pbbCancel.Location = New System.Drawing.Point(12, 120)
        Me.pbbCancel.Name = "pbbCancel"
        Me.pbbCancel.Size = New System.Drawing.Size(79, 23)
        Me.pbbCancel.TabIndex = 14
        Me.pbbCancel.TabStop = False
        '
        'pbbStaffInitialsHelp
        '
        Me.pbbStaffInitialsHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbStaffInitialsHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbStaffInitialsHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbStaffInitialsHelp.ImageList = Nothing
        Me.pbbStaffInitialsHelp.Location = New System.Drawing.Point(182, 41)
        Me.pbbStaffInitialsHelp.Name = "pbbStaffInitialsHelp"
        Me.pbbStaffInitialsHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbStaffInitialsHelp.TabIndex = 16
        Me.pbbStaffInitialsHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbStaffInitialsHelp, "The intials of a staff member, maximum 3. This is a required field")
        '
        'pbbStaffNameHelp
        '
        Me.pbbStaffNameHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbStaffNameHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbStaffNameHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbStaffNameHelp.ImageList = Nothing
        Me.pbbStaffNameHelp.Location = New System.Drawing.Point(243, 80)
        Me.pbbStaffNameHelp.Name = "pbbStaffNameHelp"
        Me.pbbStaffNameHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbStaffNameHelp.TabIndex = 17
        Me.pbbStaffNameHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbStaffNameHelp, "The member of staff's name")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'frmAddStaff
        '
        Me.AcceptButton = Me.pbbAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timetable.My.Resources.Images.AddDialogBackground
        Me.CancelButton = Me.pbbCancel
        Me.ClientSize = New System.Drawing.Size(298, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbbStaffNameHelp)
        Me.Controls.Add(Me.pbbStaffInitialsHelp)
        Me.Controls.Add(Me.pbbAdd)
        Me.Controls.Add(Me.pbbCancel)
        Me.Controls.Add(Me.lblRequired)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtStaffInitials)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffInitials)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddStaff"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddStaff"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbStaffInitialsHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbStaffNameHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffInitials As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffInitials As System.Windows.Forms.Label
    Friend WithEvents pbbAdd As Timetable.PictureBoxButton
    Friend WithEvents imgAddButton As System.Windows.Forms.ImageList
    Friend WithEvents pbbCancel As Timetable.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents lblRequired As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pbbStaffInitialsHelp As Timetable.PictureBoxButton
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents pbbStaffNameHelp As Timetable.PictureBoxButton
End Class
