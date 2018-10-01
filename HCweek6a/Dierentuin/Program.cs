using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new DierentuinContext())
            {
                context.Hokken
                        .Include("Dieren")
                        .FirstOrDefault(h => h.Nr == 1)
                        .Dieren.ToList()
                        .ForEach(d => Console.WriteLine(d.Soort));

            }

            //resultaat.ToList().ForEach(d => Console.WriteLine(d.Soort));

            Console.ReadLine();
        }
    }
}
