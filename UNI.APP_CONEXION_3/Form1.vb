Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class Form1
    Dim cn As New SqlConnection(ConnectionStrings("cno").ConnectionString)
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Sub llenaClientes()
        da = New SqlDataAdapter("SELECT * FROM Ventas.CLIENTES", cn)
        da.Fill(ds, "Clientes")
        dgClientes.DataSource = ds.Tables("Clientes")
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        lblTotal.Text = ds.Tables("Clientes").Rows.Count
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaClientes()
    End Sub
End Class
