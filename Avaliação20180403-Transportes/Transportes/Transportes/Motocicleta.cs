using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Motocicleta : Veiculo
    {
        private string corMotocicleta;

        public string getCorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setCorMotocicleta(string corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }
        public override string ToString()
        {
            return "Carro {" + "Marca= " + getMarca() + ", Ano= " + getAno() + ", Pneu= " + getPneu() + " e Cor da Motocicleta= " + corMotocicleta + "}";
        }
    }
}
