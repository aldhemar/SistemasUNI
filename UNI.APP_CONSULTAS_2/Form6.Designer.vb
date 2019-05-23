<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEmpleado
        '
        Me.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpleado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(178, 63)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(265, 27)
        Me.cboEmpleado.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "EMPLEADO :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 34)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CONSULTA DE PEDIDOS"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(178, 96)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(265, 27)
        Me.cboCliente.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "CLIENTE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "FECHA INICIAL"
        '
        'dtInicio
        '
        Me.dtInicio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(178, 129)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(113, 26)
        Me.dtInicio.TabIndex = 32
        '
        'dtFin
        '
        Me.dtFin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(178, 161)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(113, 26)
        Me.dtFin.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "FECHA FINAL"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(532, 157)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(133, 37)
        Me.btnConsultar.TabIndex = 35
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgPedidos
        '
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Location = New System.Drawing.Point(12, 209)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(676, 260)
        Me.dgPedidos.TabIndex = 36
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = ":::: CONSULTAS ::::"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGridView
End Class
