Module Constantes

    Public accesoSQL As New Conexion With {._motor = Conexion.motores.sqlserver _
          , ._cadena_conexion = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=_BD_PERSONAS_; PASSWORD=avisuales1"}



    Public accesoMySQL As New Conexion With {._motor = Conexion.motores.mysql, ._cadena_conexion = ConnectionString}

    Public ReadOnly HOST As String = "52.37.245.6"
    Public ReadOnly PORT As Integer = 3306
    Public ReadOnly USER As String = "PAV_1"
    Public ReadOnly PASS As String = "pass"
    Public ReadOnly DB_NAME As String = "PAV_1"

    ReadOnly ConnectionString As String = "server=" & HOST & ";" & "user id=" & USER & ";" & "password=" & PASS & ";" & "port=" & PORT & ";" & "database=" & DB_NAME & ";"


End Module
