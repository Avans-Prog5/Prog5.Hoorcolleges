using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hoorcollege.Week3.ViewModel
{
    public class AddMemeVM : ViewModelBase
    {
        private MemeListVM _main;

        public ICommand AddCommand { get; set; }

        public AddMemeVM(MemeListVM main)
        {
            _main = main;
            Meme = new Meme();
            AddCommand = new RelayCommand(AddMeme);
        }

        public Meme Meme { get; set; }

        public void AddMeme()
        {
            _main.Memes.Add(Meme);
        }
    }
}
