Public Class Inicial


    Private Sub AltaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPropiedadToolStripMenuItem.Click
        Dim frm As New AltaPropiedad()
        frm.Show()
    End Sub

    Private Sub BajaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaPropiedadToolStripMenuItem.Click
        Dim frm As New BajaPropiedad()
        frm.Show()
    End Sub
End Class