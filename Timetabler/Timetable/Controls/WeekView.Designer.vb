<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekView
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
        Me.lblDay = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(0, 0)
        Me.lblDay.MaximumSize = New System.Drawing.Size(18, 0)
        Me.lblDay.MinimumSize = New System.Drawing.Size(18, 117)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDay.Size = New System.Drawing.Size(18, 117)
        Me.lblDay.TabIndex = 0
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.MinimumSize = New System.Drawing.Size(18, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(18, 117)
        Me.Panel1.TabIndex = 1
        '
        'WeekView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "WeekView"
        Me.Size = New System.Drawing.Size(24, 123)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
