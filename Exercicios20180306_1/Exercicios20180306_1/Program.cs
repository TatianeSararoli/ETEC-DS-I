using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios20180306_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            string cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write(nome + ", digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da Cidade que você nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n***Informações Digitadas*** \n");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Cidade que reside: " + cidade);
            Console.WriteLine("\n");
            Console.WriteLine("{0} tem {1} anos de idade e reside na cidade de {2}", nome, idade, cidade);

            Console.ReadKey();

        }
    }
}
