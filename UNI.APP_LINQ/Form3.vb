Public Class Form3
    Dim modelo As New Negocios2015DataContext

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = From c In modelo.clientes Select c

        cboClientes.DataSource = lista.ToList()
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "IdCliente"
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Try
            Dim idcli As String = cboClientes.SelectedValue.ToString
            Dim lista = From p In modelo.pedidoscabe
                        Where p.IdCliente = idcli Select p

            dgPedidos.DataSource = lista.ToList
        Catch ex As Exception

        End Try
    End Sub
End Class