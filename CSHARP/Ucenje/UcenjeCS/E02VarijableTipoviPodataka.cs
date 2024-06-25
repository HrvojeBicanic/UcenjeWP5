using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {


        public static void Izvedi()
        {

            // deklaracija varijable
            int i;

            // dodjeljivanje vrijednoti - operator dodjeljivanja =
            i = 7;

            // korištenje varijable 
            Console.WriteLine(i);

            // učitanje broja od korisnika
            // procitati https://blogoscoped.com/archive/2005-08-24-n14.html

            Console.Write("Molim upisati cijeli broj veci od nule: ");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine(broj + 1);

            // za decimalne brojeve cemo koristiti float

            Console.Write("Unesi decimalni broj (. je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);

            // logicka vrijednost

            bool uvjet = false;

            Console.WriteLine(uvjet);

            // operatori za rad s varijablama
            // =, +, -, * /
            // == operator usporedivanja, tipa bool
            // != razlicito, tipa bool

            int j = 3;

            Console.WriteLine(j == 3);
            Console.WriteLine(j != 6);

            // increment i dekrement

            i = 0;
            i = i + 1; // skraceni i + =1 ili i++ ili ++i
            // i++ prvo uvecaj pa korisi
            // ++i prvo koristi pa uvecaj

            i = 1;
            Console.WriteLine(i++);//1
            Console.WriteLine(i); //2
            Console.WriteLine(++i); //3
            Console.WriteLine(i); //3

            // dekrement je ista stvar samo u minus

            i--;
            --i;

            // prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y;// x = 0,  y = 1
            y = x-- + y; // x = -1 y = 1
            Console.WriteLine(x + y); // 0

            // prvo napocetku dvosatnog vjezbanja si zadati zadatak 
            // na kraju dvosanog vjezbanja rijesiti ga

            // operator modulo 

            Console.WriteLine("9%2 = {0}", 9 % 2);
            Console.WriteLine("8%2 = {0}", 8 % 2);

            x = 5;
            y = 2;
            Console.WriteLine(x/(float)y); //(float) cast u tip podatka float

        }



    }
}
