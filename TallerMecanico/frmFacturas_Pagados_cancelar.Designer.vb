<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturas_Pagados_cancelar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblrefa = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblidpago = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.GridAbonos = New System.Windows.Forms.DataGridView()
        Me.ColIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAbonado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblrefa)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblfecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblidpago)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 66)
        Me.Panel1.TabIndex = 0
        '
        'lblrefa
        '
        Me.lblrefa.AutoSize = True
        Me.lblrefa.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrefa.Location = New System.Drawing.Point(367, 6)
        Me.lblrefa.Name = "lblrefa"
        Me.lblrefa.Size = New System.Drawing.Size(40, 18)
        Me.lblrefa.TabIndex = 6
        Me.lblrefa.Text = "refa"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(236, 36)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(45, 19)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "total:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(65, 36)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(88, 18)
        Me.lblfecha.TabIndex = 3
        Me.lblfecha.Text = "00/00/0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "fecha:"
        '
        'lblidpago
        '
        Me.lblidpago.AutoSize = True
        Me.lblidpago.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidpago.Location = New System.Drawing.Point(192, 6)
        Me.lblidpago.Name = "lblidpago"
        Me.lblidpago.Size = New System.Drawing.Size(20, 22)
        Me.lblidpago.TabIndex = 1
        Me.lblidpago.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Se cancelará este pago:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(706, 304)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GridAbonos)
        Me.Panel3.Controls.Add(Me.txtpass)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(9, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(688, 237)
        Me.Panel3.TabIndex = 0
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(6, 32)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(197, 30)
        Me.txtpass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese contraseña para continuar"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btnSi)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(9, 246)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(688, 49)
        Me.Panel4.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "NO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aplicar cancelación?"
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(178, 6)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(70, 31)
        Me.btnSi.TabIndex = 0
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'GridAbonos
        '
        Me.GridAbonos.AllowUserToAddRows = False
        Me.GridAbonos.AllowUserToDeleteRows = False
        Me.GridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAbonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdDetalle, Me.ColIdFactura, Me.ColFolio, Me.ColAbonado, Me.ColTotalFactura})
        Me.GridAbonos.Location = New System.Drawing.Point(7, 68)
        Me.GridAbonos.Name = "GridAbonos"
        Me.GridAbonos.ReadOnly = True
        Me.GridAbonos.Size = New System.Drawing.Size(676, 150)
        Me.GridAbonos.TabIndex = 2
        '
        'ColIdDetalle
        '
        Me.ColIdDetalle.HeaderText = "IdDetalle"
        Me.ColIdDetalle.Name = "ColIdDetalle"
        Me.ColIdDetalle.ReadOnly = True
        '
        'ColIdFactura
        '
        Me.ColIdFactura.HeaderText = "IdFactura"
        Me.ColIdFactura.Name = "ColIdFactura"
        Me.ColIdFactura.ReadOnly = True
        '
        'ColFolio
        '
        Me.ColFolio.HeaderText = "Folio"
        Me.ColFolio.Name = "ColFolio"
        Me.ColFolio.ReadOnly = True
        '
        'ColAbonado
        '
        Me.ColAbonado.HeaderText = "Abonado"
        Me.ColAbonado.Name = "ColAbonado"
        Me.ColAbonado.ReadOnly = True
        '
        'ColTotalFactura
        '
        Me.ColTotalFactura.HeaderText = "Total de Factura"
        Me.ColTotalFactura.Name = "ColTotalFactura"
        Me.ColTotalFactura.ReadOnly = True
        '
        'frmFacturas_Pagados_cancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 370)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacturas_Pagados_cancelar"
        Me.Text = "frmFacturas_Pagados_cancelar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GridAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblidpago As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents lblrefa As System.Windows.Forms.Label
    Friend WithEvents GridAbonos As System.Windows.Forms.DataGridView
    Friend WithEvents ColIdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIdFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAbonado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
