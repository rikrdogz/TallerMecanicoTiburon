<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas_INV
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas_INV))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblidfac = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfolio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabla_detalle = New System.Windows.Forms.DataGridView()
        Me.id_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnaplicar = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnINV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.tabla_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblid_proveedor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblestado)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblproveedor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblidfac)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblfolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(943, 45)
        Me.Panel1.TabIndex = 0
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblid_proveedor.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_proveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblid_proveedor.Location = New System.Drawing.Point(788, 5)
        Me.lblid_proveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(20, 22)
        Me.lblid_proveedor.TabIndex = 9
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(654, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.Label5.Size = New System.Drawing.Size(134, 35)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID Proveedor:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblestado.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblestado.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblestado.Location = New System.Drawing.Point(629, 5)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(25, 28)
        Me.lblestado.TabIndex = 4
        Me.lblestado.Text = "0"
        Me.lblestado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(549, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.Label4.Size = New System.Drawing.Size(80, 35)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblproveedor
        '
        Me.lblproveedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblproveedor.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor.Location = New System.Drawing.Point(403, 5)
        Me.lblproveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(146, 33)
        Me.lblproveedor.TabIndex = 3
        Me.lblproveedor.Text = "0"
        Me.lblproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(296, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.Label3.Size = New System.Drawing.Size(107, 35)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Proveedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblidfac
        '
        Me.lblidfac.AutoSize = True
        Me.lblidfac.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblidfac.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidfac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblidfac.Location = New System.Drawing.Point(276, 5)
        Me.lblidfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidfac.Name = "lblidfac"
        Me.lblidfac.Size = New System.Drawing.Size(20, 22)
        Me.lblidfac.TabIndex = 2
        Me.lblidfac.Text = "0"
        Me.lblidfac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(196, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.Label2.Size = New System.Drawing.Size(80, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID Fac:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfolio
        '
        Me.lblfolio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblfolio.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfolio.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolio.Location = New System.Drawing.Point(50, 5)
        Me.lblfolio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(146, 33)
        Me.lblfolio.TabIndex = 1
        Me.lblfolio.Text = "0"
        Me.lblfolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.Label1.Size = New System.Drawing.Size(45, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FAC:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabla_detalle
        '
        Me.tabla_detalle.AllowUserToAddRows = False
        Me.tabla_detalle.AllowUserToDeleteRows = False
        Me.tabla_detalle.AllowUserToResizeRows = False
        Me.tabla_detalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabla_detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabla_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_det, Me.cantidad, Me.np, Me.desc, Me.costo, Me.id_np})
        Me.tabla_detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabla_detalle.Location = New System.Drawing.Point(0, 45)
        Me.tabla_detalle.MultiSelect = False
        Me.tabla_detalle.Name = "tabla_detalle"
        Me.tabla_detalle.ReadOnly = True
        Me.tabla_detalle.RowHeadersVisible = False
        Me.tabla_detalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tabla_detalle.RowTemplate.Height = 38
        Me.tabla_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_detalle.Size = New System.Drawing.Size(751, 297)
        Me.tabla_detalle.TabIndex = 1
        '
        'id_det
        '
        Me.id_det.HeaderText = "id"
        Me.id_det.Name = "id_det"
        Me.id_det.ReadOnly = True
        Me.id_det.Width = 35
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cant"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 50
        '
        'np
        '
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        Me.np.ReadOnly = True
        '
        'desc
        '
        Me.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'costo
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 150
        '
        'id_np
        '
        Me.id_np.HeaderText = "id_np"
        Me.id_np.Name = "id_np"
        Me.id_np.ReadOnly = True
        Me.id_np.Width = 70
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnaplicar)
        Me.Panel2.Controls.Add(Me.lblresultado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Panel2.Size = New System.Drawing.Size(943, 53)
        Me.Panel2.TabIndex = 2
        '
        'btnaplicar
        '
        Me.btnaplicar.BackColor = System.Drawing.Color.White
        Me.btnaplicar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnaplicar.Image = CType(resources.GetObject("btnaplicar.Image"), System.Drawing.Image)
        Me.btnaplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaplicar.Location = New System.Drawing.Point(724, 0)
        Me.btnaplicar.Name = "btnaplicar"
        Me.btnaplicar.Size = New System.Drawing.Size(207, 49)
        Me.btnaplicar.TabIndex = 1
        Me.btnaplicar.Text = "Guardar y aplicar Inventario"
        Me.btnaplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaplicar.UseVisualStyleBackColor = False
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(0, 0)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(117, 19)
        Me.lblresultado.TabIndex = 0
        Me.lblresultado.Text = "resultado: 0"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnINV)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(751, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(192, 297)
        Me.Panel3.TabIndex = 3
        '
        'btnINV
        '
        Me.btnINV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnINV.Image = CType(resources.GetObject("btnINV.Image"), System.Drawing.Image)
        Me.btnINV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnINV.Location = New System.Drawing.Point(5, 5)
        Me.btnINV.Name = "btnINV"
        Me.btnINV.Size = New System.Drawing.Size(182, 62)
        Me.btnINV.TabIndex = 0
        Me.btnINV.Text = "Selecccionar Invetario"
        Me.btnINV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnINV.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(5, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 104)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "La cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccionada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "será  solo 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por unidad (1x1)"
        '
        'Facturas_INV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 395)
        Me.Controls.Add(Me.tabla_detalle)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Facturas_INV"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Facturas_INV"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabla_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabla_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents lblidfac As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents btnaplicar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnINV As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_det As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
