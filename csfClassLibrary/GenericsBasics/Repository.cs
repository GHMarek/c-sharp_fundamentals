using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.GenericsBasics
{
    public class Repository<T>
    //public class Repository<T> where T : class
    {
        private List<T> data = new List<T>();

        public void AddElement(T element)
        {
            if (element != null)
            {
                data.Add(element);
            }
        }

        public T GetElements(int index)
        {
            if (index < data.Count)
            {
                return data[index];
            }
            else
            {
                return default(T);
            }
        }
    }
}
