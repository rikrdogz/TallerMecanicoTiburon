<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage = New System.Windows.Forms.TabControl()
        Me.tabFacturas = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnproveedores = New System.Windows.Forms.Button()
        Me.btnAgregar_prov = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnDeudas = New System.Windows.Forms.Button()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnBuscarNP = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNota = New System.Windows.Forms.Button()
        Me.btnFacturasAgregar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.tabArticulos = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabTermo = New System.Windows.Forms.TabPage()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnUltimosServicios = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabConfigurar = New System.Windows.Forms.TabPage()
        Me.btnCorreoTG = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnConfigIVA = New System.Windows.Forms.Button()
        Me.TabCFDI = New System.Windows.Forms.TabPage()
        Me.btnCfdiListaFacturas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblidUser = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.tabFacturas.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tabArticulos.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabTermo.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabConfigurar.SuspendLayout()
        Me.TabCFDI.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "book-48.png")
        Me.ImageList1.Images.SetKeyName(1, "678109-profile-group-48.png")
        Me.ImageList1.Images.SetKeyName(2, "678061-box-full-32.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TabPage)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(1284, 128)
        Me.Panel1.TabIndex = 4
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.tabFacturas)
        Me.TabPage.Controls.Add(Me.tabArticulos)
        Me.TabPage.Controls.Add(Me.TabTermo)
        Me.TabPage.Controls.Add(Me.TabConfigurar)
        Me.TabPage.Controls.Add(Me.TabCFDI)
        Me.TabPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPage.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage.ImageList = Me.ImageList1
        Me.TabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage.ItemSize = New System.Drawing.Size(80, 32)
        Me.TabPage.Location = New System.Drawing.Point(5, 10)
        Me.TabPage.Multiline = True
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(1181, 113)
        Me.TabPage.TabIndex = 6
        '
        'tabFacturas
        '
        Me.tabFacturas.BackColor = System.Drawing.SystemColors.Control
        Me.tabFacturas.Controls.Add(Me.Panel11)
        Me.tabFacturas.Controls.Add(Me.Panel8)
        Me.tabFacturas.Controls.Add(Me.Panel12)
        Me.tabFacturas.Controls.Add(Me.Panel2)
        Me.tabFacturas.Controls.Add(Me.Panel4)
        Me.tabFacturas.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabFacturas.ImageIndex = 0
        Me.tabFacturas.Location = New System.Drawing.Point(4, 36)
        Me.tabFacturas.Name = "tabFacturas"
        Me.tabFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacturas.Size = New System.Drawing.Size(1173, 73)
        Me.tabFacturas.TabIndex = 0
        Me.tabFacturas.Text = "Proveedores"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.btnproveedores)
        Me.Panel11.Controls.Add(Me.btnAgregar_prov)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(820, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel11.Size = New System.Drawing.Size(243, 67)
        Me.Panel11.TabIndex = 8
        '
        'btnproveedores
        '
        Me.btnproveedores.BackColor = System.Drawing.Color.White
        Me.btnproveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnproveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproveedores.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnproveedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnproveedores.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedores.Image = CType(resources.GetObject("btnproveedores.Image"), System.Drawing.Image)
        Me.btnproveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnproveedores.Location = New System.Drawing.Point(121, 2)
        Me.btnproveedores.Name = "btnproveedores"
        Me.btnproveedores.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnproveedores.Size = New System.Drawing.Size(110, 59)
        Me.btnproveedores.TabIndex = 1
        Me.btnproveedores.Text = "Proveedores"
        Me.btnproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnproveedores.UseVisualStyleBackColor = False
        '
        'btnAgregar_prov
        '
        Me.btnAgregar_prov.BackColor = System.Drawing.Color.White
        Me.btnAgregar_prov.BackgroundImage = CType(resources.GetObject("btnAgregar_prov.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar_prov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar_prov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_prov.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregar_prov.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregar_prov.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_prov.Image = CType(resources.GetObject("btnAgregar_prov.Image"), System.Drawing.Image)
        Me.btnAgregar_prov.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_prov.Location = New System.Drawing.Point(2, 2)
        Me.btnAgregar_prov.Name = "btnAgregar_prov"
        Me.btnAgregar_prov.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnAgregar_prov.Size = New System.Drawing.Size(119, 59)
        Me.btnAgregar_prov.TabIndex = 0
        Me.btnAgregar_prov.Text = "Agregar"
        Me.btnAgregar_prov.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregar_prov.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.btnDeudas)
        Me.Panel8.Controls.Add(Me.BtnPagos)
        Me.Panel8.Controls.Add(Me.btnPagar)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(540, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel8.Size = New System.Drawing.Size(280, 67)
        Me.Panel8.TabIndex = 7
        '
        'btnDeudas
        '
        Me.btnDeudas.BackColor = System.Drawing.Color.White
        Me.btnDeudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeudas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeudas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeudas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnDeudas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeudas.Image = CType(resources.GetObject("btnDeudas.Image"), System.Drawing.Image)
        Me.btnDeudas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeudas.Location = New System.Drawing.Point(205, 4)
        Me.btnDeudas.Name = "btnDeudas"
        Me.btnDeudas.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnDeudas.Size = New System.Drawing.Size(66, 55)
        Me.btnDeudas.TabIndex = 2
        Me.btnDeudas.Text = "Deudas"
        Me.btnDeudas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeudas.UseVisualStyleBackColor = False
        '
        'BtnPagos
        '
        Me.BtnPagos.BackColor = System.Drawing.Color.White
        Me.BtnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPagos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPagos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnPagos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagos.Image = CType(resources.GetObject("BtnPagos.Image"), System.Drawing.Image)
        Me.BtnPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagos.Location = New System.Drawing.Point(126, 4)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnPagos.Size = New System.Drawing.Size(79, 55)
        Me.BtnPagos.TabIndex = 1
        Me.BtnPagos.Text = "PAGADOS"
        Me.BtnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagos.UseVisualStyleBackColor = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.White
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPagar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Image = CType(resources.GetObject("btnPagar.Image"), System.Drawing.Image)
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagar.Location = New System.Drawing.Point(4, 4)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnPagar.Size = New System.Drawing.Size(122, 55)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar Facturas"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LightBlue
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.btnBuscarNP)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(419, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel12.Size = New System.Drawing.Size(121, 67)
        Me.Panel12.TabIndex = 9
        '
        'btnBuscarNP
        '
        Me.btnBuscarNP.BackColor = System.Drawing.Color.White
        Me.btnBuscarNP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarNP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarNP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscarNP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarNP.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarNP.Image = CType(resources.GetObject("btnBuscarNP.Image"), System.Drawing.Image)
        Me.btnBuscarNP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarNP.Location = New System.Drawing.Point(2, 2)
        Me.btnBuscarNP.Name = "btnBuscarNP"
        Me.btnBuscarNP.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.btnBuscarNP.Size = New System.Drawing.Size(113, 54)
        Me.btnBuscarNP.TabIndex = 0
        Me.btnBuscarNP.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facturas"
        Me.btnBuscarNP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarNP.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnNota)
        Me.Panel2.Controls.Add(Me.btnFacturasAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(111, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel2.Size = New System.Drawing.Size(308, 67)
        Me.Panel2.TabIndex = 5
        '
        'btnNota
        '
        Me.btnNota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNota.BackgroundImage = CType(resources.GetObject("btnNota.BackgroundImage"), System.Drawing.Image)
        Me.btnNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNota.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNota.ForeColor = System.Drawing.Color.DarkRed
        Me.btnNota.Image = CType(resources.GetObject("btnNota.Image"), System.Drawing.Image)
        Me.btnNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNota.Location = New System.Drawing.Point(161, 4)
        Me.btnNota.Name = "btnNota"
        Me.btnNota.Padding = New System.Windows.Forms.Padding(12, 0, 4, 0)
        Me.btnNota.Size = New System.Drawing.Size(139, 55)
        Me.btnNota.TabIndex = 6
        Me.btnNota.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nota Cred."
        Me.btnNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNota.UseVisualStyleBackColor = False
        '
        'btnFacturasAgregar
        '
        Me.btnFacturasAgregar.BackColor = System.Drawing.Color.White
        Me.btnFacturasAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFacturasAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturasAgregar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFacturasAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnFacturasAgregar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturasAgregar.Image = CType(resources.GetObject("btnFacturasAgregar.Image"), System.Drawing.Image)
        Me.btnFacturasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturasAgregar.Location = New System.Drawing.Point(4, 4)
        Me.btnFacturasAgregar.Name = "btnFacturasAgregar"
        Me.btnFacturasAgregar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnFacturasAgregar.Size = New System.Drawing.Size(131, 55)
        Me.btnFacturasAgregar.TabIndex = 0
        Me.btnFacturasAgregar.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facturas"
        Me.btnFacturasAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturasAgregar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btnFacturas)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel4.Size = New System.Drawing.Size(108, 67)
        Me.Panel4.TabIndex = 6
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.White
        Me.btnFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFacturas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnFacturas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Image = CType(resources.GetObject("btnFacturas.Image"), System.Drawing.Image)
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFacturas.Location = New System.Drawing.Point(4, 4)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnFacturas.Size = New System.Drawing.Size(92, 55)
        Me.btnFacturas.TabIndex = 0
        Me.btnFacturas.Text = "FACTURAS"
        Me.btnFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'tabArticulos
        '
        Me.tabArticulos.Controls.Add(Me.Panel9)
        Me.tabArticulos.Controls.Add(Me.Panel6)
        Me.tabArticulos.Controls.Add(Me.Panel5)
        Me.tabArticulos.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabArticulos.ImageIndex = 2
        Me.tabArticulos.Location = New System.Drawing.Point(4, 36)
        Me.tabArticulos.Name = "tabArticulos"
        Me.tabArticulos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabArticulos.Size = New System.Drawing.Size(1173, 73)
        Me.tabArticulos.TabIndex = 1
        Me.tabArticulos.Text = "Articulos"
        Me.tabArticulos.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Cyan
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(317, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel9.Size = New System.Drawing.Size(320, 67)
        Me.Panel9.TabIndex = 9
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.White
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Controls.Add(Me.Button12)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(161, 4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel15.Size = New System.Drawing.Size(157, 55)
        Me.Panel15.TabIndex = 9
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button12.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(4, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Button12.Size = New System.Drawing.Size(145, 43)
        Me.Button12.TabIndex = 0
        Me.Button12.Text = "INVENTARIO"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Button5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel10.Size = New System.Drawing.Size(157, 55)
        Me.Panel10.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Button5.Size = New System.Drawing.Size(145, 43)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventario"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightBlue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(160, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel6.Size = New System.Drawing.Size(157, 67)
        Me.Panel6.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(8, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Button2.Size = New System.Drawing.Size(137, 47)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Articulos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(157, 67)
        Me.Panel5.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Button1.Size = New System.Drawing.Size(137, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Articulos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabTermo
        '
        Me.TabTermo.BackColor = System.Drawing.Color.DimGray
        Me.TabTermo.Controls.Add(Me.Panel22)
        Me.TabTermo.Controls.Add(Me.Panel16)
        Me.TabTermo.Controls.Add(Me.Panel14)
        Me.TabTermo.Controls.Add(Me.Panel20)
        Me.TabTermo.Controls.Add(Me.Panel13)
        Me.TabTermo.Controls.Add(Me.Panel7)
        Me.TabTermo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabTermo.ImageIndex = 3
        Me.TabTermo.Location = New System.Drawing.Point(4, 36)
        Me.TabTermo.Name = "TabTermo"
        Me.TabTermo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTermo.Size = New System.Drawing.Size(1173, 73)
        Me.TabTermo.TabIndex = 2
        Me.TabTermo.Text = "TERMOGAS"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.btnUltimosServicios)
        Me.Panel22.Controls.Add(Me.Button4)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(845, 3)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel22.Size = New System.Drawing.Size(322, 67)
        Me.Panel22.TabIndex = 13
        '
        'btnUltimosServicios
        '
        Me.btnUltimosServicios.BackColor = System.Drawing.Color.White
        Me.btnUltimosServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUltimosServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUltimosServicios.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUltimosServicios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUltimosServicios.FlatAppearance.BorderSize = 2
        Me.btnUltimosServicios.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimosServicios.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnUltimosServicios.Image = CType(resources.GetObject("btnUltimosServicios.Image"), System.Drawing.Image)
        Me.btnUltimosServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUltimosServicios.Location = New System.Drawing.Point(142, 8)
        Me.btnUltimosServicios.Name = "btnUltimosServicios"
        Me.btnUltimosServicios.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnUltimosServicios.Size = New System.Drawing.Size(167, 49)
        Me.btnUltimosServicios.TabIndex = 2
        Me.btnUltimosServicios.Text = "Ultimos Servicios"
        Me.btnUltimosServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUltimosServicios.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button4.Size = New System.Drawing.Size(134, 49)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Ultimos Movimientos"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Button14)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(653, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel16.Size = New System.Drawing.Size(192, 67)
        Me.Panel16.TabIndex = 11
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderSize = 2
        Me.Button14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(8, 8)
        Me.Button14.Name = "Button14"
        Me.Button14.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button14.Size = New System.Drawing.Size(174, 49)
        Me.Button14.TabIndex = 1
        Me.Button14.Text = "Reportes"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.Button13)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(461, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel14.Size = New System.Drawing.Size(192, 67)
        Me.Panel14.TabIndex = 10
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button13.FlatAppearance.BorderSize = 2
        Me.Button13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(8, 8)
        Me.Button13.Name = "Button13"
        Me.Button13.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button13.Size = New System.Drawing.Size(176, 51)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "COTIZACIONES"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel20.Controls.Add(Me.btnMantenimiento)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(356, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel20.Size = New System.Drawing.Size(105, 67)
        Me.Panel20.TabIndex = 12
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackColor = System.Drawing.Color.White
        Me.btnMantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnMantenimiento.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.Image = CType(resources.GetObject("btnMantenimiento.Image"), System.Drawing.Image)
        Me.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantenimiento.Location = New System.Drawing.Point(4, 4)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnMantenimiento.Size = New System.Drawing.Size(97, 59)
        Me.btnMantenimiento.TabIndex = 0
        Me.btnMantenimiento.Text = "Mantenimiento"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = False
        Me.btnMantenimiento.Visible = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Teal
        Me.Panel13.Controls.Add(Me.Button7)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(182, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel13.Size = New System.Drawing.Size(174, 67)
        Me.Panel13.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderSize = 2
        Me.Button7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(8, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button7.Size = New System.Drawing.Size(158, 51)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Servicios"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel7.Size = New System.Drawing.Size(179, 67)
        Me.Panel7.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button3.Size = New System.Drawing.Size(171, 59)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "CAMIONES"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabConfigurar
        '
        Me.TabConfigurar.Controls.Add(Me.btnCorreoTG)
        Me.TabConfigurar.Controls.Add(Me.btnUsuarios)
        Me.TabConfigurar.Controls.Add(Me.btnConfigIVA)
        Me.TabConfigurar.Location = New System.Drawing.Point(4, 36)
        Me.TabConfigurar.Name = "TabConfigurar"
        Me.TabConfigurar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfigurar.Size = New System.Drawing.Size(1173, 73)
        Me.TabConfigurar.TabIndex = 4
        Me.TabConfigurar.Text = "Configuraciones"
        Me.TabConfigurar.UseVisualStyleBackColor = True
        '
        'btnCorreoTG
        '
        Me.btnCorreoTG.Location = New System.Drawing.Point(266, 19)
        Me.btnCorreoTG.Name = "btnCorreoTG"
        Me.btnCorreoTG.Size = New System.Drawing.Size(115, 45)
        Me.btnCorreoTG.TabIndex = 2
        Me.btnCorreoTG.Text = "Correos TG"
        Me.btnCorreoTG.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(118, 22)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(122, 38)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnConfigIVA
        '
        Me.btnConfigIVA.Location = New System.Drawing.Point(6, 6)
        Me.btnConfigIVA.Name = "btnConfigIVA"
        Me.btnConfigIVA.Size = New System.Drawing.Size(90, 54)
        Me.btnConfigIVA.TabIndex = 0
        Me.btnConfigIVA.Text = "Valores IVA"
        Me.btnConfigIVA.UseVisualStyleBackColor = True
        '
        'TabCFDI
        '
        Me.TabCFDI.Controls.Add(Me.btnCfdiListaFacturas)
        Me.TabCFDI.Location = New System.Drawing.Point(4, 36)
        Me.TabCFDI.Name = "TabCFDI"
        Me.TabCFDI.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCFDI.Size = New System.Drawing.Size(1173, 73)
        Me.TabCFDI.TabIndex = 5
        Me.TabCFDI.Text = "CFDI Facturas"
        Me.TabCFDI.UseVisualStyleBackColor = True
        '
        'btnCfdiListaFacturas
        '
        Me.btnCfdiListaFacturas.Location = New System.Drawing.Point(16, 6)
        Me.btnCfdiListaFacturas.Name = "btnCfdiListaFacturas"
        Me.btnCfdiListaFacturas.Size = New System.Drawing.Size(121, 61)
        Me.btnCfdiListaFacturas.TabIndex = 0
        Me.btnCfdiListaFacturas.Text = "Lista de Facturas"
        Me.btnCfdiListaFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCfdiListaFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCfdiListaFacturas.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblidUser)
        Me.Panel3.Controls.Add(Me.btnCerrarSesion)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Controls.Add(Me.lblestado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1186, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(93, 113)
        Me.Panel3.TabIndex = 7
        '
        'lblidUser
        '
        Me.lblidUser.AutoSize = True
        Me.lblidUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblidUser.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidUser.ForeColor = System.Drawing.Color.White
        Me.lblidUser.Location = New System.Drawing.Point(0, 105)
        Me.lblidUser.Name = "lblidUser"
        Me.lblidUser.Size = New System.Drawing.Size(13, 13)
        Me.lblidUser.TabIndex = 4
        Me.lblidUser.Text = "0"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 71)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(91, 34)
        Me.btnCerrarSesion.TabIndex = 3
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUser.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(0, 49)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(50, 22)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "name"
        '
        'lblestado
        '
        Me.lblestado.BackColor = System.Drawing.SystemColors.Control
        Me.lblestado.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblestado.Location = New System.Drawing.Point(0, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Padding = New System.Windows.Forms.Padding(2)
        Me.lblestado.Size = New System.Drawing.Size(91, 49)
        Me.lblestado.TabIndex = 0
        Me.lblestado.Text = "estado"
        Me.lblestado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tiempo
        '
        Me.tiempo.Interval = 400
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1284, 345)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIPrincipal"
        Me.Text = "Sistema Tiburon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.tabFacturas.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.tabArticulos.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabTermo.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabConfigurar.ResumeLayout(False)
        Me.TabCFDI.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents tabFacturas As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnFacturasAgregar As System.Windows.Forms.Button
    Friend WithEvents tabArticulos As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabTermo As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregar_prov As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarNP As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnproveedores As System.Windows.Forms.Button
    Friend WithEvents BtnPagos As System.Windows.Forms.Button
    Friend WithEvents btnDeudas As System.Windows.Forms.Button
    Friend WithEvents btnNota As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents lblidUser As System.Windows.Forms.Label
    Friend WithEvents tiempo As System.Windows.Forms.Timer
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabConfigurar As System.Windows.Forms.TabPage
    Friend WithEvents btnConfigIVA As System.Windows.Forms.Button
    Friend WithEvents btnUltimosServicios As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents TabCFDI As System.Windows.Forms.TabPage
    Friend WithEvents btnCfdiListaFacturas As System.Windows.Forms.Button
    Friend WithEvents btnCorreoTG As Button
End Class
