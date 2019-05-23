<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpleados
        '
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(10, 120)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(693, 286)
        Me.dgEmpleados.TabIndex = 26
        '
        'cboDistrito
        '
        Me.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(245, 67)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(265, 27)
        Me.cboDistrito.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ELEGIR DISTRITO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CONSULTA DE EMPLEADOS POR DISTRITO"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 422)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.cboDistrito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "::::: APLICACIONES :::"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents cboDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
