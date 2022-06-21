using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace IzmirimKart
{
    public class Ogrenci : IzmirimKart
    {
        public override void Okut()
        {
            if (Bakiye >= 1)
            {
                Bakiye--;
                MessageBox.Show("1 TL Alınıyor." + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        public void BakiyeYazdir(Control control)
        {
            control.Text = Bakiye.ToString();
        }
    }
}
