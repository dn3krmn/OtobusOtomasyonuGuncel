using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace OtobusOtomasyonuGuncel
{
    class DAO
    {
        public static bool Yonetici(Yonetici y)
        {
            SqlConnection con = openConnection();
            bool sonuc;
            try{
                // Sqlconnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
               // SqlConnection con = new SqlConnection("server =.;Data Source =.\\SQLEXPRESS;Initial Catalog=BUS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from Yonetici where YoneticiID =@yID and parola=@parola", con);
                cmd.Parameters.AddWithValue("@yID", y.getYoneticiID());
                cmd.Parameters.AddWithValue("@parola", y.getParola());

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception e){
                // txt dosyaya veri ekleme yapılsın
                // loglama      id,zaman,hatamesajı,metotismi
                e.Message.ToString();
                throw e;
            }
            finally
            {
                connectionClose(con);
            }
            return sonuc;
        }
        public static void connectionClose(SqlConnection con)
        {
            con.Close();
        }
        public static SqlConnection openConnection()
        {
            SqlConnection con = new SqlConnection("server =.;Data Source =.\\SQLEXPRESS;Initial Catalog=BUS;Integrated Security=True");
            try{
                con.Open();
                return con;

            }
            catch (Exception){

                throw;
            }
        }
        public static void SeferEkle(Seferler sfr){   
            SqlConnection con = openConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Seferler (Nereden,Nereye,Tarih,Saat,Tip,BiletFiyat) VALUES (@Nereden,@Nereye,@Tarih,@Saat,@Tip,@BiletFiyat)", con);
           
            cmd.Parameters.AddWithValue("@Nereden", sfr.getNereden());
            cmd.Parameters.AddWithValue("@Nereye", sfr.getNereye());
            cmd.Parameters.AddWithValue("@Tarih", sfr.getTarih());
            cmd.Parameters.AddWithValue("@Saat", sfr.getSaat());
            cmd.Parameters.AddWithValue("@Tip", sfr.getTip());
            cmd.Parameters.AddWithValue("@BiletFiyat", Convert.ToInt32(sfr.getBiletFiyat()));
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception){
                throw;
            }
            finally{
                connectionClose(con);
            }
        }

        public static void SeferSil(Seferler sfr)
        {
            //,Nereye = @Nereye,Tarih = @Tarih,Saat = @Saat.Tip@Tip,BiletFiyat = @BiletFiyat
            SqlConnection con = openConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Seferler WHERE SeferID=@SeferID", con);

            cmd.Parameters.AddWithValue("@SeferID", Convert.ToInt32(sfr.getSeferID()));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionClose(con);
            }
        }
        public static void SeferGuncelle(Seferler sfr)
        {
            SqlConnection con = openConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Seferler SET Nereden =@Nereden WHERE SeferID =@SeferID", con);
            //Nereden = @Nereden,Nereye = @Nereye,Tarih = @Tarih,Saat = @Saat,Tip = @Tip,BiletFiyat = @BiletFiyat WHERE SeferID = @SeferID
            cmd.Parameters.AddWithValue("@Nereden", sfr.getNereden());
            cmd.Parameters.AddWithValue("@Nereye", sfr.getNereye());
            cmd.Parameters.AddWithValue("@Tarih", sfr.getTarih());
            cmd.Parameters.AddWithValue("@Saat", sfr.getSaat());
            cmd.Parameters.AddWithValue("@Tip", sfr.getTip());
            cmd.Parameters.AddWithValue("@BiletFiyat", Convert.ToInt32(sfr.getBiletFiyat()));
            cmd.Parameters.AddWithValue("@SeferID", Convert.ToInt32(sfr.getSeferID()));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionClose(con);
            }
        }
        public static void FiyatGetir()
        {

        }
        public static void BiletEkle(Biletler blt)
        {
            SqlConnection con = openConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Biletler(ad,soyad,tel,cinsiyet,koltukNo,SeferID)VALUES(@ad,@soyad,@tel,@cinsiyet,@koltukNo,@SeferID)", con);

            cmd.Parameters.AddWithValue("@ad", blt.getad());
            cmd.Parameters.AddWithValue("@soyad", blt.getsoyad());
            cmd.Parameters.AddWithValue("@tel", blt.gettel());
            cmd.Parameters.AddWithValue("@cinsiyet", blt.getcinsiyet());
            cmd.Parameters.AddWithValue("@koltukNo", Convert.ToInt32(blt.getkoltukNo()));
            cmd.Parameters.AddWithValue("@SeferID", Convert.ToInt32(blt.getSeferID()));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionClose(con);
            }
        }
    }
}
