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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }


        private void btnSefer_Click(object sender, EventArgs e)
        {
            Sefer s = new Sefer();
            s.Show();
        }

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            BiletSatis b = new BiletSatis();
            b.Show();
        }
    }
}
