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
namespace OtobusOtomasyonuGuncel{
    public partial class Sefer : Form{
        SqlConnection baglanti;
        SqlDataAdapter da;
        public Sefer()
        {
            InitializeComponent();
        }
        private void txtNereden_TextChanged(object sender, EventArgs e){
        }
        void SeferGoruntule(){
            baglanti = new SqlConnection("server =.;Data Source =.\\SQLEXPRESS;Initial Catalog=BUS;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Seferler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Sefer_Load(object sender, EventArgs e)
        {
            SeferGoruntule();
        }
        private void btnSeferEkle_Click(object sender, EventArgs e){
            Seferler sfr = new Seferler();
            sfr.setNereden(txtNereden.Text);
            sfr.setNereye(txtNereye.Text);
            sfr.setTarih(txtTarih.Text);
            sfr.setSaat(textBox1.Text);
            sfr.setTip(txtTip.Text);
            sfr.setBiletFiyat(Convert.ToInt32(txtBiletFiyat.Text));
            DAO.SeferEkle(sfr);
            MessageBox.Show("Başarıyla Eklendi");
            SeferGoruntule();
        }
        private void btnSil_Click(object sender, EventArgs e){
            Seferler sfr = new Seferler();
            sfr.setSeferID(Convert.ToInt32(txtSeferID.Text));
            DAO.SeferSil(sfr);
            MessageBox.Show("başarıyla silindi");
            SeferGoruntule();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Sefer gr = new Sefer();
            txtSeferID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNereden.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNereye.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTip.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBiletFiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //DAO.SeferGoruntule(gr);
            
        }

        private void Sefer_Load_1(object sender, EventArgs e)
        {
            SeferGoruntule();
        }

        private void btnGuncelle_Click(object sender, EventArgs e){
            Seferler sfr = new Seferler();
            sfr.setNereden(txtNereden.Text);
            sfr.setNereye(txtNereye.Text);
            sfr.setTarih(txtTarih.Text);
            sfr.setSaat(textBox1.Text);
            sfr.setTip(txtTip.Text);
            sfr.setBiletFiyat(Convert.ToInt32(txtBiletFiyat.Text));
            DAO.SeferGuncelle(sfr);
            MessageBox.Show("Başarıyla Güncellendi");
            SeferGoruntule();
        }

        private void txtSeferID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNereye_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
