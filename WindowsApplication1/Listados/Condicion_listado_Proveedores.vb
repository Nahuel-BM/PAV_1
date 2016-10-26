Public Class Condicion_listado_Proveedores
   

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Listado_Proveedores.lbl_condProveedor.Text = Me.txt_condicionProveedor.Text
        Listado_Proveedores.Show()
        Me.Close()

    End Sub

    
End Class