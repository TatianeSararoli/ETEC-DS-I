using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;
        
        public override double vencimento()
        {
            double vcto = totalVenda * taxaComissao;
            return vcto;
        }

        public double getTotalVenda()
        {
            return totalVenda;
        }
        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;

        }
        public double getTaxaComissao()
        {
            return taxaComissao;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;

        }
        public override string ToString()
        {
            return "Comissionado: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Total das Vendas= " + totalVenda + ", Taxa da Comissão= " + taxaComissao + ", Vencimentos Totais: " + vencimento() + ".";
        }
    }
}
