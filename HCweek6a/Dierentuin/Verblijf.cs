using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    [Table("Verblijven")]
    class Verblijf
    {
        [Key]
        public int Nr { get; set; }

        public virtual ICollection<Dier> Dieren { get; set; }
    }
}
