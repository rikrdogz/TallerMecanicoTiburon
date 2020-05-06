<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicioAgregarSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicioAgregarSelect))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtInfoAño = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInfoModelo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInfoMarca = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tablaArticulos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnPendiente = New System.Windows.Forms.Button()
        Me.btnSININV = New System.Windows.Forms.Button()
        Me.btnMano = New System.Windows.Forms.Button()
        Me.ventana = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.NCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblarticulos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tablaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.NCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtInfoAño)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtInfoModelo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtInfoMarca)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbltipo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel1.Size = New System.Drawing.Size(1221, 51)
        Me.Panel1.TabIndex = 10
        '
        'txtInfoAño
        '
        Me.txtInfoAño.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtInfoAño.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoAño.Location = New System.Drawing.Point(779, 7)
        Me.txtInfoAño.Name = "txtInfoAño"
        Me.txtInfoAño.Size = New System.Drawing.Size(67, 30)
        Me.txtInfoAño.TabIndex = 18
        Me.txtInfoAño.TabStop = False
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(732, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 33)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Año:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInfoModelo
        '
        Me.txtInfoModelo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtInfoModelo.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoModelo.Location = New System.Drawing.Point(632, 7)
        Me.txtInfoModelo.Name = "txtInfoModelo"
        Me.txtInfoModelo.Size = New System.Drawing.Size(100, 30)
        Me.txtInfoModelo.TabIndex = 16
        Me.txtInfoModelo.TabStop = False
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(558, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 33)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Modelo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInfoMarca
        '
        Me.txtInfoMarca.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtInfoMarca.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoMarca.Location = New System.Drawing.Point(458, 7)
        Me.txtInfoMarca.Name = "txtInfoMarca"
        Me.txtInfoMarca.Size = New System.Drawing.Size(100, 30)
        Me.txtInfoMarca.TabIndex = 14
        Me.txtInfoMarca.TabStop = False
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(409, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 33)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Marca:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltipo
        '
        Me.lbltipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltipo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltipo.Location = New System.Drawing.Point(316, 7)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(93, 33)
        Me.lbltipo.TabIndex = 12
        Me.lbltipo.Text = "TIPO:"
        Me.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(263, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 33)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TIPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1147, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(63, 33)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione un Articulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel2.Size = New System.Drawing.Size(1221, 368)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.tablaArticulos)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(7, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel3.Size = New System.Drawing.Size(1205, 352)
        Me.Panel3.TabIndex = 0
        '
        'tablaArticulos
        '
        Me.tablaArticulos.AllowUserToAddRows = False
        Me.tablaArticulos.AllowUserToDeleteRows = False
        Me.tablaArticulos.AllowUserToResizeRows = False
        Me.tablaArticulos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tablaArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.np, Me.desc, Me.marca, Me.modelo, Me.año, Me.TIPO, Me.id_inv, Me.costo, Me.mano, Me.precio, Me.inv})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaArticulos.DefaultCellStyle = DataGridViewCellStyle8
        Me.tablaArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaArticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tablaArticulos.Location = New System.Drawing.Point(8, 47)
        Me.tablaArticulos.Name = "tablaArticulos"
        Me.tablaArticulos.ReadOnly = True
        Me.tablaArticulos.RowHeadersVisible = False
        Me.tablaArticulos.RowTemplate.Height = 29
        Me.tablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaArticulos.Size = New System.Drawing.Size(1189, 248)
        Me.tablaArticulos.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 40
        '
        'np
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.np.DefaultCellStyle = DataGridViewCellStyle1
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        Me.np.ReadOnly = True
        Me.np.Width = 200
        '
        'desc
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc.DefaultCellStyle = DataGridViewCellStyle2
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.Width = 340
        '
        'marca
        '
        Me.marca.HeaderText = "marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 75
        '
        'modelo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelo.DefaultCellStyle = DataGridViewCellStyle3
        Me.modelo.HeaderText = "modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'año
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.año.DefaultCellStyle = DataGridViewCellStyle4
        Me.año.HeaderText = "año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        Me.año.Width = 85
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 75
        '
        'id_inv
        '
        Me.id_inv.HeaderText = "id_inv"
        Me.id_inv.Name = "id_inv"
        Me.id_inv.ReadOnly = True
        Me.id_inv.Visible = False
        Me.id_inv.Width = 50
        '
        'costo
        '
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 75
        '
        'mano
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.mano.DefaultCellStyle = DataGridViewCellStyle5
        Me.mano.HeaderText = "mano"
        Me.mano.Name = "mano"
        Me.mano.ReadOnly = True
        Me.mano.Width = 75
        '
        'precio
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 95
        '
        'inv
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Navy
        Me.inv.DefaultCellStyle = DataGridViewCellStyle7
        Me.inv.HeaderText = "inv"
        Me.inv.Name = "inv"
        Me.inv.ReadOnly = True
        Me.inv.Width = 50
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.BtnPendiente)
        Me.Panel5.Controls.Add(Me.btnSININV)
        Me.Panel5.Controls.Add(Me.btnMano)
        Me.Panel5.Controls.Add(Me.ventana)
        Me.Panel5.Controls.Add(Me.btnSeleccionar)
        Me.Panel5.Controls.Add(Me.NCantidad)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.lblarticulos)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(8, 295)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(1189, 49)
        Me.Panel5.TabIndex = 1
        '
        'BtnPendiente
        '
        Me.BtnPendiente.BackColor = System.Drawing.Color.White
        Me.BtnPendiente.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPendiente.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPendiente.Image = CType(resources.GetObject("BtnPendiente.Image"), System.Drawing.Image)
        Me.BtnPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPendiente.Location = New System.Drawing.Point(962, 5)
        Me.BtnPendiente.Name = "BtnPendiente"
        Me.BtnPendiente.Size = New System.Drawing.Size(151, 35)
        Me.BtnPendiente.TabIndex = 6
        Me.BtnPendiente.Text = "PENDIENTE"
        Me.BtnPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPendiente.UseVisualStyleBackColor = False
        '
        'btnSININV
        '
        Me.btnSININV.BackColor = System.Drawing.Color.White
        Me.btnSININV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSININV.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSININV.Image = CType(resources.GetObject("btnSININV.Image"), System.Drawing.Image)
        Me.btnSININV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSININV.Location = New System.Drawing.Point(695, 5)
        Me.btnSININV.Name = "btnSININV"
        Me.btnSININV.Size = New System.Drawing.Size(267, 35)
        Me.btnSININV.TabIndex = 5
        Me.btnSININV.Text = "REAL Sin Inventario"
        Me.btnSININV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSININV.UseVisualStyleBackColor = False
        '
        'btnMano
        '
        Me.btnMano.BackColor = System.Drawing.Color.White
        Me.btnMano.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMano.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMano.Image = CType(resources.GetObject("btnMano.Image"), System.Drawing.Image)
        Me.btnMano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMano.Location = New System.Drawing.Point(639, 5)
        Me.btnMano.Name = "btnMano"
        Me.btnMano.Size = New System.Drawing.Size(56, 35)
        Me.btnMano.TabIndex = 4
        Me.btnMano.Text = "Solo mano"
        Me.btnMano.UseVisualStyleBackColor = False
        Me.btnMano.Visible = False
        '
        'ventana
        '
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Left
        Me.ventana.Location = New System.Drawing.Point(616, 5)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(23, 35)
        Me.ventana.TabIndex = 5
        Me.ventana.Text = "ventana"
        Me.ventana.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ventana.Visible = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSeleccionar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionar.Location = New System.Drawing.Point(388, 5)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(228, 35)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "Con Inventario"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'NCantidad
        '
        Me.NCantidad.Dock = System.Windows.Forms.DockStyle.Left
        Me.NCantidad.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCantidad.Location = New System.Drawing.Point(271, 5)
        Me.NCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NCantidad.Name = "NCantidad"
        Me.NCantidad.Size = New System.Drawing.Size(117, 32)
        Me.NCantidad.TabIndex = 10
        Me.NCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(159, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 35)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Cantidad:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblarticulos
        '
        Me.lblarticulos.BackColor = System.Drawing.Color.White
        Me.lblarticulos.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblarticulos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarticulos.Location = New System.Drawing.Point(72, 5)
        Me.lblarticulos.Name = "lblarticulos"
        Me.lblarticulos.Size = New System.Drawing.Size(87, 35)
        Me.lblarticulos.TabIndex = 2
        Me.lblarticulos.Text = "0"
        Me.lblarticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 35)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Resultados:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtAño)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtmodelo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtMarca)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtdesc)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtNP)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(1189, 39)
        Me.Panel4.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(962, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtAño
        '
        Me.txtAño.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtAño.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(885, 3)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(77, 29)
        Me.txtAño.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Location = New System.Drawing.Point(818, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Año:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmodelo
        '
        Me.txtmodelo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtmodelo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.Location = New System.Drawing.Point(706, 3)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(112, 29)
        Me.txtmodelo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(639, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Modelo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMarca
        '
        Me.txtMarca.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(515, 3)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(124, 29)
        Me.txtMarca.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(461, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdesc
        '
        Me.txtdesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtdesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(247, 3)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(214, 29)
        Me.txtdesc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(193, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESC:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNP
        '
        Me.txtNP.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNP.Location = New System.Drawing.Point(47, 3)
        Me.txtNP.Name = "txtNP"
        Me.txtNP.Size = New System.Drawing.Size(146, 29)
        Me.txtNP.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "NP:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmServicioAgregarSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 419)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmServicioAgregarSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServicioAgregarSelect"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.tablaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.NCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInfoAño As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtInfoModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInfoMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tablaArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblarticulos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents NCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents ventana As System.Windows.Forms.Label
    Friend WithEvents btnMano As System.Windows.Forms.Button
    Friend WithEvents btnSININV As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnPendiente As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
