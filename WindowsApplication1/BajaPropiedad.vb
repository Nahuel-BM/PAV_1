Imports MySql.Data.MySqlClient

Public Class BajaPropiedad

    ReadOnly Servidor As String = "52.37.245.6"
    ReadOnly Usuario As String = "PAV_1"
    ReadOnly Password As String = "pass"
    ReadOnly BaseDatos As String = "PAV_1"
    ReadOnly Puerto As Integer = 3306

    Friend conexion As MySqlConnection

    ReadOnly ConnectionString As String = "server=" & Servidor & ";" & "user id=" & Usuario & ";" & "password=" & Password & ";" & "port=" & Puerto & ";" & "database=" & BaseDatos & ";"

    Private Sub BajaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Buscar_Inmueble_Por_Designacion_Catastral(sender As Object, e As EventArgs) Handles Button1.Click

        Dim TrimString As String = LTrim(RTrim(Me.MaskedTextBox1.Text))

        Dim sqlConsulta As String = "SELECT  `Domicilio`.`id` AS `ID_DOMICILIO`, `Inmueble`.`id` AS `ID_INMUEBLE` , `Propiedad`.`id` AS `ID_PROPIEDAD`, `Domicilio`.`Calle`, `Domicilio`.`Numero` , `Localidad`.`Nombre` AS `Localidad` , `Provincia`.`Nombre` AS `Provincia`, `Inmueble`.`Designacion_Catastral` FROM  `Propiedad` LEFT JOIN  `Inmueble` ON  `Propiedad`.`Id_Inmueble` =  `Inmueble`.`id` LEFT JOIN `Domicilio` ON `Inmueble`.`Domicilio` = `Domicilio`.`id`  LEFT JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` LEFT JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE  `Inmueble`.`Designacion_Catastral` LIKE  '%" & TrimString & "%' ;"

        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = Me.ConnectionString
            conexion.Open()

            Dim adapter As New MySqlDataAdapter
            Dim tabla As New Data.DataTable

            Dim cmd As New MySqlCommand
            cmd.Connection = conexion
            cmd.CommandText = sqlConsulta

            'cmd.Parameters.Add(New MySqlParameter("parametro", Me.MaskedTextBox1.Text))

            adapter.SelectCommand = cmd



            'conexion.Open()
            tabla.Load(cmd.ExecuteReader())
            conexion.Close()

            Me.grid_grilla.Rows.Clear()


            Dim recorrido As Integer = 0
            For recorrido = 0 To tabla.Rows.Count() - 1
                Me.grid_grilla.Rows.Add()
                Me.grid_grilla.Rows(recorrido).Cells("ID_DOMICILIO").Value = tabla.Rows(recorrido)("ID_DOMICILIO")
                Me.grid_grilla.Rows(recorrido).Cells("ID_INMUEBLE").Value = tabla.Rows(recorrido)("ID_INMUEBLE")
                Me.grid_grilla.Rows(recorrido).Cells("ID_PROPIEDAD").Value = tabla.Rows(recorrido)("ID_PROPIEDAD")
                Me.grid_grilla.Rows(recorrido).Cells("Domicilio").Value = tabla.Rows(recorrido)("Calle") & " " & tabla.Rows(recorrido)("Numero") & ", " & tabla.Rows(recorrido)("Localidad") & ", " & tabla.Rows(recorrido)("Provincia") & "."

                Me.grid_grilla.Rows(recorrido).Cells("designacion").Value = tabla.Rows(recorrido)("Designacion_Catastral")
                'designacion

            Next

        Catch ex As Exception
            MsgBox("Error al conectar al servidor MySQL " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try


    End Sub


End Class