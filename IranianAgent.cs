using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    public class IranianAgent 
    {
        public string rank { get; private set; }
        
        private List<string> weaknesses { get; set; }



        public IranianAgent(string rank)
        {
            this.rank = rank;
            this.weaknesses = GenerateWeaknesses();
        }
        private List<string> GenerateWeaknesses()
        {
            var sensorTypes = new List<string> { "Audio", "Thermal"};
            var random = new Random();
            var weaknesses = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                weaknesses.Add(sensorTypes[random.Next(sensorTypes.Count)]);
            }
            return weaknesses;
        }

        public static IranianAgent CreateIranianAgent(string rank)
        {
            return new IranianAgent(rank);
        }

        public List<string> GetWeaknesses()
        {
            return new List<string>(weaknesses);
        }

    }
}
