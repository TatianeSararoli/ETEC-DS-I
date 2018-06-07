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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exerc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc1 Exerc1 = new frmExerc1(); //criando uma instância do formulário Teste1
            Exerc1.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc1.Show(); //esta linah exibe o formulário Exerc1
        }

        private void exerc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc2 Exerc2 = new frmExerc2(); //criando uma instância do formulário Teste1
            Exerc2.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc2.Show(); //esta linah exibe o formulário Exerc2
        }

        private void exerc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc3 Exerc3 = new frmExerc3(); //criando uma instância do formulário Teste1
            Exerc3.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc3.Show(); //esta linah exibe o formulário Exerc3
        }

        private void exerc4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc4 Exerc4 = new frmExerc4(); //criando uma instância do formulário Teste1
            Exerc4.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc4.Show(); //esta linah exibe o formulário Exerc4
        }

        private void exerc5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc5 Exerc5 = new frmExerc5(); //criando uma instância do formulário Teste1
            Exerc5.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc5.Show(); //esta linah exibe o formulário Exerc5
        }

        private void exerc6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc6 Exerc6 = new frmExerc6(); //criando uma instância do formulário Teste1
            Exerc6.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc6.Show(); //esta linah exibe o formulário Exerc6
        }

        private void exerc7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExerc7 Exerc7 = new frmExerc7(); //criando uma instância do formulário Teste1
            Exerc7.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc7.Show(); //esta linah exibe o formulário Exerc7
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSairForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbldata_Click(object sender, EventArgs e)
        {
            lbldata.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lblhora_Click(object sender, EventArgs e)
        {
            lblhora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnForm1_Click(object sender, EventArgs e)
        {
            frmExerc1 Exerc1 = new frmExerc1(); //criando uma instância do formulário Teste1
            Exerc1.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc1.Show(); //esta linah exibe o formulário Exerc1
        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            frmExerc2 Exerc2 = new frmExerc2(); //criando uma instância do formulário Teste1
            Exerc2.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc2.Show(); //esta linah exibe o formulário Exerc2
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            frmExerc3 Exerc3 = new frmExerc3(); //criando uma instância do formulário Teste1
            Exerc3.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc3.Show(); //esta linah exibe o formulário Exerc3
        }

        private void BtnForm4_Click(object sender, EventArgs e)
        {
            frmExerc4 Exerc4 = new frmExerc4(); //criando uma instância do formulário Teste1
            Exerc4.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc4.Show(); //esta linah exibe o formulário Exerc4
        }

        private void BtnForm5_Click(object sender, EventArgs e)
        {
            frmExerc5 Exerc5 = new frmExerc5(); //criando uma instância do formulário Teste1
            Exerc5.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc5.Show(); //esta linah exibe o formulário Exerc5
        }

        private void BtnForm6_Click(object sender, EventArgs e)
        {
            frmExerc6 Exerc6 = new frmExerc6(); //criando uma instância do formulário Teste1
            Exerc6.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc6.Show(); //esta linah exibe o formulário Exerc6
        }

        private void BtnForm7_Click(object sender, EventArgs e)
        {
            frmExerc7 Exerc7 = new frmExerc7(); //criando uma instância do formulário Teste1
            Exerc7.MdiParent = this; // esta linha define que a instância do formulário criado é "filho" do formulário principal
            Exerc7.Show(); //esta linah exibe o formulário Exerc7
        }

        
    }
}
