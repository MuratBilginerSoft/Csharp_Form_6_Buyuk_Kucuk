using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Büyük_Küçük_App
{
    public partial class Form1 : Form
    {
        #region Parameters

        int a, b;

        #endregion

        #region Methods

        public string BKB(int x, int y)
        {
            if (x>y)
            {
                return x.ToString();
            }

            else if (y>x)
            {
                return y.ToString();
            }

            else
            {
                return "İki Sayı Eşittir";
            }
        }

        #endregion

        #region Definitions

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Eski Kodlar

            // Bu KOdlar ilk bildiğimiz Standart Kodlamayla Yapılmıştı Yenisi Yazıldığı İçin Kapatıldı
            // Murat Bilginer 22.05.2018

            //a = int.Parse(textBox1.Text);
            //b = int.Parse(textBox2.Text);

            //if (a>b)
            //{
            //    label1.Text = a.ToString();
            //}

            //else if(b>a)
            //{
            //    label1.Text = b.ToString();
            //}

            //else
            //{
            //    label1.Text = "İki Sayı Eşittir";
            //}

            #endregion

            #region Yeni Kodlar

            // Metodlar Kavramını Öğrendik Ve Kodlamayı Güncelleştirdik

            string Sonuc;

            Sonuc = BKB(Convert.ToInt32(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = Sonuc;

            #endregion

            //label1.Text= BKB(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

        }
    }
}
