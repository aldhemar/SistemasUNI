Public Class Form4
    Dim obj As New EmpleadoDAO

    Sub cargaDistritos()
        cboDistrito.DataSource = obj.DistritoListar
        cboDistrito.DisplayMember = "nomDistrito"
        cboDistrito.ValueMember = "idDistrito"
    End Sub

    Sub cargaCargos()
        cboCargo.DataSource = obj.CargoListar
        cboCargo.DisplayMember = "desCargo"
        cboCargo.ValueMember = "idCargo"
    End Sub

    Sub cargaEmpleados()
        dgEmpleados.DataSource = obj.EmpleadoListar
        dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaCargos()
        cargaDistritos()
        cargaEmpleados()
    End Sub

    Private Sub dgEmpleados_SelectionChanged(sender As Object, e As EventArgs) Handles dgEmpleados.SelectionChanged
        Try
            lblCodigo.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(0).Value()
            txtApe.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(1).Value()
            txtNom.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(2).Value()
            txtDireccion.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(4).Value()
            cboDistrito.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(3).Value()
            txtTelefono.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(6).Value()
            cboCargo.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(5).Value()
            dtContrato.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(7).Value()
            dtfecnac.Text = dgEmpleados.Rows(dgEmpleados.CurrentRow.Index).Cells(8).Value()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each objeto As Object In Me.Controls
            If TypeOf objeto Is TextBox Then objeto.Text = String.Empty
        Next
        cboCargo.SelectedIndex = -1
        cboDistrito.SelectedIndex = -1
        txtApe.Focus()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            obj.EmpleadoInsertar(txtApe.Text, txtNom.Text, dtfecnac.Value.Date,
                                 txtDireccion.Text, Integer.Parse(cboDistrito.SelectedValue.ToString),
                                 txtTelefono.Text, Integer.Parse(cboCargo.SelectedValue.ToString),
                                 dtContrato.Value.Date)
            cargaEmpleados()
            MessageBox.Show("Empleado Registrado....", "AVISO")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            obj.EmpleadoActualizar(Integer.Parse(lblCodigo.Text), txtApe.Text, txtNom.Text,
                                 dtfecnac.Value.Date, txtDireccion.Text,
                                 Integer.Parse(cboDistrito.SelectedValue.ToString),
                                 txtTelefono.Text, Integer.Parse(cboCargo.SelectedValue.ToString),
                                 dtContrato.Value.Date)
            cargaEmpleados()
            MessageBox.Show("Empleado Actualizado.....", "AVISO")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If (MessageBox.Show("Desea dar de baja al Empleado ?", "Aviso",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            Try
                obj.EmpleadoBaja(lblCodigo.Text)
                cargaEmpleados()
                MessageBox.Show("Empleado dado de Baja ....!!", "AVISO")
            Catch ex As Exception

            End Try
        End If


    End Sub
End Class