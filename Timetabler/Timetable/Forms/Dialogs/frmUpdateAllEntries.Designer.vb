<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateAllEntries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateAllEntries))
        Me.lblMessage = New System.Windows.Forms.Label
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnOk = New Tempestas.PictureBoxButton
        Me.imgOkButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(66, 63)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(165, 26)
        Me.lblMessage.TabIndex = 22
        Me.lblMessage.Text = "This will update all related entries." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Are you sure you want to do this?"
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageList = Me.imgOkButton
        Me.btnOk.Location = New System.Drawing.Point(203, 119)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(79, 23)
        Me.btnOk.TabIndex = 21
        Me.btnOk.TabStop = False
        '
        'imgOkButton
        '
        Me.imgOkButton.ImageStream = CType(resources.GetObject("imgOkButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgOkButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgOkButton.Images.SetKeyName(0, "btnOKUp.png")
        Me.imgOkButton.Images.SetKeyName(1, "btnOKDown.png")
        Me.imgOkButton.Images.SetKeyName(2, "btnOKDisabled.png")
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.TabStop = False
        '
        'frmUpdateAllEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(300, 160)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmUpdateAllEntries"
        Me.Text = "Are You Sure?"
        Me.TitleText = "Are You Sure?"
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents btnOk As Tempestas.PictureBoxButton
    Friend WithEvents imgOkButton As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton

End Class
