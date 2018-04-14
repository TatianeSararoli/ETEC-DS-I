using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            b = a * 2;

            Console.WriteLine();
            Console.Write("O dobro de {0} é: {1}", a, b);

            Console.ReadKey();
        }
    }
}