using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario
{
    class Empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public virtual float vencimento()
        {
            return 1;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public string getSobrenome()
        {
            return sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        
        public string getCPF()
        {
            return cpf;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        
        public override string ToString()
        {
            return "Empregado {" + "Nome= " + nome + ", Sobrenome= " + sobrenome + " e CPF= " + cpf + "}";
        }
    }
}
