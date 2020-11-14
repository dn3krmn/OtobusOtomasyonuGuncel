using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonuGuncel
{
    public partial class kayitFormu : Form
    {
        public kayitFormu()
        {
            InitializeComponent();
        }

        private void rdbKadin_CheckedChanged(object sender, EventArgs e)
        {
 
        }
        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void texAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskTexTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void texSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }
        private void textSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void texAd_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kayitFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen gerekli alanları doldurunuz!");
                        return;
                    }
                }    
            }
            
            Biletler blt = new Biletler();
            blt.setad(textAd.Text);
            blt.setsoyad(textSoyad.Text);
            blt.settel(maskTexTel.Text);
            
            if (rdbKadin.Checked){
                 blt.setcinsiyet(rdbKadin.Text);
            }
            else{
                blt.setcinsiyet(rdbErkek.Text);
            }

            /*blt.set(textBox1.Text);
            blt.setTip(txtTip.Text);
            blt.setBiletFiyat(Convert.ToInt32(txtBiletFiyat.Text));*/
            DAO.BiletEkle(blt);
            MessageBox.Show("Başarıyla Eklendi");
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnİptal_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
