using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {
        // program od korisnika trazi unos cijelog broja
        // program ispisuje da li je uneseni broj paran ili ne
        public static void Izvedi()
        {
            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj " + broj + " je paran");
            }
            else
            {
                Console.WriteLine("Broj " + broj + " je neparan");
            }

            Console.WriteLine(broj % 2 == 0 ? "Paran" : "Ne paran");


        }
    }
}
