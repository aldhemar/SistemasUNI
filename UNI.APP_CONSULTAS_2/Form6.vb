Public Class Form6
    Dim obj As New DataAccess

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEmpleado.DataSource = obj.EmpleadoListar.Tables(0)
        cboEmpleado.DisplayMember = "ApeEmpleado"
        cboEmpleado.ValueMember = "IdEmpleado"
        cboEmpleado_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleado.SelectedIndexChanged
        Try
            Dim idemp As Integer = Integer.Parse(cboEmpleado.SelectedValue.ToString)
            cboCliente.DataSource = obj.ClienteEmpleado(idemp).Tables(0)
            cboCliente.DisplayMember = "NomCliente"
            cboCliente.ValueMember = "idCliente"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim idemp As Integer = Integer.Parse(cboEmpleado.SelectedValue.ToString)
        Dim idcli As String = cboCliente.SelectedValue.ToString
        Dim ds As New DataSet
        ds = obj.PedidoECfechas(idemp, idcli, dtInicio.Value.Date, dtFin.Value.Date)

        If ds.Tables(0).Rows.Count > 0 Then
            dgPedidos.DataSource = ds.Tables(0)
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            dgPedidos.DataSource = Nothing
            MessageBox.Show("No se encuentran datos...!!! ", "AVISO")
        End If
    End Sub
End Class