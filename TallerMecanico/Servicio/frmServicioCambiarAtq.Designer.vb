<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicioCambiarAtq
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
        Me.GridCamiones = New System.Windows.Forms.DataGridView()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIDatq = New System.Windows.Forms.Label()
        Me.lblInfoCamion = New System.Windows.Forms.Label()
        Me.ColIdCamion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAtq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTexto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.GridCamiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblInfoCamion)
        Me.Panel1.Controls.Add(Me.lblIDatq)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblIdServicio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 83)
        Me.Panel1.TabIndex = 0
        '
        'GridCamiones
        '
        Me.GridCamiones.AllowUserToAddRows = False
        Me.GridCamiones.AllowUserToDeleteRows = False
        Me.GridCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCamiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdCamion, Me.ColAtq, Me.ColRuta, Me.ColActivo, Me.ColTexto, Me.ColMarca, Me.ColAño})
        Me.GridCamiones.Location = New System.Drawing.Point(8, 89)
        Me.GridCamiones.Name = "GridCamiones"
        Me.GridCamiones.ReadOnly = True
        Me.GridCamiones.Size = New System.Drawing.Size(572, 150)
        Me.GridCamiones.TabIndex = 1
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(422, 245)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(140, 23)
        Me.btnCambiar.TabIndex = 2
        Me.btnCambiar.Text = "Cambiar / Aceptar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicio:"
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.Location = New System.Drawing.Point(59, 9)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(13, 13)
        Me.lblIdServicio.TabIndex = 1
        Me.lblIdServicio.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ATQ:"
        '
        'lblIDatq
        '
        Me.lblIDatq.AutoSize = True
        Me.lblIDatq.Location = New System.Drawing.Point(59, 36)
        Me.lblIDatq.Name = "lblIDatq"
        Me.lblIDatq.Size = New System.Drawing.Size(13, 13)
        Me.lblIDatq.TabIndex = 3
        Me.lblIDatq.Text = "0"
        '
        'lblInfoCamion
        '
        Me.lblInfoCamion.AutoSize = True
        Me.lblInfoCamion.Location = New System.Drawing.Point(110, 36)
        Me.lblInfoCamion.Name = "lblInfoCamion"
        Me.lblInfoCamion.Size = New System.Drawing.Size(32, 13)
        Me.lblInfoCamion.TabIndex = 4
        Me.lblInfoCamion.Text = "ATQ:"
        '
        'ColIdCamion
        '
        Me.ColIdCamion.HeaderText = "id"
        Me.ColIdCamion.Name = "ColIdCamion"
        Me.ColIdCamion.ReadOnly = True
        '
        'ColAtq
        '
        Me.ColAtq.HeaderText = "Atq"
        Me.ColAtq.Name = "ColAtq"
        Me.ColAtq.ReadOnly = True
        '
        'ColRuta
        '
        Me.ColRuta.HeaderText = "Ruta"
        Me.ColRuta.Name = "ColRuta"
        Me.ColRuta.ReadOnly = True
        '
        'ColActivo
        '
        Me.ColActivo.HeaderText = "ColActivo"
        Me.ColActivo.Name = "ColActivo"
        Me.ColActivo.ReadOnly = True
        '
        'ColTexto
        '
        Me.ColTexto.HeaderText = "Texto"
        Me.ColTexto.Name = "ColTexto"
        Me.ColTexto.ReadOnly = True
        '
        'ColMarca
        '
        Me.ColMarca.HeaderText = "Marca"
        Me.ColMarca.Name = "ColMarca"
        Me.ColMarca.ReadOnly = True
        '
        'ColAño
        '
        Me.ColAño.HeaderText = "Año"
        Me.ColAño.Name = "ColAño"
        Me.ColAño.ReadOnly = True
        '
        'frmServicioCambiarAtq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 271)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.GridCamiones)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmServicioCambiarAtq"
        Me.Text = "frmServicioCambiarAtq"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridCamiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridCamiones As System.Windows.Forms.DataGridView
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents lblInfoCamion As System.Windows.Forms.Label
    Friend WithEvents lblIDatq As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIdServicio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColIdCamion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAtq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRuta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColActivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTexto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAño As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
