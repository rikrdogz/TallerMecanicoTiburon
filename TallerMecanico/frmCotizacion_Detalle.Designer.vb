<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizacion_Detalle))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOC = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CBFac = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NPagado = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBMetodo = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.npreven = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCOT = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiarGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ntotal = New System.Windows.Forms.NumericUpDown()
        Me.fecha_fac = New System.Windows.Forms.DateTimePicker()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.tablarelacion = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.NPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.npreven, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ntotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.tablarelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSC
        '
        Me.txtSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSC.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSC.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC.Location = New System.Drawing.Point(341, 5)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(104, 32)
        Me.txtSC.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(231, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(4)
        Me.Label7.Size = New System.Drawing.Size(110, 32)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "S. COMPRA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OC:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.txtser)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtSC)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtOC)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(9, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(793, 47)
        Me.Panel3.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(665, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.TabStop = False
        Me.Button3.Text = "NOREALIZADO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtser
        '
        Me.txtser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtser.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtser.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtser.Location = New System.Drawing.Point(525, 5)
        Me.txtser.Name = "txtser"
        Me.txtser.Size = New System.Drawing.Size(88, 32)
        Me.txtser.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(4)
        Me.Label10.Size = New System.Drawing.Size(80, 32)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "S.SER:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOC
        '
        Me.txtOC.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtOC.Location = New System.Drawing.Point(51, 5)
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Size = New System.Drawing.Size(180, 30)
        Me.txtOC.TabIndex = 0
        '
        'txtFactura
        '
        Me.txtFactura.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFactura.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(118, 7)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(194, 36)
        Me.txtFactura.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 41)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FACTURA:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtFactura)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(9, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel4.Size = New System.Drawing.Size(793, 55)
        Me.Panel4.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Controls.Add(Me.CBFac)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(659, 7)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(127, 41)
        Me.Panel8.TabIndex = 3
        '
        'CBFac
        '
        Me.CBFac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBFac.FormattingEnabled = True
        Me.CBFac.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBFac.Location = New System.Drawing.Point(5, 5)
        Me.CBFac.Name = "CBFac"
        Me.CBFac.Size = New System.Drawing.Size(117, 30)
        Me.CBFac.TabIndex = 0
        Me.CBFac.TabStop = False
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(312, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(347, 41)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "requiere Factura:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NPagado
        '
        Me.NPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NPagado.DecimalPlaces = 2
        Me.NPagado.Dock = System.Windows.Forms.DockStyle.Left
        Me.NPagado.Location = New System.Drawing.Point(90, 5)
        Me.NPagado.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NPagado.Name = "NPagado"
        Me.NPagado.Size = New System.Drawing.Size(155, 30)
        Me.NPagado.TabIndex = 2
        Me.NPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 32)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "METODO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 34)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PAGADO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CBMetodo
        '
        Me.CBMetodo.Dock = System.Windows.Forms.DockStyle.Left
        Me.CBMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBMetodo.FormattingEnabled = True
        Me.CBMetodo.Items.AddRange(New Object() {"TRANSFERENCIA", "EFECTIVO", "RECOTIZADO"})
        Me.CBMetodo.Location = New System.Drawing.Point(116, 5)
        Me.CBMetodo.Name = "CBMetodo"
        Me.CBMetodo.Size = New System.Drawing.Size(252, 30)
        Me.CBMetodo.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.npreven)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.CBMetodo)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(9, 155)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(793, 42)
        Me.Panel6.TabIndex = 3
        '
        'npreven
        '
        Me.npreven.DecimalPlaces = 2
        Me.npreven.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npreven.Enabled = False
        Me.npreven.Location = New System.Drawing.Point(433, 5)
        Me.npreven.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.npreven.Name = "npreven"
        Me.npreven.Size = New System.Drawing.Size(355, 30)
        Me.npreven.TabIndex = 4
        Me.npreven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(368, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "preven"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCOT
        '
        Me.lblCOT.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCOT.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOT.Location = New System.Drawing.Point(86, 4)
        Me.lblCOT.Name = "lblCOT"
        Me.lblCOT.Size = New System.Drawing.Size(119, 50)
        Me.lblCOT.TabIndex = 1
        Me.lblCOT.Text = "0"
        Me.lblCOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltitulo.Location = New System.Drawing.Point(4, 4)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(82, 50)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "COTIZACION:"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnLimpiarGuardar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbltipo)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lblCOT)
        Me.Panel1.Controls.Add(Me.lbltitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(813, 62)
        Me.Panel1.TabIndex = 2
        '
        'btnLimpiarGuardar
        '
        Me.btnLimpiarGuardar.BackColor = System.Drawing.Color.White
        Me.btnLimpiarGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLimpiarGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarGuardar.Image = CType(resources.GetObject("btnLimpiarGuardar.Image"), System.Drawing.Image)
        Me.btnLimpiarGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarGuardar.Location = New System.Drawing.Point(495, 4)
        Me.btnLimpiarGuardar.Name = "btnLimpiarGuardar"
        Me.btnLimpiarGuardar.Size = New System.Drawing.Size(207, 50)
        Me.btnLimpiarGuardar.TabIndex = 5
        Me.btnLimpiarGuardar.TabStop = False
        Me.btnLimpiarGuardar.Text = "Limpiar Metodo pago y Guardar"
        Me.btnLimpiarGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarGuardar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(745, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.Text = "CERRAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltipo
        '
        Me.lbltipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltipo.Location = New System.Drawing.Point(482, 4)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(13, 50)
        Me.lbltipo.TabIndex = 3
        Me.lbltipo.Text = "COT"
        Me.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSAVE.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSAVE.Enabled = False
        Me.btnSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.Image = CType(resources.GetObject("btnSAVE.Image"), System.Drawing.Image)
        Me.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSAVE.Location = New System.Drawing.Point(345, 4)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(137, 50)
        Me.btnSAVE.TabIndex = 6
        Me.btnSAVE.TabStop = False
        Me.btnSAVE.Text = "GUARDAR [F2]"
        Me.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSAVE.UseVisualStyleBackColor = False
        Me.btnSAVE.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(205, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 50)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "GUARDAR [F2]"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.ntotal)
        Me.Panel5.Controls.Add(Me.fecha_fac)
        Me.Panel5.Controls.Add(Me.lblfecha)
        Me.Panel5.Controls.Add(Me.NPagado)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(9, 111)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(793, 44)
        Me.Panel5.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Location = New System.Drawing.Point(507, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total:"
        '
        'ntotal
        '
        Me.ntotal.DecimalPlaces = 2
        Me.ntotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.ntotal.Enabled = False
        Me.ntotal.Location = New System.Drawing.Point(577, 5)
        Me.ntotal.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.ntotal.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.ntotal.Name = "ntotal"
        Me.ntotal.ReadOnly = True
        Me.ntotal.Size = New System.Drawing.Size(211, 30)
        Me.ntotal.TabIndex = 7
        '
        'fecha_fac
        '
        Me.fecha_fac.Dock = System.Windows.Forms.DockStyle.Left
        Me.fecha_fac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_fac.Location = New System.Drawing.Point(343, 5)
        Me.fecha_fac.MinDate = New Date(2001, 1, 1, 0, 0, 0, 0)
        Me.fecha_fac.Name = "fecha_fac"
        Me.fecha_fac.Size = New System.Drawing.Size(129, 30)
        Me.fecha_fac.TabIndex = 6
        Me.fecha_fac.TabStop = False
        Me.fecha_fac.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfecha.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblfecha.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblfecha.Location = New System.Drawing.Point(245, 5)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(98, 34)
        Me.lblfecha.TabIndex = 5
        Me.lblfecha.Text = "FECHA FAC:"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblfecha.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(813, 421)
        Me.Panel2.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(9, 197)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel7.Size = New System.Drawing.Size(793, 213)
        Me.Panel7.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.tablarelacion)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(4, 25)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(785, 184)
        Me.Panel9.TabIndex = 3
        '
        'tablarelacion
        '
        Me.tablarelacion.AllowUserToAddRows = False
        Me.tablarelacion.AllowUserToDeleteRows = False
        Me.tablarelacion.AllowUserToResizeRows = False
        Me.tablarelacion.BackgroundColor = System.Drawing.Color.White
        Me.tablarelacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablarelacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablarelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablarelacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.total, Me.atq, Me.factura, Me.cot})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablarelacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.tablarelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablarelacion.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tablarelacion.Location = New System.Drawing.Point(0, 0)
        Me.tablarelacion.Name = "tablarelacion"
        Me.tablarelacion.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablarelacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tablarelacion.RowHeadersVisible = False
        Me.tablarelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablarelacion.Size = New System.Drawing.Size(472, 182)
        Me.tablarelacion.TabIndex = 2
        '
        'ID
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "id"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 30
        '
        'total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle3
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 80
        '
        'atq
        '
        Me.atq.HeaderText = "atq"
        Me.atq.Name = "atq"
        Me.atq.ReadOnly = True
        Me.atq.Width = 200
        '
        'factura
        '
        Me.factura.HeaderText = "factura"
        Me.factura.Name = "factura"
        Me.factura.ReadOnly = True
        Me.factura.Width = 50
        '
        'cot
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cot.DefaultCellStyle = DataGridViewCellStyle4
        Me.cot.HeaderText = "cot"
        Me.cot.Name = "cot"
        Me.cot.ReadOnly = True
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.DataGridView1)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(472, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Panel10.Size = New System.Drawing.Size(311, 182)
        Me.Panel10.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(307, 155)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 52
        '
        'Column2
        '
        Me.Column2.HeaderText = "campo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "fecha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Location = New System.Drawing.Point(0, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Historial"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(785, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "RELACIONADOS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCotizacion_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCotizacion_Detalle"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCotizacion_Detalle"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.NPagado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.npreven, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ntotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.tablarelacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents NPagado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBMetodo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblCOT As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tablarelacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents npreven As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents CBFac As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtser As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiarGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents fecha_fac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ntotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents atq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
