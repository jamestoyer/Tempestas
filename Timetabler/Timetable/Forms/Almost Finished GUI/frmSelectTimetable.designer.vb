<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectTimetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectTimetable))
        Me.lblTimetable = New System.Windows.Forms.Label
        Me.cboTimetable = New System.Windows.Forms.ComboBox
        Me.lblError = New System.Windows.Forms.Label
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.btnNew = New Tempestas.PictureBoxButton
        Me.imgNew = New System.Windows.Forms.ImageList(Me.components)
        Me.imgLoad = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLoad = New Tempestas.PictureBoxButton
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimetable
        '
        Me.lblTimetable.AutoSize = True
        Me.lblTimetable.BackColor = System.Drawing.Color.Transparent
        Me.lblTimetable.Location = New System.Drawing.Point(15, 66)
        Me.lblTimetable.Name = "lblTimetable"
        Me.lblTimetable.Size = New System.Drawing.Size(56, 13)
        Me.lblTimetable.TabIndex = 1
        Me.lblTimetable.Text = "Timetable:"
        '
        'cboTimetable
        '
        Me.cboTimetable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimetable.FormattingEnabled = True
        Me.cboTimetable.Location = New System.Drawing.Point(80, 63)
        Me.cboTimetable.Name = "cboTimetable"
        Me.cboTimetable.Size = New System.Drawing.Size(210, 21)
        Me.cboTimetable.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(146, 98)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 13)
        Me.lblError.TabIndex = 3
        Me.lblError.Text = "Error"
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
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancel
        Me.btnCancel.Location = New System.Drawing.Point(18, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageList = Me.imgNew
        Me.btnNew.Location = New System.Drawing.Point(126, 123)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(79, 23)
        Me.btnNew.TabIndex = 12
        Me.btnNew.TabStop = False
        '
        'imgNew
        '
        Me.imgNew.ImageStream = CType(resources.GetObject("imgNew.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgNew.TransparentColor = System.Drawing.Color.Lime
        Me.imgNew.Images.SetKeyName(0, "btnNewUp.png")
        Me.imgNew.Images.SetKeyName(1, "btnNewDown.png")
        Me.imgNew.Images.SetKeyName(2, "btnNewDisabled.png")
        '
        'imgLoad
        '
        Me.imgLoad.ImageStream = CType(resources.GetObject("imgLoad.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLoad.TransparentColor = System.Drawing.Color.Lime
        Me.imgLoad.Images.SetKeyName(0, "btnLoadUp.png")
        Me.imgLoad.Images.SetKeyName(1, "btnLoadDown.png")
        Me.imgLoad.Images.SetKeyName(2, "btnLoadDisabled.png")
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageList = Me.imgLoad
        Me.btnLoad.Location = New System.Drawing.Point(211, 123)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(79, 23)
        Me.btnLoad.TabIndex = 13
        Me.btnLoad.TabStop = False
        '
        'frmSelectTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(308, 164)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.cboTimetable)
        Me.Controls.Add(Me.lblTimetable)
        Me.Name = "frmSelectTimetable"
        Me.Text = "Select Timetable"
        Me.TitleText = "Select Timetable"
        Me.Controls.SetChildIndex(Me.lblTimetable, 0)
        Me.Controls.SetChildIndex(Me.cboTimetable, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnLoad, 0)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimetable As System.Windows.Forms.Label
    Friend WithEvents cboTimetable As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents btnNew As Tempestas.PictureBoxButton
    Friend WithEvents imgNew As System.Windows.Forms.ImageList
    Friend WithEvents imgLoad As System.Windows.Forms.ImageList
    Friend WithEvents btnLoad As Tempestas.PictureBoxButton

End Class
