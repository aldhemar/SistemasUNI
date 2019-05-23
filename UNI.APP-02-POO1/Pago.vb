Public Class Pago
    'Atributos
    Public Vendedor As String
    Public Categoria As Integer
    Public Hora As Integer

    'Constructor
    Public Sub New(vend As String, cate As Integer, hora As Integer)
        Me.Vendedor = vend
        Me.Categoria = cate
        Me.Hora = hora
    End Sub

    'Metodos
    Public Function PagoHora() As Double
        Select Case Me.Categoria
            Case 0 : Return 40
            Case 1 : Return 30
            Case 2 : Return 20
            Case 3 : Return 10
            Case Else
                Return 0
        End Select
    End Function

    Public Function SalarioBruto() As Double
        Return Hora * PagoHora()
    End Function

    Public Function Descuento() As Double
        Return SalarioBruto() * 0.1
    End Function

    Public Function Neto() As Double
        Return SalarioBruto() - Descuento()
    End Function
End Class
