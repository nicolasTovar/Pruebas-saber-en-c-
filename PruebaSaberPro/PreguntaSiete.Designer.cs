namespace PruebaSaberPro
{
    partial class FrmPreguntaSiete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaSiete));
            this.lblPRegunta7 = new System.Windows.Forms.Label();
            this.gbP8 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRes7 = new System.Windows.Forms.Label();
            this.cboRespuesta7 = new System.Windows.Forms.ComboBox();
            this.lblP7 = new System.Windows.Forms.Label();
            this.btnSiguiente7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrSiete = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbP8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPRegunta7
            // 
            this.lblPRegunta7.AutoSize = true;
            this.lblPRegunta7.BackColor = System.Drawing.Color.Transparent;
            this.lblPRegunta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPRegunta7.ForeColor = System.Drawing.Color.White;
            this.lblPRegunta7.Location = new System.Drawing.Point(196, 26);
            this.lblPRegunta7.Name = "lblPRegunta7";
            this.lblPRegunta7.Size = new System.Drawing.Size(211, 31);
            this.lblPRegunta7.TabIndex = 0;
            this.lblPRegunta7.Text = "Pregunta siete ";
            // 
            // gbP8
            // 
            this.gbP8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbP8.Controls.Add(this.pictureBox1);
            this.gbP8.Controls.Add(this.lblRes7);
            this.gbP8.Controls.Add(this.cboRespuesta7);
            this.gbP8.Controls.Add(this.lblP7);
            this.gbP8.ForeColor = System.Drawing.Color.White;
            this.gbP8.Location = new System.Drawing.Point(62, 87);
            this.gbP8.Name = "gbP8";
            this.gbP8.Size = new System.Drawing.Size(687, 322);
            this.gbP8.TabIndex = 1;
            this.gbP8.TabStop = false;
            this.gbP8.Text = "Seleccione una opción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblRes7
            // 
            this.lblRes7.AutoSize = true;
            this.lblRes7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes7.Location = new System.Drawing.Point(29, 122);
            this.lblRes7.Name = "lblRes7";
            this.lblRes7.Size = new System.Drawing.Size(139, 20);
            this.lblRes7.TabIndex = 9;
            this.lblRes7.Text = "Hace referencia a:";
            // 
            // cboRespuesta7
            // 
            this.cboRespuesta7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRespuesta7.FormattingEnabled = true;
            this.cboRespuesta7.Items.AddRange(new object[] {
            "Singleton",
            "Patrón creacional",
            "Patrón fabrica abstracta ",
            "Patrón comportamental"});
            this.cboRespuesta7.Location = new System.Drawing.Point(196, 121);
            this.cboRespuesta7.Name = "cboRespuesta7";
            this.cboRespuesta7.Size = new System.Drawing.Size(426, 21);
            this.cboRespuesta7.TabIndex = 8;
            this.cboRespuesta7.SelectedIndexChanged += new System.EventHandler(this.cboRespuesta7_SelectedIndexChanged);
            // 
            // lblP7
            // 
            this.lblP7.AutoSize = true;
            this.lblP7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP7.Location = new System.Drawing.Point(29, 63);
            this.lblP7.Name = "lblP7";
            this.lblP7.Size = new System.Drawing.Size(570, 20);
            this.lblP7.TabIndex = 0;
            this.lblP7.Text = "7. ¿A qué se hace referencia cuando se habla de patrón estrategia y comando?";
            // 
            // btnSiguiente7
            // 
            this.btnSiguiente7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente7.Location = new System.Drawing.Point(704, 415);
            this.btnSiguiente7.Name = "btnSiguiente7";
            this.btnSiguiente7.Size = new System.Drawing.Size(72, 23);
            this.btnSiguiente7.TabIndex = 2;
            this.btnSiguiente7.Text = "Siguiente";
            this.btnSiguiente7.UseVisualStyleBackColor = true;
            this.btnSiguiente7.Click += new System.EventHandler(this.btnSiguiente7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(12, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 451);
            this.textBox1.TabIndex = 20;
            // 
            // tmrSiete
            // 
            this.tmrSiete.Tick += new System.EventHandler(this.tmrSiete_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(59, 415);
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
            this.lblTiempo.Location = new System.Drawing.Point(116, 415);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(693, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // FrmPreguntaSiete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSiguiente7);
            this.Controls.Add(this.gbP8);
            this.Controls.Add(this.lblPRegunta7);
            this.Name = "FrmPreguntaSiete";
            this.Text = "Pregunta Siete";
            this.Load += new System.EventHandler(this.FrmPreguntaSiete_Load);
            this.gbP8.ResumeLayout(false);
            this.gbP8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPRegunta7;
        private System.Windows.Forms.GroupBox gbP8;
        private System.Windows.Forms.Label lblP7;
        private System.Windows.Forms.Button btnSiguiente7;
        private System.Windows.Forms.Label lblRes7;
        private System.Windows.Forms.ComboBox cboRespuesta7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrSiete;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}