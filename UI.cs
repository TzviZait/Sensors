using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    public class UI
    {
        public  InvestigationManager agent;

        public  UI() 
        {
            this.agent = new InvestigationManager();
        }
        public void run()
        {
            Console.WriteLine("Welcome to the Sensor Management System!");
            Console.WriteLine("Please choose a sensor:");
            Console.WriteLine("1. Audio");
            Console.WriteLine("2. Thermal");
            Console.Write("Enter your choice (1 or 2): ");

            string choice = Console.ReadLine();
            Sensor sensor;
            switch (choice)
            {
                case "1":
                    sensor = new Sensor(SensorType.Audio);
                    break;
                case "2":
                    sensor = new Sensor(SensorType.Thermal);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 for Audio or 2 for Thermal.");
                    run();
                    return;
            }

            
            var (correct, total) = agent.GetMatchCount(sensor);
            Console.WriteLine($"Result: {correct}/{total}");
            if (correct == 2)
            {
                Console.WriteLine("Agent revealed! You win!");
                return;
            }
            else
            {
                run();
            }
            
        }
    }
}
