using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hoorcollege.Week3
{
    public class MemeListVM : ViewModelBase
    {
        public ObservableCollection<Meme> Memes { get; set; }

        public ICommand AddMemeCommand { get; set; }

        public MemeListVM()
        {
            Memes = new ObservableCollection<Meme>();
            Memes.Add(new Meme() { Naam = "Trump", Categorie = "gek haar" });
            Memes.Add(new Meme() { Naam = "Grumpy cat", Categorie = "classics" });

            AddMemeCommand = new RelayCommand(ShowAddWindow);
        }

        private void ShowAddWindow()
        {
            var window = new AddMeme();
            window.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
