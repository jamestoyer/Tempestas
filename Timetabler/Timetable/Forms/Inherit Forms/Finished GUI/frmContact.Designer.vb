<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContact))
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.imgAcceptButton = New System.Windows.Forms.ImageList(Me.components)
        Me.lblError = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.lblContact = New System.Windows.Forms.Label
        Me.clrContactColour = New System.Windows.Forms.ColorDialog
        Me.lblColour = New System.Windows.Forms.Label
        Me.cboColour = New System.Windows.Forms.ComboBox
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 126)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.TabStop = False
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
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAcceptButton
        Me.btnAccept.Location = New System.Drawing.Point(203, 126)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 7
        Me.btnAccept.TabStop = False
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgAcceptButton.ImageSize = New System.Drawing.Size(79, 23)
        Me.imgAcceptButton.TransparentColor = System.Drawing.Color.Lime
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(77, 103)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(143, 13)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Please Enter a Contact Type"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContact.Location = New System.Drawing.Point(143, 47)
        Me.txtContact.MaxLength = 50
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(100, 20)
        Me.txtContact.TabIndex = 2
        Me.tipHelp.SetToolTip(Me.txtContact, "The name of the type of contact e.g Seminar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        Me.txtContact.WordWrap = False
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Location = New System.Drawing.Point(57, 50)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(74, 13)
        Me.lblContact.TabIndex = 1
        Me.lblContact.Text = "Contact Type:"
        Me.tipHelp.SetToolTip(Me.lblContact, "The name of the type of contact e.g Seminar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'clrContactColour
        '
        Me.clrContactColour.AllowFullOpen = False
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.BackColor = System.Drawing.Color.White
        Me.lblColour.Location = New System.Drawing.Point(57, 76)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(80, 13)
        Me.lblColour.TabIndex = 3
        Me.lblColour.Text = "Contact Colour:"
        Me.tipHelp.SetToolTip(Me.lblColour, "The colour you would like to designate this contact." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'cboColour
        '
        Me.cboColour.BackColor = System.Drawing.Color.Black
        Me.cboColour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColour.ForeColor = System.Drawing.Color.White
        Me.cboColour.FormattingEnabled = True
        Me.cboColour.IntegralHeight = False
        Me.cboColour.ItemHeight = 15
        Me.cboColour.Location = New System.Drawing.Point(143, 73)
        Me.cboColour.Name = "cboColour"
        Me.cboColour.Size = New System.Drawing.Size(100, 21)
        Me.cboColour.TabIndex = 4
        Me.tipHelp.SetToolTip(Me.cboColour, "The colour you would like to designate this contact." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'tipHelp
        '
        Me.tipHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'frmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(300, 167)
        Me.Controls.Add(Me.cboColour)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.HideTitleButtons = True
        Me.MinimumSize = New System.Drawing.Size(250, 160)
        Me.Name = "frmContact"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Contact"
        Me.TitleText = "Contact"
        Me.Controls.SetChildIndex(Me.lblContact, 0)
        Me.Controls.SetChildIndex(Me.txtContact, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblColour, 0)
        Me.Controls.SetChildIndex(Me.cboColour, 0)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Public WithEvents btnAccept As Tempestas.PictureBoxButton
    Public WithEvents imgAcceptButton As System.Windows.Forms.ImageList
    Public WithEvents clrContactColour As System.Windows.Forms.ColorDialog
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Public WithEvents cboColour As System.Windows.Forms.ComboBox

End Class
