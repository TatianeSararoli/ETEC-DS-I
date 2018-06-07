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
    public partial class frmExerc4 : Form
    {
        public frmExerc4()
        {
            InitializeComponent();
        }

        int mes = 0;

        private void frmExerc4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            mes = Convert.ToInt32(txtMes.Text);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            if (mes == 1)
            {
                lblMesCorr.Text = "Janeiro";
            }
            else if (mes == 2)
            {
                lblMesCorr.Text = "Fevereiro";
            }
            else if (mes == 3)
            {
                lblMesCorr.Text = "Março";
            }
            else if (mes == 4)
            {
                lblMesCorr.Text = "Abril";
            }
            else if (mes == 5)
            {
                lblMesCorr.Text = "Maio";
            }
            else if (mes == 6)
            {
                lblMesCorr.Text = "Junho";
            }
            else if (mes == 7)
            {
                lblMesCorr.Text = "Julho";
            }
            else if (mes == 8)
            {
                lblMesCorr.Text = "Agosto";
            }
            else if (mes == 9)
            {
                lblMesCorr.Text = "Setembro";
            }
            else if (mes == 10)
            {
                lblMesCorr.Text = "Outubro";
            }
            else if (mes == 11)
            {
                lblMesCorr.Text = "Novembro";
            }
            else if (mes == 12)
            {
                lblMesCorr.Text = "Dezembro";
            }
            else
            {
                lblMesCorr.Text = "Não existe mês com este número";
            }
        }
    }
}
