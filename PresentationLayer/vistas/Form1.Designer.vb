<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FklevaduraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGcervezas = New System.Windows.Forms.DataGridView()
        Me.CerveceriaDataSet1 = New PresentationLayer.CerveceriaDataSet()
        Me.CervezasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CervezasTableAdapter1 = New PresentationLayer.CerveceriaDataSetTableAdapters.CervezasTableAdapter()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FklevaduraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGcervezas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CerveceriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CervezasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cervezas"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DescDataGridViewTextBoxColumn
        '
        Me.DescDataGridViewTextBoxColumn.Name = "DescDataGridViewTextBoxColumn"
        '
        'FklevaduraDataGridViewTextBoxColumn
        '
        Me.FklevaduraDataGridViewTextBoxColumn.Name = "FklevaduraDataGridViewTextBoxColumn"
        '
        'DGcervezas
        '
        Me.DGcervezas.AutoGenerateColumns = False
        Me.DGcervezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcervezas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.DescripDataGridViewTextBoxColumn, Me.FklevaduraDataGridViewTextBoxColumn1})
        Me.DGcervezas.DataSource = Me.CervezasBindingSource
        Me.DGcervezas.Location = New System.Drawing.Point(290, 65)
        Me.DGcervezas.Name = "DGcervezas"
        Me.DGcervezas.Size = New System.Drawing.Size(444, 224)
        Me.DGcervezas.TabIndex = 1
        '
        'CerveceriaDataSet1
        '
        Me.CerveceriaDataSet1.DataSetName = "CerveceriaDataSet"
        Me.CerveceriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CervezasBindingSource
        '
        Me.CervezasBindingSource.DataMember = "Cervezas"
        Me.CervezasBindingSource.DataSource = Me.CerveceriaDataSet1
        '
        'CervezasTableAdapter1
        '
        Me.CervezasTableAdapter1.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescripDataGridViewTextBoxColumn
        '
        Me.DescripDataGridViewTextBoxColumn.DataPropertyName = "descrip"
        Me.DescripDataGridViewTextBoxColumn.HeaderText = "descrip"
        Me.DescripDataGridViewTextBoxColumn.Name = "DescripDataGridViewTextBoxColumn"
        '
        'FklevaduraDataGridViewTextBoxColumn1
        '
        Me.FklevaduraDataGridViewTextBoxColumn1.DataPropertyName = "fk_levadura"
        Me.FklevaduraDataGridViewTextBoxColumn1.HeaderText = "fk_levadura"
        Me.FklevaduraDataGridViewTextBoxColumn1.Name = "FklevaduraDataGridViewTextBoxColumn1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 488)
        Me.Controls.Add(Me.DGcervezas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGcervezas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CerveceriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CervezasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CerveceriaDataSet As CerveceriaDataSet
    Friend WithEvents CervezasTableAdapter As CerveceriaDataSetTableAdapters.CervezasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FklevaduraDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGcervezas As Windows.Forms.DataGridView
    Friend WithEvents CerveceriaDataSet1 As CerveceriaDataSet
    Friend WithEvents CervezasBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CervezasTableAdapter1 As CerveceriaDataSetTableAdapters.CervezasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FklevaduraDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
End Class
