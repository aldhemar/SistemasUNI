Public Class Form4
    Dim modelo As New Negocios2015DataContext

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClientes.DataSource = modelo.usp_ClienteListar
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "idCliente"
        cboClientes_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Try
            Dim idcli As String = cboClientes.SelectedValue.ToString
            dgPedidos.DataSource = modelo.usp_PedidosCliente(idcli)
        Catch ex As Exception

        End Try
    End Sub
End Class