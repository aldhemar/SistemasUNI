Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporte As New rptProductos
        crvProductos.ReportSource = reporte
    End Sub
End Class
