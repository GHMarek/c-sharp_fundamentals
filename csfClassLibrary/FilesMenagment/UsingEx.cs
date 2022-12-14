using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.FilesMenagment
{
    public class UsingEx
    {
        private const string filePath = @"D:\vs projects\notatka git.txt";
        public void exF()
        {
            var readFileStream = new FileStream(filePath, FileMode.Open);
            readFileStream.Close();


            // using makes sure file will be closed, even if exception occurs
            // using can be used with any class implementing IDisposable interface
            using (var writeFileStream = new FileStream(filePath, FileMode.Open))
            {

            }
            // like this
            using (var someDisposableClass = new SomeDisposableClass())
            {
                someDisposableClass.SayHi();
            }
            
        }
    }
}
