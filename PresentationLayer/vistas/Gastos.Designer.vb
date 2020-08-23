<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BNuevoGasto = New System.Windows.Forms.Button()
        Me.DGgastos = New System.Windows.Forms.DataGridView()
        Me.CerveceriaDataSet1 = New PresentationLayer.CerveceriaDataSet()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosTableAdapter1 = New PresentationLayer.CerveceriaDataSetTableAdapters.GastosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGgastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CerveceriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGgastos)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'BNuevoGasto
        '
        Me.BNuevoGasto.Location = New System.Drawing.Point(594, 426)
        Me.BNuevoGasto.Name = "BNuevoGasto"
        Me.BNuevoGasto.Size = New System.Drawing.Size(75, 23)
        Me.BNuevoGasto.TabIndex = 1
        Me.BNuevoGasto.Text = "Nuevo"
        Me.BNuevoGasto.UseVisualStyleBackColor = True
        '
        'DGgastos
        '
        Me.DGgastos.AutoGenerateColumns = False
        Me.DGgastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGgastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DescripDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4})
        Me.DGgastos.DataSource = Me.GastosBindingSource
        Me.DGgastos.Location = New System.Drawing.Point(39, 49)
        Me.DGgastos.Name = "DGgastos"
        Me.DGgastos.Size = New System.Drawing.Size(574, 296)
        Me.DGgastos.TabIndex = 0
        '
        'CerveceriaDataSet1
        '
        Me.CerveceriaDataSet1.DataSetName = "CerveceriaDataSet"
        Me.CerveceriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "Gastos"
        Me.GastosBindingSource.DataSource = Me.CerveceriaDataSet1
        '
        'GastosTableAdapter1
        '
        Me.GastosTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha_ini"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha_ini"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "esmensual"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "esmensual"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DescripDataGridViewTextBoxColumn
        '
        Me.DescripDataGridViewTextBoxColumn.DataPropertyName = "descrip"
        Me.DescripDataGridViewTextBoxColumn.HeaderText = "descrip"
        Me.DescripDataGridViewTextBoxColumn.Name = "DescripDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fk_nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fk_nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BNuevoGasto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Gastos"
        Me.Text = "Gastos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGgastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CerveceriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents IdDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsmensualDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FknombreDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BNuevoGasto As Windows.Forms.Button
    Friend WithEvents CerveceriaDataSet As CerveceriaDataSet
    Friend WithEvents GastosTableAdapter As CerveceriaDataSetTableAdapters.GastosTableAdapter
    Friend WithEvents DGgastos As Windows.Forms.DataGridView
    Friend WithEvents CerveceriaDataSet1 As CerveceriaDataSet
    Friend WithEvents GastosBindingSource As Windows.Forms.BindingSource
    Friend WithEvents GastosTableAdapter1 As CerveceriaDataSetTableAdapters.GastosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Windows.Forms.DataGridViewTextBoxColumn
End Class
