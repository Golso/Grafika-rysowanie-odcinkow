namespace Odcinek
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.etykieta1 = new System.Windows.Forms.Label();
            this.etykieta2 = new System.Windows.Forms.Label();
            this.CleanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.wybAlg = new System.Windows.Forms.Label();
            this.WspButton = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RysujButton = new System.Windows.Forms.Button();
            this.RysownikButton = new System.Windows.Forms.Button();
            this.Wyjatek = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(26, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(851, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Algorytm przyrostowy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etykieta1
            // 
            this.etykieta1.AutoSize = true;
            this.etykieta1.Location = new System.Drawing.Point(711, 37);
            this.etykieta1.Name = "etykieta1";
            this.etykieta1.Size = new System.Drawing.Size(125, 17);
            this.etykieta1.TabIndex = 2;
            this.etykieta1.Text = "Punkt początkowy:";
            // 
            // etykieta2
            // 
            this.etykieta2.AutoSize = true;
            this.etykieta2.Location = new System.Drawing.Point(711, 81);
            this.etykieta2.Name = "etykieta2";
            this.etykieta2.Size = new System.Drawing.Size(106, 17);
            this.etykieta2.TabIndex = 3;
            this.etykieta2.Text = "Punkt końcowy:";
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(778, 373);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(127, 51);
            this.CleanButton.TabIndex = 6;
            this.CleanButton.Text = "Wyczyść";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(714, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 67);
            this.button3.TabIndex = 9;
            this.button3.Text = "Algorytm z punktem środkowym";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wybrany algorytm:";
            // 
            // wybAlg
            // 
            this.wybAlg.AutoSize = true;
            this.wybAlg.Location = new System.Drawing.Point(843, 317);
            this.wybAlg.Name = "wybAlg";
            this.wybAlg.Size = new System.Drawing.Size(149, 17);
            this.wybAlg.TabIndex = 11;
            this.wybAlg.Text = "Z punktem środkowym";
            // 
            // WspButton
            // 
            this.WspButton.Location = new System.Drawing.Point(1033, 142);
            this.WspButton.Name = "WspButton";
            this.WspButton.Size = new System.Drawing.Size(216, 42);
            this.WspButton.TabIndex = 12;
            this.WspButton.Text = "Wpisz własne współrzędne";
            this.WspButton.UseVisualStyleBackColor = true;
            this.WspButton.Click += new System.EventHandler(this.WspButton_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(1076, 37);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(33, 22);
            this.textBoxX1.TabIndex = 13;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(1076, 76);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(33, 22);
            this.textBoxX2.TabIndex = 14;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(1180, 37);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.ReadOnly = true;
            this.textBoxY1.Size = new System.Drawing.Size(30, 22);
            this.textBoxY1.TabIndex = 15;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(1180, 78);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.ReadOnly = true;
            this.textBoxY2.Size = new System.Drawing.Size(30, 22);
            this.textBoxY2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1049, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1049, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1144, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1144, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y:";
            // 
            // RysujButton
            // 
            this.RysujButton.Enabled = false;
            this.RysujButton.Location = new System.Drawing.Point(1100, 206);
            this.RysujButton.Name = "RysujButton";
            this.RysujButton.Size = new System.Drawing.Size(75, 32);
            this.RysujButton.TabIndex = 21;
            this.RysujButton.Text = "Rysuj";
            this.RysujButton.UseVisualStyleBackColor = true;
            this.RysujButton.Click += new System.EventHandler(this.RysujButton_Click);
            // 
            // RysownikButton
            // 
            this.RysownikButton.Location = new System.Drawing.Point(714, 142);
            this.RysownikButton.Name = "RysownikButton";
            this.RysownikButton.Size = new System.Drawing.Size(264, 42);
            this.RysownikButton.TabIndex = 22;
            this.RysownikButton.Text = "Zaznaczaj na rysowniku";
            this.RysownikButton.UseVisualStyleBackColor = true;
            this.RysownikButton.Click += new System.EventHandler(this.RysownikButton_Click);
            // 
            // Wyjatek
            // 
            this.Wyjatek.AutoSize = true;
            this.Wyjatek.Location = new System.Drawing.Point(1049, 256);
            this.Wyjatek.Name = "Wyjatek";
            this.Wyjatek.Size = new System.Drawing.Size(0, 17);
            this.Wyjatek.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1073, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "X: 0-491;   Y:0-345";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1281, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Wyjatek);
            this.Controls.Add(this.RysownikButton);
            this.Controls.Add(this.RysujButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.WspButton);
            this.Controls.Add(this.wybAlg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.etykieta2);
            this.Controls.Add(this.etykieta1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odcinek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label etykieta1;
        private System.Windows.Forms.Label etykieta2;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wybAlg;
        private System.Windows.Forms.Button WspButton;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RysujButton;
        private System.Windows.Forms.Button RysownikButton;
        private System.Windows.Forms.Label Wyjatek;
        private System.Windows.Forms.Label label8;
    }
}

