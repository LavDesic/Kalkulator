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
            broj2 = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            broj1 = textBox1.Text;
        }

    }
}
