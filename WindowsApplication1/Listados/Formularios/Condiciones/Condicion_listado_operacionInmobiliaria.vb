Public Class Condicion_listado_operacionInmobiliaria

    
    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        Listado_OperacionesInmobiliarias.lbl_monto.Text = Me.txt_condicionMonto.Text
        Listado_OperacionesInmobiliarias.lbl_comision.Text = Me.txt_Comision.Text
        Listado_OperacionesInmobiliarias.Show()
        Me.Close()
    End Sub
End Class