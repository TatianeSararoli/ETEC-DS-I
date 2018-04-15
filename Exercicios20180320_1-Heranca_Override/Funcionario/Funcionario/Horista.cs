using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;
        
        public override double vencimento()
        {
            double vcto = precoHora * horasTrabalhadas;
            return vcto;
        }
        
        public double getPrecoHora()
        {
            return precoHora;
        }
        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;

        }
        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;

        }
        public override string ToString()
        {
            return "Horista: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Preço das Horas= " + precoHora + ", Horas Trabalhadas= " + horasTrabalhadas + ", Vencimentos Totais: " + vencimento() + ".";
        }

    }
}
