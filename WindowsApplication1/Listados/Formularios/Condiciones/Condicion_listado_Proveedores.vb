Public Class Condicion_listado_Proveedores
   
    Dim Conexion As Conexion = Constantes.accesoMySQL

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        'Listado_Proveedores.lbl_condProveedor.Text = Me.txt_condicionProveedor.Text
        Dim frm As New Listado_Proveedores(Me.cmb_provincia.SelectedValue)
        frm.Show()
        Me.Close()

    End Sub

    
    Private Sub Condicion_listado_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
    End Sub
End Class