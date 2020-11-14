namespace OtobusOtomasyonuGuncel
{
    partial class Sefer
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSeferEkle = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblNereye = new System.Windows.Forms.Label();
            this.lblNereden = new System.Windows.Forms.Label();
            this.txtBiletFiyat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBiletFiyat = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeferID = new System.Windows.Forms.TextBox();
            this.txtNereden = new System.Windows.Forms.ComboBox();
            this.txtNereye = new System.Windows.Forms.ComboBox();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Info;
            this.btnSil.Location = new System.Drawing.Point(296, 314);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 39);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuncelle.Location = new System.Drawing.Point(296, 183);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 39);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSeferEkle
            // 
            this.btnSeferEkle.BackColor = System.Drawing.SystemColors.Info;
            this.btnSeferEkle.Location = new System.Drawing.Point(296, 53);
            this.btnSeferEkle.Name = "btnSeferEkle";
            this.btnSeferEkle.Size = new System.Drawing.Size(92, 39);
            this.btnSeferEkle.TabIndex = 37;
            this.btnSeferEkle.Text = "Sefer Ekle";
            this.btnSeferEkle.UseVisualStyleBackColor = false;
            this.btnSeferEkle.Click += new System.EventHandler(this.btnSeferEkle_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(27, 308);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 36;
            this.lblTip.Text = "Tip";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(24, 196);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 32;
            this.lblTarih.Text = "Tarih";
            // 
            // lblNereye
            // 
            this.lblNereye.AutoSize = true;
            this.lblNereye.Location = new System.Drawing.Point(27, 134);
            this.lblNereye.Name = "lblNereye";
            this.lblNereye.Size = new System.Drawing.Size(41, 13);
            this.lblNereye.TabIndex = 31;
            this.lblNereye.Text = "Nereye";
            // 
            // lblNereden
            // 
            this.lblNereden.AutoSize = true;
            this.lblNereden.Location = new System.Drawing.Point(24, 66);
            this.lblNereden.Name = "lblNereden";
            this.lblNereden.Size = new System.Drawing.Size(48, 13);
            this.lblNereden.TabIndex = 30;
            this.lblNereden.Text = "Nereden";
            // 
            // txtBiletFiyat
            // 
            this.txtBiletFiyat.Location = new System.Drawing.Point(27, 384);
            this.txtBiletFiyat.Name = "txtBiletFiyat";
            this.txtBiletFiyat.Size = new System.Drawing.Size(193, 20);
            this.txtBiletFiyat.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 392);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lblBiletFiyat
            // 
            this.lblBiletFiyat.AutoSize = true;
            this.lblBiletFiyat.Location = new System.Drawing.Point(27, 357);
            this.lblBiletFiyat.Name = "lblBiletFiyat";
            this.lblBiletFiyat.Size = new System.Drawing.Size(52, 13);
            this.lblBiletFiyat.TabIndex = 26;
            this.lblBiletFiyat.Text = "Bilet Fiyat";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(24, 246);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 13);
            this.lblSaat.TabIndex = 25;
            this.lblSaat.Text = "Saat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "SeferID";
            // 
            // txtSeferID
            // 
            this.txtSeferID.Location = new System.Drawing.Point(27, 32);
            this.txtSeferID.Name = "txtSeferID";
            this.txtSeferID.Size = new System.Drawing.Size(193, 20);
            this.txtSeferID.TabIndex = 42;
            this.txtSeferID.TextChanged += new System.EventHandler(this.txtSeferID_TextChanged);
            // 
            // txtNereden
            // 
            this.txtNereden.FormattingEnabled = true;
            this.txtNereden.Items.AddRange(new object[] {
            "Ankara",
            "Bolu",
            "Bursa",
            "Çanakkale",
            "Giresun",
            "İstanbul",
            "İzmir",
            "Karabük",
            "Konya",
            "Tokat",
            "Samsun"});
            this.txtNereden.Location = new System.Drawing.Point(27, 92);
            this.txtNereden.Name = "txtNereden";
            this.txtNereden.Size = new System.Drawing.Size(193, 21);
            this.txtNereden.TabIndex = 43;
            this.txtNereden.SelectedIndexChanged += new System.EventHandler(this.txtNereden_SelectedIndexChanged);
            // 
            // txtNereye
            // 
            this.txtNereye.FormattingEnabled = true;
            this.txtNereye.Items.AddRange(new object[] {
            "Ankara",
            "Bolu",
            "Bursa",
            "Çanakkale",
            "Giresun",
            "İstanbul",
            "İzmir",
            "Karabük",
            "Konya",
            "Tokat",
            "Samsun"});
            this.txtNereye.Location = new System.Drawing.Point(27, 150);
            this.txtNereye.Name = "txtNereye";
            this.txtNereye.Size = new System.Drawing.Size(193, 21);
            this.txtNereye.TabIndex = 44;
            // 
            // txtTarih
            // 
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTarih.Location = new System.Drawing.Point(27, 212);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(193, 20);
            this.txtTarih.TabIndex = 45;
            // 
            // txtTip
            // 
            this.txtTip.FormattingEnabled = true;
            this.txtTip.Items.AddRange(new object[] {
            "2+2",
            "2+1"});
            this.txtTip.Location = new System.Drawing.Point(27, 324);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(193, 21);
            this.txtTip.TabIndex = 46;
            // 
            // Sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 422);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtNereye);
            this.Controls.Add(this.txtNereden);
            this.Controls.Add(this.txtSeferID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSeferEkle);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblNereye);
            this.Controls.Add(this.lblNereden);
            this.Controls.Add(this.txtBiletFiyat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBiletFiyat);
            this.Controls.Add(this.lblSaat);
            this.Name = "Sefer";
            this.Text = "Sefer";
            this.Load += new System.EventHandler(this.Sefer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSeferEkle;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.TextBox txtBiletFiyat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBiletFiyat;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeferID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtNereden;
        private System.Windows.Forms.ComboBox txtNereye;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.ComboBox txtTip;
    }
}