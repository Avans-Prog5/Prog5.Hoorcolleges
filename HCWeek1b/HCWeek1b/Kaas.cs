using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCWeek1b
{
    class Kaas
    {
        private string _naam;

        public string Naam { get; set; }

        public int AantalGaatjes { get; set; }

        public bool RuiktVies { get; set; }

        public double Gewicht { get; set; }

        public DateTime Houdbaarheidsdatum { get; set; }

        public Kaas()
        {
            this.Houdbaarheidsdatum = DateTime.Now + TimeSpan.FromDays(7);
            this.RuiktVies = false;
            this.Gewicht = 200;
        }
    }
}
