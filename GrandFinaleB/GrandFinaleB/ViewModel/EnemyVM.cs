using System.Linq;

namespace GrandFinaleB.ViewModel
{
    public class EnemyVM
    {
        private Enemy e;

        public EnemyVM(Enemy e)
        {
            this.e = e;
        }

        public string Name
        {
            get { return e.Name;  }
            set {
                e.Name = value;
                using (var context = new GrandFinaleBEntities())
                {
                    context.Enemies.Attach(e);
                    context.Entry(e).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public string Dungeon
        {
            get { return e.Dungeon?.Name;  }
        }
    }
}