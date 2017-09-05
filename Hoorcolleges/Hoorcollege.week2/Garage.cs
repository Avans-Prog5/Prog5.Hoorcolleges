using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoorcollege.week2
{
    public class Garage
    {
        #region 
        private List<string> _merken = new List<string>() { "Toyota", "Mercedes", "Seat", "Volkswagen", "Citroën", "Peugot" };
        private List<string> _uitvoeringen = new List<string>() { "Hatchback", "Station", "Cruiser", "Cabrio", "SUV", "Musslecar" };
        private List<int> _jaar = new List<int>() { 2004, 2008, 2011, 2013, 2015, 2017 };
        #endregion

        public List<Car> Cars { get; set; }

        /// <summary>
        /// Genereerd 10.000 random autos
        /// </summary>
        public Garage()
        {
            var r = new Random();
            this.Cars = new List<Car>();

            for (int i = 0; i < 10000; i++)
            {
                var rm = r.Next(this._merken.Count - 1);
                var ru = r.Next(this._uitvoeringen.Count - 1);
                var rj = r.Next(this._jaar.Count - 1);
                var price = r.Next(9000, 40000);
                this.Cars.Add(new Car()
                {
                    Merk = _merken[rm],
                    Jaartal = _jaar[rj],
                    Uitvoering = _uitvoeringen[ru],
                    Price = price
                });
            }
        }

        public void RenderOverview()
        {
            Cars
               .Where(car => car.Jaartal < 2011)
               .Where(car => car.Merk == "Seat")
               .OrderBy(car => car.Price)
               .GroupBy(car => car.Uitvoering)
               .ToList().ForEach(g =>
               {
                   Console.WriteLine("#### Cars from group {0 } (total {1})", g.Key, g.Count());
                   g.ToList().ForEach(c => Console.WriteLine("Year: {0}, Price: {1}", c.Jaartal, c.Price));
               });
        }
    }
}
