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
            String numbers = "0123456789";
            String punctuation = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";



            Console.Write("Unesi duljinu lozinke: ");
            int passwordLenght = int.Parse(Console.ReadLine());



            Console.WriteLine("Lozinka se sastoji od: ");
            Console.WriteLine("1.) Mala slova");
            Console.WriteLine("2.) Velika slova");
            Console.WriteLine("3.) Brojevi");
            Console.WriteLine("4.) Interpunkcijski znakovi");


            Console.WriteLine("Odaberi opcije (npr. 1,2,3 ili 1 3)");
            List<string> optionsToChoose = new List<string>(Console.ReadLine().Split(',', ' '));


            StringBuilder password = new StringBuilder();

            foreach (var option in optionsToChoose)
            {

                switch (option)
                {
                    case "1":
                        password.Append(GetRandomCharacters(ran, alphabetsLower));
                        break;

                    case "2":
                        password.Append(GetRandomCharacters(ran, alphabetsUpper));
                        break;

                    case "3":
                        password.Append(GetRandomCharacters(ran, numbers));
                        break;

                    case "4":
                        password.Append(GetRandomCharacters(ran, punctuation));
                        break;

                }
            }
            while (password.Length < passwordLenght)
            {
                foreach (var option in optionsToChoose)
                {
                    switch (option)
                    {
                        case "1":
                            password.Append(GetRandomCharacters(ran, alphabetsLower));
                            break;

                        case "2":
                            password.Append(GetRandomCharacters(ran, alphabetsUpper));
                            break;

                        case "3":
                            password.Append(GetRandomCharacters(ran, numbers));
                            break;

                        case "4":
                            password.Append(GetRandomCharacters(ran, punctuation));
                            break;


                    }
                    if (password.Length >= passwordLenght)
                        break;
                }
            }
            Console.WriteLine($"Generated password: {password.ToString()}");

        }
        static string GetRandomCharacters(Random ran, String characters)
        {
            int randomNumber = ran.Next(0, characters.Length);
            return characters[randomNumber].ToString();

        }
    }
}
