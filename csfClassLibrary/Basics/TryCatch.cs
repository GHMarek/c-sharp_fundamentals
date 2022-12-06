using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class TryCatch
    {
        public static void exF()
        {
            int[] intArr = { 1, 2, 3 };

            try
            {
                var x = intArr[3];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Another exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}; stack: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Try Catch block executed");
            }

        }
    }
}
