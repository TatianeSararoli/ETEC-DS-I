using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, RESULT;
            
            Console.Write("Digite um número para A: ");
            A = double.Parse(Console.ReadLine());
            
            Console.Write("Digite um número para B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite um número para C: ");
            C = double.Parse(Console.ReadLine());
            
            RESULT = ((Math.Pow(A, 2) * 5) - C) / (B - A % 4);
            
            Console.WriteLine();
            Console.Write("O Resultado de é: {0:N1}", RESULT);

            Console.ReadKey();
        }
    }
}
