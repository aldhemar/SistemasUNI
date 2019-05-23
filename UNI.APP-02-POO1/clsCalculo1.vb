Public Class clsCalculo1
    'Definir Atributos
    Public Producto As String
    Public Precio As Double
    Public Cantidad As Integer

    'Metodos de la Clase
    Public Function SubTotal() As Double
        Return Precio * Cantidad
    End Function

    Public Function Igv() As Double
        Return SubTotal() * 0.18
    End Function

    Public Function Total() As Double
        Return SubTotal() + Igv()
    End Function
End Class
