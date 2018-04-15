using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario
{
    class Comissionado : Empregado
    {
        private float totalVenda;
        private float taxaComissao;

        public override float vencimento()
        {
            float vcto = totalVenda * taxaComissao;
            return vcto;
        }

        public float getTotalVenda()
        {
            return totalVenda;
        }
        public void setTotalVenda(float totalVenda)
        {
            this.totalVenda = totalVenda;
        }
        public float getTaxaComissao()
        {
            return taxaComissao;
        }
        public void setTaxaComissao(float taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public override string ToString()
        {
            return "Comissionado: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Total das Vendas= " + totalVenda + ", Taxa da Comissão= " + taxaComissao + ", Vencimentos Totais: " + vencimento() + ".";
        }
    }
}
