using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;

namespace GrandFinaleA.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<DoelVM> Doelen { get; set; }

        public MainViewModel()
        {
            using (var context = new GrandFinaleAEntities())
            {
                var doelen = context.Doels
                    .Include("Idees")
                    .ToList()
                    .Where(d => !d.IsGeheim)
                    .Select(doel => new DoelVM(doel));

                Doelen = new ObservableCollection<DoelVM>(doelen);
            }
        }
    }
}