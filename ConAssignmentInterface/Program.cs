using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignmentInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
                Smartphone smartphone = new Smartphone();
                Console.WriteLine("Enter Smartphone Details:");
                Console.Write("Smartphone Brand: ");
                smartphone.Brand = Console.ReadLine();
                Console.Write("Smartphone Model: ");
                smartphone.Model = Console.ReadLine();
                Console.Write("Battery Level (0-100%): ");
                smartphone.BatteryLevel = int.Parse(Console.ReadLine());

                Laptop laptop = new Laptop();
                Console.WriteLine("\nEnter Laptop Details:");
                Console.Write("Laptop Brand: ");
                laptop.Manufacturer = Console.ReadLine();
                Console.Write("Laptop Model: ");
                laptop.Model = Console.ReadLine();
                Console.Write("Battery Level (0-100%): ");
                laptop.BatteryLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDisplay Information:");
                Console.WriteLine(smartphone.Display());
                Console.WriteLine(laptop.Display());

                Console.ReadKey();
            }
        }
    }
