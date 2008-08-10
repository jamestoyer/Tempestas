<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddModule))
        Me.lblModuleCode = New System.Windows.Forms.Label
        Me.lblModuleTitle = New System.Windows.Forms.Label
        Me.txtModuleCode = New System.Windows.Forms.TextBox
        Me.txtModuleTitle = New System.Windows.Forms.TextBox
        Me.lblError = New System.Windows.Forms.Label
        Me.lblRequired = New System.Windows.Forms.Label
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgAddButton = New System.Windows.Forms.ImageList(Me.components)
        Me.pbbAdd = New Timetable.PictureBoxButton
        Me.pbbCancel = New Timetable.PictureBoxButton
        Me.pbbModuleCodeHelp = New Timetable.PictureBoxButton
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbbModuleTitleHelp = New Timetable.PictureBoxButton
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbModuleCodeHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbModuleTitleHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblModuleCode
        '
        Me.lblModuleCode.AutoSize = True
        Me.lblModuleCode.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleCode.Location = New System.Drawing.Point(56, 44)
        Me.lblModuleCode.Name = "lblModuleCode"
        Me.lblModuleCode.Size = New System.Drawing.Size(80, 13)
        Me.lblModuleCode.TabIndex = 0
        Me.lblModuleCode.Text = "Module Code: *"
        '
        'lblModuleTitle
        '
        Me.lblModuleTitle.AutoSize = True
        Me.lblModuleTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleTitle.Location = New System.Drawing.Point(56, 83)
        Me.lblModuleTitle.Name = "lblModuleTitle"
        Me.lblModuleTitle.Size = New System.Drawing.Size(68, 13)
        Me.lblModuleTitle.TabIndex = 3
        Me.lblModuleTitle.Text = "Module Title:"
        '
        'txtModuleCode
        '
        Me.txtModuleCode.Location = New System.Drawing.Point(142, 41)
        Me.txtModuleCode.MaxLength = 5
        Me.txtModuleCode.Name = "txtModuleCode"
        Me.txtModuleCode.Size = New System.Drawing.Size(61, 20)
        Me.txtModuleCode.TabIndex = 1
        Me.txtModuleCode.Text = "WWWWW"
        '
        'txtModuleTitle
        '
        Me.txtModuleTitle.Location = New System.Drawing.Point(142, 80)
        Me.txtModuleTitle.MaxLength = 8000
        Me.txtModuleTitle.Name = "txtModuleTitle"
        Me.txtModuleTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtModuleTitle.TabIndex = 4
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(78, 64)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(142, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Please Enter a Module Code"
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
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'imgAddButton
        '
        Me.imgAddButton.ImageStream = CType(resources.GetObject("imgAddButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAddButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgAddButton.Images.SetKeyName(0, "btnAddUp.png")
        Me.imgAddButton.Images.SetKeyName(1, "btnAddDown.png")
        Me.imgAddButton.Images.SetKeyName(2, "btnAddDisabled.png")
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
        Me.pbbAdd.TabIndex = 9
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
        Me.pbbCancel.TabIndex = 8
        Me.pbbCancel.TabStop = False
        '
        'pbbModuleCodeHelp
        '
        Me.pbbModuleCodeHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbModuleCodeHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbModuleCodeHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbModuleCodeHelp.ImageList = Nothing
        Me.pbbModuleCodeHelp.Location = New System.Drawing.Point(209, 41)
        Me.pbbModuleCodeHelp.Name = "pbbModuleCodeHelp"
        Me.pbbModuleCodeHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbModuleCodeHelp.TabIndex = 10
        Me.pbbModuleCodeHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbModuleCodeHelp, "The module code associated with module. This is a required field")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'pbbModuleTitleHelp
        '
        Me.pbbModuleTitleHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbbModuleTitleHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pbbModuleTitleHelp.Image = Global.Timetable.My.Resources.Images.help
        Me.pbbModuleTitleHelp.ImageList = Nothing
        Me.pbbModuleTitleHelp.Location = New System.Drawing.Point(248, 80)
        Me.pbbModuleTitleHelp.Name = "pbbModuleTitleHelp"
        Me.pbbModuleTitleHelp.Size = New System.Drawing.Size(16, 16)
        Me.pbbModuleTitleHelp.TabIndex = 11
        Me.pbbModuleTitleHelp.TabStop = False
        Me.tipHelp.SetToolTip(Me.pbbModuleTitleHelp, "The name of the module")
        '
        'frmAddModule
        '
        Me.AcceptButton = Me.pbbAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timetable.My.Resources.Images.AddDialogBackground
        Me.CancelButton = Me.pbbCancel
        Me.ClientSize = New System.Drawing.Size(298, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbbModuleTitleHelp)
        Me.Controls.Add(Me.pbbModuleCodeHelp)
        Me.Controls.Add(Me.pbbAdd)
        Me.Controls.Add(Me.pbbCancel)
        Me.Controls.Add(Me.lblRequired)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtModuleTitle)
        Me.Controls.Add(Me.txtModuleCode)
        Me.Controls.Add(Me.lblModuleTitle)
        Me.Controls.Add(Me.lblModuleCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddModule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddModule"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbModuleCodeHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbModuleTitleHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModuleCode As System.Windows.Forms.Label
    Friend WithEvents lblModuleTitle As System.Windows.Forms.Label
    Friend WithEvents txtModuleCode As System.Windows.Forms.TextBox
    Friend WithEvents txtModuleTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblRequired As System.Windows.Forms.Label
    Friend WithEvents pbbCancel As Timetable.PictureBoxButton
    Friend WithEvents pbbAdd As Timetable.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents imgAddButton As System.Windows.Forms.ImageList
    Friend WithEvents pbbModuleCodeHelp As Timetable.PictureBoxButton
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents pbbModuleTitleHelp As Timetable.PictureBoxButton
End Class
