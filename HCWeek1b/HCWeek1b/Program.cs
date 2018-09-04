using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCWeek1b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kaas> kaasjes = new List<Kaas>();
            kaasjes.Add(new Kaas() { Naam = "Roch4", RuiktVies = true });
            kaasjes.Add(new Kaas() { Naam = "Gouda", Gewicht = 500 });
            kaasjes.Add(new Kaas() { Naam = "Parmazaan", Gewicht = 50 });
            kaasjes.Add(new Kaas() { Naam = "Tenekaas", RuiktVies = true, Gewicht = 10000 });

            //old skewl
            //var result = new List<Kaas>();
            //foreach(var k in kaasjes)
            //{
            //    if (k.RuiktVies)
            //        result.Add(k);
            //}

            //1. Query syntax
            //List<string> result = (from k in kaasjes
            //             where k.RuiktVies
            //             select k.Naam).ToList();

            //2. Lambda syntax

            var result = kaasjes
                .Where((Kaas p) => !p.RuiktVies)
                .ToList()
                .Select(k => k);

            DoSomething("kip");
            Console.ReadLine();

            

        }

        public static void DoSomething(String dier)
        {
            Console.WriteLine("Er danst een {0} op de gang", dier);
        }


    }
}
