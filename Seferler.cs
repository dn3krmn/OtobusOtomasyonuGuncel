using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonuGuncel
{
    class Seferler
    {
        private int SeferID;
        private string Nereden;
        private string Nereye;
        private string Tarih;
        private string Saat;
        private string Tip;
        private int BiletFiyat ;

        public void setSeferID(int sefer)
        {
            SeferID = sefer;
        }
        public int getSeferID()
        {
            return SeferID;
        }
        public void setNereden(string nrdn)
        {
            Nereden = nrdn;
        }
        public string getNereden()
        {
            return Nereden;
        }
        public void setNereye(string nry)
        {
            Nereye = nry;
        }
        public string getNereye()
        {
            return Nereye;
        }
        public void setTarih(string trh)
        {
            Tarih = trh;
        }
        public string getTarih()
        {
            return Tarih;
        }
        public void setSaat(string st)
        {
            Saat = st;
        }
        public string getSaat()
        {
            return Saat;
        }
        public void setTip(string tip)
        {
            Tip = tip;
        }
        public string getTip()
        {
            return Tip;
        }
        public void setBiletFiyat(int bltfyt)
        {
           BiletFiyat = bltfyt ;
        }
        public int getBiletFiyat()
        {
            return BiletFiyat;
        }
    }
}
