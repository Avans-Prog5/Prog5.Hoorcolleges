using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoorcollege.Week3
{
    public class MemeListVM : ViewModelBase
    {
        public List<Meme> Memes { get; set; }

        public MemeListVM()
        {
            Memes = new List<Meme>();
            Memes.Add(new Meme() { Naam = "Trump", Categorie = "gek haar" });
            Memes.Add(new Meme() { Naam = "Grumpy cat", Categorie = "classics" });

        }
    }
}
