using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Reptil : Animal
    {
        private string corEscama;

        public string getcorEscama()
        {
            return corEscama;
        }
        public void setcorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }

        public override string ToString()
        {
            return "Réptil: " + "peso= " + getPeso() + ", idade= " + getIdade() + ", membros= " + getMembros() + ", cor da escama= " + corEscama + '.';
        }
    }
}
