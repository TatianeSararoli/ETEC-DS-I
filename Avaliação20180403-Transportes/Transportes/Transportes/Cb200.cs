using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Cb200 : Motocicleta
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove a CB200 com Tração na Roda Traseira");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece a Motocicleta Dependendo da Força do Remador");
        }
    }
}
