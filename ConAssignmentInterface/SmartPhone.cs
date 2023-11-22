using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignmentInterface
{
    public class Smartphone : IConnectable, IRechargable, IDisplayable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int BatteryLevel { get; set; }

        public bool Connect()
        {
            Console.WriteLine("Smartphone connected successfully!");
            return true;
        }

        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"Smartphone charged for {minutes} minutes.");
        }

        public string Display()
        {
            return $"Smartphone Details: {Brand} {Model}, Battery Level: {BatteryLevel}%";
        }
    }
}
