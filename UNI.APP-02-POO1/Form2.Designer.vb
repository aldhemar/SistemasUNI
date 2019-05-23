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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnOperaciones = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(45, 251)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(152, 32)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(45, 213)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(152, 32)
        Me.btnLimpiar.TabIndex = 35
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnOperaciones
        '
        Me.btnOperaciones.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperaciones.Location = New System.Drawing.Point(44, 175)
        Me.btnOperaciones.Name = "btnOperaciones"
        Me.btnOperaciones.Size = New System.Drawing.Size(152, 32)
        Me.btnOperaciones.TabIndex = 34
        Me.btnOperaciones.Text = "OPERACIONES"
        Me.btnOperaciones.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(317, 251)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(79, 26)
        Me.txtTotal.TabIndex = 33
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(232, 258)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(50, 18)
        Me.label6.TabIndex = 32
        Me.label6.Text = "TOTAL:"
        '
        'txtIgv
        '
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(317, 219)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(79, 26)
        Me.txtIgv.TabIndex = 31
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(232, 224)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(38, 18)
        Me.label5.TabIndex = 30
        Me.label5.Text = "IGV: "
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(317, 184)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(79, 26)
        Me.txtSubTotal.TabIndex = 29
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(232, 189)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 18)
        Me.label4.TabIndex = 28
        Me.label4.Text = "SUBTOTAL :"
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(135, 110)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 26)
        Me.txtCantidad.TabIndex = 27
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio
        '
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(135, 78)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(65, 26)
        Me.txtPrecio.TabIndex = 26
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(135, 44)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(261, 26)
        Me.txtProducto.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(46, 115)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 18)
        Me.label3.TabIndex = 24
        Me.label3.Text = "CANTIDAD :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(46, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 18)
        Me.label2.TabIndex = 23
        Me.label2.Text = "PRECIO :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(46, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 18)
        Me.label1.TabIndex = 22
        Me.label1.Text = "PRODUCTO :"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 326)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnOperaciones)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private WithEvents btnOperaciones As System.Windows.Forms.Button
    Private WithEvents txtTotal As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtIgv As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents txtPrecio As System.Windows.Forms.TextBox
    Private WithEvents txtProducto As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
