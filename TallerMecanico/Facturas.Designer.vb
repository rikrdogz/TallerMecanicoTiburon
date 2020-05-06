<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Mover = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrupoPanel = New System.Windows.Forms.Panel()
        Me.DetalleFactPanel = New System.Windows.Forms.Panel()
        Me.TablaDetalle = New System.Windows.Forms.DataGridView()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iddet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbldetalle = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me._pagos = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblmetodo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnINV = New System.Windows.Forms.Button()
        Me.FolioPanel = New System.Windows.Forms.Panel()
        Me.TablaFacturas = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheNA = New System.Windows.Forms.CheckBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRefa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.NMax = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFolios = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Obser_Panel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnNota = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelarFAC = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Refa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrupoPanel.SuspendLayout()
        Me.DetalleFactPanel.SuspendLayout()
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me._pagos.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.FolioPanel.SuspendLayout()
        CType(Me.TablaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.NMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Obser_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(5, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(1299, 47)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Mover)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(163, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.Panel2.Size = New System.Drawing.Size(380, 39)
        Me.Panel2.TabIndex = 4
        '
        'Mover
        '
        Me.Mover.BackColor = System.Drawing.Color.White
        Me.Mover.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mover.Image = CType(resources.GetObject("Mover.Image"), System.Drawing.Image)
        Me.Mover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mover.Location = New System.Drawing.Point(4, 1)
        Me.Mover.Name = "Mover"
        Me.Mover.Size = New System.Drawing.Size(108, 35)
        Me.Mover.TabIndex = 6
        Me.Mover.TabStop = False
        Me.Mover.Text = "Seleccion"
        Me.Mover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Mover.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1232, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrupoPanel
        '
        Me.GrupoPanel.BackColor = System.Drawing.Color.Transparent
        Me.GrupoPanel.Controls.Add(Me.DetalleFactPanel)
        Me.GrupoPanel.Controls.Add(Me.FolioPanel)
        Me.GrupoPanel.Controls.Add(Me.Panel5)
        Me.GrupoPanel.Controls.Add(Me.Panel4)
        Me.GrupoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrupoPanel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoPanel.Location = New System.Drawing.Point(5, 57)
        Me.GrupoPanel.Name = "GrupoPanel"
        Me.GrupoPanel.Padding = New System.Windows.Forms.Padding(9)
        Me.GrupoPanel.Size = New System.Drawing.Size(1299, 366)
        Me.GrupoPanel.TabIndex = 1
        Me.GrupoPanel.Visible = False
        '
        'DetalleFactPanel
        '
        Me.DetalleFactPanel.BackColor = System.Drawing.Color.LightCyan
        Me.DetalleFactPanel.Controls.Add(Me.TablaDetalle)
        Me.DetalleFactPanel.Controls.Add(Me.Panel10)
        Me.DetalleFactPanel.Controls.Add(Me.Panel9)
        Me.DetalleFactPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetalleFactPanel.Location = New System.Drawing.Point(713, 78)
        Me.DetalleFactPanel.Name = "DetalleFactPanel"
        Me.DetalleFactPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.DetalleFactPanel.Size = New System.Drawing.Size(577, 279)
        Me.DetalleFactPanel.TabIndex = 5
        '
        'TablaDetalle
        '
        Me.TablaDetalle.AllowUserToAddRows = False
        Me.TablaDetalle.AllowUserToDeleteRows = False
        Me.TablaDetalle.AllowUserToResizeRows = False
        Me.TablaDetalle.BackgroundColor = System.Drawing.Color.White
        Me.TablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TablaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.TablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cant, Me.np, Me.desc, Me.costo, Me.idinv, Me.iddet, Me.x_cant})
        Me.TablaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaDetalle.Location = New System.Drawing.Point(5, 99)
        Me.TablaDetalle.Name = "TablaDetalle"
        Me.TablaDetalle.RowHeadersVisible = False
        Me.TablaDetalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue
        Me.TablaDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDetalle.Size = New System.Drawing.Size(567, 140)
        Me.TablaDetalle.TabIndex = 1
        '
        'cant
        '
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.Width = 70
        '
        'np
        '
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        '
        'desc
        '
        Me.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        '
        'costo
        '
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        '
        'idinv
        '
        Me.idinv.HeaderText = "idinv"
        Me.idinv.Name = "idinv"
        Me.idinv.Width = 25
        '
        'iddet
        '
        Me.iddet.HeaderText = "iddet"
        Me.iddet.Name = "iddet"
        Me.iddet.Visible = False
        '
        'x_cant
        '
        Me.x_cant.HeaderText = "x_cant"
        Me.x_cant.Name = "x_cant"
        Me.x_cant.Width = 50
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.lbldetalle)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(5, 239)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel10.Size = New System.Drawing.Size(567, 35)
        Me.Panel10.TabIndex = 2
        '
        'lbldetalle
        '
        Me.lbldetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbldetalle.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldetalle.ForeColor = System.Drawing.Color.Black
        Me.lbldetalle.Location = New System.Drawing.Point(236, 4)
        Me.lbldetalle.Name = "lbldetalle"
        Me.lbldetalle.Size = New System.Drawing.Size(98, 27)
        Me.lbldetalle.TabIndex = 4
        Me.lbldetalle.Text = "0"
        Me.lbldetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 27)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Piezas | Servicios :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me._pagos)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(5, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(8, 2, 8, 2)
        Me.Panel9.Size = New System.Drawing.Size(567, 94)
        Me.Panel9.TabIndex = 0
        '
        '_pagos
        '
        Me._pagos.Controls.Add(Me.Panel12)
        Me._pagos.Controls.Add(Me.Panel8)
        Me._pagos.Controls.Add(Me.PictureBox1)
        Me._pagos.Dock = System.Windows.Forms.DockStyle.Top
        Me._pagos.Location = New System.Drawing.Point(8, 42)
        Me._pagos.Name = "_pagos"
        Me._pagos.Padding = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me._pagos.Size = New System.Drawing.Size(549, 45)
        Me._pagos.TabIndex = 6
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(179, 8)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(138, 29)
        Me.Panel12.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(80, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "metodo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 14)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "metodo:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lblmetodo)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(41, 8)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(138, 29)
        Me.Panel8.TabIndex = 1
        '
        'lblmetodo
        '
        Me.lblmetodo.AutoSize = True
        Me.lblmetodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblmetodo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmetodo.Location = New System.Drawing.Point(0, 14)
        Me.lblmetodo.Name = "lblmetodo"
        Me.lblmetodo.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblmetodo.Size = New System.Drawing.Size(80, 19)
        Me.lblmetodo.TabIndex = 1
        Me.lblmetodo.Text = "metodo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 14)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "metodo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.btnINV)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(8, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(8, 2, 8, 2)
        Me.Panel7.Size = New System.Drawing.Size(549, 40)
        Me.Panel7.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 36)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Detalle de la Factura."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnINV
        '
        Me.btnINV.BackColor = System.Drawing.Color.White
        Me.btnINV.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnINV.Image = CType(resources.GetObject("btnINV.Image"), System.Drawing.Image)
        Me.btnINV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnINV.Location = New System.Drawing.Point(472, 2)
        Me.btnINV.Name = "btnINV"
        Me.btnINV.Size = New System.Drawing.Size(69, 36)
        Me.btnINV.TabIndex = 4
        Me.btnINV.TabStop = False
        Me.btnINV.Text = "INV"
        Me.btnINV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnINV.UseVisualStyleBackColor = False
        '
        'FolioPanel
        '
        Me.FolioPanel.BackColor = System.Drawing.Color.Transparent
        Me.FolioPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FolioPanel.Controls.Add(Me.TablaFacturas)
        Me.FolioPanel.Controls.Add(Me.Panel6)
        Me.FolioPanel.Controls.Add(Me.Panel11)
        Me.FolioPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.FolioPanel.Location = New System.Drawing.Point(9, 78)
        Me.FolioPanel.Name = "FolioPanel"
        Me.FolioPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.FolioPanel.Size = New System.Drawing.Size(704, 279)
        Me.FolioPanel.TabIndex = 4
        '
        'TablaFacturas
        '
        Me.TablaFacturas.AllowUserToAddRows = False
        Me.TablaFacturas.AllowUserToDeleteRows = False
        Me.TablaFacturas.AllowUserToResizeRows = False
        Me.TablaFacturas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Folio, Me.idpro, Me.Refa, Me.fecha, Me.estado, Me.total, Me.Observacion, Me.colUsuario, Me.colpendiente, Me.colpagado})
        Me.TablaFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaFacturas.GridColor = System.Drawing.SystemColors.ControlLight
        Me.TablaFacturas.Location = New System.Drawing.Point(8, 46)
        Me.TablaFacturas.MultiSelect = False
        Me.TablaFacturas.Name = "TablaFacturas"
        Me.TablaFacturas.ReadOnly = True
        Me.TablaFacturas.RowHeadersVisible = False
        Me.TablaFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.TablaFacturas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TablaFacturas.RowTemplate.DividerHeight = 1
        Me.TablaFacturas.RowTemplate.Height = 28
        Me.TablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaFacturas.Size = New System.Drawing.Size(684, 186)
        Me.TablaFacturas.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.CheNA)
        Me.Panel6.Controls.Add(Me.txtEstado)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.txtObserv)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.txtRefa)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.txtFolio)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(8, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(684, 38)
        Me.Panel6.TabIndex = 4
        '
        'CheNA
        '
        Me.CheNA.AutoSize = True
        Me.CheNA.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheNA.Location = New System.Drawing.Point(670, 5)
        Me.CheNA.Name = "CheNA"
        Me.CheNA.Size = New System.Drawing.Size(103, 28)
        Me.CheNA.TabIndex = 10
        Me.CheNA.Text = "OCULTAR N/A"
        Me.CheNA.UseVisualStyleBackColor = True
        Me.CheNA.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(573, 5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(97, 25)
        Me.txtEstado.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(510, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 28)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Estado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObserv
        '
        Me.txtObserv.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtObserv.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.Location = New System.Drawing.Point(389, 5)
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(121, 25)
        Me.txtObserv.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(326, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 28)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Obser:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRefa
        '
        Me.txtRefa.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtRefa.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefa.Location = New System.Drawing.Point(215, 5)
        Me.txtRefa.Name = "txtRefa"
        Me.txtRefa.Size = New System.Drawing.Size(111, 25)
        Me.txtRefa.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(162, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 28)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Refa:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFolio
        '
        Me.txtFolio.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFolio.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(68, 5)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(94, 25)
        Me.txtFolio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Folio:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.NMax)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.lblFolios)
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(8, 232)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel11.Size = New System.Drawing.Size(684, 35)
        Me.Panel11.TabIndex = 3
        '
        'NMax
        '
        Me.NMax.Dock = System.Windows.Forms.DockStyle.Left
        Me.NMax.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMax.Location = New System.Drawing.Point(239, 4)
        Me.NMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NMax.Name = "NMax"
        Me.NMax.Size = New System.Drawing.Size(78, 26)
        Me.NMax.TabIndex = 11
        Me.NMax.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(177, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 27)
        Me.Label13.TabIndex = 10
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFolios
        '
        Me.lblFolios.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblFolios.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolios.ForeColor = System.Drawing.Color.Transparent
        Me.lblFolios.Location = New System.Drawing.Point(90, 4)
        Me.lblFolios.Name = "lblFolios"
        Me.lblFolios.Size = New System.Drawing.Size(87, 27)
        Me.lblFolios.TabIndex = 4
        Me.lblFolios.Text = "0"
        Me.lblFolios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(4, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 27)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Facturas:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(9, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1281, 18)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Obser_Panel)
        Me.Panel4.Controls.Add(Me.btnNota)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btnCancelarFAC)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.btnAgregar)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(9, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel4.Size = New System.Drawing.Size(1281, 51)
        Me.Panel4.TabIndex = 0
        '
        'Obser_Panel
        '
        Me.Obser_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Obser_Panel.Controls.Add(Me.Button3)
        Me.Obser_Panel.Controls.Add(Me.txtObservacion)
        Me.Obser_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Obser_Panel.Location = New System.Drawing.Point(783, 7)
        Me.Obser_Panel.Name = "Obser_Panel"
        Me.Obser_Panel.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Obser_Panel.Size = New System.Drawing.Size(465, 33)
        Me.Obser_Panel.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(255, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 27)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Actualizar Observación"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtObservacion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(2, 1)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(253, 23)
        Me.txtObservacion.TabIndex = 0
        '
        'btnNota
        '
        Me.btnNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNota.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNota.ForeColor = System.Drawing.Color.Black
        Me.btnNota.Image = CType(resources.GetObject("btnNota.Image"), System.Drawing.Image)
        Me.btnNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNota.Location = New System.Drawing.Point(601, 7)
        Me.btnNota.Name = "btnNota"
        Me.btnNota.Size = New System.Drawing.Size(182, 33)
        Me.btnNota.TabIndex = 5
        Me.btnNota.Text = "Agregar Nota Cred."
        Me.btnNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNota.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(583, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelarFAC
        '
        Me.btnCancelarFAC.BackColor = System.Drawing.Color.White
        Me.btnCancelarFAC.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelarFAC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarFAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelarFAC.Image = CType(resources.GetObject("btnCancelarFAC.Image"), System.Drawing.Image)
        Me.btnCancelarFAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarFAC.Location = New System.Drawing.Point(422, 7)
        Me.btnCancelarFAC.Name = "btnCancelarFAC"
        Me.btnCancelarFAC.Size = New System.Drawing.Size(161, 33)
        Me.btnCancelarFAC.TabIndex = 3
        Me.btnCancelarFAC.Text = "Cancelar Factura"
        Me.btnCancelarFAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelarFAC.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(407, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(260, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(147, 33)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Factura"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lista de Facturas Agregadas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 60
        '
        'Folio
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folio.DefaultCellStyle = DataGridViewCellStyle1
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.ReadOnly = True
        '
        'idpro
        '
        Me.idpro.HeaderText = "idpro"
        Me.idpro.Name = "idpro"
        Me.idpro.ReadOnly = True
        Me.idpro.Visible = False
        '
        'Refa
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Refa.DefaultCellStyle = DataGridViewCellStyle2
        Me.Refa.HeaderText = "Refa"
        Me.Refa.Name = "Refa"
        Me.Refa.ReadOnly = True
        '
        'fecha
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 85
        '
        'estado
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon
        Me.estado.DefaultCellStyle = DataGridViewCellStyle4
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle5
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 200
        '
        'colUsuario
        '
        Me.colUsuario.HeaderText = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        '
        'colpendiente
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colpendiente.DefaultCellStyle = DataGridViewCellStyle6
        Me.colpendiente.HeaderText = "pendiente"
        Me.colpendiente.Name = "colpendiente"
        Me.colpendiente.ReadOnly = True
        '
        'colpagado
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colpagado.DefaultCellStyle = DataGridViewCellStyle7
        Me.colpagado.HeaderText = "pagado"
        Me.colpagado.Name = "colpagado"
        Me.colpagado.ReadOnly = True
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1309, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.GrupoPanel)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Facturas"
        Me.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GrupoPanel.ResumeLayout(False)
        Me.DetalleFactPanel.ResumeLayout(False)
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me._pagos.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.FolioPanel.ResumeLayout(False)
        CType(Me.TablaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.NMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Obser_Panel.ResumeLayout(False)
        Me.Obser_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrupoPanel As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnNota As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarFAC As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DetalleFactPanel As System.Windows.Forms.Panel
    Friend WithEvents FolioPanel As System.Windows.Forms.Panel
    Friend WithEvents TablaFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TablaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lbldetalle As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblFolios As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRefa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Obser_Panel As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents CheNA As System.Windows.Forms.CheckBox
    Friend WithEvents NMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnINV As System.Windows.Forms.Button
    Friend WithEvents Mover As System.Windows.Forms.Button
    Friend WithEvents _pagos As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblmetodo As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iddet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents x_cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Refa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpagado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
