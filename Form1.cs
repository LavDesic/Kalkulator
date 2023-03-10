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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);
            //textBox3.Text = Broj1.pretvori();
        }
    }
}
