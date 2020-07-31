<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfigCorreos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridCorreos = New System.Windows.Forms.DataGridView()
        Me.idcorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.acciones = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardarCorreo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreoPara = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de correos con copia TODOGAS"
        '
        'GridCorreos
        '
        Me.GridCorreos.AllowUserToAddRows = False
        Me.GridCorreos.AllowUserToDeleteRows = False
        Me.GridCorreos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.GridCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCorreos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcorreo, Me.correo, Me.contacto, Me.activo, Me.acciones})
        Me.GridCorreos.Location = New System.Drawing.Point(36, 108)
        Me.GridCorreos.Name = "GridCorreos"
        Me.GridCorreos.ReadOnly = True
        Me.GridCorreos.Size = New System.Drawing.Size(594, 168)
        Me.GridCorreos.TabIndex = 1
        '
        'idcorreo
        '
        Me.idcorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idcorreo.HeaderText = "idcorreo"
        Me.idcorreo.Name = "idcorreo"
        Me.idcorreo.ReadOnly = True
        Me.idcorreo.Width = 91
        '
        'correo
        '
        Me.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.correo.HeaderText = "correo"
        Me.correo.MinimumWidth = 150
        Me.correo.Name = "correo"
        Me.correo.ReadOnly = True
        '
        'contacto
        '
        Me.contacto.HeaderText = "contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        '
        'activo
        '
        Me.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.activo.HeaderText = "activo"
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        Me.activo.Width = 56
        '
        'acciones
        '
        Me.acciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.acciones.HeaderText = "acciones"
        Me.acciones.Name = "acciones"
        Me.acciones.ReadOnly = True
        Me.acciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.acciones.Width = 97
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGuardarCorreo)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(36, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 162)
        Me.Panel1.TabIndex = 2
        '
        'btnGuardarCorreo
        '
        Me.btnGuardarCorreo.Location = New System.Drawing.Point(429, 107)
        Me.btnGuardarCorreo.Name = "btnGuardarCorreo"
        Me.btnGuardarCorreo.Size = New System.Drawing.Size(107, 32)
        Me.btnGuardarCorreo.TabIndex = 5
        Me.btnGuardarCorreo.Text = "Agregar"
        Me.btnGuardarCorreo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(188, 75)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(348, 26)
        Me.txtNombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre del contacto:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(79, 43)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(457, 26)
        Me.txtCorreo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Correo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Agregar Correo"
        '
        'txtCorreoPara
        '
        Me.txtCorreoPara.Location = New System.Drawing.Point(174, 21)
        Me.txtCorreoPara.Name = "txtCorreoPara"
        Me.txtCorreoPara.Size = New System.Drawing.Size(387, 26)
        Me.txtCorreoPara.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Correo Dirigido a:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cambiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmConfigCorreos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCorreoPara)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridCorreos)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmConfigCorreos"
        Me.Text = "frmConfigCorreos"
        CType(Me.GridCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GridCorreos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardarCorreo As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idcorreo As DataGridViewTextBoxColumn
    Friend WithEvents correo As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewCheckBoxColumn
    Friend WithEvents acciones As DataGridViewButtonColumn
    Friend WithEvents txtCorreoPara As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
