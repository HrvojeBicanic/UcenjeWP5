using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {
        public static void Izvedi() 
        {

            int b1;
            int b2;
            while (true)
            {
                // Korisnik unosi dva cijel abroja i ispisuje njihov zbroj

                Console.WriteLine("Unesi prvi broj: ");
                b1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesi drugi broj: ");
                b2 = int.Parse(Console.ReadLine());
                break;
              
            }
            Console.WriteLine("Zbroj unesenih brojeva je: " + (b1 + b2));
            


        }
    }
}
