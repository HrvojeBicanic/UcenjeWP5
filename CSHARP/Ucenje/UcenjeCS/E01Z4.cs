using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z4
    {
        //Koristeći ASCII art (https://www.asciiart.eu/) ispišite vama omiljenu grafiku.
        public static void Izvedi()
        {
            Console.WriteLine("Unesite dva cijela broja!");
            Console.Write("Prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());
            Console.Write("Treći broj: ");
            int treciBroj = int.Parse(Console.ReadLine());

            if (prviBroj > drugiBroj & prviBroj > treciBroj)
            {
                Console.WriteLine(prviBroj);

            }
            else if (drugiBroj > prviBroj & drugiBroj > treciBroj)
            {
                Console.WriteLine(drugiBroj);
            }
            else
            {
                Console.WriteLine(treciBroj);
            }

        }
    }
}
