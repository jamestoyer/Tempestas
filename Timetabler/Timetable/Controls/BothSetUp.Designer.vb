<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BothSetUp
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
        Me.dtpFinishDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblLength = New System.Windows.Forms.Label
        Me.lblFinishDate = New System.Windows.Forms.Label
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.txtLength = New System.Windows.Forms.TextBox
        Me.lblTerm = New System.Windows.Forms.Label
        Me.lblStartWeek = New System.Windows.Forms.Label
        Me.lblFinishWeek = New System.Windows.Forms.Label
        Me.txtStartWeek = New System.Windows.Forms.TextBox
        Me.txtFinishWeek = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'dtpFinishDate
        '
        Me.dtpFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinishDate.Location = New System.Drawing.Point(227, 21)
        Me.dtpFinishDate.Name = "dtpFinishDate"
        Me.dtpFinishDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpFinishDate.TabIndex = 11
        Me.dtpFinishDate.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(64, 21)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpStartDate.TabIndex = 9
        Me.dtpStartDate.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(321, 25)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(86, 13)
        Me.lblLength.TabIndex = 12
        Me.lblLength.Text = "Length (Weeks):"
        '
        'lblFinishDate
        '
        Me.lblFinishDate.AutoSize = True
        Me.lblFinishDate.Location = New System.Drawing.Point(158, 25)
        Me.lblFinishDate.Name = "lblFinishDate"
        Me.lblFinishDate.Size = New System.Drawing.Size(63, 13)
        Me.lblFinishDate.TabIndex = 10
        Me.lblFinishDate.Text = "Finish Date:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(0, 25)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 8
        Me.lblStartDate.Text = "Start Date:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(413, 22)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(43, 20)
        Me.txtLength.TabIndex = 13
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTerm.Location = New System.Drawing.Point(0, 0)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(57, 16)
        Me.lblTerm.TabIndex = 7
        Me.lblTerm.Text = "Term X"
        '
        'lblStartWeek
        '
        Me.lblStartWeek.AutoSize = True
        Me.lblStartWeek.Location = New System.Drawing.Point(0, 49)
        Me.lblStartWeek.Name = "lblStartWeek"
        Me.lblStartWeek.Size = New System.Drawing.Size(64, 13)
        Me.lblStartWeek.TabIndex = 14
        Me.lblStartWeek.Text = "Start Week:"
        '
        'lblFinishWeek
        '
        Me.lblFinishWeek.AutoSize = True
        Me.lblFinishWeek.Location = New System.Drawing.Point(158, 50)
        Me.lblFinishWeek.Name = "lblFinishWeek"
        Me.lblFinishWeek.Size = New System.Drawing.Size(69, 13)
        Me.lblFinishWeek.TabIndex = 15
        Me.lblFinishWeek.Text = "Finish Week:"
        '
        'txtStartWeek
        '
        Me.txtStartWeek.Location = New System.Drawing.Point(64, 47)
        Me.txtStartWeek.Name = "txtStartWeek"
        Me.txtStartWeek.Size = New System.Drawing.Size(45, 20)
        Me.txtStartWeek.TabIndex = 16
        Me.txtStartWeek.Text = "1"
        '
        'txtFinishWeek
        '
        Me.txtFinishWeek.Location = New System.Drawing.Point(227, 47)
        Me.txtFinishWeek.Name = "txtFinishWeek"
        Me.txtFinishWeek.Size = New System.Drawing.Size(45, 20)
        Me.txtFinishWeek.TabIndex = 17
        Me.txtFinishWeek.Text = "1"
        '
        'BothSetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtFinishWeek)
        Me.Controls.Add(Me.txtStartWeek)
        Me.Controls.Add(Me.lblFinishWeek)
        Me.Controls.Add(Me.lblStartWeek)
        Me.Controls.Add(Me.dtpFinishDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblFinishDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblTerm)
        Me.Name = "BothSetUp"
        Me.Size = New System.Drawing.Size(456, 75)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFinishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblFinishDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents lblStartWeek As System.Windows.Forms.Label
    Friend WithEvents lblFinishWeek As System.Windows.Forms.Label
    Friend WithEvents txtStartWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishWeek As System.Windows.Forms.TextBox

End Class
