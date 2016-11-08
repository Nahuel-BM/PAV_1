Public Class Interesados
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Interesados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        Dim tabla As New DataTable
        Dim sql As String = "select * from interesados p inner join persona on persona.id = p.interesado inner join propiedad on propiedad.id= p.propiedad where propiedad.id = " & MaskedTextBox1.Text

        MsgBox(sql)

        tabla = Conexion.Consulta(sql)
        InteresadosBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MaskedTextBox1.Text = "" Then
            Me.ReportViewer1.RefreshReport()
        Else
            impresion()
        End If
    End Sub
End Class