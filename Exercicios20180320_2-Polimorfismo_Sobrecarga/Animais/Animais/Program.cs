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
            Mamifero mamifero1 = new Mamifero();
            Mamifero mamifero2 = new Mamifero();
            Reptil reptil1 = new Reptil();
            Reptil reptil2 = new Reptil();
            Ave ave1 = new Ave();
            Ave ave2 = new Ave();
            Canguru canguru = new Canguru();
            Cachorro cachorro = new Cachorro();
            Tartaruga tartaruga = new Tartaruga();
            Tucano tucano = new Tucano();

            mamifero1.locomover();
            mamifero1.alimentar();
            mamifero1.emitirSom();
            mamifero1.setPeso(150);
            mamifero1.setIdade(15);
            mamifero1.setMembros(4);
            mamifero1.setcorPelo("Caramelo");
            mamifero1.setraca("Leão");
            Console.WriteLine(mamifero1.ToString());

            mamifero2.locomover();
            mamifero2.alimentar();
            mamifero2.emitirSom();
            mamifero2.setPeso(100);
            mamifero2.setIdade(20);
            mamifero2.setMembros(4);
            mamifero2.setcorPelo("Preto");
            mamifero2.setraca("Chipanzé");
            Console.WriteLine(mamifero2.ToString());

            reptil1.locomover();
            reptil1.alimentar();
            reptil1.emitirSom();
            reptil1.setPeso(50);
            reptil1.setIdade(10);
            reptil1.setMembros(4);
            reptil1.setcorEscama("Azul");
            Console.WriteLine(reptil1.ToString());

            reptil2.locomover();
            reptil2.alimentar();
            reptil2.emitirSom();
            reptil2.setPeso(200);
            reptil2.setIdade(20);
            reptil2.setMembros(4);
            reptil2.setcorEscama("Verde");
            Console.WriteLine(reptil2.ToString());

            ave1.locomover();
            ave1.alimentar();
            ave1.emitirSom();
            ave2.fazerNinho();
            ave1.setPeso(10);
            ave1.setIdade(5);
            ave1.setMembros(2);
            ave1.setcorPena("Amarelo");
            Console.WriteLine(ave1.ToString());

            ave2.locomover();
            ave2.alimentar();
            ave2.emitirSom();
            ave2.fazerNinho();
            ave2.setPeso(5);
            ave2.setIdade(10);
            ave2.setMembros(2);
            ave2.setcorPena("Branca");
            Console.WriteLine(ave2.ToString());

            canguru.locomover();
            canguru.alimentar();
            canguru.emitirSom();
            canguru.usarBolsa();
            canguru.setPeso(200);
            canguru.setIdade(20);
            canguru.setMembros(2);
            canguru.setcorPelo("Caramelo");
            canguru.setraca("Canguru-Gigante");
            Console.WriteLine(canguru.ToString());

            cachorro.locomover();
            cachorro.alimentar();
            cachorro.emitirSom();
            cachorro.enterrarOsso();
            cachorro.abanarRabo();
            cachorro.setPeso(100);
            cachorro.setIdade(10);
            cachorro.setMembros(2);
            cachorro.setcorPelo("Caramelo");
            cachorro.setraca("Leão");
            Console.WriteLine(cachorro.ToString());

            tartaruga.locomover();
            tartaruga.alimentar();
            tartaruga.emitirSom();
            tartaruga.setPeso(60);
            tartaruga.setIdade(60);
            tartaruga.setMembros(2);
            tartaruga.setcorEscama("Verde");
            Console.WriteLine(tartaruga.ToString());

            tucano.locomover();
            tucano.alimentar();
            tucano.emitirSom();
            tucano.fazerNinho();
            tucano.setPeso(200);
            tucano.setIdade(20);
            tucano.setMembros(2);
            tucano.setcorPena("Branca");
            Console.WriteLine(tucano.ToString());

            Console.ReadKey();
        }
    }
}
