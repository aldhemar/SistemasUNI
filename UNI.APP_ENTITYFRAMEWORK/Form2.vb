Public Class Form2
    Dim modelo As New Negocios2015Entities

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim oLista As New List(Of usp_PedidoFechas_Result)
        oLista = modelo.usp_PedidoFechas(dt1.Value.Date, dt2.Value.Date).ToList

        If oLista.Count > 0 Then
            dgPedidos.DataSource = oLista
        Else
            dgPedidos.DataSource = Nothing
            MessageBox.Show("No existen datos....", "AVISO")
        End If

    End Sub
End Class