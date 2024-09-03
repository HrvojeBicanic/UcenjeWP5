using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Teren : Entitet
    {
        public string? NazivTerena {  get; set; }

        public string? TipTerena { get; set; }


        public Teren() { }

        public Teren(int? id, string? nazivTerena, string? tipTerena) 
        {
            base.ID = id;
            this.NazivTerena = nazivTerena;
            this.TipTerena = tipTerena;
        
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(NazivTerena);
            sb.Append(TipTerena);

            return sb.ToString();
        }

    }

    



}
