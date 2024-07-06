using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        //Program unosi brojeve sve dok ne unese broj -1
        //Program ispisuje zbroj svih unesenih brojeva
        public static void Izvedi() 
        {

            Console.WriteLine("Unesi brojeve: ");
            int i = 0;
            int sum = 0;    

            while (true) 
            {
                i = int.Parse(Console.ReadLine());
                if (i == -1) 
                {
                    break;
                }
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
