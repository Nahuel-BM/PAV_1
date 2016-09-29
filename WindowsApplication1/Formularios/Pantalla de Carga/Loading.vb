Imports System.Threading

Public Class Loading

    Dim valorProgressBar As Integer = 0
    Dim intTotalPartes As Integer = 1
    Dim aumento As Integer = 0
    Dim leyenda As String = "Iniciando.."
    Dim SegundosTranscurridos As Double = 0


    Public Property _leyenda As String
        Get
            Return leyenda
        End Get
        Set(ByVal value As String)
            Me.leyenda = value
        End Set
    End Property


    Public Property _valorProgressBar As Integer
        Get
            Return Me.valorProgressBar
        End Get
        Set(ByVal value As Integer)
            Me.valorProgressBar = value
        End Set
    End Property

    Public Property _totalPartes As Integer
        Get
            Return Me.intTotalPartes
        End Get
        Set(ByVal value As Integer)
            Me.intTotalPartes = value
            Me.aumento = 100 / intTotalPartes
        End Set
    End Property

    Public Property _aumento As Integer
        Get
            Return Me.aumento
        End Get
        Set(ByVal value As Integer)
            Me.aumento = 100 / intTotalPartes
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Timer1.Enabled = True

    End Sub


    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_Estado.Text = leyenda
        Me.Timer1.Enabled = True
    End Sub


    '    Public Sub ActualizarBarra()
    '        Me._valorProgressBar += Me._aumento
    '    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Me.prgb_carga.Value < 100 Then 'si la barra esta llena..

            'si falta cargar..
            Me.prgb_carga.Value = valorProgressBar
            Me.lbl_Estado.Text = leyenda
            Me.SegundosTranscurridos += 0.1D

        Else

            'Cambio la transparencia

            If Me.Opacity = 0.0 Then       ' si la ventana es transparente
                Me.Timer1.Enabled = False   ' Detengo el timer..
                Me.Dispose()                ' cierro la ventana
            Else                            ' sino 
                Me.Opacity -= 0.1           ' aumento la transparencia
            End If



        End If

    End Sub

End Class