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
            String brojevi = "0123456789";
            String interpunkcija = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            Console.Write("Unesi duljinu lozinke: ");
            int duljinaLozinke = int.Parse(Console.ReadLine());

            Console.WriteLine("Lozinka se sastoji od: ");
            Console.WriteLine("1.) Mala slova");
            Console.WriteLine("2.) Velika slova");
            Console.WriteLine("3.) Brojevi");
            Console.WriteLine("4.) Interpunkcijski znakovi");


            Console.WriteLine("Odaberi opcije (npr. 1,2,3 ili 1 3)");
            string[] odabraneOpcije = Console.ReadLine().Split(',', ' ');

            List<string> popisZnakova = new List<string>();

            foreach (string odabir in odabraneOpcije)
            {
                switch (odabir)
                {

                    case "1":
                        popisZnakova.Add(alphabetsLower);
                        break;
                    case "2":
                        popisZnakova.Add(alphabetsUpper);
                        break;
                    case "3":
                        popisZnakova.Add(brojevi);
                        break;
                    case "4":
                        popisZnakova.Add(interpunkcija);
                        break;

                }
            }




        }
    }
}

