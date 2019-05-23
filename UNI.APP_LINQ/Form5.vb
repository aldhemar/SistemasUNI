Public Class Form5
    Dim modelo As New Negocios2015DataContext

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim lista = modelo.usp_PedidoFechas(DT1.Value.Date, DT2.Value.Date)
        dgPedidos.DataSource = lista
        dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub
End Class