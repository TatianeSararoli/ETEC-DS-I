using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2_Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o nome da Cidade que você nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n***Informações Digitadas*** \n");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Cidade de nascimento: " + cidade);

            Console.ReadKey();
        }
    }
}
