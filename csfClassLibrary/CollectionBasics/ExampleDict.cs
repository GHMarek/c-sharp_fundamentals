using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.CollectionBasics
{
    public class ExampleDict
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();

        public void exF()
        {
            myDict.Append(new KeyValuePair<int, string>( 6, "test"));
            myDict.Add(7, "test");

        }
    }
}
