<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEvent
    Inherits Tempestas.frmEvent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewEvent))
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ImageStream = CType(resources.GetObject("imgAcceptButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAcceptButton.Images.SetKeyName(0, "btnAddUp.png")
        Me.imgAcceptButton.Images.SetKeyName(1, "btnAddDown.png")
        Me.imgAcceptButton.Images.SetKeyName(2, "btnAddDisabled.png")
        '
        'btnAccept
        '
        '
        'frmNewEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(438, 479)
        Me.Name = "frmNewEvent"
        Me.Text = "New Entry"
        Me.TitleText = "New Entry"
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
