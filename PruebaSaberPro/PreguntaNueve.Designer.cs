namespace PruebaSaberPro
{
    partial class FrmPreguntaNueve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaNueve));
            this.lblPregunta9 = new System.Windows.Forms.Label();
            this.lblP9 = new System.Windows.Forms.Label();
            this.rbA9 = new System.Windows.Forms.RadioButton();
            this.rbB9 = new System.Windows.Forms.RadioButton();
            this.rbC9 = new System.Windows.Forms.RadioButton();
            this.rbD9 = new System.Windows.Forms.RadioButton();
            this.lblA9 = new System.Windows.Forms.Label();
            this.lblB9 = new System.Windows.Forms.Label();
            this.lblC9 = new System.Windows.Forms.Label();
            this.lblD9 = new System.Windows.Forms.Label();
            this.btnSiguiente9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbP9 = new System.Windows.Forms.GroupBox();
            this.tmrNueve = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbP9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta9
            // 
            this.lblPregunta9.AutoSize = true;
            this.lblPregunta9.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPregunta9.ForeColor = System.Drawing.Color.White;
            this.lblPregunta9.Location = new System.Drawing.Point(225, 29);
            this.lblPregunta9.Name = "lblPregunta9";
            this.lblPregunta9.Size = new System.Drawing.Size(219, 31);
            this.lblPregunta9.TabIndex = 1;
            this.lblPregunta9.Text = "Pregunta nueve";
            // 
            // lblP9
            // 
            this.lblP9.AutoSize = true;
            this.lblP9.BackColor = System.Drawing.Color.Transparent;
            this.lblP9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblP9.ForeColor = System.Drawing.Color.White;
            this.lblP9.Location = new System.Drawing.Point(6, 16);
            this.lblP9.Name = "lblP9";
            this.lblP9.Size = new System.Drawing.Size(289, 20);
            this.lblP9.TabIndex = 2;
            this.lblP9.Text = "9. ¿En qué se basa el patrón singleton?";
            // 
            // rbA9
            // 
            this.rbA9.AutoSize = true;
            this.rbA9.BackColor = System.Drawing.Color.Transparent;
            this.rbA9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA9.ForeColor = System.Drawing.Color.White;
            this.rbA9.Location = new System.Drawing.Point(62, 54);
            this.rbA9.Name = "rbA9";
            this.rbA9.Size = new System.Drawing.Size(300, 22);
            this.rbA9.TabIndex = 3;
            this.rbA9.TabStop = true;
            this.rbA9.Text = "se enfoca en crear objetos de una familia ";
            this.rbA9.UseVisualStyleBackColor = false;
            // 
            // rbB9
            // 
            this.rbB9.AutoSize = true;
            this.rbB9.BackColor = System.Drawing.Color.Transparent;
            this.rbB9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB9.ForeColor = System.Drawing.Color.White;
            this.rbB9.Location = new System.Drawing.Point(62, 97);
            this.rbB9.Name = "rbB9";
            this.rbB9.Size = new System.Drawing.Size(579, 40);
            this.rbB9.TabIndex = 4;
            this.rbB9.TabStop = true;
            this.rbB9.Text = "Tiene una clase auxiliar que tiene métodos de su propia clase y va inicializar co" +
    "n los \r\nsubsistemas\r\n";
            this.rbB9.UseVisualStyleBackColor = false;
            // 
            // rbC9
            // 
            this.rbC9.AutoSize = true;
            this.rbC9.BackColor = System.Drawing.Color.Transparent;
            this.rbC9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC9.ForeColor = System.Drawing.Color.White;
            this.rbC9.Location = new System.Drawing.Point(62, 159);
            this.rbC9.Name = "rbC9";
            this.rbC9.Size = new System.Drawing.Size(521, 22);
            this.rbC9.TabIndex = 5;
            this.rbC9.TabStop = true;
            this.rbC9.Text = "Es donde se comunica con el invoker que se encarga  de inicializar la clase";
            this.rbC9.UseVisualStyleBackColor = false;
            // 
            // rbD9
            // 
            this.rbD9.AutoSize = true;
            this.rbD9.BackColor = System.Drawing.Color.Transparent;
            this.rbD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD9.ForeColor = System.Drawing.Color.White;
            this.rbD9.Location = new System.Drawing.Point(74, 212);
            this.rbD9.Name = "rbD9";
            this.rbD9.Size = new System.Drawing.Size(197, 22);
            this.rbD9.TabIndex = 6;
            this.rbD9.TabStop = true;
            this.rbD9.Text = "Ninguna de las anteriores ";
            this.rbD9.UseVisualStyleBackColor = false;
            // 
            // lblA9
            // 
            this.lblA9.AutoSize = true;
            this.lblA9.BackColor = System.Drawing.Color.Transparent;
            this.lblA9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblA9.ForeColor = System.Drawing.Color.White;
            this.lblA9.Location = new System.Drawing.Point(13, 45);
            this.lblA9.Name = "lblA9";
            this.lblA9.Size = new System.Drawing.Size(43, 31);
            this.lblA9.TabIndex = 7;
            this.lblA9.Text = "A)";
            // 
            // lblB9
            // 
            this.lblB9.AutoSize = true;
            this.lblB9.BackColor = System.Drawing.Color.Transparent;
            this.lblB9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblB9.ForeColor = System.Drawing.Color.White;
            this.lblB9.Location = new System.Drawing.Point(13, 97);
            this.lblB9.Name = "lblB9";
            this.lblB9.Size = new System.Drawing.Size(43, 31);
            this.lblB9.TabIndex = 8;
            this.lblB9.Text = "B)";
            // 
            // lblC9
            // 
            this.lblC9.AutoSize = true;
            this.lblC9.BackColor = System.Drawing.Color.Transparent;
            this.lblC9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblC9.ForeColor = System.Drawing.Color.White;
            this.lblC9.Location = new System.Drawing.Point(13, 150);
            this.lblC9.Name = "lblC9";
            this.lblC9.Size = new System.Drawing.Size(45, 31);
            this.lblC9.TabIndex = 9;
            this.lblC9.Text = "C)";
            // 
            // lblD9
            // 
            this.lblD9.AutoSize = true;
            this.lblD9.BackColor = System.Drawing.Color.Transparent;
            this.lblD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblD9.ForeColor = System.Drawing.Color.White;
            this.lblD9.Location = new System.Drawing.Point(13, 203);
            this.lblD9.Name = "lblD9";
            this.lblD9.Size = new System.Drawing.Size(45, 31);
            this.lblD9.TabIndex = 10;
            this.lblD9.Text = "D)";
            // 
            // btnSiguiente9
            // 
            this.btnSiguiente9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente9.Location = new System.Drawing.Point(640, 369);
            this.btnSiguiente9.Name = "btnSiguiente9";
            this.btnSiguiente9.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente9.TabIndex = 11;
            this.btnSiguiente9.Text = "Siguiente";
            this.btnSiguiente9.UseVisualStyleBackColor = true;
            this.btnSiguiente9.Click += new System.EventHandler(this.btnSiguiente9_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(721, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 360);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(-2, 398);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(803, 22);
            this.textBox2.TabIndex = 21;
            // 
            // gbP9
            // 
            this.gbP9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbP9.Controls.Add(this.lblP9);
            this.gbP9.Controls.Add(this.lblA9);
            this.gbP9.Controls.Add(this.rbA9);
            this.gbP9.Controls.Add(this.lblB9);
            this.gbP9.Controls.Add(this.rbB9);
            this.gbP9.Controls.Add(this.rbD9);
            this.gbP9.Controls.Add(this.lblD9);
            this.gbP9.Controls.Add(this.lblC9);
            this.gbP9.Controls.Add(this.rbC9);
            this.gbP9.ForeColor = System.Drawing.Color.White;
            this.gbP9.Location = new System.Drawing.Point(23, 90);
            this.gbP9.Name = "gbP9";
            this.gbP9.Size = new System.Drawing.Size(658, 268);
            this.gbP9.TabIndex = 30;
            this.gbP9.TabStop = false;
            this.gbP9.Text = "Seleccione una respuesta";
            // 
            // tmrNueve
            // 
            this.tmrNueve.Tick += new System.EventHandler(this.tmrNueve_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(20, 379);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 13);
            this.lblHora.TabIndex = 36;
            this.lblHora.Text = "Tiempo";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(77, 379);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 35;
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
            // FrmPreguntaNueve
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
            this.Controls.Add(this.gbP9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSiguiente9);
            this.Controls.Add(this.lblPregunta9);
            this.Name = "FrmPreguntaNueve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta Nueve";
            this.Load += new System.EventHandler(this.FrmPreguntaNueve_Load);
            this.gbP9.ResumeLayout(false);
            this.gbP9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta9;
        private System.Windows.Forms.Label lblP9;
        private System.Windows.Forms.RadioButton rbA9;
        private System.Windows.Forms.RadioButton rbB9;
        private System.Windows.Forms.RadioButton rbC9;
        private System.Windows.Forms.RadioButton rbD9;
        private System.Windows.Forms.Label lblA9;
        private System.Windows.Forms.Label lblB9;
        private System.Windows.Forms.Label lblC9;
        private System.Windows.Forms.Label lblD9;
        private System.Windows.Forms.Button btnSiguiente9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbP9;
        private System.Windows.Forms.Timer tmrNueve;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}