using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Assalariado : Empregado
    {
        private double salario;

        public override double vencimento()
        {
            double vcto = salario;
            return vcto;
        }

        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public override string ToString()
        {
            return "Assalariado: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Salário= " + getSalario() + ", Vencimentos Totais: " + vencimento() + ".";
        }
    }
}
