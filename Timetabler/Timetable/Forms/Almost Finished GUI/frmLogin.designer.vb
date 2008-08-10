<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.lblUsername = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.imgNew = New System.Windows.Forms.ImageList(Me.components)
        Me.btnNew = New Tempestas.PictureBoxButton
        Me.btnLogin = New Tempestas.PictureBoxButton
        Me.imgLogin = New System.Windows.Forms.ImageList(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCancel
        '
        Me.imgCancel.ImageStream = CType(resources.GetObject("imgCancel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancel.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancel.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancel.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancel
        Me.btnCancel.Location = New System.Drawing.Point(18, 165)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Location = New System.Drawing.Point(64, 77)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        Me.tipHelp.SetToolTip(Me.lblUsername, "The username of the user that wants to login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is required")
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(66, 103)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        Me.tipHelp.SetToolTip(Me.lblPassword, "The password of the user that wants to login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field can be empty depending o" & _
                "n the password")
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Location = New System.Drawing.Point(93, 44)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(164, 13)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Please login or create a new user"
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(97, 136)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(169, 13)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "Username or password is incorrect"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtUsername.Location = New System.Drawing.Point(128, 74)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(178, 20)
        Me.txtUsername.TabIndex = 3
        Me.tipHelp.SetToolTip(Me.txtUsername, "The username of the user that wants to login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is required")
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtPassword.Location = New System.Drawing.Point(128, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(178, 20)
        Me.txtPassword.TabIndex = 5
        Me.tipHelp.SetToolTip(Me.txtPassword, "The password of the user that wants to login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field can be empty depending o" & _
                "n the password")
        '
        'imgNew
        '
        Me.imgNew.ImageStream = CType(resources.GetObject("imgNew.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgNew.TransparentColor = System.Drawing.Color.Lime
        Me.imgNew.Images.SetKeyName(0, "btnNewUp.png")
        Me.imgNew.Images.SetKeyName(1, "btnNewDown.png")
        Me.imgNew.Images.SetKeyName(2, "btnNewDisabled.png")
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageList = Me.imgNew
        Me.btnNew.Location = New System.Drawing.Point(188, 165)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(79, 23)
        Me.btnNew.TabIndex = 13
        Me.btnNew.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageList = Me.imgLogin
        Me.btnLogin.Location = New System.Drawing.Point(273, 165)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(79, 23)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.TabStop = False
        '
        'imgLogin
        '
        Me.imgLogin.ImageStream = CType(resources.GetObject("imgLogin.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLogin.TransparentColor = System.Drawing.Color.Lime
        Me.imgLogin.Images.SetKeyName(0, "btnLoginUp.png")
        Me.imgLogin.Images.SetKeyName(1, "btnLoginDown.png")
        Me.imgLogin.Images.SetKeyName(2, "btnLoginDisabled.png")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(370, 206)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.HideTitleButtons = True
        Me.Name = "frmLogin"
        Me.Resizeable = False
        Me.Text = "Login"
        Me.TitleText = "Login"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblUsername, 0)
        Me.Controls.SetChildIndex(Me.lblPassword, 0)
        Me.Controls.SetChildIndex(Me.lblInfo, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.txtUsername, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnLogin, 0)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents imgNew As System.Windows.Forms.ImageList
    Friend WithEvents btnNew As Tempestas.PictureBoxButton
    Friend WithEvents btnLogin As Tempestas.PictureBoxButton
    Friend WithEvents imgLogin As System.Windows.Forms.ImageList
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip

End Class
