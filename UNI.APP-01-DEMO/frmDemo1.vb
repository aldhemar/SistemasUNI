Public Class frmDemo1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Saliendo del Formulario.....", "AVISO")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me >>  Referencia al formulario actual.
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.LimeGreen
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        'this.Close();
    End Sub
End Class
