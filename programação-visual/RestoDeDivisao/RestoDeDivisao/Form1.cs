using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDeDivisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(num1.Text);
            int divisor = Convert.ToInt32(num2.Text);
            int r = dividendo % divisor;
            resto.Text = r.ToString();
        }
    }
}
