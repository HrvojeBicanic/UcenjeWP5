using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {
        public String? Naziv { get; set; }
        [Column("brojsati")] // ovo nuzno u vasim zavrsnim radovima nije potrebno
        public int? Tranjanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Vaucer { get; set; }
    }
}
