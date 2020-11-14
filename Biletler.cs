using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonuGuncel
{
    class Biletler
    {
        private int BiletID;
        private String ad;
        private String soyad;
        private String tel;
        private String cinsiyet;
        private int koltukNo;
        private int SeferID;

        public void setBiletID(int bilet)
        {
            BiletID = bilet;
        }
        public int getBiletID()
        {
            return BiletID;
        }
        public void setad(string isim)
        {
           ad = isim;
        }
        public string getad()
        {
            return ad;
        }
        public void setsoyad(string soy)
        {
            soyad = soy;
        }
        public string getsoyad()
        {
            return soyad;
        }
        public void settel(string t)
        {
            tel = t;
        }
        public string gettel()
        {
            return tel;
        }
        public void setcinsiyet(string c)
        {
            cinsiyet = c;
        }
        public string getcinsiyet()
        {
            return cinsiyet;
        }
        public void setkoltukNo(int kn)
        {
            koltukNo = kn;
        }
        public int getkoltukNo()
        {
            return koltukNo;
        }
        public void setSeferID(int sfr)
        {
            SeferID = sfr;
        }
        public int getSeferID()
        {
            return SeferID;
        }

    }
}
