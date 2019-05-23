Public Class Form2
    Dim modelo As New Negocios2015DataContext

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        'Dim lista = From c In modelo.clientes
        '            Where c.NomCliente.StartsWith(txtCliente.Text.Trim)
        '            Select c
        Dim lista = From c In modelo.clientes
                   Where c.NomCliente.Contains(txtCliente.Text.Trim)
                   Select c

        dgClientes.DataSource = lista.ToList
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCliente_TextChanged(sender, e)
    End Sub
End Class