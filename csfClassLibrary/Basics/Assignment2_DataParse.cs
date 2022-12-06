using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Assignment2_DataParse
    {
        /*
        Zadanie: Parsowanie daty (treść)
        Zadanie:

        Utwórz aplikację konsolową która pobierze od użytkownika datę 
        jego urodzin i na tej podstawie obliczy ile mięło dni od tej
        daty do obecnego dnia.
         */

        public static void dayDiff()
        {
            
            int y;
            int m;
            int d;

            Console.WriteLine("Type your YEAR of birth:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your MONTH of birth:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your DAY of birth:");
            d = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(y, m, d);
            int resDays;

            resDays = DateTime.Now.Subtract(dateOfBirth).Days;

            TimeSpan timeSpan = DateTime.Now.Subtract(dateOfBirth);
            
            Console.WriteLine($"Days difference = {resDays}");
        }

    }
}
