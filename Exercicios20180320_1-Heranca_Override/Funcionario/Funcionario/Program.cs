using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assalariado empregado1 = new Assalariado();
            Comissionado empregado2 = new Comissionado();
            Horista empregado3 = new Horista();

            empregado1.setNome("Amanda");
            empregado1.setSobrenome("Aparecida");
            empregado1.setCPF("111.111.111-11");
            empregado1.setSalario(1000f);
            empregado1.vencimento();
            Console.WriteLine(empregado1.ToString());
            Console.WriteLine();

            empregado2.setNome("Beatriz");
            empregado2.setSobrenome("Silva");
            empregado2.setCPF("222.222.222-22");
            empregado2.setTotalVenda(2000f);
            empregado2.setTaxaComissao(2f);
            empregado2.vencimento();
            Console.WriteLine(empregado2.ToString());
            Console.WriteLine();

            empregado3.setNome("João");
            empregado3.setSobrenome("Augusto");
            empregado3.setCPF("333.333.333-33");
            empregado3.setPrecoHora(30);
            empregado3.setHorasTrabalhadas(30);
            empregado3.vencimento();
            Console.WriteLine(empregado3.ToString());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
