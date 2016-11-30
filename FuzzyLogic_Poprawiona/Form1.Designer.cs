namespace FuzzyLogic_Poprawiona
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerTemperatury = new System.Windows.Forms.Timer(this.components);
            this.panelDwor = new System.Windows.Forms.Panel();
            this.labelTempDwor = new System.Windows.Forms.Label();
            this.pictureBoxPoraDnia = new System.Windows.Forms.PictureBox();
            this.panelWnetrze = new System.Windows.Forms.Panel();
            this.buttonNewRandom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTempWnetrze = new System.Windows.Forms.Label();
            this.pictureBoxPiecyk = new System.Windows.Forms.PictureBox();
            this.pictureBoxKlima = new System.Windows.Forms.PictureBox();
            this.pictureBoxOkno = new System.Windows.Forms.PictureBox();
            this.panelDwor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoraDnia)).BeginInit();
            this.panelWnetrze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiecyk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOkno)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTemperatury
            // 
            this.timerTemperatury.Interval = 1000;
            this.timerTemperatury.Tick += new System.EventHandler(this.timerTemperatury_Tick);
            // 
            // panelDwor
            // 
            this.panelDwor.Controls.Add(this.labelTempDwor);
            this.panelDwor.Controls.Add(this.pictureBoxPoraDnia);
            this.panelDwor.Location = new System.Drawing.Point(595, 0);
            this.panelDwor.Name = "panelDwor";
            this.panelDwor.Size = new System.Drawing.Size(244, 502);
            this.panelDwor.TabIndex = 1;
            // 
            // labelTempDwor
            // 
            this.labelTempDwor.AutoSize = true;
            this.labelTempDwor.Location = new System.Drawing.Point(10, 10);
            this.labelTempDwor.Name = "labelTempDwor";
            this.labelTempDwor.Size = new System.Drawing.Size(81, 13);
            this.labelTempDwor.TabIndex = 2;
            this.labelTempDwor.Text = "labelTempDwor";
            // 
            // pictureBoxPoraDnia
            // 
            this.pictureBoxPoraDnia.Image = global::FuzzyLogic_Poprawiona.Properties.Resources.dzien;
            this.pictureBoxPoraDnia.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPoraDnia.Name = "pictureBoxPoraDnia";
            this.pictureBoxPoraDnia.Size = new System.Drawing.Size(244, 499);
            this.pictureBoxPoraDnia.TabIndex = 3;
            this.pictureBoxPoraDnia.TabStop = false;
            // 
            // panelWnetrze
            // 
            this.panelWnetrze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWnetrze.BackgroundImage")));
            this.panelWnetrze.Controls.Add(this.buttonNewRandom);
            this.panelWnetrze.Controls.Add(this.pictureBox1);
            this.panelWnetrze.Controls.Add(this.labelTempWnetrze);
            this.panelWnetrze.Controls.Add(this.pictureBoxPiecyk);
            this.panelWnetrze.Controls.Add(this.pictureBoxKlima);
            this.panelWnetrze.Controls.Add(this.pictureBoxOkno);
            this.panelWnetrze.Location = new System.Drawing.Point(-2, 0);
            this.panelWnetrze.Name = "panelWnetrze";
            this.panelWnetrze.Size = new System.Drawing.Size(601, 502);
            this.panelWnetrze.TabIndex = 0;
            // 
            // buttonNewRandom
            // 
            this.buttonNewRandom.Location = new System.Drawing.Point(206, 82);
            this.buttonNewRandom.Name = "buttonNewRandom";
            this.buttonNewRandom.Size = new System.Drawing.Size(160, 23);
            this.buttonNewRandom.TabIndex = 5;
            this.buttonNewRandom.Text = "Losuj nowa Temperature";
            this.buttonNewRandom.UseVisualStyleBackColor = true;
            this.buttonNewRandom.Click += new System.EventHandler(this.buttonNewRandom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FuzzyLogic_Poprawiona.Properties.Resources.typek_norm;
            this.pictureBox1.Location = new System.Drawing.Point(389, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 297);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelTempWnetrze
            // 
            this.labelTempWnetrze.AutoSize = true;
            this.labelTempWnetrze.BackColor = System.Drawing.Color.Transparent;
            this.labelTempWnetrze.Location = new System.Drawing.Point(14, 10);
            this.labelTempWnetrze.Name = "labelTempWnetrze";
            this.labelTempWnetrze.Size = new System.Drawing.Size(96, 13);
            this.labelTempWnetrze.TabIndex = 3;
            this.labelTempWnetrze.Text = "labelTempWnetrze";
            // 
            // pictureBoxPiecyk
            // 
            this.pictureBoxPiecyk.Image = global::FuzzyLogic_Poprawiona.Properties.Resources.piec_off;
            this.pictureBoxPiecyk.Location = new System.Drawing.Point(186, 249);
            this.pictureBoxPiecyk.Name = "pictureBoxPiecyk";
            this.pictureBoxPiecyk.Size = new System.Drawing.Size(180, 130);
            this.pictureBoxPiecyk.TabIndex = 2;
            this.pictureBoxPiecyk.TabStop = false;
            // 
            // pictureBoxKlima
            // 
            this.pictureBoxKlima.Image = global::FuzzyLogic_Poprawiona.Properties.Resources.klima_off;
            this.pictureBoxKlima.Location = new System.Drawing.Point(420, 82);
            this.pictureBoxKlima.Name = "pictureBoxKlima";
            this.pictureBoxKlima.Size = new System.Drawing.Size(102, 60);
            this.pictureBoxKlima.TabIndex = 1;
            this.pictureBoxKlima.TabStop = false;
            // 
            // pictureBoxOkno
            // 
            this.pictureBoxOkno.Image = global::FuzzyLogic_Poprawiona.Properties.Resources.okno_close;
            this.pictureBoxOkno.Location = new System.Drawing.Point(38, 73);
            this.pictureBoxOkno.Name = "pictureBoxOkno";
            this.pictureBoxOkno.Size = new System.Drawing.Size(109, 188);
            this.pictureBoxOkno.TabIndex = 0;
            this.pictureBoxOkno.TabStop = false;
            this.pictureBoxOkno.Click += new System.EventHandler(this.pictureBoxOkno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 496);
            this.Controls.Add(this.panelDwor);
            this.Controls.Add(this.panelWnetrze);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FuzzyLogic";
            this.panelDwor.ResumeLayout(false);
            this.panelDwor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoraDnia)).EndInit();
            this.panelWnetrze.ResumeLayout(false);
            this.panelWnetrze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiecyk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOkno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWnetrze;
        private System.Windows.Forms.PictureBox pictureBoxPiecyk;
        private System.Windows.Forms.PictureBox pictureBoxKlima;
        private System.Windows.Forms.PictureBox pictureBoxOkno;
        private System.Windows.Forms.Panel panelDwor;
        private System.Windows.Forms.Timer timerTemperatury;
        private System.Windows.Forms.Label labelTempWnetrze;
        private System.Windows.Forms.Label labelTempDwor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxPoraDnia;
        private System.Windows.Forms.Button buttonNewRandom;
    }
}

