using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        //Korisnik unosi brojčanu vrijednost ocjene od 1 do 5
        //Program ispisuje slovnu ocjenu, a ako korisnik nije unosio ocjenu
        //program ispisuje broj nie ocjena

        public static void Izvedi() 
        {
            Console.WriteLine("Unesi ocjenu pd 1 do 5: ");
            int ocjena = int.Parse(Console.ReadLine());

            switch (ocjena) 
            {
                case 0:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 1:
                    Console.WriteLine("Dovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dobar");
                    break;
                case 3:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 4:
                    Console.WriteLine("Odličan");
                    break;
            
            
            }


        }
    }
}
