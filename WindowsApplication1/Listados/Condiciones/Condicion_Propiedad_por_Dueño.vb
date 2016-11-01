Public Class Condicion_Propiedad_por_Dueño

    Dim Funciones As New FuncionesUtiles
    Dim idPersonaBuscada As Integer = 1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Form_propiedades_por_dueño(idPersonaBuscada)

        'Me.Close()

        frm.Show()

        'Funciones.AbrirFormulario("Form_propiedades_por_dueño", frm)

    End Sub
End Class