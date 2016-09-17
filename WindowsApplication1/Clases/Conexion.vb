Imports MySql.Data.MySqlClient

Public Class Conexion

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
        mysql
        sqlserver
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


    Public Function Consulta(ByVal sql As String) As DataTable
        Return Me.ejecutar(sql)
    End Function



    Public Function leoTabla() As DataTable
        Return ejecutar("SELECT * FROM " & Me.nombre_tabla & ";")
    End Function


    Public Function leoTabla(ByVal tabla As String) As DataTable
        Return ejecutar("SELECT * FROM " & tabla & ";")
    End Function



    Public Sub cargarComboTipo(ByRef combo As ComboBox, ByVal NombreTabla As String, Optional ByVal Opciones As String = "")
        Dim tabla As New Data.DataTable

        tabla = Me.ejecutar("SELECT * FROM " & NombreTabla & " " & Opciones)

        combo.DataSource = tabla
        combo.DisplayMember = "Nombre"
        combo.ValueMember = "id"
    End Sub



    Private Function ejecutar(ByVal sql As String) As DataTable

        Dim tabla As New DataTable

        Me.Conectar()
        Me.cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader())

        Me.Cerrar()

        Return tabla

    End Function


    Public Sub ejecutarInsert(ByVal sql)

        Try
            Me.Conectar()
            Me.cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Me.Cerrar()
        Catch ex As Exception
            MsgBox("Error al Ejecutar Insert " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)

            MsgBox(sql)

            Throw ex

        End Try

    End Sub


    Private Sub Conectar()
        Try

            Select Case Me.motor
                Case motores.mysql
                    Me.conexion = New MySqlConnection()
                    Me.cmd = New MySqlCommand()

                Case motores.sqlserver
                    Me.conexion = New OleDb.OleDbConnection()
                    Me.cmd = New OleDb.OleDbCommand()

            End Select

            Me.conexion.ConnectionString = Me.cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

        Catch ex As Exception
            MsgBox("Error al Crear Conexion " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Cerrar()
        Try
            Me.conexion.Close()
        Catch ex As Exception
            MsgBox("Error al Cerrar Conexion " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Function ultimoIdInsertado() As Integer
        Dim retorno As Integer
        Dim sql As String = "SELECT LAST_INSERT_ID() AS LASTID;"

        Dim tabla As New Data.DataTable
        tabla = Me.ejecutar(sql)
        retorno = Integer.Parse(tabla(0)("LASTID").ToString())

        Return retorno
    End Function


    'Fin de clase!


End Class
