using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, dolar, conversao;

            Console.Write("Digite o valor em R$ a ser Convertido em Dólar: R$ ");
            reais = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da Cotação do Dólar: US$ ");
            dolar = double.Parse(Console.ReadLine());

            conversao = reais / dolar;
            
            Console.WriteLine();
            Console.Write("O valor da conversão de moeda (de Reais para Dólares) é: US$ {0:N2}", conversao);

            Console.ReadKey();
        }
    }
}