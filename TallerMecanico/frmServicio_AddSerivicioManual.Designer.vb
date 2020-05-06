<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicio_AddSerivicioManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicio_AddSerivicioManual))
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NImpPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Nprecio = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NCant = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NImpMano = New System.Windows.Forms.NumericUpDown()
        Me.Nmano = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Ncosto = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NTotal = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.NImpPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.NImpMano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nmano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Ncosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(164, 8)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(391, 35)
        Me.txtdesc.TabIndex = 15
        Me.txtdesc.TabStop = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(483, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 39)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Importe (Precio):"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NImpPrecio
        '
        Me.NImpPrecio.BackColor = System.Drawing.Color.White
        Me.NImpPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NImpPrecio.DecimalPlaces = 2
        Me.NImpPrecio.Dock = System.Windows.Forms.DockStyle.Right
        Me.NImpPrecio.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NImpPrecio.ForeColor = System.Drawing.Color.Black
        Me.NImpPrecio.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NImpPrecio.InterceptArrowKeys = False
        Me.NImpPrecio.Location = New System.Drawing.Point(611, 4)
        Me.NImpPrecio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NImpPrecio.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NImpPrecio.Name = "NImpPrecio"
        Me.NImpPrecio.ReadOnly = True
        Me.NImpPrecio.Size = New System.Drawing.Size(173, 32)
        Me.NImpPrecio.TabIndex = 14
        Me.NImpPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nprecio
        '
        Me.Nprecio.DecimalPlaces = 2
        Me.Nprecio.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nprecio.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nprecio.Location = New System.Drawing.Point(319, 4)
        Me.Nprecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Nprecio.Name = "Nprecio"
        Me.Nprecio.Size = New System.Drawing.Size(190, 36)
        Me.Nprecio.TabIndex = 8
        Me.Nprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(163, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NCant
        '
        Me.NCant.Dock = System.Windows.Forms.DockStyle.Left
        Me.NCant.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCant.Location = New System.Drawing.Point(77, 4)
        Me.NCant.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NCant.Name = "NCant"
        Me.NCant.Size = New System.Drawing.Size(86, 36)
        Me.NCant.TabIndex = 6
        Me.NCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.NImpPrecio)
        Me.Panel4.Controls.Add(Me.Nprecio)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.NCant)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel4.Size = New System.Drawing.Size(790, 49)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cant:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.NImpMano)
        Me.Panel5.Controls.Add(Me.Nmano)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(8, 57)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel5.Size = New System.Drawing.Size(790, 49)
        Me.Panel5.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(483, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 39)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Importe (M/O):"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NImpMano
        '
        Me.NImpMano.BackColor = System.Drawing.Color.White
        Me.NImpMano.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NImpMano.DecimalPlaces = 2
        Me.NImpMano.Dock = System.Windows.Forms.DockStyle.Right
        Me.NImpMano.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NImpMano.ForeColor = System.Drawing.Color.Black
        Me.NImpMano.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NImpMano.InterceptArrowKeys = False
        Me.NImpMano.Location = New System.Drawing.Point(611, 4)
        Me.NImpMano.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NImpMano.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NImpMano.Name = "NImpMano"
        Me.NImpMano.ReadOnly = True
        Me.NImpMano.Size = New System.Drawing.Size(173, 32)
        Me.NImpMano.TabIndex = 12
        Me.NImpMano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nmano
        '
        Me.Nmano.DecimalPlaces = 2
        Me.Nmano.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nmano.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nmano.Location = New System.Drawing.Point(83, 4)
        Me.Nmano.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Nmano.Name = "Nmano"
        Me.Nmano.Size = New System.Drawing.Size(190, 36)
        Me.Nmano.TabIndex = 8
        Me.Nmano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 39)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mano:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(483, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 39)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Importe TOTAL:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Ncosto)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.NTotal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(8, 106)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel6.Size = New System.Drawing.Size(790, 49)
        Me.Panel6.TabIndex = 2
        '
        'Ncosto
        '
        Me.Ncosto.DecimalPlaces = 2
        Me.Ncosto.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ncosto.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ncosto.Location = New System.Drawing.Point(114, 4)
        Me.Ncosto.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Ncosto.Name = "Ncosto"
        Me.Ncosto.Size = New System.Drawing.Size(190, 36)
        Me.Ncosto.TabIndex = 15
        Me.Ncosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 39)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Costo ($) :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NTotal
        '
        Me.NTotal.BackColor = System.Drawing.Color.White
        Me.NTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NTotal.DecimalPlaces = 2
        Me.NTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.NTotal.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NTotal.ForeColor = System.Drawing.Color.Black
        Me.NTotal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NTotal.InterceptArrowKeys = False
        Me.NTotal.Location = New System.Drawing.Point(611, 4)
        Me.NTotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NTotal.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NTotal.Name = "NTotal"
        Me.NTotal.ReadOnly = True
        Me.NTotal.Size = New System.Drawing.Size(173, 32)
        Me.NTotal.TabIndex = 12
        Me.NTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel2.Size = New System.Drawing.Size(806, 166)
        Me.Panel2.TabIndex = 3
        '
        'lblindex
        '
        Me.lblindex.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblindex.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblindex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblindex.Location = New System.Drawing.Point(137, 8)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(27, 44)
        Me.lblindex.TabIndex = 5
        Me.lblindex.Text = "0"
        Me.lblindex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Agregar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(39, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(63, 28)
        Me.btnClose.TabIndex = 11
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(567, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 44)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(686, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel3.Size = New System.Drawing.Size(110, 44)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtdesc)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblindex)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(806, 62)
        Me.Panel1.TabIndex = 2
        '
        'frmServicio_AddSerivicioManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 228)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmServicio_AddSerivicioManual"
        Me.Text = "frmServicio_AddSerivicioManual"
        CType(Me.NImpPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.NImpMano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nmano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.Ncosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NImpPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nprecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents NImpMano As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nmano As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Ncosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblindex As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
