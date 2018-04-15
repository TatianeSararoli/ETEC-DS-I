using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Assalariado empregado1 = new Assalariado();
            Comissionado empregado2 = new Comissionado();
            Horista empregado3 = new Horista();
            Assalariado empregado4 = new Assalariado();
            Comissionado empregado5 = new Comissionado();
            Horista empregado6 = new Horista();

            empregado1.setNome("Amanda");
            empregado1.setSobrenome("Aparecida");
            empregado1.setCPF("111.111.111-11");
            empregado1.setSalario(1000f);
            empregado1.vencimento();
            empregado1.atraso(9);
            empregado1.atraso("Atestado");
            empregado1.atraso(true);
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

            empregado4.setNome("Cesar");
            empregado4.setSobrenome("Silva");
            empregado4.setCPF("444.444.444-44");
            empregado4.setSalario(4000f);
            empregado4.vencimento();
            empregado4.atraso(10);
            empregado4.atraso("Reunião");
            empregado4.atraso(true);
            Console.WriteLine(empregado4.ToString());
            Console.WriteLine();

            empregado5.setNome("Maria");
            empregado5.setSobrenome("Antônia");
            empregado5.setCPF("555.555.555-55");
            empregado5.setTotalVenda(5000f);
            empregado5.setTaxaComissao(5f);
            empregado5.vencimento();
            Console.WriteLine(empregado5.ToString());
            Console.WriteLine();

            empregado6.setNome("José");
            empregado6.setSobrenome("Carlos");
            empregado6.setCPF("666.666.666-66");
            empregado6.setPrecoHora(60);
            empregado6.setHorasTrabalhadas(60);
            empregado6.vencimento();
            Console.WriteLine(empregado6.ToString());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
