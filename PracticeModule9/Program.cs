using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
        {
            new Flash("Flash1", "Kingston", 3.0, 64),
            new DVD("DVD1", "Sony", 8, "Single"),
            new HDD("HDD1", "Seagate", 2.0, 2, 500)
        };

            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            Console.WriteLine($"Total Memory: {totalMemory} GB");

            double dataSize = 565; // GB
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }

            double transferSpeed = 5;
            double time = dataSize / transferSpeed;
            Console.WriteLine($"Time required for copying: {time} seconds");

            double dataPerDevice = 780; 
            int devicesNeeded = (int)Math.Ceiling(dataSize / dataPerDevice);
            Console.WriteLine($"Number of devices needed: {devicesNeeded}");

            Console.WriteLine("\nDevice Information:");
            foreach (var device in devices)
            {
                Console.WriteLine(device.GetDeviceInfo());
            }

            Console.ReadLine();
        }
    }
}
