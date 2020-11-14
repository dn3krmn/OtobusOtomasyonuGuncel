namespace OtobusOtomasyonuGuncel
{
    partial class AnaMenu
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
            this.btnSefer = new System.Windows.Forms.Button();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSefer
            // 
            this.btnSefer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSefer.Location = new System.Drawing.Point(62, 126);
            this.btnSefer.Name = "btnSefer";
            this.btnSefer.Size = new System.Drawing.Size(184, 66);
            this.btnSefer.TabIndex = 0;
            this.btnSefer.Text = "Sefer ";
            this.btnSefer.UseVisualStyleBackColor = false;
            this.btnSefer.Click += new System.EventHandler(this.btnSefer_Click);
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBiletSatis.Location = new System.Drawing.Point(360, 126);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Size = new System.Drawing.Size(201, 66);
            this.btnBiletSatis.TabIndex = 1;
            this.btnBiletSatis.Text = "Bilet Satış";
            this.btnBiletSatis.UseVisualStyleBackColor = false;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 313);
            this.Controls.Add(this.btnBiletSatis);
            this.Controls.Add(this.btnSefer);
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSefer;
        private System.Windows.Forms.Button btnBiletSatis;
    }
}