using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {
        //Koristeci if
        //program ucitava ime grada. U ovisnosti od grada porogram pise regiju
        // za ostale upise program ispisuje nezz koja je regija
        /*
         * Osijek Slalvconija
         * Zadar Dalmacija
         * Cakovec medimurje
         * pula istra
         */
        
        public static void Izvedi() 
        {
            Console.Write("Unesite ime grada: ");
            string grad = Console.ReadLine();

            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else 
            {
                Console.WriteLine("Ne znam koja je to regija ");
            }
        }
    }
}
