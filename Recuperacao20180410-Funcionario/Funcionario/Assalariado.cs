using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario
{
    class Assalariado : Empregado
    {
        private float salario;
        
        public override float vencimento()
        {
            float vcto = salario;
            return vcto;
        }

        public float getSalario()
        {
            return salario;
        }
        public void setSalario(float salario)
        {
            this.salario = salario;
        }

        public void atraso(float hora)
        {
            if (hora >= 7 && hora < 8)
            {
                Console.WriteLine("Chegou Adiantado - Hora Extra (de 7:00 às 8:00)");
            }
            else if (hora >= 8 && hora <= 18)
            {
                Console.WriteLine("Chegou fora do Horário Normal de Trabalho (de 08:00 às 18:00)");
            }
            else if (hora > 18 && hora <= 20)
            {
                Console.WriteLine("Hora Extra (de 18:00 às 20:00)");
            }
            else
            {
                Console.WriteLine("Atenção: Fora do Horário de Expediente !!!");
            }
        }

        public void atraso(string tolerancia)
        {
            if (tolerancia == "Atestado")
            {
                Console.WriteLine("Atestado Médico");
            }
            else if (tolerancia == "Reunião")
            {
                Console.WriteLine("Reunião Externa");
            }
            else
            {
                Console.WriteLine("Atraso Fora da Tolerância e será Descontado !!!");
            }
        }
                
        public void atraso(bool opcao)
        {
            if (opcao == true)
            {
                Console.WriteLine("Apresentou Atestado e não será Descontado !!!");
            }
            else
            {
                Console.WriteLine("Sem Atestado e será Descontado !!!");
            }
        }
        
        public override string ToString()
        {
            return "Assalariado: " + "Nome= " + getNome() + ", Sobrenome= " + getSobrenome() + ", CPF= " + getCPF() + ", Salário= " + getSalario() + ", Vencimentos Totais: " + vencimento() + ".";
        }
    }
}
