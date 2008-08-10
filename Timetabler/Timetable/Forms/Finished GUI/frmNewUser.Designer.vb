<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
    Inherits Tempestas.frmUser

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUser))
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        '
        'imgAccept
        '
        Me.imgAccept.ImageStream = CType(resources.GetObject("imgAccept.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAccept.Images.SetKeyName(0, "btnCreateUp.png")
        Me.imgAccept.Images.SetKeyName(1, "btnCreateDown.png")
        Me.imgAccept.Images.SetKeyName(2, "btnCreateDisabled.png")
        '
        'lblPasswordChecked
        '
        Me.lblPasswordChecked.Size = New System.Drawing.Size(81, 13)
        Me.lblPasswordChecked.Text = "Add Password?"
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(423, 256)
        Me.Name = "frmNewUser"
        Me.Text = "New User"
        Me.TitleText = "New User"
        Me.TopMost = True
        CType(Me.btnAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
