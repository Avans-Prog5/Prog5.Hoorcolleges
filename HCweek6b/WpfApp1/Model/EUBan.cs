using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class EUBan
    {
        [Key]
        public int ArtikelNr { get; set; }

        public virtual ICollection<Meme> Memes { get; set; }

        public string Artiest { get; set; }
    }
}
