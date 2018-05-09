using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void frmMaiorValorDeTres_Load(object sender, EventArgs e)
        {

        }

        private void lblValorA_Click(object sender, EventArgs e)
        {

        }

        private void lblValorB_Click(object sender, EventArgs e)
        {

        }

        private void lblValorC_Click(object sender, EventArgs e)
        {

        }

        private void txbValorA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbValorB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbValorC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);
            double ValorC = System.Convert.ToDouble(txbValorC.Text);

            if (ValorA > ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "O Maior Valor é A";
            }
            else if (ValorB > ValorA && ValorB > ValorC)
            {
                lblResposta.Text = "O Maior Valor é B";
            }
            else if (ValorC > ValorB && ValorC > ValorA)
            {
                lblResposta.Text = "O Maior Valor é C";
            }
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
