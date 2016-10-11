Public Class BuscarEscribano

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim EsEdicion As Boolean = False


    Public Sub New(ByVal EsEdicion As Boolean)

        InitializeComponent()

        Me.EsEdicion = EsEdicion
    End Sub


    Private Sub BuscarEscribano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsEdicion Then
            Me.Text = "Editar Escribano"
            Funciones.AddButtonColumn(Me.grid_busqueda, "Editar", "Accion", 3)
        Else
            Me.Text = "Borrar Escribano"
            Funciones.AddButtonColumn(Me.grid_busqueda, "Borrar", "Accion", 3)
        End If

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        Dim valido As Boolean = Me.Funciones.ValidarTextBox(Me.txt_Matricula)

        If valido Then
            'Bucar en db..
            Try
                Dim sql As String = "SELECT `Escribanos`.`id` AS `ID`, CONCAT(`Persona`.`Apellido`, ', ', `Persona`.`Nombre`, '(', `Escribanos`.`Matricula` ,')' ) AS `Nombre` FROM `Escribanos` JOIN `Persona` ON `Persona`.`id` = `Escribanos`.`Persona` WHERE `Escribanos`.`Matricula` LIKE '%" & Me.txt_Matricula.Text & "%';"

                Dim Tabla As DataTable = Conexion.Consulta(sql)

                Dim variableTemporal As Integer = 0

                For Each elemento As DataRow In Tabla.Rows
                    Me.grid_busqueda.Rows.Add()

                    Me.grid_busqueda.Rows(variableTemporal).Cells("id").Value = elemento("ID")
                    Me.grid_busqueda.Rows(variableTemporal).Cells("Nombre").Value = elemento("Nombre")

                    variableTemporal += 1
                Next



            Catch ex As Exception

            End Try



        Else
            MsgBox("Datos invalidos.")
            Me.txt_Matricula.Focus()
        End If


    End Sub



    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub


    Private Sub EventoEliminarEscribano(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_busqueda.CellClick
        ' elimino la fila
        If e.ColumnIndex = 2 Then
            Dim result As Integer = 0
            If EsEdicion Then
                result = MessageBox.Show("¿Realmente desea Editar el Escribano?", "Alerta", MessageBoxButtons.OKCancel)
            Else
                result = MessageBox.Show("¿Realmente desea Eliminar el Escribano?", "Alerta", MessageBoxButtons.OKCancel)
            End If

            If result = DialogResult.OK Then

                Dim Id_Escribano As Integer = Integer.Parse(Me.grid_busqueda.Rows(e.RowIndex).Cells(0).Value.ToString)

                If EsEdicion Then
                    Dim frm As New AltaEscribano(Id_Escribano)
                    frm.Show()
                    Me.Close()
                Else
                    Me.BorrarEscribano(Id_Escribano)
                    Me.grid_busqueda.Rows.RemoveAt(e.RowIndex)
                End If


            End If
        End If
    End Sub


    Private Sub BorrarEscribano(ByVal id As Integer)
        Me.Conexion.BorrarEscribano(id)
        MsgBox("Borrado Correcto.")
    End Sub

End Class