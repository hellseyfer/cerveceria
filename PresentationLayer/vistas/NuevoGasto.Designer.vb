<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoGasto
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
        Me.DPfechaGasto = New System.Windows.Forms.DateTimePicker()
        Me.CBesmensual = New System.Windows.Forms.CheckBox()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.NMonto = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        CType(Me.NMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DPfechaGasto
        '
        Me.DPfechaGasto.Location = New System.Drawing.Point(116, 39)
        Me.DPfechaGasto.Name = "DPfechaGasto"
        Me.DPfechaGasto.Size = New System.Drawing.Size(200, 20)
        Me.DPfechaGasto.TabIndex = 0
        '
        'CBesmensual
        '
        Me.CBesmensual.AutoSize = True
        Me.CBesmensual.Location = New System.Drawing.Point(116, 78)
        Me.CBesmensual.Name = "CBesmensual"
        Me.CBesmensual.Size = New System.Drawing.Size(80, 17)
        Me.CBesmensual.TabIndex = 1
        Me.CBesmensual.Text = "Es mensual"
        Me.CBesmensual.UseVisualStyleBackColor = True
        '
        'TBDesc
        '
        Me.TBDesc.Location = New System.Drawing.Point(116, 151)
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Size = New System.Drawing.Size(200, 20)
        Me.TBDesc.TabIndex = 3
        '
        'NMonto
        '
        Me.NMonto.Location = New System.Drawing.Point(116, 112)
        Me.NMonto.Name = "NMonto"
        Me.NMonto.Size = New System.Drawing.Size(120, 20)
        Me.NMonto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripcion"
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(152, 206)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 8
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'NuevoGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 270)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NMonto)
        Me.Controls.Add(Me.TBDesc)
        Me.Controls.Add(Me.CBesmensual)
        Me.Controls.Add(Me.DPfechaGasto)
        Me.Name = "NuevoGasto"
        Me.Text = "NuevoGasto"
        CType(Me.NMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DPfechaGasto As Windows.Forms.DateTimePicker
    Friend WithEvents CBesmensual As Windows.Forms.CheckBox
    Friend WithEvents TBDesc As Windows.Forms.TextBox
    Friend WithEvents NMonto As Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents BGuardar As Windows.Forms.Button
End Class
