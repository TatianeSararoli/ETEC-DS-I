using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Cachorro : Mamifero
    {
        public void enterrarOsso()
        {
            Console.WriteLine("Enterrou o osso !!!");
        }
        public void abanarRabo()
        {
            Console.WriteLine("Abanou o rabo !!!");
        }

        public string reagir(string atitude) {
            Console.WriteLine("Digite se o Cahorror está 'Agradável' ou 'Desagradável': ", atitude);
            if (atitude == "Agradável !!!")
            {
                return abanarRabo;
            }
            else
            {
                Console.WriteLine("Rosna !!!");
            }
        }
        public int reagir(int hora)
        {
            Console.WriteLine("Digite o horário atual: ", hora);
            hora = int.Parse(Console.ReadLine());

            if(hora<12){
                Console.WriteLine("Abanou o rabo e vai latir !!!");
            }
            else if(hora>=18)
            {
                Console.WriteLine("Não liga para o dono !!!");
            }
            else
            {
                return abanarRabo;
            }
        }
        public bool reagir(bool dono)
        {
            Console.WriteLine("Digite 'true' se dono do cachorro: ", dono);
            dono = bool.Parse(Console.ReadLine());
            if (dono == true)
            {
                Console.WriteLine("Abanou o rabo e quer brincar !!!");
            }
            else
            {
                Console.WriteLine("Atenção: Avança e rosna !!!");
            }
        }
    }
}
