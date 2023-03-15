using Singulink.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public string broj1, broj2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox12.Text != null)textBox12.Clear();
            if (Broj.ProveriRimskiRegex(textBox1.Text))
            {
                string broj2 = textBox2.Text;
                Broj Broj2 = new Broj(broj2);
            }
            else
            {
                string greska = "GRESKA";
                textBox12.Text = greska;
                textBox1.Clear();
            }
            //textBox3.Text = Convert.ToString(Broj2.vrednost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string broj2 = textBox2.Text;
            Broj Broj2 = new Broj(broj2);
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);

            Broj br = Broj.saberi(Broj1, Broj2);
            textBox3.Text = br.pretvori();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string broj2 = textBox2.Text;
            Broj Broj2 = new Broj(broj2);
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);

            if (Broj1.vrednost < Broj2.vrednost)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                Broj br = Broj.oduzmi(Broj1, Broj2);
                textBox3.Text = br.pretvori();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string broj2 = textBox2.Text;
            Broj Broj2 = new Broj(broj2);
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);

            Broj br = Broj.pomnozi(Broj1, Broj2);
            textBox3.Text = br.pretvori();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string broj2 = textBox2.Text;
            Broj Broj2 = new Broj(broj2);
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);

            Broj br = Broj.podeli(Broj1, Broj2);
            if (Broj1.vrednost % Broj2.vrednost != 0)
            {
                Broj ostatak = new Broj(Broj1.vrednost % Broj2.vrednost);
                textBox3.Text = br.pretvori() + " ( " + ostatak.pretvori() + " )";
            }
            else
            {
                textBox3.Text = br.pretvori();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kompleksni k1 = new Kompleksni(Convert.ToDouble(textBox4.Text),Convert.ToDouble(textBox5.Text));
            Kompleksni k2 = new Kompleksni(Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text));
            textBox8.Text = Kompleksni.saberi(k1, k2).ispis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kompleksni k1 = new Kompleksni(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            Kompleksni k2 = new Kompleksni(Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text));
            textBox8.Text = Kompleksni.oduzmi(k1, k2).ispis();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kompleksni k1 = new Kompleksni(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            Kompleksni k2 = new Kompleksni(Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text));
            textBox8.Text = Kompleksni.pomnozi(k1, k2).ispis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kompleksni k1 = new Kompleksni(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            Kompleksni k2 = new Kompleksni(Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text));
            textBox8.Text = Kompleksni.podeli(k1, k2).ispis();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string a = textBox11.Text;
            if (Dugacak.provera(a))
            {
                Dugacak d1 = new Dugacak(a);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string b = textBox10.Text;
            if (Dugacak.provera(b))
            {
                Dugacak d2 = new Dugacak(b);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //textBox12.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a = textBox11.Text;
            Dugacak d1 = new Dugacak();
            if (Dugacak.provera(a))
            {
                d1.broj = BigDecimal.Parse(a);
            }
            string b = textBox10.Text;
            Dugacak d2 = new Dugacak();
            if (Dugacak.provera(b))
            {
                d2.broj = BigDecimal.Parse(b);
            }
            BigDecimal rez = d1.broj + d2.broj;
            textBox9.Text = Convert.ToString(rez);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a = textBox11.Text;
            Dugacak d1 = new Dugacak();
            if (Dugacak.provera(a))
            {
                d1.broj = BigDecimal.Parse(a);
            }
            string b = textBox10.Text;
            Dugacak d2 = new Dugacak();
            if (Dugacak.provera(b))
            {
                d2.broj = BigDecimal.Parse(b);
            }
            BigDecimal rez = d1.broj - d2.broj;
            textBox9.Text = Convert.ToString(rez);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string a = textBox11.Text;
            Dugacak d1 = new Dugacak();
            if (Dugacak.provera(a))
            {
                d1.broj = BigDecimal.Parse(a);
            }
            string b = textBox10.Text;
            Dugacak d2 = new Dugacak();
            if (Dugacak.provera(b))
            {
                d2.broj = BigDecimal.Parse(b);
            }
            BigDecimal rez = d1.broj * d2.broj;
            textBox9.Text = Convert.ToString(rez);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string a = textBox11.Text;
            Dugacak d1 = new Dugacak();
            if (Dugacak.provera(a))
            {
                d1.broj = BigDecimal.Parse(a);
            }
            string b = textBox10.Text;
            Dugacak d2 = new Dugacak();
            if (Dugacak.provera(b))
            {
                d2.broj = BigDecimal.Parse(b);
            }
            BigDecimal rez = d1.broj / d2.broj;
            textBox9.Text = Convert.ToString(rez);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox12.Text != null) textBox12.Clear();
            if (Broj.ProveriRimskiRegex(textBox1.Text))
            {
                string broj1 = textBox1.Text;
                Broj Broj1 = new Broj(broj1);
            }
            else
            {
                string greska = "GRESKA";
                textBox12.Text = greska;
                textBox1.Clear();
            }
            //textBox3.Text = Broj1.pretvori();
        }
    }
}
