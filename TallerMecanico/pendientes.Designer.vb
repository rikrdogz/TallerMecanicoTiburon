<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendientes
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pendientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.opcionesPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.opcionesPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblUnidad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(1009, 44)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(323, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Servicios Pendientes o sin Cotizar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnidad
        '
        Me.lblUnidad.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblUnidad.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(79, 4)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(353, 36)
        Me.lblUnidad.TabIndex = 1
        Me.lblUnidad.Text = "Unidad:"
        Me.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.AllowUserToDeleteRows = False
        Me.tabla.AllowUserToResizeRows = False
        Me.tabla.BackgroundColor = System.Drawing.Color.White
        Me.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cant, Me.idinv, Me.np, Me.desc, Me.precio, Me.serv, Me.cot, Me.fecha, Me.estado, Me.OC, Me.observ})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla.DefaultCellStyle = DataGridViewCellStyle6
        Me.tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabla.EnableHeadersVisualStyles = False
        Me.tabla.Location = New System.Drawing.Point(0, 96)
        Me.tabla.MultiSelect = False
        Me.tabla.Name = "tabla"
        Me.tabla.ReadOnly = True
        Me.tabla.RowHeadersVisible = False
        Me.tabla.RowTemplate.Height = 32
        Me.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla.Size = New System.Drawing.Size(1009, 194)
        Me.tabla.TabIndex = 1
        '
        'opcionesPanel
        '
        Me.opcionesPanel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.opcionesPanel.Controls.Add(Me.Panel2)
        Me.opcionesPanel.Controls.Add(Me.Panel3)
        Me.opcionesPanel.Controls.Add(Me.Label3)
        Me.opcionesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.opcionesPanel.Location = New System.Drawing.Point(0, 44)
        Me.opcionesPanel.Name = "opcionesPanel"
        Me.opcionesPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.opcionesPanel.Size = New System.Drawing.Size(1009, 52)
        Me.opcionesPanel.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbldesc)
        Me.Panel2.Controls.Add(Me.lblServicio)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(165, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Panel2.Size = New System.Drawing.Size(497, 44)
        Me.Panel2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 44)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(241, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 44)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Orden de Compra:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldesc
        '
        Me.lbldesc.BackColor = System.Drawing.Color.White
        Me.lbldesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbldesc.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(88, 0)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(153, 44)
        Me.lbldesc.TabIndex = 2
        Me.lbldesc.Text = "Servicio Seleccionado:"
        Me.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServicio
        '
        Me.lblServicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblServicio.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(20, 0)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(68, 44)
        Me.lblServicio.TabIndex = 1
        Me.lblServicio.Text = "0"
        Me.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnAbrir)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(662, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Panel3.Size = New System.Drawing.Size(343, 44)
        Me.Panel3.TabIndex = 6
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.White
        Me.btnAbrir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAbrir.Image = CType(resources.GetObject("btnAbrir.Image"), System.Drawing.Image)
        Me.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrir.Location = New System.Drawing.Point(20, 0)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(139, 42)
        Me.btnAbrir.TabIndex = 3
        Me.btnAbrir.Text = "Abrir Servicio"
        Me.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(179, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(142, 42)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo Servicio"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 44)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Servicio Seleccionado:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cant
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cant.DefaultCellStyle = DataGridViewCellStyle1
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 40
        '
        'idinv
        '
        Me.idinv.HeaderText = "idInv"
        Me.idinv.MinimumWidth = 60
        Me.idinv.Name = "idinv"
        Me.idinv.ReadOnly = True
        Me.idinv.Width = 60
        '
        'np
        '
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        Me.np.ReadOnly = True
        '
        'desc
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc.DefaultCellStyle = DataGridViewCellStyle2
        Me.desc.HeaderText = "desc"
        Me.desc.MinimumWidth = 300
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.Width = 300
        '
        'precio
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 85
        '
        'serv
        '
        Me.serv.HeaderText = "serv"
        Me.serv.Name = "serv"
        Me.serv.ReadOnly = True
        Me.serv.Width = 80
        '
        'cot
        '
        Me.cot.HeaderText = "cot"
        Me.cot.MinimumWidth = 100
        Me.cot.Name = "cot"
        Me.cot.ReadOnly = True
        '
        'fecha
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'estado
        '
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 110
        '
        'OC
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OC.DefaultCellStyle = DataGridViewCellStyle5
        Me.OC.HeaderText = "OC"
        Me.OC.Name = "OC"
        Me.OC.ReadOnly = True
        Me.OC.Width = 80
        '
        'observ
        '
        Me.observ.HeaderText = "Observación"
        Me.observ.MinimumWidth = 140
        Me.observ.Name = "observ"
        Me.observ.ReadOnly = True
        Me.observ.Width = 140
        '
        'pendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 290)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.opcionesPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pendientes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.opcionesPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents opcionesPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
