using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignmentInterface
{
    public class Laptop : IConnectable, IRechargable, IDisplayable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int BatteryLevel { get; set; }

        public bool Connect()
        {
            Console.WriteLine("Laptop connected successfully!");
            return true;
        }

        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"Laptop charged for {minutes} minutes.");
        }

        public string Display()
        {
            return $"Laptop Details: {Manufacturer} {Model}, Battery Level: {BatteryLevel}%";
        }
    }
}
