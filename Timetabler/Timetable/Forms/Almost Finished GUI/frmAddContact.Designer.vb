<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddContact))
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.lblContact = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.imgAddButton = New System.Windows.Forms.ImageList(Me.components)
        Me.pbbAdd = New Timetable.PictureBoxButton
        Me.pbbCancel = New Timetable.PictureBoxButton
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(139, 69)
        Me.txtContact.MaxLength = 50
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(100, 20)
        Me.txtContact.TabIndex = 1
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Location = New System.Drawing.Point(59, 72)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(74, 13)
        Me.lblContact.TabIndex = 0
        Me.lblContact.Text = "Contact Type:"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(78, 92)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(143, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Please Enter a Contact Type"
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
        Me.pbbAdd.TabIndex = 13
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
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'frmAddContact
        '
        Me.AcceptButton = Me.pbbAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Timetable.My.Resources.Images.AddDialogBackground
        Me.CancelButton = Me.pbbCancel
        Me.ClientSize = New System.Drawing.Size(298, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbbCancel)
        Me.Controls.Add(Me.pbbAdd)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddContact"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddNewContact"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.pbbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pbbAdd As Timetable.PictureBoxButton
    Friend WithEvents imgAddButton As System.Windows.Forms.ImageList
    Friend WithEvents pbbCancel As Timetable.PictureBoxButton
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
End Class
