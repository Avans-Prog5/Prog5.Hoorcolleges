using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    [Table("Dieren")]
    class Dier
    {
        [Key]
        public int Id { get; set; }
        public String Soort { get; set; }
        public Boolean IsZoogdier { get; set; }
        public int AantalPoten { get; set; }
        public int AantalHoofden { get; set; }
        public int AantalOogen { get; set; }


        public Dier()
        {
            
        }
    }
}
