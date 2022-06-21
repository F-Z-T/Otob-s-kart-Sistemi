using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace IzmirimKart
{
    public class IzmirimKart
    {

        private decimal _bakiye;
        public decimal Bakiye
        {
            get { return _bakiye; }
            set { _bakiye = value;}
        }

        public virtual void Okut()
        {
            if (Bakiye >= 3)
            {
                Bakiye = Bakiye - 3;
                MessageBox.Show("3 TL Alınıyor..." + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MevcutBakiyeYazdir(Control control)
        {
             control.Text = Bakiye.ToString();
        }
        public void OkutIndirim()
        {
            if (Bakiye >= 0.1M)
            {
                Decimal indirim = 0.1M;
                Bakiye -= indirim;
                MessageBox.Show("0.10 TL Alınıyor..." + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
