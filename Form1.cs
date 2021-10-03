using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        string operador;
        int a = 0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btnAdicao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnSubtracao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btnMultiplicacao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btnDivisao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));
            }
            validar = false;
        }
    }
}
