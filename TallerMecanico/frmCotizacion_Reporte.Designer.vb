<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion_Reporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaCOT = New System.Windows.Forms.DataGridView()
        Me.COT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLSUMA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPendiente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lble = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblanexado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblagregado = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblreal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.tablaCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de cotizaciones pendientes de pago"
        '
        'tablaCOT
        '
        Me.tablaCOT.AllowUserToAddRows = False
        Me.tablaCOT.AllowUserToDeleteRows = False
        Me.tablaCOT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tablaCOT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tablaCOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaCOT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COT, Me.CANT, Me.DESC, Me.PRECIO, Me.IMPORTE, Me.MARCADO, Me.TOTAL})
        Me.tablaCOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaCOT.Location = New System.Drawing.Point(6, 55)
        Me.tablaCOT.Name = "tablaCOT"
        Me.tablaCOT.ReadOnly = True
        Me.tablaCOT.RowHeadersVisible = False
        Me.tablaCOT.Size = New System.Drawing.Size(808, 236)
        Me.tablaCOT.TabIndex = 1
        '
        'COT
        '
        Me.COT.HeaderText = "COT"
        Me.COT.Name = "COT"
        Me.COT.ReadOnly = True
        Me.COT.Width = 75
        '
        'CANT
        '
        Me.CANT.HeaderText = "CANT"
        Me.CANT.Name = "CANT"
        Me.CANT.ReadOnly = True
        Me.CANT.Width = 50
        '
        'DESC
        '
        Me.DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESC.HeaderText = "DESC"
        Me.DESC.Name = "DESC"
        Me.DESC.ReadOnly = True
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        Me.PRECIO.Width = 85
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        '
        'MARCADO
        '
        Me.MARCADO.HeaderText = "MARCADO"
        Me.MARCADO.Name = "MARCADO"
        Me.MARCADO.ReadOnly = True
        '
        'TOTAL
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle1
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LBLSUMA)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblPendiente)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblF)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lble)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(6, 320)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 2, 1, 1)
        Me.Panel2.Size = New System.Drawing.Size(808, 29)
        Me.Panel2.TabIndex = 2
        '
        'LBLSUMA
        '
        Me.LBLSUMA.AutoSize = True
        Me.LBLSUMA.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBLSUMA.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUMA.Location = New System.Drawing.Point(430, 2)
        Me.LBLSUMA.Name = "LBLSUMA"
        Me.LBLSUMA.Size = New System.Drawing.Size(20, 22)
        Me.LBLSUMA.TabIndex = 9
        Me.LBLSUMA.Text = "0"
        Me.LBLSUMA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(336, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SUMA TOTAL:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPendiente
        '
        Me.lblPendiente.AutoSize = True
        Me.lblPendiente.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPendiente.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendiente.Location = New System.Drawing.Point(318, 2)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(18, 19)
        Me.lblPendiente.TabIndex = 7
        Me.lblPendiente.Text = "0"
        Me.lblPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Location = New System.Drawing.Point(190, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "suma Pendiente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblF.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(172, 2)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(18, 19)
        Me.lblF.TabIndex = 5
        Me.lblF.Text = "0"
        Me.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(96, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "suma F:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lble
        '
        Me.lble.AutoSize = True
        Me.lble.Dock = System.Windows.Forms.DockStyle.Left
        Me.lble.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lble.Location = New System.Drawing.Point(78, 2)
        Me.lble.Name = "lble"
        Me.lble.Size = New System.Drawing.Size(18, 19)
        Me.lble.TabIndex = 3
        Me.lble.Text = "0"
        Me.lble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suma E:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblanexado)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblagregado)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lblreal)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lblCount)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(6, 291)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2, 2, 1, 1)
        Me.Panel3.Size = New System.Drawing.Size(808, 29)
        Me.Panel3.TabIndex = 3
        '
        'lblanexado
        '
        Me.lblanexado.AutoSize = True
        Me.lblanexado.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblanexado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanexado.Location = New System.Drawing.Point(423, 2)
        Me.lblanexado.Name = "lblanexado"
        Me.lblanexado.Size = New System.Drawing.Size(18, 19)
        Me.lblanexado.TabIndex = 7
        Me.lblanexado.Text = "0"
        Me.lblanexado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Location = New System.Drawing.Point(338, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "ANEXADO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblagregado
        '
        Me.lblagregado.AutoSize = True
        Me.lblagregado.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblagregado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagregado.Location = New System.Drawing.Point(320, 2)
        Me.lblagregado.Name = "lblagregado"
        Me.lblagregado.Size = New System.Drawing.Size(18, 19)
        Me.lblagregado.TabIndex = 5
        Me.lblagregado.Text = "0"
        Me.lblagregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(235, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 26)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "AGREGADO:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblreal
        '
        Me.lblreal.AutoSize = True
        Me.lblreal.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblreal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreal.Location = New System.Drawing.Point(217, 2)
        Me.lblreal.Name = "lblreal"
        Me.lblreal.Size = New System.Drawing.Size(18, 19)
        Me.lblreal.TabIndex = 3
        Me.lblreal.Text = "0"
        Me.lblreal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Location = New System.Drawing.Point(132, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 26)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Suma Real:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCount
        '
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCount.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(79, 2)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(53, 26)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Location = New System.Drawing.Point(2, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 26)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Resultado:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCotizacion_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 355)
        Me.Controls.Add(Me.tablaCOT)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCotizacion_Reporte"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Text = "frmCotizacion_Reporte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablaCOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tablaCOT As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lble As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents COT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblPendiente As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblF As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblanexado As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblagregado As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblreal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLSUMA As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
