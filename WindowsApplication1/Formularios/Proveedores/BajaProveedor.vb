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
        Dim tabla As DataTable = Conexion.Consulta("SELECT CONCAT(`Domicilio`.`Calle`, ', ', `Domicilio`.`Numero`, ', ', `Localidad`.`Nombre`, ', ', `Provincia`.`Nombre`) AS `DomicilioCompleto`, `Proveedor`.`id`, `Proveedor`.`Nombre` FROM `Proveedor` JOIN `Domicilio` ON `Proveedor`.`Domicilio` = `Domicilio`.`id` JOIN `Localidad` ON `Localidad`.`id` = `Domicilio`.`Localidad` JOIN `Provincia` ON `Provincia`.`id` = `Localidad`.`Provincia` WHERE `Proveedor`.`Nombre` LIKE '%" & numero & "%';")

        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontro el Proveedor.")

        End If

        Dim recorrido As Integer = 0
        For recorrido = 0 To tabla.Rows.Count() - 1
            Me.DataGridView1.Rows.Add()

            Me.DataGridView1.Rows(recorrido).Cells("id").Value = tabla.Rows(recorrido)("id")
            Me.DataGridView1.Rows(recorrido).Cells("nombre").Value = tabla.Rows(recorrido)("Nombre")
            Me.DataGridView1.Rows(recorrido).Cells("domicilio").Value = tabla.Rows(recorrido)("DomicilioCompleto")

        Next

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub




    Private Sub EventoEliminarEscribano(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' elimino la fila
        If e.ColumnIndex = 3 And Me.DataGridView1.Rows.Count > 0 Then
            Dim result As Integer = 0
            If editar Then
                '   result = MessageBox.Show("¿Realmente desea Editar el Escribano?", "Alerta", MessageBoxButtons.OKCancel)
            Else
                result = MessageBox.Show("¿Realmente desea Eliminar el Proveedor?", "Alerta", MessageBoxButtons.OKCancel)
            End If

            If result = DialogResult.OK Then

                Dim Id_Escribano As Integer = Integer.Parse(Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)

                If editar Then
                    '    Dim frm As New AltaEscribano(Id_Escribano)
                    '     frm.Show()
                    '    Me.Close()
                Else

                    Me.Conexion.BorrarProveedor(Id_Escribano)

                    Me.DataGridView1.Rows.RemoveAt(e.RowIndex)
                End If


            End If
        End If
    End Sub
End Class