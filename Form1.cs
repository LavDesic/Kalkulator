using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string broj2 = textBox2.Text;
            Broj Broj2 = new Broj(broj2);
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

            Broj br = Broj.oduzmi(Broj1, Broj2);
            textBox3.Text = br.pretvori();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);
            //textBox3.Text = Broj1.pretvori();
        }
    }
}
