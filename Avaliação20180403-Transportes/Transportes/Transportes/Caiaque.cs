using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Caiaque : Embarcacao
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove o Caiaque com Remo");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece o Caiaque com Diesel");
        }
    }
}
