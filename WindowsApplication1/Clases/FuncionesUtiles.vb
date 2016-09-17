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

    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function

    Public Function QuitarEspacios(ByVal cadena As String) As String
        Return LTrim(RTrim(cadena))
    End Function

    Public Function QuitarTodosLosEspacios(ByVal cadena As String) As String
        Return (QuitarEspacios(cadena)).Replace(" ", "")
    End Function

    Public Function ValidarComboBox(ByRef combo As ComboBox) As Boolean
        If combo.SelectedIndex = -1 Then
            combo.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ValidarTextBox(ByRef textBox As TextBox) As Boolean
        If Me.QuitarEspacios(textBox.Text) = "" Then
            textBox.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ValidarTextBox(ByRef textBox As MaskedTextBox) As Boolean
        If Me.QuitarEspacios(textBox.Text) = "" Then
            textBox.Focus()
            Return False
        End If
        Return True
    End Function


    Public Function RellenarConEspacios(ByVal cadena As String) As String
        Dim retorno As Double = Double.Parse(cadena)
        Dim fmt As String = "00000000000.00"
        Return retorno.ToString(fmt)
    End Function


End Class
