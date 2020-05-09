<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarCotizacion
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
        Me.lblNumCotizacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCorreoDe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtCuerpoCorreo = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.lblNumCotizacion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 43)
        Me.Panel1.TabIndex = 0
        '
        'lblNumCotizacion
        '
        Me.lblNumCotizacion.AutoSize = True
        Me.lblNumCotizacion.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCotizacion.Location = New System.Drawing.Point(193, 7)
        Me.lblNumCotizacion.Name = "lblNumCotizacion"
        Me.lblNumCotizacion.Size = New System.Drawing.Size(30, 32)
        Me.lblNumCotizacion.TabIndex = 1
        Me.lblNumCotizacion.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enviar Cotización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Para"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(87, 44)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(181, 24)
        Me.lblCorreo.TabIndex = 3
        Me.lblCorreo.Text = "correo@correo.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Asunto"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblCorreoDe)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtAsunto)
        Me.Panel2.Controls.Add(Me.txtCuerpoCorreo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblCorreo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Location = New System.Drawing.Point(12, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 252)
        Me.Panel2.TabIndex = 3
        '
        'lblCorreoDe
        '
        Me.lblCorreoDe.AutoSize = True
        Me.lblCorreoDe.Location = New System.Drawing.Point(87, 10)
        Me.lblCorreoDe.Name = "lblCorreoDe"
        Me.lblCorreoDe.Size = New System.Drawing.Size(181, 24)
        Me.lblCorreoDe.TabIndex = 10
        Me.lblCorreoDe.Text = "correo@correo.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "De"
        '
        'txtAsunto
        '
        Me.txtAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtAsunto.Location = New System.Drawing.Point(91, 80)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(524, 46)
        Me.txtAsunto.TabIndex = 8
        Me.txtAsunto.TabStop = False
        '
        'txtCuerpoCorreo
        '
        Me.txtCuerpoCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCuerpoCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuerpoCorreo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtCuerpoCorreo.Location = New System.Drawing.Point(19, 132)
        Me.txtCuerpoCorreo.Multiline = True
        Me.txtCuerpoCorreo.Name = "txtCuerpoCorreo"
        Me.txtCuerpoCorreo.Size = New System.Drawing.Size(606, 72)
        Me.txtCuerpoCorreo.TabIndex = 7
        Me.txtCuerpoCorreo.TabStop = False
        Me.txtCuerpoCorreo.Text = "Cuerpo del correo"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.TallerMecanico.My.Resources.Resources.close_window_32
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(12, 309)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(139, 38)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.BackColor = System.Drawing.Color.White
        Me.btnEnviar.Image = Global.TallerMecanico.My.Resources.Resources.send_32
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(513, 309)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(139, 38)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'frmEnviarCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(664, 359)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmEnviarCotizacion"
        Me.Text = "frmEnviarCotizacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNumCotizacion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCuerpoCorreo As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreoDe As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
