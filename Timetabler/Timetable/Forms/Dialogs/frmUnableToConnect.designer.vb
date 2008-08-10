<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnableToConnect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnableToConnect))
        Me.btnOk = New Tempestas.PictureBoxButton
        Me.imgOk = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageList = Me.imgOk
        Me.btnOk.Location = New System.Drawing.Point(110, 97)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(79, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.TabStop = False
        '
        'imgOk
        '
        Me.imgOk.ImageStream = CType(resources.GetObject("imgOk.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgOk.TransparentColor = System.Drawing.Color.Lime
        Me.imgOk.Images.SetKeyName(0, "btnOKUp.png")
        Me.imgOk.Images.SetKeyName(1, "btnOKDown.png")
        Me.imgOk.Images.SetKeyName(2, "btnOKDisabled.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Caprica has been unable to load the timetable file"
        '
        'frmUnableToConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(300, 138)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.HideTitleButtons = True
        Me.MinimumSize = New System.Drawing.Size(300, 100)
        Me.Name = "frmUnableToConnect"
        Me.Resizeable = False
        Me.Text = "File Error"
        Me.TitleText = "File Error"
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As Tempestas.PictureBoxButton
    Friend WithEvents imgOk As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
