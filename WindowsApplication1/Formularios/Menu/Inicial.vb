Public Class Inicial


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

    Private Sub NuevaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New AltaPersona(False, 0)
        frm.Show()
    End Sub

    Private Sub BajaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaPersonaToolStripMenuItem.Click
        Dim frm As New BajaPersona(False)
        frm.Show()
    End Sub

    Private Sub ModificarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPersonaToolStripMenuItem.Click
        Dim frm As New BajaPersona(True)
        frm.Show()
    End Sub

    Private Sub AltaOperacionInmobiliariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaOperacionInmobiliariaToolStripMenuItem.Click
        Dim frm As New AltaOperacionInmobiliaria()
        frm.Show()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        Dim frm As New AltaProveedor()
        frm.Show()
    End Sub

    Private Sub BorrarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarProveedorToolStripMenuItem.Click
        Dim frm As New BajaProveedor()
        frm.Show()
    End Sub

    Private Sub AltaGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaGastoToolStripMenuItem.Click
        Dim frm As New AltaGastos()
        frm.Show()

    End Sub

    Private Sub BajaGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaGastoToolStripMenuItem.Click
        Dim frm As New BajaGastos()
        frm.Show()
    End Sub

    Private Sub ConsultarGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarGastoToolStripMenuItem.Click
        Dim frm As New ConsultarGastos()

        frm.Show()
    End Sub

    Private Sub ModificarGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarGastoToolStripMenuItem.Click
        Dim frm As New ModificarGastos()
        frm.Show()
    End Sub
End Class