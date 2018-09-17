using GalaSoft.MvvmLight.Command;
using HCweek2a.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HCweek2a
{
    public class BoodschappenLijstVM
    {
        public ObservableCollection<BoodschapVM> Boodschappen { get; set; }

        public ICommand AddBierCommand { get; set; }

        public ICommand ShowLijstjeCommand { get; set; }

        private BoodschappenRepository _repo;

        public BoodschappenLijstVM()
        {
            _repo = new BoodschappenRepository();
            var boodschappen = _repo.GetBoodschappen();
            this.Boodschappen = new ObservableCollection<BoodschapVM>(boodschappen);
  
            AddBierCommand = new RelayCommand(AddBier);
            ShowLijstjeCommand = new RelayCommand(ShowLijstje);
        }

        private void ShowLijstje()
        {
            var lijstje = new Lijstje();
            lijstje.Show();
        }

        public void AddBier()
        {
            this.Boodschappen.Add(new BoodschapVM() { Naam = "Bier", Aantal = 1 });
        }
    }
}
