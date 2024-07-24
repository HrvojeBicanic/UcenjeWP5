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
            static string GetRandomCharacters(Random ran, String characters)
            {
                int radnomNumber = ran.Next(0, characters.Length);
                return characters[radnomNumber].ToString();
            }



            Random ran = new Random();
            String alphabetsLower = "abcdefghijklmnopqrstuvwxyz";
            String alphabetsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String numbers = "0123456789";
            String interpuction = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";


            Console.Write("Unesi duljinu lozinke: ");
            int passwordLenght = int.Parse(Console.ReadLine());



            Console.WriteLine("Lozinka se sastoji od: ");
            Console.WriteLine("1.) Mala slova");
            Console.WriteLine("2.) Velika slova");
            Console.WriteLine("3.) Brojevi");
            Console.WriteLine("4.) Interpunkcijski znakovi");


            Console.WriteLine("Odaberi opcije (npr. 1,2,3 ili 1 3)");
            string[] odabraneOpcije = Console.ReadLine().Split(',', ' ');

            for (int i = 0; i < odabraneOpcije.Length; i++)
            {
                if (odabraneOpcije[i] == "1")
                {
                    for (int j = 0; j < (passwordLenght / odabraneOpcije.Length); j++)
                    {
                        Console.Write(GetRandomCharacters (ran, alphabetsLower));

                    }

                }else if (odabraneOpcije[i] == "2")
                {
                    for (int j = 0; j < passwordLenght; j++)
                    {
                        Console.Write(GetRandomCharacters(ran, alphabetsUpper));

                    }

                }

            }































            /* foreach (string odabir in odabraneOpcije)
             * List<string> popisZnakova = new List<string>();
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
            StringBuilder random = new StringBuilder();
           */
        }
    }
}

