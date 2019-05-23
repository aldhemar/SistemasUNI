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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DT1 = New System.Windows.Forms.DateTimePicker()
        Me.DT2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "FECHA INICIAL :"
        '
        'dgPedidos
        '
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Location = New System.Drawing.Point(12, 160)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(611, 278)
        Me.dgPedidos.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CONSULTA DE PEDIDOS"
        '
        'DT1
        '
        Me.DT1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT1.Location = New System.Drawing.Point(162, 84)
        Me.DT1.Name = "DT1"
        Me.DT1.Size = New System.Drawing.Size(128, 23)
        Me.DT1.TabIndex = 17
        '
        'DT2
        '
        Me.DT2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT2.Location = New System.Drawing.Point(162, 113)
        Me.DT2.Name = "DT2"
        Me.DT2.Size = New System.Drawing.Size(128, 23)
        Me.DT2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FECHA FINAL"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(391, 94)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(137, 37)
        Me.btnConsultar.TabIndex = 20
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 450)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.DT2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DT1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = ":::: CONSULTA ::::"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
End Class
