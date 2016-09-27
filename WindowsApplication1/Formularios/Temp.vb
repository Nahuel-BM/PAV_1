Public Class Temp

    Dim CadenaConexion As String = ""
    Dim Conexio As OleDb.OleDbConnection
    Dim comando As OleDb.OleDbCommand


    Private Sub Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexio.ConnectionString = Me.CadenaConexion

        Conexio.Open()

        Dim tabla As New DataTable

        comando.Connection = Conexio

        comando.CommandType = CommandType.Text
        comando.CommandText = "SQL"

        tabla.Load(comando.ExecuteReader())

        Conexio.Close()





    End Sub

End Class