using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class PicapeS10 : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove a PicapeS10 com Tração nas 4 Rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece a PicapeS10 com Diesel");
        }
    }
}
