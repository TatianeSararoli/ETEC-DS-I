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
    public partial class frmExerc1 : Form
    {
        public frmExerc1()
        {
            InitializeComponent();
        }

        double valor1 = 0;
        double valor2 = 0;
        double resultado = 0;

        private void frmExerc1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void textValor1_TextChanged(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textValor1.Text);
        }

        private void textValor2_TextChanged(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textValor2.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            resultado = valor1 + valor2;
                    
            if (resultado > 20)
            {
                lblResultado.Text = resultado + 8 + "";
            }
            else if (resultado <= 20)
            {
                lblResultado.Text = resultado - 5 + "";
            }
        }
    }
}
