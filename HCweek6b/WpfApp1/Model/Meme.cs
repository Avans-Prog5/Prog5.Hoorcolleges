using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1.Model
{
    public class Meme
    {
        [Key]
        public int Id { get; set; }

        public Meme()
        {
            this.EUBan_ArtikelNr = null;
        }

        public string Naam { get; set; }

        public string Artiest { get; set; }

        public int? EUBan_ArtikelNr { get; set; }

        [ForeignKey("EUBan_ArtikelNr")]
        public virtual EUBan Ban { get; set; }
    }
}