<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAviso
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botones = New System.Windows.Forms.Panel()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSI = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.botones.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.botones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel1.Size = New System.Drawing.Size(703, 70)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel4.Size = New System.Drawing.Size(528, 65)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estos elementos en Verde se restaran del Inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "¿DESEAS CONTINUAR?"
        '
        'botones
        '
        Me.botones.Controls.Add(Me.btnCLose)
        Me.botones.Controls.Add(Me.Panel3)
        Me.botones.Controls.Add(Me.btnSI)
        Me.botones.Dock = System.Windows.Forms.DockStyle.Right
        Me.botones.Location = New System.Drawing.Point(528, 0)
        Me.botones.Name = "botones"
        Me.botones.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.botones.Size = New System.Drawing.Size(175, 65)
        Me.botones.TabIndex = 1
        '
        'btnCLose
        '
        Me.btnCLose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCLose.Location = New System.Drawing.Point(98, 0)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(66, 65)
        Me.btnCLose.TabIndex = 1
        Me.btnCLose.Text = "NO"
        Me.btnCLose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(80, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 65)
        Me.Panel3.TabIndex = 2
        '
        'btnSI
        '
        Me.btnSI.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSI.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSI.Location = New System.Drawing.Point(5, 0)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(75, 65)
        Me.btnSI.TabIndex = 3
        Me.btnSI.Text = "SI"
        Me.btnSI.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tabla)
        Me.Panel2.Controls.Add(Me.lblResultados)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(703, 358)
        Me.Panel2.TabIndex = 1
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.AllowUserToDeleteRows = False
        Me.tabla.AllowUserToResizeRows = False
        Me.tabla.BackgroundColor = System.Drawing.Color.White
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cant, Me.desc, Me.Column3})
        Me.tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabla.EnableHeadersVisualStyles = False
        Me.tabla.Location = New System.Drawing.Point(0, 0)
        Me.tabla.Name = "tabla"
        Me.tabla.ReadOnly = True
        Me.tabla.RowHeadersVisible = False
        Me.tabla.RowTemplate.Height = 28
        Me.tabla.Size = New System.Drawing.Size(703, 335)
        Me.tabla.TabIndex = 1
        '
        'cant
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cant.DefaultCellStyle = DataGridViewCellStyle1
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 180
        '
        'desc
        '
        Me.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.desc.HeaderText = "pieza"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "marcado"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 180
        '
        'lblResultados
        '
        Me.lblResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblResultados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblResultados.Location = New System.Drawing.Point(0, 335)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(703, 23)
        Me.lblResultados.TabIndex = 0
        Me.lblResultados.Text = "RESULT"
        '
        'frmAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 428)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAviso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.botones.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents lblResultados As System.Windows.Forms.Label
    Friend WithEvents btnCLose As System.Windows.Forms.Button
    Friend WithEvents btnSI As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents botones As System.Windows.Forms.Panel
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
