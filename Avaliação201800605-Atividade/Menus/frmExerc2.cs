using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmExerc2 : Form
    {
        public frmExerc2()
        {
            InitializeComponent();
        }

        double valor = 0;

        private void frmExerc2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtValor.Text);
        }

        private void btnInformar_Click(object sender, EventArgs e)
        {
            if (valor % 10 == 0)
            {
                double divisao = valor / 10;
                lblDiv10.Text = "O Resultado da Divisão é " + divisao + " e é divisível por 10";
            }
            if (valor % 5 == 0)
            {
                double divisao = valor / 5;
                lblDiv5.Text = "O Resultado da Divisão é " + divisao + " e é divisível por 5";
            }
            if (valor % 2 == 0)
            {
                double divisao = valor / 2;
                lblDiv2.Text = "O Resultado da Divisão é " + divisao + " e é divisível por 2";
            }
            else
            {
                lblNaoDiv.Text = "O Resultado não é divisível por alguns deles";
            }
        }
    }
}
