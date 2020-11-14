using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtobusOtomasyonuGuncel
{
    public partial class BiletSatis : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlDataReader dr;
        public BiletSatis()
        {
            InitializeComponent();
        }
        void Getir(){
            
            baglanti = new SqlConnection("server =.;Data Source =.\\SQLEXPRESS;Initial Catalog=BUS;Integrated Security=True");
            da = new SqlDataAdapter("SELECT  SeferID,Nereden,Nereye,Tip,Tarih,Saat,BiletFiyat FROM Seferler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            dataGridView1.DataSource = ds.Tables["Seferler"];
            baglanti.Close();
        }

        private void BiletSatis_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            da = new SqlDataAdapter("Select * from Seferler where Tip Like '" + cmbOtobus.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Seferler"];*/
            switch (cmbOtobus.Text)
            {
                case "2+2":
                    KoltukDoldur(10, true);
                    break;
                case "2+1":
                    KoltukDoldurSuit(10);
                    break;
            }
        }
        void KoltukDoldur(int sira, bool arkaBesliMi){
        /*yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Kaydet")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }

                }
            }*/
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 5 && j > 2)
                    {
                        continue;
                    }
                    if (arkaBesliMi == true)
                    {
                        if (i != sira - 1 && j == 2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (j == 2)
                            continue;
                    }
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();

                    koltukNo++;
                    koltuk.MouseDown += koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }
        void KoltukDoldurSuit(int sira)
        {/*
        yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Ara")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }*/
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 1)
                    {
                        continue;
                    }

                    if (i == 5 && j > 2)
                    {
                        continue;
                    }
                    if (j == 2)
                        continue;
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    koltuk.MouseDown += koltuk_MouseDown;
                    this.Controls.Add(koltuk);

                }
            }
        }

        Button tiklanan;
        void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
            //MessageBox.Show(tiklanan.Text);
            if (cmbOtobus.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!");
                return;
            }
            kayitFormu kf = new kayitFormu();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}", kf.textAd.Text, kf.textSoyad.Text);
                lvi.SubItems.Add(kf.maskTexTel.Text);
                if (kf.rdbKadin.Checked)
                {
                    lvi.SubItems.Add("Kadın");
                    tiklanan.BackColor = Color.DarkMagenta;

                    tiklanan.Enabled = false;
                    if (tiklanan.Enabled == false)
                    {
                        MessageBox.Show("Doldu");
                    }

                }
                if (kf.rdbErkek.Checked)
                {
                    lvi.SubItems.Add("Erkek");
                    tiklanan.BackColor = Color.ForestGreen;
                    tiklanan.Enabled = false;
                    if (tiklanan.Enabled == false)
                    {
                       MessageBox.Show("Doldu");
                    }
                }

                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                listView1.Items.Add(lvi);

            }

        }
 
        private void label2_Click(object sender, EventArgs e) { }
        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e) {/*
            da = new SqlDataAdapter("Select * from Seferler where Nereden Like '" + cmbNereden.Text + "%'", baglanti);// ½ işareti texbox sa girilen karakterden sonra sonuna hangi harf gelirse gelsin tümünü göster demektir.
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Seferler"];*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void btnAra_Click_1(object sender, EventArgs e){
            da = new SqlDataAdapter("select * from seferler where  Nereden like  '"  + txtAra.Text + "%'" , baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Seferler"];
        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e){/*
            da = new SqlDataAdapter("Select * from Seferler where Nereye Like '" + cmbNereye.Text + "%'", baglanti);// ½ işareti texbox sa girilen karakterden sonra sonuna hangi harf gelirse gelsin tümünü göster demektir.
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Seferler"];*/
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e){/*
            da = new SqlDataAdapter("Select * from Seferler where Tarih Like '" + dtpTarih.Text + "%'", baglanti);// ½ işareti texbox sa girilen karakterden sonra sonuna hangi harf gelirse gelsin tümünü göster demektir.
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Seferler");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Seferler"];*/
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
