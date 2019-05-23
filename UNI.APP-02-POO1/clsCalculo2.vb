Public Class clsCalculo2
    'Definir Atributos
    Public Producto As String
    Public Precio As Double
    Public Cantidad As Integer

    'Constructor
    'se usa al momento de instanciar a la clase (Dim obj as New NomClase)
    Public Sub New(prod As String, pre As Double, can As Integer)
        Me.Producto = prod
        Me.Precio = pre
        Me.Cantidad = can
    End Sub

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
