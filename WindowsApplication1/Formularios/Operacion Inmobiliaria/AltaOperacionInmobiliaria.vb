Public Class AltaOperacionInmobiliaria

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    Private Sub AltaOperacionInmobiliaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_tipoPropiedad, "Tipo_Propiedad")
    End Sub

End Class