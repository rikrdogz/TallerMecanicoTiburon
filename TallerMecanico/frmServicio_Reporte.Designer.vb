<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicio_Reporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbla = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbla)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 48)
        Me.Panel1.TabIndex = 0
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(522, 15)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(39, 13)
        Me.lbla.TabIndex = 3
        Me.lbla.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(310, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Filtras Solo con OC"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(184, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Padding = New System.Windows.Forms.Padding(20, 0, 10, 0)
        Me.lbltotal.Size = New System.Drawing.Size(88, 25)
        Me.lbltotal.TabIndex = 1
        Me.lbltotal.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicios Pendientes Con OC"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tabla)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(941, 281)
        Me.Panel2.TabIndex = 1
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.AllowUserToDeleteRows = False
        Me.tabla.AllowUserToResizeRows = False
        Me.tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cant, Me.np, Me.desc, Me.atq, Me.idInv, Me.precio, Me.importe, Me.Existencia, Me.serv, Me.cot, Me.fecha, Me.oc, Me.fac})
        Me.tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabla.Location = New System.Drawing.Point(9, 9)
        Me.tabla.Name = "tabla"
        Me.tabla.ReadOnly = True
        Me.tabla.RowHeadersVisible = False
        Me.tabla.Size = New System.Drawing.Size(923, 263)
        Me.tabla.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 45
        '
        'cant
        '
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 35
        '
        'np
        '
        Me.np.HeaderText = "np"
        Me.np.Name = "np"
        Me.np.ReadOnly = True
        Me.np.Width = 120
        '
        'desc
        '
        Me.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'atq
        '
        Me.atq.HeaderText = "atq"
        Me.atq.Name = "atq"
        Me.atq.ReadOnly = True
        Me.atq.Width = 80
        '
        'idInv
        '
        Me.idInv.HeaderText = "idINV"
        Me.idInv.Name = "idInv"
        Me.idInv.ReadOnly = True
        Me.idInv.Width = 25
        '
        'precio
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle1
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 65
        '
        'importe
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle2
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 75
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 40
        '
        'serv
        '
        Me.serv.HeaderText = "serv"
        Me.serv.Name = "serv"
        Me.serv.ReadOnly = True
        Me.serv.Width = 45
        '
        'cot
        '
        Me.cot.HeaderText = "cot"
        Me.cot.Name = "cot"
        Me.cot.ReadOnly = True
        Me.cot.Width = 45
        '
        'fecha
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 75
        '
        'oc
        '
        Me.oc.HeaderText = "oc"
        Me.oc.Name = "oc"
        Me.oc.ReadOnly = True
        Me.oc.Width = 65
        '
        'fac
        '
        Me.fac.HeaderText = "fac"
        Me.fac.Name = "fac"
        Me.fac.ReadOnly = True
        '
        'frmServicio_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 329)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmServicio_Reporte"
        Me.Text = "frmServicio_Reporte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents atq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fac As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
