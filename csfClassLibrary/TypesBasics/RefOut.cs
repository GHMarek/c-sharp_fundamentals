using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.TypesBasics
{
    public class RefOut
    {
        public void exF(int value)
        {
            value = value * 2;

            Console.WriteLine($"exF = {value}");

        }

        public void exRefF(ref int value)
        {
            value = value * 2;

            Console.WriteLine($"exRefF = {value}");
        }

        public void IsDivisible(int value, int factor)
        {
            int reminder;

            if (IsDivisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} is divisable by {factor}. The reminder is {reminder}.");
                return;
            }

            Console.WriteLine($"{value} is not divisable by {factor}. The reminder is {reminder}.");
        }

        private bool IsDivisible(int value, int factor, out int reminder)
        {
            reminder = value % factor;

            return reminder == 0;

        }
    }
}
