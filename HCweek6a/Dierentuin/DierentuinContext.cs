using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class DierentuinContext : DbContext
    {
        public DierentuinContext() : base("name=default")
        {

        }

        public DbSet<Dier> Dieren { get; set; }
        public DbSet<Verblijf> Hokken { get; set; }
    }
}
