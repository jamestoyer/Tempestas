<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekEventView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.lblNotes = New System.Windows.Forms.Label
        Me.pnlMiddle = New System.Windows.Forms.Panel
        Me.lblRoom = New System.Windows.Forms.Label
        Me.lblStaff = New System.Windows.Forms.Label
        Me.lblModule = New System.Windows.Forms.Label
        Me.lblModuleCode = New System.Windows.Forms.Label
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.lblContact = New System.Windows.Forms.Label
        Me.pnlBottom.SuspendLayout()
        Me.pnlMiddle.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottom.Controls.Add(Me.lblNotes)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBottom.Location = New System.Drawing.Point(0, 81)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(90, 21)
        Me.pnlBottom.TabIndex = 5
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(0, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 1
        Me.lblNotes.Text = "Notes"
        '
        'pnlMiddle
        '
        Me.pnlMiddle.BackColor = System.Drawing.Color.Transparent
        Me.pnlMiddle.Controls.Add(Me.lblRoom)
        Me.pnlMiddle.Controls.Add(Me.lblStaff)
        Me.pnlMiddle.Controls.Add(Me.lblModule)
        Me.pnlMiddle.Controls.Add(Me.lblModuleCode)
        Me.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMiddle.Location = New System.Drawing.Point(0, 21)
        Me.pnlMiddle.Name = "pnlMiddle"
        Me.pnlMiddle.Size = New System.Drawing.Size(90, 60)
        Me.pnlMiddle.TabIndex = 4
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRoom.Location = New System.Drawing.Point(0, 39)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(35, 13)
        Me.lblRoom.TabIndex = 3
        Me.lblRoom.Text = "Room"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStaff.Location = New System.Drawing.Point(0, 26)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(29, 13)
        Me.lblStaff.TabIndex = 2
        Me.lblStaff.Text = "Staff"
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.BackColor = System.Drawing.Color.Transparent
        Me.lblModule.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblModule.Location = New System.Drawing.Point(0, 13)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(42, 13)
        Me.lblModule.TabIndex = 1
        Me.lblModule.Text = "Module"
        '
        'lblModuleCode
        '
        Me.lblModuleCode.AutoSize = True
        Me.lblModuleCode.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleCode.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblModuleCode.Location = New System.Drawing.Point(0, 0)
        Me.lblModuleCode.Name = "lblModuleCode"
        Me.lblModuleCode.Size = New System.Drawing.Size(70, 13)
        Me.lblModuleCode.TabIndex = 0
        Me.lblModuleCode.Text = "Module Code"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.lblContact)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(90, 21)
        Me.pnlTop.TabIndex = 3
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(0, 1)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(51, 13)
        Me.lblContact.TabIndex = 0
        Me.lblContact.Text = "Contact"
        '
        'WeekEventView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlMiddle)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "WeekEventView"
        Me.Size = New System.Drawing.Size(90, 102)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlMiddle.ResumeLayout(False)
        Me.pnlMiddle.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents pnlMiddle As System.Windows.Forms.Panel
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents lblModuleCode As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblContact As System.Windows.Forms.Label

End Class
