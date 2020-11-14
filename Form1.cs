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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
                // DAO.userLogin
                Yonetici y = new Yonetici();
                y.setYoneticiID(txtYoneticiID.Text);
                y.setParola(txtParola.Text);
                bool sonuc = DAO.Yonetici(y);
                if (sonuc)
                {
                    // kullanıcı sistemde kayıtlı 
                    MessageBox.Show("Sisteme hoşgeldiniz");
                    AnaMenu a = new AnaMenu();
                    a.Show();
                    //Sefer f = new Sefer();
                    //f.Show();

                }
                else
                {
                    // kulllanıcı kayıtlı değil 
                    MessageBox.Show("Hatalı giriş");

                }
            }

        private void txtYoneticiID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
