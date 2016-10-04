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


    Public Function GetFormByName(formName As String) As Form

        If (formName = String.Empty) Then Return Nothing

        For Each frm As Form In Application.OpenForms

            If (frm.Name.ToUpperInvariant() = formName.ToUpperInvariant()) Then
                ' Devolvemos la referencia del formulario.
                '
                Return frm
            End If

        Next

        ' No está abierto el formulario especificado
        '
        Return Nothing

    End Function

    'Ahora, cuando desees saber si el formulario llamado 'frmClientes' está abierto, llamarías a la función de la siguiente manera:
    Public Sub AbrirFormulario(ByVal nombreFormulario As String, ByVal claseForm As Form)
        'Try
        '    Dim frm2 As Form = GetFormByName("Loading")
        '    frm2.Close()
        'Catch ex As Exception

        'End Try


        If Application.OpenForms.Count < 2 Then

            Dim frm As Form = GetFormByName(nombreFormulario)

            If (frm Is Nothing) Then
                frm = claseForm
                ' Mostramos el formulario
                frm.Show()
            Else
                ' Seleccionamos el formulario abierto
                frm.Select()
            End If

            'Else

            '    For dime As Integer = 0 To Application.OpenForms.Count - 1
            '        MsgBox("Cantidad de forms abiertos : " & Application.OpenForms.Count & "    " & Application.OpenForms.Item(dime).Name)

            '    Next


            
        End If

    End Sub

End Class
