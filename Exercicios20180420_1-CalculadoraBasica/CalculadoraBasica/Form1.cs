using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        double valor1;
        double valor2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbValor1_TextChanged(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txbValor1.Text);
        }

        private void txbValor2_TextChanged(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txbValor2.Text);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = valor1 + valor2 + "";
        }
        
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = valor1 - valor2 + "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblResultado.Text = valor1 * valor2 + "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = valor1 / valor2 + "";
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void lblValor2_Click(object sender, EventArgs e)
        {

        }
    }
}
