<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimetableSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimetableSystem))
        Me.pnlSystem = New System.Windows.Forms.Panel
        Me.radBoth = New System.Windows.Forms.RadioButton
        Me.radTerm = New System.Windows.Forms.RadioButton
        Me.radWeek = New System.Windows.Forms.RadioButton
        Me.lblFormat = New System.Windows.Forms.Label
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.btnNext = New Tempestas.PictureBoxButton
        Me.imgNext = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New Tempestas.PictureBoxButton
        Me.lblError = New System.Windows.Forms.Label
        Me.pnlSystem.SuspendLayout()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSystem
        '
        Me.pnlSystem.BackColor = System.Drawing.Color.White
        Me.pnlSystem.Controls.Add(Me.radBoth)
        Me.pnlSystem.Controls.Add(Me.radTerm)
        Me.pnlSystem.Controls.Add(Me.radWeek)
        Me.pnlSystem.Controls.Add(Me.lblFormat)
        Me.pnlSystem.Location = New System.Drawing.Point(18, 47)
        Me.pnlSystem.Name = "pnlSystem"
        Me.pnlSystem.Size = New System.Drawing.Size(264, 86)
        Me.pnlSystem.TabIndex = 1
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Location = New System.Drawing.Point(62, 62)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(139, 17)
        Me.radBoth.TabIndex = 3
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "Week and Term System"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'radTerm
        '
        Me.radTerm.AutoSize = True
        Me.radTerm.Location = New System.Drawing.Point(62, 39)
        Me.radTerm.Name = "radTerm"
        Me.radTerm.Size = New System.Drawing.Size(86, 17)
        Me.radTerm.TabIndex = 2
        Me.radTerm.TabStop = True
        Me.radTerm.Text = "Term System"
        Me.radTerm.UseVisualStyleBackColor = True
        '
        'radWeek
        '
        Me.radWeek.AutoSize = True
        Me.radWeek.Location = New System.Drawing.Point(62, 16)
        Me.radWeek.Name = "radWeek"
        Me.radWeek.Size = New System.Drawing.Size(91, 17)
        Me.radWeek.TabIndex = 1
        Me.radWeek.TabStop = True
        Me.radWeek.Text = "Week System"
        Me.radWeek.UseVisualStyleBackColor = True
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(3, 0)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(198, 13)
        Me.lblFormat.TabIndex = 0
        Me.lblFormat.Text = "Please select the format of the timetable:"
        '
        'imgCancel
        '
        Me.imgCancel.ImageStream = CType(resources.GetObject("imgCancel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancel.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancel.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancel.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageList = Me.imgNext
        Me.btnNext.Location = New System.Drawing.Point(203, 162)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(79, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.TabStop = False
        '
        'imgNext
        '
        Me.imgNext.ImageStream = CType(resources.GetObject("imgNext.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgNext.TransparentColor = System.Drawing.Color.Lime
        Me.imgNext.Images.SetKeyName(0, "btnNextUp.png")
        Me.imgNext.Images.SetKeyName(1, "btnNextDown.png")
        Me.imgNext.Images.SetKeyName(2, "btnNextDisabled.png")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancel
        Me.btnCancel.Location = New System.Drawing.Point(18, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(90, 140)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(156, 13)
        Me.lblError.TabIndex = 10
        Me.lblError.Text = "Please select a timetable format"
        '
        'frmTimetableSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(300, 203)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlSystem)
        Me.HideTitleButtons = True
        Me.Name = "frmTimetableSystem"
        Me.Resizeable = False
        Me.ShowInTaskbar = False
        Me.Text = "Timetable System"
        Me.TitleText = "Timetable System"
        Me.Controls.SetChildIndex(Me.pnlSystem, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnNext, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.pnlSystem.ResumeLayout(False)
        Me.pnlSystem.PerformLayout()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSystem As System.Windows.Forms.Panel
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents radTerm As System.Windows.Forms.RadioButton
    Friend WithEvents radWeek As System.Windows.Forms.RadioButton
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents imgNext As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Public WithEvents btnNext As Tempestas.PictureBoxButton

End Class
