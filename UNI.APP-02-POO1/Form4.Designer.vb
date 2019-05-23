<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.txtNeto = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(249, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 28)
        Me.btnSalir.TabIndex = 56
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(151, 270)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(91, 28)
        Me.btnLimpiar.TabIndex = 55
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnProceso
        '
        Me.btnProceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceso.Location = New System.Drawing.Point(54, 270)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(91, 28)
        Me.btnProceso.TabIndex = 54
        Me.btnProceso.Text = "PROCESO"
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'txtNeto
        '
        Me.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeto.Location = New System.Drawing.Point(191, 214)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(65, 20)
        Me.txtNeto.TabIndex = 53
        Me.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(87, 216)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(90, 13)
        Me.label6.TabIndex = 52
        Me.label6.Text = "NETO A PAGAR:"
        '
        'txtDescuento
        '
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Location = New System.Drawing.Point(191, 188)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(65, 20)
        Me.txtDescuento.TabIndex = 51
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(100, 190)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(77, 13)
        Me.label5.TabIndex = 50
        Me.label5.Text = "DESCUENTO:"
        '
        'txtSalario
        '
        Me.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalario.Location = New System.Drawing.Point(191, 162)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(65, 20)
        Me.txtSalario.TabIndex = 49
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(80, 164)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 13)
        Me.label4.TabIndex = 48
        Me.label4.Text = "SALARIO BRUTO:"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(147, 100)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(156, 21)
        Me.cboCategoria.TabIndex = 47
        '
        'txtHoras
        '
        Me.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoras.Location = New System.Drawing.Point(147, 76)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(65, 20)
        Me.txtHoras.TabIndex = 46
        Me.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVendedor
        '
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Location = New System.Drawing.Point(147, 44)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(157, 20)
        Me.txtVendedor.TabIndex = 45
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(52, 76)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 44
        Me.label3.Text = "HORAS TRAB:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(58, 106)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 13)
        Me.label2.TabIndex = 43
        Me.label2.Text = "CATEGORIA :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(58, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 13)
        Me.label1.TabIndex = 42
        Me.label1.Text = "VENDEDOR :"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 337)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnProceso)
        Me.Controls.Add(Me.txtNeto)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private WithEvents btnProceso As System.Windows.Forms.Button
    Private WithEvents txtNeto As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtDescuento As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtSalario As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Private WithEvents txtHoras As System.Windows.Forms.TextBox
    Private WithEvents txtVendedor As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
