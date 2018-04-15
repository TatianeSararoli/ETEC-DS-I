using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Legacy450 : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("Locomove o Legacy450 com Turbina");
        }
        public override void abastecer()
        {
            Console.WriteLine("Abastece o Legacy450 com Querosene");
        }
        public void decolar(string clima)
        {
            if (clima == "sol")
            {
                Console.WriteLine("Voo Normal do Legacy450");
            }
            else if (clima == "chuva")
            {
                Console.WriteLine("Voo por Instrumento do Legacy450");
            }
            else if (clima == "nublado")
            {
                Console.WriteLine("Voo por Instrumento do Legacy450");
            }
            else if (clima == "chuva e nublado")
            {
                Console.WriteLine("Voo por Instrumento do Legacy450");
            }
            else if (clima == "neve")
            {
                Console.WriteLine("Sem Voo do Legacy450");
            }
            else
            {
                Console.WriteLine("Informação Inválida !!!");
            }
        }
        public void decolar(int hora)
        {
            if (hora >= 1 && hora <= 12)
            {
                Console.WriteLine("manhã – altitude mais alta (de 01:00 às 12:00)");
            }
            else if (hora > 12 && hora <= 18)
            {
                Console.WriteLine("tarde – altitude média (das 12:01 às 18:00)");
            }
            else if (hora > 18 && hora < 1)
            {
                Console.WriteLine("noite – altitude baixa (das 18:01 às 00:59)");
            }
            else
            {
                Console.WriteLine("Informação Inválida !!!");
            }
        }
        public void decolar(bool tipo)
        {
            if (tipo == true)
            {
                Console.WriteLine("Passageiro - Servir Refeição no Legacy450");
            }
            else
            {
                Console.WriteLine("Não Passageiro - Amarrar Bem a Carga do Legacy450");
            }
        }
        public override string ToString()
        {
            return "Legacy450 {" + "Marca= " + getMarca() + ", Ano= " + getAno() + ", Pneu= " + getPneu() + " e Cor da Fuselagem= " + getCorFuselagem() + "}";
        }
    }
}
