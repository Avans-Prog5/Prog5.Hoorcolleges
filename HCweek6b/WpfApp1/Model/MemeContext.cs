using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class MemeContext : DbContext
    {
        public MemeContext() : base("name=knektie")
        {

        }

        public DbSet<Meme> Memes { get; set; }
        public DbSet<EUBan> EUBans { get; set; }
    }
}
