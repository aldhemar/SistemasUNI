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
        Me.components = New System.ComponentModel.Container()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FonoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NEGOCIOS2015DataSet1 = New APP_CONEXION_1.NEGOCIOS2015DataSet1()
        Me.ClientesTableAdapter = New APP_CONEXION_1.NEGOCIOS2015DataSet1TableAdapters.clientesTableAdapter()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEGOCIOS2015DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(658, 398)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 31)
        Me.lblTotal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TOTAL DE CLIENTES :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LISTADO DE CLIENTES"
        '
        'dgClientes
        '
        Me.dgClientes.AutoGenerateColumns = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NomClienteDataGridViewTextBoxColumn, Me.DirClienteDataGridViewTextBoxColumn, Me.IdpaisDataGridViewTextBoxColumn, Me.FonoClienteDataGridViewTextBoxColumn})
        Me.dgClientes.DataSource = Me.ClientesBindingSource
        Me.dgClientes.Location = New System.Drawing.Point(4, 62)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(709, 321)
        Me.dgClientes.TabIndex = 7
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        '
        'NomClienteDataGridViewTextBoxColumn
        '
        Me.NomClienteDataGridViewTextBoxColumn.DataPropertyName = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn.HeaderText = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn.Name = "NomClienteDataGridViewTextBoxColumn"
        '
        'DirClienteDataGridViewTextBoxColumn
        '
        Me.DirClienteDataGridViewTextBoxColumn.DataPropertyName = "DirCliente"
        Me.DirClienteDataGridViewTextBoxColumn.HeaderText = "DirCliente"
        Me.DirClienteDataGridViewTextBoxColumn.Name = "DirClienteDataGridViewTextBoxColumn"
        '
        'IdpaisDataGridViewTextBoxColumn
        '
        Me.IdpaisDataGridViewTextBoxColumn.DataPropertyName = "idpais"
        Me.IdpaisDataGridViewTextBoxColumn.HeaderText = "idpais"
        Me.IdpaisDataGridViewTextBoxColumn.Name = "IdpaisDataGridViewTextBoxColumn"
        '
        'FonoClienteDataGridViewTextBoxColumn
        '
        Me.FonoClienteDataGridViewTextBoxColumn.DataPropertyName = "fonoCliente"
        Me.FonoClienteDataGridViewTextBoxColumn.HeaderText = "fonoCliente"
        Me.FonoClienteDataGridViewTextBoxColumn.Name = "FonoClienteDataGridViewTextBoxColumn"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.NEGOCIOS2015DataSet1
        '
        'NEGOCIOS2015DataSet1
        '
        Me.NEGOCIOS2015DataSet1.DataSetName = "NEGOCIOS2015DataSet1"
        Me.NEGOCIOS2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 445)
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "CLIENTES"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEGOCIOS2015DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents NEGOCIOS2015DataSet1 As APP_CONEXION_1.NEGOCIOS2015DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As APP_CONEXION_1.NEGOCIOS2015DataSet1TableAdapters.clientesTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FonoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
