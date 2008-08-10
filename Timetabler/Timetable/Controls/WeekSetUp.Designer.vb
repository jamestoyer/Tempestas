<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekSetUp
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
        Me.lblYear = New System.Windows.Forms.Label
        Me.txtYearName = New System.Windows.Forms.TextBox
        Me.lblYearName = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.lblLength = New System.Windows.Forms.Label
        Me.txtLength = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblYear.Location = New System.Drawing.Point(0, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(54, 16)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year X"
        '
        'txtYearName
        '
        Me.txtYearName.Location = New System.Drawing.Point(69, 22)
        Me.txtYearName.MaxLength = 30
        Me.txtYearName.Name = "txtYearName"
        Me.txtYearName.Size = New System.Drawing.Size(88, 20)
        Me.txtYearName.TabIndex = 1
        '
        'lblYearName
        '
        Me.lblYearName.AutoSize = True
        Me.lblYearName.Location = New System.Drawing.Point(0, 25)
        Me.lblYearName.Name = "lblYearName"
        Me.lblYearName.Size = New System.Drawing.Size(63, 13)
        Me.lblYearName.TabIndex = 2
        Me.lblYearName.Text = "Year Name:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(227, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpStartDate.TabIndex = 4
        Me.dtpStartDate.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(163, 25)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 3
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(321, 25)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(86, 13)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "Length (Weeks):"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(413, 22)
        Me.txtLength.MaxLength = 4
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(43, 20)
        Me.txtLength.TabIndex = 8
        Me.txtLength.Text = "0"
        '
        'WeekSetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblYearName)
        Me.Controls.Add(Me.txtYearName)
        Me.Controls.Add(Me.lblYear)
        Me.Name = "WeekSetUp"
        Me.Size = New System.Drawing.Size(456, 49)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYearName As System.Windows.Forms.TextBox
    Friend WithEvents lblYearName As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox

End Class
