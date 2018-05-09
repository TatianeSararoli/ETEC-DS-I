using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }
        
        double bim1;
        double bim2;
        double bim3;
        double bim4;

        private void lblAluno_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl1Bim_Click(object sender, EventArgs e)
        {

        }

        private void lbl2Bim_Click(object sender, EventArgs e)
        {

        }

        private void lbl3Bim_Click(object sender, EventArgs e)
        {

        }

        private void lbl4Bim_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bim1 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bim2 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bim3 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bim4 = double.Parse(textBox5.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblMedia.Text = (bim1 + bim2 + bim3 + bim4) / 4 + "";
            lblNome.Text = textBox1.Text;
            lblMedia.Text = "Sua Média é: " + lblMedia.Text;
        }
        
        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMedia_Click(object sender, EventArgs e)
        {
            
        }
    }
}
