<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewWeekTimetable
    Inherits Tempestas.frmWeekTimetable

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewWeekTimetable))
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        '
        'btnToPage2
        '
        Me.btnToPage2.Image = CType(resources.GetObject("btnToPage2.Image"), System.Drawing.Image)
        '
        'frmNewWeekTimetable
        '
        Me.AcceptButton = Me.btnToPage2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnPage1Cancel
        Me.ClientSize = New System.Drawing.Size(513, 288)
        Me.Name = "frmNewWeekTimetable"
        Me.Text = "New Week Timetable"
        Me.TitleText = "New Week Timetable"
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
