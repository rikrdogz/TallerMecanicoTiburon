<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos_aviso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos_aviso))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_id_inv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblactivo = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblcantidad_articulo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblexistencia = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblnp = New System.Windows.Forms.Label()
        Me.lbleste = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lista_articulos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_id_inv)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 176)
        Me.Panel1.TabIndex = 0
        '
        'lbl_id_inv
        '
        Me.lbl_id_inv.AutoSize = True
        Me.lbl_id_inv.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_id_inv.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_inv.Location = New System.Drawing.Point(353, 150)
        Me.lbl_id_inv.Name = "lbl_id_inv"
        Me.lbl_id_inv.Size = New System.Drawing.Size(24, 25)
        Me.lbl_id_inv.TabIndex = 8
        Me.lbl_id_inv.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Su numero de Inventario es:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblactivo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(131, 120)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(730, 30)
        Me.Panel7.TabIndex = 6
        '
        'lblactivo
        '
        Me.lblactivo.AutoSize = True
        Me.lblactivo.BackColor = System.Drawing.Color.Yellow
        Me.lblactivo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblactivo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactivo.Location = New System.Drawing.Point(5, 5)
        Me.lblactivo.Name = "lblactivo"
        Me.lblactivo.Size = New System.Drawing.Size(40, 19)
        Me.lblactivo.TabIndex = 5
        Me.lblactivo.Text = "está"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbltipo)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.lblcantidad_articulo)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(131, 90)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(730, 30)
        Me.Panel6.TabIndex = 5
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltipo.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(347, 5)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(21, 23)
        Me.lbltipo.TabIndex = 7
        Me.lbltipo.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "es tipo:"
        '
        'lblcantidad_articulo
        '
        Me.lblcantidad_articulo.AutoSize = True
        Me.lblcantidad_articulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblcantidad_articulo.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad_articulo.Location = New System.Drawing.Point(264, 5)
        Me.lblcantidad_articulo.Name = "lblcantidad_articulo"
        Me.lblcantidad_articulo.Size = New System.Drawing.Size(21, 23)
        Me.lblcantidad_articulo.TabIndex = 5
        Me.lblcantidad_articulo.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(259, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "cantidad por articulo ingresado:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblexistencia)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(131, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(730, 30)
        Me.Panel5.TabIndex = 4
        '
        'lblexistencia
        '
        Me.lblexistencia.AutoSize = True
        Me.lblexistencia.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblexistencia.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexistencia.Location = New System.Drawing.Point(250, 5)
        Me.lblexistencia.Name = "lblexistencia"
        Me.lblexistencia.Size = New System.Drawing.Size(21, 23)
        Me.lblexistencia.TabIndex = 5
        Me.lblexistencia.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "con la cantidad de existencia:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbldesc)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(131, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(730, 30)
        Me.Panel4.TabIndex = 3
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbldesc.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(283, 5)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(55, 23)
        Me.lbldesc.TabIndex = 5
        Me.lbldesc.Text = "desc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "con la descripcion de invetario de:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblnp)
        Me.Panel3.Controls.Add(Me.lbleste)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(131, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(730, 30)
        Me.Panel3.TabIndex = 2
        '
        'lblnp
        '
        Me.lblnp.AutoSize = True
        Me.lblnp.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblnp.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnp.Location = New System.Drawing.Point(409, 5)
        Me.lblnp.Name = "lblnp"
        Me.lblnp.Size = New System.Drawing.Size(34, 23)
        Me.lblnp.TabIndex = 1
        Me.lblnp.Text = "np"
        '
        'lbleste
        '
        Me.lbleste.AutoSize = True
        Me.lbleste.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbleste.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleste.Location = New System.Drawing.Point(5, 5)
        Me.lbleste.Name = "lbleste"
        Me.lbleste.Size = New System.Drawing.Size(404, 19)
        Me.lbleste.TabIndex = 0
        Me.lbleste.Text = "Este articulo/servicio existe con el Numero de parte:"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 176)
        Me.Panel2.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 176)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel8.Size = New System.Drawing.Size(861, 146)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lista_articulos)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(8, 8)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel9.Size = New System.Drawing.Size(828, 130)
        Me.Panel9.TabIndex = 0
        '
        'lista_articulos
        '
        Me.lista_articulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_articulos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_articulos.FormattingEnabled = True
        Me.lista_articulos.ItemHeight = 21
        Me.lista_articulos.Location = New System.Drawing.Point(5, 26)
        Me.lista_articulos.Name = "lista_articulos"
        Me.lista_articulos.Size = New System.Drawing.Size(818, 99)
        Me.lista_articulos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulos relacionados"
        '
        'frmArticulos_aviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 322)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulos_aviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArticulos_aviso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblcantidad_articulo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblexistencia As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblnp As System.Windows.Forms.Label
    Friend WithEvents lbleste As System.Windows.Forms.Label
    Friend WithEvents lblactivo As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_inv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lista_articulos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
