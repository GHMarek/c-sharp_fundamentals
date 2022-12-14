using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.FilesMenagment
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public bool IsAlive { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
}
