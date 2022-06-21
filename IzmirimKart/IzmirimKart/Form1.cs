using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace IzmirimKart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IzmirimKart izknt = new IzmirimKart();
        Ogrenci ogr = new Ogrenci();
        Ogretmen ogrt = new Ogretmen();

        private void btnYukle_Click(object sender, EventArgs e)
        {
            ogr.Bakiye = Convert.ToDecimal(textBox1.Text);
            ogr.BakiyeYazdir(lblKalanBakiye);

            ogrt.Bakiye = Convert.ToDecimal(textBox1.Text);
            ogrt.OgrtBakiyeYazdir(lblKalanBakiye);

            izknt.Bakiye = Convert.ToDecimal(textBox1.Text);
            izknt.MevcutBakiyeYazdir(lblKalanBakiye);
           
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (sayac > 5 && sayac < 90)
            {
                izknt.OkutIndirim();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }
            else
            {
                izknt.Okut();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {

            timer1.Start();

            if (sayac > 1 && sayac < 5)
            {
                izknt.Okut();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }
            else if (sayac > 5 && sayac < 90)
            {
                izknt.OkutIndirim();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }
            else
            {
                ogr.Okut();
                ogr.BakiyeYazdir(lblKalanBakiye);
            }
            timer1.Enabled = true;
        }


        private void btnOgretmen_Click(object sender, EventArgs e)
        {

            timer1.Start();

            if (sayac > 1 && sayac < 5)
            {
                izknt.Okut();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }
            else if (sayac > 5 && sayac < 90)
            {
                izknt.OkutIndirim();
                izknt.MevcutBakiyeYazdir(lblKalanBakiye);
            }
            else
            {
                ogrt.Okut();
                ogrt.OgrtBakiyeYazdir(lblKalanBakiye);
            }
            timer1.Enabled = true;
        }

        private void lblZaman_Click(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
             sayac++;
            lblZaman.Text = sayac.ToString();
        }
    }                                                                                          
}
