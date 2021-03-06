﻿Imports MySql.Data.MySqlClient



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



    'Public Property _nombre_tabla As String
    '    Get
    '        Return Me.nombre_tabla
    '    End Get
    '    Set(ByVal value As String)
    '        Me.nombre_tabla = value
    '    End Set
    'End Property

    'Public Property _motor As motores
    '    Get
    '        Return motor
    '    End Get
    '    Set(ByVal value As motores)
    '        Me.motor = value
    '    End Set
    'End Property

    'Public Property _cadena_conexion As String
    '    Get
    '        Return cadena_conexion
    '    End Get
    '    Set(ByVal value As String)
    '        Me.cadena_conexion = value
    '    End Set
    'End Property


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
        Try
            Me.Conectar()
            Me.cmd.CommandText = sql

            tabla.Load(cmd.ExecuteReader())

            Me.Cerrar()

        Catch ex As Exception

        End Try

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

            Throw

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

            Dim Msg As MsgBoxResult
            Msg = MsgBox("Cerrar el programa, ¿Desea salir?", vbYesNo, "Salir del Programa")
            If Msg = MsgBoxResult.Yes Then
                Application.Exit()
            End If

        Finally

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


    'Domicilio

    Public Function CrearDomicilio(ByVal NombreCalle As String, ByVal NumeroCalle As Integer, ByVal Localidad As Integer) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Domicilio`(`Calle`, `Numero`, `Localidad`) VALUES ('" & NombreCalle & "', " & NumeroCalle & "," & Localidad & ");"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarDomicilio(ByVal idDomicilio As Integer, ByVal NombreCalle As String, ByVal NumeroCalle As Integer, ByVal Localidad As Integer)
        Dim sqlDomicilio As String = "UPDATE `Domicilio` SET `Calle`='" & NombreCalle & "',`Numero`= " & NumeroCalle & ",`Localidad`= " & Localidad & " WHERE `id` = " & idDomicilio & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarDomicilio(ByVal idDomicilio As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Domicilio` WHERE `id` = " & idDomicilio & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Persona

    Public Function CrearPersona(ByVal idDomicilio As Integer, ByVal NumeroDocumento As Integer, ByVal TipoDocumento As Integer, ByVal Nombre As String, ByVal Apellido As String) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Persona`(`Domicilio`, `Documento`, `Tipo_Documento`, `Nombre`, `Apellido`) VALUES (" & idDomicilio & "," & NumeroDocumento & "," & TipoDocumento & ",'" & Nombre & "','" & Apellido & "');"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarPersona(ByVal idPersona As Integer, ByVal idDomicilio As Integer, ByVal NumeroDocumento As Integer, ByVal TipoDocumento As Integer, ByVal Nombre As String, ByVal Apellido As String)
        Dim sqlDomicilio As String = "UPDATE `Persona` SET `Domicilio`= " & idDomicilio & ",`Documento`= " & NumeroDocumento & ",`Tipo_Documento`=" & TipoDocumento & ",`Nombre`='" & Nombre & "',`Apellido`='" & Apellido & "' WHERE `id` = " & idPersona & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarPersona(ByVal idPersona As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Persona` WHERE `id` = " & idPersona & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Escribano
    Public Sub CrearEscribano(ByVal idPersona As Integer, ByVal Matricula As String)
        Dim sqlCrearEscribano As String = "INSERT INTO `Escribanos`(`Matricula`, `Persona`) VALUES ('" & Matricula & "', " & idPersona & "); "
        Me.ejecutarInsert(sqlCrearEscribano)
    End Sub

    Public Sub EditarEscribano(ByVal idEscribano As Integer, ByVal Matricula As String)
        Dim sqlCrearEscribano As String = "UPDATE `Escribanos` SET `Matricula`='" & Matricula & "' WHERE `id` = " & idEscribano & ";"
        Me.ejecutar(sqlCrearEscribano)
    End Sub

    Public Sub BorrarEscribano(ByVal idEscribano As Integer)
        Dim sqlCrearEscribano As String = "DELETE FROM `Escribanos` WHERE `id` = " & idEscribano & "; "
        Me.ejecutar(sqlCrearEscribano)
    End Sub

    'Busquedas en tablas
    Public Function BusquedaExactaEnTabla(ByVal NombreTabla As String, ByVal CampoDeBusqueda As String, ByVal valor1 As String, Optional ByVal valor2 As Integer = 0) As DataTable
        Dim sql As String
        If valor2 = 0 Then
            sql = "SELECT * FROM `" & NombreTabla & "` WHERE `" & CampoDeBusqueda & "` = '" & valor1 & "'; "
        Else
            sql = "SELECT * FROM `" & NombreTabla & "` WHERE `" & CampoDeBusqueda & "` = " & valor2 & "; "
        End If
        Return Me.Consulta(sql)
    End Function

    Public Function BusquedaGeneralEnTabla(ByVal NombreTabla As String, ByVal CampoDeBusqueda As String, ByVal valor1 As String, Optional ByVal Filtro As String = "") As DataTable
        Dim sql As String = "SELECT * FROM `" & NombreTabla & "` WHERE `" & CampoDeBusqueda & "` LIKE '%" & valor1 & "%' " & Filtro & "; "
        Return Me.Consulta(sql)
    End Function
    'Fin Busquedas

    'Proveedor
    Public Function CrearProveedor(ByVal idDomicilio As Integer, ByVal Nombre As String) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Proveedor`(`Domicilio`,`Nombre`) VALUES (" & idDomicilio & ",'" & Nombre & "');"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarProveedor(ByVal idProveedor As Integer, ByVal idDomicilio As Integer, ByVal Nombre As String)
        Dim sqlDomicilio As String = "UPDATE `Proveedor` SET `Domicilio`= " & idDomicilio & ", `Nombre`='" & Nombre & "' WHERE `id` = " & idProveedor & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarProveedor(ByVal idProveedor As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Proveedor` WHERE `id` = " & idProveedor & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub


    'Gastos

    Public Function CrearGasto(ByVal idEdificio As Integer, ByVal Fecha As DateTime, ByVal Concepto As String, ByVal Proveedor As Integer, ByVal NumeroComprobante As Integer, ByVal Monto As Double) As Integer

        'Dim date1 As New Date(2012, 12, 16, 12, 0, 0)
        ' 16/12/2012 12:00:00
        'DateTime constructor: parameters year, month, day, hour, min, sec
        ' Formato MySQL YYYY-MM-DD


        Dim sql As String = "INSERT INTO `Gastos`(`Edificio`, `Fecha`, `Concepto`, `Proveedor`, `Numero_Comprobante`, `Importe`) VALUES (" & idEdificio & ",'" & Fecha.Year & "-" & Fecha.Month & "-" & Fecha.Day & "', '" & Concepto & "'," & Proveedor & "," & NumeroComprobante & "," & Monto & ");"
        Me.ejecutarInsert(sql)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarGasto(ByVal idGasto As Integer, ByVal idEdificio As Integer, ByVal Fecha As DateTime, ByVal Concepto As String, ByVal Proveedor As Integer, ByVal NumeroComprobante As Integer, ByVal Monto As Double)
        Dim sqlDomicilio As String = "UPDATE `Gastos` SET `Edificio`= " & idEdificio & ",`Fecha`='" & Fecha.Year & "-" & Fecha.Month & "-" & Fecha.Day & "',`Concepto`='" & Concepto & "',`Proveedor`=" & Proveedor & ",`Numero_Comprobante`=" & NumeroComprobante & ",`Importe`=" & Monto & " WHERE `id` = " & idGasto & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarGasto(ByVal idGastos As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Gastos` WHERE `id` = " & idGastos & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Duenio
    Public Function CrearDuenio(ByVal idPropiedad As Integer, ByVal idPersona As Integer) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Duenios`(`Propiedad`, `Duenio`) VALUES (" & idPropiedad & "," & idPersona & ");"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarDuenio(ByVal idDuenio As Integer, ByVal idPropiedad As Integer, ByVal idPersona As Integer, Optional ByVal Borrado As Integer = 0)
        Dim sqlDomicilio As String = "UPDATE `Duenios` SET `Propiedad`=" & idPropiedad & ",`Duenio`=" & idPersona & ",`borrado`=" & Borrado & " WHERE `id` = " & idDuenio & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarDuenio(ByVal idDuenio As Integer)
        Dim sqlDomicilio As String = "UPDATE `Duenios` SET `Borrado` = 1 WHERE `id` = " & idDuenio & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarDuenioFisico(ByVal idDuenio As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Duenios` WHERE `id` = " & idDuenio & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarDuenioFisicoPorPropiedad(ByVal idPropiedad As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Duenios` WHERE `Propiedad` = " & idPropiedad & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Interesado

    Public Function CrearInteresado(ByVal idPropiedad As Integer, ByVal idPersona As Integer) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Interesados`(`Propiedad`, `Interesado`) VALUES (" & idPropiedad & "," & idPersona & ");"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarInteresado(ByVal idInteresado As Integer, ByVal idPropiedad As Integer, ByVal idPersona As Integer)
        Dim sqlDomicilio As String = "UPDATE `Interesados` SET `Propiedad`=" & idPropiedad & ",`Interesado`=" & idPersona & " WHERE `id` = " & idInteresado & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarInteresado(ByVal idInteresado As Integer)
        Dim sqlDomicilio As String = "DELETE FROM `Interesados` WHERE `id` = " & idInteresado & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Propiedad
    Public Function CrearPropiedad(ByVal idInmueble As Integer, ByVal Piso As Integer, ByVal Denominacion As String, ByVal TipoPropiedad As Integer, ByVal Superficie As Double, ByVal Monto As Double, ByVal Moneda As String) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Propiedad`(`Id_Inmueble`, `Piso`, `Denominacion`, `Tipo_Propiedad`, `Superficie`, `Monto`, `Moneda`)" _
                                     & " VALUES (" & idInmueble & "," & Piso & ", '" & Denominacion & "' , " & TipoPropiedad & "," & Superficie & ", " & Superficie & ",`" & Moneda & "`);"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarPropiedad(ByVal idPropiedad As Integer, ByVal idInmueble As Integer, ByVal Piso As Integer, ByVal Denominacion As String, ByVal TipoPropiedad As Integer, ByVal Superficie As Double, ByVal Monto As Double, ByVal Moneda As String, Optional ByVal Borrado As Integer = 0)
        Dim sqlDomicilio As String = "UPDATE `Propiedad` SET `Id_Inmueble`= " & idInmueble & ",`Piso`= " & Piso & ",`Denominacion`= '" & Denominacion & "' ,`Tipo_Propiedad`=" & TipoPropiedad & ",`Superficie`=" & Superficie & ",`Monto`= " & Monto & ",`Moneda`= '" & Moneda & "',`borrado`= " & Borrado & " WHERE `id` = " & idPropiedad & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarPropiedad(ByVal idPropiedad As Integer)
        Dim sqlDomicilio As String = "UPDATE `Propiedad` SET `Borrado` = 1 WHERE `id` = " & idPropiedad & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub


    'Inmueble
    Public Function CrearInmueble(ByVal DesignacionCatastral As String, ByVal IdDomicilio As Integer, ByVal IdPersona As Integer, ByVal CantidadDepartamentos As Integer, ByVal Ascensor As Boolean) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`, `Encargado`, `Cantidad_Departamentos`, `Ascensor`) VALUES ('" & DesignacionCatastral & "'," & IdDomicilio & "," & IdPersona & "," & CantidadDepartamentos & "," & Convert.ToInt32(Ascensor) & ")"
        Me.ejecutarInsert(sqlDomicilio)
        Return Me.ultimoIdInsertado()
    End Function

    Public Sub ActualizarInmueble(ByVal idInmueble As Integer, ByVal DesignacionCatastral As String, ByVal IdDomicilio As Integer, ByVal IdPersona As Integer, ByVal CantidadDepartamentos As Integer, ByVal Ascensor As Boolean, Optional ByVal Borrado As Integer = 0)
        Dim sqlDomicilio As String = "UPDATE `Inmueble` SET `Designacion_Catastral`='" & DesignacionCatastral & "',`Domicilio`= " & IdDomicilio & ",`Encargado`= " & IdPersona & ",`Cantidad_Departamentos`=" & CantidadDepartamentos & ",`Ascensor`=" & Convert.ToInt32(Ascensor) & ",`borrado`= " & Borrado & " WHERE `id` = " & idInmueble & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarInmueble(ByVal idInmueble As Integer)
        Dim sqlDomicilio As String = "UPDATE `Inmueble` SET `Borrado` = 1 WHERE `id` = " & idInmueble & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Factura
    'INSERT INTO `Factura`(`id`, `Persona`, `Monto`, `Moneda`, `Concepto`, `borrado`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6])

    Public Function CrearFactura(ByVal idPersona As Integer, ByVal Monto As Double, ByVal Moneda As String, ByVal Concepto As String) As Integer
        Dim sqlDomicilio As String = "INSERT INTO `Factura`(`Persona`, `Monto`, `Moneda`, `Concepto`) VALUES (" & idPersona & "," & Monto & ",'" & Moneda & "','" & Concepto & "');"
        'Me.ejecutarInsert(sqlDomicilio)


        Dim sqlid = "SELECT MAX(id) AS id FROM `Factura`"

        Dim tabla As DataTable = ejecutar(sqlid)


        Me.conexion_con_transaccion()

        Me.insertar(sqlDomicilio)

        Dim retorno As Integer = Integer.Parse(tabla(0)("id"))

        Return retorno
        'Return Me.ultimoIdInsertado()
    End Function

    Public Sub BorrarFactura(ByVal idFactura As Integer)
        Dim sqlDomicilio As String = "UPDATE `Factura` SET `Borrado` = 1 WHERE `id` = " & idFactura & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    'Operacion inmobiliaria

    'INSERT INTO `Operacion_Inmobiliaria`(`Inmueble`, `Propiedad`, `Tipo_Operacion`, `Persona_Interviniente`, `Fecha_Operacion`, `Duracion`, `Monto_Mensual`, `Factura`, `Comision_Venta`, `Escribano`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7],[value-8],[value-9],[value-10])

    Public Sub CrearOperacionInmobiliaria(ByVal idPropiedad As Integer, ByVal TipoOperacion As Integer, ByVal idPersonaInterviniente As Integer, ByVal FechaOperacion As Date, ByVal Duracion As Integer, ByVal MontoMensual As Double, ByVal idFactura As Integer, ByVal Comision As Double, ByVal idEscribano As Integer)

        Dim separados() As String
        separados = Split(FechaOperacion, "/")

        Dim dia As Integer = Integer.Parse(separados(0))
        Dim mes As Integer = Integer.Parse(separados(1))
        Dim año As Integer = Integer.Parse(separados(2))

        Dim daaaa As New Date(año, mes, dia)


        Dim fecha As String = daaaa.ToString("yyyy-MM-dd")


        Dim sqlDomicilio As String = "INSERT INTO `Operacion_Inmobiliaria`(`Propiedad`, `Tipo_Operacion`, `Persona_Interviniente`, `Fecha_Operacion`, `Duracion`, `Monto_Mensual`, `Factura`, `Comision_Venta`, `Escribano`) VALUES (" & idPropiedad & "," & TipoOperacion & "," & idPersonaInterviniente & ",'" & fecha & "', " & Duracion & ", " & MontoMensual & ", " & idFactura & ", " & Comision & "," & idEscribano & ")"
        'Me.ejecutarInsert(sqlDomicilio)

        Me.insertar(sqlDomicilio)

        ' MsgBox(sqlDomicilio)

        ' Return Me.ultimoIdInsertado()
    End Sub

    Public Sub ActualizarOperacionInmobiliaria(ByVal idOperacionInmobiliaria As Integer, ByVal idPropiedad As Integer, ByVal TipoOperacion As Integer, ByVal idPersonaInterviniente As Integer, ByVal FechaOperacion As Date, ByVal Duracion As Integer, ByVal MontoMensual As Double, ByVal idFactura As Integer, ByVal Comision As Double, ByVal idEscribano As Integer)
        Dim sqlDomicilio As String = "UPDATE `Operacion_Inmobiliaria` SET `Propiedad`=" & idPropiedad & ",`Tipo_Operacion`=" & TipoOperacion & ",`Persona_Interviniente`=" & idPersonaInterviniente & ",`Fecha_Operacion`= '" & FechaOperacion & "',`Duracion`= " & Duracion & ",`Monto_Mensual`=" & MontoMensual & ",`Factura`= " & idFactura & ",`Comision_Venta`= " & Comision & ",`Escribano`=" & idEscribano & " WHERE `id` = " & idOperacionInmobiliaria & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub

    Public Sub BorrarOperacionInmobiliaria(ByVal idInmueble As Integer)
        Dim sqlDomicilio As String = "UPDATE `Inmueble` SET `Borrado` = 1 WHERE `id` = " & idInmueble & ";"
        Me.ejecutar(sqlDomicilio)
    End Sub


    Public Function ComprobarFK(ByVal Tabla As String, ByVal Campo As String, ByVal id As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) AS `TOTAL` FROM `" & Tabla & "` WHERE `" & Campo & "` = " & id & ";"
        Dim retorno As DataTable = Me.Consulta(sql)

        If retorno(0)("TOTAL") > 0 Then
            Return False
        End If

        Return True

    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Enum tipo_conexion
        simple
        transaccion
    End Enum

    Enum resultado
        _ok
        _error
    End Enum

    Dim configuracion_conexion As tipo_conexion = tipo_conexion.simple
    Dim transaccion As Object


    Dim UltimoError As String = ""
    Dim control_transaccion As resultado = resultado._ok




    'Declaro la variable externa
    '    - Definición de propiedades públicas
    Public Property _cadena_conexion As String
        Get
            'Envio de la cadena de conexion interna
            Return cadena_conexion
        End Get
        Set(ByVal value As String)
            'ingreso a la clase desde afuera
            cadena_conexion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    'Definimos el motor
    Public Property _motor As motores
        Get
            Return motor
        End Get
        Set(ByVal value As motores)
            motor = value
            Me.configurar_motor()
        End Set
    End Property

    Public Property _nombre_tabla As String
        Get
            Return nombre_tabla
        End Get
        Set(ByVal value As String)
            nombre_tabla = value
        End Set
    End Property
    'byval toma el valor en la posicion del objeto 
    'byref toma en lugar de el valor enviado, la posicion del objeto
    Public Function Consulta2(ByVal sql As String) As DataTable
        Return ejecutar2(sql)
    End Function

    Public Function leo_tabla() As DataTable
        Return ejecutar2("SELECT * FROM " & Me.nombre_tabla)
    End Function

    Public Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecutar2("SELECT * FROM " & nombre_tabla)
    End Function

    Private Function ejecutar2(ByRef sql As String) As DataTable
        Dim tabla As New DataTable
        Me.conectar2()
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        Me.Cerrar()
        Return tabla
    End Function

    Public Sub conexion_con_transaccion()
        configuracion_conexion = tipo_conexion.transaccion
        control_transaccion = resultado._ok
    End Sub

    Public Sub cerrar_con_transaccion()
        If (control_transaccion = resultado._ok) Then
            transaccion.Commit()
        Else
            transaccion.RollBack()
        End If
        conexion.Close()
        configuracion_conexion = tipo_conexion.simple

    End Sub

    Public Function insertar(ByVal datos As String) As resultado
        Dim txt_datos As String = datos.ToUpper 'transfiere los datos todos a mayuscula
        Dim tabla As New DataTable

        Dim cabecera As String = ""
        Dim paquete_datos As String = ""
        Dim tipoDato As String = ""
        Dim sqlinsert As String = ""

        sqlinsert = datos

        'MessageBox.Show(sqlinsert)

        If resultado._ok = Me.conectar2 Then
            Me.conectar2()
            Me.cmd.CommandText = sqlinsert
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                control_transaccion = resultado._error
                Cerrar()
                Return resultado._error
            End Try
            'Me.Cerrar()
            Return resultado._ok

            Return True

        End If
        Return resultado._error
    End Function

    Private Function formatear(ByVal dato As String, ByVal tipodato As String) As String
        Select Case tipodato
            Case "String"
                Return "'" + dato + "'"
            Case Else
                Return dato
        End Select

    End Function
    Private Function estructura_tabla() As DataTable
        Dim tabla As New DataTable
        Select Case Me.motor
            Case motores.sqlserver
                Return Me.ejecutar("SELECT TOP 1 * FROM " & Me.nombre_tabla)
        End Select
        Return tabla
    End Function


    Private Sub cerrar2()
        If configuracion_conexion = tipo_conexion.simple Then
            conexion.Close()
        End If
    End Sub

    Private Sub configurar_motor()
        'Las usamos para autocompletar
        'Dim conexion As OleDb.OleDbConnection
        'Dim cmd As OleDb.OleDbCommand
        Select Case Me.motor
            Case motores.sqlserver
                Me.conexion = New OleDb.OleDbConnection
                Me.cmd = New OleDb.OleDbCommand
            Case motores.mysql
                'Me.conexion = New MySql.Data.MySqlClient.MySqlConnection
                'Me.cmd = New MySqlCommand
        End Select
    End Sub


    Private Function conectar2() As resultado


        If conexion.State.ToString <> "Open" Then
            conexion.ConnectionString = cadena_conexion


            Try
                conexion.Open()
            Catch ex As Exception
                MessageBox.Show("Error al intentar conectar", "Error grave")
                Me.UltimoError = ex.Message
                Return resultado._error
            End Try



            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            If (Me.configuracion_conexion = tipo_conexion.transaccion) Then
                Me.transaccion = conexion.BeginTransaction
                cmd.Transaction = Me.transaccion
            End If
        End If
        Return resultado._ok
    End Function



End Class
