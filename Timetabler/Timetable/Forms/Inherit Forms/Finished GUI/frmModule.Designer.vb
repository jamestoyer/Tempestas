<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModule))
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgAcceptButton = New System.Windows.Forms.ImageList(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtModuleTitle = New System.Windows.Forms.TextBox
        Me.txtModuleCode = New System.Windows.Forms.TextBox
        Me.lblModuleTitle = New System.Windows.Forms.Label
        Me.lblModuleCode = New System.Windows.Forms.Label
        Me.lblStaff = New System.Windows.Forms.Label
        Me.cboStaff = New System.Windows.Forms.ComboBox
        Me.btnNewStaff = New Tempestas.PictureBoxButton
        Me.imgAddField = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.lblError = New System.Windows.Forms.Label
        CType(Me.btnNewStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgAcceptButton.ImageSize = New System.Drawing.Size(79, 23)
        Me.imgAcceptButton.TransparentColor = System.Drawing.Color.Lime
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'txtModuleTitle
        '
        Me.txtModuleTitle.Location = New System.Drawing.Point(103, 67)
        Me.txtModuleTitle.MaxLength = 8000
        Me.txtModuleTitle.Name = "txtModuleTitle"
        Me.txtModuleTitle.Size = New System.Drawing.Size(161, 20)
        Me.txtModuleTitle.TabIndex = 4
        Me.tipHelp.SetToolTip(Me.txtModuleTitle, "The title of the module")
        '
        'txtModuleCode
        '
        Me.txtModuleCode.Location = New System.Drawing.Point(103, 41)
        Me.txtModuleCode.MaxLength = 5
        Me.txtModuleCode.Name = "txtModuleCode"
        Me.txtModuleCode.Size = New System.Drawing.Size(61, 20)
        Me.txtModuleCode.TabIndex = 2
        Me.tipHelp.SetToolTip(Me.txtModuleCode, "The module code associated with module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'lblModuleTitle
        '
        Me.lblModuleTitle.AutoSize = True
        Me.lblModuleTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleTitle.Location = New System.Drawing.Point(24, 70)
        Me.lblModuleTitle.Name = "lblModuleTitle"
        Me.lblModuleTitle.Size = New System.Drawing.Size(68, 13)
        Me.lblModuleTitle.TabIndex = 3
        Me.lblModuleTitle.Text = "Module Title:"
        Me.tipHelp.SetToolTip(Me.lblModuleTitle, "The title of the module")
        '
        'lblModuleCode
        '
        Me.lblModuleCode.AutoSize = True
        Me.lblModuleCode.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleCode.Location = New System.Drawing.Point(24, 44)
        Me.lblModuleCode.Name = "lblModuleCode"
        Me.lblModuleCode.Size = New System.Drawing.Size(73, 13)
        Me.lblModuleCode.TabIndex = 1
        Me.lblModuleCode.Text = "Module Code:"
        Me.tipHelp.SetToolTip(Me.lblModuleCode, "The module code associated with module" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblStaff.Location = New System.Drawing.Point(24, 96)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(73, 13)
        Me.lblStaff.TabIndex = 5
        Me.lblStaff.Text = "Staff Member:"
        Me.tipHelp.SetToolTip(Me.lblStaff, "The member of staff in charge of the module")
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(103, 93)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(161, 21)
        Me.cboStaff.TabIndex = 6
        Me.tipHelp.SetToolTip(Me.cboStaff, "The member of staff in charge of the module")
        '
        'btnNewStaff
        '
        Me.btnNewStaff.BackColor = System.Drawing.Color.Transparent
        Me.btnNewStaff.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewStaff.Image = CType(resources.GetObject("btnNewStaff.Image"), System.Drawing.Image)
        Me.btnNewStaff.ImageList = Me.imgAddField
        Me.btnNewStaff.Location = New System.Drawing.Point(270, 96)
        Me.btnNewStaff.Name = "btnNewStaff"
        Me.btnNewStaff.Size = New System.Drawing.Size(16, 16)
        Me.btnNewStaff.TabIndex = 37
        Me.btnNewStaff.TabStop = False
        Me.tipHelp.SetToolTip(Me.btnNewStaff, "Click here to add a new member of staff")
        '
        'imgAddField
        '
        Me.imgAddField.ImageStream = CType(resources.GetObject("imgAddField.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAddField.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAddField.Images.SetKeyName(0, "add2.png")
        Me.imgAddField.Images.SetKeyName(1, "add2.png")
        Me.imgAddField.Images.SetKeyName(2, "add2.png")
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAcceptButton
        Me.btnAccept.Location = New System.Drawing.Point(213, 144)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 19
        Me.btnAccept.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 144)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(88, 122)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(142, 13)
        Me.lblError.TabIndex = 7
        Me.lblError.Text = "Please Enter a Module Code"
        '
        'frmModule
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(310, 185)
        Me.Controls.Add(Me.btnNewStaff)
        Me.Controls.Add(Me.cboStaff)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtModuleTitle)
        Me.Controls.Add(Me.txtModuleCode)
        Me.Controls.Add(Me.lblModuleTitle)
        Me.Controls.Add(Me.lblModuleCode)
        Me.HideTitleButtons = True
        Me.Name = "frmModule"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Module"
        Me.TitleText = "Module"
        Me.Controls.SetChildIndex(Me.lblModuleCode, 0)
        Me.Controls.SetChildIndex(Me.lblModuleTitle, 0)
        Me.Controls.SetChildIndex(Me.txtModuleCode, 0)
        Me.Controls.SetChildIndex(Me.txtModuleTitle, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        Me.Controls.SetChildIndex(Me.lblStaff, 0)
        Me.Controls.SetChildIndex(Me.cboStaff, 0)
        Me.Controls.SetChildIndex(Me.btnNewStaff, 0)
        CType(Me.btnNewStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtModuleTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtModuleCode As System.Windows.Forms.TextBox
    Friend WithEvents lblModuleTitle As System.Windows.Forms.Label
    Friend WithEvents lblModuleCode As System.Windows.Forms.Label
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewStaff As Tempestas.PictureBoxButton
    Friend WithEvents imgAddField As System.Windows.Forms.ImageList
    Public WithEvents btnAccept As Tempestas.PictureBoxButton
    Public WithEvents imgAcceptButton As System.Windows.Forms.ImageList

End Class
