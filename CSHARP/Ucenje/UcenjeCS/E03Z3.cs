using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {


        // program od korisnika trazi unos dva cijela broja
        // program ispisuje manji
        public static void Izvedi() 
        {
            Console.WriteLine("Unesi dva cijela broja");
            int brojJedan = int.Parse(Console.ReadLine());
            int brojDva = int.Parse(Console.ReadLine());
            if (brojJedan < brojDva)
            {
                Console.WriteLine("Manji broj je: " + brojJedan);
            }
            else 
            {
                Console.WriteLine("Manji broj je ;"  );
            }
        }
    }
}
