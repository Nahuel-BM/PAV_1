Public Class Form_con_Pantalla_de_Carga_Incluida


    Dim PantallaDeCarga As Loading
    Public thColor As Threading.Thread

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
        thColor = New Threading.Thread(AddressOf MetodoDeCreacionDeHiloLocal)
        thColor.Start()

    End Sub


    'Metodo local que apunta a la instancia de Loading, se hace esto para cambiar los valores
    'de la barra de progreso desde metodos locales.
    Private Sub MetodoDeCreacionDeHiloLocal()
        Form_con_Pantalla_de_Carga_Incluida.CrearLoadingConParametro(Me.PantallaDeCarga)
    End Sub


    Public Shared Sub CrearLoadingConParametro(ByRef Loading As Loading)
        Application.Run(Loading)
    End Sub


    ' Public Async


    ' Metodo que actualiza el valor de la barra de progreso y adiciona una leyenda
    Public Sub actualizarLoading(ByVal leyenda As String)

        ' Por alguna razon que desconozco no funciona de esta forma

        'Me.PantallaDeCarga._leyenda = leyenda
        'Me.PantallaDeCarga.ActualizarBarra()

        'funciona asi.. o.O
        Me.PantallaDeCarga.prgb_carga.Value += Me.PantallaDeCarga._aumento
        Me.PantallaDeCarga.lbl_Estado.Text = leyenda

    End Sub

    ' Metodo que finaliza el hilo y cierra el formulario "Loading"
    Private Sub terminarLoading()
        Me.PantallaDeCarga._leyenda = "Finalizando.."
        Me.PantallaDeCarga.prgb_carga.Value = 100
        'Me.thColor.Abort()
    End Sub


End Class
