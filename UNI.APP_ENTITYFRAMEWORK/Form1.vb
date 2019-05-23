Public Class Form1
    Dim modelo As New Negocios2015Entities

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim lista = From c In modelo.clientes
        '            Select c

        'Dim oData As New List(Of usp_ClienteListar_Result)
        'oData = modelo.usp_ClienteListar.ToList

        Dim lista = modelo.usp_ClienteListar

        dgClientes.DataSource = lista.ToList()
    End Sub
End Class
