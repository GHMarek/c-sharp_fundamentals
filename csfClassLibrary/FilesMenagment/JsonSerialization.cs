using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.FilesMenagment
{
    public class JsonSerialization
    {
        public void exF()
        {
            Player zenon = newPlayer("Zenon");

            string playerSerialized = JsonConvert.SerializeObject(zenon);

            File.WriteAllText(@"D:\vs projects\trash.txt", playerSerialized);

            Player newZenon = JsonConvert.DeserializeObject<Player>(playerSerialized);


        }

        private Player newPlayer(string name)
        {

            Player x = new Player()
            {
                Name = name,
                Level = 0,
                HP = 9,
                IsAlive = true,
                Statistics = new List<Statistic>()
                {
                    new Statistic(){ Name = "Mana", Points = 14},
                    new Statistic(){ Name = "Blood", Points = 11}
                }

            };

            return x;

        }
    }
}
