<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvProductos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvProductos
        '
        Me.crvProductos.ActiveViewIndex = -1
        Me.crvProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvProductos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvProductos.Location = New System.Drawing.Point(0, 0)
        Me.crvProductos.Name = "crvProductos"
        Me.crvProductos.Size = New System.Drawing.Size(480, 409)
        Me.crvProductos.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 409)
        Me.Controls.Add(Me.crvProductos)
        Me.Name = "Form1"
        Me.Text = ":::: REPORTE DE PRODUCTOS :::::"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvProductos As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
