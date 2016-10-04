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

    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click



    End Sub



End Class