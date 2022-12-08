using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.CollectionBasics
{
    
    public class ExampleYield
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        IEnumerable<int> Fibonacci(int n)
        {
            var vals = new List<int>();

            for (int i = 0, n1 = 0, n2 = 1; i < n; i++)
            {
                int fib = n1 + n2;

                n1 = n2;

                vals.Add(fib);
                n2 = fib;
            }

            return vals;
        }

        IEnumerable<int> FibonacciYield(int n)
        {
            for (int i = 0, n1 = 0, n2 = 1; i < n; i++)
            {
                yield return n1;
                
                //if (n1 > 100) { yield break; }

                int temp = n1 + n2;
                n1 = n2;

                n2 = temp;
            }
        }
        public void exF()
        {
            Console.WriteLine("return");
            int fibLen = 100;

            var data = Fibonacci(fibLen);

            stopwatch.Start();
            foreach (int e in data)
            {
                Console.WriteLine(e);
            }

            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("yield return");

            stopwatch.Start();
            foreach (int e in FibonacciYield(fibLen))
            {
                Console.WriteLine(e);
            }
            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}
