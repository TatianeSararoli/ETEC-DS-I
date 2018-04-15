using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Mamifero mamifero = new Mamifero();
            Reptil reptil = new Reptil();
            Aves aves = new Aves();

            animal.setPeso(150f);
            animal.setIdade(15);
            animal.setMembros(4);

            mamifero.setPeso(100f);
            mamifero.setIdade(10);
            mamifero.setMembros(4);
            mamifero.setcorPelo("caramelo");
            mamifero.setraca("felino");

            reptil.setPeso(50f);
            reptil.setIdade(5);
            reptil.setMembros(4);
            reptil.setcorEscama("verde");

            aves.setPeso(10f);
            aves.setIdade(1);
            aves.setMembros(2);
            aves.setcorPena("branca");

            Console.WriteLine(animal.ToString());
            Console.WriteLine(mamifero.ToString());
            Console.WriteLine(reptil.ToString());
            Console.WriteLine(aves.ToString());

            Console.ReadKey();
        }
    }
}
