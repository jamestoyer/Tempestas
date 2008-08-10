Public Class frmUnableToConnect

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Load the find database form
        frmFindDatabase.ShowDialog()

        Me.Close()
    End Sub
End Class
