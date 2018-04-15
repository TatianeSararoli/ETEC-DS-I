using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Embarcacao : Veiculo
    {
        private string corCasco;

        public void ancorar()
        {
            Console.WriteLine("Ancorar a Embarcação");
        }

        public string getCorCasco()
        {
            return corCasco;
        }
        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }
        public override string ToString()
        {
            return "Carro {" + "Marca= " + getMarca() + ", Ano= " + getAno() + ", Pneu= " + getPneu() + " e Cor do Casco= " + corCasco + "}";
        }
    }
}
