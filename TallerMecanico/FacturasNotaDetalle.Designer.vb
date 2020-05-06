<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasNotaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturasNotaDetalle))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelFacturas = New System.Windows.Forms.Panel()
        Me.tablaFacturas = New System.Windows.Forms.DataGridView()
        Me.idfac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblfolio = New System.Windows.Forms.Label()
        Me.panel_Detalle = New System.Windows.Forms.Panel()
        Me.TablaDetalle = New System.Windows.Forms.DataGridView()
        Me.iddet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idnp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelFacturas.SuspendLayout()
        CType(Me.tablaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.panel_Detalle.SuspendLayout()
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtfolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel1.Size = New System.Drawing.Size(655, 59)
        Me.Panel1.TabIndex = 0
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(478, 9)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(129, 37)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBuscar.ForeColor = System.Drawing.Color.Blue
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(366, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 37)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtfolio
        '
        Me.txtfolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfolio.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtfolio.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolio.Location = New System.Drawing.Point(198, 9)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(168, 32)
        Me.txtfolio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Factura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para NOTA DE CREDITO"
        '
        'panelFacturas
        '
        Me.panelFacturas.Controls.Add(Me.tablaFacturas)
        Me.panelFacturas.Controls.Add(Me.Panel3)
        Me.panelFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFacturas.Location = New System.Drawing.Point(0, 59)
        Me.panelFacturas.Name = "panelFacturas"
        Me.panelFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.panelFacturas.Size = New System.Drawing.Size(655, 88)
        Me.panelFacturas.TabIndex = 1
        '
        'tablaFacturas
        '
        Me.tablaFacturas.AllowUserToAddRows = False
        Me.tablaFacturas.AllowUserToDeleteRows = False
        Me.tablaFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idfac, Me.folio, Me.total, Me.estado, Me.observ})
        Me.tablaFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaFacturas.EnableHeadersVisualStyles = False
        Me.tablaFacturas.Location = New System.Drawing.Point(3, 3)
        Me.tablaFacturas.Name = "tablaFacturas"
        Me.tablaFacturas.ReadOnly = True
        Me.tablaFacturas.RowHeadersVisible = False
        Me.tablaFacturas.Size = New System.Drawing.Size(462, 82)
        Me.tablaFacturas.TabIndex = 0
        '
        'idfac
        '
        Me.idfac.HeaderText = "id"
        Me.idfac.Name = "idfac"
        Me.idfac.ReadOnly = True
        Me.idfac.Visible = False
        '
        'folio
        '
        Me.folio.HeaderText = "folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'estado
        '
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'observ
        '
        Me.observ.HeaderText = "observ"
        Me.observ.Name = "observ"
        Me.observ.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnaceptar)
        Me.Panel3.Controls.Add(Me.lblid)
        Me.Panel3.Controls.Add(Me.lblfolio)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(465, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel3.Size = New System.Drawing.Size(187, 82)
        Me.Panel3.TabIndex = 1
        '
        'btnaceptar
        '
        Me.btnaceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaceptar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(4, 40)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(177, 36)
        Me.btnaceptar.TabIndex = 2
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblid.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(4, 22)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(177, 18)
        Me.lblid.TabIndex = 1
        Me.lblid.Text = "Clic a la factura"
        '
        'lblfolio
        '
        Me.lblfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblfolio.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolio.Location = New System.Drawing.Point(4, 4)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(177, 18)
        Me.lblfolio.TabIndex = 0
        Me.lblfolio.Text = "Seleccione una factura"
        '
        'panel_Detalle
        '
        Me.panel_Detalle.Controls.Add(Me.TablaDetalle)
        Me.panel_Detalle.Controls.Add(Me.Panel2)
        Me.panel_Detalle.Controls.Add(Me.Label4)
        Me.panel_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Detalle.Location = New System.Drawing.Point(0, 147)
        Me.panel_Detalle.Name = "panel_Detalle"
        Me.panel_Detalle.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_Detalle.Size = New System.Drawing.Size(655, 196)
        Me.panel_Detalle.TabIndex = 2
        '
        'TablaDetalle
        '
        Me.TablaDetalle.AllowUserToAddRows = False
        Me.TablaDetalle.AllowUserToDeleteRows = False
        Me.TablaDetalle.AllowUserToResizeRows = False
        Me.TablaDetalle.BackgroundColor = System.Drawing.Color.White
        Me.TablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iddet, Me.cant, Me.np, Me.desc, Me.precio, Me.agregar, Me.tipo, Me.idnp})
        Me.TablaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaDetalle.Location = New System.Drawing.Point(5, 24)
        Me.TablaDetalle.Name = "TablaDetalle"
        Me.TablaDetalle.ReadOnly = True
        Me.TablaDetalle.RowHeadersVisible = False
        Me.TablaDetalle.RowTemplate.Height = 32
        Me.TablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDetalle.Size = New System.Drawing.Size(645, 132)
        Me.TablaDetalle.TabIndex = 2
        '
        'iddet
        '
        Me.iddet.HeaderText = "iddet"
        Me.iddet.Name = "iddet"
        Me.iddet.ReadOnly = True
        Me.iddet.Width = 40
        '
        'cant
        '
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 45
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
        'precio
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'agregar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        Me.agregar.DefaultCellStyle = DataGridViewCellStyle3
        Me.agregar.HeaderText = "agregar"
        Me.agregar.Name = "agregar"
        Me.agregar.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Visible = False
        '
        'idnp
        '
        Me.idnp.HeaderText = "idnp"
        Me.idnp.Name = "idnp"
        Me.idnp.ReadOnly = True
        Me.idnp.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnListo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(645, 35)
        Me.Panel2.TabIndex = 3
        '
        'btnListo
        '
        Me.btnListo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnListo.Location = New System.Drawing.Point(542, 3)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(100, 29)
        Me.btnListo.TabIndex = 3
        Me.btnListo.Text = "Listo!"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Resultados: 0"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(645, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Detalle de factura..."
        '
        'FacturasNotaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 343)
        Me.Controls.Add(Me.panel_Detalle)
        Me.Controls.Add(Me.panelFacturas)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacturasNotaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FacturasNotaDetalle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelFacturas.ResumeLayout(False)
        CType(Me.tablaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.panel_Detalle.ResumeLayout(False)
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelFacturas As System.Windows.Forms.Panel
    Friend WithEvents tablaFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents panel_Detalle As System.Windows.Forms.Panel
    Friend WithEvents TablaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnListo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents idfac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iddet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents agregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idnp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
