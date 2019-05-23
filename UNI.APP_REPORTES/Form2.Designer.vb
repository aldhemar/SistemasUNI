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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crvPedidos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(487, 75)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(133, 37)
        Me.btnConsultar.TabIndex = 46
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFin
        '
        Me.dtFin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(155, 98)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(113, 26)
        Me.dtFin.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "FECHA FINAL"
        '
        'dtInicio
        '
        Me.dtInicio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(155, 66)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(113, 26)
        Me.dtInicio.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "FECHA INICIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 34)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "CONSULTA DE PEDIDOS"
        '
        'crvPedidos
        '
        Me.crvPedidos.ActiveViewIndex = -1
        Me.crvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPedidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crvPedidos.Location = New System.Drawing.Point(0, 153)
        Me.crvPedidos.Name = "crvPedidos"
        Me.crvPedidos.Size = New System.Drawing.Size(924, 368)
        Me.crvPedidos.TabIndex = 47
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 521)
        Me.Controls.Add(Me.crvPedidos)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crvPedidos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
