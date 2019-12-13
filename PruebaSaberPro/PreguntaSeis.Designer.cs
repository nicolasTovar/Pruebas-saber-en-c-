namespace PruebaSaberPro
{
    partial class FrmPreguntaSeis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaSeis));
            this.lblPregunta6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblP6 = new System.Windows.Forms.Label();
            this.gb6 = new System.Windows.Forms.GroupBox();
            this.cbF = new System.Windows.Forms.CheckBox();
            this.cbE = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.tmrSeis = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta6
            // 
            this.lblPregunta6.AutoSize = true;
            this.lblPregunta6.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPregunta6.ForeColor = System.Drawing.Color.White;
            this.lblPregunta6.Location = new System.Drawing.Point(127, 30);
            this.lblPregunta6.Name = "lblPregunta6";
            this.lblPregunta6.Size = new System.Drawing.Size(193, 31);
            this.lblPregunta6.TabIndex = 0;
            this.lblPregunta6.Text = "Pregunta seis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblP6
            // 
            this.lblP6.AutoSize = true;
            this.lblP6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblP6.ForeColor = System.Drawing.Color.White;
            this.lblP6.Location = new System.Drawing.Point(12, 87);
            this.lblP6.Name = "lblP6";
            this.lblP6.Size = new System.Drawing.Size(745, 48);
            this.lblP6.TabIndex = 2;
            this.lblP6.Text = "6. ¿Según la vista estática a que patrón se hace referencia? De acuerdo con la pr" +
    "egunta\r\n anterior seleccione las respuestas correctas \r\n";
            // 
            // gb6
            // 
            this.gb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gb6.Controls.Add(this.cbF);
            this.gb6.Controls.Add(this.cbE);
            this.gb6.Controls.Add(this.cbD);
            this.gb6.Controls.Add(this.cbC);
            this.gb6.Controls.Add(this.cbB);
            this.gb6.Controls.Add(this.cbA);
            this.gb6.ForeColor = System.Drawing.Color.White;
            this.gb6.Location = new System.Drawing.Point(2, 140);
            this.gb6.Name = "gb6";
            this.gb6.Size = new System.Drawing.Size(496, 314);
            this.gb6.TabIndex = 10;
            this.gb6.TabStop = false;
            this.gb6.Text = "Respuesta multiple";
            // 
            // cbF
            // 
            this.cbF.AutoSize = true;
            this.cbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbF.Location = new System.Drawing.Point(12, 243);
            this.cbF.Name = "cbF";
            this.cbF.Size = new System.Drawing.Size(256, 20);
            this.cbF.TabIndex = 13;
            this.cbF.Text = "Delega el control de su única instancia";
            this.cbF.UseVisualStyleBackColor = true;
            // 
            // cbE
            // 
            this.cbE.AutoSize = true;
            this.cbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbE.Location = new System.Drawing.Point(12, 204);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(183, 20);
            this.cbE.TabIndex = 12;
            this.cbE.Text = "El patrón fabrica abstracta";
            this.cbE.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbD.Location = new System.Drawing.Point(12, 153);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(479, 36);
            this.cbD.TabIndex = 11;
            this.cbD.Text = "Contiene una clase auxiliar que tiene métodos de su propia clase e inicializa\r\n c" +
    "on los subsistemas";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC.Location = new System.Drawing.Point(12, 127);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(142, 20);
            this.cbC.TabIndex = 10;
            this.cbC.Text = "El patrón Comando";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.Location = new System.Drawing.Point(12, 89);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(458, 20);
            this.cbB.TabIndex = 9;
            this.cbB.Text = "Encapsula la lógica de una familia y las hace facílmente intercambiables";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA.Location = new System.Drawing.Point(12, 52);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(132, 20);
            this.cbA.TabIndex = 8;
            this.cbA.Text = "El patrón fachada";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // tmrSeis
            // 
            this.tmrSeis.Tick += new System.EventHandler(this.tmrSeis_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(27, 466);
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
            this.lblTiempo.Location = new System.Drawing.Point(84, 466);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 33;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSiguiente.Location = new System.Drawing.Point(741, 458);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 35;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(754, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // FrmPreguntaSeis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 488);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.gb6);
            this.Controls.Add(this.lblP6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPregunta6);
            this.Name = "FrmPreguntaSeis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta Seis";
            this.Load += new System.EventHandler(this.FrmPreguntaSeis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb6.ResumeLayout(false);
            this.gb6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblP6;
        private System.Windows.Forms.GroupBox gb6;
        private System.Windows.Forms.Timer tmrSeis;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.CheckBox cbF;
        private System.Windows.Forms.CheckBox cbE;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}