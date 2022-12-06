using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Array
    {
        string[] cars = new string[] { "volvo", "bmw", "Mazda" };
        
        public void exF()
        {
            Console.WriteLine(cars[1]);
            int arrayLen = cars.Length;
            
            cars[2] = "Tesla";

        }


    }
}
