using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Fusca : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove o Fusca com Tração nas 2 Rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece o Fusca com Gasolina");
        }
    }
}
