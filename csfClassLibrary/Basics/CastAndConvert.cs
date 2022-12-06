using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class CastAndConvert
    {
        public void exF()
        {
            string userInput = Console.ReadLine();
            int yearOfBirt;
            int age;

            if (int.TryParse(userInput, out yearOfBirt))
            {
                yearOfBirt = int.Parse(userInput);
                age = DateTime.Now.Year - yearOfBirt;

                Console.WriteLine($"Your age is {age}");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            byte someByte = 100;
            Convert.ToInt32(someByte);

        }
    }
}
