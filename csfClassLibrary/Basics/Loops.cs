using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Loops
    {
        public void exF()
        {
            string[] cars = new string[] { "volvo", "bmw", "Mazda" };

            int i = 0;

            while(i < cars.Length)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                i++;
                Console.WriteLine(i);

            } while (i < 10);


            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            cars.ToList().ForEach(x => Console.WriteLine(x.Length));

        }
    }
}
