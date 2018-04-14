using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int IDADE;

            Console.Write("Digite uma Idade para verificar maioridade: ");
            IDADE = int.Parse(Console.ReadLine());

            if (IDADE < 18)
            {
                Console.Write("ATENÇÃO: MENOR DE IDADE !!!");
            }
            else
            {
                Console.Write("EXCELENTE: MAIOR DE IDADE !!!");
            }

            Console.ReadKey();
        }
    }
}
