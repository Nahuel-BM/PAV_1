Public Class Form_con_Pantalla_de_Carga_Incluida
    Implements System.IDisposable

    Dim PantallaDeCarga As Loading
    Public thColor As Threading.Thread
    Dim disposed As Boolean = False

    Public Sub New()
        'Desactivo el control cruzado de hilos
        Control.CheckForIllegalCrossThreadCalls = False

        'Creo instancia de Loading
        Me.PantallaDeCarga = New Loading()

        'Me.PantallaDeCarga.Show()

    End Sub



    Public Sub setTotalDeEventos(ByVal valor As Integer)
        Me.PantallaDeCarga._totalPartes = valor
    End Sub


    Public Sub Run()
        'Creo el hilo y lo inicio

        Me.thColor = New Threading.Thread(AddressOf MetodoDeCreacionDeHiloLocal)
        Me.thColor.Start()

        'Asigno referencia al hilo padre
        Me.PantallaDeCarga.setHiloPadre(Me.thColor)

    End Sub


    'Metodo local que apunta a la instancia de Loading, se hace esto para cambiar los valores
    'de la barra de progreso desde metodos locales.
    Private Sub MetodoDeCreacionDeHiloLocal()
        Form_con_Pantalla_de_Carga_Incluida.CrearLoadingConParametro(Me.PantallaDeCarga)
    End Sub


    Public Shared Sub CrearLoadingConParametro(ByRef Loading As Loading)
        Try
            Application.Run(Loading)
        Catch ex As System.Threading.ThreadAbortException
            'agarre la exception!
        End Try
    End Sub

    ' Metodo que actualiza el valor de la barra de progreso y adiciona una leyenda
    Public Sub actualizarLoading(ByVal leyenda As String)

        ' Por alguna razon que desconozco no funciona de esta forma

        'Me.PantallaDeCarga._leyenda = leyenda
        'Me.PantallaDeCarga.ActualizarBarra()

        'funciona asi.. o.O

        Dim suma As Integer = Me.PantallaDeCarga.prgb_carga.Value + Me.PantallaDeCarga._aumento

        If suma >= 99 Then
            Me.PantallaDeCarga.prgb_carga.Value = 100
        Else
            Me.PantallaDeCarga.prgb_carga.Value += Me.PantallaDeCarga._aumento
        End If


        Me.PantallaDeCarga.lbl_Estado.Text = leyenda

    End Sub

    ' Metodo que finaliza el hilo y cierra el formulario "Loading"
    Private Sub terminarLoading()
        '  Me.PantallaDeCarga._leyenda = "Finalizando.."
        '   Me.PantallaDeCarga.prgb_carga.Value = 100
        Me.thColor.Abort()
    End Sub


    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)

        If Not disposed Then
            If disposing Then
                Dispose()
            End If
        End If
        disposed = True
    End Sub

    Public Overloads Sub Dispose() Implements System.IDisposable.Dispose
        Dispose(True)
        Me.terminarLoading()
        GC.SuppressFinalize(Me)
    End Sub


End Class
