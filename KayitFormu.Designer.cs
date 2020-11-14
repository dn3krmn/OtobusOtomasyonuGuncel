namespace OtobusOtomasyonuGuncel
{
    partial class kayitFormu
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
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.btnTamam = new System.Windows.Forms.Button();
            this.maskTexTel = new System.Windows.Forms.MaskedTextBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.BackColor = System.Drawing.Color.ForestGreen;
            this.rdbErkek.Location = new System.Drawing.Point(205, 210);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 20;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = false;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.BackColor = System.Drawing.Color.DarkMagenta;
            this.rdbKadin.Location = new System.Drawing.Point(113, 210);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 19;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = false;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(205, 242);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 18;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click_1);
            // 
            // maskTexTel
            // 
            this.maskTexTel.Location = new System.Drawing.Point(132, 163);
            this.maskTexTel.Mask = "(999) 000-0000";
            this.maskTexTel.Name = "maskTexTel";
            this.maskTexTel.Size = new System.Drawing.Size(126, 20);
            this.maskTexTel.TabIndex = 17;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(81, 242);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 16;
            this.btnİptal.Text = "iptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click_1);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(132, 119);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(126, 20);
            this.textSoyad.TabIndex = 14;
            this.textSoyad.TextChanged += new System.EventHandler(this.texSoyad_TextChanged);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(132, 71);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(126, 20);
            this.textAd.TabIndex = 15;
            this.textAd.TextChanged += new System.EventHandler(this.texAd_TextChanged_1);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(78, 119);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 11;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(78, 163);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(78, 71);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad";
            // 
            // kayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(362, 330);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.maskTexTel);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAd);
            this.Name = "kayitFormu";
            this.Text = "Kayit Formu";
            this.Load += new System.EventHandler(this.kayitFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rdbErkek;
        public System.Windows.Forms.RadioButton rdbKadin;
        public System.Windows.Forms.MaskedTextBox maskTexTel;
        public System.Windows.Forms.TextBox textSoyad;
        public System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.Button btnİptal;
    }
}