using Hoorcollege.week2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoorcolleges
{
    class Program
    {
        static void Main(string[] args)
        {
            //AgeCalculator calcy = new AgeCalculator();
            //calcy.Calculate();

            //Voorbeeld hoorcollege
            var namen = new List<String>() { "STijn", "Bart", "Erik", "Bram", "Suzanne" };
            var namen_startB_linq = from naam in namen where naam[0] == 'B' select naam;
            var namen_startB_lambda = namen.Where(naam => naam[0] == 'B');
            var namen_start_linq_delegate = namen.Where(EersteLetterB); 

            //Extra voorbeeld lange linq
            var garage = new Garage();
            garage.RenderOverview();

            Console.ReadLine();
        }

        static public Boolean EersteLetterB(string i)
        {
            return i[0] == 'B';
        }
    }
}
