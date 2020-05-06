<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasAgregar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturasAgregar))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FechaPanel = New System.Windows.Forms.Panel()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelFolio = New System.Windows.Forms.Panel()
        Me.lblfoliofac = New System.Windows.Forms.Label()
        Me.lblIdRelacion = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.CBPago = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Info = New System.Windows.Forms.Panel()
        Me.tipo_a = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.NCosto = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblidNp = New System.Windows.Forms.Label()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.txtNp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ncantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Botones = New System.Windows.Forms.Panel()
        Me.pago_panel = New System.Windows.Forms.Panel()
        Me.txtobser_pago = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.fechapago = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CBMetodo = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnServicio = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.TablaDetalle = New System.Windows.Forms.DataGridView()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.idnp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NSub = New System.Windows.Forms.NumericUpDown()
        Me.lblPorcentajeIva = New System.Windows.Forms.Label()
        Me.NIva = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NTotal = New System.Windows.Forms.NumericUpDown()
        Me.lblcant = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panel_inv = New System.Windows.Forms.Panel()
        Me.lblCant_Inv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tiempoNota = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FechaPanel.SuspendLayout()
        Me.panelFolio.SuspendLayout()
        Me.Info.SuspendLayout()
        CType(Me.NCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Botones.SuspendLayout()
        Me.pago_panel.SuspendLayout()
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panel_inv.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblProveedor)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(1285, 59)
        Me.Panel1.TabIndex = 0
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblProveedor.Location = New System.Drawing.Point(392, 5)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(344, 47)
        Me.lblProveedor.TabIndex = 4
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.FechaPanel)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.lblClave)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btnGuardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(736, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.Panel4.Size = New System.Drawing.Size(479, 47)
        Me.Panel4.TabIndex = 16
        '
        'FechaPanel
        '
        Me.FechaPanel.Controls.Add(Me.fecha)
        Me.FechaPanel.Controls.Add(Me.Label19)
        Me.FechaPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FechaPanel.Location = New System.Drawing.Point(298, 2)
        Me.FechaPanel.Name = "FechaPanel"
        Me.FechaPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.FechaPanel.Size = New System.Drawing.Size(176, 43)
        Me.FechaPanel.TabIndex = 16
        '
        'fecha
        '
        Me.fecha.CalendarMonthBackground = System.Drawing.Color.White
        Me.fecha.CalendarTitleBackColor = System.Drawing.Color.Yellow
        Me.fecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fecha.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(68, 5)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(103, 29)
        Me.fecha.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(5, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 33)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "FECHA:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(225, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 43)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Credito:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'lblClave
        '
        Me.lblClave.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblClave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClave.Location = New System.Drawing.Point(192, 2)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(33, 43)
        Me.lblClave.TabIndex = 6
        Me.lblClave.Text = "Clave"
        Me.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblClave.Visible = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(161, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 43)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Clave:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(5, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(156, 43)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1215, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 47)
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblid
        '
        Me.lblid.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(360, 5)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(32, 47)
        Me.lblid.TabIndex = 3
        Me.lblid.Text = "0"
        Me.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblid.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(273, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Proveedor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(268, 47)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Agregando Factura"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelFolio
        '
        Me.panelFolio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelFolio.Controls.Add(Me.lblfoliofac)
        Me.panelFolio.Controls.Add(Me.lblIdRelacion)
        Me.panelFolio.Controls.Add(Me.btnAceptar)
        Me.panelFolio.Controls.Add(Me.CBPago)
        Me.panelFolio.Controls.Add(Me.Label18)
        Me.panelFolio.Controls.Add(Me.txtObservacion)
        Me.panelFolio.Controls.Add(Me.Label5)
        Me.panelFolio.Controls.Add(Me.txtFolio)
        Me.panelFolio.Controls.Add(Me.Label4)
        Me.panelFolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFolio.Location = New System.Drawing.Point(0, 69)
        Me.panelFolio.Name = "panelFolio"
        Me.panelFolio.Padding = New System.Windows.Forms.Padding(6)
        Me.panelFolio.Size = New System.Drawing.Size(1285, 46)
        Me.panelFolio.TabIndex = 1
        '
        'lblfoliofac
        '
        Me.lblfoliofac.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblfoliofac.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfoliofac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblfoliofac.Location = New System.Drawing.Point(1176, 6)
        Me.lblfoliofac.Name = "lblfoliofac"
        Me.lblfoliofac.Size = New System.Drawing.Size(33, 30)
        Me.lblfoliofac.TabIndex = 16
        Me.lblfoliofac.Text = "folio"
        Me.lblfoliofac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIdRelacion
        '
        Me.lblIdRelacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblIdRelacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdRelacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIdRelacion.Location = New System.Drawing.Point(1143, 6)
        Me.lblIdRelacion.Name = "lblIdRelacion"
        Me.lblIdRelacion.Size = New System.Drawing.Size(33, 30)
        Me.lblIdRelacion.TabIndex = 15
        Me.lblIdRelacion.Text = "0"
        Me.lblIdRelacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(1048, 6)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 30)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'CBPago
        '
        Me.CBPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.CBPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBPago.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPago.FormattingEnabled = True
        Me.CBPago.Items.AddRange(New Object() {"PENDIENTE", "PAGADO"})
        Me.CBPago.Location = New System.Drawing.Point(927, 6)
        Me.CBPago.Name = "CBPago"
        Me.CBPago.Size = New System.Drawing.Size(121, 30)
        Me.CBPago.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(808, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 30)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Pago:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(424, 6)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(384, 31)
        Me.txtObservacion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(313, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Observacion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(136, 6)
        Me.txtFolio.MaxLength = 121
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(177, 31)
        Me.txtFolio.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factura / Folio:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Info.Controls.Add(Me.tipo_a)
        Me.Info.Controls.Add(Me.btnAgregar)
        Me.Info.Controls.Add(Me.lbltipo)
        Me.Info.Controls.Add(Me.NCosto)
        Me.Info.Controls.Add(Me.Label9)
        Me.Info.Controls.Add(Me.txtDesc)
        Me.Info.Controls.Add(Me.Label8)
        Me.Info.Controls.Add(Me.lblidNp)
        Me.Info.Controls.Add(Me.btnInventario)
        Me.Info.Controls.Add(Me.txtNp)
        Me.Info.Controls.Add(Me.Label7)
        Me.Info.Controls.Add(Me.Ncantidad)
        Me.Info.Controls.Add(Me.Label6)
        Me.Info.Dock = System.Windows.Forms.DockStyle.Top
        Me.Info.Enabled = False
        Me.Info.Location = New System.Drawing.Point(0, 169)
        Me.Info.Name = "Info"
        Me.Info.Padding = New System.Windows.Forms.Padding(6)
        Me.Info.Size = New System.Drawing.Size(1285, 51)
        Me.Info.TabIndex = 2
        '
        'tipo_a
        '
        Me.tipo_a.Dock = System.Windows.Forms.DockStyle.Left
        Me.tipo_a.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tipo_a.Location = New System.Drawing.Point(1232, 6)
        Me.tipo_a.Name = "tipo_a"
        Me.tipo_a.Size = New System.Drawing.Size(53, 35)
        Me.tipo_a.TabIndex = 16
        Me.tipo_a.Text = "tipo"
        Me.tipo_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(1137, 6)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(95, 35)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lbltipo
        '
        Me.lbltipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltipo.Location = New System.Drawing.Point(1092, 6)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(45, 35)
        Me.lbltipo.TabIndex = 12
        Me.lbltipo.Text = "clave"
        Me.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltipo.Visible = False
        '
        'NCosto
        '
        Me.NCosto.DecimalPlaces = 2
        Me.NCosto.Dock = System.Windows.Forms.DockStyle.Left
        Me.NCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCosto.Location = New System.Drawing.Point(972, 6)
        Me.NCosto.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NCosto.Minimum = New Decimal(New Integer() {10000000, 0, 0, -2147483648})
        Me.NCosto.Name = "NCosto"
        Me.NCosto.Size = New System.Drawing.Size(120, 31)
        Me.NCosto.TabIndex = 11
        Me.NCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(896, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 35)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Costo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(554, 6)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(342, 31)
        Me.txtDesc.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(457, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 35)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Descripcion:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblidNp
        '
        Me.lblidNp.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblidNp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidNp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblidNp.Location = New System.Drawing.Point(438, 6)
        Me.lblidNp.Name = "lblidNp"
        Me.lblidNp.Size = New System.Drawing.Size(19, 35)
        Me.lblidNp.TabIndex = 15
        Me.lblidNp.Text = "0"
        Me.lblidNp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnInventario
        '
        Me.btnInventario.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInventario.Enabled = False
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.Location = New System.Drawing.Point(369, 6)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(69, 35)
        Me.btnInventario.TabIndex = 14
        Me.btnInventario.TabStop = False
        Me.btnInventario.Text = "Inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taller "
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'txtNp
        '
        Me.txtNp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNp.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNp.Location = New System.Drawing.Point(217, 6)
        Me.txtNp.Name = "txtNp"
        Me.txtNp.Size = New System.Drawing.Size(152, 31)
        Me.txtNp.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(133, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 35)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No. Parte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ncantidad
        '
        Me.Ncantidad.BackColor = System.Drawing.Color.White
        Me.Ncantidad.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ncantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ncantidad.Location = New System.Drawing.Point(58, 6)
        Me.Ncantidad.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.Ncantidad.Name = "Ncantidad"
        Me.Ncantidad.Size = New System.Drawing.Size(75, 31)
        Me.Ncantidad.TabIndex = 5
        Me.Ncantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 35)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cant:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Botones
        '
        Me.Botones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Botones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Botones.Controls.Add(Me.pago_panel)
        Me.Botones.Controls.Add(Me.Label21)
        Me.Botones.Controls.Add(Me.btnDescuento)
        Me.Botones.Controls.Add(Me.Label11)
        Me.Botones.Controls.Add(Me.btnServicio)
        Me.Botones.Controls.Add(Me.Label10)
        Me.Botones.Controls.Add(Me.btnProducto)
        Me.Botones.Dock = System.Windows.Forms.DockStyle.Top
        Me.Botones.Enabled = False
        Me.Botones.Location = New System.Drawing.Point(0, 115)
        Me.Botones.Name = "Botones"
        Me.Botones.Padding = New System.Windows.Forms.Padding(5)
        Me.Botones.Size = New System.Drawing.Size(1285, 54)
        Me.Botones.TabIndex = 3
        '
        'pago_panel
        '
        Me.pago_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pago_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pago_panel.Controls.Add(Me.txtobser_pago)
        Me.pago_panel.Controls.Add(Me.Label24)
        Me.pago_panel.Controls.Add(Me.fechapago)
        Me.pago_panel.Controls.Add(Me.Label23)
        Me.pago_panel.Controls.Add(Me.CBMetodo)
        Me.pago_panel.Controls.Add(Me.Label22)
        Me.pago_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pago_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pago_panel.Location = New System.Drawing.Point(410, 5)
        Me.pago_panel.Name = "pago_panel"
        Me.pago_panel.Padding = New System.Windows.Forms.Padding(6)
        Me.pago_panel.Size = New System.Drawing.Size(725, 40)
        Me.pago_panel.TabIndex = 13
        Me.pago_panel.Visible = False
        '
        'txtobser_pago
        '
        Me.txtobser_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobser_pago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtobser_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobser_pago.Location = New System.Drawing.Point(494, 6)
        Me.txtobser_pago.Name = "txtobser_pago"
        Me.txtobser_pago.Size = New System.Drawing.Size(223, 26)
        Me.txtobser_pago.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(383, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 26)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Observacion:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fechapago
        '
        Me.fechapago.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechapago.CalendarTitleBackColor = System.Drawing.Color.Yellow
        Me.fechapago.Dock = System.Windows.Forms.DockStyle.Left
        Me.fechapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechapago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechapago.Location = New System.Drawing.Point(280, 6)
        Me.fechapago.Name = "fechapago"
        Me.fechapago.Size = New System.Drawing.Size(103, 24)
        Me.fechapago.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label23.Location = New System.Drawing.Point(190, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 26)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "fecha pago:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBMetodo
        '
        Me.CBMetodo.Dock = System.Windows.Forms.DockStyle.Left
        Me.CBMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBMetodo.FormattingEnabled = True
        Me.CBMetodo.Items.AddRange(New Object() {"EFECTIVO", "TARJETA", "TRANSFERENCIA", "CHEQUE"})
        Me.CBMetodo.Location = New System.Drawing.Point(69, 6)
        Me.CBMetodo.Name = "CBMetodo"
        Me.CBMetodo.Size = New System.Drawing.Size(121, 24)
        Me.CBMetodo.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label22.Location = New System.Drawing.Point(6, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 26)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Metodo:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(377, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 40)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = " | "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDescuento
        '
        Me.btnDescuento.BackColor = System.Drawing.Color.White
        Me.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescuento.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDescuento.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDescuento.Image = CType(resources.GetObject("btnDescuento.Image"), System.Drawing.Image)
        Me.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescuento.Location = New System.Drawing.Point(273, 5)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(104, 40)
        Me.btnDescuento.TabIndex = 12
        Me.btnDescuento.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descuento"
        Me.btnDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDescuento.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(234, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 40)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = " | "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnServicio
        '
        Me.btnServicio.BackColor = System.Drawing.Color.White
        Me.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnServicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnServicio.Image = CType(resources.GetObject("btnServicio.Image"), System.Drawing.Image)
        Me.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServicio.Location = New System.Drawing.Point(139, 5)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(95, 40)
        Me.btnServicio.TabIndex = 10
        Me.btnServicio.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnServicio.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(100, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 40)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = " | "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.Color.White
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(5, 5)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(95, 40)
        Me.btnProducto.TabIndex = 8
        Me.btnProducto.Text = "Agregar Producto"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProducto.UseVisualStyleBackColor = False
        '
        'TablaDetalle
        '
        Me.TablaDetalle.AllowUserToAddRows = False
        Me.TablaDetalle.AllowUserToDeleteRows = False
        Me.TablaDetalle.AllowUserToResizeRows = False
        Me.TablaDetalle.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TablaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cant, Me.np, Me.desc, Me.costo, Me.tipo, Me.importe, Me.editar, Me.eliminar, Me.idnp, Me.tipo_art, Me.c_unidad, Me.id_det})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaDetalle.DefaultCellStyle = DataGridViewCellStyle9
        Me.TablaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaDetalle.GridColor = System.Drawing.SystemColors.Control
        Me.TablaDetalle.Location = New System.Drawing.Point(0, 220)
        Me.TablaDetalle.MultiSelect = False
        Me.TablaDetalle.Name = "TablaDetalle"
        Me.TablaDetalle.ReadOnly = True
        Me.TablaDetalle.RowHeadersVisible = False
        Me.TablaDetalle.RowTemplate.DividerHeight = 1
        Me.TablaDetalle.RowTemplate.Height = 34
        Me.TablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDetalle.Size = New System.Drawing.Size(1085, 216)
        Me.TablaDetalle.TabIndex = 4
        '
        'cant
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cant.DefaultCellStyle = DataGridViewCellStyle1
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 60
        '
        'np
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.np.DefaultCellStyle = DataGridViewCellStyle2
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        Me.np.ReadOnly = True
        Me.np.Width = 120
        '
        'desc
        '
        Me.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkBlue
        Me.desc.DefaultCellStyle = DataGridViewCellStyle3
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'costo
        '
        DataGridViewCellStyle4.Format = "C3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle4
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 140
        '
        'tipo
        '
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 45
        '
        'importe
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle5
        Me.importe.DividerWidth = 1
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 140
        '
        'editar
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.editar.DefaultCellStyle = DataGridViewCellStyle6
        Me.editar.DividerWidth = 1
        Me.editar.HeaderText = "editar"
        Me.editar.Name = "editar"
        Me.editar.ReadOnly = True
        Me.editar.Width = 85
        '
        'eliminar
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.eliminar.DefaultCellStyle = DataGridViewCellStyle7
        Me.eliminar.DividerWidth = 1
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 85
        '
        'idnp
        '
        Me.idnp.HeaderText = "idnp"
        Me.idnp.Name = "idnp"
        Me.idnp.ReadOnly = True
        Me.idnp.Width = 50
        '
        'tipo_art
        '
        Me.tipo_art.HeaderText = "tipo_art"
        Me.tipo_art.Name = "tipo_art"
        Me.tipo_art.ReadOnly = True
        Me.tipo_art.Width = 50
        '
        'c_unidad
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_unidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.c_unidad.HeaderText = "cant_unidad"
        Me.c_unidad.Name = "c_unidad"
        Me.c_unidad.ReadOnly = True
        Me.c_unidad.Width = 85
        '
        'id_det
        '
        Me.id_det.HeaderText = "id_det"
        Me.id_det.Name = "id_det"
        Me.id_det.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.NSub)
        Me.Panel3.Controls.Add(Me.lblPorcentajeIva)
        Me.Panel3.Controls.Add(Me.NIva)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.NTotal)
        Me.Panel3.Controls.Add(Me.lblcant)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(1285, 46)
        Me.Panel3.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(454, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 36)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Subtotal:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NSub
        '
        Me.NSub.BackColor = System.Drawing.Color.White
        Me.NSub.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NSub.DecimalPlaces = 2
        Me.NSub.Dock = System.Windows.Forms.DockStyle.Right
        Me.NSub.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NSub.ForeColor = System.Drawing.Color.Black
        Me.NSub.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NSub.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NSub.InterceptArrowKeys = False
        Me.NSub.Location = New System.Drawing.Point(551, 5)
        Me.NSub.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NSub.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NSub.Name = "NSub"
        Me.NSub.ReadOnly = True
        Me.NSub.Size = New System.Drawing.Size(173, 26)
        Me.NSub.TabIndex = 10
        Me.NSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPorcentajeIva
        '
        Me.lblPorcentajeIva.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPorcentajeIva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPorcentajeIva.Location = New System.Drawing.Point(724, 5)
        Me.lblPorcentajeIva.Name = "lblPorcentajeIva"
        Me.lblPorcentajeIva.Size = New System.Drawing.Size(154, 36)
        Me.lblPorcentajeIva.TabIndex = 9
        Me.lblPorcentajeIva.Text = "Iva:"
        Me.lblPorcentajeIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NIva
        '
        Me.NIva.BackColor = System.Drawing.Color.White
        Me.NIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NIva.DecimalPlaces = 2
        Me.NIva.Dock = System.Windows.Forms.DockStyle.Right
        Me.NIva.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIva.ForeColor = System.Drawing.Color.Black
        Me.NIva.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NIva.InterceptArrowKeys = False
        Me.NIva.Location = New System.Drawing.Point(878, 5)
        Me.NIva.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.NIva.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NIva.Name = "NIva"
        Me.NIva.ReadOnly = True
        Me.NIva.Size = New System.Drawing.Size(152, 26)
        Me.NIva.TabIndex = 8
        Me.NIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(1030, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 36)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Total:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NTotal
        '
        Me.NTotal.BackColor = System.Drawing.Color.White
        Me.NTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NTotal.DecimalPlaces = 2
        Me.NTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.NTotal.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NTotal.ForeColor = System.Drawing.Color.Black
        Me.NTotal.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NTotal.Location = New System.Drawing.Point(1087, 5)
        Me.NTotal.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.NTotal.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NTotal.Name = "NTotal"
        Me.NTotal.Size = New System.Drawing.Size(193, 28)
        Me.NTotal.TabIndex = 6
        Me.NTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NTotal.ThousandsSeparator = True
        '
        'lblcant
        '
        Me.lblcant.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblcant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcant.Location = New System.Drawing.Point(135, 5)
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(130, 36)
        Me.lblcant.TabIndex = 5
        Me.lblcant.Text = "0"
        Me.lblcant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(5, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 36)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Cantidad en lista:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.panel_inv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1085, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(200, 216)
        Me.Panel2.TabIndex = 6
        '
        'panel_inv
        '
        Me.panel_inv.BackColor = System.Drawing.Color.White
        Me.panel_inv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_inv.Controls.Add(Me.lblCant_Inv)
        Me.panel_inv.Controls.Add(Me.Label1)
        Me.panel_inv.Controls.Add(Me.lbldesc)
        Me.panel_inv.Controls.Add(Me.Label20)
        Me.panel_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_inv.Location = New System.Drawing.Point(10, 10)
        Me.panel_inv.Name = "panel_inv"
        Me.panel_inv.Padding = New System.Windows.Forms.Padding(8)
        Me.panel_inv.Size = New System.Drawing.Size(180, 133)
        Me.panel_inv.TabIndex = 3
        '
        'lblCant_Inv
        '
        Me.lblCant_Inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCant_Inv.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant_Inv.ForeColor = System.Drawing.Color.Black
        Me.lblCant_Inv.Location = New System.Drawing.Point(8, 83)
        Me.lblCant_Inv.Name = "lblCant_Inv"
        Me.lblCant_Inv.Size = New System.Drawing.Size(160, 25)
        Me.lblCant_Inv.TabIndex = 9
        Me.lblCant_Inv.Text = "0"
        Me.lblCant_Inv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cantidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldesc
        '
        Me.lbldesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbldesc.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.ForeColor = System.Drawing.Color.Black
        Me.lbldesc.Location = New System.Drawing.Point(8, 33)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(160, 25)
        Me.lbldesc.TabIndex = 7
        Me.lbldesc.Text = "Descripcion INV"
        Me.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(160, 25)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Descripcion INV"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tiempoNota
        '
        Me.tiempoNota.Interval = 200
        '
        'FacturasAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1285, 492)
        Me.Controls.Add(Me.TablaDetalle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.panelFolio)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FacturasAgregar"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FacturasAgregar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FechaPanel.ResumeLayout(False)
        Me.panelFolio.ResumeLayout(False)
        Me.panelFolio.PerformLayout()
        Me.Info.ResumeLayout(False)
        Me.Info.PerformLayout()
        CType(Me.NCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Botones.ResumeLayout(False)
        Me.pago_panel.ResumeLayout(False)
        Me.pago_panel.PerformLayout()
        CType(Me.TablaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.NSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.panel_inv.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents panelFolio As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Info As System.Windows.Forms.Panel
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents NCosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ncantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Botones As System.Windows.Forms.Panel
    Friend WithEvents btnDescuento As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnServicio As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnProducto As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents TablaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblcant As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents NSub As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPorcentajeIva As System.Windows.Forms.Label
    Friend WithEvents NIva As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents CBPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnInventario As System.Windows.Forms.Button
    Friend WithEvents lblidNp As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panel_inv As System.Windows.Forms.Panel
    Friend WithEvents lblCant_Inv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents FechaPanel As System.Windows.Forms.Panel
    Friend WithEvents pago_panel As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtobser_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents fechapago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CBMetodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tipo_a As System.Windows.Forms.Label
    Friend WithEvents lblfoliofac As System.Windows.Forms.Label
    Friend WithEvents lblIdRelacion As System.Windows.Forms.Label
    Friend WithEvents tiempoNota As System.Windows.Forms.Timer
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents idnp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_det As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
