using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class ifElse
    {
        public void exF()
        {
            bool someBool = true;
            Console.WriteLine("Ile masz lat?");
            string userInput = Console.ReadLine();
            int yearBirth = int.Parse(userInput);

            bool isUserOver18 = DateTime.Now.Date.Year - yearBirth > 18;

            if (someBool)
            {
                Console.WriteLine("yep");
            }
            else
            {
                Console.WriteLine("nah");
            }

            if (isUserOver18)
            {
                Console.WriteLine("NSFW content for you");
            }
            else
            {
                Console.WriteLine("Return when you get older");
            }

            Console.WriteLine("Bye");

        }
    }
}
