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
    public partial class frmExerc3 : Form
    {
        public frmExerc3()
        {
            InitializeComponent();
        }

        double valorA, valorB, valorC;

        private void frmExerc3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valorA = Convert.ToDouble(txtValorA.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            valorB = Convert.ToDouble(txtValorB.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            valorC = Convert.ToDouble(txtValorC.Text);
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            if (valorA < valorB + valorC && valorB < valorA + valorC && valorC < valorA + valorB)
            {
                if (valorA == valorB && valorB == valorC)
                    lblTriangulo.Text = "TRIÂNGULO EQUILÁTERO";
                else
                    if (valorA == valorB || valorB == valorC || valorC == valorA)
                        lblTriangulo.Text = "TRIÂNGULO ISÓSCELES";
                    else
                        lblTriangulo.Text = "TRIÂNGULO ESCALENO";
            }
            else
                lblTriangulo.Text = "NÃO FORMA TRIÂNGULO !!!";
        }
    }
}
