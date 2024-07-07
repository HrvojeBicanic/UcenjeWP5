using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {
        //Program od korisnika ucitava ime grada i broj stanovnika
        //Ispisuje recenicu : U xxxxxx zivi xxxx ljdu
        public static void Izvedi() 
        {
            Console.WriteLine("Unesi ime grada: ");
            var grad = Console.ReadLine();
            Console.WriteLine("Unesi broj stanovnika :");
            int brojStanovnika = int.Parse(Console.ReadLine());

            //Console.WriteLine("U " + grad + " živi " + brojStanovnika + " ljudi.");
            //Console.WriteLine("U {0} živi {1} ljudi", grad, brojStanovnika);
            Console.WriteLine($"U {grad} zivi {brojStanovnika} ljudi");

        }
    }
}
