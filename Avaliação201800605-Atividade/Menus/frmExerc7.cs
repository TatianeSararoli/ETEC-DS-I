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
    public partial class frmExerc7 : Form
    {
        public frmExerc7()
        {
            InitializeComponent();
        }

        double arlindo = 1.5;
        double manoel = 1.1;
        double anos = 0;

        private void frmExerc7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            do
            {
                arlindo = arlindo + 0.02;
                manoel = manoel + 0.03;
                anos ++;
            }
            while (manoel <= arlindo);
            {
                lblResposta.Text = "Serão necessários " + anos + " anos !!!";
            }
        }
    }
}
