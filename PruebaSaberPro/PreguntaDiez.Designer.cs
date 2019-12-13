namespace PruebaSaberPro
{
    partial class FrmPreguntaDiez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaDiez));
            this.lblPregunta10 = new System.Windows.Forms.Label();
            this.pbCohesion = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbG = new System.Windows.Forms.CheckBox();
            this.cbF = new System.Windows.Forms.CheckBox();
            this.cbE = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDiez = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCohesion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta10
            // 
            this.lblPregunta10.AutoSize = true;
            this.lblPregunta10.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPregunta10.ForeColor = System.Drawing.Color.White;
            this.lblPregunta10.Location = new System.Drawing.Point(170, 9);
            this.lblPregunta10.Name = "lblPregunta10";
            this.lblPregunta10.Size = new System.Drawing.Size(199, 31);
            this.lblPregunta10.TabIndex = 1;
            this.lblPregunta10.Text = "Pregunta Diez";
            // 
            // pbCohesion
            // 
            this.pbCohesion.Image = ((System.Drawing.Image)(resources.GetObject("pbCohesion.Image")));
            this.pbCohesion.Location = new System.Drawing.Point(565, 132);
            this.pbCohesion.Name = "pbCohesion";
            this.pbCohesion.Size = new System.Drawing.Size(220, 219);
            this.pbCohesion.TabIndex = 2;
            this.pbCohesion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.cbG);
            this.groupBox1.Controls.Add(this.cbF);
            this.groupBox1.Controls.Add(this.cbE);
            this.groupBox1.Controls.Add(this.cbD);
            this.groupBox1.Controls.Add(this.cbC);
            this.groupBox1.Controls.Add(this.cbB);
            this.groupBox1.Controls.Add(this.cbA);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuesta múltiple ";
            // 
            // cbG
            // 
            this.cbG.AutoSize = true;
            this.cbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbG.Location = new System.Drawing.Point(7, 242);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(134, 22);
            this.cbG.TabIndex = 20;
            this.cbG.Text = "Una asosiación ";
            this.cbG.UseVisualStyleBackColor = true;
            // 
            // cbF
            // 
            this.cbF.AutoSize = true;
            this.cbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbF.Location = new System.Drawing.Point(6, 206);
            this.cbF.Name = "cbF";
            this.cbF.Size = new System.Drawing.Size(120, 22);
            this.cbF.TabIndex = 19;
            this.cbF.Text = "Alta cohesión ";
            this.cbF.UseVisualStyleBackColor = true;
            // 
            // cbE
            // 
            this.cbE.AutoSize = true;
            this.cbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbE.Location = new System.Drawing.Point(7, 171);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(150, 22);
            this.cbE.TabIndex = 18;
            this.cbE.Text = "Esta especializada";
            this.cbE.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbD.Location = new System.Drawing.Point(7, 133);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(125, 22);
            this.cbD.TabIndex = 17;
            this.cbD.Text = "Baja cohesión ";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC.Location = new System.Drawing.Point(7, 96);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(271, 22);
            this.cbC.TabIndex = 16;
            this.cbC.Text = "Nivel de especialización de una clase";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.Location = new System.Drawing.Point(7, 61);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(172, 22);
            this.cbB.TabIndex = 15;
            this.cbB.Text = "No está especializada";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA.Location = new System.Drawing.Point(7, 31);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(101, 22);
            this.cbA.TabIndex = 14;
            this.cbA.Text = "Un método";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "10.¿En qué se divide una cohesión?";
            // 
            // tmrDiez
            // 
            this.tmrDiez.Tick += new System.EventHandler(this.tmrDiez_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(485, 418);
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
            this.lblTiempo.Location = new System.Drawing.Point(542, 418);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 33;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinalizar.Location = new System.Drawing.Point(729, 408);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 35;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_2);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(731, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // FrmPreguntaDiez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCohesion);
            this.Controls.Add(this.lblPregunta10);
            this.Name = "FrmPreguntaDiez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta Diez";
            this.Load += new System.EventHandler(this.FrmPreguntaDiez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCohesion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta10;
        private System.Windows.Forms.PictureBox pbCohesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrDiez;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.CheckBox cbG;
        private System.Windows.Forms.CheckBox cbF;
        private System.Windows.Forms.CheckBox cbE;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}