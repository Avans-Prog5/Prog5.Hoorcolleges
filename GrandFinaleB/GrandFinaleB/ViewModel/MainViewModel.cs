using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;

namespace GrandFinaleB.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<EnemyVM> Enemies { get; set; }
      
        public MainViewModel()
        {
            using (var context = new GrandFinaleBEntities())
            {
                var enemies = context.Enemies
                    .Include("Dungeon")
                    .ToList()
                    .Select(e => new EnemyVM(e));
                Enemies = new ObservableCollection<EnemyVM>(enemies);
            }
        }
    }
}