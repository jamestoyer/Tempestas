<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewContact
    Inherits Tempestas.frmContact

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewContact))
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Image = CType(resources.GetObject("btnAccept.Image"), System.Drawing.Image)
        '
        'imgAcceptButton
        '
        Me.imgAcceptButton.ImageStream = CType(resources.GetObject("imgAcceptButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAcceptButton.Images.SetKeyName(0, "btnAddUp.png")
        Me.imgAcceptButton.Images.SetKeyName(1, "btnAddDown.png")
        Me.imgAcceptButton.Images.SetKeyName(2, "btnAddDisabled.png")
        '
        'frmNewContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(300, 167)
        Me.Name = "frmNewContact"
        Me.Text = "New Contact"
        Me.TitleText = "New Contact"
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
