Public Class Form3
    Dim modelo As New Negocios2015Entities

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClientes.DataSource = modelo.usp_ClienteListar
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "idCliente"
        cboClientes_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Try
            dgPedidos.DataSource = modelo.usp_PedidosCliente( _
                  cboClientes.SelectedValue.ToString)
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class