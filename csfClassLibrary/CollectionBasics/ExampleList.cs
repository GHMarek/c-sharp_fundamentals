using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.CollectionBasics
{
    public class ExampleList
    {
        

        public void exF()
        {
            List<int> listInts = new List<int>() { 5 };

            listInts.Add(6);

            listInts.AddRange(Enumerable.Range(0, 300));

            foreach (var i in listInts)
            {
                Console.WriteLine(i);
            }
            
        }

        public void DisplayElements(List<int> list)
        {
            Console.WriteLine("List");

        }
    }
}
