<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectModifyDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectModifyDelete))
        Me.imgModifyButton = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancelButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDelete = New Tempestas.PictureBoxButton
        Me.imgDeleteButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnModify = New Tempestas.PictureBoxButton
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.lstEvents = New System.Windows.Forms.ListBox
        Me.lblError = New System.Windows.Forms.Label
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgModifyButton
        '
        Me.imgModifyButton.ImageStream = CType(resources.GetObject("imgModifyButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgModifyButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgModifyButton.Images.SetKeyName(0, "btnModifyUp.png")
        Me.imgModifyButton.Images.SetKeyName(1, "btnModifyDown.png")
        Me.imgModifyButton.Images.SetKeyName(2, "btnModifyDisabled.png")
        '
        'imgCancelButton
        '
        Me.imgCancelButton.ImageStream = CType(resources.GetObject("imgCancelButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancelButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancelButton.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancelButton.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancelButton.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageList = Me.imgDeleteButton
        Me.btnDelete.Location = New System.Drawing.Point(223, 283)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.TabStop = False
        '
        'imgDeleteButton
        '
        Me.imgDeleteButton.ImageStream = CType(resources.GetObject("imgDeleteButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgDeleteButton.TransparentColor = System.Drawing.Color.Lime
        Me.imgDeleteButton.Images.SetKeyName(0, "btnDeleteUp.png")
        Me.imgDeleteButton.Images.SetKeyName(1, "btnDeleteDown.png")
        Me.imgDeleteButton.Images.SetKeyName(2, "btnDeleteDisabled.png")
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.BackColor = System.Drawing.Color.Transparent
        Me.btnModify.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageList = Me.imgModifyButton
        Me.btnModify.Location = New System.Drawing.Point(308, 283)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(79, 23)
        Me.btnModify.TabIndex = 20
        Me.btnModify.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancelButton
        Me.btnCancel.Location = New System.Drawing.Point(18, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.TabStop = False
        '
        'lstEvents
        '
        Me.lstEvents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.Location = New System.Drawing.Point(18, 47)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(369, 199)
        Me.lstEvents.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(144, 258)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(113, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Please select one item"
        '
        'frmSelectModifyDelete
        '
        Me.AcceptButton = Me.btnModify
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(405, 324)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstEvents)
        Me.HideTitleButtons = True
        Me.Name = "frmSelectModifyDelete"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Select Modify Delete"
        Me.TitleText = "Select Modify Delete"
        Me.Controls.SetChildIndex(Me.lstEvents, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgModifyButton As System.Windows.Forms.ImageList
    Friend WithEvents imgCancelButton As System.Windows.Forms.ImageList
    Friend WithEvents imgDeleteButton As System.Windows.Forms.ImageList
    Public WithEvents lblError As System.Windows.Forms.Label
    Public WithEvents btnDelete As Tempestas.PictureBoxButton
    Public WithEvents btnModify As Tempestas.PictureBoxButton
    Public WithEvents lstEvents As System.Windows.Forms.ListBox
    Public WithEvents btnCancel As Tempestas.PictureBoxButton

End Class
