<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPedidos
        '
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Location = New System.Drawing.Point(12, 141)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(702, 250)
        Me.dgPedidos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PEDIDOS POR FECHAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA INICIAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA FINAL"
        '
        'dt1
        '
        Me.dt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(156, 71)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(110, 21)
        Me.dt1.TabIndex = 4
        '
        'dt2
        '
        Me.dt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt2.Location = New System.Drawing.Point(156, 101)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(110, 21)
        Me.dt2.TabIndex = 5
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(350, 71)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(136, 43)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 403)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPedidos)
        Me.Name = "Form2"
        Me.Text = ":::: FECHAS ::::"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
End Class
