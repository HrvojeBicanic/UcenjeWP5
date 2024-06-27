using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {
        // program odkorisnika trazi unos broj godina koje ima korisnik
        // program i spisuje da li je korisnik punoljetan
        public static void Izvedi() 
        {
            Console.WriteLine("Unesi broj godina: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("Korisnik ima " + godine + " godina, punoljetan je");
            }
            else 
            {
                Console.WriteLine("Korisnik ima " + godine + "godina,  nije punoljetan");
            }
            if (godine < 0 | godine > 112 ) 
            {
                Console.WriteLine("Unos je ne ispravan");
            } 

        }


    }
}
