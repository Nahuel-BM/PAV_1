﻿Public Class Inicial


    Private Sub AltaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPropiedadToolStripMenuItem.Click
        Dim frm As New AltaPropiedad()
        frm.Show()
    End Sub

    Private Sub BajaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaPropiedadToolStripMenuItem.Click
        Dim frm As New BuscarPropiedad()
        frm.Show()
    End Sub

    Private Sub MdoficarPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MdoficarPropiedadToolStripMenuItem.Click
        Dim frm As New BuscarPropiedad(True)
        frm.Show()
    End Sub
End Class