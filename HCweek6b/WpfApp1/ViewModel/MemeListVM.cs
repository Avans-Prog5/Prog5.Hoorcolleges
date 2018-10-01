using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1
{
    public class MeMeListVM : ViewModelBase
    {
        private MemesRepository _repo;

        public ObservableCollection<MeMeVM> MeMes { get; set; }

        public ICommand AddMemeCommand {get; set;}
        public RelayCommand OpenHotCommand { get; }

        public MeMeListVM()
        {
            _repo = new MemesRepository();
            var memes = _repo.GetHottestMemes(); 

            MeMes = new ObservableCollection<MeMeVM>(memes);

            AddMemeCommand = new RelayCommand(AddMeme);
            OpenHotCommand = new RelayCommand(GoToHot);
        }

        private void GoToHot()
        {
            var hot = new HotPage();
            hot.Show();
        }

        public void AddMeme()
        {
            MeMes.Add(new MeMeVM() {
                Naam = "Meme nr " + new Random().Next(1000)
            });
            
        }
    }
}
