<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasPagar))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TablaPagados = New System.Windows.Forms.DataGridView()
        Me.idp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foliop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abonar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porPagarPendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Npagadas = New System.Windows.Forms.NumericUpDown()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.cbMetodo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tablaFacturas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnAct = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Ntotales = New System.Windows.Forms.NumericUpDown()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.TablaPagados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.Npagadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tablaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Ntotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnContinuar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel1.Size = New System.Drawing.Size(1107, 65)
        Me.Panel1.TabIndex = 0
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncancelar.Enabled = False
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(565, 9)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(8)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(119, 43)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1031, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnContinuar.Enabled = False
        Me.btnContinuar.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Image = CType(resources.GetObject("btnContinuar.Image"), System.Drawing.Image)
        Me.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinuar.Location = New System.Drawing.Point(446, 9)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(119, 43)
        Me.btnContinuar.TabIndex = 5
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbProveedor)
        Me.Panel2.Controls.Add(Me.lblid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(194, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(252, 43)
        Me.Panel2.TabIndex = 2
        '
        'cbProveedor
        '
        Me.cbProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(9, 9)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(214, 28)
        Me.cbProveedor.TabIndex = 0
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblid.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(223, 9)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(20, 22)
        Me.lblid.TabIndex = 2
        Me.lblid.Text = "0"
        Me.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 43)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'fecha
        '
        Me.fecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fecha.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(4, 26)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(176, 30)
        Me.fecha.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8, 8, 8, 20)
        Me.Panel3.Size = New System.Drawing.Size(1107, 422)
        Me.Panel3.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TablaPagados)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(565, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel6.Size = New System.Drawing.Size(298, 390)
        Me.Panel6.TabIndex = 1
        '
        'TablaPagados
        '
        Me.TablaPagados.AllowUserToAddRows = False
        Me.TablaPagados.AllowUserToDeleteRows = False
        Me.TablaPagados.AllowUserToResizeRows = False
        Me.TablaPagados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaPagados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPagados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idp, Me.foliop, Me.totalp, Me.fechad, Me.obser, Me.abonar, Me.porPagarPendiente})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaPagados.DefaultCellStyle = DataGridViewCellStyle6
        Me.TablaPagados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaPagados.Location = New System.Drawing.Point(6, 34)
        Me.TablaPagados.MultiSelect = False
        Me.TablaPagados.Name = "TablaPagados"
        Me.TablaPagados.ReadOnly = True
        Me.TablaPagados.RowHeadersVisible = False
        Me.TablaPagados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaPagados.RowTemplate.Height = 30
        Me.TablaPagados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaPagados.Size = New System.Drawing.Size(286, 306)
        Me.TablaPagados.TabIndex = 1
        '
        'idp
        '
        Me.idp.HeaderText = "idp"
        Me.idp.Name = "idp"
        Me.idp.ReadOnly = True
        Me.idp.Visible = False
        Me.idp.Width = 80
        '
        'foliop
        '
        Me.foliop.HeaderText = "foliop"
        Me.foliop.Name = "foliop"
        Me.foliop.ReadOnly = True
        '
        'totalp
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.totalp.DefaultCellStyle = DataGridViewCellStyle1
        Me.totalp.HeaderText = "total"
        Me.totalp.Name = "totalp"
        Me.totalp.ReadOnly = True
        '
        'fechad
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fechad.DefaultCellStyle = DataGridViewCellStyle2
        Me.fechad.HeaderText = "fecha"
        Me.fechad.Name = "fechad"
        Me.fechad.ReadOnly = True
        '
        'obser
        '
        Me.obser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.NullValue = Nothing
        Me.obser.DefaultCellStyle = DataGridViewCellStyle3
        Me.obser.HeaderText = "observ"
        Me.obser.MinimumWidth = 100
        Me.obser.Name = "obser"
        Me.obser.ReadOnly = True
        '
        'abonar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.abonar.DefaultCellStyle = DataGridViewCellStyle4
        Me.abonar.HeaderText = "abonar"
        Me.abonar.Name = "abonar"
        Me.abonar.ReadOnly = True
        '
        'porPagarPendiente
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "c2"
        Me.porPagarPendiente.DefaultCellStyle = DataGridViewCellStyle5
        Me.porPagarPendiente.HeaderText = "Pendiente"
        Me.porPagarPendiente.Name = "porPagarPendiente"
        Me.porPagarPendiente.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(286, 28)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Lista de Facturas a PAGAR"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Npagadas)
        Me.Panel7.Controls.Add(Me.btnRegresar)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(6, 340)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel7.Size = New System.Drawing.Size(286, 44)
        Me.Panel7.TabIndex = 0
        '
        'Npagadas
        '
        Me.Npagadas.DecimalPlaces = 2
        Me.Npagadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Npagadas.Enabled = False
        Me.Npagadas.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Npagadas.InterceptArrowKeys = False
        Me.Npagadas.Location = New System.Drawing.Point(84, 8)
        Me.Npagadas.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Npagadas.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.Npagadas.Name = "Npagadas"
        Me.Npagadas.Size = New System.Drawing.Size(65, 36)
        Me.Npagadas.TabIndex = 3
        Me.Npagadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Npagadas.ThousandsSeparator = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRegresar.Location = New System.Drawing.Point(149, 8)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(129, 28)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "<-regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.lbltotal)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.txtproveedor)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.txtObserv)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(863, 8)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(20, 8, 20, 8)
        Me.Panel8.Size = New System.Drawing.Size(232, 390)
        Me.Panel8.TabIndex = 2
        '
        'lbltotal
        '
        Me.lbltotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbltotal.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(20, 346)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(188, 22)
        Me.lbltotal.TabIndex = 12
        Me.lbltotal.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(20, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "total a pagar:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel9.Controls.Add(Me.btnGuardar)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(20, 274)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel9.Size = New System.Drawing.Size(188, 57)
        Me.Panel9.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(9, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(170, 41)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtproveedor
        '
        Me.txtproveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtproveedor.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(20, 209)
        Me.txtproveedor.Multiline = True
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(188, 65)
        Me.txtproveedor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(20, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pagando a:"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.fecha)
        Me.Panel12.Controls.Add(Me.Label7)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(20, 130)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel12.Size = New System.Drawing.Size(188, 64)
        Me.Panel12.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "FECHA PAGO:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Navy
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.cbMetodo)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.ForeColor = System.Drawing.Color.White
        Me.Panel11.Location = New System.Drawing.Point(20, 73)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel11.Size = New System.Drawing.Size(188, 57)
        Me.Panel11.TabIndex = 7
        '
        'cbMetodo
        '
        Me.cbMetodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMetodo.FormattingEnabled = True
        Me.cbMetodo.Items.AddRange(New Object() {"TRANSFERENCIA", "EFECTIVO", "CHEQUE", "TARJETA", "SALDO A FAVOR"})
        Me.cbMetodo.Location = New System.Drawing.Point(4, 26)
        Me.cbMetodo.Name = "cbMetodo"
        Me.cbMetodo.Size = New System.Drawing.Size(178, 23)
        Me.cbMetodo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Metodo de pago:"
        '
        'txtObserv
        '
        Me.txtObserv.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtObserv.Location = New System.Drawing.Point(20, 23)
        Me.txtObserv.MaxLength = 150
        Me.txtObserv.Multiline = True
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(188, 50)
        Me.txtObserv.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(20, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observacion:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tablaFacturas)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel4.Size = New System.Drawing.Size(557, 390)
        Me.Panel4.TabIndex = 0
        '
        'tablaFacturas
        '
        Me.tablaFacturas.AllowUserToAddRows = False
        Me.tablaFacturas.AllowUserToDeleteRows = False
        Me.tablaFacturas.AllowUserToResizeRows = False
        Me.tablaFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.folio, Me.total, Me.fech, Me.obse, Me.ColPendiente, Me.ColPagado})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaFacturas.DefaultCellStyle = DataGridViewCellStyle11
        Me.tablaFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaFacturas.Location = New System.Drawing.Point(6, 42)
        Me.tablaFacturas.Name = "tablaFacturas"
        Me.tablaFacturas.ReadOnly = True
        Me.tablaFacturas.RowHeadersVisible = False
        Me.tablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaFacturas.Size = New System.Drawing.Size(545, 298)
        Me.tablaFacturas.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 25
        '
        'folio
        '
        Me.folio.HeaderText = "folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        Me.folio.Width = 105
        '
        'total
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle7
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 110
        '
        'fech
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.fech.DefaultCellStyle = DataGridViewCellStyle8
        Me.fech.HeaderText = "fecha"
        Me.fech.Name = "fech"
        Me.fech.ReadOnly = True
        '
        'obse
        '
        Me.obse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.obse.HeaderText = "obser"
        Me.obse.MinimumWidth = 100
        Me.obse.Name = "obse"
        Me.obse.ReadOnly = True
        '
        'ColPendiente
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ColPendiente.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColPendiente.HeaderText = "Pendiente"
        Me.ColPendiente.Name = "ColPendiente"
        Me.ColPendiente.ReadOnly = True
        '
        'ColPagado
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ColPagado.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColPagado.HeaderText = "Pagado"
        Me.ColPagado.Name = "ColPagado"
        Me.ColPagado.ReadOnly = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel10.Controls.Add(Me.btnAct)
        Me.Panel10.Controls.Add(Me.btnLimpiar)
        Me.Panel10.Controls.Add(Me.txtFolio)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(6, 6)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel10.Size = New System.Drawing.Size(545, 36)
        Me.Panel10.TabIndex = 2
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.White
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAct.Image = CType(resources.GetObject("btnAct.Image"), System.Drawing.Image)
        Me.btnAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAct.Location = New System.Drawing.Point(252, 2)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Size = New System.Drawing.Size(131, 32)
        Me.btnAct.TabIndex = 3
        Me.btnAct.Text = "Actualizar"
        Me.btnAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAct.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.White
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLimpiar.Location = New System.Drawing.Point(177, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 32)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtFolio
        '
        Me.txtFolio.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFolio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(67, 2)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(110, 26)
        Me.txtFolio.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Folio:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Ntotales)
        Me.Panel5.Controls.Add(Me.btnagregar)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(6, 340)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(545, 44)
        Me.Panel5.TabIndex = 0
        '
        'Ntotales
        '
        Me.Ntotales.DecimalPlaces = 2
        Me.Ntotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ntotales.Enabled = False
        Me.Ntotales.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ntotales.InterceptArrowKeys = False
        Me.Ntotales.Location = New System.Drawing.Point(118, 8)
        Me.Ntotales.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Ntotales.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.Ntotales.Name = "Ntotales"
        Me.Ntotales.Size = New System.Drawing.Size(289, 30)
        Me.Ntotales.TabIndex = 3
        Me.Ntotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ntotales.ThousandsSeparator = True
        '
        'btnagregar
        '
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnagregar.Location = New System.Drawing.Point(407, 8)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(130, 28)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar->"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFacturasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 503)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFacturasPagar"
        Me.Padding = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmFacturasPagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.TablaPagados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.Npagadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.tablaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.Ntotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tablaFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TablaPagados As System.Windows.Forms.DataGridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents Npagadas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents Ntotales As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents cbMetodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnAct As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents obse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents foliop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents obser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abonar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porPagarPendiente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
