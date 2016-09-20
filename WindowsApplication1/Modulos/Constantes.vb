Module Constantes

    
    Public ReadOnly HOST As String = "127.0.0.1"
    Public ReadOnly PORT As Integer = 3306
    Public ReadOnly USER As String = "root"
    Public ReadOnly PASS As String = ""
    Public ReadOnly DB_NAME As String = "pav_1"

    Public ReadOnly ConnectionString As String = "server=" & HOST & ";" & "user id=" & USER & ";" & "password=" & PASS & ";" & "port=" & PORT & ";" & "database=" & DB_NAME & ";"

    Public accesoSQL As New Conexion With {._motor = Conexion.motores.sqlserver _
         , ._cadena_conexion = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=_BD_PERSONAS_; PASSWORD=avisuales1"}

    Public accesoMySQL As New Conexion With {._motor = Conexion.motores.mysql, ._cadena_conexion = ConnectionString, ._nombre_tabla = ""}


End Module
