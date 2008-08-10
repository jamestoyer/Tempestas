<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.lblError = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtStaffInitials = New System.Windows.Forms.TextBox
        Me.lblStaffName = New System.Windows.Forms.Label
        Me.lblStaffInitials = New System.Windows.Forms.Label
        Me.txtSalutation = New System.Windows.Forms.TextBox
        Me.lblSalutation = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.grpStaffDetails = New System.Windows.Forms.GroupBox
        Me.grpContactDetails = New System.Windows.Forms.GroupBox
        Me.btnNewRoom = New Tempestas.PictureBoxButton
        Me.imgAddField = New System.Windows.Forms.ImageList(Me.components)
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.cboOffice = New System.Windows.Forms.ComboBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblOffice = New System.Windows.Forms.Label
        Me.imgAcceptButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.grpStaffDetails.SuspendLayout()
        Me.grpContactDetails.SuspendLayout()
        CType(Me.btnNewRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(103, 214)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(188, 13)
        Me.lblError.TabIndex = 3
        Me.lblError.Text = "Please Enter the Staff Members Initials"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(79, 45)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 5
        Me.tipHelp.SetToolTip(Me.txtFirstName, "The first name of the member of staff")
        '
        'txtStaffInitials
        '
        Me.txtStaffInitials.Location = New System.Drawing.Point(250, 19)
        Me.txtStaffInitials.MaxLength = 5
        Me.txtStaffInitials.Name = "txtStaffInitials"
        Me.txtStaffInitials.Size = New System.Drawing.Size(39, 20)
        Me.txtStaffInitials.TabIndex = 3
        Me.tipHelp.SetToolTip(Me.txtStaffInitials, "The initials of the member of staff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is required")
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffName.ForeColor = System.Drawing.Color.Black
        Me.lblStaffName.Location = New System.Drawing.Point(8, 48)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(60, 13)
        Me.lblStaffName.TabIndex = 4
        Me.lblStaffName.Text = "First Name:"
        Me.tipHelp.SetToolTip(Me.lblStaffName, "The first name of the member of staff")
        '
        'lblStaffInitials
        '
        Me.lblStaffInitials.AutoSize = True
        Me.lblStaffInitials.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffInitials.ForeColor = System.Drawing.Color.Black
        Me.lblStaffInitials.Location = New System.Drawing.Point(180, 22)
        Me.lblStaffInitials.Name = "lblStaffInitials"
        Me.lblStaffInitials.Size = New System.Drawing.Size(64, 13)
        Me.lblStaffInitials.TabIndex = 2
        Me.lblStaffInitials.Text = "Staff Initials:"
        Me.tipHelp.SetToolTip(Me.lblStaffInitials, "The initials of the member of staff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is required")
        '
        'txtSalutation
        '
        Me.txtSalutation.Location = New System.Drawing.Point(79, 19)
        Me.txtSalutation.MaxLength = 10
        Me.txtSalutation.Name = "txtSalutation"
        Me.txtSalutation.Size = New System.Drawing.Size(39, 20)
        Me.txtSalutation.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.txtSalutation, "The salutation (title) of the member of staff")
        '
        'lblSalutation
        '
        Me.lblSalutation.AutoSize = True
        Me.lblSalutation.BackColor = System.Drawing.Color.Transparent
        Me.lblSalutation.ForeColor = System.Drawing.Color.Black
        Me.lblSalutation.Location = New System.Drawing.Point(8, 22)
        Me.lblSalutation.Name = "lblSalutation"
        Me.lblSalutation.Size = New System.Drawing.Size(57, 13)
        Me.lblSalutation.TabIndex = 0
        Me.lblSalutation.Text = "Salutation:"
        Me.tipHelp.SetToolTip(Me.lblSalutation, "The salutation (title) of the member of staff")
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(250, 45)
        Me.txtSurname.MaxLength = 150
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 7
        Me.tipHelp.SetToolTip(Me.txtSurname, "The surname of the member of staff")
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname.ForeColor = System.Drawing.Color.Black
        Me.lblSurname.Location = New System.Drawing.Point(192, 48)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 6
        Me.lblSurname.Text = "Surname:"
        Me.tipHelp.SetToolTip(Me.lblSurname, "The surname of the member of staff")
        '
        'grpStaffDetails
        '
        Me.grpStaffDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpStaffDetails.Controls.Add(Me.lblSurname)
        Me.grpStaffDetails.Controls.Add(Me.txtSurname)
        Me.grpStaffDetails.Controls.Add(Me.lblSalutation)
        Me.grpStaffDetails.Controls.Add(Me.txtStaffInitials)
        Me.grpStaffDetails.Controls.Add(Me.txtSalutation)
        Me.grpStaffDetails.Controls.Add(Me.lblStaffInitials)
        Me.grpStaffDetails.Controls.Add(Me.lblStaffName)
        Me.grpStaffDetails.Controls.Add(Me.txtFirstName)
        Me.grpStaffDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpStaffDetails.Location = New System.Drawing.Point(18, 47)
        Me.grpStaffDetails.Name = "grpStaffDetails"
        Me.grpStaffDetails.Size = New System.Drawing.Size(378, 76)
        Me.grpStaffDetails.TabIndex = 1
        Me.grpStaffDetails.TabStop = False
        Me.grpStaffDetails.Text = "Staff Details"
        '
        'grpContactDetails
        '
        Me.grpContactDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpContactDetails.Controls.Add(Me.btnNewRoom)
        Me.grpContactDetails.Controls.Add(Me.txtEmail)
        Me.grpContactDetails.Controls.Add(Me.cboOffice)
        Me.grpContactDetails.Controls.Add(Me.lblEmail)
        Me.grpContactDetails.Controls.Add(Me.lblOffice)
        Me.grpContactDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpContactDetails.Location = New System.Drawing.Point(18, 129)
        Me.grpContactDetails.Name = "grpContactDetails"
        Me.grpContactDetails.Size = New System.Drawing.Size(378, 76)
        Me.grpContactDetails.TabIndex = 2
        Me.grpContactDetails.TabStop = False
        Me.grpContactDetails.Text = "Contact Details"
        '
        'btnNewRoom
        '
        Me.btnNewRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnNewRoom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewRoom.Image = CType(resources.GetObject("btnNewRoom.Image"), System.Drawing.Image)
        Me.btnNewRoom.ImageList = Me.imgAddField
        Me.btnNewRoom.Location = New System.Drawing.Point(356, 48)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(16, 16)
        Me.btnNewRoom.TabIndex = 34
        Me.btnNewRoom.TabStop = False
        Me.tipHelp.SetToolTip(Me.btnNewRoom, "Click here to add a new office or room")
        '
        'imgAddField
        '
        Me.imgAddField.ImageStream = CType(resources.GetObject("imgAddField.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAddField.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAddField.Images.SetKeyName(0, "add2.png")
        Me.imgAddField.Images.SetKeyName(1, "add2.png")
        Me.imgAddField.Images.SetKeyName(2, "add2.png")
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(79, 19)
        Me.txtEmail.MaxLength = 300
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 1
        Me.tipHelp.SetToolTip(Me.txtEmail, "The e-mail address of the member of staff")
        '
        'cboOffice
        '
        Me.cboOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOffice.FormattingEnabled = True
        Me.cboOffice.Location = New System.Drawing.Point(79, 45)
        Me.cboOffice.Name = "cboOffice"
        Me.cboOffice.Size = New System.Drawing.Size(271, 21)
        Me.cboOffice.TabIndex = 3
        Me.tipHelp.SetToolTip(Me.cboOffice, "The office of the member of staff")
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(8, 22)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email:"
        Me.tipHelp.SetToolTip(Me.lblEmail, "The e-mail address of the member of staff")
        '
        'lblOffice
        '
        Me.lblOffice.AutoSize = True
        Me.lblOffice.BackColor = System.Drawing.Color.Transparent
        Me.lblOffice.ForeColor = System.Drawing.Color.Black
        Me.lblOffice.Location = New System.Drawing.Point(8, 48)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(38, 13)
        Me.lblOffice.TabIndex = 2
        Me.lblOffice.Text = "Office:"
        Me.tipHelp.SetToolTip(Me.lblOffice, "The office of the member of staff")
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgAcceptButton.ImageSize = New System.Drawing.Size(79, 23)
        Me.imgAcceptButton.TransparentColor = System.Drawing.Color.Lime
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAcceptButton
        Me.btnAccept.Location = New System.Drawing.Point(317, 236)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 20
        Me.btnAccept.TabStop = False
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.TabStop = False
        '
        'frmStaff
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(414, 277)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpContactDetails)
        Me.Controls.Add(Me.grpStaffDetails)
        Me.Controls.Add(Me.lblError)
        Me.HideTitleButtons = True
        Me.Name = "frmStaff"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Staff"
        Me.TitleText = "Staff"
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.grpStaffDetails, 0)
        Me.Controls.SetChildIndex(Me.grpContactDetails, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        Me.grpStaffDetails.ResumeLayout(False)
        Me.grpStaffDetails.PerformLayout()
        Me.grpContactDetails.ResumeLayout(False)
        Me.grpContactDetails.PerformLayout()
        CType(Me.btnNewRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffInitials As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffInitials As System.Windows.Forms.Label
    Friend WithEvents txtSalutation As System.Windows.Forms.TextBox
    Friend WithEvents lblSalutation As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents grpStaffDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpContactDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboOffice As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewRoom As Tempestas.PictureBoxButton
    Friend WithEvents imgAddField As System.Windows.Forms.ImageList
    Public WithEvents imgAcceptButton As System.Windows.Forms.ImageList
    Public WithEvents btnAccept As Tempestas.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton

End Class
