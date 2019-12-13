namespace PruebaSaberPro
{
    partial class FrmPreguntaUno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaUno));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.rbA1 = new System.Windows.Forms.RadioButton();
            this.rbB1 = new System.Windows.Forms.RadioButton();
            this.rbC1 = new System.Windows.Forms.RadioButton();
            this.rbD1 = new System.Windows.Forms.RadioButton();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblD1 = new System.Windows.Forms.Label();
            this.gbP1 = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tmrUno = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta  Uno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPregunta1.ForeColor = System.Drawing.Color.White;
            this.lblPregunta1.Location = new System.Drawing.Point(6, 16);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(488, 48);
            this.lblPregunta1.TabIndex = 1;
            this.lblPregunta1.Text = "1.Nivel de dependencia de una clase. Hace referencia a:\r\n\r\n";
            // 
            // rbA1
            // 
            this.rbA1.AutoSize = true;
            this.rbA1.BackColor = System.Drawing.Color.Transparent;
            this.rbA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbA1.ForeColor = System.Drawing.Color.White;
            this.rbA1.Location = new System.Drawing.Point(48, 69);
            this.rbA1.Name = "rbA1";
            this.rbA1.Size = new System.Drawing.Size(110, 28);
            this.rbA1.TabIndex = 2;
            this.rbA1.TabStop = true;
            this.rbA1.Text = "Herencia ";
            this.rbA1.UseVisualStyleBackColor = false;
            // 
            // rbB1
            // 
            this.rbB1.AutoSize = true;
            this.rbB1.BackColor = System.Drawing.Color.Transparent;
            this.rbB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbB1.ForeColor = System.Drawing.Color.White;
            this.rbB1.Location = new System.Drawing.Point(48, 111);
            this.rbB1.Name = "rbB1";
            this.rbB1.Size = new System.Drawing.Size(149, 28);
            this.rbB1.TabIndex = 3;
            this.rbB1.TabStop = true;
            this.rbB1.Text = "Acoplamiento ";
            this.rbB1.UseVisualStyleBackColor = false;
            // 
            // rbC1
            // 
            this.rbC1.AutoSize = true;
            this.rbC1.BackColor = System.Drawing.Color.Transparent;
            this.rbC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbC1.ForeColor = System.Drawing.Color.White;
            this.rbC1.Location = new System.Drawing.Point(48, 155);
            this.rbC1.Name = "rbC1";
            this.rbC1.Size = new System.Drawing.Size(147, 28);
            this.rbC1.TabIndex = 4;
            this.rbC1.TabStop = true;
            this.rbC1.Text = "Alta cohesión ";
            this.rbC1.UseVisualStyleBackColor = false;
            // 
            // rbD1
            // 
            this.rbD1.AutoSize = true;
            this.rbD1.BackColor = System.Drawing.Color.Transparent;
            this.rbD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbD1.ForeColor = System.Drawing.Color.White;
            this.rbD1.Location = new System.Drawing.Point(51, 204);
            this.rbD1.Name = "rbD1";
            this.rbD1.Size = new System.Drawing.Size(75, 28);
            this.rbD1.TabIndex = 5;
            this.rbD1.TabStop = true;
            this.rbD1.Text = "Clase";
            this.rbD1.UseVisualStyleBackColor = false;
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.BackColor = System.Drawing.Color.Transparent;
            this.lblA1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA1.ForeColor = System.Drawing.Color.White;
            this.lblA1.Location = new System.Drawing.Point(6, 63);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(36, 28);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "A)";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.BackColor = System.Drawing.Color.Transparent;
            this.lblB1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB1.ForeColor = System.Drawing.Color.White;
            this.lblB1.Location = new System.Drawing.Point(8, 111);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(34, 28);
            this.lblB1.TabIndex = 7;
            this.lblB1.Text = "B)";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.BackColor = System.Drawing.Color.Transparent;
            this.lblC1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1.ForeColor = System.Drawing.Color.White;
            this.lblC1.Location = new System.Drawing.Point(8, 152);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(34, 28);
            this.lblC1.TabIndex = 8;
            this.lblC1.Text = "C)";
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.BackColor = System.Drawing.Color.Transparent;
            this.lblD1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD1.ForeColor = System.Drawing.Color.White;
            this.lblD1.Location = new System.Drawing.Point(8, 201);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(37, 28);
            this.lblD1.TabIndex = 9;
            this.lblD1.Text = "D)";
            // 
            // gbP1
            // 
            this.gbP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbP1.Controls.Add(this.lblPregunta1);
            this.gbP1.Controls.Add(this.rbD1);
            this.gbP1.Controls.Add(this.lblD1);
            this.gbP1.Controls.Add(this.lblA1);
            this.gbP1.Controls.Add(this.lblC1);
            this.gbP1.Controls.Add(this.rbC1);
            this.gbP1.Controls.Add(this.rbA1);
            this.gbP1.Controls.Add(this.lblB1);
            this.gbP1.Controls.Add(this.rbB1);
            this.gbP1.ForeColor = System.Drawing.Color.White;
            this.gbP1.Location = new System.Drawing.Point(24, 86);
            this.gbP1.Name = "gbP1";
            this.gbP1.Size = new System.Drawing.Size(583, 280);
            this.gbP1.TabIndex = 10;
            this.gbP1.TabStop = false;
            this.gbP1.Text = "Única Respuesta";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(636, 359);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(88, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(750, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 343);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(0, 388);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(801, 25);
            this.textBox2.TabIndex = 12;
            // 
            // tmrUno
            // 
            this.tmrUno.Tick += new System.EventHandler(this.tmrUno_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(69, 428);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 31;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(12, 428);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 13);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "Tiempo";
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
            // FrmPreguntaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbP1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPreguntaUno";
            this.Text = "Pregunta Uno";
            this.Load += new System.EventHandler(this.FrmPreguntaUno_Load);
            this.gbP1.ResumeLayout(false);
            this.gbP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.RadioButton rbA1;
        private System.Windows.Forms.RadioButton rbB1;
        private System.Windows.Forms.RadioButton rbC1;
        private System.Windows.Forms.RadioButton rbD1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.GroupBox gbP1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tmrUno;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}