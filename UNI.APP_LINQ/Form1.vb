Public Class Form1
    'instanciar el modelo del contexto
    Dim modelo As New Negocios2015DataContext

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'linq
        Dim lista = From c In modelo.clientes
                    Select c.IdCliente, c.NomCliente, c.DirCliente, c.fonoCliente

        dgClientes.DataSource = lista.ToList()
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
End Class
