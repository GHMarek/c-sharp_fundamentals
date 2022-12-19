using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.GenericsBasics
{
    public class GenericsExample
    {
        public void exF()
        {
            var stringRepo = new Repository<string>();

            stringRepo.AddElement("some value");

            var intRepo = new Repository<int>();
            intRepo.AddElement(1);

        }
    }
}
