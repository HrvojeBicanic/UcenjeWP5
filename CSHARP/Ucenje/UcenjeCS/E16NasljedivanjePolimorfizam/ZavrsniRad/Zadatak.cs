using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Zadatak
    {

        /*
         * 
         * Kreirati klase prema ERA dijagramu Vaše baze podataka
         * Implementirati nasljeđivanje i prepisati metodu ToString
         * 
         * Za svaku klasu napraviti po jedan konstruktor
         * 
         * Svaku klasu instancirati u ovoj klasu
         * 
         */

        public Zadatak()
        {
            //ovdje instancirati svaku kreiranu klasu jednom i dodjeliti svim svojstvima vrijednosti

            var korisnik = new Korisnik(1, "Hrvoje", "Bicanic", "096545787", "ejovrh@email.com", "password");

            var teren = new Teren(1, "Lokosi", "Nogomet");

            var termin = new Termin(1, korisnik, DateTime.Now, DateTime.Now, teren, decimal);

            
            
            
        }

    }
}