using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int[] sayilar = new int[5];
            lstListe.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = sayi.Next(1, 501);
                lstListe.Items.Add(sayilar[i]);
            }

            label1.Text = ("3'e Tam Bölüen Sayılar: ");
            for (int i = 0; i < lstListe.Items.Count; i++)
            {
                if (i % 3 == 0)
                {
                    label1.Text += (" " + lstListe.Items[i]);
                }
            }

            int enbuyuk = sayilar[0];
            for (int y = 1; y < sayilar.Length; y++)
            {
                if (sayilar[y] > enbuyuk)
                {
                    enbuyuk = sayilar[y];
                }
            }
            label4.Text = ("En Büyük Sayı: " + enbuyuk);

            int endusuk = sayilar[0];
            for (int j = 1; j < sayilar.Length; j++)
            {
                if (sayilar[j] < endusuk)
                {
                    endusuk = sayilar[j];
                }
            }
            label2.Text = ("En Küçük Sayı: " + endusuk);

            int toplam = 0;
            for (int x = 0; x < lstListe.Items.Count; x++)
            {
                toplam += (int)lstListe.Items[x];
            }
            label3.Text = ("Sayıların Toplamı: " + toplam);
        }
    }
}
