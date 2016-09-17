Public Class FuncionesUtiles



    Public Sub AddButtonColumn(ByRef grid As DataGridView, ByVal Texto As String, ByVal Cabecera As String, Optional ByRef posicion As Integer = 0)
        Dim buttons As New DataGridViewButtonColumn()
        With buttons
            .HeaderText = Cabecera
            .Text = Texto
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 0
        End With

        buttons.DisplayIndex = posicion

        grid.Columns.Add(buttons)

    End Sub


End Class
