using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Aves : Animal
    {
        public string corPena;

        public void fazerNinho()
        {
            Console.WriteLine("Fez o Ninho !!!");
        }

        public string getcorPena()
        {
            return corPena;
        }
        public void setcorPena(string corPena)
        {
            this.corPena = corPena;
        }

        public override string ToString()
        {
            return "Aves: " + "peso= " + getPeso() + ", idade= " + getIdade() + ", membros= " + getMembros() + ", cor da pena= " + corPena + '.';
        }
    }
}
