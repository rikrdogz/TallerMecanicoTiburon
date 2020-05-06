<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion_RenglonEdit
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblventana = New System.Windows.Forms.Label()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Nprecio = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nmano = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ncosto = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NCant = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Nprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nmano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel2.Size = New System.Drawing.Size(793, 193)
        Me.Panel2.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblventana)
        Me.Panel6.Controls.Add(Me.lblindex)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.btnAgregar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(12, 124)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel6.Size = New System.Drawing.Size(765, 48)
        Me.Panel6.TabIndex = 3
        '
        'lblventana
        '
        Me.lblventana.BackColor = System.Drawing.Color.Transparent
        Me.lblventana.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblventana.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblventana.Location = New System.Drawing.Point(155, 7)
        Me.lblventana.Name = "lblventana"
        Me.lblventana.Size = New System.Drawing.Size(99, 34)
        Me.lblventana.TabIndex = 9
        Me.lblventana.Text = "ventana"
        Me.lblventana.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblindex
        '
        Me.lblindex.BackColor = System.Drawing.Color.Transparent
        Me.lblindex.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblindex.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblindex.Location = New System.Drawing.Point(116, 7)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(39, 34)
        Me.lblindex.TabIndex = 8
        Me.lblindex.Text = "0"
        Me.lblindex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(649, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(109, 34)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Nprecio)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Nmano)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Ncosto)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(12, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(765, 50)
        Me.Panel5.TabIndex = 2
        '
        'Nprecio
        '
        Me.Nprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nprecio.DecimalPlaces = 2
        Me.Nprecio.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nprecio.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nprecio.Location = New System.Drawing.Point(598, 5)
        Me.Nprecio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Nprecio.Name = "Nprecio"
        Me.Nprecio.Size = New System.Drawing.Size(150, 36)
        Me.Nprecio.TabIndex = 12
        Me.Nprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(510, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 38)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nmano
        '
        Me.Nmano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nmano.DecimalPlaces = 2
        Me.Nmano.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nmano.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nmano.Location = New System.Drawing.Point(360, 5)
        Me.Nmano.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Nmano.Name = "Nmano"
        Me.Nmano.Size = New System.Drawing.Size(150, 36)
        Me.Nmano.TabIndex = 10
        Me.Nmano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mano:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ncosto
        '
        Me.Ncosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ncosto.DecimalPlaces = 2
        Me.Ncosto.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ncosto.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ncosto.Location = New System.Drawing.Point(73, 5)
        Me.Ncosto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Ncosto.Name = "Ncosto"
        Me.Ncosto.Size = New System.Drawing.Size(199, 36)
        Me.Ncosto.TabIndex = 8
        Me.Ncosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Costo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(12, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(765, 15)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtdesc)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.NCant)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(765, 47)
        Me.Panel3.TabIndex = 0
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtdesc.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(233, 5)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(494, 36)
        Me.txtdesc.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Desc:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NCant
        '
        Me.NCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NCant.Dock = System.Windows.Forms.DockStyle.Left
        Me.NCant.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCant.Location = New System.Drawing.Point(73, 5)
        Me.NCant.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NCant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NCant.Name = "NCant"
        Me.NCant.Size = New System.Drawing.Size(81, 36)
        Me.NCant.TabIndex = 6
        Me.NCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cant:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCotizacion_RenglonEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "frmCotizacion_RenglonEdit"
        Me.Text = "frmCotizacion_RenglonEdit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.Nprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nmano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblindex As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Nprecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Nmano As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ncosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblventana As System.Windows.Forms.Label
End Class
