using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UcenjeCS
{
    internal class E14GeneratorLozinki
    {
        internal static void Izvedi()
        {

            Random ran = new Random();
            String alphabetsLower = "abcdefghijklmnopqrstuvwxyz";
            String alphabetsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String alphabetsLowerAndUpper = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String brojevi = "0123456789";


            Console.Write("Unesi duljinu lozinke: ");
            int duljinaLozinke = int.Parse(Console.ReadLine());

            Console.WriteLine("Lozinka se sastoji od: ");
            Console.WriteLine("1.) Mala slova");
            Console.WriteLine("2.) Velika slova");
            Console.WriteLine("3.) Velika i mala slova");
            Console.WriteLine("4.) Brojevi");

            string font = "";

            while (true)
            {
                font = Console.ReadLine();
                if (font.Equals("1") || font.Equals("2") || font.Equals("3"))
                {
                    break;
                }
                Console.WriteLine($"{font}");
            }

            String random = "";

            if (font == "1")
            {
                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(alphabetsLower.Length);
                    random += alphabetsLower[index];


                }

                Console.WriteLine($"Lozinka: {random}");
                Console.ReadLine();

            }
            else if (font == "2")
            {

                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(alphabetsUpper.Length);
                    random += alphabetsUpper[index];

                }


                
            }
            else if (font == "3") 
            {
                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(alphabetsLowerAndUpper.Length);
                    random += alphabetsLowerAndUpper[index];

                }
                
            }
            else if (font == "4")
            {
                for (int i = 0; i < duljinaLozinke; i++)
                {
                    int index = ran.Next(brojevi.Length);
                    random += brojevi[index];

                }
                Console.WriteLine($"Lozinka: {random}");
                Console.ReadLine();
            }



        }
    }
}

