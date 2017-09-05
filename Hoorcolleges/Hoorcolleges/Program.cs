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

            var namen = new List<String>() { "STijn", "Bart", "Erik", "Bram", "Suzanne" };

            var metB = from naam in namen where naam[0] == 'B';
        }

        static public Boolean HasFIrstLetterB(string i)
        {
            return i[0] == 'B';
        }
    }
}
