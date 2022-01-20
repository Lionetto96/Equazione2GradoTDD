namespace WinFormsEquazione2Grado
{
    partial class Equazione2Grado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equazione2Grado));
            this.btnRisolvi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Risultato = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRisolvi
            // 
            this.btnRisolvi.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRisolvi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRisolvi.Location = new System.Drawing.Point(240, 340);
            this.btnRisolvi.Name = "btnRisolvi";
            this.btnRisolvi.Size = new System.Drawing.Size(292, 50);
            this.btnRisolvi.TabIndex = 1;
            this.btnRisolvi.Text = "Risolvi";
            this.btnRisolvi.UseVisualStyleBackColor = false;
            this.btnRisolvi.Click += new System.EventHandler(this.btnRisolvi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "InserisciCoefficienteA";
            this.textBox1.Size = new System.Drawing.Size(211, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "InserisciCoefficienteB";
            this.textBox2.Size = new System.Drawing.Size(185, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(538, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "InserisciCoefficienteC";
            this.textBox3.Size = new System.Drawing.Size(189, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(240, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(292, 31);
            this.textBox4.TabIndex = 7;
            // 
            // Risultato
            // 
            this.Risultato.AutoSize = true;
            this.Risultato.Location = new System.Drawing.Point(341, 275);
            this.Risultato.Name = "Risultato";
            this.Risultato.Size = new System.Drawing.Size(92, 25);
            this.Risultato.TabIndex = 8;
            this.Risultato.Text = "Risultato/i";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(239, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(289, 42);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "x^2 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "x +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "= 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 153);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Equazione2Grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.Risultato);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRisolvi);
            this.Name = "Equazione2Grado";
            this.Text = "Equazioni2Grado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRisolvi;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Risultato;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}