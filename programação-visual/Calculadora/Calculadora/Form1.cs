using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            String op = operacao.Text;

            double n1 = double.Parse(numUm.Text);
            double n2 = double.Parse(numDois.Text);

            double r = 0;

            switch(op)
            {
                case "adição":
                    r = n1 + n2;
                    break;
                case "subtração":
                    r = n1 - n2;
                    break;
                case "multiplicação":
                    r = n1 * n2;
                    break;
                case "divisão":
                    if(n2 != 0)
                    {
                        r = n1 / n2;
                        
                    }
                    else
                    {
                        MessageBox.Show("Operação inválida");
                        numUm.Clear();
                        numDois.Clear();
                        resul.Clear();
                    }
                    break;

            }
            resul.Text = r.ToString();


        }

        private void numUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            numUm.Clear();
            numDois.Clear();
            resul.Clear();

        }

        private void operacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void numDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
