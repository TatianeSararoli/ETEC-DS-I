using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Aeronave : Veiculo
    {
        private string corFuselagem;

        public void arremeter()
        {
            Console.WriteLine("Arremeter a Aeronave");
        }

        public string getCorFuselagem()
        {
            return corFuselagem;
        }
        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }
        public override string ToString()
        {
            return "Carro {" + "Marca= " + getMarca() + ", Ano= " + getAno() + ", Pneu= " + getPneu() + " e Cor da Fuselagem= " + corFuselagem + "}";
        }
    }
}
