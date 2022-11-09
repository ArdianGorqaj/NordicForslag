
using System.ComponentModel.DataAnnotations;

namespace NordicForslag.Models
{
    public class Forslag
    {
        [Key]
        public string Navn { get; set; }
        [Required]
        public string Tittel { get; set; }

        public string Forbedringsforslag { get; set; }

        public string Årsak { get; set; }

        public string Mål { get; set; }

        public string Løsning { get; set; }

        public DateTime DatoRegistrert { get; set; } = DateTime.Now;



    }
}
