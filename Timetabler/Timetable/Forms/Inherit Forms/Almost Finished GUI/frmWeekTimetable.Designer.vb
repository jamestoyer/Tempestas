<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeekTimetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeekTimetable))
        Me.pnlPage2 = New System.Windows.Forms.Panel
        Me.lblPage2Error = New System.Windows.Forms.Label
        Me.btnCreate = New Tempestas.PictureBoxButton
        Me.imgCreate = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBack = New Tempestas.PictureBoxButton
        Me.imgBack = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPage2Cancel = New Tempestas.PictureBoxButton
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.imgNext = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlPage1 = New System.Windows.Forms.Panel
        Me.btnToPage2 = New Tempestas.PictureBoxButton
        Me.btnPage1Cancel = New Tempestas.PictureBoxButton
        Me.txtYears = New System.Windows.Forms.TextBox
        Me.lblPage1Error = New System.Windows.Forms.Label
        Me.txtTimetableName = New System.Windows.Forms.TextBox
        Me.lblYears = New System.Windows.Forms.Label
        Me.lblTimetableName = New System.Windows.Forms.Label
        Me.pnlPage2.SuspendLayout()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPage2Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPage1.SuspendLayout()
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPage1Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPage2
        '
        Me.pnlPage2.BackColor = System.Drawing.Color.White
        Me.pnlPage2.Controls.Add(Me.lblPage2Error)
        Me.pnlPage2.Controls.Add(Me.btnCreate)
        Me.pnlPage2.Controls.Add(Me.btnBack)
        Me.pnlPage2.Controls.Add(Me.btnPage2Cancel)
        Me.pnlPage2.Location = New System.Drawing.Point(33, 64)
        Me.pnlPage2.Name = "pnlPage2"
        Me.pnlPage2.Size = New System.Drawing.Size(477, 223)
        Me.pnlPage2.TabIndex = 4
        '
        'lblPage2Error
        '
        Me.lblPage2Error.AutoSize = True
        Me.lblPage2Error.ForeColor = System.Drawing.Color.Red
        Me.lblPage2Error.Location = New System.Drawing.Point(234, 173)
        Me.lblPage2Error.Name = "lblPage2Error"
        Me.lblPage2Error.Size = New System.Drawing.Size(29, 13)
        Me.lblPage2Error.TabIndex = 8
        Me.lblPage2Error.Text = "Error"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageList = Me.imgCreate
        Me.btnCreate.Location = New System.Drawing.Point(398, 200)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(79, 23)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.TabStop = False
        '
        'imgCreate
        '
        Me.imgCreate.ImageStream = CType(resources.GetObject("imgCreate.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCreate.TransparentColor = System.Drawing.Color.Lime
        Me.imgCreate.Images.SetKeyName(0, "btnCreateUp.png")
        Me.imgCreate.Images.SetKeyName(1, "btnCreateDown.png")
        Me.imgCreate.Images.SetKeyName(2, "btnCreateDisabled.png")
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageList = Me.imgBack
        Me.btnBack.Location = New System.Drawing.Point(313, 200)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(79, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.TabStop = False
        '
        'imgBack
        '
        Me.imgBack.ImageStream = CType(resources.GetObject("imgBack.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBack.TransparentColor = System.Drawing.Color.Lime
        Me.imgBack.Images.SetKeyName(0, "btnBackUp.png")
        Me.imgBack.Images.SetKeyName(1, "btnBackDown.png")
        Me.imgBack.Images.SetKeyName(2, "btnBackDisabled.png")
        '
        'btnPage2Cancel
        '
        Me.btnPage2Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage2Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btnPage2Cancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPage2Cancel.Image = CType(resources.GetObject("btnPage2Cancel.Image"), System.Drawing.Image)
        Me.btnPage2Cancel.ImageList = Me.imgCancel
        Me.btnPage2Cancel.Location = New System.Drawing.Point(228, 200)
        Me.btnPage2Cancel.Name = "btnPage2Cancel"
        Me.btnPage2Cancel.Size = New System.Drawing.Size(79, 23)
        Me.btnPage2Cancel.TabIndex = 8
        Me.btnPage2Cancel.TabStop = False
        '
        'imgCancel
        '
        Me.imgCancel.ImageStream = CType(resources.GetObject("imgCancel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancel.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancel.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(1, "btnCancelDown.png")
        Me.imgCancel.Images.SetKeyName(2, "btnCancelDisabled.png")
        '
        'imgNext
        '
        Me.imgNext.ImageStream = CType(resources.GetObject("imgNext.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgNext.TransparentColor = System.Drawing.Color.Lime
        Me.imgNext.Images.SetKeyName(0, "btnNextUp.png")
        Me.imgNext.Images.SetKeyName(1, "btnNextDown.png")
        Me.imgNext.Images.SetKeyName(2, "btnNextDisabled.png")
        '
        'pnlPage1
        '
        Me.pnlPage1.BackColor = System.Drawing.Color.Transparent
        Me.pnlPage1.Controls.Add(Me.btnToPage2)
        Me.pnlPage1.Controls.Add(Me.btnPage1Cancel)
        Me.pnlPage1.Controls.Add(Me.txtYears)
        Me.pnlPage1.Controls.Add(Me.lblPage1Error)
        Me.pnlPage1.Controls.Add(Me.txtTimetableName)
        Me.pnlPage1.Controls.Add(Me.lblYears)
        Me.pnlPage1.Controls.Add(Me.lblTimetableName)
        Me.pnlPage1.Location = New System.Drawing.Point(18, 47)
        Me.pnlPage1.Name = "pnlPage1"
        Me.pnlPage1.Size = New System.Drawing.Size(477, 223)
        Me.pnlPage1.TabIndex = 3
        '
        'btnToPage2
        '
        Me.btnToPage2.BackColor = System.Drawing.Color.Transparent
        Me.btnToPage2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnToPage2.Image = CType(resources.GetObject("btnToPage2.Image"), System.Drawing.Image)
        Me.btnToPage2.ImageList = Me.imgNext
        Me.btnToPage2.Location = New System.Drawing.Point(398, 200)
        Me.btnToPage2.Name = "btnToPage2"
        Me.btnToPage2.Size = New System.Drawing.Size(79, 23)
        Me.btnToPage2.TabIndex = 3
        Me.btnToPage2.TabStop = False
        '
        'btnPage1Cancel
        '
        Me.btnPage1Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPage1Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btnPage1Cancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPage1Cancel.Image = CType(resources.GetObject("btnPage1Cancel.Image"), System.Drawing.Image)
        Me.btnPage1Cancel.ImageList = Me.imgCancel
        Me.btnPage1Cancel.Location = New System.Drawing.Point(313, 200)
        Me.btnPage1Cancel.Name = "btnPage1Cancel"
        Me.btnPage1Cancel.Size = New System.Drawing.Size(79, 23)
        Me.btnPage1Cancel.TabIndex = 7
        Me.btnPage1Cancel.TabStop = False
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(227, 105)
        Me.txtYears.MaxLength = 2
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(29, 20)
        Me.txtYears.TabIndex = 3
        '
        'lblPage1Error
        '
        Me.lblPage1Error.AutoSize = True
        Me.lblPage1Error.ForeColor = System.Drawing.Color.Red
        Me.lblPage1Error.Location = New System.Drawing.Point(234, 141)
        Me.lblPage1Error.Name = "lblPage1Error"
        Me.lblPage1Error.Size = New System.Drawing.Size(29, 13)
        Me.lblPage1Error.TabIndex = 7
        Me.lblPage1Error.Text = "Error"
        '
        'txtTimetableName
        '
        Me.txtTimetableName.Location = New System.Drawing.Point(227, 79)
        Me.txtTimetableName.MaxLength = 50
        Me.txtTimetableName.Name = "txtTimetableName"
        Me.txtTimetableName.Size = New System.Drawing.Size(159, 20)
        Me.txtTimetableName.TabIndex = 1
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(135, 108)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(87, 13)
        Me.lblYears.TabIndex = 2
        Me.lblYears.Text = "Number of years:"
        '
        'lblTimetableName
        '
        Me.lblTimetableName.AutoSize = True
        Me.lblTimetableName.Location = New System.Drawing.Point(137, 82)
        Me.lblTimetableName.Name = "lblTimetableName"
        Me.lblTimetableName.Size = New System.Drawing.Size(85, 13)
        Me.lblTimetableName.TabIndex = 0
        Me.lblTimetableName.Text = "Timetable name:"
        '
        'frmWeekTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 288)
        Me.Controls.Add(Me.pnlPage1)
        Me.Controls.Add(Me.pnlPage2)
        Me.Name = "frmWeekTimetable"
        Me.Text = "Week Timetable"
        Me.TitleText = "Week Timetable"
        Me.Controls.SetChildIndex(Me.pnlPage2, 0)
        Me.Controls.SetChildIndex(Me.pnlPage1, 0)
        Me.pnlPage2.ResumeLayout(False)
        Me.pnlPage2.PerformLayout()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPage2Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPage1.ResumeLayout(False)
        Me.pnlPage1.PerformLayout()
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPage1Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPage2 As System.Windows.Forms.Panel
    Public WithEvents btnCreate As Tempestas.PictureBoxButton
    Friend WithEvents imgCreate As System.Windows.Forms.ImageList
    Friend WithEvents btnBack As Tempestas.PictureBoxButton
    Friend WithEvents imgBack As System.Windows.Forms.ImageList
    Friend WithEvents btnPage2Cancel As Tempestas.PictureBoxButton
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents imgNext As System.Windows.Forms.ImageList
    Friend WithEvents pnlPage1 As System.Windows.Forms.Panel
    Public WithEvents btnToPage2 As Tempestas.PictureBoxButton
    Friend WithEvents btnPage1Cancel As Tempestas.PictureBoxButton
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents lblPage1Error As System.Windows.Forms.Label
    Friend WithEvents txtTimetableName As System.Windows.Forms.TextBox
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblTimetableName As System.Windows.Forms.Label
    Friend WithEvents lblPage2Error As System.Windows.Forms.Label

End Class
