using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Korisnik : Entitet
    {
        public string? Ime { get; set; }

        public string? Prezime { get; set; }

        public string? BrojMobitela { get; set; }

        public string? Email { get; set; }

        public string? Lozinka { get; set; }

        public Korisnik() { }

        public Korisnik (int id, string? ime, string? prezime, string? brojMobitela, string? email, string? lozinka ) 
        {
            base.ID = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojMobitela = brojMobitela;
            this.Email = email;
            this.Lozinka = lozinka;
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Ime);
            sb.Append(Prezime);
            sb.Append(BrojMobitela);
            sb.Append(Email);
            sb.Append(Lozinka);

            return sb.ToString();
        }
    }
}
