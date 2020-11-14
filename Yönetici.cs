using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyonuGuncel
{
    class Yonetici
    {
        private string YoneticiID;
        private string parola;


        public void setYoneticiID(string yntcID)
        {
            YoneticiID = yntcID;
        }

        public string getYoneticiID()
        {
            return YoneticiID;
        }

        public void setParola(string pr)
        {
            parola = pr;
        }

        public string getParola()
        {
            return parola;
        }

    }
}
