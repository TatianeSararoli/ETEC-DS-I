using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        public virtual void locomover()
        {
            Console.WriteLine("Animal Locomoveu-se !!!"); ;
        }
        public virtual void alimentar()
        {
            Console.WriteLine("Animal Alimentou-se !!!");
        }
        public virtual void emitirSom()
        {
            Console.WriteLine("Animal Emitiu Som !!!");
        }

        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public override string ToString()
        {
            return "Animal: " + "peso= " + peso + ", idade= " + idade + ", membros= " + membros + '.';
        }
    }
}
