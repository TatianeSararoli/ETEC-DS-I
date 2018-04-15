using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro veiculo1 = new Carro();
            Motocicleta veiculo2 = new Motocicleta();
            Embarcacao veiculo3 = new Embarcacao();
            Aeronave veiculo4 = new Aeronave();
            Fusca fusca = new Fusca();
            PicapeS10 picapes10 = new PicapeS10();
            Cb200 cb200 = new Cb200();
            Caiaque caiaque = new Caiaque();
            Esquilo esquilo = new Esquilo();
            Legacy450 legacy450 = new Legacy450();

            veiculo1.locomover();
            veiculo1.abastecer();
            veiculo1.setMarca("Fiat");
            veiculo1.setAno(2018);
            veiculo1.setPneu(4);
            veiculo1.setCorCarro("Verde");
            Console.WriteLine(veiculo1.ToString());
            Console.WriteLine();

            veiculo2.locomover();
            veiculo2.abastecer();
            veiculo2.setMarca("Honda");
            veiculo2.setAno(1981);
            veiculo2.setPneu(2);
            veiculo2.setCorMotocicleta("Preta");
            Console.WriteLine(veiculo2.ToString());
            Console.WriteLine();

            veiculo3.locomover();
            veiculo3.abastecer();
            veiculo3.ancorar();
            veiculo3.setMarca("Caiaker");
            veiculo3.setAno(2011);
            veiculo3.setPneu(0);
            veiculo3.setCorCasco("Prata");
            Console.WriteLine(veiculo3.ToString());
            Console.WriteLine();

            veiculo4.locomover();
            veiculo4.abastecer();
            veiculo4.arremeter();
            veiculo4.setMarca("EMBRAER");
            veiculo4.setAno(2013);
            veiculo4.setPneu(6);
            veiculo4.setCorFuselagem("Branca");
            Console.WriteLine(veiculo4.ToString());
            Console.WriteLine();

            fusca.locomover();
            fusca.abastecer();
            fusca.setMarca("Volkswagen");
            fusca.setAno(1981);
            fusca.setPneu(4);
            fusca.setCorCarro("Verde");
            Console.WriteLine(fusca.ToString());
            Console.WriteLine();

            picapes10.locomover();
            picapes10.abastecer();
            picapes10.setMarca("Chevrolet");
            picapes10.setAno(2018);
            picapes10.setPneu(4);
            picapes10.setCorCarro("Branca");
            Console.WriteLine(picapes10.ToString());
            Console.WriteLine();

            cb200.locomover();
            cb200.abastecer();
            cb200.setMarca("Honda");
            cb200.setAno(1977);
            cb200.setPneu(2);
            cb200.setCorMotocicleta("Vermelha");
            Console.WriteLine(cb200.ToString());
            Console.WriteLine();

            caiaque.locomover();
            caiaque.abastecer();
            caiaque.ancorar();
            caiaque.setMarca("Caiaker");
            caiaque.setAno(2010);
            caiaque.setPneu(0);
            caiaque.setCorCasco("Laranja");
            Console.WriteLine(caiaque.ToString());
            Console.WriteLine();

            esquilo.locomover();
            esquilo.abastecer();
            esquilo.arremeter();
            esquilo.setMarca("AIRBUS HELICOPTERS");
            esquilo.setAno(2000);
            esquilo.setPneu(0);
            esquilo.setCorFuselagem("Preta");
            Console.WriteLine(esquilo.ToString());
            Console.WriteLine();

            legacy450.locomover();
            legacy450.abastecer();
            legacy450.arremeter();
            legacy450.decolar("sol");
            legacy450.decolar(15);
            legacy450.decolar(true);
            legacy450.setMarca("EMBRAER");
            legacy450.setAno(2017);
            legacy450.setPneu(6);
            legacy450.setCorFuselagem("Branca");
            Console.WriteLine(legacy450.ToString());

            Console.ReadKey();
        }
    }
}
