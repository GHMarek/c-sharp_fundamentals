using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Operators
    {

        public void exF()
        {
            int result;
            int val1;
            int val2;

            val1 = 3;
            val2 = 5;

            result = val1 + val2;
            result = val1 - val2;
            result = val1 * val2;
            result = val1 / val2;
            result = val1 % val2;

            result = val1 + val2;

            Console.WriteLine($"Start: {result++}; {++result}; {result--}; {result++}");

            bool boolResult;

            boolResult = (val1 == val2);
            boolResult = (val1 > val2);
            boolResult = (val1 < val2);
            boolResult = (val1 >= val2);
            boolResult = (val1 <= val2);
            boolResult = (val1 != val2);

            bool t = true;
            bool f = false;

            boolResult = t && f;
            boolResult = t || f;
            boolResult = !t;

            // ternary operator

            boolResult = val1 > val2 ? t : f;



        }
    }
}
