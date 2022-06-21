using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace IzmirimKart
{
    public class Ogretmen:IzmirimKart
    {
        public override void Okut()
        {
            if (Bakiye >= 2)
            {
                Bakiye = Bakiye - 2;
                MessageBox.Show("2 TL Alınıyor" + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OgrtBakiyeYazdir(Control control)
        {
            control.Text = Bakiye.ToString();
        }
    }
}
