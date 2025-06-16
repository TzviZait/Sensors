using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    public enum SensorType
    {
        Audio,
        Thermal
    }

    public class Sensor
    {
        public SensorType Type { get; private set; }

        public Sensor(SensorType type)
        {
            Type = type;
        }

        public void Activate()
        {
            
        }
    }
}
