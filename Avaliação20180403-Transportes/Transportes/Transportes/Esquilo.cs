using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Esquilo : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove o Esquilo com Hélice");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece o Esquilo com Diesel");
        }
    }
}
