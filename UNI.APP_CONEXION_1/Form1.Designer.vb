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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.NEGOCIOS2015DataSet = New APP_CONEXION_1.NEGOCIOS2015DataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New APP_CONEXION_1.NEGOCIOS2015DataSetTableAdapters.productosTableAdapter()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantxUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEGOCIOS2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTADO DE PRODUCTOS"
        '
        'dgProductos
        '
        Me.dgProductos.AutoGenerateColumns = False
        Me.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NomProductoDataGridViewTextBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.CantxUnidadDataGridViewTextBoxColumn, Me.PrecioUnidadDataGridViewTextBoxColumn, Me.UnidadesEnExistenciaDataGridViewTextBoxColumn, Me.UnidadesEnPedidoDataGridViewTextBoxColumn})
        Me.dgProductos.DataSource = Me.ProductosBindingSource
        Me.dgProductos.Location = New System.Drawing.Point(12, 72)
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.Size = New System.Drawing.Size(657, 277)
        Me.dgProductos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TOTAL DE PRODUCTOS :"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(607, 359)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 31)
        Me.lblTotal.TabIndex = 3
        '
        'NEGOCIOS2015DataSet
        '
        Me.NEGOCIOS2015DataSet.DataSetName = "NEGOCIOS2015DataSet"
        Me.NEGOCIOS2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.NEGOCIOS2015DataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'NomProductoDataGridViewTextBoxColumn
        '
        Me.NomProductoDataGridViewTextBoxColumn.DataPropertyName = "NomProducto"
        Me.NomProductoDataGridViewTextBoxColumn.HeaderText = "NomProducto"
        Me.NomProductoDataGridViewTextBoxColumn.Name = "NomProductoDataGridViewTextBoxColumn"
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        '
        'CantxUnidadDataGridViewTextBoxColumn
        '
        Me.CantxUnidadDataGridViewTextBoxColumn.DataPropertyName = "CantxUnidad"
        Me.CantxUnidadDataGridViewTextBoxColumn.HeaderText = "CantxUnidad"
        Me.CantxUnidadDataGridViewTextBoxColumn.Name = "CantxUnidadDataGridViewTextBoxColumn"
        '
        'PrecioUnidadDataGridViewTextBoxColumn
        '
        Me.PrecioUnidadDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.HeaderText = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.Name = "PrecioUnidadDataGridViewTextBoxColumn"
        '
        'UnidadesEnExistenciaDataGridViewTextBoxColumn
        '
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.DataPropertyName = "UnidadesEnExistencia"
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.HeaderText = "UnidadesEnExistencia"
        Me.UnidadesEnExistenciaDataGridViewTextBoxColumn.Name = "UnidadesEnExistenciaDataGridViewTextBoxColumn"
        '
        'UnidadesEnPedidoDataGridViewTextBoxColumn
        '
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.DataPropertyName = "UnidadesEnPedido"
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.HeaderText = "UnidadesEnPedido"
        Me.UnidadesEnPedidoDataGridViewTextBoxColumn.Name = "UnidadesEnPedidoDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 406)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgProductos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = ":::::: LISTADO DE PRODUCTOS :::::"
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEGOCIOS2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents NEGOCIOS2015DataSet As APP_CONEXION_1.NEGOCIOS2015DataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As APP_CONEXION_1.NEGOCIOS2015DataSetTableAdapters.productosTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantxUnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadesEnExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadesEnPedidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
