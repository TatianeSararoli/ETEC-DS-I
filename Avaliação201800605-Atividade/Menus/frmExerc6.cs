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
    public partial class frmExerc6 : Form
    {
        public frmExerc6()
        {
            InitializeComponent();
        }

        int vezes = 0;
        
        private void frmExerc6_FormClosing(object sender, FormClosingEventArgs e)
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
            vezes = Convert.ToInt32(txtNumero.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (n = 1; n <= vezes; n ++)
            {
                txtLista.Text += "BRASIL ";
            }
        }
    }
}
