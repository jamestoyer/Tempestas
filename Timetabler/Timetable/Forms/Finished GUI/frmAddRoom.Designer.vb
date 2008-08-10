<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRoom))
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblRoomNumber = New System.Windows.Forms.Label
        Me.lblRequired = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.imgAddButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.pbbAdd = New Timetable.PictureBoxButton
        Me.pbbCancel = New Timetable.PictureBoxButton
        Me.pbbRoomNumberHelp = New Timetable.PictureBoxButton
        Me.pbbDepartmentHelp = New Timetable.PictureBoxButton
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbRoomNumberHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbDepartmentHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(144, 80)
        Me.txtDepartment.MaxLength = 8000
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartment.TabIndex = 4
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(144, 41)
        Me.txtRoomNumber.MaxLength = 6
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRoomNumber.TabIndex = 1
        Me.txtRoomNumber.Text = "WWWWWW"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Location = New System.Drawing.Point(53, 83)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.lblDepartment.TabIndex = 3
        Me.lblDepartment.Text = "Department:"
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNumber.Location = New System.Drawing.Point(53, 44)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(85, 13)
        Me.lblRoomNumber.TabIndex = 0
        Me.lblRoomNumber.Text = "Room Number: *"
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
        Me.lblError.Location = New System.Drawing.Point(78, 64)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(147, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Please Enter a Room Number"
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
        'pbbAdd
        '
        Me.pbbAdd.BackColor = System.Drawing.Color.Transparent
        Me.pbbAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbAdd.Image = CType(resources.GetObject("pbbAdd.Image"), System.Drawing.Image)
        Me.pbbAdd.ImageList = Me.imgAddButton
        Me.pbbAdd.Location = New System.Drawing.Point(207, 120)
        Me.pbbAdd.Name = "pbbAdd"
        Me.pbbAdd.Size = New System.Drawing.Size(79, 23)
        Me.pbbAdd.TabIndex = 11
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
        Me.pbbCancel.TabIndex = 10
        Me.pbbCancel.TabStop = False
        '
        'pbbRoomNumberHelp
        '
        Me.pbbRoomNumberHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbRoomNumberHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbRoomNumberHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbRoomNumberHelp.ImageList = Nothing
        Me.pbbRoomNumberHelp.Location = New System.Drawing.Point(222, 41)
        Me.pbbRoomNumberHelp.Name = "pbbRoomNumberHelp"
        Me.pbbRoomNumberHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbRoomNumberHelp.TabIndex = 12
        Me.pbbRoomNumberHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbRoomNumberHelp, "The room number. This is a required field")
        '
        'pbbDepartmentHelp
        '
        Me.pbbDepartmentHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbDepartmentHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbDepartmentHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbDepartmentHelp.ImageList = Nothing
        Me.pbbDepartmentHelp.Location = New System.Drawing.Point(250, 80)
        Me.pbbDepartmentHelp.Name = "pbbDepartmentHelp"
        Me.pbbDepartmentHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbDepartmentHelp.TabIndex = 13
        Me.pbbDepartmentHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbDepartmentHelp, "The department in which the room is located")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'frmAddRoom
        '
        Me.AcceptButton = Me.pbbAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timetable.My.Resources.Images.AddDialogBackground
        Me.CancelButton = Me.pbbCancel
        Me.ClientSize = New System.Drawing.Size(298, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbbDepartmentHelp)
        Me.Controls.Add(Me.pbbRoomNumberHelp)
        Me.Controls.Add(Me.pbbAdd)
        Me.Controls.Add(Me.pbbCancel)
        Me.Controls.Add(Me.lblRequired)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblRoomNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddRoom"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddRoom"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbRoomNumberHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbDepartmentHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Friend WithEvents lblRequired As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents imgAddButton As System.Windows.Forms.ImageList
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents pbbAdd As Timetable.PictureBoxButton
    Friend WithEvents pbbCancel As Timetable.PictureBoxButton
    Friend WithEvents pbbRoomNumberHelp As Timetable.PictureBoxButton
    Friend WithEvents pbbDepartmentHelp As Timetable.PictureBoxButton
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
End Class
