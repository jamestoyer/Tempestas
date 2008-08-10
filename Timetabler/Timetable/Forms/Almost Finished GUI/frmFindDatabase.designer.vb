<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindDatabase))
        Me.lblLocation = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.imgBrowse = New System.Windows.Forms.ImageList(Me.components)
        Me.imgAdd = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCancel = New System.Windows.Forms.ImageList(Me.components)
        Me.lblError = New System.Windows.Forms.Label
        Me.ofdLocation = New System.Windows.Forms.OpenFileDialog
        Me.btnAdd = New Tempestas.PictureBoxButton
        Me.btnBrowse = New Tempestas.PictureBoxButton
        Me.btnCancel = New Tempestas.PictureBoxButton
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Location = New System.Drawing.Point(18, 50)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(100, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Timetable Location:"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Location = New System.Drawing.Point(124, 47)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(140, 20)
        Me.txtLocation.TabIndex = 4
        '
        'imgBrowse
        '
        Me.imgBrowse.ImageStream = CType(resources.GetObject("imgBrowse.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBrowse.TransparentColor = System.Drawing.Color.Lime
        Me.imgBrowse.Images.SetKeyName(0, "btnBrowseUp.png")
        Me.imgBrowse.Images.SetKeyName(1, "btnBrowseUp.png")
        Me.imgBrowse.Images.SetKeyName(2, "btnBrowseDown.png")
        Me.imgBrowse.Images.SetKeyName(3, "btnBrowseDisabled.png")
        '
        'imgAdd
        '
        Me.imgAdd.ImageStream = CType(resources.GetObject("imgAdd.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAdd.TransparentColor = System.Drawing.Color.Lime
        Me.imgAdd.Images.SetKeyName(0, "btnAddUp.png")
        Me.imgAdd.Images.SetKeyName(1, "btnAddUp.png")
        Me.imgAdd.Images.SetKeyName(2, "btnAddDown.png")
        Me.imgAdd.Images.SetKeyName(3, "btnAddDisabled.png")
        '
        'imgCancel
        '
        Me.imgCancel.ImageStream = CType(resources.GetObject("imgCancel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCancel.TransparentColor = System.Drawing.Color.Lime
        Me.imgCancel.Images.SetKeyName(0, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(1, "btnCancelUp.png")
        Me.imgCancel.Images.SetKeyName(2, "btnCancelDown.png")
        Me.imgCancel.Images.SetKeyName(3, "btnCancelDisabled.png")
        '
        'lblError
        '
        Me.lblError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(121, 79)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(131, 13)
        Me.lblError.TabIndex = 8
        Me.lblError.Text = "Please enter a file location"
        '
        'ofdLocation
        '
        Me.ofdLocation.Filter = "SQL Server Database (*.mdf)|*.mdf"
        Me.ofdLocation.Title = "Find Timetable"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageList = Me.imgAdd
        Me.btnAdd.Location = New System.Drawing.Point(270, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageList = Me.imgBrowse
        Me.btnBrowse.Location = New System.Drawing.Point(270, 44)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(79, 23)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageList = Me.imgCancel
        Me.btnCancel.Location = New System.Drawing.Point(185, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.TabStop = False
        '
        'frmFindDatabase
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(367, 160)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.HideTitleButtons = True
        Me.Name = "frmFindDatabase"
        Me.Resizeable = False
        Me.Text = "Find Timetable"
        Me.TitleText = "Find Timetable"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.lblLocation, 0)
        Me.Controls.SetChildIndex(Me.txtLocation, 0)
        Me.Controls.SetChildIndex(Me.lblError, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnBrowse, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents imgBrowse As System.Windows.Forms.ImageList
    Friend WithEvents imgAdd As System.Windows.Forms.ImageList
    Friend WithEvents imgCancel As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents ofdLocation As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAdd As Tempestas.PictureBoxButton
    Friend WithEvents btnBrowse As Tempestas.PictureBoxButton
    Friend WithEvents btnCancel As Tempestas.PictureBoxButton

End Class
