using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Enum
    {
        enum Gender : byte
        {
            Male = 1,
            Female = 2
        }

        public static void exF()
        {
            Gender male = Gender.Male;
            byte female = (byte)Gender.Female;

            Console.WriteLine(female);
            Console.WriteLine(male);            

        }
    }
}
