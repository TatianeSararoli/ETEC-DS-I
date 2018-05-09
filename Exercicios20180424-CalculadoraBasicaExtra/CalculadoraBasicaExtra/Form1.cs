using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasicaExtra
{
    public partial class Form1 : Form
    {
        double valorA;
        double valorB;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblValorA_Click(object sender, EventArgs e)
        {

        }

        private void lblValorB_Click(object sender, EventArgs e)
        {

        }

        private void txtValorA_TextChanged(object sender, EventArgs e)
        {
            valorA = Convert.ToDouble(txtValorA.Text);
        }

        private void txtValorB_TextChanged(object sender, EventArgs e)
        {
            valorB = Convert.ToDouble(txtValorB.Text);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (valorA + valorB + "");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (valorA - valorB + "");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (valorA * valorB + "");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (valorA / valorB + "");
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
