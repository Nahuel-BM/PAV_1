Public Class Inicial

    Dim Funciones As New FuncionesUtiles

    Private Sub AltaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPropiedadToolStripMenuItem.Click
        Dim frm As New AltaPropiedad()
        Funciones.AbrirFormulario("AltaPropiedad", frm)
    End Sub

    Private Sub BajaPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaPropiedadToolStripMenuItem.Click
        Dim frm As New BuscarPropiedad()
        Funciones.AbrirFormulario("BuscarPropiedad", frm)
    End Sub

    Private Sub MdoficarPropiedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MdoficarPropiedadToolStripMenuItem.Click
        Dim frm As New BuscarPropiedad(True)
        Funciones.AbrirFormulario("BuscarPropiedad", frm)
    End Sub

    Private Sub NuevaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New AltaPersona(False, 0)
        Funciones.AbrirFormulario("AltaPersona", frm)
    End Sub

    Private Sub BajaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaPersonaToolStripMenuItem.Click
        Dim frm As New BajaPersona(False)
        Funciones.AbrirFormulario("BajaPersona", frm)
    End Sub

    Private Sub ModificarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPersonaToolStripMenuItem.Click
        Dim frm As New BajaPersona(True)
        Funciones.AbrirFormulario("BajaPersona", frm)
    End Sub

    Private Sub AltaOperacionInmobiliariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaOperacionInmobiliariaToolStripMenuItem.Click
        Dim frm As New AltaOperacionInmobiliaria()
        Funciones.AbrirFormulario("AltaOperacionInmobiliaria", frm)
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        Dim frm As New AltaProveedor()
        Funciones.AbrirFormulario("AltaProveedor", frm)
    End Sub

    Private Sub BorrarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarProveedorToolStripMenuItem.Click
        Dim frm As New BajaProveedor()
        Funciones.AbrirFormulario("BajaProveedor", frm)
    End Sub

    Private Sub AltaGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaGastoToolStripMenuItem.Click
        Dim frm As New AltaGastos()
        Funciones.AbrirFormulario("AltaGastos", frm)
    End Sub

    Private Sub BajaGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaGastoToolStripMenuItem.Click
        Dim frm As New BajaGastos()
        Funciones.AbrirFormulario("BajaGastos", frm)
    End Sub

    Private Sub ConsultarGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarGastoToolStripMenuItem.Click
        Dim frm As New ConsultarGastos()
        Funciones.AbrirFormulario("ConsultarGastos", frm)
    End Sub

    Private Sub ModificarGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarGastoToolStripMenuItem.Click
        Dim frm As New ModificarGastos()
        Funciones.AbrirFormulario("ModificarGastos", frm)
    End Sub

    Private Sub AltaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPersonaToolStripMenuItem.Click
        Dim frm As New AltaPersona(False, 0)
        Funciones.AbrirFormulario("AltaPersona", frm)
    End Sub

    Private Sub NuevoEscribanoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoEscribanoToolStripMenuItem.Click
        Dim frm As New AltaEscribano()
        Funciones.AbrirFormulario("AltaEscribano", frm)
    End Sub

    Private Sub EditarEscribanoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEscribanoToolStripMenuItem.Click
        Dim frm As New BuscarEscribano(True)
        Funciones.AbrirFormulario("BuscarEscribano", frm)
    End Sub

    Private Sub BorrarEscribanoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarEscribanoToolStripMenuItem.Click
        Dim frm As New BuscarEscribano(False)
        Funciones.AbrirFormulario("BuscarEscribano", frm)
    End Sub

    Private Sub ListarDueñosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarDueñosToolStripMenuItem1.Click
        Dim frm As New Listado_Dueños()
        Funciones.AbrirFormulario("Listado_Dueños", frm)
    End Sub

    Private Sub ListarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProveedoresToolStripMenuItem.Click
        Dim frm As New Condicion_listado_Proveedores()
        Funciones.AbrirFormulario("Condicion_listado_Proveedores", frm)
    End Sub

    Private Sub ListarOperacionesInmobiliariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarOperacionesInmobiliariasToolStripMenuItem.Click
        Dim frm As New Condicion_listado_operacionInmobiliaria()
        Funciones.AbrirFormulario("Condicion_listado_operacionInmobiliaria", frm)
    End Sub

    Private Sub ListarPropiedadesPorLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPropiedadesPorLocalidadToolStripMenuItem.Click

    End Sub

    Private Sub ListarPropiedadesPorDueñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPropiedadesPorDueñoToolStripMenuItem.Click
        Dim frm As New Condicion_Propiedad_por_Dueño()
        Funciones.AbrirFormulario("Condicion_Propiedad_por_Dueño", frm)
    End Sub

    Private Sub Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

<<<<<<< Updated upstream
    Private Sub EstadisticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem1.Click
        Dim frm As New Estadisticas()
        Funciones.AbrirFormulario("Estadisticas", frm)
=======
    Private Sub ListarInteresadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarInteresadosToolStripMenuItem.Click
        Dim frm As New Interesados()

        Funciones.AbrirFormulario("Interesados", frm)
>>>>>>> Stashed changes
    End Sub
End Class