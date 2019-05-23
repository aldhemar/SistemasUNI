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
        Me.btnUtilizar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstDatos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnUtilizar
        '
        Me.btnUtilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtilizar.Location = New System.Drawing.Point(131, 227)
        Me.btnUtilizar.Name = "btnUtilizar"
        Me.btnUtilizar.Size = New System.Drawing.Size(137, 39)
        Me.btnUtilizar.TabIndex = 17
        Me.btnUtilizar.Text = "UTILIZAR"
        Me.btnUtilizar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(169, 162)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(157, 26)
        Me.txtDireccion.TabIndex = 16
        '
        'txtEdad
        '
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(169, 126)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(65, 26)
        Me.txtEdad.TabIndex = 15
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(169, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(157, 26)
        Me.txtNombre.TabIndex = 14
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(169, 60)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(157, 26)
        Me.txtApellido.TabIndex = 13
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(42, 164)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(106, 18)
        Me.label4.TabIndex = 12
        Me.label4.Text = "DIRECCION :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(42, 131)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(58, 18)
        Me.label3.TabIndex = 11
        Me.label3.Text = "EDAD :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(42, 96)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 18)
        Me.label2.TabIndex = 10
        Me.label2.Text = "NOMBRE :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(42, 63)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(94, 18)
        Me.label1.TabIndex = 9
        Me.label1.Text = "APELLIDO :"
        '
        'lstDatos
        '
        Me.lstDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDatos.FormattingEnabled = True
        Me.lstDatos.ItemHeight = 18
        Me.lstDatos.Location = New System.Drawing.Point(366, 40)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(232, 166)
        Me.lstDatos.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 308)
        Me.Controls.Add(Me.lstDatos)
        Me.Controls.Add(Me.btnUtilizar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnUtilizar As System.Windows.Forms.Button
    Private WithEvents txtDireccion As System.Windows.Forms.TextBox
    Private WithEvents txtEdad As System.Windows.Forms.TextBox
    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents txtApellido As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lstDatos As System.Windows.Forms.ListBox

End Class
