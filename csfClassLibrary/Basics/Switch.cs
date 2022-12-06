using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    class Switch
    {
        public void exF()
        {
            var expression = DateTime.Now.DayOfWeek;

            switch (expression)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    break;
            }
        }
    }
}
