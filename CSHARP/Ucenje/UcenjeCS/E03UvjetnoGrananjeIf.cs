using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {



        public static void Izvedi()
        {

            int i = 8;

            bool uvjet = i == 8;

            Console.WriteLine(uvjet);

            // if radi s bool tipom poatka

            if (uvjet) {
                Console.WriteLine("Vrijednost varijable i je 8");
            }

            // Ovo je neispravno
            if (uvjet == true) { 
            
            }

            // najcecsa sintaksa
            if (i == 8) { 
            
            }

            // if ima i else granu
            if (i > 10)
            {

                Console.WriteLine("i je veci od 10");
            }
            else
            {
                Console.WriteLine("i nije veci od 10");
            }

            // if ne mora imati {} ako se if ili else odnose na jednu liniju

            if (i < 10) Console.WriteLine("i je veci od 10");
            else Console.WriteLine("i nije veci od 10");

            // puna sintaksa if narebe 
            int b = 2;
            if (b == 1)
            {

                Console.WriteLine("ne može");
            }
            else if (b > 5)
            {
                Console.WriteLine("ok");

            }   // jos moze ici nn else if djelova
            else 
            {

                Console.WriteLine("ostalo");
            }

            // operatori & i &&
            // & uvijek provjerava dva uvjeta
            // && ukoliko 1. uvjet nije zadovoljen, drugi se niti ne provjerava

            int x = 2, y = 1;

            if (x == 1 & y == 1)
            {
                Console.WriteLine("x i y su 1");
            }

            // operatori | || 

            // | provjerava oba uvjeta
            // || ukoliko je prvi uvjet zadoovoljen, ne gleda se drugi

            if (i > 1 || i == 0) 
            {
                Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            }


            // if se moze gnjezditi
            if (x == 0) 
            {
                if (x == 3) 
                {
                    int k = 9;
                    if (i > 0) 
                    {
                        Console.WriteLine("Zadovoljeno");
                    }
                }
            }

            // inline if - tercijarni operator ?
            x = 0;
            if (x == 0)
            {
                Console.WriteLine("OK");
            }
            else 
            {
                Console.WriteLine("ne");
            }

            // preduvjer he da if i else prvode istu akciju -  u ovom slucaju cw


        }
            


    }
}
