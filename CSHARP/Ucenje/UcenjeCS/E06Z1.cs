using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1
    {
        //korisnik unos dva broja
        //program ispisuje sve brojeeve izmedu njih
        public static void Izvedi() 
        {
            int b1 = 2;
            int b2 = 78;
            int brojOd = b1<b2 ? b1 : b2;
            int brojDo = b1>b2 ? b1 : b2;   

            for (int i = brojOd; i < brojDo; i++) 
            {
                Console.WriteLine(i);

            }
        }
    }
}
