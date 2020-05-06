<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioDeSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioDeSesion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.ingresoPanel = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbData = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.barra = New System.Windows.Forms.ProgressBar()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CBUsuario = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.LinkActualizarSistema = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.ingresoPanel.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.lblinfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 3, 20, 3)
        Me.Panel1.Size = New System.Drawing.Size(499, 70)
        Me.Panel1.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(395, 11)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(91, 51)
        Me.btnConnect.TabIndex = 21
        Me.btnConnect.Text = "Volver a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conectar"
        Me.btnConnect.UseVisualStyleBackColor = True
        Me.btnConnect.Visible = False
        '
        'lblinfo
        '
        Me.lblinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblinfo.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(20, 3)
        Me.lblinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(457, 62)
        Me.lblinfo.TabIndex = 20
        Me.lblinfo.Text = "conectando..."
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ingresoPanel
        '
        Me.ingresoPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.ingresoPanel.Controls.Add(Me.LinkActualizarSistema)
        Me.ingresoPanel.Controls.Add(Me.Panel8)
        Me.ingresoPanel.Controls.Add(Me.Panel7)
        Me.ingresoPanel.Controls.Add(Me.Panel6)
        Me.ingresoPanel.Controls.Add(Me.Panel5)
        Me.ingresoPanel.Controls.Add(Me.Panel2)
        Me.ingresoPanel.Controls.Add(Me.Panel4)
        Me.ingresoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ingresoPanel.Location = New System.Drawing.Point(0, 70)
        Me.ingresoPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ingresoPanel.Name = "ingresoPanel"
        Me.ingresoPanel.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.ingresoPanel.Size = New System.Drawing.Size(499, 392)
        Me.ingresoPanel.TabIndex = 0
        Me.ingresoPanel.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.CbData)
        Me.Panel8.Controls.Add(Me.PictureBox3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(30, 289)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(439, 38)
        Me.Panel8.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(341, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Respaldar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CbData
        '
        Me.CbData.BackColor = System.Drawing.Color.LightGray
        Me.CbData.Dock = System.Windows.Forms.DockStyle.Left
        Me.CbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbData.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbData.ForeColor = System.Drawing.Color.Black
        Me.CbData.FormattingEnabled = True
        Me.CbData.Location = New System.Drawing.Point(43, 5)
        Me.CbData.Name = "CbData"
        Me.CbData.Size = New System.Drawing.Size(241, 28)
        Me.CbData.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.btnCerrar)
        Me.Panel7.Controls.Add(Me.btnaceptar)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(30, 236)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel7.Size = New System.Drawing.Size(439, 53)
        Me.Panel7.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.barra)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(139, 9)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel9.Size = New System.Drawing.Size(202, 35)
        Me.Panel9.TabIndex = 2
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barra.Location = New System.Drawing.Point(3, 3)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(196, 29)
        Me.barra.TabIndex = 0
        Me.barra.Visible = False
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.White
        Me.btnaceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnaceptar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(9, 9)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(130, 35)
        Me.btnaceptar.TabIndex = 0
        Me.btnaceptar.Text = "Iniciar"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(30, 221)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(439, 15)
        Me.Panel6.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtPass)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(30, 116)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(20, 20, 20, 7)
        Me.Panel5.Size = New System.Drawing.Size(439, 105)
        Me.Panel5.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.LightGray
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(20, 60)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(399, 32)
        Me.txtPass.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(150, 0, 150, 0)
        Me.Panel3.Size = New System.Drawing.Size(399, 40)
        Me.Panel3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(202, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CBUsuario)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(30, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 4, 20, 4)
        Me.Panel2.Size = New System.Drawing.Size(439, 90)
        Me.Panel2.TabIndex = 6
        '
        'CBUsuario
        '
        Me.CBUsuario.BackColor = System.Drawing.Color.LightGray
        Me.CBUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBUsuario.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CBUsuario.FormattingEnabled = True
        Me.CBUsuario.Location = New System.Drawing.Point(20, 44)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.Size = New System.Drawing.Size(399, 37)
        Me.CBUsuario.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.PictureBox4)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(20, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(150, 0, 150, 0)
        Me.Panel10.Size = New System.Drawing.Size(399, 40)
        Me.Panel10.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(186, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuario:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(30, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(439, 11)
        Me.Panel4.TabIndex = 1
        '
        'tiempo
        '
        Me.tiempo.Enabled = True
        Me.tiempo.Interval = 600
        '
        'LinkActualizarSistema
        '
        Me.LinkActualizarSistema.AutoSize = True
        Me.LinkActualizarSistema.Location = New System.Drawing.Point(22, 357)
        Me.LinkActualizarSistema.Name = "LinkActualizarSistema"
        Me.LinkActualizarSistema.Size = New System.Drawing.Size(142, 20)
        Me.LinkActualizarSistema.TabIndex = 8
        Me.LinkActualizarSistema.TabStop = True
        Me.LinkActualizarSistema.Text = "Actualizar Sistema"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(341, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(89, 35)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(150, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Size = New System.Drawing.Size(52, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(150, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Size = New System.Drawing.Size(36, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'InicioDeSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(499, 462)
        Me.Controls.Add(Me.ingresoPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(515, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 286)
        Me.Name = "InicioDeSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioDeSesion"
        Me.Panel1.ResumeLayout(False)
        Me.ingresoPanel.ResumeLayout(False)
        Me.ingresoPanel.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ingresoPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CBUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents CbData As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents tiempo As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkActualizarSistema As System.Windows.Forms.LinkLabel
End Class
