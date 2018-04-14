using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;

            Console.Write("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());
            b = Math.Pow (a, 2);

            Console.WriteLine();
            Console.Write("O quadrado de {0} é: {1}", a, b);

            Console.ReadKey();
        }
    }
}
