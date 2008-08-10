<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBothTimetable
    Inherits Tempestas.frmBothTimetable

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewBothTimetable))
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToPage2
        '
        Me.btnToPage2.Image = CType(resources.GetObject("btnToPage2.Image"), System.Drawing.Image)
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        '
        'frmNewBothTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 293)
        Me.Name = "frmNewBothTimetable"
        Me.Text = "New Week and Term Timetable"
        Me.TitleText = "New Week and Term Timetable"
        CType(Me.btnToPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
