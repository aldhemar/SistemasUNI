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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.dtfecnac = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.dtContrato = New System.Windows.Forms.DateTimePicker()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANTENIMIENTO DE EMPLEADOS"
        '
        'cboCargo
        '
        Me.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCargo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(446, 201)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(219, 27)
        Me.cboCargo.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "CARGO"
        '
        'cboDistrito
        '
        Me.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(445, 145)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(220, 27)
        Me.cboDistrito.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "DISTRITO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(367, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CODIGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "APELLIDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(340, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "FECHA NAC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(343, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "DIRECCION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "TELEFONO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(325, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "FECHA CONT."
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(445, 18)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(47, 14)
        Me.lblCodigo.TabIndex = 42
        Me.lblCodigo.Text = "00000"
        '
        'txtApe
        '
        Me.txtApe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe.Location = New System.Drawing.Point(445, 40)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(262, 23)
        Me.txtApe.TabIndex = 43
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(445, 65)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(262, 23)
        Me.txtNom.TabIndex = 44
        '
        'dtfecnac
        '
        Me.dtfecnac.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecnac.Location = New System.Drawing.Point(445, 91)
        Me.dtfecnac.Name = "dtfecnac"
        Me.dtfecnac.Size = New System.Drawing.Size(113, 26)
        Me.dtfecnac.TabIndex = 45
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(445, 120)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(262, 23)
        Me.txtDireccion.TabIndex = 46
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(445, 175)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(133, 23)
        Me.txtTelefono.TabIndex = 47
        '
        'dtContrato
        '
        Me.dtContrato.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtContrato.Location = New System.Drawing.Point(445, 232)
        Me.dtContrato.Name = "dtContrato"
        Me.dtContrato.Size = New System.Drawing.Size(113, 26)
        Me.dtContrato.TabIndex = 48
        '
        'dgEmpleados
        '
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 264)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(695, 234)
        Me.dgEmpleados.TabIndex = 49
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(115, 54)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(114, 32)
        Me.btnNuevo.TabIndex = 50
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(115, 88)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(114, 32)
        Me.btnGrabar.TabIndex = 51
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(115, 125)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(114, 32)
        Me.btnActualizar.TabIndex = 52
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.Location = New System.Drawing.Point(115, 163)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(114, 32)
        Me.btnBaja.TabIndex = 53
        Me.btnBaja.Text = "Dar de Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(115, 201)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 32)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 501)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.dtContrato)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.dtfecnac)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDistrito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "::::: MANTENIMIENTO DE DATOS :::"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents dtfecnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dtContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
