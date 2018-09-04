using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> foodsiLIKE = new List<Food>();

            foodsiLIKE.Add(new Food() { Name = "Pasta", Calories = 1000, BestBefore = DateTime.Now });
            foodsiLIKE.Add(new Food() { Name = "Frikadelle", Calories = 20000, BestBefore = new DateTime(2030, 01, 01) });
            foodsiLIKE.Add(new Food() { Name = "Appels", Calories = 1, BestBefore = new DateTime(2019, 01, 01) });
            foodsiLIKE.Add(new Food() { Name = "Kaas", Calories = 200, BestBefore = new DateTime(22, 01, 01) });

            //old skewl
            //List<Food> result = new List<Food>();

            //foreach(var f in foodsiLIKE)
            //{
            //    if (f.Calories < 1000)
            //        result.Add(f);
            //}

            //komt er zo aan!
            //var result = select  from foodsiLIKE where Calories 

            //1. linq met lambda
            foodsiLIKE
                .Where(f => f.Calories < 1000)
                .Where(f => f.BestBefore < new DateTime(2019, 01, 01))
                
                .ToList()
                .ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();

            //2. linq query syntax
            List<string> result = (from f in foodsiLIKE
                         where f.Calories < 1000
                         select f.Name)
                         .ToList();
        }


    }
}
