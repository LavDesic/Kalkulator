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
            textBox3.Text = Convert.ToString(Broj2.vrednost);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string broj1 = textBox1.Text;
            Broj Broj1 = new Broj(broj1);
            textBox3.Text = Convert.ToString(Broj1.pretvori());
        }

    }
}
