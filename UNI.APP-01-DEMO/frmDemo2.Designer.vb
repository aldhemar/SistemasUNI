<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo2
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
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.txtCopia = New System.Windows.Forms.TextBox()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.txtn3 = New System.Windows.Forms.TextBox()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDato
        '
        Me.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDato.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.Location = New System.Drawing.Point(35, 22)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(253, 26)
        Me.txtDato.TabIndex = 10
        '
        'txtCopia
        '
        Me.txtCopia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopia.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopia.Location = New System.Drawing.Point(35, 64)
        Me.txtCopia.Name = "txtCopia"
        Me.txtCopia.Size = New System.Drawing.Size(253, 26)
        Me.txtCopia.TabIndex = 11
        '
        'txtn1
        '
        Me.txtn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtn1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtn1.Location = New System.Drawing.Point(35, 131)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(83, 26)
        Me.txtn1.TabIndex = 0
        '
        'txtn2
        '
        Me.txtn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtn2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtn2.Location = New System.Drawing.Point(35, 163)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(83, 26)
        Me.txtn2.TabIndex = 1
        '
        'txtn3
        '
        Me.txtn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtn3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtn3.Location = New System.Drawing.Point(35, 195)
        Me.txtn3.Name = "txtn3"
        Me.txtn3.Size = New System.Drawing.Size(83, 26)
        Me.txtn3.TabIndex = 2
        '
        'txtPromedio
        '
        Me.txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPromedio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromedio.Location = New System.Drawing.Point(35, 234)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(83, 26)
        Me.txtPromedio.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(274, 304)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 34)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(148, 304)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(98, 34)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(20, 304)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(98, 34)
        Me.btnProcesar.TabIndex = 8
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'frmDemo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 360)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.txtn3)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.txtCopia)
        Me.Controls.Add(Me.txtDato)
        Me.Name = "frmDemo2"
        Me.Text = "APLICACIONES WINDOWS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents txtCopia As System.Windows.Forms.TextBox
    Friend WithEvents txtn1 As System.Windows.Forms.TextBox
    Friend WithEvents txtn2 As System.Windows.Forms.TextBox
    Friend WithEvents txtn3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPromedio As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
End Class
