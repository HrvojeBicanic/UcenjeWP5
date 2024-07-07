using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            string grad = Console.ReadLine();

            Console.WriteLine("Unesi broj stanovnika :");

            /* Ovaj dio koda osigurava da korsinik upise broj stanovnika i grad,
             * ali ako korisnik ne upise broj program se prekida i ne trazi od korisnika ponovno da upiše broj
             * 
            if (int.TryParse(Console.ReadLine(), out int brojStanovnika))
            {
                //Console.WriteLine("U " + grad + " živi " + brojStanovnika + " ljudi.");
                //Console.WriteLine("U {0} živi {1} ljudi", grad, brojStanovnika); --> ispravno ali, donji nacin je također moguc 
                Console.WriteLine($"U {grad} zivi {brojStanovnika} ljudi");
            }
            else
            {
                Console.WriteLine("Unos nije broj");
                
            }*/

            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out int brojStanovnika))
                {
                    Console.WriteLine($"Grad {grad} ima {brojStanovnika}");
                }
                else 
                {
                    Console.WriteLine("Unos nije valjan!");
                    Console.Write("Molim unesite broj stanovnika: ");
                    continue;
                }
            
            }
        }
    }
}
