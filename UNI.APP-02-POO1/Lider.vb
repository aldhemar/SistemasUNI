Public Class Lider
    'Propiedades
    Private _Cliente As String
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    Private _Dni As String
    Public Property Dni() As String
        Get
            Return _Dni
        End Get
        Set(ByVal value As String)
            _Dni = value
        End Set
    End Property

    Private _Horas As Integer
    Public Property Horas() As Integer
        Get
            Return _Horas
        End Get
        Set(ByVal value As Integer)
            _Horas = value
        End Set
    End Property

    Private _Tarifa As Decimal
    Public Property Tarifa() As Decimal
        Get
            Return _Tarifa
        End Get
        Set(ByVal value As Decimal)
            _Tarifa = value
        End Set
    End Property

    Public Sub New()
        _Tarifa = 50
    End Sub

    Public Sub New(tar As Decimal)
        _Tarifa = tar
    End Sub

    'Metodos
    Public Function ImporteBruto() As Decimal
        Return _Tarifa * _Horas
    End Function

    Public Function Descuento() As Decimal
        If _Horas <= 3 Then
            Return ImporteBruto() * 0.1
        ElseIf _Horas <= 6 Then
            Return ImporteBruto() * 0.2
        Else
            Return ImporteBruto() * 0.3
        End If
    End Function

    Public Function Neto() As Double
        Return ImporteBruto() - Descuento()
    End Function

    Public Function Garantia() As Decimal
        Return _Horas * 10
    End Function
End Class
