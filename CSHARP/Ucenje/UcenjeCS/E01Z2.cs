using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z2
    {
        //Korisnik ce unjeti dvoznamenkasti brojk
        //ispisuje se prva znamenka
        //56 => 5
        //11 => 1
        public static void Izvedi() 
        {
            int i = 22;
            Console.WriteLine(i);
            string s = i .ToString();
            Console.WriteLine(s[0]);

        } 
    }
}
