Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NEGOCIOS2015DataSet1.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.NEGOCIOS2015DataSet1.clientes)
        lblTotal.Text = dgClientes.RowCount - 1
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
End Class