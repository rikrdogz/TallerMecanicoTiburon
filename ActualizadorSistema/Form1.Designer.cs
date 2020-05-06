namespace ActualizadorSistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCLose = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUrlArchivo = new System.Windows.Forms.TextBox();
            this.BoxEventos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCLose.BackColor = System.Drawing.Color.White;
            this.btnCLose.Image = global::ActualizadorSistema.Properties.Resources.close_window_32;
            this.btnCLose.Location = new System.Drawing.Point(31, 214);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(88, 41);
            this.btnCLose.TabIndex = 7;
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(487, 219);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(137, 41);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Actualizar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(27, 23);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 69);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Dirección Server:";
            // 
            // txtUrlArchivo
            // 
            this.txtUrlArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlArchivo.Location = new System.Drawing.Point(111, 32);
            this.txtUrlArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrlArchivo.Name = "txtUrlArchivo";
            this.txtUrlArchivo.Size = new System.Drawing.Size(512, 26);
            this.txtUrlArchivo.TabIndex = 4;
            this.txtUrlArchivo.Text = "\\\\192.168.0.6\\ActualizacionTiburon";
            // 
            // BoxEventos
            // 
            this.BoxEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxEventos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEventos.FormattingEnabled = true;
            this.BoxEventos.ItemHeight = 16;
            this.BoxEventos.Location = new System.Drawing.Point(31, 70);
            this.BoxEventos.Name = "BoxEventos";
            this.BoxEventos.Size = new System.Drawing.Size(593, 132);
            this.BoxEventos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 266);
            this.Controls.Add(this.BoxEventos);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUrlArchivo);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Actualizador del Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCLose;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUrlArchivo;
        private System.Windows.Forms.ListBox BoxEventos;
    }
}

