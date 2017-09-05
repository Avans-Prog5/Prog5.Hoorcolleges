using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoorcollege.week2
{
    public class AgeCalculator
    {
        public int Calculate()
        {
            //1. Input van een gebruiker
            string input = Console.ReadLine();

            DateTime result;

            //2. De input omzetten naar datum
            //Je MOET het woordje out voor de 2de parameter zetten
            while (!DateTime.TryParse(input, out result))
            {
                input = Console.ReadLine();
            }

            //3. Leeftijd berekenen
            int age = DateTime.Now.Year - result.Year;

            Console.WriteLine(age);
            Console.ReadLine();
            return age;

        }
    }
}
