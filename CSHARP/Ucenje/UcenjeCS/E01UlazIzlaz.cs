using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi() 
        {
            Console.WriteLine("Hello");

            Console.Write("Upiši svoje ime: ");

            string ime  = Console.ReadLine();

            Console.WriteLine("Unjeli ste " + ime);
            // formatirani način ispisa
            Console.WriteLine("Unjeli ste {0}",ime);


            //Unesi Adsresu i grad te isisati jedno uspod drugog

            Console.WriteLine("Unesi adresu: ");
            string adresa = Console.ReadLine();
            

            Console.WriteLine("Unesi grad: ");
            string grad = Console.ReadLine();

            Console.WriteLine(grad);
            Console.WriteLine(adresa);

        }
    }
}
