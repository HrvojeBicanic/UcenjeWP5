using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E14GeneratorLozinki
    {
        internal static void Izvedi()
        {

            Random ran = new Random();
            String alphabetsLower = "abcdefghijklmnopqrstuvwxyz";
            String alphabetsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int duljinaLozinke = int.Parse(Console.ReadLine());



            Console.WriteLine("Velika/Mala");
            string font = Console.ReadLine();
            String random = "";


            if (font == "Mala")
            {
                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(alphabetsLower.Length);
                    random += alphabetsLower[index];


                }

                Console.WriteLine($"Lozinka: {random}");
                Console.ReadLine();

            }
            else if (font == "Velika" )
            {

                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(alphabetsUpper.Length);
                    random += alphabetsUpper[index];

                }

                Console.WriteLine($"Lozinka: {random}");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Odaberi font:");
                
            }



        }
    }
}

