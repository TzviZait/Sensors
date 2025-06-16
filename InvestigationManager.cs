using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    public class InvestigationManager
    {
        public List<Sensor> attachedSensors;

        private IranianAgent agent;

        private List<string> weaknessesCopy;


        public InvestigationManager()
        {
            this.attachedSensors = new List<Sensor>();
            this.agent = IranianAgent.CreateIranianAgent("Foot Soldier");
            this.weaknessesCopy = agent.GetWeaknesses();
        }

        public void AttachSensor(Sensor sensor)
        {
            attachedSensors.Add(sensor);
        }

        public (int correct, int total) GetMatchCount(Sensor sensor)
        {
            int count = 0;
            AttachSensor(sensor);
            var tempWeaknesses = new List<string>(weaknessesCopy);

             foreach (var attachedSensor in attachedSensors)
            {
                if (tempWeaknesses.Contains(attachedSensor.Type.ToString()))
                {
                    count++;
                    agent.GetWeaknesses().Remove(attachedSensor.Type.ToString());
                    tempWeaknesses.Remove(attachedSensor.Type.ToString());
                }
            }
            return (count ,weaknessesCopy.Count);

        }
    }

}
