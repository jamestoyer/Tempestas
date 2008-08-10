<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoom))
        Me.imgAcceptButton = New System.Windows.Forms.ImageList(Me.components)
        Me.tipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.btnAccept = New Tempestas.PictureBoxButton
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.lblError = New System.Windows.Forms.Label
        Me.lblRoomNumber = New System.Windows.Forms.Label
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(142, 73)
        Me.txtDepartment.MaxLength = 8000
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartment.TabIndex = 4
        Me.tipHelp.SetToolTip(Me.txtDepartment, "The department in which the room is located")
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(142, 47)
        Me.txtRoomNumber.MaxLength = 6
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRoomNumber.TabIndex = 2
        Me.tipHelp.SetToolTip(Me.txtRoomNumber, "The room number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Location = New System.Drawing.Point(58, 76)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.lblDepartment.TabIndex = 3
        Me.lblDepartment.Text = "Department:"
        Me.tipHelp.SetToolTip(Me.lblDepartment, "The department in which the room is located")
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccept.ImageList = Me.imgAcceptButton
        Me.btnAccept.Location = New System.Drawing.Point(203, 126)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(79, 23)
        Me.btnAccept.TabIndex = 21
        Me.btnAccept.TabStop = False
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
        Me.btnCancel.TabIndex = 20
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
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(79, 103)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(147, 13)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Please Enter a Room Number"
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNumber.Location = New System.Drawing.Point(58, 50)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblRoomNumber.TabIndex = 1
        Me.lblRoomNumber.Text = "Room Number:"
        Me.tipHelp.SetToolTip(Me.lblRoomNumber, "The room number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a required field")
        '
        'frmRoom
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(300, 167)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblRoomNumber)
        Me.HideTitleButtons = True
        Me.Name = "frmRoom"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Room"
        Me.TitleText = "Room"
        Me.Controls.SetChildIndex(Me.lblRoomNumber, 0)
        Me.Controls.SetChildIndex(Me.lblDepartment, 0)
        Me.Controls.SetChildIndex(Me.txtRoomNumber, 0)
        Me.Controls.SetChildIndex(Me.txtDepartment, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnAccept, 0)
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Public WithEvents imgAcceptButton As System.Windows.Forms.ImageList
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Public WithEvents btnAccept As Tempestas.PictureBoxButton

End Class
