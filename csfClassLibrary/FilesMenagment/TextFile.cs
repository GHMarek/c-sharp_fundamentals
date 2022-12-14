using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.FilesMenagment
{
    
    public class TextFile
    {
        private const string pPath = @"D:\vs projects\";
        public void exF()
        {
            ReadFiles();
            WriteFiles("test writer");
        }

        private void ReadFiles()
        {
            
            var document1 = File.ReadAllText($@"{pPath}notatka git.txt");
            var document2 = String.Join(Environment.NewLine, document1);

            Console.WriteLine(document2);
        
        }

        private void WriteFiles(string txt)
        {
            File.WriteAllText($@"{pPath}trash.txt", txt);

            File.AppendAllText($@"{pPath}trash.txt", txt);
        }
    }
}
