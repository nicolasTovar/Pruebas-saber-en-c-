namespace PruebaSaberPro
{
    partial class FrmPreguntaDos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaDos));
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.cboRespuesta2 = new System.Windows.Forms.ComboBox();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.gbP2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tmrDos = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPregunta2.ForeColor = System.Drawing.Color.White;
            this.lblPregunta2.Location = new System.Drawing.Point(195, 19);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(200, 31);
            this.lblPregunta2.TabIndex = 1;
            this.lblPregunta2.Text = "Pregunta  Dos";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(12, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 451);
            this.textBox1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(36, 31);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(287, 24);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "2. ¿Qué es un Patrón de diseño?";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRes2.ForeColor = System.Drawing.Color.White;
            this.lblRes2.Location = new System.Drawing.Point(36, 92);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(222, 24);
            this.lblRes2.TabIndex = 4;
            this.lblRes2.Text = "Un Patrón de diseño es:  ";
            // 
            // cboRespuesta2
            // 
            this.cboRespuesta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRespuesta2.FormattingEnabled = true;
            this.cboRespuesta2.Items.AddRange(new object[] {
            "•Interface",
            "•Catalogo gof",
            "•Es la mejor solución a problemas recurrentes al software",
            "•Ninguna de las anteriores"});
            this.cboRespuesta2.Location = new System.Drawing.Point(264, 92);
            this.cboRespuesta2.Name = "cboRespuesta2";
            this.cboRespuesta2.Size = new System.Drawing.Size(422, 21);
            this.cboRespuesta2.TabIndex = 5;
            this.cboRespuesta2.SelectedIndexChanged += new System.EventHandler(this.cboRespuesta2_SelectedIndexChanged);
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente2.Location = new System.Drawing.Point(648, 383);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente2.TabIndex = 6;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // gbP2
            // 
            this.gbP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbP2.Controls.Add(this.pictureBox2);
            this.gbP2.Controls.Add(this.cboRespuesta2);
            this.gbP2.Controls.Add(this.lblRes2);
            this.gbP2.Controls.Add(this.lbl2);
            this.gbP2.ForeColor = System.Drawing.Color.White;
            this.gbP2.Location = new System.Drawing.Point(63, 90);
            this.gbP2.Name = "gbP2";
            this.gbP2.Size = new System.Drawing.Size(725, 287);
            this.gbP2.TabIndex = 7;
            this.gbP2.TabStop = false;
            this.gbP2.Text = "Seleccione una opción";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(457, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(-5, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 8;
            // 
            // tmrDos
            // 
            this.tmrDos.Tick += new System.EventHandler(this.tmrDos_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(60, 407);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 13);
            this.lblHora.TabIndex = 34;
            this.lblHora.Text = "Tiempo";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(117, 407);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(693, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // FrmPreguntaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gbP2);
            this.Controls.Add(this.btnSiguiente2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPregunta2);
            this.Name = "FrmPreguntaDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreguntaDos";
            this.Load += new System.EventHandler(this.FrmPreguntaDos_Load);
            this.gbP2.ResumeLayout(false);
            this.gbP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.ComboBox cboRespuesta2;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.GroupBox gbP2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tmrDos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}