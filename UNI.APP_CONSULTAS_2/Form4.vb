Public Class Form4
    Dim obj As New DataAccess

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCliente.DataSource = obj.ClienteListar.Tables(0)
        cboCliente.DisplayMember = "NomCliente"
        cboCliente.ValueMember = "IdCliente"
        cboCliente_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        Try
            Dim idcliente As String = cboCliente.SelectedValue.ToString
            dgPedidos.DataSource = obj.PedidosCliente(idcliente).Tables(0)
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class