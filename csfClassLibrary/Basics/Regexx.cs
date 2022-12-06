using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Regexx
    {

        // https://regexr.com/
        // https://cheatography.com/davechild/cheat-sheets/regular-expressions/
        // https://www.c-sharpcorner.com/article/c-sharp-regex-examples/
        public static void exF()
        {

        }
        /// <summary>
        /// Mini asgnt.: check if email address is correct.
        /// </summary>
        public static void assignmentF()
        {
            string[] emailArr = new string[] { "email@gmail.com", "emai#l@gmail.com", "email@gmail.", ".email@gmail.com", "$%asdasda@@@gmail.com" };

            string pattern = @"(^\w)([a-z 0-9 A-Z (.)]+)(@)([a-z 0-9 A-Z]+)[(.)](...)";
            Regex rg = new Regex(pattern);

            foreach (var item in emailArr)
            {
                string ans = rg.IsMatch(item) ? $"{item} is match" : $"{item} is not match";

                Console.WriteLine(ans);
            }
        
        }
    }
}
