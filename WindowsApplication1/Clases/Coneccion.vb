Imports MySql.Data.MySqlClient

Public Class Coneccion

    '1._ Cadena de conexion.
    '2._ Definicion de propiedades publicas.
    '3._ Creo objetos para la conexion.
    '4._ Configuro objetos.

    '5._ Ejecutar conexion
    '6._ Ejecutar sql
    '7._ Retener momentaneamente el resultado de la ejecucion del comando sql
    '8._ Devolver al exterior el resultado
    '9._ Cerrar conexion

    'Inicio de clase!

    Enum motores
        sqlserver
        mysql
    End Enum

    Dim cadena_conexion As String = ""
    Dim conexion As Object
    Dim cmd As Object
    Dim motor As motores = motores.sqlserver
    Dim nombre_tabla As String = ""



    Public Property _nombre_tabla As String
        Get
            Return Me.nombre_tabla
        End Get
        Set(ByVal value As String)
            Me.nombre_tabla = value
        End Set
    End Property

    Public Property _motor As motores
        Get
            Return motor
        End Get
        Set(ByVal value As motores)
            Me.motor = value
        End Set
    End Property

    Public Property _cadena_conexion As String
        Get
            Return cadena_conexion
        End Get
        Set(ByVal value As String)
            Me.cadena_conexion = value
        End Set
    End Property


    Public Sub New()

        Select Case Me.motor
            Case motores.sqlserver
                Me.conexion = New OleDb.OleDbConnection
                Me.cmd = New OleDb.OleDbCommand

            Case motores.mysql
                Me.conexion = New MySqlConnection
                Me.cmd = New MySqlCommand

        End Select

    End Sub



    Public Function Consulta(ByVal sql As String) As DataTable
        Return Me.ejecutar(sql)
    End Function



    Public Function leoTabla() As DataTable
        Return ejecutar("SELECT * FROM " & Me.nombre_tabla & ";")
    End Function


    Public Function leoTabla(ByVal tabla As String) As DataTable
        Return ejecutar("SELECT * FROM " & tabla & ";")
    End Function



    Private Function ejecutar(ByRef sql As String) As DataTable

        Dim tabla As New DataTable

        Me.Conectar()
        Me.cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader())

        Me.Cerrar()

        Return tabla

    End Function


    Private Sub Conectar()
        Me.conexion.ConnectionString = Me.cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

    End Sub

    Private Sub Cerrar()
        Me.conexion.Close()
    End Sub



    'Fin de clase!


End Class
