<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.imgAccept = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.grpLoginDetails = New System.Windows.Forms.GroupBox
        Me.lblPasswordChecked = New System.Windows.Forms.Label
        Me.chkPassword = New System.Windows.Forms.CheckBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblConfirm = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLoginDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAccept
        Me.btnAccept.Location = New System.Drawing.Point(326, 215)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 17
        Me.btnAccept.TabStop = False
        '
        'imgAccept
        '
        Me.imgAccept.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgAccept.ImageSize = New System.Drawing.Size(79, 23)
        Me.imgAccept.TransparentColor = System.Drawing.Color.Lime
        '
        'imgCancel
        '
        Me.imgCancel.ImageStream = CType(resources.GetObject("imgCancel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancel.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancel.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancel.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(18, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(6, 22)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        Me.tipHelp.SetToolTip(Me.lblFirstName, "The first name of the user")
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname.ForeColor = System.Drawing.Color.Black
        Me.lblSurname.Location = New System.Drawing.Point(185, 22)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname:"
        Me.tipHelp.SetToolTip(Me.lblSurname, "The surname of the user")
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(275, 19)
        Me.txtSurname.MaxLength = 50
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 3
        Me.tipHelp.SetToolTip(Me.txtSurname, "The surname of the user")
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(79, 19)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.txtFirstName, "The first name of the user")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancel
        Me.btnCancel.Location = New System.Drawing.Point(18, 215)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.TabStop = False
        '
        'grpLoginDetails
        '
        Me.grpLoginDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpLoginDetails.Controls.Add(Me.lblPasswordChecked)
        Me.grpLoginDetails.Controls.Add(Me.chkPassword)
        Me.grpLoginDetails.Controls.Add(Me.txtUsername)
        Me.grpLoginDetails.Controls.Add(Me.txtConfirm)
        Me.grpLoginDetails.Controls.Add(Me.lblUserName)
        Me.grpLoginDetails.Controls.Add(Me.lblPassword)
        Me.grpLoginDetails.Controls.Add(Me.txtPassword)
        Me.grpLoginDetails.Controls.Add(Me.lblConfirm)
        Me.grpLoginDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpLoginDetails.Location = New System.Drawing.Point(18, 47)
        Me.grpLoginDetails.Name = "grpLoginDetails"
        Me.grpLoginDetails.Size = New System.Drawing.Size(387, 76)
        Me.grpLoginDetails.TabIndex = 1
        Me.grpLoginDetails.TabStop = False
        Me.grpLoginDetails.Text = "Login Details"
        '
        'lblPasswordChecked
        '
        Me.lblPasswordChecked.AutoSize = True
        Me.lblPasswordChecked.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordChecked.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordChecked.Location = New System.Drawing.Point(185, 22)
        Me.lblPasswordChecked.Name = "lblPasswordChecked"
        Me.lblPasswordChecked.Size = New System.Drawing.Size(84, 13)
        Me.lblPasswordChecked.TabIndex = 2
        Me.lblPasswordChecked.Text = "New Password?"
        Me.tipHelp.SetToolTip(Me.lblPasswordChecked, "The username for the new user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a unique field and is required")
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Location = New System.Drawing.Point(275, 22)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(15, 14)
        Me.chkPassword.TabIndex = 3
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(79, 19)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.txtUsername, "The username for the new user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a unique field and is required")
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(275, 45)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirm.TabIndex = 7
        Me.tipHelp.SetToolTip(Me.txtConfirm, "Confirm the password entered in the password box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These two passwords must match")
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(8, 22)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Username:"
        Me.tipHelp.SetToolTip(Me.lblUserName, "The username for the new user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a unique field and is required")
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(10, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        Me.tipHelp.SetToolTip(Me.lblPassword, "The password for the user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This can be left blank")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 45)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 5
        Me.tipHelp.SetToolTip(Me.txtPassword, "The password for the user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This can be left blank")
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.ForeColor = System.Drawing.Color.Black
        Me.lblConfirm.Location = New System.Drawing.Point(185, 48)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(45, 13)
        Me.lblConfirm.TabIndex = 6
        Me.lblConfirm.Text = "Confirm:"
        Me.tipHelp.SetToolTip(Me.lblConfirm, "Confirm the password entered in the password box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These two passwords must match")
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(168, 190)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 13)
        Me.lblError.TabIndex = 3
        Me.lblError.Text = "Error"
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'frmUser
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(423, 256)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpLoginDetails)
        Me.Controls.Add(Me.lblError)
        Me.HideTitleButtons = True
        Me.Name = "frmUser"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "User"
        Me.TitleText = "User"
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.grpLoginDetails, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLoginDetails.ResumeLayout(False)
        Me.grpLoginDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btnAccept As Tempestas.PictureBoxButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents grpLoginDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Public WithEvents imgAccept As System.Windows.Forms.ImageList
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Public WithEvents lblPasswordChecked As System.Windows.Forms.Label

End Class
