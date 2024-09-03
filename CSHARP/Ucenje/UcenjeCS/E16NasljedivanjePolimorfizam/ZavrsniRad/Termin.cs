using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    class Termin : Entitet
    {
        public Korisnik? Korisnik { get; set; } 

        public DateTime? Pocetak { get; set; }

        public DateTime? Kraj { get; set; }

        public Teren? Teren { get; set; }

        public decimal? Cijena { get; set; }

        public Termin() { }

        public Termin(int? id, Korisnik? korisnik, DateTime? pocetak, DateTime? kraj, Teren? teren, decimal? cijena ) 
        {
            base.ID = id;
            this.Korisnik = korisnik;
            this.Pocetak = pocetak;
            this.Kraj = kraj;
            this.Teren = teren;
            this.Cijena = cijena;     
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Korisnik);
            sb.Append(Pocetak);
            sb.Append(Kraj);
            sb.Append(Teren);
            sb.Append(Cijena);

            return sb.ToString();
        }


    }
}
