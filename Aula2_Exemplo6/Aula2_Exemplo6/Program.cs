﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2_Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double peso;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write(nome + ", digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write(nome + ", digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\n***Informações Digitadas*** \n");
            Console.WriteLine("{0} tem {1} anos de idade e pesa {2:N3}Kg", nome, idade, peso);

            Console.ReadKey();
        }
    }
}
