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
    public partial class frmExerc5 : Form
    {
        public frmExerc5()
        {
            InitializeComponent();
        }

        int numero = 0;

        private void frmExerc5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txtNumero.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int valor;
            for (valor = 1; valor <= numero; valor++)
            {
                if (numero >= 1 && numero <= 50)
                {
                    txtLista.Text = txtLista.Text + valor + "  ";
                }
                else
                {
                    txtLista.Text = "O número " + numero + " não está entre 1 e 50 !!!";
                }
            }
        }
    }
}
