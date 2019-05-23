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
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstResultado = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(68, 142)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "TARIFA"
        '
        'txtTarifa
        '
        Me.txtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarifa.Location = New System.Drawing.Point(204, 138)
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(60, 22)
        Me.txtTarifa.TabIndex = 14
        '
        'txtHoras
        '
        Me.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.Location = New System.Drawing.Point(204, 99)
        Me.txtHoras.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(60, 22)
        Me.txtHoras.TabIndex = 13
        '
        'txtDNI
        '
        Me.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(204, 66)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(160, 22)
        Me.txtDNI.TabIndex = 12
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(204, 29)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(160, 22)
        Me.txtCliente.TabIndex = 11
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(68, 103)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(118, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "HORAS TRABAJADAS"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(68, 68)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "DNI"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(68, 29)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "CLIENTE"
        '
        'lstResultado
        '
        Me.lstResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.ItemHeight = 18
        Me.lstResultado.Location = New System.Drawing.Point(55, 194)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(355, 148)
        Me.lstResultado.TabIndex = 16
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(273, 367)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 28)
        Me.btnSalir.TabIndex = 59
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(175, 367)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(91, 28)
        Me.btnLimpiar.TabIndex = 58
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnProceso
        '
        Me.btnProceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceso.Location = New System.Drawing.Point(78, 367)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(91, 28)
        Me.btnProceso.TabIndex = 57
        Me.btnProceso.Text = "PROCESO"
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 407)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnProceso)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtTarifa)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtTarifa As System.Windows.Forms.TextBox
    Private WithEvents txtHoras As System.Windows.Forms.TextBox
    Private WithEvents txtDNI As System.Windows.Forms.TextBox
    Private WithEvents txtCliente As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lstResultado As System.Windows.Forms.ListBox
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private WithEvents btnProceso As System.Windows.Forms.Button
End Class
