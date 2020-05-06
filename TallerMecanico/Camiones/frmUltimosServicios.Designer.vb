<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUltimosServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUltimosServicios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMovimientos = New System.Windows.Forms.Button()
        Me.NCantidadMovimientos = New System.Windows.Forms.NumericUpDown()
        Me.TablaMovimientos = New System.Windows.Forms.DataGridView()
        Me.IdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marcado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NCantidadMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 60)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(692, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(63, 44)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 43)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Por Fechas"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(203, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMovimientos)
        Me.GroupBox1.Controls.Add(Me.NCantidadMovimientos)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Por Ultimos Movimientos"
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Image = CType(resources.GetObject("btnMovimientos.Image"), System.Drawing.Image)
        Me.btnMovimientos.Location = New System.Drawing.Point(129, 11)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Size = New System.Drawing.Size(50, 25)
        Me.btnMovimientos.TabIndex = 1
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'NCantidadMovimientos
        '
        Me.NCantidadMovimientos.Location = New System.Drawing.Point(3, 16)
        Me.NCantidadMovimientos.Name = "NCantidadMovimientos"
        Me.NCantidadMovimientos.Size = New System.Drawing.Size(120, 20)
        Me.NCantidadMovimientos.TabIndex = 0
        Me.NCantidadMovimientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NCantidadMovimientos.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'TablaMovimientos
        '
        Me.TablaMovimientos.AllowUserToAddRows = False
        Me.TablaMovimientos.AllowUserToDeleteRows = False
        Me.TablaMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle, Me.Cant, Me.Concepto, Me.FechaServicio, Me.IdInventario, Me.Marcado, Me.ATQ})
        Me.TablaMovimientos.Location = New System.Drawing.Point(12, 65)
        Me.TablaMovimientos.Name = "TablaMovimientos"
        Me.TablaMovimientos.ReadOnly = True
        Me.TablaMovimientos.Size = New System.Drawing.Size(737, 254)
        Me.TablaMovimientos.TabIndex = 1
        '
        'IdDetalle
        '
        Me.IdDetalle.HeaderText = "IdDetalle"
        Me.IdDetalle.MinimumWidth = 100
        Me.IdDetalle.Name = "IdDetalle"
        Me.IdDetalle.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cantidad"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'Concepto
        '
        Me.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Concepto.HeaderText = "Descripción / Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        '
        'FechaServicio
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaServicio.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaServicio.HeaderText = "Fecha Servicio"
        Me.FechaServicio.Name = "FechaServicio"
        Me.FechaServicio.ReadOnly = True
        '
        'IdInventario
        '
        Me.IdInventario.HeaderText = "IdInventario"
        Me.IdInventario.Name = "IdInventario"
        Me.IdInventario.ReadOnly = True
        '
        'Marcado
        '
        Me.Marcado.HeaderText = "Marcado"
        Me.Marcado.Name = "Marcado"
        Me.Marcado.ReadOnly = True
        '
        'ATQ
        '
        Me.ATQ.HeaderText = "ATQ Auto"
        Me.ATQ.Name = "ATQ"
        Me.ATQ.ReadOnly = True
        '
        'frmUltimosServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 331)
        Me.Controls.Add(Me.TablaMovimientos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUltimosServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmUltimosServicios"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NCantidadMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TablaMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovimientos As System.Windows.Forms.Button
    Friend WithEvents NCantidadMovimientos As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents IdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdInventario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marcado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATQ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
