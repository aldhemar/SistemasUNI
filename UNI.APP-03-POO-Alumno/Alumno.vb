Public Class Alumno
    'campos. - Variables que almacenan la informacion
    Private _codigo As String
    Private _nombre As String
    Private _nota1 As Single
    Private _nota2 As Single
    Private _nota3 As Single
    Private _prom As Single
    Private _mensaje As String
    Private N As Integer

    'Creando Propiedades
    Public ReadOnly Property Codigo As String
        Get
            Return _codigo
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public ReadOnly Property Promedio As Single
        Get
            Return _prom
        End Get
    End Property

    Public ReadOnly Property Fecha As String
        Get
            Return DateTime.Now.ToShortDateString
        End Get
    End Property

    Public ReadOnly Property Hora As String
        Get
            Return DateTime.Now.ToLongTimeString
        End Get
    End Property

    Public ReadOnly Property Mensaje As String
        Get
            Return _mensaje
        End Get
    End Property

    Public WriteOnly Property Nota1 As Single
        Set(value As Single)
            If value > 0 And value <= 20 Then
                _nota1 = value
            Else
                'Evento
            End If
        End Set
    End Property

    Public WriteOnly Property Nota2 As Single
        Set(value As Single)
            If value > 0 And value <= 20 Then
                _nota2 = value
            Else
                'Evento
            End If
        End Set
    End Property

    Public WriteOnly Property Nota3 As Single
        Set(value As Single)
            If value > 0 And value <= 20 Then
                _nota3 = value
                'ProcesaDatos()
                'GeneraCodigo()
            Else
                'Evento
            End If
        End Set
    End Property

    'METODOS
    Private Sub ProcesaDatos()
        _prom = (_nota1 + _nota2 + _nota3 * 2) / 4
        If _prom >= 14 Then
            _mensaje = "APROBADO"
        ElseIf _prom >= 10 And _prom < 14 Then
            _mensaje = "SUSTITUTORIO"
        Else
            _mensaje = "DESAPROBADO"
        End If
    End Sub

    Private Sub GeneraCodigo()
        N += 1
        _codigo = "NET-000" & N.ToString
    End Sub
End Class
