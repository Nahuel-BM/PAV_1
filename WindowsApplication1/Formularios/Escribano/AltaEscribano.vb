Public Class AltaEscribano

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Private Sub AltaEscribano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Carga.setTotalDeEventos(1)
        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.lbl_nombre.Text = ""
        Me.txt_documento.Text = ""
        Me.txt_matricula.Text = ""
        Me.cmd_crear.Enabled = False
        Me.cmd_nuevo.Enabled = False
        Me.txt_matricula.Enabled = False
        Me.cmd_buscar.Enabled = True
        Me.txt_documento.Focus()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click



    End Sub



    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
    End Sub
End Class