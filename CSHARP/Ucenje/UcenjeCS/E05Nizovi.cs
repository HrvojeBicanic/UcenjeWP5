using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {

            int temp1, temp2, t3, t4; // --> ovo je lose 

            // Arrays
            int[] temperature = new int[12]; //najveci problem nizova je sto na pocetku moram znati koliko imam elemenata

            //nozivoi pocinju s indexom 0
            //1. elemenmnt niza je na indexu 0
            temperature[0] = -2; // sijecanj
            temperature[1] = 0;
            //..
            temperature[11] = -3;// prosinac

            //duzina niza
            Console.WriteLine(temperature.Length); //ukupan broj elemenata

            //zadnji se u pravilu postavlja ovako
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]); // 0

            //temperature[12] = 1; -> greska prilikom izvodenja 

            Console.WriteLine(temperature);


            //ispisati sve elemente niza
            Console.WriteLine(string.Join(",", temperature));

            //skraceniji nacin
            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            //ispisati 56
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo", "Belisce" };

            //ispisati zadnji grad

            Console.WriteLine(gradovi[gradovi.Length - 1]);


            int[,] tablica = {
            { 1,2,3 },
            { 4,5,6 },
            { 7,8,9 },
            };

            // ispisi 6

            Console.WriteLine(tablica[1, 2]);
            Console.WriteLine(tablica[2, 2]);

            //tesarekt - 4 dimenzije

            int[,,,] tesarekt = { };

            //multiverse
            int[,,,,,,] multiverse = { };

            //nozivoi mogu imati i razlicite tipove podataka

            object[] objekti = { "ovo", 3, 2.6, true};


        }
    }
}
