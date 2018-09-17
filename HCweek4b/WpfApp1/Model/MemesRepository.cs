using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class MemesRepository
    {
        private List<Meme> _memes;

        public MemesRepository()
        {
            _memes = new List<Meme>()
            {
                new Meme() { Naam = "Bad Luck Brian"},
                new Meme() { Naam = "SAP"},
                new Meme() { Naam = "Overly attached GF"},
                new Meme() { Naam = "Kokosnoten zijn geen spees-r-eien"}
            };
        }

        public List<MeMeVM> GetHottestMemes()
        {
            return _memes.Select(m => new MeMeVM(m)).ToList();
        }
    }
}
