Public Class BajaProveedor

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim editar As Boolean = False

    Private Sub BajaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editar = True Then
            Funciones.AddButtonColumn(Me.DataGridView1, "Editar", "Acción", 3)
        Else
            Funciones.AddButtonColumn(Me.DataGridView1, "Eliminar", "Acción", 3)
        End If

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Me.DataGridView1.Rows.Clear()

        Dim numero As String = Funciones.QuitarTodosLosEspacios(Me.txt_nroproveedor.Text)
        Dim tabla As DataTable = Conexion.Consulta("SELECT `Domicilio`.`Nombre`, `Proveedor`.`id`, `Proveedor`.`Nombre` FROM `Proveedor` JOIN `Domicilio` ON `Proveedor`.`Domicilio` = `Domicilio`.`id` WHERE `Proveedor`.`id` = " & numero & ";")

        Dim recorrido As Integer = 0
        For recorrido = 0 To tabla.Rows.Count() - 1
            Me.DataGridView1.Rows.Add()

            Me.DataGridView1.Rows(recorrido).Cells("id").Value = tabla.Rows(recorrido)("id")
            Me.DataGridView1.Rows(recorrido).Cells("nombre").Value = tabla.Rows(recorrido)("Nombre")
            Me.DataGridView1.Rows(recorrido).Cells("domicilio").Value = tabla.Rows(recorrido)("Domicilio")

        Next

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class