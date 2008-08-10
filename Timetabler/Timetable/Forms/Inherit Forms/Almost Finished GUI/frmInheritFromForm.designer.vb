<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInheritFromForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInheritFromForm))
        Me.pnlHeaderBar = New System.Windows.Forms.Panel
        Me.imgMinimise = New System.Windows.Forms.ImageList(Me.components)
        Me.imgMaximise = New System.Windows.Forms.ImageList(Me.components)
        Me.imgCloseCross = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMinimise = New Tempestas.Button
        Me.btnMaximise = New Tempestas.Button
        Me.btnCloseCross = New Tempestas.Button
        Me.pnlHeaderBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeaderBar
        '
        Me.pnlHeaderBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeaderBar.BackColor = System.Drawing.Color.Lime
        Me.pnlHeaderBar.BackgroundImage = Global.Tempestas.My.Resources.resInheritFromFormImages.TitleBarCentre
        Me.pnlHeaderBar.Controls.Add(Me.btnMinimise)
        Me.pnlHeaderBar.Controls.Add(Me.btnMaximise)
        Me.pnlHeaderBar.Controls.Add(Me.btnCloseCross)
        Me.pnlHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderBar.Name = "pnlHeaderBar"
        Me.pnlHeaderBar.Size = New System.Drawing.Size(800, 29)
        Me.pnlHeaderBar.TabIndex = 0
        '
        'imgMinimise
        '
        Me.imgMinimise.ImageStream = CType(resources.GetObject("imgMinimise.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMinimise.TransparentColor = System.Drawing.Color.Lime
        Me.imgMinimise.Images.SetKeyName(0, "btnMinimiseUp.png")
        Me.imgMinimise.Images.SetKeyName(1, "btnMinimiseEnter.png")
        Me.imgMinimise.Images.SetKeyName(2, "btnMinimiseDown.png")
        '
        'imgMaximise
        '
        Me.imgMaximise.ImageStream = CType(resources.GetObject("imgMaximise.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMaximise.TransparentColor = System.Drawing.Color.Lime
        Me.imgMaximise.Images.SetKeyName(0, "btnMaximiseUp.png")
        Me.imgMaximise.Images.SetKeyName(1, "btnMaximiseEnter.png")
        Me.imgMaximise.Images.SetKeyName(2, "btnMaximiseDown.png")
        '
        'imgCloseCross
        '
        Me.imgCloseCross.ImageStream = CType(resources.GetObject("imgCloseCross.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCloseCross.TransparentColor = System.Drawing.Color.Lime
        Me.imgCloseCross.Images.SetKeyName(0, "btnCloseCrossUp.png")
        Me.imgCloseCross.Images.SetKeyName(1, "btnCloseCrossEnter.png")
        Me.imgCloseCross.Images.SetKeyName(2, "btnCloseCrossDown.png")
        '
        'btnMinimise
        '
        Me.btnMinimise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.BackgroundImage = CType(resources.GetObject("btnMinimise.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimise.ImageList = Me.imgMinimise
        Me.btnMinimise.Location = New System.Drawing.Point(720, 4)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimise.TabIndex = 0
        Me.btnMinimise.TabStop = False
        '
        'btnMaximise
        '
        Me.btnMaximise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximise.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximise.BackgroundImage = CType(resources.GetObject("btnMaximise.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximise.ImageList = Me.imgMaximise
        Me.btnMaximise.Location = New System.Drawing.Point(746, 4)
        Me.btnMaximise.Name = "btnMaximise"
        Me.btnMaximise.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximise.TabIndex = 1
        Me.btnMaximise.TabStop = False
        '
        'btnCloseCross
        '
        Me.btnCloseCross.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseCross.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseCross.BackgroundImage = CType(resources.GetObject("btnCloseCross.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseCross.ImageList = Me.imgCloseCross
        Me.btnCloseCross.Location = New System.Drawing.Point(772, 4)
        Me.btnCloseCross.Name = "btnCloseCross"
        Me.btnCloseCross.Size = New System.Drawing.Size(20, 20)
        Me.btnCloseCross.TabIndex = 2
        Me.btnCloseCross.TabStop = False
        '
        'frmInheritFromForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlHeaderBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 160)
        Me.Name = "frmInheritFromForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 44, 15, 15)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmInheritFromForm"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.pnlHeaderBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeaderBar As System.Windows.Forms.Panel
    Friend WithEvents imgCloseCross As System.Windows.Forms.ImageList
    Friend WithEvents imgMaximise As System.Windows.Forms.ImageList
    Friend WithEvents imgMinimise As System.Windows.Forms.ImageList
    Friend WithEvents btnCloseCross As Tempestas.Button
    Friend WithEvents btnMaximise As Tempestas.Button
    Friend WithEvents btnMinimise As Tempestas.Button
End Class
