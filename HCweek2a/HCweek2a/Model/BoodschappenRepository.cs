using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCweek2a.Model
{
    class BoodschappenRepository
    {
        private List<Boodschap> _boodschappen;
        
        public BoodschappenRepository()
        {
            this._boodschappen = new List<Boodschap>();
            this._boodschappen.Add(new Boodschap() { Naam = "Boter" });
            this._boodschappen.Add(new Boodschap() { Naam = "Kaas" });
            this._boodschappen.Add(new Boodschap() { Naam = "Eieren" });

        }

        public List<BoodschapVM> GetBoodschappen()
        {
            return _boodschappen.Select(b => new BoodschapVM(b)).ToList();
        }

    }
}
