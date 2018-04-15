using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public string getcorPelo()
        {
            return corPelo;
        }
        public void setcorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }
        public string getraca()
        {
            return raca;
        }
        public void setraca(string raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "Mamífero: " + "peso= " + getPeso() + ", idade= " + getIdade() + ", membros= " + getMembros() + ", cor do pelo= " + corPelo + ", raça= " + raca + '.';
        }
    }
}
