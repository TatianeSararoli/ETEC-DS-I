using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraTradicional
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        string operacao = "";
        bool temOperacao = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            if ((txtResultado.Text == "0") || (temOperacao))
                txtResultado.Clear();

            temOperacao = false;
            Button btn = (Button) sender;
            txtResultado.Text = txtResultado.Text + btn.Text;
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultado != 0)
            {
                btnIgual.PerformClick();
                operacao = btn.Text;
                lblHistorico.Text = resultado + " " + operacao;
                temOperacao = true;
            }
            else
            {
                operacao = btn.Text;
                resultado = double.Parse(txtResultado.Text);
                lblHistorico.Text = resultado + " " + operacao;
                temOperacao = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+":
                    txtResultado.Text = (resultado + double.Parse(txtResultado.Text)).ToString();
                    break;
                case "-":
                    txtResultado.Text = (resultado - double.Parse(txtResultado.Text)).ToString();
                    break;
                case "*":
                    txtResultado.Text = (resultado * double.Parse(txtResultado.Text)).ToString();
                    break;
                case "/":
                    txtResultado.Text = (resultado / double.Parse(txtResultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultado = double.Parse(txtResultado.Text);
            lblHistorico.Text = lblHistorico.Text + txtResultado.Text + " = " + resultado;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblHistorico.Text = " ";
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblHistorico.Text = " ";
            resultado = 0;
        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {

        }
    }
}
