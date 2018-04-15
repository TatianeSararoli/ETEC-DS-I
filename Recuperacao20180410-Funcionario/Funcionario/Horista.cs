using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario
{
    class Horista : Empregado
    {
        private float precoHora;
        private float horasTrabalhadas;

        public override float vencimento()
        {
            float vcto = precoHora * horasTrabalhadas;
            return vcto;
        }

        public float getPrecoHora()
        {
            return precoHora;
        }
        public void setPrecoHora(float precoHora)
        {
            this.precoHora = precoHora;
        }
        public float getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(float horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override string ToString()
        {
            return "Horista: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Preço das Horas= " + precoHora + ", Horas Trabalhadas= " + horasTrabalhadas + ", Vencimentos Totais: " + vencimento() + ".";
        }

        
    }
}
