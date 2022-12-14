using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.FilesMenagment
{
    public class SomeDisposableClass : IDisposable
    {
        public void Dispose()
        {
            // proper dispose https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
            Console.WriteLine("Disposing class");
        }

        public void SayHi()
        {
            Console.WriteLine("Say hi");
        }
    }
}
